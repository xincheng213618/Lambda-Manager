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
using System.Windows.Shapes;
using ThemeManager.Controls;

namespace ConfigSetting
{
    /// <summary>
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class CalibrationWindow : BaseWindow
    {
        public CalibrationWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LambdaControl.Log(new Message() { Severity = Severity.INFO, Text = "灯光校准" });
            LambdaControl.Trigger("LightCalibrationStart",this,new Dictionary<string, object>());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            LambdaControl.Log(new Message() { Severity = Severity.INFO, Text = "位移台校准" });
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            LambdaControl.Log(new Message() { Severity = Severity.INFO, Text = "算法校准" });
        }
    }
}
