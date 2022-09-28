using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Global.Common.Converter
{
    public static class String
    {
        public static string ToUincode(string str)
        {
            using MemoryStream memoryStream = new();
            using (Utf8JsonWriter writer = new((Stream)memoryStream, default))
            {
                writer.WriteStringValue(str);
            }
            return Encoding.UTF8.GetString(memoryStream.ToArray())[1..^1];
        }
    }
}
