using Global.Hardware;
using Global.SettingUp;
using Global.SettingUp.Hardware;
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
    public partial class Page3 : Page
    {
        ObjectiveConfig objectiveConfig = SoftwareConfig.HardwareConfig.ObjectiveConfig;

        MainWindow Window;
        public Page3(MainWindow window)
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
            objectiveConfig.AvailableObjectives.Add(new ObjectiveConfigBase(4, 0.1) { MagnitudeName = "4X" });
            objectiveConfig.AvailableObjectives.Add(new ObjectiveConfigBase(10,0.25) {MagnitudeName="10X"});
            objectiveConfig.AvailableObjectives.Add(new ObjectiveConfigBase(20, 0.4) { MagnitudeName = "20X" });
            objectiveConfig.AvailableObjectives.Add(new ObjectiveConfigBase(40, 0.65) { MagnitudeName = "40X" });
            objectiveConfig.AvailableObjectives.Add(new ObjectiveConfigBase(100, 0.65) { MagnitudeName = "100X" });
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            objectiveConfig.SelectObjective = objectiveConfig.AvailableObjectives[1];
            Content = new Page5(Window);
            Pages();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Content = new Page2(Window);
            Pages();
        }
    }
}
