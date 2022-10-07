using System;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Windows.Media;

namespace Global.Common.Converter.Json
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
}
