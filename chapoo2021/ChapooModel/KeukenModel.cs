using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class KeukenModel
    {
        public int ItemID { get; set; }

        public int Type { get; set; }

        public Decimal Price { get; set; }

        public int Stock { get; set; }

        public string Name { get; set; }
    }
}
