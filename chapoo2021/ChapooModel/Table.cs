using System;

namespace ChapooModel
{
    // made by Faruk Bikmaz
    public class Table
    {
        public int tableId;
        public int orderTableId;
        public int employeeId;
        public DateTime currentDate;
        public decimal Price;
        public string comment;
        public bool LopendeOrder { get; set; }
        public DateTime orderTijd;
        public int TafelStatusId { get; set; }
        public int orderid;

    }
}
