using Global.Common;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace Global.Hardware
{
    public class ObjectiveSetting
    {
        public int ID { get; set; }
        public string Name { get; set; }

        [JsonPropertyName("magnitude")]
        public string Magnitude { get; set; }

        [JsonPropertyName("N.A")]
        public double NA { get; set; }
        public bool IsEnabled { get; set; } = true;
        public bool IsChecked { get; set; } = false;
    }

    public class DeviceInformation : ViewModelBase
    {
        //Objectiv
        public ObservableCollection<ObjectiveSetting> ObjectiveSettings = new ObservableCollection<ObjectiveSetting>();
        //相机曝光
        public List<double> CameraExpose;

        public List<string> CameraExposeShow;

        public ObservableCollection<ExposureInfo> ExposureInfos = new ObservableCollection<ExposureInfo>();

        public List<string> CameraResolution;   
    }

    public class ExposureInfo : ViewModelBase
    {
        private string exposureShow;
        /// <summary>
        /// 展示数据
        /// </summary>
        public string ExposureShow
        {
            get { return exposureShow; }
            set { exposureShow = value; NotifyPropertyChanged(); }
        }

        private double exposure;
        /// <summary>
        /// 展示数据
        /// </summary>
        public double Exposure
        {
            get { return exposure; }
            set { exposure = value; NotifyPropertyChanged(); }
        }
    }

    public class ExposureViewMode : ViewModelBase
    {
        public ObservableCollection<ExposureInfo> ExposureInfos = new ObservableCollection<ExposureInfo>();
        public bool IsBackGroundChanged = false;

        public void SetValue(double Exposure)
        {
            IsBackGroundChanged = true;
            if (_Exposure> ExposureInfos[ExposureInfos.Count - 1].Exposure)
            {
                index = ExposureInfos.Count - 1;
                this.Exposure = Exposure;
                this.ExposureShow = Exposure.ToString();
            }

            for (int i = 0; i < ExposureInfos.Count -1; i++)
            {
                if (Exposure > ExposureInfos[i].Exposure && Exposure <= ExposureInfos[i + 1].Exposure)
                {
                    if (ExposureInfos[i].Exposure + ExposureInfos[i + 1].Exposure - 2 * Exposure <= 0)
                    {
                        Index = i + 1;
                    }
                    else
                    {
                        Index = i;
                    }
                    this.Exposure = Exposure;
                    this.ExposureShow = Exposure.ToString();
                    break;
                }
            }
            IsBackGroundChanged = false;
        }


        private int index = 0;
        /// <summary>
        /// 序号
        /// </summary>
        public int Index
        {
            get { return index; }
            set
            {
                if (value != index && value >= 0 && value < ExposureInfos.Count)
                {
                    index = value;
                    ExposureShow = ExposureInfos[index].ExposureShow;
                    Exposure = ExposureInfos[index].Exposure;
                    NotifyPropertyChanged();
                }
            }
        }

        /// <summary>
        /// 展示数据
        /// </summary>
        public string ExposureShow { get => _ExposureShow; set { _ExposureShow = value; NotifyPropertyChanged(); } }
        private string _ExposureShow;

        /// <summary>
        /// 展示数据
        /// </summary>
        public double Exposure { get => _Exposure; set { _Exposure = value; NotifyPropertyChanged(); } }

        private double _Exposure;

    }
}
