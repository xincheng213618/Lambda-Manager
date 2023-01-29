using Global.UserControls.DrawVisual;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;

namespace Global
{
    public class CustomStroke : Stroke
    {
        public CustomStroke(StylusPointCollection points) : base(points)
        {
            StylusPoints = points.Clone();
        }
        public int Dash { get; set; }
        public int LineWidth { get; set; }
        public int Index { get; set; }
        public string Type { get; set; }
        public string Type1 { get; set; }
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
        public List<Point> PointList { get; set; } = new List<Point>();
        public Point Point1 { get; set; } = new Point(0, 0);
        public string Content { get; set; } = "null";


    }
}

