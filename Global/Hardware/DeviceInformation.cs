using Global.Common;
using Global.Mode.Config;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Global.Hardware
{
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
        public ExposureViewMode()
        {
        }


        public void SetValue(double Exposure)
        {
            if (exposure> ExposureInfos[ExposureInfos.Count - 1].Exposure)
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
}
