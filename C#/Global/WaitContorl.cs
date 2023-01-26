using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Global.Common;
using Lambda;

namespace Global
{
    /// <summary>
    /// 等待的弹窗
    /// </summary>
    public class WaitContorl:ViewModelBase 
    {
        private static WaitContorl _instance;
        private static readonly object _locker = new();
        public static WaitContorl GetInstance() {  lock (_locker) { return  _instance ??= new WaitContorl(); }  }

        public TextBox textBox = new TextBox() { Text = "计算中" };
        private Grid WaitWindow;

        public WaitContorl()
        {

            if (Application.Current.MainWindow.FindName("stageConfig") is Grid stageConfig && stageConfig.Parent is Grid MainGrid)
            {
                WaitWindow = new Grid();
                Grid.SetRow(WaitWindow, 1);
                Grid.SetColumnSpan(WaitWindow, 3);

                MainGrid.Children.Add(WaitWindow);

                WaitWindow.Visibility = Visibility.Collapsed;

                Grid grid1 = new Grid() { Background = Brushes.Black, Opacity = 0.3 };
                WaitWindow.Children.Add(grid1);

                Border border1 = new Border() { Background = new SolidColorBrush(Color.FromRgb(55, 59, 65)), Height = 150, Width = 550, CornerRadius = new CornerRadius(10) };
                Border border2 = new Border() { Background = new SolidColorBrush(Color.FromRgb(72, 77, 79)), Height = 100, Width = 500, CornerRadius = new CornerRadius(5) };
                Grid grid2 = new Grid() { Margin = new Thickness(10) };
                ProgressBar progressBar = new ProgressBar() { Height = 20, VerticalAlignment = VerticalAlignment.Bottom, IsIndeterminate = true, Foreground = new SolidColorBrush(Color.FromRgb(110, 166, 70)), Background = new SolidColorBrush(Color.FromRgb(36, 38, 39)) };
                grid2.Children.Add(textBox);
                grid2.Children.Add(progressBar);
                border2.Child = grid2;
                border1.Child = border2;
                WaitWindow.Children.Add(border1);
                WaitWindow.MouseRightButtonUp += delegate
                {
                    WaitWindow.Visibility = Visibility.Collapsed;
                };
            }
        }



        public void Hidden()
        {
            if (WaitWindow != null)
            {
                WaitWindow.Visibility = Visibility.Collapsed;
                Application.Current.MainWindow.Cursor = Cursors.Arrow;
            }
        }

        /// <summary>
        /// 毫秒
        /// </summary>
        public double ShowTimeOut =0;
        private System.Windows.Threading.DispatcherTimer _timer;

        public void Show()
        {
            if (WaitWindow != null)
            {
                if (ShowTimeOut != 0)
                {
                    _timer = new System.Windows.Threading.DispatcherTimer(){ Interval = TimeSpan.FromMilliseconds(ShowTimeOut) };
                    _timer.Tick += delegate
                    {
                        _timer.Stop();
                        Application.Current.Dispatcher.Invoke(delegate
                        {
                            WaitWindow.Visibility = Visibility.Collapsed;
                            Application.Current.MainWindow.Cursor = Cursors.Arrow;

                            MessageBox1.Show("WaitContorl超时", "Grid", MessageBoxButton.OK, MessageBoxImage.Error);
                            LambdaControl.Log(new Message() { Severity = Severity.ERROR, Text = "WaitContorl超时,程序异常" });
                        });
                    };
                }
                Application.Current.MainWindow.Cursor = Cursors.Wait;
                WaitWindow.Visibility = Visibility.Visible;
            }
        }


        public async void Timer(int time)
        {
            if (WaitWindow != null)
            {
                Application.Current.MainWindow.Cursor = Cursors.Wait;
                WaitWindow.Visibility = Visibility.Visible;
                await Task.Delay(time);
                WaitWindow.Visibility = Visibility.Hidden;
                Application.Current.MainWindow.Cursor = Cursors.Arrow;
            }
        }


    }
}
