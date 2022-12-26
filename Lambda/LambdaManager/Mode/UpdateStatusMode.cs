using Global.Common;

namespace LambdaManager.Mode
{
    public class UpdateStatus: ViewModelBase
    {

        public string ImageX { get => _ImageX; set { if (value == string.Empty) return; _ImageX = value; NotifyPropertyChanged(); } }
        private string _ImageX;

        public string ImageY { get => _ImageY; set { if (value == string.Empty) return; _ImageY = value; NotifyPropertyChanged(); } }
        private string _ImageY;

        public string ImageZ { get => _ImageZ; set { if (value == string.Empty) return; _ImageZ = value; NotifyPropertyChanged(); } }
        private string _ImageZ;

        public string ImageSize { get => _ImageSize; set { if (value == string.Empty) return; _ImageSize = value; NotifyPropertyChanged(); } }
        private string _ImageSize;

        public string ImageFocus { get => _ImageFocus; set { if (value == string.Empty) return; _ImageFocus = value; NotifyPropertyChanged(); } }
        private string _ImageFocus;

        public string CreateTime { get => _CreateTime; set { if (value == string.Empty) return; _CreateTime = value; NotifyPropertyChanged(); } }
        private string _CreateTime;

        public int FrameIndex { get => _FrameIndex; set { _FrameIndex = value; NotifyPropertyChanged(); } }
        private int _FrameIndex =0;


        public int TotalFrame { get => _TotalFrame; set { _TotalFrame = value; NotifyPropertyChanged(); } }
        private int _TotalFrame = 4;

        public string TimeElapsed { get => _TimeElapsed; set { if (value == string.Empty) return; _TimeElapsed = value; NotifyPropertyChanged(); } }
        private string _TimeElapsed;

        public string TotalTime { get => _TotalTime; set { if (value == string.Empty) return; _TotalTime = value; NotifyPropertyChanged(); } }
        private string _TotalTime;

        public int SliceIndex { get => _SliceIndex; set { _SliceIndex = value; NotifyPropertyChanged(); } }
        private int _SliceIndex = 0;

        public int TotalSlice { get => _TotalSlice; set { _TotalSlice = value; NotifyPropertyChanged(); } }
        private int _TotalSlice = 0;

        public string ZTop { get => _ZTop; set { if (value == string.Empty) return; _ZTop = value; NotifyPropertyChanged(); } }
        private string _ZTop;

        public string ZCurrent { get => _ZCurrent; set { if (value == string.Empty) return; _ZCurrent = value; NotifyPropertyChanged(); } }
        private string _ZCurrent;

        public string ZBottom { get => _ZBottom; set { if (value == string.Empty) return; _ZBottom = value; NotifyPropertyChanged(); } }
        private string _ZBottom;

        public string Ratio { get => _Ratio; set { if (value == string.Empty) return;  _Ratio = value; NotifyPropertyChanged(); } }
        private string _Ratio;

    }
}
