using System;

namespace ChapooModel
{
    // made by Faruk Bikmaz & Jelle de Vries
    public class Tafels
    {
        public int tableId;
        public int orderTableId;
        public int employeeId;
        public DateTime currentDate;
        public decimal Price;
        public string comment;
        public int TafelStatusId { get; set; }
        public bool LopendeOrder { get; set; }
    }
}
