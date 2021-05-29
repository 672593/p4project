using System;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ChapooModel
{
public class RNG
    {
        public string GenerateRandomCryptographicKey(int keyLength)
        {
            return Convert.ToBase64String(GenerateRandomCryptographicBytes(keyLength));
        }

        public byte[] GenerateRandomCryptographicBytes(int keyLength)
        {
            RNGCryptoServiceProvider RNG = new RNGCryptoServiceProvider();
            byte[] randomBytes = new byte[keyLength];
            RNG.GetBytes(randomBytes);
            return randomBytes;
        }
    }
}
