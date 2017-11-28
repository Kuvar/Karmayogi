using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace KarmyogiWeb
{
    public class Helper
    {
        public static string Get8Digits()
        {
            var bytes = new byte[4];
            var rng = RandomNumberGenerator.Create();
            rng.GetBytes(bytes);
            uint random = BitConverter.ToUInt32(bytes, 0) % 100000000;
            return String.Format("{0:D8}", random);
        }

        public static string GetSecurityKey()
        {
            return DateTime.Now.ToString().GetHashCode().ToString("x") + Guid.NewGuid().ToString().GetHashCode().ToString("x");
        }
    }
}