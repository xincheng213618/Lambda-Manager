
using Newtonsoft.Json;

namespace Global.Mode.Config
{
    public class MulDimensional: ModeBaseObject
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

        [JsonProperty("Z-Enable")]
        public bool ZEnable { get; set; } = false;

        

        private int zStart = 16;
        [JsonProperty("Z-Start")]
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

        [JsonProperty("Z-End")]
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
        [JsonProperty("Z-step")]
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

        private bool tNumberEnable
        {

        }

        public bool TNumberEnable { get; set; } = false;

        private int tNumber = 15;

        [JsonProperty("T-Number")]
        public int TNumber
        {
            get { return tNumber ; }
            set { 
                tNumber = value;
                NotifyPropertyChanged();
            }
        }



        public bool TBooleanEnable { get; set; }    

        public bool TIntervalEnable { get; set; } = false;


        private int tInterval = 16;

        [JsonProperty("T-Interva")]
        public int TInterval
        {
            get { return tInterval; }
            set {
                tInterval = value;
                NotifyPropertyChanged();
            }
        }


        public bool FocusEnable { get; set; } = true;

        public int FocusMode { get; set; } = 0;

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
        [JsonProperty("X")]
        public int X { get; set; }
        [JsonProperty("Y")]
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
        [JsonProperty("X")]
        public int X { get; set; }
        [JsonProperty("Y")]
        public int Y { get; set; }
        [JsonProperty("Width")]
        public int Width { get; set; }
        [JsonProperty("Height")]
        public int Height { get; set; }
    }
}
