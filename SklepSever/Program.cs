﻿using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Sklep.Database;
using Sklep.Database.Models;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using ZXing;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace SklepSever
{
    internal class Program
    {
        static string finalizeCart(Dictionary<string, decimal> cart)
        {
            Receipt newReceipt = new Receipt
            {
                Date = DateTime.Now.ToUniversalTime(),
                ReceiptPositions = new List<ReceiptPosition>()
            };
            using (var db = new DatabaseContext())
            {
                foreach (var item in cart)
                {
                    var product = db.Products.SingleOrDefault(p => p.Barcode == item.Key);
                    if (product == null)
                    {
                        return JsonConvert.SerializeObject(new { result = "ERROR" });
                    }

                    InventoryChange newInventoryChange = new InventoryChange
                    {
                        PositionId = product.PositionId,
                        Type = "Sprzedaż",
                        Amount = -1 * item.Value,
                        Date = DateTime.Now.ToUniversalTime(),
                    };
                    ReceiptPosition newReceiptPosition = new ReceiptPosition
                    {
                        Product = product,
                        Amount = item.Value,
                        Receipt = newReceipt
                    };
                    newReceipt.ReceiptPositions.Add(newReceiptPosition);
                    db.InventoryPositions
                        .Single(p => p.Id == newInventoryChange.PositionId)
                        .Amount -= item.Value;

                    db.InventoryChanges.Add(newInventoryChange);
                }
                db.Receipts.Add(newReceipt);
                db.SaveChanges();
            }

            return JsonConvert.SerializeObject(new { result = "OK", receiptId = newReceipt.Id });
        }

        static Dictionary<string, ProductReply> cachedProducts = new Dictionary<string, ProductReply>();
        static string GetProduct(string barcode)
        {
            if (cachedProducts.ContainsKey(barcode))
            {
                var response = new
                {
                    result = "OK",
                    data = cachedProducts[barcode]
                };
                return JsonConvert.SerializeObject(response);
            }

            using (var context = new DatabaseContext())
            {
                var product = context.Products
                    .Include(p => p.Category)
                    .SingleOrDefault(p => p.Barcode == barcode);
                if (product != null)
                {
                    var response = new
                    {
                        result = "OK",
                        data = new ProductReply
                        {
                            Id = product.Id,
                            ShortName = product.ShortName,
                            LongName = product.LongName,
                            Barcode = product.Barcode,
                            Price = product.Price,
                            AdultOnly = product.Category.AdultOnly,
                            Amount = 1
                        }
                    };
                    cachedProducts[barcode] = response.data;
                    return JsonConvert.SerializeObject(response);
                }

                var productGroup = context.ProductGroups
                    .Include("Product")
                    .Include(p => p.Product.Category)
                    .SingleOrDefault(p => p.GroupBarcode == barcode);
                if (productGroup != null)
                {
                    product = productGroup.Product;
                    var response = new
                    {
                        result = "OK",
                        data = new ProductReply
                        {
                            Id = product.Id,
                            ShortName = product.ShortName,
                            LongName = product.LongName,
                            Barcode = product.Barcode,
                            Price = product.Price,
                            AdultOnly = product.Category.AdultOnly,
                            Amount = productGroup.Amount
                        }
                    };
                    cachedProducts[barcode] = response.data;
                    return JsonConvert.SerializeObject(response);
                }

                return JsonConvert.SerializeObject(new { result = "ERROR" });
            }
        }

        static void ProcessClient(Socket client)
        {
            byte[] bytes = new byte[32000];
            int numBytes = client.Receive(bytes);
            string str = Encoding.UTF8.GetString(bytes, 0, numBytes);

            dynamic? jsonRequest = JsonConvert.DeserializeObject(str);
            if (jsonRequest == null)
                return;

            string command = jsonRequest["command"].ToString();
            dynamic data = jsonRequest["data"];
            if (command == "scanProduct")
            {
                string resStr = GetProduct(data["barcode"].ToString());
                byte[] resData = Encoding.UTF8.GetBytes(resStr);

                client.SendTo(resData, client.RemoteEndPoint);
            }
            if (command == "finalizeCart")
            {
                var cart = data.ToObject<Dictionary<string, decimal>>();
                string resStr = finalizeCart(cart);
                byte[] resData = Encoding.ASCII.GetBytes(resStr);

                client.SendTo(resData, client.RemoteEndPoint);
            }
            client.Close();
        }

        static async Task Main(string[] args)
        {
            Console.WriteLine("Starting server...");
            Socket httpServer = new Socket(SocketType.Stream, ProtocolType.Tcp);
            int serverPort = 2137;

            IPEndPoint endpoint = new IPEndPoint(IPAddress.Any, serverPort);
            httpServer.Bind(endpoint);
            httpServer.Listen(1);
            Console.WriteLine("Listening on port {0}", serverPort);
            while (true)
            {
                Socket client = await httpServer.AcceptAsync();
                _ = Task.Run(() => ProcessClient(client));
            }
        }
    }
}
