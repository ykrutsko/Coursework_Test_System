using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SHA512Lib
{
    public static class Sha512
    {
        public static string GetSha512(this string str)
        {
            using (SHA512 sha = new SHA512Managed())
            {
                return Convert.ToBase64String(sha.ComputeHash(Encoding.UTF8.GetBytes(str)));
            }
        }
    }
}
