using System;
using System.IO;
using System.Security.Cryptography;

namespace ToolHash
{
    public static class Hash
    {
        public static MD5 hash = MD5.Create();
        public static string GetMD5(string path)
        {
            if (File.Exists(path))
            {
                using var stream = new FileStream(path, FileMode.Open);
                byte[] hashByte = hash.ComputeHash(stream);
                return BitConverter.ToString(hashByte).Replace("-", "");
            }
            return string.Empty;
        }
    }
}
