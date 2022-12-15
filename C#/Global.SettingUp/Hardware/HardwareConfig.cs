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

    /// <summary>
    /// 硬件配置表
    /// </summary>
    public class HardwareConfig:ViewModelBase
    {
        /// <summary>
        /// 物镜配置
        /// </summary>
        public ObjectiveConfig ObjectiveConfig { get; set; } = new ObjectiveConfig();

        /// <summary>
        /// 光源配置
        /// </summary>
        public LightSourceConfig LightSourceConfig { get; set; } = new LightSourceConfig();

    }

    public class HardwareConfigBase : ViewModelBase
    {
        /// <summary>
        /// 型号
        /// </summary>
        public string Version { get => _Version; set {_Version = value; NotifyPropertyChanged(); } }
        private string _Version = string.Empty;       
    }

    /// <summary>
    /// 物镜配置
    /// </summary>
    public class ObjectiveConfigBase : HardwareConfigBase
    {

        public ObjectiveConfigBase(int Magnitude,double NA)
        {
            this.Magnitude = Magnitude;
            this.NA = NA;
        }
        /// <summary>
        /// 放大倍数
        /// </summary>
        public int Magnitude { get; set; }

        /// <summary>
        /// 放大倍数
        /// </summary>
        public string MagnitudeName { get; set; }

        /// <summary>
        /// 数值孔径
        /// </summary>
        [JsonPropertyName("N.A")]
        public double NA { get; set; }
    }

    public class ObjectiveConfig : HardwareConfigBase
    {
        public List<ObjectiveConfigBase> AvailableObjectives { get; set; } = new List<ObjectiveConfigBase>();


        private ObjectiveConfigBase selectObjective = null;

        public ObjectiveConfigBase SelectObjective { get => selectObjective; set 
            {
                selectObjective = value;
                NotifyPropertyChanged();
                this.Magnitude = selectObjective.Magnitude;
                this.NA = selectObjective.NA;
            }
        }


        private int magnitude;
        /// <summary>
        /// 放大倍数
        /// </summary>
        public int Magnitude
        {
            get => magnitude;
            set
            {
                magnitude = value;
                NotifyPropertyChanged();
            }
        }


        private double na;
        /// <summary>
        /// 数值孔径
        /// </summary>
        [JsonPropertyName("N.A")]
        public double NA
        {
            get =>na;
            set 
            { 
                na = value;
                NotifyPropertyChanged();
            }
        }




    }




}
