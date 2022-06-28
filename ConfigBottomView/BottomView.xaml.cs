using Lambda;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
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
    /// UserControl.xaml 的交互逻辑
    /// </summary>
    public partial class BottomView : UserControl
    {
        public BottomView( )
        {
            //InitializeComponent(); 
            this.LoadViewFromUri("/ConfigBottomView;component/bottomview.xaml");

        }

        /// 初始化和界面初始化的实际不对，和界面有关的初始化在Loading中加载，和控件相关的初始化加载在Initialized中
        private void UserControl_Initialized(object sender, EventArgs e)
        {
        }
        List<ImageSource> ImageSources = new List<ImageSource>();

        public void SetHistogram(int[] Histogramedata)
        {
            Text1.Text = "最小值" + Histogramedata.Min();
            Text2.Text = "最大值" + Histogramedata.Max();
            double avg = Histogramedata.Average();
            Text3.Text = "平均值" + avg.ToString("f5");
            Text4.Text = "方差" + (Histogramedata.Sum(x => Math.Pow(x - avg, 2)) / (Histogramedata.Count() - 1)).ToString("f5");
            HistogramImage1.Source = Extensions.GetBitmapSource(ConvertImageToHistogram.GenerateHistogramImage(Histogramedata.ToList()));

        }




        private bool BottomViewIsInitialized = false;

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            if (!BottomViewIsInitialized)
            {
                BottomViewIsInitialized = true;

                Window mainwin = Application.Current.MainWindow;

                Grid mainView = (Grid)mainwin.FindName("mainView");
                mainView.SizeChanged += delegate
                {
                    this.Width = mainView.ActualWidth;
                };
            }

        }

        public void Show()
        {
            this.Visibility = Visibility.Visible;
        }
        public void Hidden()
        {
            this.Visibility = Visibility.Collapsed;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
        }

        private void UserControl_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            HistogramImage1.Height = this.ActualHeight-20;
        }
    }
}
