using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace UserRegister.JsonOperate
{



    /// <summary>
    ///   AES 加密解密拓展方法
    /// </summary>
    /// 

    public static class EncryptionExtension
        {
            /// <summary>
            /// AES加密，并且有向量
            /// </summary>
            /// <param name="encrypteStr">需要加密的明文</param>
            /// <param name="key">秘钥</param>
            /// <param name="vector">向量</param>
            /// <returns>密文</returns>
            public static string AESEncryptedString(this string encrypteStr, string key, string vector)
            {
                byte[] aesBytes = Encoding.UTF8.GetBytes(encrypteStr);

                byte[] aesKey = new byte[32];

                //直接转
                //Array.Copy(Convert.FromBase64String(key), aesKey, aesKey.Length);
                Array.Copy(Encoding.UTF8.GetBytes(key.PadRight(aesKey.Length)), aesKey, aesKey.Length);
                 byte[] aesVector = new byte[16];
                //直接转
               // Array.Copy(Convert.FromBase64String(vector), aesVector, aesVector.Length);
                Array.Copy(Encoding.UTF8.GetBytes(vector.PadRight(aesVector.Length)), aesVector, aesVector.Length);
           
                Rijndael Aes = Rijndael.Create();
                //或者采用下方生成Aes
                //RijndaelManaged Aes = new();

                // 开辟一块内存流  
                using MemoryStream memoryStream = new MemoryStream();
                // 把内存流对象包装成加密流对象  
                using CryptoStream cryptoStream = new(memoryStream, Aes.CreateEncryptor(aesKey, aesVector), CryptoStreamMode.Write);
                // 明文数据写入加密流  
                cryptoStream.Write(aesBytes, 0, aesBytes.Length);
                cryptoStream.FlushFinalBlock();

                string result = Convert.ToBase64String(memoryStream.ToArray());
                return result;
            }

            /// <summary>
            /// AES解密，并且有向量
            /// </summary>
            /// <param name="decryptStr">被加密的明文</param>
            /// <param name="key">秘钥</param>
            /// <param name="vector">向量</param>
            /// <returns>明文</returns>
            public static string AESDecryptString(this string decryptStr, string key, string vector)
            {
                byte[] aesBytes = Convert.FromBase64String(decryptStr);
                byte[] aesKey = new byte[32];
                //直接转，可采用不同的方法，但是需与加密方法一致
                //Array.Copy(Convert.FromBase64String(key), aesKey, aesKey.Length);
                Array.Copy(Encoding.UTF8.GetBytes(key.PadRight(aesKey.Length)), aesKey, aesKey.Length);
                byte[] aesVector = new byte[16];
                //直接转，可采用不同的方法，但是需与加密方法一致
               // Array.Copy(Convert.FromBase64String(vector), aesVector, aesVector.Length);
                Array.Copy(Encoding.UTF8.GetBytes(vector.PadRight(aesVector.Length)), aesVector, aesVector.Length);
                Rijndael Aes = Rijndael.Create();
                //或者采用下方生成Aes
                //RijndaelManaged Aes = new();

                // 开辟一块内存流，存储密文  
                using MemoryStream memoryStream = new(aesBytes);
                // 把内存流对象包装成加密流对象  
                using CryptoStream Decryptor = new(memoryStream, Aes.CreateDecryptor(aesKey, aesVector), CryptoStreamMode.Read);
                // 明文存储区  
                using MemoryStream originalMemory = new();
                byte[] Buffer = new byte[1024];
                int readBytes = 0;
                while ((readBytes = Decryptor.Read(Buffer, 0, Buffer.Length)) > 0)
                {
                    originalMemory.Write(Buffer, 0, readBytes);
                }

                byte[] original = originalMemory.ToArray();
                 // Encoding.UTF8.GetString
                // string result = Convert.ToBase64String(originalMemory.ToArray());
                 string result = Encoding.UTF8.GetString(originalMemory.ToArray());
                 return result;
            }

 



        /// <summary>  
        /// AES加密(无向量)  
        /// </summary>  
        /// <param name="encrypteStr">需要加密的明文</param>  
        /// <param name="key">密钥</param>  
        /// <returns>密文</returns>  
        public static string AESEncryptedString(this string encrypteStr, string key)
            {
                byte[] aesBytes = Encoding.UTF8.GetBytes(encrypteStr);
                byte[] aesKey = new byte[32];
                //直接转
                //Array.Copy(Convert.FromBase64String(key), aesKey, aesKey.Length);
                //当长度不够时，右侧添加空格
                Array.Copy(Encoding.UTF8.GetBytes(key.PadRight(aesKey.Length)), aesKey, aesKey.Length);

                using MemoryStream memoryStream = new();
                Rijndael Aes = Rijndael.Create();
                //或者采用下方生成Aes
                //RijndaelManaged Aes = new();

                Aes.Mode = CipherMode.ECB;
                Aes.Padding = PaddingMode.PKCS7;
                Aes.KeySize = 128;
                Aes.Key = aesKey;
                using CryptoStream cryptoStream = new(memoryStream, Aes.CreateEncryptor(), CryptoStreamMode.Write);
                cryptoStream.Write(aesBytes, 0, aesBytes.Length);
                cryptoStream.FlushFinalBlock();
                Aes.Clear();
                return Convert.ToBase64String(memoryStream.ToArray());
            }


            /// <summary>  
            /// AES解密(无向量)  
            /// </summary>  
            /// <param name="decryptStr">被加密的明文</param>  
            /// <param name="key">密钥</param>  
            /// <returns>明文</returns>  
            public static string AESDecryptString(this string decryptStr, string key)
            {
                byte[] aesBytes = Convert.FromBase64String(decryptStr);
                byte[] aesKey = new byte[32];
                //需要跟加密一致
                //直接转
                //Array.Copy(Convert.FromBase64String(key), aesKey, aesKey.Length);
                //当长度不够时，右侧添加空格
                Array.Copy(Encoding.UTF8.GetBytes(key.PadRight(aesKey.Length)), aesKey, aesKey.Length);

                using MemoryStream memoryStream = new(aesBytes);
                Rijndael Aes = Rijndael.Create();
                //或者采用下方生成Aes
                //RijndaelManaged Aes = new();

                Aes.Mode = CipherMode.ECB;//需与加密方法一致
                Aes.Padding = PaddingMode.PKCS7;//需与加密方法一致
                Aes.KeySize = 128;
                Aes.Key = aesKey;
                using CryptoStream cryptoStream = new(memoryStream, Aes.CreateDecryptor(), CryptoStreamMode.Read);

                byte[] temp = new byte[aesBytes.Length + 32];
                int len = cryptoStream.Read(temp, 0, aesBytes.Length + 32);
                byte[] ret = new byte[len];
                Array.Copy(temp, 0, ret, 0, len);
                Aes.Clear();
                string result = Encoding.UTF8.GetString(ret);
                return result;
            }
        }

   
}
