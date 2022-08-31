
using Global.Common;
using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Text.Json.Serialization;

namespace Global.Mode.Config
{
    [Serializable]
    public class MulDimensional: ViewModelBase
    {
        public void Set(MulDimensional mulDimensional)
        {
            ZEnable = mulDimensional.ZEnable;
            ZStart = mulDimensional.ZStart;
            ZEnd = mulDimensional.ZEnd;
            Zstep=mulDimensional.Zstep;
            ZAbsolute=mulDimensional.ZAbsolute;
            TEnable = mulDimensional.TEnable;
        }
        
        public List<MulDimensionalArea> mulDimensionalAreas { get; set; } = new List<MulDimensionalArea> { };
        public List<MulDimensionalPoint> mulDimensionalPoints { get; set; } = new List<MulDimensionalPoint> { };

        public List<string> TIntervalUnitsList { get; set; } = new List<string> {"秒","分钟","小时","天"};

        private string tIntervalUnits = "小时";
        public string TIntervalUnits 
        {
            get { return tIntervalUnits; }
            set { tIntervalUnits = value;
                 NotifyPropertyChanged();
            }
        }
        
       

        private bool optimizedSel=false;
        public bool OptimizedSel
        {
            get { return optimizedSel; }
            set
            {
                optimizedSel = value; NotifyPropertyChanged();
            }
        }

        private bool userDefinedSel = false;
        public bool UserDefinedSel
        {
            get { return userDefinedSel; }
            set
            {
                userDefinedSel = value; NotifyPropertyChanged();
            }
        }





        [JsonPropertyName("Z-Enable")]
        public bool ZEnable { get; set; } = false;

        private int zStart = 16;
        [JsonPropertyName("Z-Start")]
        public int ZStart
        {
            get { return zStart; }
            set
            {
                zStart = value;
                NotifyPropertyChanged();
            }
        }

        private int zEnd = 32;

        [JsonPropertyName("Z-End")]
        public int ZEnd
        {
            get { return zEnd; }
            set 
            { 
                zEnd = value;
                NotifyPropertyChanged();
            }
        }

        private int zstep = 200;
        [JsonPropertyName("Z-step")]
        public int Zstep
        {
            get { return zstep; }
            set
            {
                zstep = value;
                NotifyPropertyChanged();
            }
        }
        private bool zAbsolute = false;

        public bool ZAbsolute
        {
            get { return zAbsolute; }
            set
            { 
                zAbsolute = value;
                NotifyPropertyChanged();
            }
        }

        private bool tEnable = false;

        public bool TEnable
        {
            get { return tEnable; }
            set { 
                tEnable = value;
                NotifyPropertyChanged();
            }
        }


        public bool TNumberEnable { get; set; } = false;

        private int tNumber = 15;

        [JsonPropertyName("T-Number")]
        public int TNumber
        {
            get { return tNumber ; }
            set { 
                tNumber = value;
                NotifyPropertyChanged();
            }
        }



        public bool TBooleanEnable { get; set; }  
        

        private bool tIntervalEnable = false;
        public bool TIntervalEnable
        {
            get { return tIntervalEnable; }
            set
            {
                tIntervalEnable = value;
                NotifyPropertyChanged();
            }
        }


        private string tInterval = "16";

        [JsonPropertyName("T-Interva")]
        public string TInterval
        {
            get { return tInterval; }
            set {
                tInterval = value;
                NotifyPropertyChanged();
            }
        }


        private bool focusEnable = true;

        public bool FocusEnable
        {
            get { return focusEnable; }
            set
            {
                focusEnable = value;
                NotifyPropertyChanged();
            }
        }

        private int focusMode  = 0;
        public int FocusMode
        {
            get { return focusMode; }
            set
            {
                focusMode = value;
                NotifyPropertyChanged();
            }
        }

        // FOCUS MODE
        private bool setEnable = false;
        public bool SetEnable
        {
            get { return setEnable; }
            set
            {
                setEnable = value;
                NotifyPropertyChanged();
            }
        }



        // t-wise 

        private bool twiseEnable = true;
        public bool TwiseEnable
        {
            get { return twiseEnable; }
            set
            {
                twiseEnable = value;
                NotifyPropertyChanged();
            }
        }
        private bool tFirst=false;
       public bool TFirst
        {
            get { return tFirst; }
            set
            {
                tFirst = value;
                NotifyPropertyChanged();
            }
        }
        private bool tEvery=false;
        public bool TEvery
        {
            get { return tEvery; }
            set
            {
                tEvery = value;
                NotifyPropertyChanged();
            }
        }
        private bool tN = false;
        public bool TN
        {
            get { return tN; }
            set
            {
                tN = value;
                NotifyPropertyChanged();
            }
        }

        private int tWiseN = 10;
        public int TWiseN
        {
            get { return tWiseN; }
            set
            {
                tWiseN = value;
                NotifyPropertyChanged();
            }
        }

        //p-wise
        private bool pwiseEnable = true;
        public bool PwiseEnable
        {
            get { return pwiseEnable; }
            set
            {
                pwiseEnable = value;
                NotifyPropertyChanged();
            }
        }


        private bool pFirst= false;
        public bool PFirst
        {
            get { return pFirst; }
            set
            {
                pFirst = value;
                NotifyPropertyChanged();
            }
        }
        private bool pEvery = false;
        public bool PEvery
        {
            get { return pEvery; }
            set
            {
                pEvery = value;
                NotifyPropertyChanged();
            }
        }
        private bool pN = false;
        public bool PN
        {
            get { return pN; }
            set
            {
                pN = value;
                NotifyPropertyChanged();
            }
        }



        private int pWiseN = 20;
        public int PWiseN
        {
            get { return pWiseN; }
            set
            {
                pWiseN = value;
                NotifyPropertyChanged();
            }
        }



        private Optimize optimized = new Optimize();
     public Optimize Optimized
        {
            get { return optimized; }
            set 
            {
                optimized = value;
                NotifyPropertyChanged();
            }
        }

        private UserDefine  userDefined = new UserDefine();
        public UserDefine UserDefined
        {
            get { return userDefined; }
            set
            {
                userDefined = value;
                NotifyPropertyChanged();
            }
        }




    }


    public class Optimize : ViewModelBase
    {

        private bool isGlobal = false;
        public bool IsGlobal 
        { get { return isGlobal; } 
            set { isGlobal = value; 
                NotifyPropertyChanged(); 
            } 
        }
        private bool isLocal = false;
        public bool IsLocal
        {
            get { return isLocal; }
            set
            {
                isLocal = value;
                NotifyPropertyChanged();
            }
        }

        private int global = 1;

        public int Global
        {
            get { return global; }
            set
            {
                global = value;
                NotifyPropertyChanged();
            }
        }

        private int local = 2;

        public int Local
        {
            get { return local; }
            set
            {
                local = value;
                NotifyPropertyChanged();
            }
        }
        private int precision = 5;
        public int Precision
        {
            get { return precision; }
            set
            {
                precision = value;
                NotifyPropertyChanged();

            }
        }


      
    }
    public class UserDefine : ViewModelBase
    {
        private bool isGlobal = false;
        public bool IsGlobal
        {
            get { return isGlobal; }
            set
            {
                isGlobal = value;
                NotifyPropertyChanged();
            }
        }
        private bool isLocal = false;
        public bool IsLocal
        {
            get { return isLocal; }
            set
            {
                isLocal = value;
                NotifyPropertyChanged();
            }
        }



        private int global = 3;

        public int Global
        {
            get { return global; }
            set
            {
                global = value;
                NotifyPropertyChanged();
            }
        }

        private int local = 5;

        public int Local
        {
            get { return local; }
            set
            {
                local = value;
                NotifyPropertyChanged();
            }
        }
        private int precision = 2;
        public int Precision
        {
            get { return precision; }
            set
            {
                precision = value;
                NotifyPropertyChanged();

            }
        }

    }




    public class MulDimensionalPoint
    {
        public MulDimensionalPoint(System.Windows.Point point)
        {
            X = (int)point.X;
            Y = (int)point.Y;
        }
        public MulDimensionalPoint(System.Drawing.Point point)
        {
            X = point.X;
            Y = point.Y;
        }
        [JsonPropertyName("X")]
        public int X { get; set; }
        [JsonPropertyName("Y")]
        public int Y { get; set; }
    }

    public class MulDimensionalArea
    {
        public MulDimensionalArea(System.Windows.Rect rectangle)
        {
            X = (int)rectangle.Top;
            Y = (int)rectangle.Left;
            Width = (int)rectangle.Width;
            Height = (int)rectangle.Height;
        }
        public MulDimensionalArea(System.Drawing.Rectangle rectangle)
        {
            X = rectangle.Top;
            Y = rectangle.Left;
            Width = rectangle.Width;
            Height = rectangle.Height;
        }

        public MulDimensionalArea()
        {

        }
        [JsonPropertyName("X")]
        public int X { get; set; }
        [JsonPropertyName("Y")]
        public int Y { get; set; }
        [JsonPropertyName("Width")]
        public int Width { get; set; }
        [JsonPropertyName("Height")]
        public int Height { get; set; }
    }
}
