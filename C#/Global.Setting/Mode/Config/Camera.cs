using Global.Common;
using Global.Mode;
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
      // [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public double Gain
        {
            get { return gain; }
            set { gain = value; NotifyPropertyChanged(); }
        }

        private MultiGain multiObjGain = new MultiGain();
        [JsonPropertyName("gain_")]
       // [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public MultiGain MultiObjGain
        {
            get { return multiObjGain; }
            set { multiObjGain = value; NotifyPropertyChanged(); }
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
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int Exposure
        {
            get { return exposure; }
            set { exposure = value; NotifyPropertyChanged(); }
        }


        private MultiExposure multiExposure = new MultiExposure();

        [JsonPropertyName("exposure_")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public MultiExposure MultiObjExposure
        {
            get { return multiExposure; }
            set { multiExposure = value; NotifyPropertyChanged(); }
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
            this.MultiObjGain = camera.MultiObjGain;
            this.MultiObjExposure = camera.MultiObjExposure;
            
        }
    }


    public class MultiGain : ViewModelBase
    {
      
            private int gain1 = 0;
            [JsonPropertyName("10x")]
            public int Gain1
           {
                get { return gain1; }
                set
                {
                     gain1 = value;
                    NotifyPropertyChanged();
                }
            }

            private int gain2 = 0;
            [JsonPropertyName("20x")]
            public int Gain2
        {
                get { return gain2; }
                set
                {
                gain2 = value;
                    NotifyPropertyChanged();
                }
            }

            private int gain3 = 30;
            [JsonPropertyName("40x")]
            public int Gain3
        {
                get { return gain3; }
                set
                {
                gain3 = value;
                    NotifyPropertyChanged();
                }
            }

            //public void SetValue(Inner inner)
            //{
            //    this.Inner1 = inner.Inner1;
            //    this.Inner2 = inner.Inner2;
            //    this.Inner3 = inner.Inner3;
            //}



    }
    public class MultiExposure : ViewModelBase
    {

        private int exposure1 = 35;
        [JsonPropertyName("10x")]
        public int Exposure1
        {
            get { return exposure1; }
            set
            {
                exposure1 = value;
                NotifyPropertyChanged();
            }
        }

        private int exposure2 = 35;
        [JsonPropertyName("20x")]
        public int Exposure2
        {
            get { return exposure2; }
            set
            {
                exposure2 = value;
                NotifyPropertyChanged();
            }
        }

        private int exposure3 = 35;
        [JsonPropertyName("40x")]
        public int Exposure3
        {
            get { return exposure3; }
            set
            {
                exposure3 = value;
                NotifyPropertyChanged();
            }
        }

        //public void SetValue(Inner inner)
        //{
        //    this.Inner1 = inner.Inner1;
        //    this.Inner2 = inner.Inner2;
        //    this.Inner3 = inner.Inner3;
        //}



    }



}
