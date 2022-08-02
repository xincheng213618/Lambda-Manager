using ACE;
using ACE.Global;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
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
using System.Xml.Linq;
using ThemeManager.Controls;

namespace Register
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : BaseWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        int mode = 1;
        RegisterInfo registerInfo;
        AESHelper AESHelper;
        IRegisterInfo iRegisterInfo;
        private void Window_Initialized(object sender, System.EventArgs e)
        {
            iRegisterInfo = new FileRegisterinfo();
            registerInfo = iRegisterInfo.GetRegisterInfo();
            this.DataContext = registerInfo;

            AESHelper = new AESHelper();
        }




        private static readonly HttpClient client = new HttpClient();

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!Regex.IsMatch(registerInfo.RegistrationDate, "^(?<year>\\d{2,4})-(?<month>\\d{1,2})-(?<day>\\d{1,2})$"))
            {
                MessageBox.Show("请输入正确的注册日期");
                return;
            }
            if (!Regex.IsMatch(registerInfo.ExpirationDate, "^(?<year>\\d{2,4})-(?<month>\\d{1,2})-(?<day>\\d{1,2})$"))
            {
                MessageBox.Show("请输入正确的过期日期");
                return;
            }
            if (!Regex.IsMatch(registerInfo.Email, @"^[A-Za-z0-9]+([_\.][A-Za-z0-9]+)*@([A-Za-z0-9\-]+\.)+[A-Za-z]{2,6}$"))
            {
                MessageBox.Show("请输入正确的邮箱地址");
                return;
            }
            if (!Regex.IsMatch(registerInfo.PhoneNumber, @"^1(3[0-9]|5[0-9]|7[6-8]|8[0-9])[0-9]{8}$"))
            {
                MessageBox.Show("请输入正确的手机号");
                return;
            }


            string RegisterCode = registerInfo.GetSha512();

            iRegisterInfo.SetRegisterInfo(registerInfo);
            AESHelper.Encrypt();
            Dictionary<string, string> keyValues = new Dictionary<string, string>()
            {
                { "userName",registerInfo.UserName },
                { "registrationDate", registerInfo.RegistrationDate },
                { "registeredAddress",registerInfo.RegisteredAddress },
                { "expirationDate",registerInfo.ExpirationDate },
                { "email",registerInfo.Email },
                { "phoneNumber",registerInfo.PhoneNumber},
                { "registerCode",registerInfo.GetSha512()},
            };
            var content = new FormUrlEncodedContent(keyValues);
            //var response = await client.PostAsync("http://b.xincheng213618.com:18888/register", content);

            //var responseString = await response.Content.ReadAsStringAsync();
            //MessageBox.Show(responseString);

            MessageBox.Show(Encoding.UTF8.GetString(AESHelper.Decrypt()));
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(AES.GetExpireDate());
        }

        private void H5a6_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
