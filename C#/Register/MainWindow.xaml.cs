using ACE;
using ACE.Global;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
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

        RegisterInfo registerInfo;
        AESHelper AESHelper;
        IRegisterInfo iRegisterInfo = new RegisterInfoReg();

        private void Window_Initialized(object sender, System.EventArgs e)
        {            
            if (!File.Exists("application.xml"))
            {
                Button1.Content = "重新注册";
            }

            registerInfo = iRegisterInfo.Get();
            this.DataContext = registerInfo;
            AESHelper = new AESHelper();
        }


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

            if (File.Exists("application.xml"))
            {
                iRegisterInfo.Set(registerInfo);
                AESHelper.Encrypt();
            }
            else
            {
                byte[] Caches = AESHelper.Decrypt();
                iRegisterInfo.Set(registerInfo);
                AESHelper.Encrypt(Caches);
            }

            Dictionary<string, string> keyValues = new Dictionary<string, string>()
            {
                { "userName",registerInfo.UserName },
                { "registrationDate", registerInfo.RegistrationDate },
                { "registeredAddress",registerInfo.RegisteredAddress },
                { "expirationDate",registerInfo.ExpirationDate },
                { "email",registerInfo.Email },
                { "phoneNumber",registerInfo.PhoneNumber},
                { "sn",registerInfo.GetMD5()},
            };

            try
            {
                HttpClient client = new HttpClient();

                var content = new FormUrlEncodedContent(keyValues);

                var response = await client.PostAsync("http://127.0.0.1:18888/register1", content);
                var responseString = await response.Content.ReadAsStringAsync();

                List<string> macs = new List<string>();
                NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
                foreach (NetworkInterface ni in interfaces)
                {
                    macs.Add(ni.GetPhysicalAddress().ToString());
                }

                Dictionary<string, string> keyValues1 = new Dictionary<string, string>()
                { 
                    { "sn",registerInfo.SN },
                    { "mac-address", macs[0] },
                    { "equip-identify",null},
                };
                var content1 = new FormUrlEncodedContent(keyValues1);

                var response1 = await client.PostAsync("http://127.0.0.1:18888/register", content1);
                var responseString1 = await response1.Content.ReadAsStringAsync();
                JsonObject jsonobject = (JsonObject)JsonNode.Parse(responseString1);
                if (jsonobject != null)
                {
                    if ("0"== jsonobject["state"].ToString())
                    {
                        if (jsonobject["message"].ToString() == "该用户已经注册过")
                        {
                            if (MessageBox.Show("该用户已经注册过，是否重新绑定机器", "Grid", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                            {
                                var response2 = await client.PostAsync("http://127.0.0.1:18888/unregister", content1);
                                var responseString2 = await response2.Content.ReadAsStringAsync();
                                MessageBox.Show(responseString2);

                                if (responseString2 == null)
                                {
                                    JsonObject jsonobject2 = (JsonObject)JsonNode.Parse(responseString2);

                                    if ("0" == jsonobject["state"].ToString())
                                    {
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("注册失败");
                            }
                        }

                        if (!String.IsNullOrEmpty(Encoding.UTF8.GetString(AESHelper.Decrypt())))
                            MessageBox.Show("注册成功");
                    }
                    MessageBox.Show("注册失败：");
                }
                else
                {
                    MessageBox.Show("注册失败：");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("注册失败："+ex.Message);
            }

            //if (File.Exists("application.xml"))
            //    File.Delete("application.xml");

            //if (!File.Exists("application.xml"))
            //{
            //    Button1.Content = "重新注册";
            //}
        }


        private void H5a6_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
