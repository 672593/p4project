using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ChapooModel;

//Anel Gusinac
namespace ChapooLogic
{
    public class PasswordWithSaltHasher
    {
        public HashWithSalt HashWithSalt(string password, int saltLength, HashAlgorithm hashAlgo)
        {
            RNG rng = new RNG();
            byte[] saltBytes = rng.GenerateRandomCryptographicBytes(saltLength);
            byte[] passwordAsBytes = Encoding.UTF8.GetBytes(password);
            List<byte> passwordWithSaltBytes = new List<byte>();
            passwordWithSaltBytes.AddRange(passwordAsBytes);
            passwordWithSaltBytes.AddRange(saltBytes);
            byte[] digestBytes = hashAlgo.ComputeHash(passwordWithSaltBytes.ToArray());
            return new HashWithSalt(Convert.ToBase64String(saltBytes), Convert.ToBase64String(digestBytes));
        }

        public HashWithSalt HashWithSaltCheck(string password, string salt, HashAlgorithm hashAlgo)
        {
            byte[] saltbytes = Encoding.UTF8.GetBytes(salt);
            byte[] passwordbytes = Encoding.UTF8.GetBytes(password);
            List<byte> passwordWithBytes = new List<byte>();
            passwordWithBytes.AddRange(passwordbytes);
            passwordWithBytes.AddRange(saltbytes);
            byte[] digestBytes = hashAlgo.ComputeHash(passwordWithBytes.ToArray());
            return new HashWithSalt(Convert.ToBase64String(saltbytes), Convert.ToBase64String(digestBytes));
        }
    }
}
