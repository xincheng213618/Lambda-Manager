using Mode;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Global.Mode.Config
{
    [Serializable]
    public class Camera : ModeBaseObject
    {
        private double gamma = 1.0;

        [JsonProperty("gamma")]
        public double Gamma
        {
            get => gamma;
            set  {
                gamma = value;
                NotifyPropertyChanged();
            }
        }
        private double gain = 0;

        [JsonProperty("gain")]
        public double Gain
        {
            get => gain;
            set
            {
                gain = value;
                NotifyPropertyChanged();
            }
        }
        private double sharpness = 0;
        [JsonProperty("sharpness")]
        public double Sharpness
        {
            get => sharpness;
            set
            {
                sharpness = value;
                NotifyPropertyChanged();
            }
        }

        private double saturation = 0;

        [JsonProperty("saturation")]
        public double Saturation
        {
            get => saturation;
            set
            {
                saturation = value;
                NotifyPropertyChanged();
            }
        }

        [JsonProperty("vedio-format")]
        public string? VideoFormat { get; set; }
        [JsonProperty("fps")]
        public double? Fps { get; set; }
        [JsonProperty("brightness")]
        public double? Brightness { get; set; }
        [JsonProperty("contrast")]
        public double? Contrast { get; set; }
        [JsonProperty("hue")]
        public double? Hue { get; set; }


        [JsonProperty("white-balance")]
        public WhiteBalance? WhiteBalance { get; set; }

        [JsonProperty("exposure")]
        public Exposure? Exposure { get; set; }
        [JsonProperty("trigger")]
        public Trigger? Trigger { get; set; }
        [JsonProperty("denoise")]
        public bool? Denoise { get; set; }
        [JsonProperty("strobe")]
        public bool? Strobe { get; set; }

        public void SetValue(Camera camera)
        {
            this.Gamma = camera.gamma;
            this.Gain = camera.gain;
            this.Sharpness = camera.Sharpness;
            this.Saturation = camera.saturation;
        }
    }
}
