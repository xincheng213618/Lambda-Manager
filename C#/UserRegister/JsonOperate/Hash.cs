using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace UserRegister.JsonOperate
{
    public class HashHelper
    {
        public static string sha512Encode(string source)
        {
            string result = "";
            byte[] buffer = Encoding.UTF8.GetBytes(source);//UTF-8 编码

            //64字节,512位
            SHA512CryptoServiceProvider SHA512 = new SHA512CryptoServiceProvider();
            byte[] h5 = SHA512.ComputeHash(buffer);

            result = BitConverter.ToString(h5).Replace("-", string.Empty);

            return result.ToLower();
        }


    }
    
}
