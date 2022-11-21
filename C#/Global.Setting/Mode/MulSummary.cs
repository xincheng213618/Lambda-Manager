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
        private string collectionTimes = "";
        /// <summary>
        /// 采集次数
        /// </summary>
        public string CollectionTimes
        {
            get { return collectionTimes; }
            set { if (value != null&& value != collectionTimes) 
                    collectionTimes = value; NotifyPropertyChanged(); }
        }

        private string collectionLayers = "";
        /// <summary>
        /// 采集层数
        /// </summary>
        public string CollectionLayers
        {
            get { return collectionLayers; }
            set { if (value != null && value != collectionLayers) 
                    collectionLayers = value; NotifyPropertyChanged(); }
        }

        private string collectionPoints = "";
        /// <summary>
        /// 采集点个数
        /// </summary>
        public string CollectionPoints
        {
            get { return collectionPoints; }
            set { if (value != null && value != collectionPoints)
                    collectionPoints = value; NotifyPropertyChanged(); }
        }

        private string viewModeCounts = "";
        /// <summary>
        /// 成像模式数
        /// </summary>
        public string ViewModeCounts
        {
            get { return viewModeCounts; }
            set { if (value != null && value != viewModeCounts)
                    viewModeCounts = value; NotifyPropertyChanged(); }
        }

        private string fluorescenceChannels = "";
        /// <summary>
        /// 荧光通道数
        /// </summary>
        public string FluorescenceChannels
        {
            get { return fluorescenceChannels; }
            set { if (value != null && value != fluorescenceChannels)
                    fluorescenceChannels = value; NotifyPropertyChanged(); }
        }

        private string imageSize = "";
        /// <summary>
        /// 图像尺寸
        /// </summary>
        public string ImageSize
        {
            get { return imageSize; }
            set { if (value != null && value != imageSize)
                    imageSize = value; NotifyPropertyChanged(); }
        }

        private string imageNums = "";
        /// <summary>
        /// 图像总数
        /// </summary>
        public string ImageNums
        {
            get { return imageNums; }
            set { if (value != null && value != imageNums)
                    imageNums = value; NotifyPropertyChanged(); }
        }

        private string storage = "";
        /// <summary>
        /// 图像总数
        /// </summary>
        public string Storage
        {
            get { return storage; }
            set { if (value != null && value != storage)
                    storage = value; NotifyPropertyChanged(); }
        }

        private string allCollectionTime = "";
        /// <summary>
        /// 全部采集耗时
        /// </summary>
        public string AllCollectionTime
        {
            get { return allCollectionTime; }
            set { if (value != null && value != allCollectionTime)
                    allCollectionTime = value; NotifyPropertyChanged(); }
        }

        private string cameraWorkingTime = "";
        /// <summary>
        /// 相机工作时长
        /// </summary>
        public string CameraWorkingTime
        {
            get { return cameraWorkingTime; }
            set { if (value != null && value != cameraWorkingTime)
                    cameraWorkingTime = value; NotifyPropertyChanged(); }
        }
        

    }
}
