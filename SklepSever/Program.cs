using Microsoft.EntityFrameworkCore;
using Sklep.Database;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;

namespace SklepSever
{
    internal class Program
    {
        static string GetProduct(string barcode)
        {
            using (var context = new DatabaseContext())
            {
                var product = context.Products.Include(p => p.Category).SingleOrDefault(p => p.Barcode == barcode);
                if(product != null)
                {
                    return string.Format("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n1", product.Id, product.ShortName, product.LongName, product.Barcode, product.Price, product.Category.AdultOnly);
                }
                var productGroup = context.ProductGroups.Include("Product").Include(p => p.Product.Category).SingleOrDefault(p => p.GroupBarcode == barcode);
                if (productGroup != null)
                {
                    product = productGroup.Product;
                    return string.Format("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}", product.Id, product.ShortName, product.LongName, product.Barcode, product.Price, product.Category.AdultOnly, productGroup.Amount);
                }

                return "";
            }
        }

        static void Main(string[] args)
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
                Socket client = httpServer.Accept();
                byte[] bytes = new byte[2048];
                int numBytes = client.Receive(bytes);
                string data = Encoding.ASCII.GetString(bytes, 0, numBytes);

                int n = data.IndexOf("\n");
                string method = data.Substring(0, n);
                string arg = data.Substring(n + 1);

                if(method == "scanProduct")
                {
                    string resStr = GetProduct(arg).ToString();
                    byte[] resData = Encoding.ASCII.GetBytes(resStr);

                    client.SendTo(resData, client.RemoteEndPoint);
                }

                client.Close();
            }
        }
    }
}