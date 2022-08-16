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
        private PlotModel _plotModel = new PlotModel();
        private PlotModel temp;
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
        public PlotModel Temp
        {
            get { return temp; }
            set
            {
                if (temp != value)
                {
                    temp = value;
                    RaisePropertyChanged(nameof(Temp));
                }
            }
        }


        /// <summary>
        /// Obtains the image data once it is loaded
        /// </summary>
        private int[] pixelData;
        List<int> histogram = new int[256].ToList();
        List<int> histogramRed = new int[256].ToList();
        List<int> histogramGreen = new int[256].ToList();
        List<int> histogramBlue = new int[256].ToList();
        public void LoadPixelData()
        {
            //var bitmapImage = new BitmapImage(new Uri("/ConfigBottomView;component/resources/startpicture1.png", UriKind.Relative));
            StreamResourceInfo sri = Application.GetResourceStream(new Uri("/ConfigBottomView;component/resources/startpicture1.png", UriKind.Relative));
            var bitmapImage =new BitmapImage();
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
            for (int i = 0; i < pixelByteArray.Length; i += 4)
            {

                red = (int)pixelByteArray[i + 2];
                histogramRed[red]++;
            }
            for (int i = 0; i < pixelByteArray.Length; i += 4)
            {

                green = (int)pixelByteArray[i + 1];
                histogramGreen[green]++;
            }
            for (int i = 0; i < pixelByteArray.Length; i += 4)
            {

                blue = (int)pixelByteArray[i];
                histogramBlue[blue]++;
            }


        }

        [Obsolete]
        public HistogramViewModel(int _rgbA)
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
                TextColor= OxyColors.White,
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
            var la = new LineAnnotation { Type = LineAnnotationType.Vertical, X = 4, Text ="4" ,TextOrientation= AnnotationTextOrientation.Horizontal ,TextColor = OxyColors.White};
            la.MouseDown += (s, e) =>
            {
                if (e.ChangedButton != OxyMouseButton.Left)
                {
                    return;
                }

                la.StrokeThickness *= 2;
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
                la.StrokeThickness /= 2;
                _plotModel.InvalidatePlot(false);
                e.Handled = true;
            };
            var lb = new LineAnnotation { Type = LineAnnotationType.Vertical, X = 240,Text = "240",Color = OxyColors.Red, TextOrientation = AnnotationTextOrientation.Horizontal, TextColor = OxyColors.White };
            lb.MouseDown += (s, e1) =>
            {
                if (e1.ChangedButton != OxyMouseButton.Left)
                {
                    return;
                }

                lb.StrokeThickness *= 2;
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
                lb.StrokeThickness /= 2;
                _plotModel.InvalidatePlot(false);
                e1.Handled = true;
            };

            _plotModel.Annotations.Add(lb);
            _plotModel.Annotations.Add(la);       
            _plotModel.Axes.Add(leftAxis);
            _plotModel.Axes.Add(bottomAxis);
            _plotModel.PlotAreaBorderColor = OxyColors.White;
            _plotModel.PlotMargins= new OxyThickness(30,-4,0,20);
           


              HistogramSeries chs = new HistogramSeries();
            HistogramSeries chsR = new HistogramSeries();
            HistogramSeries chsG = new HistogramSeries();
            HistogramSeries chsB = new HistogramSeries();
            List<HistogramItem> list = new List<HistogramItem>();
            List<HistogramItem> listR = new List<HistogramItem>();
            List<HistogramItem> listG = new List<HistogramItem>();
            List<HistogramItem> listB = new List<HistogramItem>();
            if (_rgbA == 0)
            {
                for (int i = 0; i < 256; i++)
                {

                    int m = histogram[i];
                    HistogramItem item = new HistogramItem(i, i + 1, m, 10);
                    list.Add(item);
                }
                chs.FillColor = OxyColor.Parse("#6EA646");
                //chs.TextColor = OxyColors.Red;  
                chs.Items.AddRange(list);
               _plotModel.Series.Add(chs);
            }

            //if (_rgbA == 1)
            //{
            //    for (int i = 0; i < 256; i++)
            //    {

            //        int m = histogramRed[i];
            //        HistogramItem item = new HistogramItem(i, i + 1, m, 10);
            //        listR.Add(item);
            //    }
            //    chsR.FillColor = OxyColors.Red;
            //    chsR.Items.AddRange(listR);

            //    _plotModel.Series.Add(chsR);
            //}

            //if (_rgbA == 2)
            //{
            //    for (int i = 0; i < 256; i++)
            //    {

            //        int m = histogramGreen[i];
            //        HistogramItem item = new HistogramItem(i, i + 1, m, 10);
            //        listG.Add(item);
            //    }
            //    chsG.FillColor = OxyColors.Green;
            //    chsG.Items.AddRange(listG);
            //    _plotModel.Series.Add(chsG);

            //}
            //if (_rgbA == 3)
            //{
            //    for (int i = 0; i < 256; i++)
            //    {

            //        int m = histogramBlue[i];
            //        HistogramItem item = new HistogramItem(i, i + 1, m, 10);
            //        listB.Add(item);
            //    }
            //    chsB.FillColor = OxyColors.Blue;
            //    chsB.Items.AddRange(listB);
            //    _plotModel.Series.Add(chsB);

            //}




            // chs.Items.AddRange(new[] { new HistogramItem(0, 1, 255, 7), new HistogramItem(1, 2, 2500, 7) , new HistogramItem(10, 15, 1000, 7), new HistogramItem(15, 20, 2500, 7) , new HistogramItem(20, 25, 1000, 7), new HistogramItem(25, 30, 2500, 7) });
            //chs.LabelFormatString = "{0:0.00}";
            //chs.LabelPlacement = LabelPlacement.Middle;

        }



        private static IEnumerable<double> SampleNormal(Random rnd, double mean, double std, int count)
        {
            for (int i = 0; i < count; i++)
            {
                yield return SampleNormal(rnd, mean, std);
            }
        }

        private static double SampleNormal(Random rnd, double mean, double std)
        {

            var u1 = 1.0 - rnd.NextDouble();
            var u2 = rnd.NextDouble();
            return Math.Sqrt(2 * Math.Log(u1)) * Math.Cos(2 * Math.PI * u2) * std + mean;
        }


        public class HistogramBin
        {
            public string Label { get; set; }
            public double Value { get; set; }
        }
        public PlotModel CreateHistogram(int n, int binCount)
        {
            var bins = new HistogramBin[binCount];
            for (int i = 0; i < bins.Length; i++)
            {
                bins[i] = new HistogramBin { Label = i.ToString() };
            }

            var r = new Random(31);
            for (int i = 0; i < n; i++)
            {
                int value = r.Next(binCount);
                bins[value].Value++;
            }

            temp = new PlotModel { Title = string.Format("Histogram (bins={0}, n={1})", binCount, n), Subtitle = "Pseudorandom numbers" };
            var series1 = new BarSeries { ItemsSource = bins, ValueField = "Value" };
            if (binCount < 100)
            {
                series1.LabelFormatString = "{0}";
            }

            temp.Series.Add(series1);

            temp.Axes.Add(new CategoryAxis { Position = AxisPosition.Left, ItemsSource = bins, LabelField = "Label", GapWidth = 0 });
            temp.Axes.Add(new LinearAxis { Position = AxisPosition.Bottom, MinimumPadding = 0, MaximumPadding = 0.1, AbsoluteMinimum = 0 });

            return temp;



        }
        // HistogramStandardNormalDistribution


        public PlotModel CreateNormalDistributionHistogram(int n, int binCount)
        {
            var bins = new HistogramBin[binCount];
            double min = -10;
            double max = 10;
            for (int i = 0; i < bins.Length; i++)
            {
                var v = min + (max - min) * i / (bins.Length - 1);
                bins[i] = new HistogramBin { Label = v.ToString("0.0") };
            }

            var r = new Random(31);
            for (int i = 0; i < n; i++)
            {
                // http://en.wikipedia.org/wiki/Box%E2%80%93Muller_transform
                var u1 = r.NextDouble();
                var u2 = r.NextDouble();
                var v = Math.Sqrt(-2 * Math.Log(u1)) * Math.Cos(2 * Math.PI * u2);

                int bin = (int)Math.Round((v - min) / (max - min) * (bins.Length - 1));
                if (bin >= 0 && bin < bins.Length)
                {
                    bins[bin].Value++;
                }
            }

            temp = new PlotModel { Title = string.Format("Histogram (bins={0}, n={1})", binCount, n), Subtitle = "Standard normal distribution by Box-Muller transform" };
            var series1 = new BarSeries { ItemsSource = bins, ValueField = "Value" };
            temp.Series.Add(series1);

            var categoryAxis = new CategoryAxis
            {
                Position = AxisPosition.Left,
                GapWidth = 0
            };

            categoryAxis.Labels.AddRange(bins.Select(b => b.Label));
            categoryAxis.IsAxisVisible = false;
            temp.Axes.Add(categoryAxis);

            // todo: link category and linear axis
            temp.Axes.Add(new LinearAxis { Position = AxisPosition.Left, Minimum = min, Maximum = max });

            temp.Axes.Add(new LinearAxis { Position = AxisPosition.Bottom, MinimumPadding = 0, AbsoluteMinimum = 0 });

            return temp;
            _plotModel = temp;

        }

        public HistogramSeries chs = new HistogramSeries();
        public HistogramSeries chsR = new HistogramSeries();
        public HistogramSeries chsG = new HistogramSeries();
        public HistogramSeries chsB = new HistogramSeries();
        List<HistogramItem> list = new List<HistogramItem>();
        List<HistogramItem> listR = new List<HistogramItem>();
        List<HistogramItem> listG = new List<HistogramItem>();
        List<HistogramItem> listB = new List<HistogramItem>();

        //public void HistogramView(bool R, bool G, bool B)
        //{
        //    LoadPixelData();

        //    //定义y轴
        //    LinearAxis leftAxis = new LinearAxis()
        //    {
        //        Position = AxisPosition.Left,
        //        Minimum = 0,
        //        //Maximum = 255,
        //        // Title = "Y轴",//显示标题内容
        //        TitlePosition = 1,//显示标题位置
        //        TitleColor = OxyColor.Parse("#d3d3d3"),//显示标题位置
        //        IsZoomEnabled = false,//坐标轴缩放关闭
        //        IsPanEnabled = false,//图表缩放功能关闭 
        //    };
        //    //定义x轴
        //    LinearAxis bottomAxis = new LinearAxis()
        //    {
        //        Position = AxisPosition.Bottom,
        //        Minimum = 0,
        //        Maximum = 255,
        //        //Title = "X轴",//显示标题内容
        //        TitlePosition = 1,//显示标题位置
        //        TitleColor = OxyColor.Parse("#d3d3d3"),//显示标题位置
        //        IsZoomEnabled = false,//坐标轴缩放关闭
        //        IsPanEnabled = false,//图表缩放功能关闭

        //    };


        //    _plotModel.Axes.Add(leftAxis);
        //    _plotModel.Axes.Add(bottomAxis);

        //    if (R == false & G == false & B == false)
        //    {
        //        for (int i = 0; i < 256; i++)
        //        {

        //            int m = histogram[i];
        //            HistogramItem item = new HistogramItem(i, i + 1, m, 10);
        //            list.Add(item);
        //        }
        //        chs.FillColor = OxyColors.White;
        //        chs.Items.AddRange(list);
        //    }

        //    if (R == true)
        //    {
        //        for (int i = 0; i < 256; i++)
        //        {
        //            int m = histogramRed[i];
        //            HistogramItem item = new HistogramItem(i, i + 1, m, 10);
        //            listR.Add(item);
        //        }
        //        chsG.FillColor = OxyColors.Red;
        //        chsR.Items.AddRange(listR);

        //    }
        //    if (G == true)
        //    {
        //        for (int i = 0; i < 256; i++)
        //        {

        //            int m = histogramGreen[i];
        //            HistogramItem item = new HistogramItem(i, i + 1, m, 10);
        //            listG.Add(item);
        //        }
        //        chsG.FillColor = OxyColors.Green;
        //        chsG.Items.AddRange(listG);
        //    }

        //    if (B == true)
        //    {
        //        for (int i = 0; i < 256; i++)
        //        {

        //            int m = histogramBlue[i];
        //            HistogramItem item = new HistogramItem(i, i + 1, m, 10);
        //            listB.Add(item);
        //        }
        //        chsB.FillColor = OxyColors.Blue;
        //        chsB.Items.AddRange(listB);
        //    }



        //}
    }

    }
