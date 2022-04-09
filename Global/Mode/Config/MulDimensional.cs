
using Newtonsoft.Json;

namespace Global.Mode.Config
{
    public class MulDimensional: ModeBaseObject
    {
        public List<MulDimensionalArea> mulDimensionalAreas { get; set; } = new List<MulDimensionalArea> { };
        public List<MulDimensionalPoint> mulDimensionalPoints { get; set; } = new List<MulDimensionalPoint> { };
        [JsonProperty("Z-Enable")]
        public bool ZEnable { get; set; } = false;

        public int ZStart { get; set; } = 16;

        [JsonProperty("Z-End")]
        public int ZEnd { get; set; } = 32;
        [JsonProperty("Z-step")]
        public int Zstep { get; set; } = 200;

        public bool ZAbsolute { get; set; } = false;

        public bool TEnable { get; set; } = false;

        public bool TNumberEnable { get; set; } = false;
        [JsonProperty("T-Number")]
        public int TNumber { get; set; } = 15;
        public bool TIntervalEnable { get; set; } = false;
        [JsonProperty("T-Interva")]
        public int TInterval { get; set; } = 16;

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
