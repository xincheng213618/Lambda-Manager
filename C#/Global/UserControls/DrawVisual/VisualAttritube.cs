using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Global.UserControls.DrawVisual
{
    public class VisualAttritube
    {
        public string Type { get; set; }
        public int LineWidth { get; set; }
        public int LineType { get; set; }
        public Color Color { get; set; }

        //public Point Point2 { get; set; }
        //public Point Point3 { get; set; }
        //public Point Point4 { get; set; }

        public WinProperty winProperty { get; set; } = new WinProperty();
        public List<Point> PointList { get; set; }= new List<Point>(){new Point(0,0) };

        public Text TexT { get; set; } = new Text();
    }
    public class WinProperty
    {
        public int ActiveWin { get; set; }

        public double ratio { get; set; }
        public double acWidth { get; set; }
        public double acHeight { get; set; }
    

    }

    public class Text
    {

        public Color TextColor { get; set; }
        public int Fontsize { get; set; }
        public string FontFamily { get; set; }
        public bool Bold { get; set; }
        public bool Italic { get; set; }
        public bool UnderLine { get; set; }
        public Point Point1 { get; set; } = new Point(0,0);



    }





}
