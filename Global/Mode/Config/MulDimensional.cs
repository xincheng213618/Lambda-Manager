
using Global.Common;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Global.Mode.Config
{
    [Serializable]
    public class MulDimensional: ViewModeBase
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

        public bool TIntervalEnable { get; set; } = false;


        private int tInterval = 16;

        [JsonPropertyName("T-Interva")]
        public int TInterval
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
