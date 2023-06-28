using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep.Database.Models
{
    public enum changeType
    {
        Theft,
        Stocktake,
        Sale,
        Delivery,
        ManualChange
    }
    public class InventoryChange
    {
        public int Id { get; set; }
        public int? PositionId { get; set; }
        public InventoryPosition Position { get; set; }
        public changeType Type { get; set; }
        public int Amount { get; set; }
    }
}
