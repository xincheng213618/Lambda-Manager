using Global.Common;
using Lambda;
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
    public partial class Page6 : Page
    {
        MainWindow Window;
        public Page6(MainWindow window)
        {
            InitializeComponent();
            Window = window;
        }
        private void Pages()
        {
            Dispatcher.BeginInvoke(new Action(() => Window.frame.Navigate(Content)));
        }

        private void Page_Initialized(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SolutionConfig.HardwareSetting.IsIniWizard = true;
            LambdaControl.Log(new Message() { Severity = Severity.INFO, Text = "关闭配置向导" });
            Window.Close();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Content = new Page5(Window);
            Pages();
        }
    }
}
