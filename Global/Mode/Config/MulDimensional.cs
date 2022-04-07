using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLobal.Mode.Config
{
    public class MulDimensional
    {
        public MulDimensionalArea[] mulDimensionalAreas { get; set; }

        public bool ZEnable { get; set; } = false;

        public int ZStart { get; set; } = 16;

        public int ZEnd { get; set; } = 32;

        public int Zstep { get; set; } = 200;

        public bool ZAbsolute { get; set; } = false;

        public bool TEnable { get; set; } = false;

        public bool TNumberEnable { get; set; } = false;
        public int TNumber { get; set; } = 15;
        public bool TIntervalEnable { get; set; } = false;

        public int TInterval { get; set; } = 16;

        public bool FocusEnable { get; set; } = true;

        public int FocusMode { get; set; } = 0;

    }
    public class MulDimensionalPoint
    {
        public MulDimensionalPoint(Point point)
        {
            X = point.X;
            Y = point.Y;

        }
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class MulDimensionalArea
    {
        public MulDimensionalArea(Rectangle rectangle)
        {
            X = rectangle.Top;
            Y = rectangle.Left;
            Width = rectangle.Width;
            Height = rectangle.Height;
        }
        public MulDimensionalArea()
        {

        }
        public int X { get; set; }
        public int Y { get; set; }

        public int Width { get; set; }
        public int Height { get; set; }
    }
}
