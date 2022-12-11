using Global.Common;
using System.Text.Json.Serialization;

namespace Global.SettingUp.Configure
{
    /// <summary>
    /// DLL更新
    /// </summary>
    public class FirmwareUpdate : ViewModelBase
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 版本
        /// </summary>
        public string Version { get; set; }
        /// <summary>
        /// 更新日期
        /// </summary>
        public string UpdateTime { get; set; }

        /// <summary>
        /// 更新日大小
        /// </summary>
        public string UpdateSize { get; set; }

        /// <summary>
        /// 更新连接
        /// </summary>
        public string UpdateUrl { get; set; }
    }

    /// <summary>
    /// 光源配置参数
    /// </summary>
    public class LightSourceConfig : ViewModelBase
    {
        /// <summary>
        /// 硬件版本
        /// </summary>
        public string Version { get; set; }
        /// <summary>
        /// LED行列数
        /// </summary>
        public int LEDRowsAndColumns { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string LEDSpacing { get; set; }
        public string LEDHeight { get; set; }
        public string LEDColors { get; set; }
        public string LEDCenterWavelength { get; set; }
        public string MaxRefreshRate { get; set; }
        public string MaxNumericalAperture { get; set; }
        public string MaxBrightness { get; set; }
    }

    public class CameraConfig : ViewModelBase
    {
        public string CameraModel { get; set; }
        public List<string> SupportResolution { get; set; }

        public string TargetSize { get; set; }

        public string SensorSize { get; set; }

        public string MAXFrameRate { get; set; }

        public string DynamicRange { get; set; }

        public int ImageFlip { get; set; }

        public TriggerMode TriggerMode { get; set; }
    }

    public enum TriggerMode
    {
        Hardware,
        SoftWare
    }


    public class StageConfig : ViewModelBase
    {
        public string Version { get; set; }

        public StageInfo Accuracy { get; set; }

        public StageInfo Range { get; set; }
    }

    public class StageStep :ViewModelBase
    {
        public int Fine { get; set; }

        public int Coarse { get; set; }
    }
    public class StageInfo : ViewModelBase
    {
        public string X { get; set; }
        public string Y { get; set; }

        public string Z { get; set; }
    }

    public class ObjectiveConfig :ViewModelBase
    {
        /// <summary>
        /// 型号
        /// </summary>
        public string Brand { get; set; }
        /// <summary>
        /// 倍数
        /// </summary>
        public int Magnitude { get; set; }

        /// <summary>
        /// 放大倍数
        /// </summary>
        public double Multiple { get; set; }

        /// <summary>
        /// 工作距离
        /// </summary>
        public string WorkingDistance { get; set; }

        /// <summary>
        /// 数值孔径
        /// </summary>
        [JsonPropertyName("N.A") ]
        public double NA { get; set; }

        /// <summary>
        /// 消色差
        /// </summary>
        public bool Achromatic { get; set; }
    }

}
