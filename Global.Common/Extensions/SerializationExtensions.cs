using System.IO;
using System.Text.Json;
using System.Xml.Serialization;

namespace Global.Common.Extensions
{
    public static class SerializationExtensions
    {
        public static T DeserializeXml<T>(this string toDeserialize)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            using (StringReader textReader = new StringReader(toDeserialize))
            {
                return (T)xmlSerializer.Deserialize(textReader);
            }
        }

        public static string SerializeXml<T>(this T toSerialize)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, toSerialize);
                return textWriter.ToString();
            }
        }

        public static T DeserializeJson<T>(this string toDeserialize)
        {
            return JsonSerializer.Deserialize<T>(toDeserialize);
        }

        public static string SerializeJson<T>(this T toSerialize)
        {
            return JsonSerializer.Serialize(toSerialize);
        }
    }
}
