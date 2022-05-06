using Global;
using Global.Mode;
using Global.Mode.Config;
using Newtonsoft.Json;
using System.Text;
using System.Windows.Input;

namespace Mode
{
    /// <summary>
    /// 本软件配置文件实体类
    /// </summary>
    [Serializable]
    public class Config: ModeBaseObject
    {
        [JsonProperty("version")]
        public string? Version { get; set; }
       
        [JsonProperty("modules")]
        public Modules? Modules { get; set; }
        [JsonProperty("last-visit-time")]
        public string LastOpenTime { get; set; } = DateTime.Now.ToString("YYYY-MM-dd HH:mm:ss");

        [JsonProperty("lambda-manager")]
        public LambdaManager LambdaManager { get; set; }
        
        [JsonProperty("firmware")]
        public Firmware FirmwareSetting { get; set; }

        [JsonProperty("config-stage")]
        public Stage Stage { get; set; } = new();
        [JsonProperty("config-spot")]
        public Spot Spot { get; set; } = new();

        [JsonProperty("config-imaging-mode")]
        public ViewMode ViewMode { get; set; } = new ViewMode();

        [JsonProperty("config-multi-dimensional")]
        public Dimensional Dimensional { get; set; } = new();

        [JsonProperty("log-file")]
        public string? LogFile { get; set; }

        public Hotkey Hotkey { get; set; }
    }



    [Serializable]
    public class Hotkey
    {
        [JsonProperty("Key")]
        public Key Key { get; }
        [JsonProperty("Modifiers")]
        public ModifierKeys Modifiers { get; }
        public Hotkey(Key key, ModifierKeys modifiers)
        {
            Key = key;
            Modifiers = modifiers;
        }

        public override string ToString()
        {
            var str = new StringBuilder();
            if (Modifiers.HasFlag(ModifierKeys.Windows))
                str.Append("Win + ");
            if (Modifiers.HasFlag(ModifierKeys.Control))
                str.Append("Ctrl + ");
            if (Modifiers.HasFlag(ModifierKeys.Shift))
                str.Append("Shift + ");
            if (Modifiers.HasFlag(ModifierKeys.Alt))
                str.Append("Alt + ");


            str.Append(Key);
            return str.ToString();
        }
    }

    [Serializable]
    public class Modules
    {
        [JsonProperty("lambda_manager")]
        public string? LambdaManager { get; set; } = "1.0";
        [JsonProperty("config-dpc-mode")]
        public string? ConfigDpcMode { get; set; } = "1.0";
        [JsonProperty("config-stage")]
        public string? ConfigStage { get; set; } = "1.0";
        [JsonProperty("config-spot")]
        public string? ConfigSpot { get; set; } = "1.0";
        [JsonProperty("config-dof")]
        public string? ConfigDof { get; set; } = "1.0";
        [JsonProperty("config-multi-dimensional")]
        public string? ConfigMultiDimensional { get; set; } = "1.0";
        [JsonProperty("dpc-algorithm")]
        public string? DpcAlgorithm { get; set; } = "1.0";
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
    public class Firmware
    {
        [JsonProperty("objective")]
        public ObjectiveSetting? ObjectiveSetting { get; set; }

        [JsonProperty("camera")]
        public Camera? CameraSetting { get; set; } = new ();

        [JsonProperty("source")]
        public Source? Source { get; set; }
    }



    [Serializable]
    public class Source
    {
        [JsonProperty("fpga-version")]
        public string FpgaVersion { get; set; } = "1.0";
        [JsonProperty("max-bright")]
        public int MaxBright { get; set; } = new();

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
