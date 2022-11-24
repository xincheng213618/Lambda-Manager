using Global;
using Global.Common;
using Global.Mode;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Global.Mode
{
    public class UpdateStatus : ViewModelBase
    {


        private string imageX = "X:1234";

        public string ImageX

        {
            get { return imageX; }
            set {
                if (!string.IsNullOrEmpty(value))
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
                if (!string.IsNullOrEmpty(value))
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
                if (!string.IsNullOrEmpty(value))
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
                if (!string.IsNullOrEmpty(value))
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
                if (!string.IsNullOrEmpty(value))
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
                if (!string.IsNullOrEmpty(value))
                {
                    createTime = value;
                    NotifyPropertyChanged();
                }
            }
        }
        
        public int frameIndex;
        public int FrameIndex
        {
            get { return frameIndex; }
            set
            {
                frameIndex = value;
                NotifyPropertyChanged();
            }
        }


        public int totalFrame = 0;
        public int TotalFrame

        {
            get { return totalFrame; }
            set
            {
                totalFrame = value;
                NotifyPropertyChanged();
            }
        }


        public string timeElapsed="00:00:00";
        public string TimeElapsed

        {
            get { return timeElapsed; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    timeElapsed = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string totalTime ="00:00:00";
        public string TotalTime
        {
            get { return totalTime; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    totalTime = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public int sliceIndex =0;
        public int SliceIndex
        {
            get { return sliceIndex; }
            set
            {
                sliceIndex = value;
                NotifyPropertyChanged();
            }
        }
        public int totalSlice = 0;
        public int TotalSlice
        {
            get { return totalSlice; }
            set
            {
                totalSlice = value;
                NotifyPropertyChanged();
            }
        }
        public string zTop= "0μm";
        public string ZTop
        {
            get { return zTop; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    zTop = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public string zCurrent= "0μm";
        public string ZCurrent

        {
            get { return zCurrent; }
            set
            {
                                if (!string.IsNullOrEmpty(value))
                {
                    zCurrent = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public string zBottom="0μm";
        public string ZBottom

        {
            get { return zBottom; }
            set
            {
                                if (!string.IsNullOrEmpty(value))
                {
                    zBottom = value;
                    NotifyPropertyChanged();
                }
            }
        }
        
        public int ratio=100;
        public int Ratio
        {
            get { return ratio; }
            set
            {
                    ratio = value;
                    NotifyPropertyChanged();  
            }
        }



        public string fpsState ;
        public string FpsState

        {
            get { return fpsState; }
            set
            {
                                if (!string.IsNullOrEmpty(value))
                {
                    fpsState = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private bool fpsEnable = false;
        public bool FpsEnable
        {
            get { return fpsEnable; }   
            set { 
                fpsEnable = value;
                NotifyPropertyChanged(); 
                 }
        }

        private bool bFToggEnable= false;
        public bool BFToggEnable

        {
            get { return bFToggEnable; }
            set
            {   
                bFToggEnable = value;
                NotifyPropertyChanged();

            }
        }

        private bool dFToggEnable = false;
        public bool DFToggEnable

        {
            get { return dFToggEnable; }
            set
            {
                 dFToggEnable = value;
                 NotifyPropertyChanged();
                
            }
        }
        

        private bool rIToggEnable = false;
        public bool RIToggEnable

        {
            get { return rIToggEnable; }
            set
            {
                rIToggEnable = value;
                NotifyPropertyChanged();

            }
        }

        private bool dPToggEnable = false;
        public bool DPToggEnable

        {
            get { return dPToggEnable; }
            set
            {
                dPToggEnable = value;
                NotifyPropertyChanged();

            }
        }
        
        private bool qPToggEnable = false;
        public bool QPToggEnable

        {
            get { return qPToggEnable; }
            set
            {
                qPToggEnable = value;
                NotifyPropertyChanged();

            }
        }

        
              private bool pCToggEnable = false;
        public bool PCToggEnable

        {
            get { return pCToggEnable; }
            set
            {
                pCToggEnable = value;
                NotifyPropertyChanged();

            }
        }
        // IS CHECKED
        private bool bFCheckEnable = false;
        public bool BFCheckEnable

        {
            get { return bFCheckEnable; }
            set
            {
                bFCheckEnable = value;
                NotifyPropertyChanged();

            }
        }
        
        private bool dFCheckEnable = false;
        public bool DFCheckEnable

        {
            get { return dFCheckEnable; }
            set
            {
                dFCheckEnable = value;
                NotifyPropertyChanged();

            }
        }


        private bool rICheckEnable = false;
        public bool RICheckEnable

        {
            get { return rICheckEnable; }
            set
            {
                rICheckEnable = value;
                NotifyPropertyChanged();

            }
        }
        //差分
        private bool dPCheckEnable = false;
        public bool DPCheckEnable

        {
            get { return dPCheckEnable; }
            set
            {
                dPCheckEnable = value;
                NotifyPropertyChanged();

            }
        }
        // 相位
        private bool qPCheckEnable = false;
        public bool QPCheckEnable

        {
            get { return qPCheckEnable; }
            set
            {
                qPCheckEnable = value;
                NotifyPropertyChanged();

            }
        }

        //相差
        private bool pCCheckEnable = false;
        public bool PCCheckEnable

        {
            get { return pCCheckEnable; }
            set
            {
                pCCheckEnable = value;
                NotifyPropertyChanged();

            }
        }


        private bool startEnable = false;
        public bool StartEnable

        {
            get { return startEnable; }
            set
            {
                startEnable = value;
                NotifyPropertyChanged();

            }
        }

        private bool stopEnable = false;
        public bool StopEnable

        {
            get { return stopEnable; }
            set
            {
                stopEnable = value;
                NotifyPropertyChanged();

            }
        }


        private bool forwardEnbale = false;
        public bool ForwardEnbale

        {
            get { return forwardEnbale; }
            set
            {
                forwardEnbale = value;
                NotifyPropertyChanged();

            }
        }

        private bool backwardEnbale = false;
        public bool BackwardEnbale

        {
            get { return backwardEnbale; }
            set
            {
                backwardEnbale = value;
                NotifyPropertyChanged();

            }
        }

       


     






    }
}
