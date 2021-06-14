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
}
