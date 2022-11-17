using System.IO;
using System.Text.Json;
using System.Xml.Serialization;

namespace Global.Common.Extensions
{
    /// <summary>
    /// 序列化的扩展
    /// </summary>
    public static class SerializationExtensions
    {
        public static T DeserializeXml<T>(this string This)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            using StringReader textReader = new StringReader(This);
            return (T)xmlSerializer.Deserialize(textReader);
        }

        public static string SerializeXml<T>(this T This)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, This);
                return textWriter.ToString();
            }
        }

        public static T DeserializeJson<T>(this string This)
        {
            return JsonSerializer.Deserialize<T>(This);
        }

        public static string SerializeJson<T>(this T This)
        {
            return JsonSerializer.Serialize(This);
        }
    }
}
