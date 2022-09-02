using System;
using System.Diagnostics;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Media;

namespace Global.Common.Util
{
    /// <summary>
    /// Json辅助类
    /// </summary>
    public static class JsonHelper
    {
        public class SolidColorBrushConverter : JsonConverter<SolidColorBrush>
        {
            public override SolidColorBrush Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                var hexValue = reader.GetString();

                if (string.IsNullOrWhiteSpace(hexValue))
                {
                    return Brushes.Beige;
                }

                return (SolidColorBrush)(new BrushConverter().ConvertFrom(hexValue) ?? Brushes.Beige);
            }

            public override void Write(Utf8JsonWriter writer, SolidColorBrush? value, JsonSerializerOptions options)
            {
                if (value == null)
                {
                    writer.WriteStringValue(Brushes.Beige.Color.ToString());
                    return;
                }

                writer.WriteStringValue(value.Color.ToString());
            }
        }



        /// <summary>
        /// 序列化成Json
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string ToJson(Object obj)
        {
            JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions();
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
