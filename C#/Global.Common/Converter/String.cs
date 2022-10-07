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
        ///https://blog.csdn.net/lpy369369/article/details/84849532
        ///已经由C++解决，String 的指针传输过去 中文异常的问题

        /// <summary>
        /// 中文的部分转换成Uincode
        /// </summary>
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
