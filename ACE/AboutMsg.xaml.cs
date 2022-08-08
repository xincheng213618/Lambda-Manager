using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using ThemeManager.Controls;

namespace ACE
{
    /// <summary>
    /// AboutMsg.xaml 的交互逻辑
    /// </summary>
    public partial class AboutMsg : BaseWindow
    {
        public AboutMsg()
        {
            InitializeComponent();
            WindowStyle = WindowStyle.SingleBorderWindow;
        }

        private void Window_MouseDrag(object sender, MouseButtonEventArgs e)
        {
            try
            {
                DragMove();
            }
            catch { }
        }

        private void Window_Initialized(object sender, EventArgs e)
        {
        }


        private void Label_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            _ = Process.Start("https://scilaboratory.com/");
        }

        private void SystemCommands_Click(object sender, RoutedEventArgs e)
        {
            if (!(e.OriginalSource is Button button))
            {
                return;
            }

            switch (button.Name)
            {
                case "CloseButton":
                    Close();
                    break;
                case "MinimizeButton":
                    WindowState = WindowState.Minimized;
                    break;
                case "MaximizeButton":
                    WindowState = WindowState.Maximized;
                    break;
                case "RestoreButton":
                    WindowState = WindowState.Normal;
                    break;
                default:
                    break;
            }

        }
    }
}
