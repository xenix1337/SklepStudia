using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep.Database.Models
{
    public class InventoryChange
    {
        public int Id { get; set; }
        public int? PositionId { get; set; }
        public InventoryPosition Position { get; set; }
        public string Type { get; set; }
        public int Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
