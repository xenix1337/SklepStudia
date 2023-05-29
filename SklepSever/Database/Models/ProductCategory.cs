using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep.Database.Models
{
    public class ProductCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double VAT { get; set; }
        public bool AdultOnly { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
