using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace MedApp.DAL
{
    public class Hasher : IHasher
    {
        private static string template = "0123456789abcdefghijklmnopABCDEFGHIJKLMNOP()[]{}-+";
        private Random random;

        public Hasher()
        {
            random = new Random();
        }

        public string GenerateSalt()
        {
            StringBuilder salt = new StringBuilder("");
            for (int i=0;i<64;i++)
            {
                int index = random.Next(0, template.Length);
                char c = template[index];
                salt.Append(c);
            }
            return salt.ToString();
        }

        public string HashPassword(string password, string salt)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(password + salt);
            SHA256Managed hashstring = new SHA256Managed();
            byte[] hash = hashstring.ComputeHash(bytes);
            string hashString = string.Empty;
            foreach (byte x in hash)
            {
                hashString += String.Format("{0:x2}", x);
            }
            return hashString;
        }
    }
}