using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace ExportProcessing
{

    public class WindowVisual
    {
        public int Window { get; set; } = 0;
        public double Ratio { get; set; }
        public double AcWidth { get; set; }
        public double AcHeight { get; set; }

        public ObservableCollection<VisualAttritube> VisualsList { get; set; } = new ObservableCollection<VisualAttritube>();
        public DefaultDim DefaultDim { get; set; } = new DefaultDim();
    }

    public class VisualAttritube
    {
        public string Type { get; set; } = "null";
        public int LineWidth { get; set; }
        public int LineType { get; set; }
        public Color Color { get; set; }
        // public WinProperty winProperty { get; set; } = new WinProperty();
        public List<Point> PointList { get; set; } = new List<Point>() { new Point(0, 0) };
        public Text TexT { get; set; } = new Text();

    }
    public class DefaultDim
    {
        public List<Point> PointList { get; set; } = new List<Point>() { new Point(0, 0) };
        public Color Color { get; set; }
        public Text TexT { get; set; } = new Text();

    }

    public class Text
    {
        public string Content { get; set; } = "null";
        public Color TextColor { get; set; }
        public int Fontsize { get; set; }
        public string FontFamily { get; set; } = "null";
        public bool Bold { get; set; }
        public bool Italic { get; set; }
        public bool UnderLine { get; set; }
        public Point Point1 { get; set; } = new Point(0, 0);
        public bool ShowText { get; set; }
        public string TextPos { get; set; } = "null";

    }
}


   
