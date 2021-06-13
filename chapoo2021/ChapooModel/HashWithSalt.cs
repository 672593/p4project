using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    //Anel Gusinac
    public class HashWithSalt
    {
        public string Salt { get; set; }
        public string Digest { get; set; }
        public HashWithSalt(string salt, string digest)
        {
            Salt = salt;
            Digest = digest;
        }
    }
}