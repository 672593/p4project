using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class HashwithSaltResults
    {
        public string Salt { get; }

        public string Digest { get; set; }


        public HashwithSaltResults(string salt, string digest)
        {
            Salt = salt;

            Digest = digest;
        }
    }
}
