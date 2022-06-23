using System.Text.Json.Serialization;

namespace Global.Mode.Config
{
    public class ObjectiveSetting
    {
        public int ID { get; set; }    
        public string Name { get; set; }

        [JsonPropertyName("magnitude")]
        public string Magnitude { get; set; }

        [JsonPropertyName("N.A")]
        public double NA { get; set; }
        public bool IsEnabled { get; set; } = true;
        public bool IsChecked { get; set; } = false;
    }
}
