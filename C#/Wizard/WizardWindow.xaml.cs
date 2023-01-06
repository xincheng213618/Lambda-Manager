using ACE.Global;
using Global.Common;
using Global.Common.Extensions;
using Global.Common.MVVM;
using Global.SettingUp;
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
using ThemeManager;
using ThemeManager.Controls;

namespace Wizard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class WizardWindow : BaseWindow
    {
        public List<string> ResourceDictionaryDark = new List<string>();
        public WizardWindow()
        {
            InitializeComponent();
        }
        FileRegisterinfo fileRegisterinfo;
        RegisterInfo registerInfo;
        private void BaseWindow_Initialized(object sender, EventArgs e)
        {
            //fileRegisterinfo = new FileRegisterinfo();
            //registerInfo = fileRegisterinfo.GetRegisterInfo();
            //if (registerInfo == null)
            //{
            //    Dispatcher.BeginInvoke(new Action(() => frame.Navigate(new Page1(this))));
            //}
            //else
            //{
            //    Dispatcher.BeginInvoke(new Action(() => frame.Navigate(new Page2(this))));
            //}

            Dispatcher.BeginInvoke(new Action(() => frame.Navigate(new Page2(this))));
            LambdaControl.Log(new Message() { Severity = Severity.INFO, Text = "启动配置向导" });
        }

        private void BaseWindow_Closed(object sender, EventArgs e)
        {
            if (!SoftwareConfig.HardwareSetting.IsIniWizard)
            {
                Environment.Exit(0);
            }
            else
            {
                SoftwareConfig.HardwareConfig.ToJsonFile("HardwareConfig");
            }

        }
    }
}
