using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class KeukenBestellingModel
    {
        public int OrderItemID { get; set; }

        public int MenuItemId { get; set; }

        public Decimal Price { get; set; }

        public int Amount { get; set; }

        public int orderTableId { get; set; }

        public Boolean OrderItemStatus { get; set; }

        public string Name { get; set; }
    }
}
