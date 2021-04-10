using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace PasswordAuthentication
{
    class Encryption
    {
        SHA256 SHA256 = SHA256.Create();

        public string PasswordEncryption(string Password)
        {
            var NewPassowrd = Encoding.ASCII.GetBytes(Password);
            
            var EncryptedPassword = SHA256.HashData(NewPassowrd);
            string Endpoint = ""; 
            foreach(byte b in EncryptedPassword)
            {
                Endpoint += b.ToString("x2");
            }
           

            return Endpoint;
        }
    }
}
