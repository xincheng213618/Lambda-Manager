using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Mode
{
    public class UpdateStatus :INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(propertyyName)));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private string imageX = "X:1234";

        public string ImageX

        {
            get { return imageX; }
            set {
                if (value != null)
                {
                    imageX = value;
                    NotifyPropertyChanged();
                }

            }
        }

        private string imageY = "Y:1234";

        public string ImageY

        {
            get { return imageY; }
            set
            {
                if (value != null)
                {
                    imageY = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private string imageZ = "Z:1234";

        public string ImageZ

        {
            get { return imageZ; }
            set
            {
                if (value != null)
                {
                    imageZ = value;
                    NotifyPropertyChanged();
                }

            }
        }
        private string imageSize = "1280";

        public string ImageSize

        {
            get { return imageSize; }
            set
            {
                if (value != null)
                {
                    imageSize = value;
                    NotifyPropertyChanged();
                }

            }
        }

        public string imageFocus;
        public string ImageFocus

        {
            get { return imageFocus; }
            set
            {
                if (value != null)
                {
                    imageFocus = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public string createTime;
        public string CreateTime

        {
            get { return createTime; }
            set
            {
                if (value != null)
                {
                    createTime = value;
                    NotifyPropertyChanged();
                }
            }
        }
        
        public string frameIndex;
        public string FrameIndex

        {
            get { return frameIndex; }
            set
            {
                if (value != null)
                {
                    frameIndex = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public string totalFrame;
        public string TotalFrame

        {
            get { return totalFrame; }
            set
            {
                if (value != null)
                {
                    totalFrame = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public string timeElapsed;
        public string TimeElapsed

        {
            get { return timeElapsed; }
            set
            {
                if (value != null)
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
                if (value != null)
                {
                    totalTime = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public string sliceIndex;
        public string SliceIndex

        {
            get { return sliceIndex; }
            set
            {
                if (value != null)
                {
                    sliceIndex = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public string totalSlice;
        public string TotalSlice

        {
            get { return totalSlice; }
            set
            {
                if (value != null)
                {
                    totalSlice = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public string zTop;
        public string ZTop

        {
            get { return zTop; }
            set
            {
                if (value != null)
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
                if (value != null)
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
                if (value != null)
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
                if (value != null)
                {
                    ratio = value;
                    NotifyPropertyChanged();
                }
            }
        }



        public string fpsState ;
        public string FpsState

        {
            get { return fpsState; }
            set
            {
                if (value != null)
                {
                    fpsState = value;
                    NotifyPropertyChanged();
                }
            }
        }





    }
}
