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

        public bool ZEnable { get; set; }

        public int ZStart { get; set; }

        public int ZEnd { get; set; }

        public int Zstep { get; set; }

        public bool ZAbsolute { get; set; }

        public bool TEnable { get; set; }

        public bool TNumberEnable { get; set; }
        public int TNumber { get; set; }
        public bool TIntervalEnable { get; set; }

        public int TInterval { get; set; }

        public bool FocusEnable { get; set; }

        public bool FocusMode { get; set; }

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
