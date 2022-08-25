using OxyPlot;
using OxyPlot.Annotations;
using OxyPlot.Axes;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Windows.Resources;

namespace ConfigBottomView.ViewModels
{
    public class HistogramViewModel : ViewModelBase
    {

        /// <summary>
        /// 画直方图
        /// </summary>
        public PlotModel _plotModel = new PlotModel();
     
        public PlotModel HistogramModel
        {
            get { return _plotModel; }
            set
            {
                if (_plotModel != value)
                {
                    _plotModel = value;
                    RaisePropertyChanged(nameof(HistogramModel));
                }
            }
        }

        /// <summary>
        /// Obtains the image data once it is loaded
        /// </summary>
        private int[] pixelData;
        List<int> histogram = new int[256].ToList();

        public LineAnnotation la;
        public LineAnnotation lb;
        public void LoadPixelData()
        {
            //var bitmapImage = new BitmapImage(new Uri("/ConfigBottomView;component/resources/startpicture1.png", UriKind.Relative));
            StreamResourceInfo sri = Application.GetResourceStream(new Uri("/ConfigBottomView;component/resources/startpicture1.png", UriKind.Relative));
            var bitmapImage = new BitmapImage();
            // MessageBox.Show("111111111");
            bitmapImage.BeginInit();
            bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
            bitmapImage.StreamSource = sri.Stream;
            bitmapImage.EndInit();

            int stride = ((bitmapImage.PixelWidth * bitmapImage.Format.BitsPerPixel) + 7) / 8;
            var pixelByteArray = new byte[bitmapImage.PixelHeight * stride];
            bitmapImage.CopyPixels(pixelByteArray, stride, 0);
            this.pixelData = new int[pixelByteArray.Length / 4];
            Buffer.BlockCopy(pixelByteArray, 0, this.pixelData, 0, pixelByteArray.Length);
            int brightness;
            int red; int green; int blue;

            for (int i = 0; i < pixelByteArray.Length; i += 4)
            {
                //Gray = 0.299R + 0.587G + 0.144B
                brightness = Math.Min((int)Math.Round(0.299f * (float)pixelByteArray[i + 2] + 0.587f * (float)pixelByteArray[i + 1] + 0.114f * (float)pixelByteArray[i]), 255);
                histogram[brightness]++;
            }



        }

        [Obsolete]
        public PlotModel Histogram(int _rgbA)
        {
            LoadPixelData();
            _plotModel.TitleToolTip = "hhhhhhh";
            //_plotModel = new PlotModel();
            double mean = 100; double std = 1; int n = 100000;

            //定义y轴
            LinearAxis leftAxis = new LinearAxis()
            {
                AxislineThickness = 1,
                Position = AxisPosition.Left,
                TicklineColor = OxyColors.White,
                TextColor = OxyColors.White,
                Minimum = 0,
                //Maximum = 255,
                // Title = "Y轴",//显示标题内容
                TitlePosition = 1,//显示标题位置
                TitleColor = OxyColor.Parse("#d3d3d3"),//显示标题位置
                IsZoomEnabled = false,//坐标轴缩放关闭
                IsPanEnabled = false,//图表缩放功能关闭

                //MajorGridlineStyle = LineStyle.Solid,//主刻度设置格网
                //MajorGridlineColor = OxyColor.Parse("#7379a0"),
                //MinorGridlineStyle = LineStyle.Dot,//子刻度设置格网样式
                //MinorGridlineColor = OxyColor.Parse("#666b8d")
            };
            //定义x轴
            LinearAxis bottomAxis = new LinearAxis()
            {
                AxislineThickness = 1,
                Position = AxisPosition.Bottom,
                Minimum = 0,
                Maximum = 255,
                TicklineColor = OxyColors.White,
                TextColor = OxyColors.White,
                //Title = "X轴",//显示标题内容
                TitlePosition = 1,//显示标题位置
                TitleColor = OxyColor.Parse("#FFB5AFAF"),//显示标题位置
                IsZoomEnabled = false,//坐标轴缩放关闭
                IsPanEnabled = false,//图表缩放功能关闭
                //MajorGridlineStyle = LineStyle.Solid,//主刻度设置格网
                //MajorGridlineColor = OxyColor.Parse("#7379a0"),
                //MinorGridlineStyle = LineStyle.Dot,//子刻度设置格网样式
                //MinorGridlineColor = OxyColor.Parse("#666b8d")
            };

            la = new LineAnnotation { Type = LineAnnotationType.Vertical, X = 4, Text = "4", TextOrientation = AnnotationTextOrientation.Horizontal, TextColor = OxyColors.White };
            la.MouseDown += (s, e) =>
            {
                if (e.ChangedButton != OxyMouseButton.Left)
                {
                    return;
                }

                // la.StrokeThickness *= 2;
                _plotModel.InvalidatePlot(false);
                e.Handled = true;
            };

            // Handle mouse movements (note: this is only called when the mousedown event was handled)
            la.MouseMove += (s, e) =>
            {
                la.X = la.InverseTransform(e.Position).X;
                la.TextOrientation = AnnotationTextOrientation.Horizontal;
                la.Text = Math.Round(la.X).ToString();
                la.TextColor = OxyColors.White;
                
                _plotModel.InvalidatePlot(false);
                e.Handled = true;
            };
            la.MouseUp += (s, e) =>
            {
                //la.StrokeThickness /= 2;
                _plotModel.InvalidatePlot(false);
                e.Handled = true;
            };
            lb = new LineAnnotation { Type = LineAnnotationType.Vertical, X = 240, Text = "240", Color = OxyColors.Green, TextOrientation = AnnotationTextOrientation.Horizontal, TextColor = OxyColors.White };
            lb.MouseDown += (s, e1) =>
            {
                if (e1.ChangedButton != OxyMouseButton.Left)
                {
                    return;
                }

                //lb.StrokeThickness *= 2;
                _plotModel.InvalidatePlot(false);
                e1.Handled = true;
            };

            // Handle mouse movements (note: this is only called when the mousedown event was handled)
            lb.MouseMove += (s, e1) =>
            {
                lb.X = lb.InverseTransform(e1.Position).X;
                lb.TextOrientation = AnnotationTextOrientation.Horizontal;
                lb.Text = Math.Round(lb.X).ToString();
                lb.TextColor = OxyColors.White;
                _plotModel.InvalidatePlot(false);

                e1.Handled = true;


            };
            lb.MouseUp += (s, e1) =>
            {
                // lb.StrokeThickness /= 2;
                _plotModel.InvalidatePlot(false);
                e1.Handled = true;
            };

            //_plotModel.Annotations.Add(lb);
            //_plotModel.Annotations.Add(la);       
            _plotModel.Axes.Add(leftAxis);
            _plotModel.Axes.Add(bottomAxis);
            _plotModel.PlotAreaBorderColor = OxyColors.White;
            _plotModel.PlotMargins = new OxyThickness(30, -4, 0, 20);



            HistogramSeries chs = new HistogramSeries();

            List<HistogramItem> list = new List<HistogramItem>();

            if (_rgbA == 0)
            {
                for (int i = 0; i < 256; i++)
                {

                    int m = histogram[i];
                    HistogramItem item = new HistogramItem(i, i + 1, m, 10);
                    list.Add(item);
                }
                chs.FillColor = OxyColors.White;
                //chs.TextColor = OxyColors.Red;  
                chs.Items.AddRange(list);
                _plotModel.Series.Add(chs);
            }


            return _plotModel;
        }






    }

}
