using Global.Common.Converter.Json;
using System;
using System.Diagnostics;
using System.IO;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace Global.Common.Util
{
    /// <summary>
    /// Json辅助类
    /// </summary>
    public static class Json
    {
        /// <summary>
        /// 序列化成Json
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string ToJson(Object obj)
        {
            JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions() { Encoder = JavaScriptEncoder.Create(UnicodeRanges.All) };
            jsonSerializerOptions.Converters.Add(new SolidColorBrushConverter());
            return JsonSerializer.Serialize(obj, jsonSerializerOptions);
        }

        /// <summary>
        /// 保存成json文件
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static int ToJsonFile(Object obj, string filePath, bool nullValue = true)
        {
            int result;
            try
            {
                JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions();
                jsonSerializerOptions.Converters.Add(new SolidColorBrushConverter());
                string jsonString = JsonSerializer.Serialize(obj, jsonSerializerOptions);

                File.WriteAllText(filePath, jsonString);
                result = 0;
            }
            catch(Exception ex)
            {
                Trace.WriteLine("### [" + ex.Source + "] Exception: " + ex.Message);
                Trace.WriteLine("### " + ex.StackTrace);
                result = -1;
            }
            return result;
        }



    }
}
