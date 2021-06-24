using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class Bestelling
    {
        public int orderId { get; set; }
        public int orderTableId { get; set; }
        public int employeeId { get; set; }
        public DateTime currentDate { get; set; }
        public decimal totalPrice { get; set; }
        public string comment { get; set; }
    }

    public class BestellingItem
    {
        public int orderId { get; set; }
        public int orderItemId { get; set; }
        public int orderTableId { get; set; }
        public int menuItemId { get; set; }
        public DateTime orderTime { get; set; }
        public int amount { get; set; }
        public decimal price { get; set; }
        public bool orderItemStatus { get; set; }
        public string itemName { get; set; }
    }

    // kelvin 

    public class CustomerReceipt
    {
        public int ReceiptId { get; set; }
        public int OrderId { get; set; }
        public int PayMethodId { get; set; }
        public decimal VatPercentage { get; set; }
        public decimal Tip { get; set; }
        public decimal PaidPrice { get; set; }
    }

    // Nino

    public class KeukenBarBestelling
    {
        public int OrderItemID { get; set; }

        public int Amount { get; set; }

        public int orderTableId { get; set; }

         public Boolean OrderItemStatus { get; set; }

        public string Name { get; set; }

        public DateTime Datum { get; set; }

        public string Comment { get; set; }
    }
}
