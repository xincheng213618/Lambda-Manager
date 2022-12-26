
﻿using Global.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Global.SettingUp.Mode.Hardware
{

    public class firmware : ViewModelBase
    {
        public objective objective { get; set; } = new objective();
        public camera camera { get; set; } = new camera();

        public stage stage { get; set; } = new stage();

        public source source { get; set; } = new source();
    }

    public class objective
    {
        public int magnitude { get; set; }
        public int multiple { get; set; }

        public int NA { get; set; }
        [JsonPropertyName("current-magnitude")]
        public int currentmagnitude { get; set; }
        public int WD { get; set; }
        public bool achromatic { get; set; }
    }
    public class camera
    {
        public string type { get; set; }
        [JsonPropertyName("ccd-size")]
        public string ccdsize { get; set; }

        public string hdr { get; set; }

        [JsonPropertyName("max-fps")]
        public int maxfps { get; set; }

        public bool calibrated { get; set; }

        [JsonPropertyName("vedio-format")]
        public string? VideoFormat { get; set; }
        [JsonPropertyName("fps")]
        public double? fps { get; set; }
        [JsonPropertyName("brightness")]
        public double? brightness { get; set; }
        [JsonPropertyName("contrast")]
        public double? contrast { get; set; }
        [JsonPropertyName("hue")]
        public double? hue { get; set; }


        public string flip { get; set; }

    }
    public class stage
    {
        public string type { get; set; }

        public object distance { get; set; }

        public object tolerance { get; set; }
        [JsonPropertyName("step-fine")]
        public object stepfine { get; set; }
        [JsonPropertyName("step-rough")]
        public object steprough { get; set; }
        public bool calibrated { get; set; }

    }


    public class source
    {
        [JsonPropertyName("led-size")]
        public string ledsize { get; set; }
        [JsonPropertyName("led-spacing")]
        public int ledspacing { get; set; }
        [JsonPropertyName("led-height")]

        public int ledheight { get; set; }

        public int hdr { get; set; }

        [JsonPropertyName("center-wave-length")]
        public int centerwavelength { get; set; }

        public bool calibrated { get; set; }

        [JsonPropertyName("max-frequency")]
        public int maxfrequency { get; set; }


        public int NA { get; set; }

        public int Brightness { get; set; }

    }



}