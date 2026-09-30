using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LOGICA
{
    public class SeguridadSha256Logica
    {
        public static string Sha256(string texto)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(texto);

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hash = sha256.ComputeHash(bytes);

                string hashString = string.Empty;

                foreach (byte t in hash)
                {
                    hashString += string.Format("{0:x2}", t);
                }

                return hashString;
            }
        }
    }
}
