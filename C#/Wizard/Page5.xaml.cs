using ConfigSetting;
using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Wizard
{
    /// <summary>
    /// Page2.xaml 的交互逻辑
    /// </summary>
    public partial class Page5 : Page
    {
        MainWindow Window;
        public Page5(MainWindow window)
        {
            InitializeComponent();
            Window = window;

        }
        private void Pages()
        {
            Dispatcher.BeginInvoke(new Action(() => Window.frame.Navigate(Content)));
        }

        private async void Page_Initialized(object sender, EventArgs e)
        {
            await Task.Delay(200);
            CalibrationWindow calibrationWindow = new CalibrationWindow() { WindowStartupLocation =WindowStartupLocation.CenterScreen};
            calibrationWindow.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Content = new Page6(Window);
            Pages();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Content = new Page3(Window);
            Pages();
        }
    }
}
