
using Global.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Page.xaml 的交互逻辑
    /// </summary>
    public partial class Page1 : Page
    {
        WizardWindow Window;
        public Page1(WizardWindow window)
        {
            InitializeComponent();
            Window = window;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (File.Exists("application.xml"))
            {
                //fileRegisterinfo.set(registerInfo);
                //new AESHelper(fileRegisterinfo).Encrypt();
            }
            else
            {
                //byte[] Caches = new AESHelper(fileRegisterinfo).Decrypt();
                //fileRegisterinfo.SetRegisterInfo(registerInfo);
                //new AESHelper(fileRegisterinfo).Encrypt(Caches);
            }

            List<string> macs = new List<string>();
            NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface ni in interfaces)
            {
                macs.Add(ni.GetPhysicalAddress().ToString());
            }


            Content = new Page2(Window);
            Pages();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Window.Close();
        }

        private void Pages()
        {
            Dispatcher.BeginInvoke(new Action(() => Window.frame.Navigate(Content)));
        }
        private void Page_Initialized(object sender, EventArgs e)
        {
        }

        private void H5a6_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
