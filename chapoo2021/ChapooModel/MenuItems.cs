using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ChapooModel
{
    //Anel Gusinac
    public class MenuItems
    {
        public int MenuItemId { get; set; }
        public int MenuId { get; set; }
        public string MenuItemName { get; set; }
        public int MenuItemStock { get; set; }
        public decimal MenuItemPrice { get; set; }
        public bool ContainsAlcohol { get; set; }
    }
}