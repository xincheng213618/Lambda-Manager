using Global.Common;
using Lambda;
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
        public string Version { get => _Version; set { _Version = value; NotifyPropertyChanged();} }
        private string _Version;

        /// <summary>
        /// LED行列数
        /// </summary>
        public string LEDRowsAndColumns { get => _LEDRowsAndColumns; set { _LEDRowsAndColumns = value; NotifyPropertyChanged(); } }
        private string _LEDRowsAndColumns;

        /// <summary>
        /// LED间距
        /// </summary>
        public string LEDSpacing { get => _LEDSpacing; set { _LEDSpacing = value; NotifyPropertyChanged(); } }
        private string _LEDSpacing;

        /// <summary>
        /// LED高度
        /// </summary>
        public string LEDHeight { get => _LEDHeight; set { _LEDHeight = value; NotifyPropertyChanged(); } }
        private string _LEDHeight;

        /// <summary>
        /// LED颜色Bit数
        /// </summary>
        public string LEDColors { get => _LEDColors; set { _LEDColors = value; NotifyPropertyChanged(); } }
        private string _LEDColors;


        /// <summary>
        /// LED中心波长
        /// </summary>
        public string LEDCenterWavelength { get => _LEDCenterWavelength; set { _LEDCenterWavelength = value; NotifyPropertyChanged(); } }
        private string _LEDCenterWavelength;

        /// <summary>
        /// 照明模式最高刷新速率
        /// </summary>
        public string MaxRefreshRate { get => _MaxRefreshRate; set { _MaxRefreshRate = value; NotifyPropertyChanged(); } }
        private string _MaxRefreshRate;


        /// <summary>
        /// 照明最大数值孔径
        /// </summary>
        public string MaxNumericalAperture { get => _MaxNumericalAperture; set { _MaxNumericalAperture = value; NotifyPropertyChanged(); } }
        private string _MaxNumericalAperture;
        /// <summary>
        /// 照明亮度
        /// </summary>
        public string MaxBrightness { get => _MaxBrightness; set { _MaxBrightness = value; NotifyPropertyChanged(); } }
        private string _MaxBrightness;

    }

    public class CameraConfig : ViewModelReg
    {
        /// <summary>
        /// 相机型号
        /// </summary>
        public string CameraModel { get => _CameraModel; set { _CameraModel = value; NotifyPropertyChanged(); } }
        private string _CameraModel;

        /// <summary>
        /// 支持的分辨率
        /// </summary>
        public List<string> SupportResolution { get; set; } = new List<string>();

        /// <summary>
        /// 相机靶面大小
        /// </summary>
        public string TargetSize { get => _TargetSize; set { _TargetSize = value; NotifyPropertyChanged(); } }
        private string _TargetSize;

        /// <summary>
        /// 传感器大小
        /// </summary>
        public string SensorSize { get => _SensorSize; set { _SensorSize = value; NotifyPropertyChanged(); } }
        private string _SensorSize;

        /// <summary>
        /// 最高帧率
        /// </summary>
        public string MAXFrameRate { get => _MAXFrameRate; set { _MAXFrameRate = value; NotifyPropertyChanged(); } }
        private string _MAXFrameRate;

        /// <summary>
        /// 动态范围
        /// </summary>
        public string DynamicRange { get => _DynamicRange; set { _DynamicRange = value; NotifyPropertyChanged(); } }
        public string _DynamicRange;

        //图像翻转Vertical
        public bool ImageFlipV { get => _ImageFlipV; set { _ImageFlipV = value; LambdaControl.Trigger("CameraSettingFlipV", this, new Dictionary<string, object>() { { "bflip",value  } }); WriteRegValue(value); NotifyPropertyChanged(); } }
        private bool _ImageFlipV = ReadRegValue(nameof(ImageFlipV));

        //图像翻转Horizon
        public bool ImageFlipH { get => _ImageFlipH; set { _ImageFlipH = value; LambdaControl.Trigger("CameraSettingFlipH", this, new Dictionary<string, object>() { { "bflip", value } }); WriteRegValue(value); NotifyPropertyChanged(); } }
        private bool _ImageFlipH = ReadRegValue(nameof(ImageFlipH));

        /// <summary>
        /// 触发模式
        /// </summary>
        public string TriggerMode { get => _TriggerMode; set { _TriggerMode = value; NotifyPropertyChanged(); } }
        public string _TriggerMode;
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


    public class ObjectiveConfigs:ViewModelBase
    {
        public List<double> AvailableNA { get; set; } = new List<double>();
        public List<ObjectiveConfig> AvailableObjectives
        {
            get => _AvailableObjectives; set
            {
                _AvailableObjectives = value;
                AvailableNA.Clear();
                foreach (var item in value)
                {
                    AvailableNA.Add(item.NA);
                } 
            }
        }
        private List<ObjectiveConfig> _AvailableObjectives = new List<ObjectiveConfig>();


        public ObjectiveConfig CurrentObjectiveConfig { get; set; }

    }

    public class ObjectiveConfig :ViewModelBase
    {

        /// <summary>
        /// 序号
        /// </summary>
        public int No { get; set; }
        /// <summary>
        /// 型号
        /// </summary>
        public string Brand { get; set; }
        /// <summary>
        /// 倍数
        /// </summary>
        public int Magnitude { get; set; }

        /// <summary>
        /// 标示
        /// </summary>
        public string ObjectiveKey { get; set; }


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
