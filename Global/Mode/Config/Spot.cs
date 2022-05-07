using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Global.Mode.Config
{
    [Serializable]
    public class  TestMean : ModeBaseObject
    {
        [JsonProperty("config-stage")]
        public Stage Stage { get; set; }    
        [JsonProperty("config-spot")]
        public Spot Spot { get; set; }

        [JsonProperty("config-multi-dimensional")]
        public Dimensional Dimensional { get; set; }    
    }


    [Serializable]
    public class Spot:ModeBaseObject
    {
        [JsonProperty("includes")]
        public List<List<int>> Includes { get;set; } = new List<List<int>>();

        [JsonProperty("excludes")]
        public List<List<int>> Excludes { get; set; } = new List<List<int>>();
    }
    [Serializable]
    public class Dimensional : ModeBaseObject
    {
        [JsonProperty("imaging-mode")]
        public List<string> Mode { get; set; } = new List<string>();

        [JsonProperty("focus-mode")]
        public FocusMode Focusmode { get; set; } = new();

        [JsonProperty("time-wise-serial")]
        public TimeWiseSerial TimeWiseSerial { get; set; } = new TimeWiseSerial();
        [JsonProperty("dimensions")]  
        public string Dimensions { get; set; } = "xy";

        [JsonProperty("zstack-wise-serial")]
        public ZstackWiseSerial ZstackWiseSerial { get; set; } = new ZstackWiseSerial();    
        [JsonProperty("serial-prefix")]
        public string Saveprefix { get; set; } = "Serial";
        [JsonProperty("save-dir")]
        public string Savedir { get; set; }
    }

    [Serializable]
    public class FocusMode
    {
        [JsonProperty("t-wise")]
        public Twise Twise { get; set; } = new();

        [JsonProperty("p-wise")]
        public Pwise Pwise { get; set; } = new();
    }
    [Serializable]
    public class Twise
    {
        [JsonProperty("interval")]
        public string Interval { get; set; } = "first";
    }
    [Serializable]
    public class Pwise
    {
        [JsonProperty("interval")]
        public string Interval { get; set; } = "first";
    }

    [Serializable]
    public class ZstackWiseSerial : ModeBaseObject
    {
        [JsonProperty("z-begin")]
        public int ZBegin { get; set; } 
        [JsonProperty("z-end")]
        public int ZEnd { get; set; } 
        [JsonProperty("z-step")]
        public int ZStep { get; set; } 

    }


    [Serializable]
    public class TimeWiseSerial : ModeBaseObject
    {
        [JsonProperty("times")]
        public int Times { get; set; } = 0;
        [JsonProperty("duration")]
        public int Duration { get; set; } = 0;
    }
}
