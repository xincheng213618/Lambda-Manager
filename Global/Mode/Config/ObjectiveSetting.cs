using Newtonsoft.Json;

namespace Global.Mode.Config
{
    public class ObjectiveSetting
    {
        public int ID { get; set; }    
        public string Name { get; set; }

        [JsonProperty("magnitude")]
        public string Magnitude { get; set; }

        [JsonProperty("N.A")]
        public double NA { get; set; }
        public bool IsEnabled { get; set; } = true;
        public bool IsChecked { get; set; } = false;
    }
}
