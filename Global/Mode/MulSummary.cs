using Global.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Global.Mode
{
    public class MulSummary:ViewModelBase
    {
        private string collectionTimes = "0";
        /// <summary>
        /// 采集次数
        /// </summary>
        public string CollectionTimes
        {
            get { return collectionTimes; }
            set { collectionTimes = value; NotifyPropertyChanged(); }
        }

        private string collectionLayers = "0";
        /// <summary>
        /// 采集层数
        /// </summary>
        public string CollectionLayers
        {
            get { return collectionLayers; }
            set { collectionLayers = value; NotifyPropertyChanged(); }
        }

        private string collectionPoints = "0";
        /// <summary>
        /// 采集点个数
        /// </summary>
        public string CollectionPoints
        {
            get { return collectionPoints; }
            set { collectionPoints = value; NotifyPropertyChanged(); }
        }

        private string viewModeCounts = "0";
        /// <summary>
        /// 成像模式数
        /// </summary>
        public string ViewModeCounts
        {
            get { return viewModeCounts; }
            set { viewModeCounts = value; NotifyPropertyChanged(); }
        }

        private string fluorescenceChannels = "0";
        /// <summary>
        /// 荧光通道数
        /// </summary>
        public string FluorescenceChannels
        {
            get { return fluorescenceChannels; }
            set { fluorescenceChannels = value; NotifyPropertyChanged(); }
        }

        private string imageSize = "";
        /// <summary>
        /// 图像尺寸
        /// </summary>
        public string ImageSize
        {
            get { return imageSize; }
            set { imageSize = value; NotifyPropertyChanged(); }
        }

        private string imageNums = "";
        /// <summary>
        /// 图像总数
        /// </summary>
        public string ImageNums
        {
            get { return imageNums; }
            set { imageNums = value; NotifyPropertyChanged(); }
        }

        private string storage = "";
        /// <summary>
        /// 图像总数
        /// </summary>
        public string Storage
        {
            get { return storage; }
            set { storage = value; NotifyPropertyChanged(); }
        }

        private string allCollectionTime = "";
        /// <summary>
        /// 全部采集耗时
        /// </summary>
        public string AllCollectionTime
        {
            get { return allCollectionTime; }
            set { allCollectionTime = value; NotifyPropertyChanged(); }
        }

        private string cameraWorkingTime = "";
        /// <summary>
        /// 相机工作时长
        /// </summary>
        public string CameraWorkingTime
        {
            get { return cameraWorkingTime; }
            set { cameraWorkingTime = value; NotifyPropertyChanged(); }
        }
        

    }
}
