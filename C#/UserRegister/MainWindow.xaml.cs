using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using ModernMessageBoxLib;
using System.Windows.Shapes;
using UserRegister.JsonOperate;

namespace UserRegister
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //InitializeComponent();
            Extension.LoadViewFromUri(this, "/UserRegister;component/MainWindow.xaml");
           
            this.DataContext = request.RegisterInfo;
        }

        Request request = new Request();




        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            request.SN = request.RegisterInfo.SN1 + request.RegisterInfo.SN2 + request.RegisterInfo.SN3 + request.RegisterInfo.SN4;

            String RegisterInfo = request.RegisterInfo.Name + "," + request.RegisterInfo.LegalAddress + "," + request.RegisterInfo.EmailAddress + "," + request.RegisterInfo.ContactNumber + ","
                + request.SN;

            string SHA = HashHelper.sha512Encode(RegisterInfo);
            MessageBox.Show(SHA);

            string password = "12345678901234567890123456789012";
            string iv = "00000000000000000";

            string shaEncry = EncryptionExtension.AESEncryptedString(SHA, password, iv);
            MessageBox.Show(shaEncry);
            string sha2 = EncryptionExtension.AESDecryptString(shaEncry, password, iv);
            MessageBox.Show(sha2);

        }

        

        private void LostFocus(object sender, RoutedEventArgs e)
        {

        }
        static class Extension
        {
            /// <summary>
            /// 加载控件
            /// </summary>
            /// <param name="window">根据自己实际修改</param>
            /// <param name="baseUri"></param>
            public static void LoadViewFromUri(Window window, string baseUri)
            {
                try
                {
                    var resourceLocater = new Uri(baseUri, UriKind.Relative);
                    var exprCa = (PackagePart)typeof(Application).GetMethod("GetResourceOrContentPart", BindingFlags.NonPublic | BindingFlags.Static).Invoke(null, new object[] { resourceLocater });
                    var stream = exprCa.GetStream();
                    var uri = new Uri((Uri)typeof(BaseUriHelper).GetProperty("PackAppBaseUri", BindingFlags.Static | BindingFlags.NonPublic).GetValue(null, null), resourceLocater);
                    var parserContext = new ParserContext
                    {
                        BaseUri = uri
                    };
                    typeof(XamlReader).GetMethod("LoadBaml", BindingFlags.NonPublic | BindingFlags.Static).Invoke(null, new object[] { stream, parserContext, window, true });
                }
                catch (Exception)
                {
                    //log
                }
            }
        }

        private void CreateButton1_Click(object sender, RoutedEventArgs e)
        {

            request.SN = request.RegisterInfo.SN1 + request.RegisterInfo.SN2 + request.RegisterInfo.SN3 + request.RegisterInfo.SN4;

            String RegisterInfo = request.RegisterInfo.Name + "," + request.RegisterInfo.LegalAddress + "," + request.RegisterInfo.EmailAddress + "," + request.RegisterInfo.ContactNumber + ","
                + request.SN;
            MessageBox.Show(RegisterInfo);
            string password = "12345678901234567890123456789012";
            string iv = "00000000000000000";

            string RegisterEncry = EncryptionExtension.AESEncryptedString(RegisterInfo, password, iv);
            var msg = new ModernMessageBox("请将以下内容通过微信或者邮件等方式发给公司客服人员.\n", "信息提示", ModernMessageboxIcons.Info, "确认")
            {
                CheckboxVisibility = Visibility.Collapsed,
                TextBoxText = RegisterEncry,
                TextBoxVisibility = Visibility.Visible,
                
            };

            msg.ShowDialog();
            // MessageBox.Show("请把以下内容通过微信或者邮件等方式发给公司客服人员"+ RegisterEncry);
            string Register = EncryptionExtension.AESDecryptString(RegisterEncry, password, iv);
            MessageBox.Show(Register);



        }
    }
}
