using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.Json;
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
    /// Page0.xaml 的交互逻辑
    /// </summary>
    public partial class Page0 : Page
    {
        WizardWindow Window;
        public Page0(WizardWindow window)
        {
            InitializeComponent();
            Window = window;
            this.DataContext = request.RegisterInfo;
        }
        public Page0()
        {
            InitializeComponent();
            this.DataContext = request;
        }
        Request request = new Request();
        string uri = "https://v3.xincheng213618.com:18888/register";
        string u = "https://v3.xincheng213618.com:18888/register";
        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                List<string> Macs = GetMacAddress();
                request.MacAddress = Macs[0];
                request.SN = request.RegisterInfo.SN1 + request.RegisterInfo.SN2 + request.RegisterInfo.SN3 + request.RegisterInfo.SN4;
                RegisterOnline();

            }
            catch
            {
                MessageBoxResult result = MessageBox.Show("是否离线注册！", "信息提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
                if (result == MessageBoxResult.OK)
                {
                    RegisterOffline();
                }
            }
           
          
            

        }




        private void RegisterOnline()
        {

            string json = HttpRequest1(uri, request);
            RegisterBack regBack = JsonSerializer.Deserialize<RegisterBack>(json, new JsonSerializerOptions());
            //regBack.Message = "该用户已经注册,是否重新注册到新设备？";
            if (regBack?.State == 0)
            {
                MessageBox.Show("注册成功 ！", "信息提示", MessageBoxButton.OK, MessageBoxImage.Information);
                Content = new Page2(Window);
                PageNavigate();
            }
            else
            {
                if (regBack.Message == "该用户已经注册")
                {
                    MessageBox.Show("注册失败 ！" + regBack.Message.ToString(), "信息提示", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else if (regBack.Message == "该用户已经注册,是否重新注册到新设备？")
                {

                    MessageBoxResult result = MessageBox.Show("注册失败 ！" + regBack.Message.ToString(), "信息提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
                    switch (result)
                    {
                        case MessageBoxResult.OK:


                            break;
                        case MessageBoxResult.No:
                            MessageBox.Show("注册失败 ！", "信息提示", MessageBoxButton.OK, MessageBoxImage.Information);
                            break;

                    }
                }
                else if (regBack.Message == "该注册码无效")
                {
                    

                    MessageBox.Show("注册失败 ！" + "该用户不是有效购买用户", "信息提示", MessageBoxButton.OK, MessageBoxImage.Information);

                }
                else
                {
                    MessageBox.Show("注册失败 ！" + regBack.Message.ToString(), "信息提示", MessageBoxButton.OK, MessageBoxImage.Information);

                }




            }


        }

        private void RegisterOffline()
        {
            //  request 字符串加密
            string keys;
            MessageBox.Show("keys ！" + "请把当前字符串发送给公司客服人员(微信或邮件等方式)", "信息提示", MessageBoxButton.OK, MessageBoxImage.Information);
        }







        public string HttpRequest1(string uri, Request request)
        {

            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("sn", request.SN);
            string registerInfo = "22222";
            dic.Add("register-info", registerInfo);
            dic.Add("mac-address", request.MacAddress);
            dic.Add("equip-identify", request.EquipID);
            string message = HttpRequest.Post(uri, dic);
           // MessageBox.Show(message);
            return message;
        }





        private void LostFocus(object sender, RoutedEventArgs e)
        {
            //if (UserName.Text == "" || UserName.Text == null)
            //{
            //    UserName.Text = "用户名";
            //};
            //if(Legal.Text ==""||Legal.Text == null)
            //{
            //    Legal.Text = "注册地址";
            //}
            //if (Email.Text == "" || Email.Text == null)
            //{
            //    Email.Text = "注册邮件地址";
            //}
            //if (Call.Text == "" || Call.Text == null)
            //{
            //    Call.Text = "联系电话";
            //}
            //if (SN.Text == "" || SN.Text == null)
            //{
            //    SN.Text = "注册码";
            //}

        }
        public List<string>  GetMacAddress()
        {
            List<string> macs = new List<string>();
            NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface ni in interfaces)
            {
                macs.Add(ni.GetPhysicalAddress().ToString());
            }

            return macs;

        }



        private void PageNavigate()
        {
            Dispatcher.BeginInvoke(new Action(() => Window.frame.Navigate(Content)));
        }

        private void CreateButton1_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
