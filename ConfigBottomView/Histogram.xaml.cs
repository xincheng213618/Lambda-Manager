using Lambda;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Ink;


namespace ConfigBottomView
{
    /// <summary>
    /// Histogram.xaml 的交互逻辑
    /// </summary>
    public partial class Histogram : UserControl
    {
        public Histogram()
        {
            InitializeComponent();
            drawingAttributes = new DrawingAttributes
            {
                Color = Colors.Black,
                Width = 2,
                Height = 2,
                StylusTip = StylusTip.Rectangle,
                FitToCurve = false,
                IsHighlighter = true,
                IgnorePressure = true,
            };
           // MessageBox.Show("1111");
        }

        private void UserControl_Initialized(object sender, EventArgs e)
        {
            LambdaControl.RegisterImageView(HistogramImage).ToString();
        }
        private int RGBMode(bool m, bool n, bool k)
        {
            int R, G, B;
            if (m)
            {
                R = 4;
            }
            else
            {
                R = 0;
            };
            if (n)
            {
                G = 2;
            }
            else
            {
                G = 0;
            }
            if (k)
            {
                B = 1;

            }
            else
            {
                B = 0;
            }


            return R + G + B;

        }
        bool auto = false; bool log = false;


        private void RGBGrid_Checked(object sender, RoutedEventArgs e)
        {
            int mode = RGBMode((bool)R.IsChecked, (bool)G.IsChecked, (bool)B.IsChecked);
            LambdaControl.Trigger("HISTOGRAM_MODE", this, new Dictionary<string, object> { { "mode", mode } });
            // MessageBox.Show(mode.ToString());
        }

        private void RGBGrid_UnChecked(object sender, RoutedEventArgs e)
        {
            int mode = RGBMode((bool)R.IsChecked, (bool)G.IsChecked, (bool)B.IsChecked);
            LambdaControl.Trigger("HISTOGRAM_MODE", this, new Dictionary<string, object> { { "mode", mode } });
            // MessageBox.Show(mode.ToString());
        }

        private void Auto_Click(object sender, RoutedEventArgs e)
        {
            if (!auto)
            {
                LambdaControl.Trigger("HISTOGRAM_AUTOMODE", this, new Dictionary<string, object> { { "autoMode", true } });
                auto = true;
                RangeSlider.SlidThumbVis = Visibility.Hidden;
            }
            else
            {
                LambdaControl.Trigger("HISTOGRAM_AUTOMODE", this, new Dictionary<string, object> { { "autoMode", false } });
                auto = false;
                RangeSlider.SlidThumbVis = Visibility.Visible;
            }


        }

        private void Log_Click(object sender, RoutedEventArgs e)

        {
            if (!log)
            {
                LambdaControl.Trigger("HISTOGRAM_LOGMODE", this, new Dictionary<string, object> { { "logMode", true } });
                log = true;
            }
            else
            {
                LambdaControl.Trigger("HISTOGRAM_LOGMODE", this, new Dictionary<string, object> { { "logMode", false } });
                log = false;
            }

        }

        private void RangeSlider_LowerValueChanged(object sender, RoutedEventArgs e)
        {
            if (!auto)
            {
                int min = (int)RangeSlider.LowerValue;
                int max = (int)RangeSlider.HigherValue;
                LambdaControl.Trigger("BRIGHTNESS_RANGE", this, new Dictionary<string, object>() { { "Min", min }, { "Max", max } });

            }
        }

        private void RangeSlider_HigherValueChanged(object sender, RoutedEventArgs e)
        {
            if (!auto)
            {
                int min = (int)RangeSlider.LowerValue;
                int max = (int)RangeSlider.HigherValue;
                LambdaControl.Trigger("BRIGHTNESS_RANGE", this, new Dictionary<string, object>() { { "Min", min }, { "Max", max } });

            }


        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void DoubleUpDown_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double gamma = double.Parse(NumUpdown.Value.ToString("0.00"));
            LambdaControl.Trigger("HISTOGRAM_GAMMA", this, new Dictionary<string, object>() { { "Gamma", gamma }});
           // MessageBox.Show(gamma.ToString());

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
                    YpointsSt.Add(new Point(10, list[i] + 1));
                }
                else
                {
                    YpointsSt.Add(new Point(15, list[i] + 1));
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

                XPointsSt.Add(new Point(list[i] + 1, h + 5));
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (i % 5 == 0)
                {
                    XPointsEd.Add(new Point(list[i] + 1, h + 15));
                }
                else
                {
                    XPointsEd.Add(new Point(list[i] + 1, h + 10));
                }
            }
        }

        private void drawYAxis(double height, int k)
        {
            if (height <=0)
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

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            drawYAxis(HistogramImage.ActualHeight, 10);
            drawXAxis(HistogramImage.ActualWidth, HistogramImage.ActualHeight, 20);
        }

        private void HistogramImage_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            inkCanvas.Strokes.Clear();   
            drawYAxis(HistogramImage.ActualHeight, 10);
            drawXAxis(HistogramImage.ActualWidth, HistogramImage.ActualHeight, 20);
        }
    }
}
