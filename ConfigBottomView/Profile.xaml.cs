using NumericUpDownLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ConfigBottomView
{
    /// <summary>
    /// Profile.xaml 的交互逻辑
    /// </summary>
    public partial class Profile : UserControl
    {
        public DoubleUpDown doubleUpDown1;
        public DoubleUpDown doubleUpDown2;
        public CheckBox Marker1Check;
        public CheckBox Marker2Check;
        public Profile()
        {
            InitializeComponent();
            drawingAttributes = new DrawingAttributes
            {
                Color = Colors.White,
                Width = 1,
                Height = 1,
                StylusTip = StylusTip.Rectangle,
                FitToCurve = false,
                IsHighlighter = true,
                IgnorePressure = true,
            };
            doubleUpDown1 = NumUpdown1;
            doubleUpDown2 = NumUpdown2;
            Marker1Check = Marker1;
            Marker2Check = Marker2;

        }

        public bool isMouseDown = false;
        private Point MoveOri;
        private void Marker1_Unchecked(object sender, RoutedEventArgs e)
        {
           // leftGrid.Visibility = Visibility.Collapsed;
        }

        private void Marker2_Unchecked(object sender, RoutedEventArgs e)
        {

        }

       

        

        private void Marker1_Checked(object sender, RoutedEventArgs e)
        {
           i = NumUpdown1.Value*(inkCanvas.ActualWidth - 20)+15;
            InkCanvas.SetLeft(leftGrid, i);
        }

        private void Marker2_Checked(object sender, RoutedEventArgs e)
        {
            j = (1 - NumUpdown2.Value) * (inkCanvas.ActualWidth - 20) - 6;
            InkCanvas.SetRight(rightGrid, j);
        }
        public double i = 15;
        private void inkCanvas_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            //if (e.Delta > 0)
            //{
            //    InkCanvas.SetLeft(leftGrid, i);
            //    i = i + 1;
            //}
            //else
            //{
            //    InkCanvas.SetLeft(leftGrid, i);
            //    i = i -1;
            //}
        }

        private void lowerValue_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
           // var c = sender as Control;
            MoveOri = e.GetPosition(inkCanvas);
            isMouseDown = true;
            leftGrid.CaptureMouse();
            //double leftBefore = InkCanvas.GetLeft(leftEllipse);
            //double topBefore = InkCanvas.GetTop(leftEllipse);
            leftEllipse.Visibility = Visibility.Visible;
            //Canvas.SetLeft(leftEllipse, MoveOri.X-4);
            Canvas.SetTop(leftEllipse, MoveOri.Y-4);


        }

        private void lowerValue_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
           
            isMouseDown = false;
            leftEllipse.Visibility = Visibility.Collapsed;
            leftGrid.ReleaseMouseCapture();
        }

        private void lowerValue_MouseMove(object sender, MouseEventArgs e)
        {
            Point point = e.GetPosition(inkCanvas);
            if (isMouseDown)
            {
                
                double Offset = point.X - MoveOri.X;
                i = i + Offset;
                if (i>14 && i< inkCanvas.ActualWidth-15)
                {
                    InkCanvas.SetLeft(leftGrid, i);
                    NumUpdown1.Value = (i - 15) / (inkCanvas.ActualWidth - 20);
                }
                else
                {
                    //leftGrid.ReleaseMouseCapture();
                }
               
                MoveOri = point;


            }
            if (leftEllipse.Visibility == Visibility.Visible)
            {
                if (point.X< inkCanvas.ActualWidth - 15&& point.X>15)
                {
                    //Canvas.SetLeft(leftEllipse, point.X-4);
                   Canvas.SetTop(leftEllipse, point.Y-4);
                }
                
            }
            
        }

        private void lowerValue_MouseLeave(object sender, MouseEventArgs e)
        {
            isMouseDown=false;
        }

        private double j = 5;
        public bool isMouseDown1 = false;
        private Point moveOri1;
        private void rightGrid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            moveOri1 = e.GetPosition(inkCanvas);
            isMouseDown1 = true;
            rightGrid.CaptureMouse();
            rightEllipse.Visibility=Visibility.Visible;
            //Canvas.SetLeft(rightEllipse, moveOri1.X-4);
            Canvas.SetTop(rightEllipse, moveOri1.Y-4);

        }

        private void rightGrid_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            isMouseDown1 = false;
            rightEllipse.Visibility = Visibility.Collapsed;
            rightGrid.ReleaseMouseCapture(); 

        }

        private void rightGrid_MouseMove(object sender, MouseEventArgs e)
        {
            Point point = e.GetPosition(inkCanvas);
            if (isMouseDown1)
            {

                double Offset =  moveOri1.X- point.X;
                j = j + Offset;
                if (j > 4 && j < inkCanvas.ActualWidth -26)
                {
                    InkCanvas.SetRight(rightGrid, j);
                    NumUpdown2.Value =1- (j -5) / (inkCanvas.ActualWidth - 30);
                }

                moveOri1 = point;


            }
            if (rightEllipse.Visibility == Visibility.Visible)
            {
                if (moveOri1.X< inkCanvas.ActualWidth-13 && moveOri1.X>15)
                {
                    //InkCanvas.SetLeft(rightEllipse, moveOri1.X-4);
                    Canvas.SetTop(rightEllipse, moveOri1.Y-4);
                }
                
            }

        }


        public DrawingAttributes drawingAttributes;
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
        List<Point> YpointsSt = new List<Point>();
        List<Point> YpointsEd = new List<Point>();
        List<Point> XPointsSt = new List<Point>();
        List<Point> XPointsEd = new List<Point>();
        private void YScale(double h, int k)
        {
            YpointsSt.Clear();
            YpointsEd.Clear();
            if (h <= 0)
                return;
            double step = h / k;
            double margin = 0;
            List<double> list = new List<double>();
            for (int i = 0; i < k + 1; i++)
            {
                double y = i * step + margin;
                list.Add(y);
            }

            for (int i = 0; i < list.Count; i++)
            {
                if (i % 5 == 0)
                {
                    YpointsSt.Add(new Point(13, list[i] + 1));
                }
                else
                {
                    YpointsSt.Add(new Point(17, list[i] + 1));
                }

            }
            for (int i = 0; i < list.Count; i++)
            {
                YpointsEd.Add(new Point(20, list[i] + 1));
            }
        }

        private void XScale(double w, double h, int m)
        {
            XPointsSt.Clear();
            XPointsEd.Clear();
            if (w <= 0)
                return;
            double step = w / m;
            double margin = 20;
            List<double> list = new List<double>();
            for (int i = 0; i < m + 1; i++)
            {
                double x = i * step + margin;
                list.Add(x);
            }

            for (int i = 0; i < list.Count; i++)
            {

                XPointsSt.Add(new Point(list[i] + 1, h + 4));
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (i % 5 == 0)
                {
                    XPointsEd.Add(new Point(list[i] + 1, h + 11));
                }
                else
                {
                    XPointsEd.Add(new Point(list[i] + 1, h + 7));
                }
            }
        }

        private void drawYAxis(double height, int k)
        {
            if (height <= 0)
                return;
            // lstEditingMode.SelectedIndex = 0;
            List<System.Windows.Point> pointList;
            StylusPointCollection point;
            Stroke stroke;
            StrokeCollection strokes = new StrokeCollection();
            YScale(height, k);

            for (int i = 0; i < k + 1; i++)
            {
                stroke = GenerateLineStroke(YpointsSt[i], YpointsEd[i]);
                inkCanvas.Strokes.Add(stroke);
            }

        }



        private void drawXAxis(double width, double height, int m)
        {
            if (height <= 0)
                return;
            List<System.Windows.Point> pointList;
            StylusPointCollection point;
            Stroke stroke;
            StrokeCollection strokes = new StrokeCollection();
            XScale(width, height, m);

            for (int i = 0; i < m + 1; i++)
            {
                stroke = GenerateLineStroke(XPointsSt[i], XPointsEd[i]);
                inkCanvas.Strokes.Add(stroke);
            }

        }

        private void profile_Loaded(object sender, RoutedEventArgs e)
        {
            drawYAxis(ProfileImage.ActualHeight, 10);
            drawXAxis(ProfileImage.ActualWidth, ProfileImage.ActualHeight, 20);
        }

        private void profile_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            inkCanvas.Strokes.Clear();
            drawYAxis(ProfileImage.ActualHeight, 10);
            drawXAxis(ProfileImage.ActualWidth, ProfileImage.ActualHeight, 20);
        }

       
    }
}
