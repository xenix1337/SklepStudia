using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep.Database.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ShortName { get; set; }
        public string LongName { get; set; }
        public double Price { get; set; }
        public string Barcode { get; set; }
        public int? CategoryId { get; set; }
        public ProductCategory Category { get; set; }

    }
}
