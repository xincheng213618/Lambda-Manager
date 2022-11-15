using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;

namespace InkManager
{

    public class RatioClass
    {

        public double Ratio = 1;
        public double actualwidth = 1;

    }


    public  class CustomStroke: Stroke
    {
        public CustomStroke(StylusPointCollection points) : base(points)
        {
            StylusPoints = points.Clone();

        }
        public int Dash { get; set; }
        public int LineWidth { get; set; }
        public int Index { get; set; }
        public string Type { get; set; }
        public Color ColorBru { get; set; }
        public Point CenterPoint { get; set; }
        public Point SizePoint { get; set; }
        public FormattedText customTextInput { get; set; }

        public int Fontsize { get; set; }
        public FontFamily FontFamily { get; set; }
        public bool Bold { get; set; }
        public bool Italic { get; set; }
        public bool UnderLine { get; set; }
        public bool showLabel { get; set; }
        public RatioClass ratio { get; set; }

        public Color textColor { get; set; }
        public string LabPos { get; set; }

        public double length { get; set; }
        public double angle { get; set; }
        public int dimSelectIndex { get; set; }


    }
}
