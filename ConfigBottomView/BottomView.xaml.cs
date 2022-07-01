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
            this.LoadViewFromUri("/ConfigBottomView;component/bottomview.xaml");

        }

        /// 初始化和界面初始化的实际不对，和界面有关的初始化在Loading中加载，和控件相关的初始化加载在Initialized中
        private void UserControl_Initialized(object sender, EventArgs e)
        {
            LambdaControl.RegisterImageView(HistogramImage1).ToString();
            //this.SizeChanged += UserControl_SizeChanged;
        }
        private void UserControl_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            //HistogramImage1.Height = this.ActualHeight - 10;
        }

        public void SetHistogram(int[] Histogramedata)
        {
            if (Histogramedata.Length == 256)
            {
                Text1.Text = "Min:" + Histogramedata.Min();
                Text2.Text = "Max:" + Histogramedata.Max();
                double avg = Histogramedata.Average();
                Text3.Text = "Avg:" + avg.ToString("f5");
                Text4.Text = "δ:" + (Histogramedata.Sum(x => Math.Pow(x - avg, 2)) / (Histogramedata.Count() - 1)).ToString("f5");
                //HistogramImage1.Source = Extensions.GetBitmapSource(ConvertImageToHistogram.GenerateHistogramImage(Histogramedata.ToList()));
            }
        }




        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LambdaControl.Trigger("HistogramAuto", this, new Dictionary<string, object>() { { "image", 0 }, { "auto", true } });
            DoubleThumbSlider1.Visibility = Visibility.Collapsed;
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            LambdaControl.Trigger("HistogramLog", this, new Dictionary<string, object>() { { "image", 0 }, { "log", true } });
            DoubleThumbSlider1.Visibility = Visibility.Visible;
        }


    }
}
