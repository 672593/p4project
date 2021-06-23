using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class OrdersTable
    {
        public int MenuItemId { get; set; }
        public int Amount { get; set; }
        public string ItemName { get; set; }
        public decimal Price { get; set; }
        public int OrderTableId { get; set; }
        public int OrderId { get; set; }
    }
    public class CustomerReceipt
    {
        public int ReceiptId { get; set; }
        public int OrderId { get; set; }
        public int PayMethodId { get; set; }
        public decimal VatPercentage { get; set; }
        public decimal Tip { get; set; }
        public decimal PaidPrice { get; set; }
    }
}
