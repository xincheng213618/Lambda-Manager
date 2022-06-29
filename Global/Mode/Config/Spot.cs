using Global.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Global.Mode.Config
{
    [Serializable]
    public class  TestMean : ViewModeBase
    {
        [JsonPropertyName("config-stage")]
        public Stage Stage { get; set; }    
        [JsonPropertyName("config-spot")]
        public Spot Spot { get; set; }

        [JsonPropertyName("config-multi-dimensional")]
        public Dimensional Dimensional { get; set; }    
    }

    [Serializable]
    public class Spot:ViewModeBase
    {
        [JsonPropertyName("includes")]
        public List<List<int>> Includes { get;set; } = new List<List<int>>();

        [JsonPropertyName("excludes")]
        public List<List<int>> Excludes { get; set; } = new List<List<int>>();
    }
    [Serializable]
    public class Dimensional : ViewModeBase
    {
        [JsonPropertyName("imaging-mode")]
        public List<string> Mode { get; set; } = new List<string>();

        [JsonPropertyName("focus-mode")]
        public FocusMode Focusmode { get; set; } = new();

        [JsonPropertyName("time-wise-serial")]
        public TimeWiseSerial TimeWiseSerial { get; set; } = new TimeWiseSerial();
        [JsonPropertyName("dimensions")]  
        public string Dimensions { get; set; } = "xy";

        [JsonPropertyName("zstack-wise-serial")]
        public ZstackWiseSerial ZstackWiseSerial { get; set; } = new ZstackWiseSerial();    
        [JsonPropertyName("serial-prefix")]
        public string Saveprefix { get; set; } = "Serial";
        [JsonPropertyName("save-dir")]
        public string Savedir { get; set; }
    }

    [Serializable]
    public class FocusMode
    {
        [JsonPropertyName("t-wise")]
        public Twise Twise { get; set; } = new();

        [JsonPropertyName("p-wise")]
        public Pwise Pwise { get; set; } = new();
    }
    [Serializable]
    public class Twise
    {
        [JsonPropertyName("interval")]
        public string Interval { get; set; } = "first";
    }
    [Serializable]
    public class Pwise
    {
        [JsonPropertyName("interval")]
        public string Interval { get; set; } = "first";
    }

    [Serializable]
    public class ZstackWiseSerial : ViewModeBase
    {
        [JsonPropertyName("z-begin")]
        public int ZBegin { get; set; } 
        [JsonPropertyName("z-end")]
        public int ZEnd { get; set; } 
        [JsonPropertyName("z-step")]
        public int ZStep { get; set; } 

    }


    [Serializable]
    public class TimeWiseSerial : ViewModeBase
    {
        [JsonPropertyName("times")]
        public int Times { get; set; } = 0;
        [JsonPropertyName("duration")]
        public int Duration { get; set; } = 0;
    }
}
