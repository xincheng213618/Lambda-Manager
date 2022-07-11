using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Global
{
    public class WaitContorl
    {
        private static WaitContorl instance;
        private static readonly object locker = new();

        public static WaitContorl GetInstance()
        {
            lock (locker) { if (instance == null) { instance = new WaitContorl(); } }
            return instance;
        }


        private Grid WaitWindow;

        public WaitContorl()
        {
            try
            {
                Grid stageConfig = (Grid)Application.Current.MainWindow.FindName("stageConfig");
                if ( stageConfig.Parent is Grid MainGrid)
                {
                    WaitWindow = new Grid();
                    Grid.SetRow(WaitWindow, 1);
                    Grid.SetColumnSpan(WaitWindow, 3);

                    MainGrid.Children.Add(WaitWindow);
                    WaitWindow.Visibility = Visibility.Collapsed;
                    Grid grid1 = new Grid() { Background = Brushes.Gray, Opacity = 0.1 };
                    WaitWindow.Children.Add(grid1);
                    Border border1 = new Border() { Background = new SolidColorBrush(Color.FromRgb(55, 59, 65)), Height = 150, Width = 550, CornerRadius = new CornerRadius(10) };
                    Border border2 = new Border() { Background = new SolidColorBrush(Color.FromRgb(72, 77, 79)), Height = 100, Width = 500, CornerRadius = new CornerRadius(5) };
                    Grid grid2 = new Grid() { Margin = new Thickness(10) };
                    TextBlock textBlock1 = new TextBlock() { Text = "计算中" };
                    ProgressBar progressBar = new ProgressBar() { Height = 20, VerticalAlignment = VerticalAlignment.Bottom, IsIndeterminate = true, Foreground = new SolidColorBrush(Color.FromRgb(110, 166, 70)), Background = new SolidColorBrush(Color.FromRgb(36, 38, 39)) };
                    grid2.Children.Add(textBlock1);
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
            catch
            {

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

        public void Show()
        {
            if (WaitWindow != null)
            {
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
