using Lambda;
using System;
using System.Collections.Generic;
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
    /// PixelAnalysis.xaml 的交互逻辑
    /// </summary>
    public partial class PixelAnalysis : UserControl
    {
        public PixelAnalysis()
        {
            InitializeComponent();
        }

        private void HistogramUserCon_Initialized(object sender, EventArgs e)
        {
            LambdaControl.RegisterImageView(HistogramImage).ToString();
        }

        private void RGBGrid_Checked(object sender, RoutedEventArgs e)
        {
           int mode= RGBMode((bool)R.IsChecked, (bool)G.IsChecked, (bool)B.IsChecked);
           LambdaControl.Trigger("HISTOGRAM_MODE", this, new Dictionary<string, object> { { "mode", mode } });
           // MessageBox.Show(mode.ToString());
        }

        private void RGBGrid_UnChecked(object sender, RoutedEventArgs e)
        {
            int mode = RGBMode((bool)R.IsChecked, (bool)G.IsChecked, (bool)B.IsChecked);
            LambdaControl.Trigger("HISTOGRAM_MODE", this, new Dictionary<string, object> { { "mode", mode } });
           // MessageBox.Show(mode.ToString());
        }


        /// <summary>
        /// R4 G2 B1
        /// </summary>
        private int RGBMode(bool m,bool n,bool k)
        {
            return (m ? 4 : 0 )+ (n ? 2 : 0) + (k ? 1 : 0);
        }
        bool auto= false; 

        bool log= false;

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
                LambdaControl.Trigger("HISTOGRAM_AUTOMODE", this, new Dictionary<string, object> { { "autoMode", false} });
                auto = false;
                RangeSlider.SlidThumbVis = Visibility.Visible;
            }

           
        }

        private void Log_Click(object sender, RoutedEventArgs e)
        {
            log = !log;
            LambdaControl.Trigger("HISTOGRAM_LOGMODE", this, new Dictionary<string, object> { { "logMode", log } });      
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

        //private void UserControl_Initialized(object sender, EventArgs e)
        //{
        //    LambdaControl.AddLambdaEventHandler("TestDataEvent", TestDataEvent, false);
        //}

        //[DllImport("kernel32.dll", EntryPoint = "RtlMoveMemory")]
        //public static extern void RtlMoveMemory(IntPtr Destination, IntPtr Source, uint Length);


        //private bool TestDataEvent(object sender, EventArgs e)
        //{
        //    Application.Current.Dispatcher.Invoke(delegate
        //    {
        //        Dictionary<string, object>? eventData = LambdaArgs.GetEventData(e);
        //        if (eventData != null)
        //        {
        //            int size = (int)eventData["size"];

        //            IntPtr intPtr = (IntPtr)eventData["data"];

        //            if (HistogramImage.Source is WriteableBitmap writeableBitmap1)
        //            {
        //                Int32Rect sourceRect = new Int32Rect(0, 0, (int)writeableBitmap1.Width, (int)writeableBitmap1.Height);
        //                writeableBitmap1.WritePixels(sourceRect, intPtr, (int)size, (int)writeableBitmap1.Width * writeableBitmap1.Format.BitsPerPixel / 8);

        //            }
        //            else
        //            {
        //                WriteableBitmap writeableBitmap = new WriteableBitmap(300, 300, 96.0, 96.0, PixelFormats.Bgr24, null);
        //                RtlMoveMemory(writeableBitmap.BackBuffer, intPtr, (uint)size);
        //                writeableBitmap.Lock();
        //                writeableBitmap.AddDirtyRect(new Int32Rect(0, 0, writeableBitmap.PixelWidth, writeableBitmap.PixelHeight));
        //                writeableBitmap.Unlock();
        //                HistogramImage.Source = writeableBitmap;
        //            }
        //        }
        //    });
        //    return true;
        //}







    }
}
