using Global.Common;

namespace LambdaManager.Mode
{
    public class UpdateStatus: ViewModelBase
    {
        private string imageX = string.Empty;

        public string ImageX

        {
            get { return imageX; }
            set
            {
                if (value != string.Empty &&value!=imageX)
                {
                    imageX = value;
                    NotifyPropertyChanged();
                }

            }
        }

        private string imageY = string.Empty;

        public string ImageY

        {
            get { return imageY; }
            set
            {
                if (value != string.Empty)
                {
                    imageY = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private string imageZ = string.Empty;

        public string ImageZ

        {
            get { return imageZ; }
            set
            {
                if (value != string.Empty)
                {
                    imageZ = value;
                    NotifyPropertyChanged();
                }

            }
        }
        private string imageSize = string.Empty;

        public string ImageSize

        {
            get { return imageSize; }
            set
            {
                if (value != string.Empty)
                {
                    imageSize = value;
                    NotifyPropertyChanged();
                }

            }
        }

        public string imageFocus = string.Empty;
        public string ImageFocus

        {
            get { return imageFocus; }
            set
            {
                if (value != string.Empty)
                {
                    imageFocus = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public string createTime = string.Empty;
        public string CreateTime

        {
            get { return createTime; }
            set
            {
                if (value != string.Empty)
                {
                    createTime = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public int frameIndex = 0;
        public int FrameIndex

        {
            get { return frameIndex; }
            set
            {
                frameIndex = value;
                NotifyPropertyChanged();
            }
        }


        public int totalFrame = 4;
        public int TotalFrame

        {
            get { return totalFrame; }
            set
            {
                totalFrame = value;
                NotifyPropertyChanged();
            }
        }


        public string timeElapsed =string.Empty;
        public string TimeElapsed

        {
            get { return timeElapsed; }
            set
            {
                if (value != string.Empty)
                {
                    timeElapsed = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string totalTime;
        public string TotalTime

        {
            get { return totalTime; }
            set
            {
                if (value != string.Empty)
                {
                    totalTime = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public int sliceIndex = 0;
        public int SliceIndex

        {
            get { return sliceIndex; }
            set
            {
                sliceIndex = value;
                NotifyPropertyChanged();
            }
        }
        public int totalSlice = 4;
        public int TotalSlice

        {
            get { return totalSlice; }
            set
            {
                totalSlice = value;
                NotifyPropertyChanged();
            }
        }
        public string zTop;
        public string ZTop

        {
            get { return zTop; }
            set
            {
                if (value != string.Empty)
                {
                    zTop = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public string zCurrent;
        public string ZCurrent

        {
            get { return zCurrent; }
            set
            {
                if (value != string.Empty)
                {
                    zCurrent = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public string zBottom;
        public string ZBottom
        {
            get { return zBottom; }
            set
            {
                if (value != string.Empty)
                {
                    zBottom = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string ratio;
        public string Ratio
        {
            get { return ratio; }
            set
            {
                if (value != string.Empty)
                {
                    ratio = value;
                    NotifyPropertyChanged();
                }
            }
        }
    }
}
