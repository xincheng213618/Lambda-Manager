using OxyPlot;
using OxyPlot.Annotations;
using OxyPlot.Axes;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ConfigBottomView
{
    /// <summary>
    /// ProfileChart.xaml 的交互逻辑
    /// </summary>
    public partial class ProfileChart : UserControl
    {
        public ProfileChart()
        {
            InitializeComponent();
            plotModel = CreaterAreaSeries();
            this.Model = plotModel;
            plotView.DataContext = this;
            WrapPanel1 = wrapPanel;
           
           
         // randomList(1000);
        }
        public WrapPanel WrapPanel1;
        PlotModel plotModel = new PlotModel();
        private double ratio1 = 0.3;
        private double ratio2 = 0.7;
        private bool isMosedown = false;
        public LineAnnotation la = new LineAnnotation()
        {
            Type = LineAnnotationType.Vertical,
            Color = OxyColors.Blue,
            Text = "",
            TextOrientation = AnnotationTextOrientation.Horizontal,
            StrokeThickness = 2,
            TextColor = OxyColors.White,
            TextMargin = 6,

        };
        public LineAnnotation lb = new LineAnnotation()
        {
            Type = LineAnnotationType.Vertical,
            Color = OxyColors.Green,
            Text = "",
            TextOrientation = AnnotationTextOrientation.Horizontal,
            StrokeThickness = 2,
            TextColor = OxyColors.White,
            TextLinePosition = 1,
            TextMargin = 6,
            

        };

        public LinearAxis linearAxisY = new LinearAxis()
        {

            Position = AxisPosition.Left,
            //Title = "Frequency",
            TicklineColor = OxyColors.White,
            AxislineColor = OxyColors.White,
            TitleColor = OxyColors.White,
            TextColor = OxyColors.White,
            MajorGridlineStyle = LineStyle.Solid,//主刻度设置格网
            MajorGridlineColor = OxyColors.Gray,
            MinorGridlineStyle = LineStyle.Dot,//子刻度设置格网样式
            MinorGridlineColor = OxyColors.Gray,
            IntervalLength = 50
        // MajorGridlineColor = OxyColor.Parse("#7379a0"),

        // MinorGridlineColor = OxyColor.Parse("#666b8d"),
        //AbsoluteMinimum = 0,
        //AbsoluteMaximum = 0.005
    };
        public LinearAxis linearAxisX = new LinearAxis()
        {
            Position = AxisPosition.Bottom,
            // Title = "x",
            TicklineColor = OxyColors.White,
            AxislineColor = OxyColors.White,
            TitleColor = OxyColors.White,
            TextColor = OxyColors.White,
            MajorGridlineStyle = LineStyle.Solid,//主刻度设置格网
           // MajorGridlineColor = OxyColor.Parse("#7379a0"),
            MinorGridlineStyle = LineStyle.Dot,//子刻度设置格网样式
            MajorGridlineColor = OxyColors.Gray,
            MinorGridlineColor = OxyColors.Gray,
            MinimumMajorStep = 1,
            AxisTickToLabelDistance=-3,
            IntervalLength = 50
            // MinorGridlineColor = OxyColor.Parse("#666b8d"),
            //AbsoluteMinimum = 0,
            //AbsoluteMaximum = 400
        };

       
        public AreaSeries lineSeries2 = new AreaSeries
        {

            //Color = OxyColors.White,
            //Fill = OxyColors.White,
            Color = OxyColor.Parse("#888888"),
            Fill = OxyColor.Parse("#888888"),
            InterpolationAlgorithm = InterpolationAlgorithms.CanonicalSpline,
            MarkerType = MarkerType.None
            
           
        };

        public PlotModel Model
        {
            get { return plotModel; }
            set { plotModel = value; }
        }
        public List<DataPoint> DataPoints = new List<DataPoint>() {  };
        //private void randomList(int mount)
        //{
        //    DataPoints.Clear();
        //    Random random = new Random();
        //    List<Point> daPoints = new List<Point>();
        //    for (int i = 0; i < mount; i++)
        //    {
        //        DataPoints.Add(new DataPoint(i, random.NextDouble()));
        //        daPoints.Add(new Point(i, random.NextDouble()));
        //    }

        //    daPoints.OrderBy(p => p.Y);

        //    linearAxisY.AbsoluteMaximum = 1.5;
        //    linearAxisY.AbsoluteMinimum = 0;
        //    linearAxisX.AbsoluteMaximum = DataPoints.Count;
        //    linearAxisX.AbsoluteMinimum = 0;
        //    linearAxisY.Maximum = 1.5;
        //    linearAxisY.Minimum = 0;
        //    linearAxisX.Maximum = DataPoints.Count + 1;
        //    linearAxisX.Minimum = 0;
        //    la.X = DataPoints.Count * ratio1;
        //    lb.X = DataPoints.Count * ratio2;
        //    Marker1Y.Text = DataPoints[(int)(la.X)].Y.ToString("f4");
        //    Marker2Y.Text = DataPoints[(int)(lb.X)].Y.ToString("f4");
        //    deltaX.Text = (lb.X - la.X).ToString("f0");
        //    deltaY.Text = (DataPoints[(int)lb.X].Y - DataPoints[(int)la.X].Y).ToString("f4");
        //    plotModel.ResetAllAxes();
        //    plotModel.InvalidatePlot(true);
        //    //double x = linearAxisX.StartPosition;
        //    //MessageBox.Show(x.ToString());

        //}

        //private void randomList1(int mount)
        //{
        //    DataPoints.Clear();
        //    Random random = new Random();
        //    List<Point> daPoints = new List<Point>();
        //    for (int i = 0; i < mount; i++)
        //    {
        //        DataPoints.Add(new DataPoint(i, random.NextDouble()));
        //        daPoints.Add(new Point(i, random.NextDouble()));
        //    }

        //    daPoints.OrderBy(p => p.Y);

        //    linearAxisY.AbsoluteMaximum = 1.5;
        //    linearAxisY.AbsoluteMinimum = 0;
        //    linearAxisX.AbsoluteMaximum = DataPoints.Count;
        //    linearAxisX.AbsoluteMinimum = 0;
        //    linearAxisY.Maximum = 1.5;
        //    linearAxisY.Minimum = 0;
        //    linearAxisX.Maximum = DataPoints.Count + 1;
        //    linearAxisX.Minimum = 0;
        //    la.X = DataPoints.Count * ratio1;
        //    lb.X = DataPoints.Count * ratio2;
        //    Marker1Y.Text = DataPoints[(int)(la.X)].Y.ToString("f4");
        //    Marker2Y.Text = DataPoints[(int)(lb.X)].Y.ToString("f4");
        //    deltaX.Text = (lb.X - la.X).ToString("f0");
        //    deltaY.Text = (DataPoints[(int)lb.X].Y - DataPoints[(int)la.X].Y).ToString("f4");
        //   // plotModel.ResetAllAxes();
        //    plotModel.InvalidatePlot(true);
        //    //double x = linearAxisX.StartPosition;
        //    //MessageBox.Show(x.ToString());

        //}






        public void ReadPointsArry(double[] array)
        {
            DataPoints.Clear();
            for (int i = 0; i < array.Length-1; i++)
            {
                DataPoints.Add(new DataPoint(i, array[i]));
            }
            Array.Sort(array);
            double min = array[0];
            double max = array[array.Length - 1];
            linearAxisX.AbsoluteMaximum = DataPoints.Count+1;
            linearAxisX.Maximum = DataPoints.Count;
            linearAxisX.AbsoluteMinimum = -1;
            linearAxisY.AbsoluteMaximum = max*1.2;
            linearAxisY.AbsoluteMinimum = min;
            linearAxisY.Maximum = max * 1.2;
            la.X = DataPoints.Count * ratio1;
            lb.X = DataPoints.Count * ratio2;
            Marker1Y.Text = DataPoints[(int)(la.X)].Y.ToString("f4");
            Marker2Y.Text = DataPoints[(int)(lb.X)].Y.ToString("f4");
            deltaX.Text = (lb.X - la.X).ToString("f0");
            deltaY.Text = (DataPoints[(int)lb.X].Y - DataPoints[(int)la.X].Y).ToString("f4");
            lineSeries2.ConstantY2 = min;
            plotModel.InvalidatePlot(true);
            plotModel.ResetAllAxes();


        }
        public void RefreshPointsArry(double[] array)
        {
            DataPoints.Clear();
            for (int i = 0; i < array.Length - 1; i++)
            {
                DataPoints.Add(new DataPoint(i, array[i]));
            }
            //Array.Sort(array);
            //double min = array[0];
            //double max = array[array.Length - 1];
            //linearAxisX.AbsoluteMaximum = DataPoints.Count + 1;
            //linearAxisX.Maximum = DataPoints.Count;
            //linearAxisX.AbsoluteMinimum = -1;
            //linearAxisY.AbsoluteMaximum = max * 1.2;
            //linearAxisY.Maximum = max*1.2;
            //linearAxisY.AbsoluteMinimum = min;
           // lineSeries2.ConstantY2 = min;
            la.X = DataPoints.Count * ratio1;
            lb.X = DataPoints.Count * ratio2;
            Marker1Y.Text = DataPoints[(int)(la.X)].Y.ToString("f4");
            Marker2Y.Text = DataPoints[(int)(lb.X)].Y.ToString("f4");
            deltaX.Text = (lb.X - la.X).ToString("f0");
            deltaY.Text = (DataPoints[(int)lb.X].Y - DataPoints[(int)la.X].Y).ToString("f4");
           
            plotModel.InvalidatePlot(true);


        }







        private LineAnnotation AddLineAnnotation(LineAnnotation lineAnnotation, PlotModel model)
        {
#pragma warning disable CS0618 // 类型或成员已过时
            lineAnnotation.MouseDown += (s, e) =>
            {
                if (e.ChangedButton != OxyMouseButton.Left)
                {
                    return;
                }
                model.InvalidatePlot(false);
                Canvas.SetLeft(ellipse, (e.Position).X - 4);
                Canvas.SetTop(ellipse, (e.Position).Y - 4);
                ellipse.Visibility = Visibility.Visible;
                e.Handled = true;

            };
#pragma warning disable CS0618 // 类型或成员已过时
            lineAnnotation.MouseMove += (s, e) =>
            {
                try
                {
                   
                    this.plotView.Cursor = Cursors.SizeWE;
                    if (e.Position.X <= 46 )
                    {
                        lineAnnotation.X = lineAnnotation.InverseTransform(new ScreenPoint(46,0)).X;
                        return;
                    };
                    if(e.Position.X >= plotView.ActualWidth - 22)
                    {
                        
                        lineAnnotation.X = lineAnnotation.InverseTransform(new ScreenPoint(plotView.ActualWidth - 22, 0)).X;
                        return;
                    }


                    lineAnnotation.X = lineAnnotation.InverseTransform(e.Position).X;
                   // this.plotView.Cursor = Cursors.SizeWE;
                    lineAnnotation.Text = DataPoints[(int)lineAnnotation.X].Y.ToString("f2");
                    if (lineAnnotation == la)
                    {
                        Marker1Y.Text = DataPoints[(int)lineAnnotation.X].Y.ToString("f4");
                        ratio1 = lineAnnotation.InverseTransform(e.Position).X / DataPoints.Count;
                    }
                    else if (lineAnnotation == lb)
                    {
                        Marker2Y.Text = DataPoints[(int)lineAnnotation.X].Y.ToString("f4");
                        ratio2 = lineAnnotation.InverseTransform(e.Position).X / DataPoints.Count;
                    }
                    deltaX.Text = (lb.X - la.X).ToString("f0");
                    deltaY.Text = (DataPoints[(int)lb.X].Y - DataPoints[(int)la.X].Y).ToString("f4");
                    model.InvalidatePlot(false);
                    Canvas.SetLeft(ellipse, (e.Position).X - 4);
                    Canvas.SetTop(ellipse, (e.Position).Y - 4);
                   
                }
                catch
                {

                }
              
                e.Handled = true;
            };
#pragma warning disable CS0618 // 类型或成员已过时
            lineAnnotation.MouseUp += (s, e) =>
            {

                ellipse.Visibility = Visibility.Collapsed;
                model.InvalidatePlot(false);
                Canvas.SetLeft(ellipse, (e.Position).X - 4);
                Canvas.SetTop(ellipse, (e.Position).Y - 4);
                e.Handled = true;

            };

            return lineAnnotation;


        }

        private void Marker1_Checked(object sender, RoutedEventArgs e)
        {
           
            la.X = DataPoints.Count * ratio1;
            plotModel.Annotations.Add(la);
            plotModel.InvalidatePlot(true);
            //MessageBox.Show(this.ActualHeight.ToString());
        }

        private void Marker1_Unchecked(object sender, RoutedEventArgs e)
        {
            plotModel.Annotations.Remove(la);
            plotModel.InvalidatePlot(true);
        }

        private void Marker2_Checked(object sender, RoutedEventArgs e)
        {
                lb.X = DataPoints.Count * ratio2;
            plotModel.Annotations.Add(lb);
            plotModel.InvalidatePlot(true);
        }

        private void Marker2_Unchecked(object sender, RoutedEventArgs e)
        {
            plotModel.Annotations.Remove(lb);
            plotModel.InvalidatePlot(true);
        }

        public  PlotModel CreaterAreaSeries()
        {
            var model = new PlotModel {  PlotAreaBorderColor = OxyColors.White , PlotMargins = new OxyThickness(40, -7, 20, 10) };       
            lineSeries2.ItemsSource = DataPoints;
            model.Series.Add(lineSeries2);

            model.Axes.Add(linearAxisY);
           
            model.Axes.Add(linearAxisX);
            
            AddLineAnnotation(la, model);
            AddLineAnnotation(lb, model);
#pragma warning disable CS0618 // 类型或成员已过时
            model.MouseMove += (s, e) =>
                {
                   
                    if (model.Annotations.Contains(la)|| model.Annotations.Contains(lb))
                    { 
                        if(model.Annotations.Contains(la)&& !model.Annotations.Contains(lb))
                        {
                            double xa = la.Transform(la.X, la.Y).X;

                            if (Math.Abs(xa - e.Position.X) < 5)
                            {
                                this.plotView.Cursor = Cursors.SizeWE;
                            }
                            else
                            {
                                if (isMosedown)
                                {
                                    this.plotView.Cursor = Cursors.Hand; 
                                }
                                else
                                {
                                    this.plotView.Cursor = Cursors.Arrow;
                                }
                               
                               
                            }
                        }
                        else if (model.Annotations.Contains(lb) && !model.Annotations.Contains(la))
                        {
                            double xb = lb.Transform(lb.X, lb.Y).X;
                            if (Math.Abs(xb - e.Position.X) < 5)
                            {
                                this.plotView.Cursor = Cursors.SizeWE;
                            }
                            else
                            {
                                if (isMosedown)
                                {
                                    this.plotView.Cursor = Cursors.Hand;
                                }
                                else
                                {
                                    this.plotView.Cursor = Cursors.Arrow;
                                }

                            }
                        }
                        else
                        {
                            double xa = la.Transform(la.X, la.Y).X;
                            double xb = lb.Transform(lb.X, lb.Y).X;
                            if (Math.Abs(xa - e.Position.X) < 5 || Math.Abs(xb - e.Position.X) < 5)
                            {
                                this.plotView.Cursor = Cursors.SizeWE;
                            }
                            else
                            {
                                if (isMosedown)
                                {
                                    this.plotView.Cursor = Cursors.Hand;
                                }
                                else
                                {
                                    this.plotView.Cursor = Cursors.Arrow;
                                }

                            }

                        }

                    }
                    else
                    {
                        if (isMosedown)
                        {
                            this.plotView.Cursor = Cursors.Hand;
                        }
                        else
                        {
                            this.plotView.Cursor = Cursors.Arrow;
                        }

                    }

                };

            var myController = new PlotController();
            myController.UnbindMouseDown(OxyMouseButton.Right);
            myController.BindMouseDown(OxyMouseButton.Left, PlotCommands.PanAt);
            plotView.Controller = myController;

            return model;
        }






        
       

        public class MarkerShow: ViewModelBase
        {
            private bool marker1Show = false;
            public bool Marker1Show
            {
                get { return marker1Show; }
                set { marker1Show = value; NotifyPropertyChanged(); }
            }

            private bool marker2Show = false;
            public bool Marker2Show
            {
                get { return marker2Show; }
                set { marker2Show = value; NotifyPropertyChanged(); }
            }

        }





        public abstract class ViewModelBase : INotifyPropertyChanged
        {
            public event PropertyChangedEventHandler? PropertyChanged;

            /// <summary>
            /// 触发消息通知事件
            /// </summary>
            /// <param name="propertyName"></param>
            public void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void plotView_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
           
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Random random = new Random();
            //x = random.Next(500, 2000);
            //randomList(x);
        }

       

        private void plotView_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            isMosedown = true;
        }

        private void plotView_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            isMosedown = false;
        }
    }







}

