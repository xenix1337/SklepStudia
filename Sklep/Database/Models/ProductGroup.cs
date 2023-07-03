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

        [NotMapped]
        public string ProductBarcode
        {
            get { return Product?.Barcode; }
            set { }
        }
        public int Amount { get; set; }
    }
}
