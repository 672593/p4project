using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class Reservering
    {
        public int reservationId { get; set; }
        public int tableId { get; set; }
        public string reservationName { get; set; }
        public string reservationTel { get; set; }
        public string reservationEmail { get; set; }
        public string reservationComment { get; set; }
        public DateTime reservationDate { get; set; }
    }
}
