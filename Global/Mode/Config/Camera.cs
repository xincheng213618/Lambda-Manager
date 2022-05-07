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

        private bool gainAuto = false;

        [JsonProperty("gainAuto")]
        public bool GainAuto
        {
            get => gainAuto;
            set
            {
                gainAuto = value;
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

        private int exposure = 60;
        [JsonProperty("exposure")]
        public int Exposure
        {
            get => exposure;
            set
            {
                exposure = value;
                NotifyPropertyChanged();
            }
        }

        private bool exposureAuto = false;

        [JsonProperty("exposureAuto")]
        public bool ExposureAuto
        {
            get => exposureAuto;
            set
            {
                exposureAuto = value;
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

        [JsonProperty("trigger")]
        public Trigger? Trigger { get; set; }
        [JsonProperty("denoise")]
        public bool? Denoise { get; set; }
        [JsonProperty("strobe")]
        public bool? Strobe { get; set; }

        public void SetValue(Camera camera)
        {
            this.Gamma = camera.Gamma;
            this.Gain = camera.Gain;
            this.GainAuto = camera.GainAuto;
            this.Sharpness = camera.Sharpness;
            this.Saturation = camera.saturation;
            this.Exposure = camera.Exposure;
            this.ExposureAuto = camera.ExposureAuto;
        }
    }
}
