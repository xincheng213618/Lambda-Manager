using Global.Common;
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
    public class Camera : ViewModeBase
    {
        public int SelectViewMode = 0;


        private double gamma = 1.0;
        /// <summary>
        /// 伽玛
        /// </summary>
        [JsonProperty("gamma")]
        public double Gamma
        {
            get { return gamma; }
            set { gamma = value; NotifyPropertyChanged(); }
        }

        private double gain = 0;
        [JsonProperty("gain")]
        public double Gain
        {
            get { return gain; }
            set { gain = value; NotifyPropertyChanged(); }
        }

        private bool gainAuto = false;

        [JsonProperty("gainAuto")]
        public bool GainAuto
        {
            get { return gainAuto; }
            set { gainAuto = value; NotifyPropertyChanged(); }
        }

        private double sharpness = 0;
        [JsonProperty("sharpness")]
        public double Sharpness
        {
            get { return sharpness; }
            set { sharpness = value; NotifyPropertyChanged(); }
        }

        private double saturation = 0;

        [JsonProperty("saturation")]
        public double Saturation
        {
            get { return saturation; }
            set { saturation = value; NotifyPropertyChanged(); }
        }

        private int exposure = 60;
        [JsonProperty("exposure")]
        public int Exposure
        {
            get { return exposure; }
            set { exposure = value; NotifyPropertyChanged(); }
        }

        private bool exposureAuto = false;

        [JsonProperty("exposureAuto")]
        public bool ExposureAuto
        {
            get { return exposureAuto; }
            set { exposureAuto = value; NotifyPropertyChanged(); }
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
            this.SelectViewMode = camera.SelectViewMode;
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
