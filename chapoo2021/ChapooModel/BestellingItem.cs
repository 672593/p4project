using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class BestellingItem
    {
        public int orderId { get; set; }
        public int orderItemId { get; set; }
        public int menuItemId { get; set; }
        public DateTime orderTime { get; set; }
        public int amount { get; set; }
        public decimal price { get; set; }
        public bool orderItemStatus { get; set; }
        public string itemName { get; set; }
    }
}
