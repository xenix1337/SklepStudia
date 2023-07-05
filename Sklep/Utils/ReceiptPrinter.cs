using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Sklep.Database;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Sklep.Utils
{
    public static class ReceiptPrinter
    {
        public static string PrintReceipt(Dictionary<string, decimal> cart, string receiptId)
        {
            decimal sum = 0;
            if(!Directory.Exists("Receipts"))
            {
                Directory.CreateDirectory("Receipts");
            }
            string receiptPath = @"Receipts/receipt" + receiptId + ".txt";
            string receiptContent = SettingsManager.current.receiptHeader + "\n";
            using (var db = new DatabaseContext())
            {
                foreach (var item in cart)
                {
                    var product = db.Products.SingleOrDefault(p => p.Barcode == item.Key);
                    receiptContent +=
                        product.ShortName
                        + "\t\t\t"
                        + item.Value
                        + "x "
                        + product.Price
                        + "PLN\n";
                    sum += item.Value * (decimal)product.Price;
                }
            }
            receiptContent += "SUMA" + "\t\t\t\t\t\t" + sum + "PLN\n";
            receiptContent += SettingsManager.current.receiptFooter;
            using (StreamWriter sw = File.CreateText(receiptPath))
            {
                sw.Write(receiptContent);
            }
            return receiptContent;
        }
    }
}
