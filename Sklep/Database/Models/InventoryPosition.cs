using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep.Database.Models
{
    public class InventoryPosition
    {
        public int Id { get; set; }
        public int Rack { get; set; }
        public int Shelf { get; set; }
        public decimal Amount { get; set; }
    }
}
