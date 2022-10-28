using Global.Common;
using Mode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Global.Mode.Config
{
    [Serializable]
    public class Camera : ViewModelBase
    {
        public int SelectViewMode = 0;


        private double gamma = 1.0;
        /// <summary>
        /// 伽玛
        /// </summary>
        [JsonPropertyName("gamma")]
        public double Gamma
        {
            get { return gamma; }
            set { gamma = value; NotifyPropertyChanged(); }
        }

        private double gain = 0;
        [JsonPropertyName("gain")]
        public double Gain
        {
            get { return gain; }
            set { gain = value; NotifyPropertyChanged(); }
        }

        private bool gainAuto = false;

        [JsonPropertyName("gainAuto")]
        public bool GainAuto
        {
            get { return gainAuto; }
            set { gainAuto = value; NotifyPropertyChanged(); }
        }

        private double sharpness = 0;
        [JsonPropertyName("sharpness")]
        public double Sharpness
        {
            get { return sharpness; }
            set { sharpness = value; NotifyPropertyChanged(); }
        }

        private double saturation = 0;

        [JsonPropertyName("saturation")]
        public double Saturation
        {
            get { return saturation; }
            set { saturation = value; NotifyPropertyChanged(); }
        }

        private int exposure = 35;
        [JsonPropertyName("exposure")]
        public int Exposure
        {
            get { return exposure; }
            set { exposure = value; NotifyPropertyChanged(); }
        }

        private bool exposureAuto = false;

        [JsonPropertyName("exposureAuto")]
        public bool ExposureAuto
        {
            get { return exposureAuto; }
            set { exposureAuto = value; NotifyPropertyChanged(); }
        }

        [JsonPropertyName("vedio-format")]
        public string? VideoFormat { get; set; }
        [JsonPropertyName("fps")]
        public double? Fps { get; set; }
        [JsonPropertyName("brightness")]
        public double? Brightness { get; set; }
        [JsonPropertyName("contrast")]
        public double? Contrast { get; set; }
        [JsonPropertyName("hue")]
        public double? Hue { get; set; }

        [JsonPropertyName("white-balance")]
        public WhiteBalance? WhiteBalance { get; set; }

        [JsonPropertyName("trigger")]
        public Trigger? Trigger { get; set; }
        [JsonPropertyName("denoise")]
        public bool? Denoise { get; set; }
        [JsonPropertyName("strobe")]
        public bool? Strobe { get; set; }

        public void SetValue(Camera camera)
        {
           // this.SelectViewMode = camera.SelectViewMode;
            this.Gamma = camera.gamma;
            this.Gain = camera.gain;
            this.GainAuto = camera.GainAuto;
            this.Sharpness = camera.Sharpness;
            this.Saturation = camera.saturation;
            this.Exposure = camera.Exposure;
            this.ExposureAuto = camera.ExposureAuto;
            
        }
    }
}
