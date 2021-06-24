using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class Menuu
    {
        public int menuId;
        public string menuName;
    }

    public class MenuuItem
    {
        public int menuId { get; set; }
        public string itemName { get; set; }
        public int menuItemId { get; set; }
        public decimal price { get; set; }
    }
}
