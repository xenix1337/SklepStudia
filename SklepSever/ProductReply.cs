using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SklepSever
{
    internal class ProductReply
    {
        public int Id;
        public string ShortName;
        public string LongName;
        public string Barcode;
        public double Price;
        public bool AdultOnly;
        public decimal Amount;
    }
}
