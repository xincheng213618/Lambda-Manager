using Global.Mode;
using Global.UserControls.DrawVisual;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

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


    public class ActiveView : ViewModelBase1
    {
        private int activeWin = 0;
        public int ActiveWin
        {
            get
            {
                return activeWin;
            }
            set
            {
                if (activeWin != value)
                {
                    activeWin = value;
                    RaisePropertyChanged(nameof(ActiveWin));
                }

            }

        }


    }



    public class DrawInkMethod: ViewModelBase1
    {

        public DrawInkMethod()
        {
            defdimenViewModel.LineProEnable = false;
            defdimenViewModel.LabelPosShow = false;
            ActiveViewChanged();
        }

        public DrawingAttributes drawingAttributes = new DrawingAttributes()
        { //Color = Colors.Red,
            Color = dimenViewModel.SelectedAccentColor,
            Width = 2,
            Height = 2,
            StylusTip = StylusTip.Ellipse,
            FitToCurve = false,
            IsHighlighter = false,
            IgnorePressure = false,
        };
        public DrawingAttributes drawingAttribute1 = new DrawingAttributes()
        { //Color = Colors.Red,
            Color = dimenViewModel.SelectedAccentColor,
            Width = 4,
            Height = 4,
            StylusTip = StylusTip.Ellipse,
            FitToCurve = false,
            IsHighlighter = false,
            IgnorePressure = false,
        };
        public static event EventHandler<PropertyChangedEventArgs> StaticPropertyChanged;//静态事件处理属性更改
        public static DimenViewModel defdimenViewModel = new DimenViewModel();
        
        public static DimenViewModel dimenViewModel = new DimenViewModel();
        public static StrokeCollection DrawStrokes = new StrokeCollection();
        public static ObservableCollection<Stroke> StrokesCollection = new ObservableCollection<Stroke>();
        public static bool IsZoom = true;
       
        public Stroke Dimstroke;
        public Stroke Textstroke;
        public double distance;
        public static bool rulerOver = false;
        public static bool ZoomWard = false;
        //public static int activeWindow = 0;
        public static InkCanvas ActiveInk = new InkCanvas();
        public static InkVisual[]  InkAll = new InkVisual[6];
        public static ActiveView ActiveViews = new ActiveView();
        private int viewCount = 0;
        //public static event EventHandler propertyChanged;
        //public static int ActiveWindow
        //{
        //    get { return activeWindow; }
        //    set
        //    {
               
        //            if (activeWindow != value)
        //            {
        //            activeWindow = value;
        //            StaticPropertyChanged?.Invoke(null, new PropertyChangedEventArgs(nameof(ActiveWindow)));
        //        }

        //    }
        //}
        private  void ActiveViewChanged()
        {
           
            ActiveViews.PropertyChanged += (s, e) =>
            {
                viewCount = 0;
                Window mainwin = System.Windows.Application.Current.MainWindow;
                Grid grid = (Grid)mainwin.FindName("grid0");
                Grid grid1= grid.Parent as Grid;
                foreach(var item in grid1.Children)
                {
                    if (item is Grid)
                    {
                        Color color = (Color)ColorConverter.ConvertFromString("Transparent");
                        InkAll[viewCount].Border.BorderBrush = new SolidColorBrush(color);
                         viewCount++;

                    }
                }
                if (viewCount > 1)
                {
                    Color color = (Color)ColorConverter.ConvertFromString("#6EA646");
                    InkAll[ActiveViews.ActiveWin].Border.BorderBrush = new SolidColorBrush(color);

                }





            };



        }
       
    public List<System.Windows.Point> bezierPointList = new List<System.Windows.Point>();

        public Stroke GenerateLineStroke(System.Windows.Point st, System.Windows.Point ed)
        {
            List<System.Windows.Point> pointList = new List<System.Windows.Point>();
            StylusPointCollection point;
            Stroke stroke;
            pointList = new List<System.Windows.Point>{
                new System.Windows.Point(st.X, st.Y),
                new System.Windows.Point(ed.X, ed.Y)
            };
            point = new StylusPointCollection(pointList);
            stroke = new Stroke(point)
            {
                DrawingAttributes = drawingAttributes.Clone()
            };
            return stroke;
            
        }
        private StrokeCollection GenerateDashedLineStrokeCollection(System.Windows.Point st, System.Windows.Point ed)
        {
            double step = 5;
            List<System.Windows.Point> pointList = new List<System.Windows.Point>();
            StylusPointCollection point;
            Stroke stroke;
            StrokeCollection strokes = new StrokeCollection();
            double d = GetDistance(st, ed);
            double sinTheta = (ed.Y - st.Y) / d;
            double cosTheta = (ed.X - st.X) / d;
            for (double i = 0.0; i < d; i += step * 2.76)
            {
                pointList = new List<System.Windows.Point>{
                    new System.Windows.Point(st.X + i * cosTheta, st.Y + i * sinTheta),
                    new System.Windows.Point(st.X + Math.Min(i + step, d) * cosTheta, st.Y + Math.Min(i + step, d) * sinTheta)
                };
                point = new StylusPointCollection(pointList);
                stroke = new Stroke(point)
                {
                    DrawingAttributes = drawingAttributes.Clone()
                };
                strokes.Add(stroke.Clone());
            }
            return strokes;
        }





        public Stroke GenerateDimensionStroke0(System.Windows.Point st, System.Windows.Point ed)
        {
            List<System.Windows.Point> pointList = new List<System.Windows.Point>();
            StylusPointCollection point;
            Stroke stroke;


           // double w = 20, h = 7;
            double theta = Math.Atan2(st.Y - ed.Y, st.X - ed.X);
            double theta1 = Math.Atan2(ed.Y - st.Y, ed.X - st.X);
            pointList = new List<System.Windows.Point>
            {
                new System.Windows.Point(st.X, st.Y),
                //new Point (st.X-10*Math.Cos(theta1+Math.PI / 2),st.Y-10*Math.Sin(theta1+Math.PI / 2)),
                new System.Windows.Point (st.X-10*Math.Cos(theta1-Math.PI / 2),st.Y-10*Math.Sin(theta1-Math.PI / 2)),
                new System.Windows.Point(st.X, st.Y),
                new System.Windows.Point(ed.X , ed.Y),
                new System.Windows.Point (ed.X-10*Math.Cos(theta+Math.PI / 2),ed.Y-10*Math.Sin(theta+Math.PI / 2)),
                //new Point (ed.X-10*Math.Cos(theta-Math.PI / 2),ed.Y-10*Math.Sin(theta-Math.PI / 2)),

            };
            point = new StylusPointCollection(pointList);
            stroke = new Stroke(point)
            {
                DrawingAttributes = drawingAttributes.Clone()
            };
            return stroke;
        }




        public Stroke GenerateDimensionStroke1(System.Windows.Point st, System.Windows.Point ed)
        {
            List<System.Windows.Point> pointList = new List<System.Windows.Point>();
            StylusPointCollection point;
            Stroke stroke;

           // double w = 20, h = 7;
            double theta = Math.Atan2(st.Y - ed.Y, st.X - ed.X);
            //double sint = Math.Sin(theta);
            //double cost = Math.Cos(theta);

            double theta1 = Math.Atan2(ed.Y - st.Y, ed.X - st.X);
            //double sint1 = Math.Sin(theta1);
            //double cost1 = Math.Cos(theta1);

            pointList = new List<System.Windows.Point>
            {
                new System.Windows.Point(st.X, st.Y),
                new System.Windows.Point (st.X-10*Math.Cos(theta1+Math.PI / 2),st.Y-10*Math.Sin(theta1+Math.PI / 2)),
                //new Point (st.X-10*Math.Cos(theta1-Math.PI / 2),st.Y-10*Math.Sin(theta1-Math.PI / 2)),
                new System.Windows.Point(st.X, st.Y),
                new System.Windows.Point(ed.X , ed.Y),
                //new Point (ed.X-10*Math.Cos(theta+Math.PI / 2),ed.Y-10*Math.Sin(theta+Math.PI / 2)),
                new System.Windows.Point (ed.X-10*Math.Cos(theta-Math.PI / 2),ed.Y-10*Math.Sin(theta-Math.PI / 2)),

            };
            point = new StylusPointCollection(pointList);
            stroke = new Stroke(point)
            {
                DrawingAttributes = drawingAttributes.Clone()
            };
            return stroke;
        }







        public Stroke GenerateDimensionStroke2(System.Windows.Point st, System.Windows.Point ed)
        {
            List<System.Windows.Point> pointList = new List<System.Windows.Point>();
            StylusPointCollection point;
            Stroke stroke;

            //double w = 20, h = 7;
            double theta = Math.Atan2(st.Y - ed.Y, st.X - ed.X);
            //double sint = Math.Sin(theta);
            //double cost = Math.Cos(theta);

            double theta1 = Math.Atan2(ed.Y - st.Y, ed.X - st.X);
            //double sint1 = Math.Sin(theta1);
            //double cost1 = Math.Cos(theta1);

            pointList = new List<System.Windows.Point>
            {
                new System.Windows.Point(st.X, st.Y),
                new System.Windows.Point (st.X-10*Math.Cos(theta1+Math.PI / 2),st.Y-10*Math.Sin(theta1+Math.PI / 2)),
                new System.Windows.Point (st.X-10*Math.Cos(theta1-Math.PI / 2),st.Y-10*Math.Sin(theta1-Math.PI / 2)),
                new System.Windows.Point(st.X, st.Y),
                new System.Windows.Point(ed.X , ed.Y),
                new System.Windows.Point (ed.X-10*Math.Cos(theta+Math.PI / 2),ed.Y-10*Math.Sin(theta+Math.PI / 2)),
                new System.Windows.Point (ed.X-10*Math.Cos(theta-Math.PI / 2),ed.Y-10*Math.Sin(theta-Math.PI / 2)),

            };
            point = new StylusPointCollection(pointList);
            stroke = new Stroke(point)
            {
                DrawingAttributes = drawingAttributes.Clone()
            };
            return stroke;
        }





        public Stroke GenerateDimensionStroke4(System.Windows.Point st, System.Windows.Point ed)
        {
            List<System.Windows.Point> pointList = new List<System.Windows.Point>();
            StylusPointCollection point;
            Stroke stroke;

            double w = 20, h = 7;
           // double theta = Math.Atan2(st.Y - ed.Y, st.X - ed.X);
            //double sint = Math.Sin(theta);
            //double cost = Math.Cos(theta);

            double theta1 = Math.Atan2(ed.Y - st.Y, ed.X - st.X);
            double sint1 = Math.Sin(theta1);
            double cost1 = Math.Cos(theta1);

            pointList = new List<System.Windows.Point>
            {
               new System.Windows.Point(st.X, st.Y),
                new System.Windows.Point(st.X + (w * cost1 - h * sint1), st.Y + (w * sint1 + h * cost1)),
                new System.Windows.Point(st.X, st.Y),
                new System.Windows.Point(st.X + (w * cost1 + h * sint1), st.Y - (h * cost1 - w * sint1)),
                new System.Windows.Point(st.X, st.Y),
                new System.Windows.Point (st.X-10*Math.Cos(theta1+Math.PI / 2),st.Y-10*Math.Sin(theta1+Math.PI / 2)),
                new System.Windows.Point (st.X-10*Math.Cos(theta1-Math.PI / 2),st.Y-10*Math.Sin(theta1-Math.PI / 2)),
                new System.Windows.Point(st.X, st.Y),
                new System.Windows.Point(ed.X , ed.Y),



            };
            point = new StylusPointCollection(pointList);
            stroke = new Stroke(point)
            {
                DrawingAttributes = drawingAttributes.Clone()
            };
            return stroke;
        }

        public Stroke GenerateDimensionStroke3(System.Windows.Point st, System.Windows.Point ed)
        {
            List<System.Windows.Point> pointList = new List<System.Windows.Point>();
            StylusPointCollection point;
            Stroke stroke;

            double w = 20, h = 7;
            double theta = Math.Atan2(st.Y - ed.Y, st.X - ed.X);
            double sint = Math.Sin(theta);
            double cost = Math.Cos(theta);

            double theta1 = Math.Atan2(ed.Y - st.Y, ed.X - st.X);
            double sint1 = Math.Sin(theta1);
            double cost1 = Math.Cos(theta1);

            pointList = new List<System.Windows.Point>
            {
                new System.Windows.Point(st.X, st.Y),
                new System.Windows.Point(st.X + (w * cost1 - h * sint1), st.Y + (w * sint1 + h * cost1)),
                new System.Windows.Point(st.X, st.Y),
                new System.Windows.Point(st.X + (w * cost1 + h * sint1), st.Y - (h * cost1 - w * sint1)),
                new System.Windows.Point(st.X, st.Y),
                new System.Windows.Point (st.X-10*Math.Cos(theta1+Math.PI / 2),st.Y-10*Math.Sin(theta1+Math.PI / 2)),
                new System.Windows.Point (st.X-10*Math.Cos(theta1-Math.PI / 2),st.Y-10*Math.Sin(theta1-Math.PI / 2)),
                new System.Windows.Point(st.X, st.Y),

                new System.Windows.Point(ed.X , ed.Y),
                new System.Windows.Point(ed.X + (w * cost - h * sint), ed.Y + (w * sint + h * cost)),
                new System.Windows.Point(ed.X,ed.Y),
                new System.Windows.Point(ed.X + (w * cost + h * sint), ed.Y - (h * cost - w * sint)),
                new System.Windows.Point(ed.X,ed.Y),
                new System.Windows.Point (ed.X-10*Math.Cos(theta+Math.PI / 2),ed.Y-10*Math.Sin(theta+Math.PI / 2)),
                new System.Windows.Point (ed.X-10*Math.Cos(theta-Math.PI / 2),ed.Y-10*Math.Sin(theta-Math.PI / 2)),

            };
            point = new StylusPointCollection(pointList);
            stroke = new Stroke(point)
            {
                DrawingAttributes = drawingAttributes.Clone()
            };
            return stroke;


        }

        public Stroke GenerateDimensionStroke5(System.Windows.Point st, System.Windows.Point ed)
        {
            List<System.Windows.Point> pointList = new List<System.Windows.Point>();
            StylusPointCollection point;
            Stroke stroke;

            double w = 20, h = 7;
            double theta = Math.Atan2(st.Y - ed.Y, st.X - ed.X);
            double sint = Math.Sin(theta);
            double cost = Math.Cos(theta);

            double theta1 = Math.Atan2(ed.Y - st.Y, ed.X - st.X);
            //double sint1 = Math.Sin(theta1);
            //double cost1 = Math.Cos(theta1);

            pointList = new List<System.Windows.Point>
            {
                new System.Windows.Point(st.X, st.Y),
                new System.Windows.Point(ed.X , ed.Y),
                new System.Windows.Point(ed.X + (w * cost - h * sint), ed.Y + (w * sint + h * cost)),
                new System.Windows.Point(ed.X,ed.Y),
                new System.Windows.Point(ed.X + (w * cost + h * sint), ed.Y - (h * cost - w * sint)),
                new System.Windows.Point(ed.X,ed.Y),
                new System.Windows.Point (ed.X-10*Math.Cos(theta+Math.PI / 2),ed.Y-10*Math.Sin(theta+Math.PI / 2)),
                new System.Windows.Point (ed.X-10*Math.Cos(theta-Math.PI / 2),ed.Y-10*Math.Sin(theta-Math.PI / 2)),

            };
            point = new StylusPointCollection(pointList);
            drawingAttributes.Color = dimenViewModel.SelectedAccentColor;
            stroke = new Stroke(point)
            {
                DrawingAttributes = drawingAttributes.Clone()
            };
            return stroke;
        }


        public Stroke GenerateEllipseStroke(System.Windows.Point st, System.Windows.Point ed)
        {
            List<System.Windows.Point> pointList = GenerateEllipseGeometry(st, ed);
            StylusPointCollection point = new StylusPointCollection(pointList);
            Stroke stroke;

            point = new StylusPointCollection(pointList);
            drawingAttributes.Color = dimenViewModel.SelectedAccentColor;
            stroke = new Stroke(point)
            {
                DrawingAttributes = drawingAttributes.Clone()
            };
            return stroke;
        }


        public Stroke GenerateCircleStroke(System.Windows.Point st, System.Windows.Point ed)
        {

            double dist = Math.Sqrt(Math.Pow(ed.X - st.X, 2) + Math.Pow(ed.Y - st.Y, 2));
            double deltaX = ed.X - st.X;
            double deltaY = ed.Y - st.Y;

            double x = deltaX / Math.Abs(deltaX) * dist / 1.4;
            double y = deltaY / Math.Abs(deltaY) * dist / 1.4;
            ed = new System.Windows.Point(st.X + x, st.Y + y);
            List<System.Windows.Point> pointList = GenerateEllipseGeometry(st, ed);
            StylusPointCollection point = new StylusPointCollection(pointList);
            Stroke stroke;

            point = new StylusPointCollection(pointList);
            stroke = new Stroke(point)
            {
                DrawingAttributes = drawingAttributes.Clone()
            };
            return stroke;
        }


        public Stroke GenerateArrowLineStroke(System.Windows.Point st, System.Windows.Point ed)
        {
            List<System.Windows.Point> pointList = new List<System.Windows.Point>();
            StylusPointCollection point;
            Stroke stroke;

            double w = 20, h = 7;
            double theta = Math.Atan2(st.Y - ed.Y, st.X - ed.X);
            double sint = Math.Sin(theta);
            double cost = Math.Cos(theta);

            pointList = new List<System.Windows.Point>
            {
                new System.Windows.Point(st.X, st.Y),
                new System.Windows.Point(ed.X , ed.Y),
                new System.Windows.Point(ed.X + (w * cost - h * sint), ed.Y + (w * sint + h * cost)),
                new System.Windows.Point(ed.X,ed.Y),
                new System.Windows.Point(ed.X + (w * cost + h * sint), ed.Y - (h * cost - w * sint))
            };
            point = new StylusPointCollection(pointList);
            drawingAttributes.Color = dimenViewModel.SelectedAccentColor;
            stroke = new Stroke(point)
            {

                DrawingAttributes = drawingAttributes.Clone()

            };
            return stroke;
        }

        public Stroke GenerateRectangleStroke(System.Windows.Point st, System.Windows.Point ed)
        {

            List<System.Windows.Point> pointList = new List<System.Windows.Point>();
            StylusPointCollection point;
            Stroke stroke;
            pointList = new List<System.Windows.Point>{
                        new System.Windows.Point(st.X, st.Y),
                        new System.Windows.Point(st.X, ed.Y),
                        new System.Windows.Point(ed.X, ed.Y),
                        new System.Windows.Point(ed.X, st.Y),
                        new System.Windows.Point(st.X, st.Y)
                    };
            point = new StylusPointCollection(pointList);
            drawingAttributes.Color = dimenViewModel.SelectedAccentColor;
            stroke = new Stroke(point)
            {
                DrawingAttributes = drawingAttributes.Clone()
            };

            return stroke;
        }

        public Stroke GenerateRulerStroke(System.Windows.Point st, System.Windows.Point ed)
        {
            List<System.Windows.Point> pointList = new List<System.Windows.Point>();
            StylusPointCollection point;
            Stroke stroke;

           // double w = 20, h = 7;
            double theta = Math.Atan2(st.Y - ed.Y, st.X - ed.X);
            //double sint = Math.Sin(theta);
            //double cost = Math.Cos(theta);

            double theta1 = Math.Atan2(ed.Y - st.Y, ed.X - st.X);
            double sint1 = Math.Sin(theta1);
            double cost1 = Math.Cos(theta1);

            pointList = new List<System.Windows.Point>
            {
                new System.Windows.Point(st.X, st.Y),
                new System.Windows.Point (st.X-10*Math.Cos(theta1+Math.PI / 2),st.Y-10*Math.Sin(theta1+Math.PI / 2)),
                new System.Windows.Point (st.X-10*Math.Cos(theta1-Math.PI / 2),st.Y-10*Math.Sin(theta1-Math.PI / 2)),
                new System.Windows.Point(st.X, st.Y),
                new System.Windows.Point(ed.X , ed.Y),
                new System.Windows.Point (ed.X-10*Math.Cos(theta+Math.PI / 2),ed.Y-10*Math.Sin(theta+Math.PI / 2)),
                new System.Windows.Point (ed.X-10*Math.Cos(theta-Math.PI / 2),ed.Y-10*Math.Sin(theta-Math.PI / 2)),

            };
            point = new StylusPointCollection(pointList);
            stroke = new Stroke(point)
            {
                DrawingAttributes = drawingAttributes.Clone()
            };
            return stroke;
        }

        public Stroke GenerateProfileStroke(System.Windows.Point st, System.Windows.Point ed)
        {
            List<System.Windows.Point> pointList = new List<System.Windows.Point>();
            StylusPointCollection point;
            Stroke stroke;


            double theta = Math.Atan2(st.Y - ed.Y, st.X - ed.X);

            double theta1 = Math.Atan2(ed.Y - st.Y, ed.X - st.X);


            pointList = new List<System.Windows.Point>
            {
                new System.Windows.Point(st.X, st.Y),
                //new System.Windows.Point (st.X-5*Math.Cos(theta1+Math.PI / 2),st.Y-5*Math.Sin(theta1+Math.PI / 2)),
                //new System.Windows.Point (st.X-5*Math.Cos(theta1-Math.PI / 2),st.Y-5*Math.Sin(theta1-Math.PI / 2)),
                //new System.Windows.Point(st.X, st.Y),
                new System.Windows.Point(ed.X , ed.Y),
                //new System.Windows.Point (ed.X-5*Math.Cos(theta+Math.PI / 2),ed.Y-5*Math.Sin(theta+Math.PI / 2)),
                //new System.Windows.Point (ed.X-5*Math.Cos(theta-Math.PI / 2),ed.Y-5*Math.Sin(theta-Math.PI / 2)),

            };

            //List<System.Windows.Point> pointList1 = GenerateEllipseGeometry(new Point(st.X-5, st.Y - 5) ,new Point(st.X + 5, st.Y + 5));
            //List<System.Windows.Point> pointList2 = GenerateEllipseGeometry(new Point(ed.X - 5, ed.Y - 5), new Point(ed.X + 5, ed.Y + 5));
            //pointList.AddRange(pointList1);
            //pointList.AddRange(pointList2);
            point = new StylusPointCollection(pointList);
            stroke = new Stroke(point)
            {
                DrawingAttributes = drawingAttributes.Clone()
            };
            return stroke;
        }
        public Stroke GenerateMarker1Stroke(System.Windows.Point st)
        {
            List<System.Windows.Point> pointList = new List<System.Windows.Point>();
            StylusPointCollection point;
            Stroke stroke;


            pointList = new List<System.Windows.Point>
            {
                new System.Windows.Point(st.X, st.Y),

            };

            point = new StylusPointCollection(pointList);
            stroke = new Stroke(point)
            {
                DrawingAttributes = drawingAttribute1.Clone()
            };
            return stroke;
        }


        public Stroke GenerateSquareStroke(System.Windows.Point st, System.Windows.Point ed)
        {

            double dist = Math.Sqrt(Math.Pow(ed.X - st.X, 2) + Math.Pow(ed.Y - st.Y, 2));
            double deltaX = ed.X - st.X;
            double deltaY = ed.Y - st.Y;

            double x = deltaX / Math.Abs(deltaX) * dist / 1.4;
            double y = deltaY / Math.Abs(deltaY) * dist / 1.4;
            ed = new System.Windows.Point(st.X + x, st.Y + y);

            List<System.Windows.Point> pointList = new List<System.Windows.Point>();
            StylusPointCollection point;
            Stroke stroke;
            pointList = new List<System.Windows.Point>{
                        new System.Windows.Point(st.X, st.Y),
                        new System.Windows.Point(st.X, ed.Y),
                        new System.Windows.Point(ed.X, ed.Y),
                        new System.Windows.Point(ed.X, st.Y),
                        new System.Windows.Point(st.X, st.Y)
                    };
            point = new StylusPointCollection(pointList);
            drawingAttributes.Color = dimenViewModel.SelectedAccentColor;
            stroke = new Stroke(point)
            {
                DrawingAttributes = drawingAttributes.Clone()
            };
            return stroke;
        }
        public static List<System.Windows.Point> GenerateEllipseGeometry(System.Windows.Point st, System.Windows.Point ed, bool isDrawTop = true, bool isDrawBottom = true)
        {
            double a = 0.5 * (ed.X - st.X);
            double b = 0.5 * (ed.Y - st.Y);
            List<System.Windows.Point> pointList = new List<System.Windows.Point>();
            if (isDrawTop && isDrawBottom)
            {
                for (double r = 0; r <= 2 * Math.PI; r = r + 0.01)
                {
                    pointList.Add(new System.Windows.Point(0.5 * (st.X + ed.X) + a * Math.Cos(r), 0.5 * (st.Y + ed.Y) + b * Math.Sin(r)));
                }
            }
            else
            {
                if (isDrawBottom)
                {
                    for (double r = 0; r <= Math.PI; r = r + 0.01)
                    {
                        pointList.Add(new System.Windows.Point(0.5 * (st.X + ed.X) + a * Math.Cos(r), 0.5 * (st.Y + ed.Y) + b * Math.Sin(r)));
                    }
                }
                if (isDrawTop)
                {
                    for (double r = Math.PI; r <= 2 * Math.PI; r = r + 0.01)
                    {
                        pointList.Add(new System.Windows.Point(0.5 * (st.X + ed.X) + a * Math.Cos(r), 0.5 * (st.Y + ed.Y) + b * Math.Sin(r)));
                    }
                }
            }
            return pointList;
        }

        public static class InkCanvasMethod
        {
            public static System.Windows.Media.Color ColorDefault = System.Windows.Media.Color.FromArgb(0xFF, 0xFF, 0x00, 0x00);
            public static System.Windows.Media.Color ColorEidting = System.Windows.Media.Color.FromArgb(0xFF, 0x07, 0xAA, 0xE5);
            public static System.Windows.Media.Brush StrokeBrushDefault = new SolidColorBrush(ColorDefault);
            public static System.Windows.Media.Brush StrokeBrushEdit = new SolidColorBrush(ColorEidting);
            // public static System.Windows.Media.Brush UndelLineBrush = new SolidColorBrush(dimenViewModel.SelectedAccentColor);

            /// <summary>
            /// 设置笔迹属性
            /// </summary>
            public static DrawingAttributes SetInkAttributes(double thickness = 2)
            {
                DrawingAttributes attributes = new DrawingAttributes
                {
                    FitToCurve = false,
                    Width = thickness,
                    Height = thickness,
                    Color = ColorDefault,
                    StylusTip = StylusTip.Ellipse,
                    IsHighlighter = false,
                    IgnorePressure = false,
                };
                return attributes;
            }
            public static DrawingAttributes drawingAttributes = new DrawingAttributes()
            { //Color = Colors.Red,
                Color = dimenViewModel.SelectedAccentColor,
                Width = 2,
                Height = 2,
                StylusTip = StylusTip.Ellipse,
                FitToCurve = false,
                IsHighlighter = false,
                IgnorePressure = false,
            };
            public static DrawingAttributes SetInkAttributes1(Color color, int lineWidth)
            {
                DrawingAttributes attributes = new DrawingAttributes
                {
                    FitToCurve = false,
                    Width = lineWidth,
                    Height = lineWidth,
                    Color = color,
                    StylusTip = StylusTip.Ellipse,
                    IsHighlighter = false,
                    IgnorePressure = false,
                };
                return attributes;
            }





            /// <summary>
            /// 实线 Pen
            /// </summary>
            /// <returns></returns>
            public static System.Windows.Media.Pen SetPenSolid(Color color, int lineWidth,int dash)
            {
                if (dash == 1)
                {
                    System.Windows.Media.Pen pen = new System.Windows.Media.Pen
                    {
                        Brush = new SolidColorBrush(color),
                        Thickness = lineWidth,
                        DashCap = PenLineCap.Round,
                        LineJoin = PenLineJoin.Round,
                        
                        DashStyle = new DashStyle()
                        {
                            Dashes = new DoubleCollection() { 3, 2 },
                        },

                        MiterLimit = 0.0
                    };
                    return pen;
                }
                else
                {
                    System.Windows.Media.Pen pen = new System.Windows.Media.Pen
                    {
                        Brush = new SolidColorBrush(color),
                        Thickness = lineWidth,
                        DashCap = PenLineCap.Round,
                        LineJoin = PenLineJoin.Round,
                        MiterLimit = 0.0
                    };
                    return pen;
                }
             
            }


            /// <summary>
            ///  Pen
            /// </summary>
            /// <returns></returns>
            public static System.Windows.Media.Pen SetPenSolid1(int thickness = 1)
            {
                System.Windows.Media.Pen pen = new System.Windows.Media.Pen
                {
                    Brush = Brushes.White,
                    Thickness = thickness,
                    DashCap = PenLineCap.Round,
                    DashStyle = DashStyles.DashDot,
                    LineJoin = PenLineJoin.Round,
                    MiterLimit = 0.0
                };
                return pen;
            }

            public static System.Windows.Media.Pen SetPenSolid2(int thickness = 4)
            {
                System.Windows.Media.Pen pen = new System.Windows.Media.Pen
                {
                    Brush = StrokeBrushDefault,
                    Thickness = thickness,
                    DashCap = PenLineCap.Round,

                    LineJoin = PenLineJoin.Round,
                    MiterLimit = 0.0
                };
                return pen;
            }
            public static System.Windows.Media.Pen SetPenSolid3(int thickness = 4)
            {
                System.Windows.Media.Pen pen = new System.Windows.Media.Pen
                {
                    Brush = Brushes.Blue,
                    Thickness = thickness,
                    DashCap = PenLineCap.Round,

                    LineJoin = PenLineJoin.Round,
                    MiterLimit = 0.0
                };
                return pen;
            }
            public static System.Windows.Media.Pen SetPenSolid4(int thickness = 4)
            {
                System.Windows.Media.Pen pen = new System.Windows.Media.Pen
                {
                    Brush = Brushes.Green,
                    Thickness = thickness,
                    DashCap = PenLineCap.Round,

                    LineJoin = PenLineJoin.Round,
                    MiterLimit = 0.0
                };
                return pen;
            }
            public static System.Windows.Media.Pen SetPenSolid5(Brush brush)
            {
                System.Windows.Media.Pen pen = new System.Windows.Media.Pen
                {
                    Brush = brush,
                    Thickness = 1.5,
                    DashCap = PenLineCap.Round,

                    LineJoin = PenLineJoin.Round,
                    MiterLimit = 0.0
                };
                return pen;
            }



            public static CustomText CreateText(System.Windows.Point point1, System.Windows.Point point2, RatioClass ratio, Color color)
            {
                StylusPointCollection points = new StylusPointCollection()
                  {
                new StylusPoint(point1.X, point1.Y),
                new StylusPoint(point2.X, point2.Y),

                    };
                CustomText stroke = new CustomText(new StylusPointCollection(points), ratio, color)
                {
                    DrawingAttributes = SetInkAttributes(),
                };
                return stroke;
            }
            public static CustomRulerText CreateRulerText(System.Windows.Point point1, System.Windows.Point point2, RatioClass ratio)
            {
                StylusPointCollection points = new StylusPointCollection()
                  {
                new StylusPoint(point1.X, point1.Y),
                new StylusPoint(point2.X, point2.Y),
                new StylusPoint((point1.X+point2.X)/2-30, (point1.Y+point2.Y)/2-10),
                new StylusPoint((point1.X+point2.X)/2, (point1.Y+point2.Y)/2-12),
                new StylusPoint((point1.X+point2.X)/2-20, (point1.Y+point2.Y)/2-5),
                new StylusPoint((point1.X+point2.X)/2+5, (point1.Y+point2.Y)/2-5),
                    };
                CustomRulerText stroke = new CustomRulerText(new StylusPointCollection(points), ratio)
                {
                    DrawingAttributes = SetInkAttributes(),
                };
                return stroke;
            }

            public static CustomText1 CreateText1(System.Windows.Point point1, System.Windows.Point point2)
            {
                StylusPointCollection points = new StylusPointCollection()
                  {
                new StylusPoint(point1.X, point1.Y),
                new StylusPoint(point2.X, point2.Y),


                    };
                CustomText1 stroke = new CustomText1(new StylusPointCollection(points))
                {
                    DrawingAttributes = SetInkAttributes(),
                };
                return stroke;
            }
            public static CustomMarkerText CreateMarkerText(System.Windows.Point point1, System.Windows.Point point2)
            {
                StylusPointCollection points = new StylusPointCollection()
                  {
                new StylusPoint(point1.X, point1.Y),
                new StylusPoint(point2.X, point2.Y),

                    };
                CustomMarkerText stroke = new CustomMarkerText(new StylusPointCollection(points))
                {
                    DrawingAttributes = SetInkAttributes(),
                };
                return stroke;
            }

            public static CustomProfile CreateProfile(System.Windows.Point point1, System.Windows.Point point2, ProfileModel ratio, Color color)
            {
                StylusPointCollection points = new StylusPointCollection()
                  {
                new StylusPoint(point1.X, point1.Y),
                new StylusPoint(point2.X, point2.Y),

                    };
                CustomProfile stroke = new CustomProfile(new StylusPointCollection(points), ratio, color)
                {
                    DrawingAttributes = SetInkAttributes(),
                };
                return stroke;
            }


            public static CustomTextInput CreateTextInput(System.Windows.Point point1, double height, double width, FormattedText text, Color brush,bool italic,bool bold,bool underLine,int fonSize,FontFamily fontFamily)
            {
                StylusPointCollection points = new StylusPointCollection()
                  {
                   new StylusPoint(point1.X, point1.Y),
                   new StylusPoint(point1.X+width, point1.Y),
                   new StylusPoint(point1.X, point1.Y+height),
                   new StylusPoint(point1.X+width, point1.Y+height),

                    };
                CustomTextInput stroke = new CustomTextInput(new StylusPointCollection(points), text, brush, italic, bold, underLine, fonSize, fontFamily)
                {
                    DrawingAttributes = SetInkAttributes(),
                };
                return stroke;
            }

            public static CustomTextInput ReCustomTextInput(System.Windows.Point point1, double height, double width ,FormattedText text, Color brush, bool italic, bool bold, bool underLine, int fonSize, FontFamily fontFamily)
            {
                StylusPointCollection points = new StylusPointCollection()
                  {
                   new StylusPoint(point1.X, point1.Y),
                   new StylusPoint(point1.X+width, point1.Y),
                   new StylusPoint(point1.X, point1.Y+height),
                   new StylusPoint(point1.X+width, point1.Y+height),

                    };

                CustomTextInput stroke = new CustomTextInput(new StylusPointCollection(points), text, brush, italic, bold, underLine, fonSize, fontFamily)
                {
                    DrawingAttributes = SetInkAttributes(),
                };
                return stroke;
            }

           //pixel information
            public static CustomPixel CreatePixel(System.Windows.Point point1, Image image)
            {
                StylusPointCollection points = new StylusPointCollection()
                {
                  new StylusPoint(point1.X, point1.Y),

                 };
                CustomPixel stroke = new CustomPixel(new StylusPointCollection(points), image)
                {
                    DrawingAttributes = SetInkAttributes(),
                };
                return stroke;
            }

            public static Bezierpath CreateBesizer(List<Point> bezierList, Color color, int lineWidth,int dash)
            {
                StylusPointCollection points = new StylusPointCollection()
                {

                    new StylusPoint(bezierList[0].X, bezierList[0].Y), new StylusPoint(bezierList[1].X, bezierList[1].Y), new StylusPoint(bezierList[2].X, bezierList[2].Y), new StylusPoint(bezierList[3].X, bezierList[3].Y)

                };

                Bezierpath stroke = new Bezierpath(new StylusPointCollection(points), color, lineWidth,dash)
                {
                    DrawingAttributes = SetInkAttributes1(color, lineWidth),
                };
                return stroke;

            }

            public static Bezierpath ReCreateBesizer(StylusPointCollection point, Color color, int lineWidth, int dash)
            {

                Bezierpath stroke = new Bezierpath(point, color, lineWidth, dash)
                {
                    DrawingAttributes = SetInkAttributes1(color, lineWidth),
                };
                return stroke;
            }





            public static QuadraticBezierpath CreateQuadraticBesizer(List<Point> bezierList, Color color, int lineWidth,int dash)
            {
                StylusPointCollection points = new StylusPointCollection()
                {

                    new StylusPoint(bezierList[0].X, bezierList[0].Y), new StylusPoint(bezierList[1].X, bezierList[1].Y), new StylusPoint(bezierList[2].X, bezierList[2].Y),

                };

                QuadraticBezierpath stroke = new QuadraticBezierpath(new StylusPointCollection(points), color, lineWidth,dash)
                {
                    DrawingAttributes = SetInkAttributes1(color, lineWidth),

                };
                return stroke;

            }

            public static QuadraticBezierpath ReCreateQuadraticBesizer(StylusPointCollection point, Color color, int lineWidth, int dash)
            {

                QuadraticBezierpath stroke = new QuadraticBezierpath(point, color, lineWidth, dash)
                {
                    DrawingAttributes = SetInkAttributes1(color, lineWidth),

                };
                return stroke;
            }







            public static EllipseStroke CreateEllipse(Point st, Point ed, Color color, int LineWidth,int dash)
            {

                // List<System.Windows.Point> pointList = DrawInkMethod.GenerateEllipseGeometry(st, ed);
                // point = new StylusPointCollection(pointList);
                List<System.Windows.Point> pointList = new List<System.Windows.Point>{
                        new System.Windows.Point(st.X, st.Y),
                        new System.Windows.Point(st.X, ed.Y),
                        new System.Windows.Point(ed.X, ed.Y),
                        new System.Windows.Point(ed.X, st.Y),
                        new System.Windows.Point(st.X, st.Y)
                    };
              

                StylusPointCollection point = new StylusPointCollection(pointList);

                EllipseStroke stroke = new EllipseStroke(point, color, LineWidth,dash)
                {
                    DrawingAttributes = SetInkAttributes1(color, LineWidth),
                };
                return stroke;
            }

            public static EllipseStroke ReCreateEllipse(StylusPointCollection point, Color color, int LineWidth, int dash)
            {

                EllipseStroke stroke = new EllipseStroke(point, color, LineWidth, dash)
                {
                    DrawingAttributes = SetInkAttributes1(color, LineWidth),
                };
                return stroke;
            }




            public static PolygonStroke CreatePolygon(List<System.Windows.Point> pointList, Color color, int lineWidth,int dash)
            {


                StylusPointCollection point = new StylusPointCollection(pointList);

                PolygonStroke stroke = new PolygonStroke(point, color, lineWidth,dash)
                {
                    DrawingAttributes = SetInkAttributes1(color, lineWidth),
                };
                return stroke;
            }

            public static PolygonStroke ReCreatePolygon(StylusPointCollection point, Color color, int lineWidth, int dash)
            {

                PolygonStroke stroke = new PolygonStroke(point, color, lineWidth, dash)
                {
                    DrawingAttributes = SetInkAttributes1(color, lineWidth),
                };
                return stroke;
            }



            public static CircleStroke CreateCircle(Point st, Point ed, Color color, int lineWidth,int dash)
            {
                double dist = Math.Sqrt(Math.Pow(ed.X - st.X, 2) + Math.Pow(ed.Y - st.Y, 2));
                double deltaX = ed.X - st.X;
                double deltaY = ed.Y - st.Y;

                double x = deltaX / Math.Abs(deltaX) * dist / 1.4;
                double y = deltaY / Math.Abs(deltaY) * dist / 1.4;
                ed = new System.Windows.Point(st.X + x, st.Y + y);
                //List<System.Windows.Point> pointList = DrawInkMethod.GenerateEllipseGeometry(st, ed);

                List<System.Windows.Point> pointList = new List<System.Windows.Point>{
                        new System.Windows.Point(st.X, st.Y),
                        new System.Windows.Point(st.X, ed.Y),
                        new System.Windows.Point(ed.X, ed.Y),
                        new System.Windows.Point(ed.X, st.Y),
                        new System.Windows.Point(st.X, st.Y)
                    };
                StylusPointCollection point = new StylusPointCollection(pointList);

                CircleStroke stroke = new CircleStroke(point, color, lineWidth,dash)
                {
                    DrawingAttributes = SetInkAttributes1(color, lineWidth),
                };
                return stroke;
            }

            public static CircleStroke ReCreateCircle(StylusPointCollection point, Color color, int lineWidth, int dash)
            {
                CircleStroke stroke = new CircleStroke(point, color, lineWidth, dash)
                {
                    DrawingAttributes = SetInkAttributes1(color, lineWidth),
                };
                return stroke;
            }



            public static RectangleStroke CreateRectangleStroke(System.Windows.Point st, System.Windows.Point ed, Color color, int lineWidth,int dash)
            {

                List<System.Windows.Point> pointList = new List<System.Windows.Point>();
                StylusPointCollection point;
                pointList = new List<System.Windows.Point>{
                        new System.Windows.Point(st.X, st.Y),
                        new System.Windows.Point(st.X, ed.Y),
                        new System.Windows.Point(ed.X, ed.Y),
                        new System.Windows.Point(ed.X, st.Y),
                        new System.Windows.Point(st.X, st.Y)
                    };
                point = new StylusPointCollection(pointList);
                RectangleStroke stroke = new RectangleStroke(point, color, lineWidth, dash)
                {
                    DrawingAttributes = SetInkAttributes1(color, lineWidth)
                };

                return stroke;
            }

            public static RectangleStroke ReCreateRectangle(StylusPointCollection point, Color color, int lineWidth, int dash)
            {
                RectangleStroke stroke = new RectangleStroke(point, color, lineWidth, dash)
                {
                    DrawingAttributes = SetInkAttributes1(color, lineWidth),
                };
                return stroke;
            }






            public static SquareStroke CreateSquare(System.Windows.Point st, System.Windows.Point ed, Color color, int lineWidth,int dash)
            {

                double dist = Math.Sqrt(Math.Pow(ed.X - st.X, 2) + Math.Pow(ed.Y - st.Y, 2));
                double deltaX = ed.X - st.X;
                double deltaY = ed.Y - st.Y;

                double x = deltaX / Math.Abs(deltaX) * dist / 1.4;
                double y = deltaY / Math.Abs(deltaY) * dist / 1.4;
                ed = new System.Windows.Point(st.X + x, st.Y + y);

                List<System.Windows.Point> pointList = new List<System.Windows.Point>();
                StylusPointCollection point;

                pointList = new List<System.Windows.Point>{
                        new System.Windows.Point(st.X, st.Y),
                        new System.Windows.Point(st.X, ed.Y),
                        new System.Windows.Point(ed.X, ed.Y),
                        new System.Windows.Point(ed.X, st.Y),
                        new System.Windows.Point(st.X, st.Y)
                    };
                point = new StylusPointCollection(pointList);

                SquareStroke stroke = new SquareStroke(point, color, lineWidth,dash)
                {
                    DrawingAttributes = SetInkAttributes1(color, lineWidth)
                };
                return stroke;

            }
            public static SquareStroke ReCreateSquare(StylusPointCollection point, Color color, int lineWidth, int dash)
            {
                SquareStroke stroke = new SquareStroke(point, color, lineWidth, dash)
                {
                    DrawingAttributes = SetInkAttributes1(color, lineWidth),
                };
                return stroke;
            }
            public static Stroke GenerateRulerStroke(System.Windows.Point st, System.Windows.Point ed)
            {
                List<System.Windows.Point> pointList = new List<System.Windows.Point>();
                StylusPointCollection point;
                Stroke stroke;

                // double w = 20, h = 7;
                double theta = Math.Atan2(st.Y - ed.Y, st.X - ed.X);
                //double sint = Math.Sin(theta);
                //double cost = Math.Cos(theta);

                double theta1 = Math.Atan2(ed.Y - st.Y, ed.X - st.X);
                double sint1 = Math.Sin(theta1);
                double cost1 = Math.Cos(theta1);

                pointList = new List<System.Windows.Point>
            {
                new System.Windows.Point(st.X, st.Y),
                new System.Windows.Point (st.X-10*Math.Cos(theta1+Math.PI / 2),st.Y-10*Math.Sin(theta1+Math.PI / 2)),
                new System.Windows.Point (st.X-10*Math.Cos(theta1-Math.PI / 2),st.Y-10*Math.Sin(theta1-Math.PI / 2)),
                new System.Windows.Point(st.X, st.Y),
                new System.Windows.Point(ed.X , ed.Y),
                new System.Windows.Point (ed.X-10*Math.Cos(theta+Math.PI / 2),ed.Y-10*Math.Sin(theta+Math.PI / 2)),
                new System.Windows.Point (ed.X-10*Math.Cos(theta-Math.PI / 2),ed.Y-10*Math.Sin(theta-Math.PI / 2)),

            };
                point = new StylusPointCollection(pointList);
                stroke = new Stroke(point)
                {
                    DrawingAttributes = drawingAttributes.Clone()
                };
                return stroke;
            }


            public static LineStroke CreateLineStroke(System.Windows.Point st, System.Windows.Point ed, Color color, int lineWidth,int dash)
            {

                List<System.Windows.Point> pointList = new List<System.Windows.Point>();
                StylusPointCollection point;
                pointList = new List<System.Windows.Point>{
                        new System.Windows.Point(st.X, st.Y),
                        new System.Windows.Point(ed.X, ed.Y),
                    };
                point = new StylusPointCollection(pointList);
                LineStroke stroke = new LineStroke(point, color, lineWidth,dash)
                {
                    DrawingAttributes = SetInkAttributes1(color, lineWidth)
                };

                return stroke;

            }

            public static LineStroke ReCreateLine(StylusPointCollection point, Color color, int lineWidth, int dash)
            {
                LineStroke stroke = new LineStroke(point, color, lineWidth, dash)
                {
                    DrawingAttributes = SetInkAttributes1(color, lineWidth),
                };
                return stroke;
            }








            public static Dim1Stroke CreateDim1Stroke(System.Windows.Point st, System.Windows.Point ed, Color color, RatioClass ratio, Color textColor, bool showLabel, int lineWidth,int dash, bool italic, bool bold, bool underLine, int fonSize, FontFamily fontFamily,string LabPos)
            {
                List<System.Windows.Point> pointList = new List<System.Windows.Point>();
                StylusPointCollection point;
                double theta = Math.Atan2(st.Y - ed.Y, st.X - ed.X);
                double theta1 = Math.Atan2(ed.Y - st.Y, ed.X - st.X);
                pointList = new List<System.Windows.Point>
               {
                new System.Windows.Point(st.X, st.Y),
                new System.Windows.Point (st.X-10*Math.Cos(theta1+Math.PI / 2),st.Y-10*Math.Sin(theta1+Math.PI / 2)),
                new System.Windows.Point(st.X, st.Y),
                new System.Windows.Point(ed.X , ed.Y),
                new System.Windows.Point (ed.X-10*Math.Cos(theta-Math.PI / 2),ed.Y-10*Math.Sin(theta-Math.PI / 2)),
               };
                point = new StylusPointCollection(pointList);
                Dim1Stroke stroke = new Dim1Stroke(point, color, ratio, textColor, showLabel, lineWidth,dash, italic, bold, underLine, fonSize, fontFamily, LabPos)
                {
                    DrawingAttributes = SetInkAttributes1(color, lineWidth)
                };

                return stroke;
            }

            public static Dim1Stroke ReCreateDim1(StylusPointCollection point, Color color, RatioClass ratio, Color textColor, bool showLabel, int lineWidth, int dash, bool italic, bool bold, bool underLine, int fonSize, FontFamily fontFamily, string LabPos)
            {
                Dim1Stroke stroke = new Dim1Stroke(point, color, ratio, textColor, showLabel, lineWidth, dash ,italic, bold, underLine, fonSize, fontFamily, LabPos)
                {
                    DrawingAttributes = SetInkAttributes1(color, lineWidth),
                };
                return stroke;
            }




            public static Dim2Stroke CreateDim2Stroke(System.Windows.Point st, System.Windows.Point ed, Color color, RatioClass ratio, Color textColor, bool showLabel, int lineWidth, int dash, bool italic, bool bold, bool underLine, int fonSize, FontFamily fontFamily, string LabPos)
            {
                List<System.Windows.Point> pointList = new List<System.Windows.Point>();
                StylusPointCollection point;

                //double w = 20, h = 7;
                double theta = Math.Atan2(st.Y - ed.Y, st.X - ed.X);
                double theta1 = Math.Atan2(ed.Y - st.Y, ed.X - st.X);
                pointList = new List<System.Windows.Point>
               {
                new System.Windows.Point(st.X, st.Y),
                new System.Windows.Point (st.X-10*Math.Cos(theta1+Math.PI / 2),st.Y-10*Math.Sin(theta1+Math.PI / 2)),
                new System.Windows.Point (st.X-10*Math.Cos(theta1-Math.PI / 2),st.Y-10*Math.Sin(theta1-Math.PI / 2)),
                new System.Windows.Point(st.X, st.Y),
                new System.Windows.Point(ed.X , ed.Y),
                new System.Windows.Point (ed.X-10*Math.Cos(theta+Math.PI / 2),ed.Y-10*Math.Sin(theta+Math.PI / 2)),
                new System.Windows.Point (ed.X-10*Math.Cos(theta-Math.PI / 2),ed.Y-10*Math.Sin(theta-Math.PI / 2)),

               };
                point = new StylusPointCollection(pointList);
                //Point p1 = new Point(point[0].X, point[0].Y);
                //Point p2 = new Point(point[3].X, point[3].Y);
                Dim2Stroke stroke = new Dim2Stroke(point, color, ratio, textColor, showLabel, lineWidth, dash, italic, bold, underLine, fonSize, fontFamily, LabPos)
                {
                    DrawingAttributes = SetInkAttributes1(color, lineWidth)
                };

                return stroke;
            }
            public static Dim2Stroke ReCreateDim2(StylusPointCollection point, Color color, RatioClass ratio, Color textColor, bool showLabel, int lineWidth, int dash, bool italic, bool bold, bool underLine, int fonSize, FontFamily fontFamily,string LabPos)
            {
                Dim2Stroke stroke = new Dim2Stroke(point, color, ratio, textColor, showLabel, lineWidth, dash, italic, bold, underLine, fonSize, fontFamily, LabPos)
                {
                    DrawingAttributes = SetInkAttributes1(color, lineWidth),
                };
                return stroke;
            }







            public static Dim3Stroke CreateDim3Stroke(System.Windows.Point st, System.Windows.Point ed, Color color, RatioClass ratio, Color textColor, bool showLabel, int lineWidth, int dash, bool italic, bool bold, bool underLine, int fonSize, FontFamily fontFamily, string LabPos)
            {
                List<System.Windows.Point> pointList = new List<System.Windows.Point>();
                StylusPointCollection point;

                double w = 20, h = 7;
                double theta = Math.Atan2(st.Y - ed.Y, st.X - ed.X);
                double sint = Math.Sin(theta);
                double cost = Math.Cos(theta);

                double theta1 = Math.Atan2(ed.Y - st.Y, ed.X - st.X);
                double sint1 = Math.Sin(theta1);
                double cost1 = Math.Cos(theta1);

                pointList = new List<System.Windows.Point>
            {
                new System.Windows.Point(st.X, st.Y),
                new System.Windows.Point(st.X + (w * cost1 - h * sint1), st.Y + (w * sint1 + h * cost1)),
                new System.Windows.Point(st.X, st.Y),
                new System.Windows.Point(st.X + (w * cost1 + h * sint1), st.Y - (h * cost1 - w * sint1)),
                new System.Windows.Point(st.X, st.Y),
                new System.Windows.Point (st.X-10*Math.Cos(theta1+Math.PI / 2),st.Y-10*Math.Sin(theta1+Math.PI / 2)),
                new System.Windows.Point (st.X-10*Math.Cos(theta1-Math.PI / 2),st.Y-10*Math.Sin(theta1-Math.PI / 2)),
                new System.Windows.Point(st.X, st.Y),
                new System.Windows.Point(ed.X , ed.Y),
                new System.Windows.Point(ed.X + (w * cost - h * sint), ed.Y + (w * sint + h * cost)),
                new System.Windows.Point(ed.X,ed.Y),
                new System.Windows.Point(ed.X + (w * cost + h * sint), ed.Y - (h * cost - w * sint)),
                new System.Windows.Point(ed.X,ed.Y),
                new System.Windows.Point (ed.X-10*Math.Cos(theta+Math.PI / 2),ed.Y-10*Math.Sin(theta+Math.PI / 2)),
                new System.Windows.Point (ed.X-10*Math.Cos(theta-Math.PI / 2),ed.Y-10*Math.Sin(theta-Math.PI / 2)),

            };
                point = new StylusPointCollection(pointList);
                Dim3Stroke stroke = new Dim3Stroke(point, color, ratio, textColor, showLabel, lineWidth, dash, italic, bold, underLine, fonSize, fontFamily, LabPos)
                {
                    DrawingAttributes = SetInkAttributes1(color, lineWidth)
                };

                return stroke;
            }

            public static Dim3Stroke ReCreateDim3(StylusPointCollection point, Color color, RatioClass ratio, Color textColor, bool showLabel, int lineWidth, int dash, bool italic, bool bold, bool underLine, int fonSize, FontFamily fontFamily, string LabPos)
            {
                Dim3Stroke stroke = new Dim3Stroke(point, color, ratio, textColor, showLabel, lineWidth, dash, italic, bold, underLine, fonSize, fontFamily, LabPos)
                {
                    DrawingAttributes = SetInkAttributes1(color, lineWidth),
                };
                return stroke;
            }










            public static Dim4Stroke CreateDim4Stroke(System.Windows.Point st, System.Windows.Point ed, Color color, RatioClass ratio, Color textColor, bool showLabel, int lineWidth, int dash, bool italic, bool bold, bool underLine, int fonSize, FontFamily fontFamily, string LabPos)
            {
                List<System.Windows.Point> pointList = new List<System.Windows.Point>();
                StylusPointCollection point;

                double w = 20, h = 7;
                double theta = Math.Atan2(st.Y - ed.Y, st.X - ed.X);
                //double sint = Math.Sin(theta);
                //double cost = Math.Cos(theta);

                double theta1 = Math.Atan2(ed.Y - st.Y, ed.X - st.X);
                double sint1 = Math.Sin(theta1);
                double cost1 = Math.Cos(theta1);

                pointList = new List<System.Windows.Point>
            {
                new System.Windows.Point(st.X, st.Y),
                new System.Windows.Point(st.X + (w * cost1 - h * sint1), st.Y + (w * sint1 + h * cost1)),
                new System.Windows.Point(st.X, st.Y),
                new System.Windows.Point(st.X + (w * cost1 + h * sint1), st.Y - (h * cost1 - w * sint1)),
                new System.Windows.Point(st.X, st.Y),
                new System.Windows.Point (st.X-10*Math.Cos(theta1+Math.PI / 2),st.Y-10*Math.Sin(theta1+Math.PI / 2)),
                new System.Windows.Point (st.X-10*Math.Cos(theta1-Math.PI / 2),st.Y-10*Math.Sin(theta1-Math.PI / 2)),
                new System.Windows.Point(st.X, st.Y),
                new System.Windows.Point(ed.X , ed.Y),

            };
                point = new StylusPointCollection(pointList);
                Dim4Stroke stroke = new Dim4Stroke(point, color, ratio, textColor, showLabel, lineWidth, dash, italic, bold, underLine, fonSize, fontFamily, LabPos)
                {
                    DrawingAttributes = SetInkAttributes1(color, lineWidth)
                };

                return stroke;
            }

            public static Dim4Stroke ReCreateDim4(StylusPointCollection point, Color color, RatioClass ratio, Color textColor, bool showLabel, int lineWidth, int dash, bool italic, bool bold, bool underLine, int fonSize, FontFamily fontFamily, string LabPos)
            {
                Dim4Stroke stroke = new Dim4Stroke(point, color, ratio, textColor, showLabel, lineWidth, dash, italic, bold, underLine, fonSize, fontFamily, LabPos)
                {
                    DrawingAttributes = SetInkAttributes1(color, lineWidth),
                };
                return stroke;
            }


            public static ArrowStroke CreateArrowStroke(System.Windows.Point st, System.Windows.Point ed, Color color, int lineWidth,int dash)
            {

                List<System.Windows.Point> pointList = new List<System.Windows.Point>();
                StylusPointCollection point;
                double w = 20, h = 7;
                double theta = Math.Atan2(st.Y - ed.Y, st.X - ed.X);
                double sint = Math.Sin(theta);
                double cost = Math.Cos(theta);

                pointList = new List<System.Windows.Point>
            {
                new System.Windows.Point(st.X, st.Y),
                new System.Windows.Point(ed.X , ed.Y),
                new System.Windows.Point(ed.X + (w * cost - h * sint), ed.Y + (w * sint + h * cost)),
                new System.Windows.Point(ed.X,ed.Y),
                new System.Windows.Point(ed.X + (w * cost + h * sint), ed.Y - (h * cost - w * sint))
            };
                point = new StylusPointCollection(pointList);
                ArrowStroke stroke = new ArrowStroke(point, color, lineWidth,dash)
                {
                    DrawingAttributes = SetInkAttributes1(color, lineWidth)
                };


                return stroke;
            }

            public static ArrowStroke ReCreateArrow(StylusPointCollection point, Color color, int lineWidth, int dash)
            {
                ArrowStroke stroke = new ArrowStroke(point, color, lineWidth, dash)
                {
                    DrawingAttributes = SetInkAttributes1(color, lineWidth)
                };

                return stroke;
            }


        }





        public class CustomText1 : Stroke
        {
            public CustomText1(StylusPointCollection points) : base(points)
            {
                StylusPoints = points.Clone();
            }

            protected override void DrawCore(DrawingContext drawingContext, DrawingAttributes drawingAttributes)
            {

                double x1 = StylusPoints[0].X;
                double y1 = StylusPoints[0].Y;
                double x2 = StylusPoints[1].X;
               // double y2 = StylusPoints[1].Y;
                System.Windows.Point labPoint = new System.Windows.Point((x1 + x2) / 2 - 20, y1 - 20);

                drawingContext.DrawText(new FormattedText("100 μm", CultureInfo.CurrentCulture,
                FlowDirection.LeftToRight, new Typeface("Microsoft YaHei UI"), 12, System.Windows.Media.Brushes.White, 1.25), labPoint);

            }
        }


        public class CustomMarkerText : Stroke
        {
            public CustomMarkerText(StylusPointCollection points) : base(points)
            {
                StylusPoints = points.Clone();
            }

            protected override void DrawCore(DrawingContext drawingContext, DrawingAttributes drawingAttributes)
            {

                double x1 = StylusPoints[0].X;
                double y1 = StylusPoints[0].Y;
                double x2 = StylusPoints[1].X;
                double y2 = StylusPoints[1].Y;
                System.Windows.Point labPoint = new System.Windows.Point(x1 - 10, y1 - 5);
                System.Windows.Point labPoint1 = new System.Windows.Point(x2 + 5, y2 - 5);

                drawingContext.DrawText(new FormattedText("1", CultureInfo.CurrentCulture,
                FlowDirection.LeftToRight, new Typeface("Microsoft YaHei UI"), 12, System.Windows.Media.Brushes.White, 1.25), labPoint);
                drawingContext.DrawText(new FormattedText("2", CultureInfo.CurrentCulture,
                FlowDirection.LeftToRight, new Typeface("Microsoft YaHei UI"), 12, System.Windows.Media.Brushes.White, 1.25), labPoint1);
            }
        }

        public class EllipseStroke : CustomStroke
        {
            public EllipseStroke(StylusPointCollection points, Color color, int lineWidth, int dash) : base(points)
            {
                StylusPoints = points.Clone();
                ColorBru = color;
                LineWidth = lineWidth;
                Dash = dash;
                Type = "椭圆";
            }
          
            List<double> listX;
            List<double> listY;
            protected override void DrawCore(DrawingContext drawingContext, DrawingAttributes drawingAttributes)
            {

                double x0 = StylusPoints[0].X;
                double y0 = StylusPoints[0].Y;
                double x1 = StylusPoints[2].X;
                double y1 = StylusPoints[2].Y;
                listX = new List<double> { x0, x1 };
                listY = new List<double> { y0, y1 };
                double xLeft = listX.Min();
                double xRight = listX.Max();
                double yUp = listY.Max();
                double yDown = listY.Min();
                double Xcenter = (int)(xLeft + xRight) / 2;
                double Ycenter = (int)(yUp + yDown) / 2;
                CenterPoint = new Point(Xcenter, Ycenter);
                SizePoint = new Point((int)(xRight - xLeft), (int)(yUp - yDown));
                double dist = GetDistance(new System.Windows.Point(x1, y1), new System.Windows.Point(x0, y0));
                drawingContext.DrawEllipse(null, InkCanvasMethod.SetPenSolid(ColorBru, LineWidth, Dash), new Point((x0 + x1) / 2, (y1 + y0) / 2), Math.Abs(x1 - x0) / 2, Math.Abs(y1 - y0) / 2);

            }


        }
        public class CircleStroke : CustomStroke
        {
            public CircleStroke(StylusPointCollection points, Color color, int lineWidth,int dash) : base(points)
            {
                StylusPoints = points.Clone();
                ColorBru = color;
                LineWidth = lineWidth;
                Dash = dash;
                Type = "圆";
            }
           
            //int LineWidth;
            //int Dash;
            //public Color ColorBru { get; set; }
            //public int Index { get; set; }
            //public string Type { get; set; } = "圆";
            //public Point CenterPoint { get; set; }
            //public Point SizePoint { get; set; }
            List<double> listX;
            List<double> listY;
            protected override void DrawCore(DrawingContext drawingContext, DrawingAttributes drawingAttributes)
            {

                double x0 = StylusPoints[0].X;
                double y0 = StylusPoints[0].Y;
                double x1 = StylusPoints[2].X;
                double y1 = StylusPoints[2].Y;

                listX = new List<double> { x0, x1 };
                listY = new List<double> { y0, y1 };
                double xLeft = listX.Min();
                double xRight = listX.Max();
                double yUp = listY.Max();
                double yDown = listY.Min();

                double Xcenter = (int)(xLeft + xRight) / 2;
                double Ycenter = (int)(yUp + yDown) / 2;
                CenterPoint = new Point(Xcenter, Ycenter);
                SizePoint = new Point((int)(xRight - xLeft), (int)(yUp - yDown));


                double dist = GetDistance(new System.Windows.Point(x1, y1), new System.Windows.Point(x0, y0));
                // drawingContext.DrawLine(InkCanvasMethod.SetPenSolid(Color1, LineWidth), new System.Windows.Point(x0, y0), new System.Windows.Point(x1, y1));
                drawingContext.DrawEllipse(null, InkCanvasMethod.SetPenSolid(ColorBru, LineWidth,Dash), new Point((x0 + x1) / 2, (y1 + y0) / 2), Math.Abs(x1 - x0) / 2, Math.Abs(y1 - y0) / 2);
            }



        }

        public class PolygonStroke : CustomStroke
        {
            public PolygonStroke(StylusPointCollection points, Color color, int lineWidth,int dash) : base(points)
            {
                StylusPoints = points.Clone();
                ColorBru = color;
                LineWidth = lineWidth;
                Dash = dash;
                Type = "多边形";
            }
            //int LineWidth;
            //int Dash;
            //public Color ColorBru { get; set; }
            //public int Index { get; set; }
            //public string Type { get; set; } = "多边形";
            //public Point CenterPoint { get; set; }
            //public Point SizePoint { get; set; }
            List<double> listX = new List<double>();
            List<double> listY = new List<double>();
            protected override void DrawCore(DrawingContext drawingContext, DrawingAttributes drawingAttributes)
            {
                listX.Clear();
                listY.Clear();
                for (int i = 0; i < StylusPoints.Count-1; i++)
                {
                    double x0 = StylusPoints[i].X;
                    double y0 = StylusPoints[i].Y;
                    double x1 = StylusPoints[i+1].X;
                    double y1 = StylusPoints[i + 1].Y;
                    drawingContext.DrawLine(InkCanvasMethod.SetPenSolid(ColorBru, LineWidth,Dash), new System.Windows.Point(x0, y0), new System.Windows.Point(x1, y1));
                    listX.Add(x0);
                    listY.Add(y0);


                }

                double xLeft = listX.Min();
                double xRight = listX.Max();
                double yUp = listY.Max();
                double yDown = listY.Min();
                double Xcenter = (int)(xLeft + xRight) / 2;
                double Ycenter = (int)(yUp + yDown) / 2;
                CenterPoint = new Point(Xcenter, Ycenter);
                SizePoint = new Point((int)(xRight - xLeft), (int)(yUp - yDown));

            }

        }





       

        public class LineStroke : CustomStroke
        {
            public LineStroke(StylusPointCollection points, Color color, int lineWidth, int dash) : base(points)
            {
                StylusPoints = points.Clone();
                ColorBru = color;
                LineWidth = lineWidth;
                Dash = dash;
                Type = "直线";
                dimSelectIndex = 0;
            }
            //public Color ColorBru { get; set; }
            //int LineWidth;
            //int Dash;
            //public int Index { get; set; }
            //public string Type { get; set; } = "直线";
            //public Point CenterPoint { get; set; }
            //public Point SizePoint { get; set; }
            List<double> listX;
            List<double> listY;

            protected override void DrawCore(DrawingContext drawingContext, DrawingAttributes drawingAttributes)
            {

                double x0 = StylusPoints[0].X;
                double y0 = StylusPoints[0].Y;
                double x1 = StylusPoints[1].X;
                double y1 = StylusPoints[1].Y;

                listX = new List<double> { x0, x1 };
                listY = new List<double> { y0, y1 };
                double xLeft = listX.Min();
                double xRight = listX.Max();
                double yUp = listY.Max();
                double yDown = listY.Min();

                double Xcenter = (int)(xLeft + xRight) / 2;
                double Ycenter = (int)(yUp + yDown) / 2;
                CenterPoint = new Point(Xcenter, Ycenter);
                SizePoint = new Point((int)(xRight - xLeft), (int)(yUp - yDown));
                drawingContext.DrawLine(InkCanvasMethod.SetPenSolid(ColorBru, LineWidth,Dash), new System.Windows.Point(x0, y0), new System.Windows.Point(x1, y1));

            }


        }
        public class ArrowStroke : CustomStroke
        {
            public ArrowStroke(StylusPointCollection points, Color color, int lineWidth,int dash) : base(points)
            {
                StylusPoints = points.Clone();
                ColorBru = color;
                LineWidth = lineWidth;
                Dash = dash;
                Type = "箭头";
                dimSelectIndex = 1;
            }
            //public Color ColorBru { get; set; }
            //int LineWidth;
            //int Dash;
            //public int Index { get; set; }
            //public string Type { get; set; } = "箭头";
            //public Point CenterPoint { get; set; }
            //public Point SizePoint { get; set; }
            List<double> listX;
            List<double> listY;
            protected override void DrawCore(DrawingContext drawingContext, DrawingAttributes drawingAttributes)
            {

                double x0 = StylusPoints[0].X;
                double y0 = StylusPoints[0].Y;
                double x1 = StylusPoints[1].X;
                double y1 = StylusPoints[1].Y;
                double x2 = StylusPoints[2].X;
                double y2 = StylusPoints[2].Y;
                double x4 = StylusPoints[4].X;
                double y4 = StylusPoints[4].Y;

                listX = new List<double> { x0, x1, x2, x4 };
                listY = new List<double> { y0, y1, y2, y4 };
                double xLeft = listX.Min();
                double xRight = listX.Max();
                double yUp = listY.Max();
                double yDown = listY.Min();

                double Xcenter = (int)(xLeft + xRight) / 2;
                double Ycenter = (int)(yUp + yDown) / 2;
                CenterPoint = new Point(Xcenter, Ycenter);
                SizePoint = new Point((int)(xRight - xLeft), (int)(yUp - yDown));
                drawingContext.DrawLine(InkCanvasMethod.SetPenSolid(ColorBru, LineWidth, Dash), new System.Windows.Point(x0, y0), new System.Windows.Point(x1, y1));
                drawingContext.DrawLine(InkCanvasMethod.SetPenSolid(ColorBru, LineWidth, Dash), new System.Windows.Point(x2, y2), new System.Windows.Point(x1, y1));
                drawingContext.DrawLine(InkCanvasMethod.SetPenSolid(ColorBru, LineWidth, Dash), new System.Windows.Point(x4, y4), new System.Windows.Point(x1, y1));

            }
        }

        public class Dim1Stroke : CustomStroke
        {
            public Dim1Stroke(StylusPointCollection points, Color color, RatioClass ratio, Color textColor, bool showLabel, int lineWidth,int dash ,bool italic, bool bold, bool underLine, int fontSize, FontFamily fontFamily, string labPos) : base(points)
            {
                StylusPoints = points.Clone();
                ColorBru = color;
                this.ratio = ratio;
                this.textColor = textColor;
               
                LineWidth = lineWidth;
                Dash = dash;
                Type = "标尺 A";
                Italic = italic;
                Bold = bold;
                UnderLine = underLine;
                FontFamily = fontFamily;
                Fontsize = fontSize;

                this.showLabel = showLabel;
                LabPos = labPos;
                dimSelectIndex = 2;

            }
            //int LineWidth;
            //int Dash;
            //public Color ColorBru { get; set; }
            //public int Index { get; set; }
            //public string Type { get; set; } = "标尺 A";
            //public Point CenterPoint { get; set; }
            //public Point SizePoint { get; set; }
            //RatioClass ratio;
            //bool showLabel;
            //Color textColor;
            List<double> listX;
            List<double> listY;
            protected override void DrawCore(DrawingContext drawingContext, DrawingAttributes drawingAttributes)
            {

                double x0 = StylusPoints[0].X;
                double y0 = StylusPoints[0].Y;
                double x1 = StylusPoints[1].X;
                double y1 = StylusPoints[1].Y;
                double x3 = StylusPoints[3].X;
                double y3 = StylusPoints[3].Y;
                double x4 = StylusPoints[4].X;
                double y4 = StylusPoints[4].Y;
                listX = new List<double> { x0, x1, x3, x4 };
                listY = new List<double> { y0, y1, y3, y4};
                double xLeft = listX.Min();
                double xRight = listX.Max();
                double yUp = listY.Max();
                double yDown = listY.Min();

                double Xcenter = (int)(xLeft + xRight) / 2;
                double Ycenter = (int)(yUp + yDown) / 2;
                CenterPoint = new Point(Xcenter, Ycenter);
                SizePoint = new Point((int)(xRight - xLeft), (int)(yUp - yDown));


                double theta = Math.Atan2(y3 - y0, x3 - x0);
                angle = theta / Math.PI * 180;
                double dist = GetDistance(new Point(x0, y0), new Point(x3, y3));
                length= (double)dist /ratio.actualwidth * 1689.12 / ratio.Ratio;



                // DrawInkMethod.dimenViewModel.Length = (double)dist / ratio1.actualwidth * 1689.12 / ratio1.Ratio;

                drawingContext.DrawLine(InkCanvasMethod.SetPenSolid(ColorBru, LineWidth, Dash), new System.Windows.Point(x0, y0), new System.Windows.Point(x1, y1));
                drawingContext.DrawLine(InkCanvasMethod.SetPenSolid(ColorBru, LineWidth, Dash), new System.Windows.Point(x0, y0), new System.Windows.Point(x3, y3));
                drawingContext.DrawLine(InkCanvasMethod.SetPenSolid(ColorBru, LineWidth, Dash), new System.Windows.Point(x3, y3), new System.Windows.Point(x4, y4));

                customTextInput= WriteText(new Point(x0, y0), new Point(x3, y3), ratio, textColor, Italic, Bold, UnderLine, Fontsize, FontFamily);

                DrawText(drawingContext, customTextInput,new Point(x0, y0), new Point(x3, y3), ratio, textColor, showLabel, UnderLine,LabPos);


            }
        }
        public class Dim2Stroke : CustomStroke
        {
            public Dim2Stroke(StylusPointCollection points, Color color, RatioClass ratio, Color textColor, bool showLabel, int lineWidth, int dash, bool italic, bool bold, bool underLine, int fontSize, FontFamily fontFamily, string labPos) : base(points)
            {
                StylusPoints = points.Clone();
                ColorBru = color;
                this.ratio = ratio;
                this.textColor = textColor;
                this.showLabel = showLabel;
                LineWidth = lineWidth;
                Dash = dash;
                Type = "标尺 B";

                Italic = italic;
                Bold = bold;
                UnderLine = underLine;
                FontFamily = fontFamily;
                Fontsize = fontSize;
                LabPos = labPos;
                dimSelectIndex =3;
            }
            //int LineWidth;
            //int Dash;
            //public Color ColorBru { get; set; }
            //public int Index { get; set; }
            //public string Type { get; set; } = "标尺 A";
            //public Point CenterPoint { get; set; }
            //public Point SizePoint { get; set; }
            //RatioClass ratio;
            //bool showLabel;
            //Color textColor;
            List<double> listX;
            List<double> listY;
            protected override void DrawCore(DrawingContext drawingContext, DrawingAttributes drawingAttributes)
            {

                double x0 = StylusPoints[0].X;
                double y0 = StylusPoints[0].Y;
                double x1 = StylusPoints[1].X;
                double y1 = StylusPoints[1].Y;
                double x2 = StylusPoints[2].X;
                double y2 = StylusPoints[2].Y;
                double x3 = StylusPoints[3].X;
                double y3 = StylusPoints[3].Y;
                double x4 = StylusPoints[4].X;
                double y4 = StylusPoints[4].Y;
                double x5 = StylusPoints[5].X;
                double y5 = StylusPoints[5].Y;
                double x6 = StylusPoints[6].X;
                double y6 = StylusPoints[6].Y;
                listX = new List<double> { x0, x1, x2, x3, x4, x5, x6 };
                listY = new List<double> { y0, y1, y2, y3, y4, y5, y6};
                double xLeft = listX.Min();
                double xRight = listX.Max();
                double yUp = listY.Max();
                double yDown = listY.Min();

                double Xcenter = (int)(xLeft + xRight) / 2;
                double Ycenter = (int)(yUp + yDown) / 2;
                CenterPoint = new Point(Xcenter, Ycenter);
                SizePoint = new Point((int)(xRight - xLeft), (int)(yUp - yDown));

                double theta = Math.Atan2(y4 - y0, x4 - x0);
                angle = theta / Math.PI * 180;
                double dist = GetDistance(new Point(x0, y0), new Point(x4, y4));
                length = (double)dist / ratio.actualwidth * 1689.12 / ratio.Ratio;




                // drawingContext.DrawLine(InkCanvasMethod.SetPenSolid(Color1), new System.Windows.Point(x4, y4), new System.Windows.Point(x5, y5));

                drawingContext.DrawLine(InkCanvasMethod.SetPenSolid(ColorBru, LineWidth,Dash), new System.Windows.Point(x1, y1), new System.Windows.Point(x2, y2));
                drawingContext.DrawLine(InkCanvasMethod.SetPenSolid(ColorBru, LineWidth, Dash), new System.Windows.Point(x3, y3), new System.Windows.Point(x4, y4));
                drawingContext.DrawLine(InkCanvasMethod.SetPenSolid(ColorBru, LineWidth, Dash), new System.Windows.Point(x5, y5), new System.Windows.Point(x6, y6));
                customTextInput = WriteText(new Point(x3, y3), new Point(x4, y4), ratio, textColor, Italic, Bold, UnderLine, Fontsize, FontFamily);
                DrawText(drawingContext, customTextInput,new Point(x0, y0), new Point(x4, y4), ratio, textColor, showLabel, UnderLine, LabPos);






            }
        }

        public class Dim3Stroke : CustomStroke
        {
            public Dim3Stroke(StylusPointCollection points, Color color, RatioClass ratio, Color textColor, bool showLabel, int lineWidth, int dash, bool italic, bool bold, bool underLine, int fontSize, FontFamily fontFamily, string labPos) : base(points)
            {
                StylusPoints = points.Clone();
                ColorBru = color;
                this.ratio = ratio;
                this.textColor = textColor;
                this.showLabel = showLabel;
                LineWidth = lineWidth;
                Dash = dash;
                Type= "标尺 C";

                Italic = italic;
                Bold = bold;
                UnderLine = underLine;
                FontFamily = fontFamily;
                Fontsize = fontSize;
                LabPos = labPos;
                dimSelectIndex = 4;
            }
            //int LineWidth;
            //int Dash;
            //public Color ColorBru { get; set; }
            //public int Index { get; set; }
            //public string Type { get; set; } = "标尺 A";
            //public Point CenterPoint { get; set; }
            //public Point SizePoint { get; set; }
            //RatioClass ratio;
            //bool showLabel;
            //Color textColor;
            List<double> listX;
            List<double> listY;
            protected override void DrawCore(DrawingContext drawingContext, DrawingAttributes drawingAttributes)
            {

                double x0 = StylusPoints[0].X;
                double y0 = StylusPoints[0].Y;
                double x1 = StylusPoints[1].X;
                double y1 = StylusPoints[1].Y;
                double x2 = StylusPoints[3].X;
                double y2 = StylusPoints[3].Y;
                double x3 = StylusPoints[5].X;
                double y3 = StylusPoints[5].Y;
                double x4 = StylusPoints[6].X;
                double y4 = StylusPoints[6].Y;

                double x5 = StylusPoints[8].X;
                double y5 = StylusPoints[8].Y;
                double x6 = StylusPoints[9].X;
                double y6 = StylusPoints[9].Y;
                double x7 = StylusPoints[11].X;
                double y7 = StylusPoints[11].Y;
                double x8 = StylusPoints[13].X;
                double y8 = StylusPoints[13].Y;
                double x9 = StylusPoints[14].X;
                double y9 = StylusPoints[14].Y;

                listX = new List<double> { x0, x1, x2, x3, x4, x5,x6,x7,x8,x9 };
                listY = new List<double> { y0, y1, y2, y3, y4, y5,y6,y7,y8,y9 };
                double xLeft = listX.Min();
                double xRight = listX.Max();
                double yUp = listY.Max();
                double yDown = listY.Min();

                double Xcenter = (int)(xLeft + xRight) / 2;
                double Ycenter = (int)(yUp + yDown) / 2;
                CenterPoint = new Point(Xcenter, Ycenter);
                SizePoint = new Point((int)(xRight - xLeft), (int)(yUp - yDown));


                double theta = Math.Atan2(y5 - y0, x5 - x0);
                angle = theta / Math.PI * 180;
                double dist = GetDistance(new Point(x0, y0), new Point(x5, y5));
                length = (double)dist / ratio.actualwidth * 1689.12 / ratio.Ratio;


                // drawingContext.DrawLine(InkCanvasMethod.SetPenSolid(Color1), new System.Windows.Point(x4, y4), new System.Windows.Point(x5, y5));

                drawingContext.DrawLine(InkCanvasMethod.SetPenSolid(ColorBru, LineWidth,Dash), new System.Windows.Point(x0, y0), new System.Windows.Point(x1, y1));
                drawingContext.DrawLine(InkCanvasMethod.SetPenSolid(ColorBru, LineWidth, Dash), new System.Windows.Point(x0, y0), new System.Windows.Point(x2, y2));
                drawingContext.DrawLine(InkCanvasMethod.SetPenSolid(ColorBru, LineWidth, Dash), new System.Windows.Point(x3, y3), new System.Windows.Point(x4, y4));
                drawingContext.DrawLine(InkCanvasMethod.SetPenSolid(ColorBru, LineWidth, Dash), new System.Windows.Point(x0, y0), new System.Windows.Point(x5, y5));
                drawingContext.DrawLine(InkCanvasMethod.SetPenSolid(ColorBru, LineWidth, Dash), new System.Windows.Point(x5, y5), new System.Windows.Point(x6, y6));
                drawingContext.DrawLine(InkCanvasMethod.SetPenSolid(ColorBru, LineWidth, Dash), new System.Windows.Point(x5, y5), new System.Windows.Point(x7, y7));
                drawingContext.DrawLine(InkCanvasMethod.SetPenSolid(ColorBru, LineWidth, Dash), new System.Windows.Point(x8, y8), new System.Windows.Point(x9, y9));
                customTextInput = WriteText(new Point(x0, y0), new Point(x5, y5), ratio, textColor, Italic, Bold, UnderLine, Fontsize, FontFamily);
                DrawText(drawingContext, customTextInput,new Point(x0, y0), new Point(x5, y5), ratio, textColor, showLabel, UnderLine, LabPos);


            }
        }

        public class Dim4Stroke : CustomStroke
        {
            public Dim4Stroke(StylusPointCollection points, Color color, RatioClass ratio, Color textColor, bool showLabel, int lineWidth, int dash, bool italic, bool bold, bool underLine, int fontSize, FontFamily fontFamily, string labPos) : base(points)
            {
                StylusPoints = points.Clone();
                ColorBru = color;
                this.ratio = ratio;
                this.textColor = textColor;
                this.showLabel = showLabel;
                LineWidth = lineWidth;
                Dash = dash;
                Type = "标尺 D";

                Italic = italic;
                Bold = bold;
                UnderLine = underLine;
                FontFamily = fontFamily;
                Fontsize = fontSize;
                LabPos = labPos;
                dimSelectIndex = 5;
            }
            //int LineWidth;
            //int Dash;
            //public Color ColorBru { get; set; }
            //public int Index { get; set; }
            //public string Type { get; set; } = "标尺 A";
            //public Point CenterPoint { get; set; }
            //public Point SizePoint { get; set; }
            //RatioClass ratio;
            //bool showLabel;
            //Color textColor;
            List<double> listX;
            List<double> listY;
            protected override void DrawCore(DrawingContext drawingContext, DrawingAttributes drawingAttributes)
            {

                double x0 = StylusPoints[0].X;
                double y0 = StylusPoints[0].Y;
                double x1 = StylusPoints[1].X;
                double y1 = StylusPoints[1].Y;
                double x2 = StylusPoints[3].X;
                double y2 = StylusPoints[3].Y;
                double x3 = StylusPoints[5].X;
                double y3 = StylusPoints[5].Y;
                double x4 = StylusPoints[6].X;
                double y4 = StylusPoints[6].Y;
                double x5 = StylusPoints[8].X;
                double y5 = StylusPoints[8].Y;

                listX = new List<double> { x0, x1, x2, x3, x4,x5 };
                listY = new List<double> { y0, y1, y2, y3, y4 ,y5};
                double xLeft = listX.Min();
                double xRight = listX.Max();
                double yUp = listY.Max();
                double yDown = listY.Min();

                double Xcenter = (int)(xLeft + xRight) / 2;
                double Ycenter = (int)(yUp + yDown) / 2;
                CenterPoint = new Point(Xcenter, Ycenter);
                SizePoint = new Point((int)(xRight - xLeft), (int)(yUp - yDown));

                double theta = Math.Atan2(y5 - y0, x5 - x0);
                angle = theta / Math.PI * 180;
                double dist = GetDistance(new Point(x0, y0), new Point(x5, y5));
                length = (double)dist / ratio.actualwidth * 1689.12 / ratio.Ratio;




                // drawingContext.DrawLine(InkCanvasMethod.SetPenSolid(Color1), new System.Windows.Point(x4, y4), new System.Windows.Point(x5, y5));
                drawingContext.DrawLine(InkCanvasMethod.SetPenSolid(ColorBru, LineWidth, Dash), new System.Windows.Point(x0, y0), new System.Windows.Point(x1, y1));
                drawingContext.DrawLine(InkCanvasMethod.SetPenSolid(ColorBru, LineWidth, Dash), new System.Windows.Point(x0, y0), new System.Windows.Point(x2, y2));
                drawingContext.DrawLine(InkCanvasMethod.SetPenSolid(ColorBru, LineWidth, Dash), new System.Windows.Point(x3, y3), new System.Windows.Point(x4, y4));
                drawingContext.DrawLine(InkCanvasMethod.SetPenSolid(ColorBru, LineWidth, Dash), new System.Windows.Point(x0, y0), new System.Windows.Point(x5, y5));
                customTextInput = WriteText(new Point(x0, y0), new Point(x5, y5), ratio, textColor, Italic, Bold, UnderLine, Fontsize, FontFamily);
                DrawText(drawingContext, customTextInput, new Point(x0, y0), new Point(x5, y5), ratio,  textColor, showLabel, UnderLine, LabPos);


            }
        }











        public class RectangleStroke : CustomStroke
        {
            public RectangleStroke(StylusPointCollection points, Color color, int lineWidth,int dash) : base(points)
            {
                StylusPoints = points.Clone();
                ColorBru = color;
                LineWidth = lineWidth;
                Dash = dash;
                Type  = "矩形";
            }
            //public Color ColorBru { get; set; }
           
            //int LineWidth;
            //int Dash;
            //public int Index { get; set; }
            //public string Type { get; set; } = "矩形";
            //public Point CenterPoint { get; set; }
            //public Point SizePoint { get; set; }
            List<double> listX;
            List<double> listY;
            protected override void DrawCore(DrawingContext drawingContext, DrawingAttributes drawingAttributes)
            {

                double x0 = StylusPoints[0].X;
                double y0 = StylusPoints[0].Y;
                double x1 = StylusPoints[1].X;
                double y1 = StylusPoints[1].Y;
                double x2 = StylusPoints[2].X;
                double y2 = StylusPoints[2].Y;
                double x3 = StylusPoints[3].X;
                double y3 = StylusPoints[3].Y;
                double x4 = StylusPoints[4].X;
                double y4 = StylusPoints[4].Y;
                
                 listX = new List<double> { x0, x1, x2, x3, x4 };
                 listY = new List<double> { y0, y1, y2, y3, y4 };
                 double xLeft = listX.Min();
                 double xRight = listX.Max();
                 double yUp = listY.Max();
                 double yDown = listY.Min();

                double Xcenter =(int) (xLeft + xRight) / 2;
                double Ycenter = (int)(yUp + yDown) / 2;
                CenterPoint = new Point(Xcenter, Ycenter);
                SizePoint = new Point((int)(xRight - xLeft),(int) (yUp - yDown));
                // drawingContext.DrawLine(InkCanvasMethod.SetPenSolid(Color1), new System.Windows.Point(x4, y4), new System.Windows.Point(x5, y5));

                drawingContext.DrawLine(InkCanvasMethod.SetPenSolid(ColorBru, LineWidth, Dash), new System.Windows.Point(x0, y0), new System.Windows.Point(x1, y1));
                drawingContext.DrawLine(InkCanvasMethod.SetPenSolid(ColorBru, LineWidth, Dash), new System.Windows.Point(x1, y1), new System.Windows.Point(x2, y2));
                drawingContext.DrawLine(InkCanvasMethod.SetPenSolid(ColorBru, LineWidth, Dash), new System.Windows.Point(x2, y2), new System.Windows.Point(x3, y3));
                drawingContext.DrawLine(InkCanvasMethod.SetPenSolid(ColorBru, LineWidth, Dash), new System.Windows.Point(x3, y3), new System.Windows.Point(x4, y4));
               // drawingContext.DrawRectangle(InkCanvasMethod.SetPenSolid(Color1, LineWidth), new System.Windows.Point(x0, y0), new System.Windows.Point(x1, y1));
            }


        }
        public class SquareStroke : CustomStroke
        {
            public SquareStroke(StylusPointCollection points, Color color, int lineWidth,int dash) : base(points)
            {
                StylusPoints = points.Clone();
                ColorBru = color;
                LineWidth = lineWidth;
                Dash = dash;
                Type = "正方形";
            }
            //public Color ColorBru { get; set; }
            //int LineWidth;
            //int Dash;
           
            //public int Index { get; set; }
            //public string Type { get; set; } = "正方形";
            //public Point CenterPoint { get; set; }
            //public Point SizePoint { get; set; }
            List<double> listX;
            List<double> listY;
            protected override void DrawCore(DrawingContext drawingContext, DrawingAttributes drawingAttributes)
            {

                double x0 = StylusPoints[0].X;
                double y0 = StylusPoints[0].Y;
                double x1 = StylusPoints[1].X;
                double y1 = StylusPoints[1].Y;
                double x2 = StylusPoints[2].X;
                double y2 = StylusPoints[2].Y;
                double x3 = StylusPoints[3].X;
                double y3 = StylusPoints[3].Y;
                double x4 = StylusPoints[4].X;
                double y4 = StylusPoints[4].Y;

                listX = new List<double> { x0, x1, x2, x3, x4 };
                listY = new List<double> { y0, y1, y2, y3, y4 };
                double xLeft = listX.Min();
                double xRight = listX.Max();
                double yUp = listY.Max();
                double yDown = listY.Min();

                double Xcenter = (int)(xLeft + xRight) / 2;
                double Ycenter = (int)(yUp + yDown) / 2;
                CenterPoint = new Point(Xcenter, Ycenter);
                SizePoint = new Point((int)(xRight - xLeft), (int)(yUp - yDown));




                // drawingContext.DrawLine(InkCanvasMethod.SetPenSolid(Color1), new System.Windows.Point(x4, y4), new System.Windows.Point(x5, y5));

                drawingContext.DrawLine(InkCanvasMethod.SetPenSolid(ColorBru, LineWidth, Dash), new System.Windows.Point(x0, y0), new System.Windows.Point(x1, y1));
                drawingContext.DrawLine(InkCanvasMethod.SetPenSolid(ColorBru, LineWidth, Dash), new System.Windows.Point(x1, y1), new System.Windows.Point(x2, y2));
                drawingContext.DrawLine(InkCanvasMethod.SetPenSolid(ColorBru, LineWidth, Dash), new System.Windows.Point(x2, y2), new System.Windows.Point(x3, y3));
                drawingContext.DrawLine(InkCanvasMethod.SetPenSolid(ColorBru, LineWidth, Dash), new System.Windows.Point(x3, y3), new System.Windows.Point(x4, y4));

            }

        }



        public class Bezierpath : CustomStroke
        {
            public Bezierpath(StylusPointCollection points, Color color, int lineWidth,int dash) : base(points)
            {
                StylusPoints = points.Clone();
                ColorBru = color;
                LineWidth = lineWidth;
                Dash = dash;
                Type = "曲线";
            }
            //public Color ColorBru { get; set; }
            //int LineWidth;
            //int Dash;
            //public int Index { get; set; }
            //public string Type { get; set; } = "曲线";
            //public string Points { get; set; }
            //public Point CenterPoint { get; set; }
            //public Point SizePoint { get; set; }
            List<double> listX;
            List<double> listY;
            protected override void DrawCore(DrawingContext drawingContext, DrawingAttributes drawingAttributes)
            {

                double x0 = StylusPoints[0].X;
                double y0 = StylusPoints[0].Y;
                double x1 = StylusPoints[1].X;
                double y1 = StylusPoints[1].Y;
                double x2 = StylusPoints[2].X;
                double y2 = StylusPoints[2].Y;
                double x3 = StylusPoints[3].X;
                double y3 = StylusPoints[3].Y;
             

                listX = new List<double> { x0, x1, x2, x3};
                listY = new List<double> { y0, y1, y2, y3};
                double xLeft = listX.Min();
                double xRight = listX.Max();
                double yUp = listY.Max();
                double yDown = listY.Min();

                double Xcenter = (int)(xLeft + xRight) / 2;
                double Ycenter = (int)(yUp + yDown) / 2;
                CenterPoint = new Point(Xcenter, Ycenter);
                SizePoint = new Point((int)(xRight - xLeft), (int)(yUp - yDown));


                PathGeometry geometry = new PathGeometry();
                PathFigure figure = new PathFigure
                {
                    StartPoint = (Point)StylusPoints[0],

                };


                BezierSegment bezierSegment = new BezierSegment((Point)StylusPoints[1], (Point)StylusPoints[2], (Point)StylusPoints[3], true);
                figure.Segments.Add(bezierSegment);
                geometry.Figures.Add(figure);
                drawingContext.DrawGeometry(null, InkCanvasMethod.SetPenSolid(ColorBru, LineWidth, Dash), geometry);


            }
        }


        public class QuadraticBezierpath : CustomStroke
        {
            public QuadraticBezierpath(StylusPointCollection points, Color color, int lineWidth,int dash) : base(points)
            {
                StylusPoints = points.Clone();
                ColorBru = color;
                LineWidth = lineWidth;
                Dash = dash;
                Type = "曲线1";

            }
            //public Color ColorBru { get; set; }
            //int LineWidth;
            //int Dash;
            //public int Index { get; set; }
            //public string Type { get; set; } = "曲线1";
            //public Point CenterPoint { get; set; }
            //public Point SizePoint { get; set; }
            List<double> listX;
            List<double> listY;
            protected override void DrawCore(DrawingContext drawingContext, DrawingAttributes drawingAttributes)
            {



                double x0 = StylusPoints[0].X;
                double y0 = StylusPoints[0].Y;
                double x1 = StylusPoints[1].X;
                double y1 = StylusPoints[1].Y;
                double x2 = StylusPoints[2].X;
                double y2 = StylusPoints[2].Y;
                listX = new List<double> { x0, x1, x2 };
                listY = new List<double> { y0, y1, y2};
                double xLeft = listX.Min();
                double xRight = listX.Max();
                double yUp = listY.Max();
                double yDown = listY.Min();

                double Xcenter = (int)(xLeft + xRight) / 2;
                double Ycenter = (int)(yUp + yDown) / 2;
                CenterPoint = new Point(Xcenter, Ycenter);
                SizePoint = new Point((int)(xRight - xLeft), (int)(yUp - yDown));





                PathGeometry geometry = new PathGeometry();
                PathFigure figure = new PathFigure
                {
                    StartPoint = (Point)StylusPoints[0],

                };
                QuadraticBezierSegment quadraticBezier = new QuadraticBezierSegment((Point)StylusPoints[1], (Point)StylusPoints[2], true);
                figure.Segments.Add(quadraticBezier);

                geometry.Figures.Add(figure);
                drawingContext.DrawGeometry(null, InkCanvasMethod.SetPenSolid(ColorBru, LineWidth, Dash), geometry);


            }
        }




        public class CustomProfile : Stroke
        {
            public CustomProfile(StylusPointCollection points, ProfileModel ratio, Color color) : base(points)
            {
                StylusPoints = points.Clone();
                this.ratio = ratio;
                color1 = color;
            }
            ProfileModel ratio;
            Color color1;
            protected override void DrawCore(DrawingContext drawingContext, DrawingAttributes drawingAttributes)
            {

                double x1 = StylusPoints[0].X;
                double y1 = StylusPoints[0].Y;
                double x2 = StylusPoints[1].X;
                double y2 = StylusPoints[1].Y;
                Vector vector = new Point(x2, y2) - new Point(x1, y1);
                Point p3 = new Point(x1, y1) + ratio.Ratio1 * vector;
                Point p4 = new Point(x1, y1) + ratio.Ratio2 * vector;

                System.Windows.Point labPoint = new System.Windows.Point(x1 - 12, y1 - 8);
                System.Windows.Point labPoint1 = new System.Windows.Point(x2 + 7, y2 - 8);

                drawingContext.DrawText(new FormattedText("1", CultureInfo.CurrentCulture,
                FlowDirection.LeftToRight, new Typeface("Microsoft YaHei UI"), 12, System.Windows.Media.Brushes.White, 1.25), labPoint);
                drawingContext.DrawText(new FormattedText("2", CultureInfo.CurrentCulture,
                FlowDirection.LeftToRight, new Typeface("Microsoft YaHei UI"), 12, System.Windows.Media.Brushes.White, 1.25), labPoint1);
                drawingContext.DrawLine(InkCanvasMethod.SetPenSolid(color1, 1,0), new System.Windows.Point(x1, y1), new System.Windows.Point(x2, y2));
                drawingContext.DrawEllipse(null, InkCanvasMethod.SetPenSolid2(), new System.Windows.Point(x1, y1), 1.5, 1.5);
                drawingContext.DrawEllipse(null, InkCanvasMethod.SetPenSolid2(), new System.Windows.Point(x2, y2), 1.5, 1.5);
                if (ratio.Marker1Show)
                {
                    drawingContext.DrawEllipse(null, InkCanvasMethod.SetPenSolid3(), p3, 1.5, 1.5);
                }
                if (ratio.Marker2Show)
                {
                    drawingContext.DrawEllipse(null, InkCanvasMethod.SetPenSolid4(), p4, 1.5, 1.5);
                }




            }
        }




        public class CustomTextInput : CustomStroke
        {
            public CustomTextInput(StylusPointCollection points, FormattedText text, Color brush, bool italic, bool bold, bool underLine, int fontSize, FontFamily fontFamily) : base(points)
            {
                StylusPoints = points.Clone();

                this.customTextInput = text;
                this.textColor = brush;
                Index = 1;
                Type = "文本";
                UnderLine= underLine;
                Italic = italic;
                Bold = bold;
                Fontsize = fontSize;
                FontFamily = fontFamily;


            }
            //FormattedText customTextInput;
            //public int Index { get; set; }
            //public Color ColorBru { get; set; }
            //public string Type { get; set; } = "文本";

            //public Point CenterPoint { get; set; }
            List<double> listX;
            List<double> listY;
            protected override void DrawCore(DrawingContext drawingContext, DrawingAttributes drawingAttributes)
            {

                double x1 = StylusPoints[0].X;
                double y1 = StylusPoints[0].Y;
                double x2 = StylusPoints[1].X;
                double y2 = StylusPoints[1].Y;
                double x3 = StylusPoints[2].X;
                double y3 = StylusPoints[2].Y;
                double x4 = StylusPoints[3].X;
                double y4 = StylusPoints[3].Y;


                listX = new List<double> { x1, x2, x3, x4 };
                listY = new List<double> { y1, y2, y3, y4 };
                double xLeft = listX.Min();
                double xRight = listX.Max();
                double yUp = listY.Max();
                double yDown = listY.Min();

                double Xcenter = (int)(xLeft + xRight) / 2;
                double Ycenter = (int)(yUp + yDown) / 2;
                CenterPoint = new Point(Xcenter, Ycenter);
                SizePoint = new Point((int)(xRight - xLeft), (int)(yUp - yDown));

                System.Windows.Point labPoint = new System.Windows.Point(x1 - 1, y1 - 1);
                drawingContext.DrawText(customTextInput, labPoint);
                Brush brush = new SolidColorBrush(textColor);
                if (UnderLine)
                {
                    drawingContext.DrawLine(InkCanvasMethod.SetPenSolid5(brush), new System.Windows.Point(x3, y3), new System.Windows.Point(x4, y4));
                }


            }
        }


        public class CustomRulerText : Stroke
        {
            public CustomRulerText(StylusPointCollection points, RatioClass ratio) : base(points)
            {
                StylusPoints = points.Clone();
                this.ratio = ratio;

            }
            RatioClass ratio;


            protected override void DrawCore(DrawingContext drawingContext, DrawingAttributes drawingAttributes)
            {

                double x1 = StylusPoints[0].X;
                double y1 = StylusPoints[0].Y;
                double x2 = StylusPoints[1].X;
                double y2 = StylusPoints[1].Y;


                double dist = GetDistance(new System.Windows.Point(x1, y1), new System.Windows.Point(x2, y2)) / ratio.Ratio;
                dist = (double)dist / ratio.actualwidth * 1689.12;
                string label = Math.Round(dist, 2).ToString() + " μm";

                System.Windows.Point labelPosition;
                FormattedText formattedText = new FormattedText(label, CultureInfo.CurrentCulture,

                                              FlowDirection.LeftToRight, new Typeface("Microsoft YaHei UI"), 12, System.Windows.Media.Brushes.White, 1.25);
                int textHeight = (int)formattedText.Height;
                int textWidth = (int)formattedText.Width;
                labelPosition = new System.Windows.Point((x1 + x2 - textWidth) / 2, (y1 + y2) / 2 - textHeight - 10);
                drawingContext.DrawText(formattedText, labelPosition);

            }
        }




        public class CustomText : Stroke
        {
            public CustomText(StylusPointCollection points, RatioClass ratio, Color color) : base(points)
            {
                StylusPoints = points.Clone();
                this.ratio = ratio;
                color1 = color;
            }
            RatioClass ratio;
            Color color1;

            protected override void DrawCore(DrawingContext drawingContext, DrawingAttributes drawingAttributes)
            {

                double x1 = StylusPoints[0].X;
                double y1 = StylusPoints[0].Y;
                double x2 = StylusPoints[1].X;
                double y2 = StylusPoints[1].Y;
                double theta = Math.Atan2(y1 - y2, x1 - x2);
                // MessageBox.Show(theta.ToString());
                double dist = GetDistance(new System.Windows.Point(x1, y1), new System.Windows.Point(x2, y2)) / ratio.Ratio;
                dist = (double)dist / ratio.actualwidth * 1689.12;
                //dist= (double)dist / inkCanvas.ActualWidth * 1689.12 ;
                string label = Math.Round(dist, 2).ToString() + " μm";

                System.Windows.FontStyle fontStyle = new System.Windows.FontStyle();
                FontWeight fontWeight = new FontWeight();
                FontStretch fontStretch = new FontStretch();
                if (dimenViewModel.Italic) fontStyle = FontStyles.Italic;
                if (dimenViewModel.Bold) fontWeight = FontWeights.Bold;
                System.Windows.Point labelPosition;
                FormattedText formattedText = new FormattedText(label, CultureInfo.CurrentCulture,

                                              FlowDirection.LeftToRight, new Typeface(dimenViewModel.FontFam, fontStyle, fontWeight, fontStretch), dimenViewModel.FontSize, System.Windows.Media.Brushes.White, 1.25);
                int textHeight = (int)formattedText.Height;
                int textWidth = (int)formattedText.Width;
                if (dimenViewModel.Label)
                {
                    if ((-Math.PI / 4 < theta && theta < Math.PI / 4) || (-Math.PI < theta && theta < -3 * Math.PI / 4) || (3 * Math.PI / 4 < theta && theta < Math.PI))
                    {
                        if ((-Math.PI < theta && theta < -3 * Math.PI / 4) || (3 * Math.PI / 4 < theta && theta < Math.PI))
                        {
                            switch (dimenViewModel.LabelPos)
                            {

                                case " 上左":

                                    labelPosition = new System.Windows.Point(x1 + 5, y1 - textHeight - 10);
                                    break;
                                case " 上中":
                                    labelPosition = new System.Windows.Point((x1 + x2 - textWidth) / 2, (y1 + y2) / 2 - textHeight - 10);
                                    break;
                                case " 上右":
                                    labelPosition = new System.Windows.Point(x2 - textWidth - 5, y2 - textHeight - 10);
                                    break;

                                case " 下左":
                                    labelPosition = new System.Windows.Point(x1 + 10, y1 + 10);
                                    break;
                                case " 下中":
                                    labelPosition = new System.Windows.Point((x1 + x2 - textWidth) / 2, (y1 + y2) / 2 + 10);
                                    break;
                                case " 下右":
                                    labelPosition = new System.Windows.Point(x2 - textWidth - 5, y2 + 10);
                                    break;

                            }
                            // MessageBox.Show(formattedText.Width.ToString() + formattedText.Height.ToString());
                            drawingContext.DrawText(formattedText, labelPosition);
                        }
                        else
                        {
                            switch (dimenViewModel.LabelPos)
                            {
                                case " 上左":

                                    labelPosition = new System.Windows.Point(x2 + 5, y2 - textHeight - 10);
                                    break;
                                case " 上中":
                                    labelPosition = new System.Windows.Point((x1 + x2 - textWidth) / 2, (y1 + y2) / 2 - textHeight - 10);
                                    break;
                                case " 上右":
                                    labelPosition = new System.Windows.Point(x1 - textWidth - 5, y1 - textHeight - 10);
                                    break;

                                case " 下左":
                                    labelPosition = new System.Windows.Point(x2 + 10, y2 + 10);
                                    break;
                                case " 下中":
                                    labelPosition = new System.Windows.Point((x1 + x2 - textWidth) / 2, (y1 + y2) / 2 + 10);
                                    break;
                                case " 下右":
                                    labelPosition = new System.Windows.Point(x1 - textWidth - 5, y1 + 10);
                                    break;

                            }
                            // MessageBox.Show(formattedText.Width.ToString() + formattedText.Height.ToString());
                            drawingContext.DrawText(formattedText, labelPosition);
                        }

                    }
                    else
                    {
                        if (-3 * Math.PI / 4 < theta && theta < -Math.PI / 4)
                        {
                            switch (dimenViewModel.LabelPos)
                            {

                                case " 上左":

                                    labelPosition = new System.Windows.Point(x1 - textWidth - 5, y1 - textHeight);
                                    break;
                                case " 上中":
                                    labelPosition = new System.Windows.Point(x1 - textWidth / 2, y1 - textHeight);
                                    break;
                                case " 上右":
                                    labelPosition = new System.Windows.Point(x1 + 5, y1 - textHeight);
                                    break;

                                case " 下左":
                                    labelPosition = new System.Windows.Point(x2 - textWidth - 5, y2 + 5);
                                    break;
                                case " 下中":
                                    labelPosition = new System.Windows.Point(x2 - textWidth / 2, y2 + 5);
                                    break;
                                case " 下右":
                                    labelPosition = new System.Windows.Point(x2 + 5, y2 + 5);
                                    break;

                            }
                            // MessageBox.Show(formattedText.Width.ToString() + formattedText.Height.ToString());
                            drawingContext.DrawText(formattedText, labelPosition);
                        }
                        else
                        {
                            switch (dimenViewModel.LabelPos)
                            {

                                case " 上左":

                                    labelPosition = new System.Windows.Point(x2 - textWidth - 5, y2 - textHeight);
                                    break;
                                case " 上中":
                                    labelPosition = new System.Windows.Point(x2 - textWidth / 2, y2 - textHeight);
                                    break;
                                case " 上右":
                                    labelPosition = new System.Windows.Point(x2 + 5, y2 - textHeight);
                                    break;

                                case " 下左":
                                    labelPosition = new System.Windows.Point(x1 - textWidth - 5, y1 + 5);
                                    break;
                                case " 下中":
                                    labelPosition = new System.Windows.Point(x1 - textWidth / 2, y1 + 5);
                                    break;
                                case " 下右":
                                    labelPosition = new System.Windows.Point(x1 + 5, y1 + 5);
                                    break;

                            }
                            // MessageBox.Show(formattedText.Width.ToString() + formattedText.Height.ToString());
                            drawingContext.DrawText(formattedText, labelPosition);
                        }

                    }

                    if (dimenViewModel.UnderLine)
                    {
                        drawingContext.DrawLine(InkCanvasMethod.SetPenSolid(color1, 2,0), new System.Windows.Point(labelPosition.X, labelPosition.Y + textHeight + 2), new System.Windows.Point(labelPosition.X + textWidth, labelPosition.Y + textHeight + 2));
                    }


                }
            }
        }
        public static double GetDistance(System.Windows.Point point1, System.Windows.Point point2)
        {
            return Math.Sqrt((point1.X - point2.X) * (point1.X - point2.X) + (point1.Y - point2.Y) * (point1.Y - point2.Y));
        }


        private static int _red;
        private static int _green;
        private static int _blue;
        public static FormattedText TextInput;

        public static void LoadPixelData(System.Windows.Point point1, Image image)
        {

            try
            {
                WriteableBitmap bitmapImage = image.Source as WriteableBitmap;
                int stride = ((bitmapImage.PixelWidth * bitmapImage.Format.BitsPerPixel) + 7) / 8;
                var pixelByteArray = new byte[bitmapImage.PixelHeight * stride];
                bitmapImage.CopyPixels(pixelByteArray, stride, 0);
                double pixelHeight;
                double pixelWidth;
                pixelHeight = Math.Round(point1.Y * bitmapImage.PixelHeight / image.ActualHeight);
                pixelWidth = Math.Round(point1.X * bitmapImage.PixelWidth / image.ActualWidth);
                int colorOrder = (int)Math.Round((pixelHeight * stride + pixelWidth * 3));
                _red = (int)pixelByteArray[colorOrder + 2];
                _green = (int)pixelByteArray[colorOrder + 1];
                _blue = (int)pixelByteArray[colorOrder];
            }
            catch (Exception ex)
            {

            };


        }



        public class CustomPixel : Stroke
        {
            public CustomPixel(StylusPointCollection points, Image image) : base(points)
            {
                StylusPoints = points.Clone();
                this.image = image;

            }
            Image image;
            WriteableBitmap bitmapImage;
            protected override void DrawCore(DrawingContext drawingContext, DrawingAttributes drawingAttributes)
            {
                try
                {

                    this.bitmapImage = (WriteableBitmap)image.Source;
                    double x1 = StylusPoints[0].X;
                    double y1 = StylusPoints[0].Y;
                    string label = "X Y " + "(" + (int)x1 + "," + (int)y1 + ")";
                    string label1 = "RGB " + "(" + _red + "," + _green + "," + _blue + ")";
                    double w = bitmapImage.PixelWidth / image.ActualWidth;  // 基于像素的 裁剪
                    double h = bitmapImage.PixelHeight / image.ActualHeight;

                    int RecW = 60;
                    int RecH = 45;

                    int x = (int)(x1 * w) - RecW / 2;
                    int y = (int)(y1 * h) - RecH / 2;

                    if (x1 + 120 > image.ActualWidth)
                    {
                        x1 = x1 - 120;
                        if (y1 + 130 > image.ActualHeight)
                        {

                            y1 = y1 - 130;
                        }

                    }
                    else
                    {
                        if (y1 + 130 > image.ActualHeight)
                        {

                            y1 = y1 - 130;
                        }

                    };
                    if (x > 0 && y > 0 && (x + 60) < bitmapImage.PixelWidth && (y + 45) < bitmapImage.PixelHeight)
                    {
                        var croppedBitmap = new CroppedBitmap(bitmapImage, new Int32Rect(x, y, RecW, RecH));
                        drawingContext.DrawImage(croppedBitmap, new Rect(new System.Windows.Point(x1, y1), new System.Windows.Size(120, 90)));
                    }

                    drawingContext.DrawText(new FormattedText(label, CultureInfo.CurrentCulture,
                    FlowDirection.LeftToRight, new Typeface("Arial"), 14, System.Windows.Media.Brushes.White, 1.25), new System.Windows.Point(x1, y1 + 93));
                    drawingContext.DrawText(new FormattedText(label1, CultureInfo.CurrentCulture,
                    FlowDirection.LeftToRight, new Typeface("Arial"), 14, System.Windows.Media.Brushes.White, 1.25), new System.Windows.Point(x1, y1 + 110));

                    drawingContext.DrawLine(InkCanvasMethod.SetPenSolid1(), new System.Windows.Point(x1, y1 + 45), new System.Windows.Point(x1 + 120, y1 + 45));
                    drawingContext.DrawLine(InkCanvasMethod.SetPenSolid1(), new System.Windows.Point(x1 + 60, y1), new System.Windows.Point(x1 + 60, y1 + 90));


                }
                catch (Exception ex)
                {
                    // MessageBox.Show(ex.Message);
                };

            }
        }

        private static FormattedText WriteText(Point p1, Point p2, RatioClass ratio, Color TextColor,bool italic,bool bold,bool underline,int fontsize,FontFamily  font )
        {

            double x1 = p1.X;
            double y1 = p1.Y;
            double x2 = p2.X;
            double y2 = p2.Y;
            double theta = Math.Atan2(y1 - y2, x1 - x2);
            // MessageBox.Show(theta.ToString());
            double dist = GetDistance(new System.Windows.Point(x1, y1), new System.Windows.Point(x2, y2)) / ratio.Ratio;
            dist = (double)dist / ratio.actualwidth * 1689.12;
            //dist= (double)dist / inkCanvas.ActualWidth * 1689.12 ;
            string label = Math.Round(dist, 2).ToString() + " μm";

            System.Windows.FontStyle fontStyle = new System.Windows.FontStyle();
            FontWeight fontWeight = new FontWeight();
            FontStretch fontStretch = new FontStretch();
            if (italic) fontStyle = FontStyles.Italic;
            if (bold) fontWeight = FontWeights.Bold;
            System.Windows.Point labelPosition;
            Brush textBrush = new SolidColorBrush(TextColor);
            FormattedText formattedText = new FormattedText(label, CultureInfo.CurrentCulture,

                                          FlowDirection.LeftToRight, new Typeface(font, fontStyle, fontWeight, fontStretch), fontsize, textBrush, 1.25);

            return formattedText;
        }









        public static void DrawText(DrawingContext drawingContext, FormattedText  formattedText , Point p1, Point p2, RatioClass ratio, Color TextColor, bool showLabel,bool underline,string labpos)

        {
            double x1 = p1.X;
            double y1 = p1.Y;
            double x2 = p2.X;
            double y2 = p2.Y;
            double theta = Math.Atan2(y1 - y2, x1 - x2);
            // MessageBox.Show(theta.ToString());
            double dist = GetDistance(new System.Windows.Point(x1, y1), new System.Windows.Point(x2, y2)) / ratio.Ratio;
            dist = (double)dist / ratio.actualwidth * 1689.12;
            //dist= (double)dist / inkCanvas.ActualWidth * 1689.12 ;
            string label = Math.Round(dist, 2).ToString() + " μm";

            //System.Windows.FontStyle fontStyle = new System.Windows.FontStyle();
            //FontWeight fontWeight = new FontWeight();
            //FontStretch fontStretch = new FontStretch();
            //if (dimenViewModel.Italic) fontStyle = FontStyles.Italic;
            //if (dimenViewModel.Bold) fontWeight = FontWeights.Bold;
          
            //Brush textBrush = new SolidColorBrush(TextColor);
            //FormattedText formattedText = new FormattedText(label, CultureInfo.CurrentCulture,

            //                              FlowDirection.LeftToRight, new Typeface(dimenViewModel.FontFam, fontStyle, fontWeight, fontStretch), dimenViewModel.FontSize, textBrush, 1.25);
            System.Windows.Point labelPosition;
            int textHeight = (int)formattedText.Height;
            int textWidth = (int)formattedText.Width;
            if (showLabel)
            {
                if ((-Math.PI / 4 < theta && theta < Math.PI / 4) || (-Math.PI <= theta && theta < -3 * Math.PI / 4) || (3 * Math.PI / 4 < theta && theta <= Math.PI))
                {
                    if ((-Math.PI <= theta && theta < -3 * Math.PI / 4) || (3 * Math.PI / 4 < theta && theta <= Math.PI))
                    {
                        switch (dimenViewModel.LabelPos)
                        {

                            case " 上左":

                                labelPosition = new System.Windows.Point(x1 + 5, y1 - textHeight - 10);
                                break;
                            case " 上中":
                                labelPosition = new System.Windows.Point((x1 + x2 - textWidth) / 2, (y1 + y2) / 2 - textHeight - 10);
                                break;
                            case " 上右":
                                labelPosition = new System.Windows.Point(x2 - textWidth - 5, y2 - textHeight - 10);
                                break;

                            case " 下左":
                                labelPosition = new System.Windows.Point(x1 + 10, y1 + 10);
                                break;
                            case " 下中":
                                labelPosition = new System.Windows.Point((x1 + x2 - textWidth) / 2, (y1 + y2) / 2 + 10);
                                break;
                            case " 下右":
                                labelPosition = new System.Windows.Point(x2 - textWidth - 5, y2 + 10);
                                break;

                        }
                        // MessageBox.Show(formattedText.Width.ToString() + formattedText.Height.ToString());
                        drawingContext.DrawText(formattedText, labelPosition);
                    }
                    else
                    {
                        switch (labpos)
                        {
                            case " 上左":

                                labelPosition = new System.Windows.Point(x2 + 5, y2 - textHeight - 10);
                                break;
                            case " 上中":
                                labelPosition = new System.Windows.Point((x1 + x2 - textWidth) / 2, (y1 + y2) / 2 - textHeight - 10);
                                break;
                            case " 上右":
                                labelPosition = new System.Windows.Point(x1 - textWidth - 5, y1 - textHeight - 10);
                                break;

                            case " 下左":
                                labelPosition = new System.Windows.Point(x2 + 10, y2 + 10);
                                break;
                            case " 下中":
                                labelPosition = new System.Windows.Point((x1 + x2 - textWidth) / 2, (y1 + y2) / 2 + 10);
                                break;
                            case " 下右":
                                labelPosition = new System.Windows.Point(x1 - textWidth - 5, y1 + 10);
                                break;

                        }
                        // MessageBox.Show(formattedText.Width.ToString() + formattedText.Height.ToString());
                        drawingContext.DrawText(formattedText, labelPosition);
                    }

                }
                else
                {
                    if (-3 * Math.PI / 4 < theta && theta < -Math.PI / 4)
                    {
                        switch (labpos)
                        {

                            case " 上左":

                                labelPosition = new System.Windows.Point(x1 - textWidth - 5, y1 - textHeight);
                                break;
                            case " 上中":
                                labelPosition = new System.Windows.Point(x1 - textWidth / 2, y1 - textHeight);
                                break;
                            case " 上右":
                                labelPosition = new System.Windows.Point(x1 + 5, y1 - textHeight);
                                break;

                            case " 下左":
                                labelPosition = new System.Windows.Point(x2 - textWidth - 5, y2 + 5);
                                break;
                            case " 下中":
                                labelPosition = new System.Windows.Point(x2 - textWidth / 2, y2 + 5);
                                break;
                            case " 下右":
                                labelPosition = new System.Windows.Point(x2 + 5, y2 + 5);
                                break;

                        }
                        // MessageBox.Show(formattedText.Width.ToString() + formattedText.Height.ToString());
                        drawingContext.DrawText(formattedText, labelPosition);
                    }
                    else
                    {
                        switch (labpos)
                        {

                            case " 上左":

                                labelPosition = new System.Windows.Point(x2 - textWidth - 5, y2 - textHeight);
                                break;
                            case " 上中":
                                labelPosition = new System.Windows.Point(x2 - textWidth / 2, y2 - textHeight);
                                break;
                            case " 上右":
                                labelPosition = new System.Windows.Point(x2 + 5, y2 - textHeight);
                                break;

                            case " 下左":
                                labelPosition = new System.Windows.Point(x1 - textWidth - 5, y1 + 5);
                                break;
                            case " 下中":
                                labelPosition = new System.Windows.Point(x1 - textWidth / 2, y1 + 5);
                                break;
                            case " 下右":
                                labelPosition = new System.Windows.Point(x1 + 5, y1 + 5);
                                break;

                        }
                        // MessageBox.Show(formattedText.Width.ToString() + formattedText.Height.ToString());
                        drawingContext.DrawText(formattedText, labelPosition);
                    }

                }

                if (underline)
                {
                    drawingContext.DrawLine(InkCanvasMethod.SetPenSolid(TextColor, 2, 0), new System.Windows.Point(labelPosition.X, labelPosition.Y + textHeight + 2), new System.Windows.Point(labelPosition.X + textWidth, labelPosition.Y + textHeight + 2));
                }
            }
        }



    }
}

