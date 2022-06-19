using Lambda;
using System;
using System.Collections.Generic;
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
        public BottomView()
        {
            InitializeComponent();
        }

        /// 初始化和界面初始化的实际不对，和界面有关的初始化在Loading中加载，和控件相关的初始化加载在Initialized中
        private void UserControl_Initialized(object sender, EventArgs e)
        {
            LambdaControl.AddLambdaEventHandler("TestDataEvent2", TestDataEvent2, false);
        }
        BitmapSource Bitmap = null;

        private bool TestDataEvent2(object sender, EventArgs e)
        {
            Application.Current.Dispatcher.Invoke(delegate
            {
                Dictionary<string, object>? eventData = LambdaArgs.GetEventData(e);
                if (eventData != null)
                {
                    int size = (int)eventData["size"];

                    IntPtr intPtr = (IntPtr)eventData["data"];
                    int[] aaa = new int[256];
                    Marshal.Copy(intPtr, aaa, 0, 256);
                    HistogramImage1.Source = Extensions.GetBitmapSource(ConvertImageToHistogram.GenerateHistogramImage(aaa.ToList()));

                    //GCHandle pinnedArray = GCHandle.Alloc(aaa, GCHandleType.Pinned);
                    //IntPtr pointer = pinnedArray.AddrOfPinnedObject();
                    //pinnedArray.Free();

                }
            });

            return true;
        }

        private bool BottomViewIsInitialized = false;

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            if (!BottomViewIsInitialized)
            {
                BottomViewIsInitialized = true;
                HistogramImage1.Source = Bitmap;

                //if (this.Parent is StackPanel stackPanel1)
                //{
                //    this.Width = stackPanel1.ActualWidth;
                //    this.Height = Grid1.Height;
                //    Window mainwin = Application.Current.MainWindow;
                //    mainwin.SizeChanged += delegate
                //    {
                //        this.Width = stackPanel1.ActualWidth;
                //        Grid1.Width = stackPanel1.ActualWidth;
                //    };
                //    stackPanel1.SizeChanged += delegate
                //    {
                //        this.Width = stackPanel1.ActualWidth;
                //        Grid1.Width = stackPanel1.ActualWidth;

                //    };
                //}
                Window mainwin = Application.Current.MainWindow;

                Grid mainView = (Grid)mainwin.FindName("mainView");
                mainView.SizeChanged += delegate
                {
                    this.Width = mainView.ActualWidth;
                };
            }

        }
    }
}
