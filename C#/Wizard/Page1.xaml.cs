using ACE;
using ACE.Global;
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
            if (!Regex.IsMatch(registerInfo.RegistrationDate, "^(?<year>\\d{2,4})-(?<month>\\d{1,2})-(?<day>\\d{1,2})$"))
            {
                MessageBox1.Show("请输入正确的注册日期");
                return;
            }
            if (!Regex.IsMatch(registerInfo.ExpirationDate, "^(?<year>\\d{2,4})-(?<month>\\d{1,2})-(?<day>\\d{1,2})$"))
            {
                MessageBox1.Show("请输入正确的过期日期");
                return;
            }
            if (!Regex.IsMatch(registerInfo.Email, @"^[A-Za-z0-9]+([_\.][A-Za-z0-9]+)*@([A-Za-z0-9\-]+\.)+[A-Za-z]{2,6}$"))
            {
                MessageBox1.Show("请输入正确的邮箱地址");
                return;
            }
            if (!Regex.IsMatch(registerInfo.PhoneNumber, @"^1(3[0-9]|5[0-9]|7[6-8]|8[0-9])[0-9]{8}$"))
            {
                MessageBox1.Show("请输入正确的手机号");
                return;
            }

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
        RegisterInfo? registerInfo;
        private void Page_Initialized(object sender, EventArgs e)
        {
            if (registerInfo != null)
            {
                registerInfo = new RegisterInfoReg().Get() ?? new RegisterInfo();
                RegisterStackpanel.DataContext = registerInfo;
            }
            else
            {
                Content = new Page2(Window);
                Pages();
            }
        }

        private void H5a6_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
