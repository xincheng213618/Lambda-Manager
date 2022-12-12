﻿using Global.Common;
using Global.Mode.Config;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Global.Mode
{
    /// <summary>
    /// 本软件配置文件实体类
    /// </summary>
    [Serializable]
    public class SolutionConfig: ViewModelBase
    {
        [JsonPropertyName("version")]
        public string? Version { get; set; }  
        [JsonPropertyName("modules")]
        public Modules? Modules { get; set; }
        [JsonPropertyName("last-visit-time")]
        public string LastOpenTime { get; set; } = DateTime.Now.ToString("YYYY-MM-dd HH:mm:ss");
        [JsonPropertyName("lambda-manager")] 
        public LambdaManager LambdaManager { get; set; }      
        [JsonPropertyName("firmware")]  
        public Firmware FirmwareSetting { get; set; }
        [JsonPropertyName("config-stage")]   
        public Stage Stage { get; set; } = new();
        [JsonPropertyName("config-spot")]       
        public Spot Spot { get; set; } = new();
        [JsonPropertyName("config-imaging-mode")]
        public OperatingMode OperatingMode { get; set; } = new OperatingMode();
        [JsonPropertyName("config-multi-dimensional")]
        public Dimensional Dimensional { get; set; } = new();
        public ImageViewState ImageViewState = new ImageViewState();
        [JsonPropertyName("log-file")]
        public string? LogFile { get; set; }
        [JsonIgnore]
        public int CurrentObjective=1;
        [JsonPropertyName("multiObj")]
        public MultiObjective IsMultiObj { get; set; } = new MultiObjective();
       



    }



    [Serializable]
    public class Modules
    {
        [JsonPropertyName("lambda_manager")]
        public string? LambdaManager { get; set; } = "1.0";
        [JsonPropertyName("config-dpc-mode")]
        public string? ConfigDpcMode { get; set; } = "1.0";
        [JsonPropertyName("config-stage")]
        public string? ConfigStage { get; set; } = "1.0";
        [JsonPropertyName("config-spot")]
        public string? ConfigSpot { get; set; } = "1.0";
        [JsonPropertyName("config-dof")]
        public string? ConfigDof { get; set; } = "1.0";
        [JsonPropertyName("config-multi-dimensional")]
        public string? ConfigMultiDimensional { get; set; } = "1.0";
        [JsonPropertyName("dpc-algorithm")]
        public string? DpcAlgorithm { get; set; } = "1.0";
    }
    [Serializable]
    public class LambdaManager
    {
        [JsonPropertyName("latest-closed")]
        public List<string>? LatestClosed { get; set; }
        [JsonPropertyName("default-directory")]
        public string?  DefaultDirectory { get; set; }   
    }
    [Serializable]
    public class Firmware
    {

        [JsonPropertyName("camera")]
        public Camera? CameraSetting { get; set; } = new ();

        [JsonPropertyName("source")]
        public Source? Source { get; set; }
    }



    [Serializable]
    public class Source
    {
        [JsonPropertyName("fpga-version")]
        public string FpgaVersion { get; set; } = "1.0";
        [JsonPropertyName("max-bright")]
        public int MaxBright { get; set; } = new();

    }

    [Serializable]
    public class WhiteBalance
    {
        [JsonPropertyName("auto")]
        public bool? Auto { get; set; }
        [JsonPropertyName("mode")]
        public int? Mode { get; set; }
        [JsonPropertyName("white-balance-green")]
        public int? WhiteBalanceGreen { get; set; }
        [JsonPropertyName("white-balance-blue")]
        public int? WhiteBalanceBlue { get; set; }
        [JsonPropertyName("white-balance-red")]
        public int? WhiteBalanceRed { get; set; }
    }

    [Serializable]
    public class Gain
    {
        [JsonPropertyName("auto")]
        public bool? Auto { get; set; }
        [JsonPropertyName("value")]
        public double? Value { set; get; }

    }
    [Serializable]
    public class Exposure
    {
        [JsonPropertyName("auto")]
        public bool? Auto { get; set; }
        [JsonPropertyName("value")]
        public double? Value { set; get; }
        [JsonPropertyName("auto-max")]
        public int? AutoMax { get; set; }
        [JsonPropertyName("auto-reference")]
        public int? AutoReference { get; set; }

    }
    [Serializable]
    public class Trigger
    {
        [JsonPropertyName("enable")]
        public bool? Enable { get; set; }
        [JsonPropertyName("polarity")]
        public bool? Polarity { get; set; }
        [JsonPropertyName("delay")]
        public double? Delay { set; get; }

    }
    // 临时
    public class MultiObjective
    {
        public bool? Enable { get; set; } = false;
       
    }







}
