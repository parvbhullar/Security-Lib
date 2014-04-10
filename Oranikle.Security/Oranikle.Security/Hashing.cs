using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace Oranikle.Security
{
    public class Hashing
    {
        private static string salt = "auroniks";
        private static string ComputeHash(string plainText )
        {
            plainText += Hashing.salt;
            byte[] bArr = Encoding.UTF8.GetBytes(plainText);
            MD5 md5 = new MD5CryptoServiceProvider();
            return Encoding.ASCII.GetString(md5.ComputeHash(bArr));
        }

        public static string CreateHash(string value)
        {
            string hashString = ComputeHash(value);

            return hashString;
        }
    }
}

