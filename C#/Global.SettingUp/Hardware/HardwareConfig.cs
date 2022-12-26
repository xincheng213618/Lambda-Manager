using Global.Common;
using Global.SettingUp.Configure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Global.SettingUp.Hardware
{
    public delegate void HardwareConfigChangedHandler(HardwareConfig hardwareConfig);


    /// <summary>
    /// 硬件配置表
    /// </summary>
    public class HardwareConfig:ViewModelBase
    {
        public event HardwareConfigChangedHandler HardwareConfigChanged;

        public void INIEDInvoke()
        {
            HardwareConfigChanged?.Invoke(this);
        }

        /// <summary>
        /// 设备型号
        /// </summary>
        public string DeviceType { get => _DeviceType; set { _DeviceType = value; NotifyPropertyChanged(); } }
        private string _DeviceType = string.Empty;

        /// <summary>
        /// 安装尺寸
        /// </summary>
        public string InstallSize { get => _InstallSize; set { _InstallSize = value; NotifyPropertyChanged(); } }
        private string _InstallSize = string.Empty;

        

        /// <summary>
        /// 物镜配置
        /// </summary>
        public ObjectiveConfigs ObjectiveConfigs { get; set; } = new ObjectiveConfigs();

        /// <summary>
        /// 光源配置
        /// </summary>
        public LightSourceConfig LightSourceConfig { get; set; } = new LightSourceConfig();

        public CameraConfig CameraConfig { get; set; } = new CameraConfig();    

    }




}
