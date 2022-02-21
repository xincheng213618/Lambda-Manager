using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3.Mode
{
    /// <summary>
    /// 本软件配置文件实体类
    /// </summary>
    [Serializable]
    public class Config
    {
        [JsonProperty("version")]
        public string? Version { get; set; }
       
        [JsonProperty("modules")]
        public Modules? Modules { get; set; }
       
        [JsonProperty("lambda-manager")]
        public LambdaManager? LambdaManager { get; set; }
        
        [JsonProperty("firmware-setting")]
        public FirmwareSetting? FirmwareSetting { get; set; }
       
        [JsonProperty("log-file")]
        public string? LogFile { get; set; }
    }

    [Serializable]
    public class Modules
    {
        [JsonProperty("lambda_manager")]
        public string? LambdaManager { get; set; }
        [JsonProperty("config-dpc-mode")]
        public string? ConfigDpcMode { get; set; }
        [JsonProperty("config-stage")]
        public string? ConfigStage { get; set; }
        [JsonProperty("config-spot")]
        public string? ConfigSpot { get; set; }
        [JsonProperty("config-dof")]
        public string? ConfigDof { get; set; }
        [JsonProperty("config-multi-dimensional")]
        public string? ConfigMultiDimensional { get; set; } 
        [JsonProperty("dpc-algorithm")]
        public string? DpcAlgorithm { get; set; }
    }
    [Serializable]
    public class LambdaManager
    {
        [JsonProperty("latest-closed")]
        public List<string>? LatestClosed { get; set; }
        [JsonProperty("default-directory")]
        public string?  DefaultDirectory { get; set; }   
    }
    [Serializable]
    public class FirmwareSetting
    {
        [JsonProperty("objective")]
        public ObjectiveSetting? ObjectiveSetting { get; set; }
        [JsonProperty("camera")]
        public CameraSetting? CameraSetting { get; set; }
    }

    [Serializable]
    public class ObjectiveSetting
    {
        [JsonProperty("magnitude")]
        public int? Magnitude { get; set; }
        [JsonProperty("N.A")]
        public double? NA { get; set; } 
    }
    [Serializable]
    public class CameraSetting
    {
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
        [JsonProperty("saturation")]
        public double? Saturation { get; set; }
        [JsonProperty("sharpness")]
        public double? Sharpness { get; set; }
        [JsonProperty("gamma")]
        public double? Gamma { get; set; }
        [JsonProperty("white-balance")]
        public WhiteBalance? WhiteBalance { get; set; }
        [JsonProperty("gain")]
        public Gain? gain { get; set; }
        [JsonProperty("exposure")]
        public Exposure? Exposure { get; set; }
        [JsonProperty("trigger")]
        public Trigger? Trigger { get; set; }
        [JsonProperty("denoise")]
        public bool? Denoise { get; set; }
        [JsonProperty("strobe")]
        public bool? Strobe { get; set; }
        [JsonProperty("source")]
        public Source? Source { get; set; }



    }
    [Serializable]
    public class Source
    {
        [JsonProperty("fpga-version")]
        public double FpgaVersion { get; set; }
        [JsonProperty("max-bright")]
        public int MaxBright { get; set; }

    }

    [Serializable]
    public class WhiteBalance
    {
        [JsonProperty("auto")]
        public bool? Auto { get; set; }
        [JsonProperty("mode")]
        public int? Mode { get; set; }
        [JsonProperty("white-balance-green")]
        public int? WhiteBalanceGreen { get; set; }
        [JsonProperty("white-balance-blue")]
        public int? WhiteBalanceBlue { get; set; }
        [JsonProperty("white-balance-red")]
        public int? WhiteBalanceRed { get; set; }
    }

    [Serializable]
    public class Gain
    {
        [JsonProperty("auto")]
        public bool? Auto { get; set; }
        [JsonProperty("value")]
        public double? Value { set; get; }

    }
    [Serializable]
    public class Exposure
    {
        [JsonProperty("auto")]
        public bool? Auto { get; set; }
        [JsonProperty("value")]
        public double? Value { set; get; }
        [JsonProperty("auto-max")]
        public int? AutoMax { get; set; }
        [JsonProperty("auto-reference")]
        public int? AutoReference { get; set; }

    }
    [Serializable]
    public class Trigger
    {
        [JsonProperty("enable")]
        public bool? Enable { get; set; }
        [JsonProperty("polarity")]
        public bool? Polarity { get; set; }
        [JsonProperty("delay")]
        public double? Delay { set; get; }

    }








}
