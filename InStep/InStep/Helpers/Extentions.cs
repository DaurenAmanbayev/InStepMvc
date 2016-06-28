using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace InStep.Helpers
{
    public static class Extentions
    {
        public static byte[] Encrypt(this string pwd)
        {
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(pwd);
            SHA1 sha = new SHA1CryptoServiceProvider();
            return sha.ComputeHash(bytes);
        }

        public static bool Compare(this byte[] self, byte[] byteArr)
        {
            if (self.Count() != byteArr.Count()) return false;

            for (int i = 0; i<byteArr.Count(); i++)
                if (self[i] != byteArr[i]) return false;

            return true;
        }
    }
}