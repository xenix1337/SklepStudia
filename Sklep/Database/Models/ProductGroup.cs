using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep.Database.Models
{
    public class ProductGroup
    {
        public int Id { get; set; }
        public string GroupBarcode { get; set; }
        public Product Product { get; set; }
        /*
        [NotMapped]
        public string ProductBarcode { 
            get {
                using (var db = new DatabaseContext())
                {
                    db.Products.Load();
                    return db.Products.Get.Barcode;
                    return Product?.Barcode;
                }
            }
            set {
                using(var db = new DatabaseContext())
                {
                    db.Products.Load();
                    Product = db.Products.Local.SingleOrDefault(p => p.Barcode == value);
                    db.SaveChanges();
                }
            } 
        }
        */
        public int Amount { get; set; }
    }
}
