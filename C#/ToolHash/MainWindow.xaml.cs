using ACE;
using ACE.Global;
using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Forms;
using System.Xml.Linq;
using ThemeManager.Controls;
using MessageBox = System.Windows.MessageBox;

namespace ToolHash
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : BaseWindow
    {
        AESHelper AESHelper;
        public MainWindow()
        {
            InitializeComponent();

            AESHelper = new AESHelper();
            AESHelper.iRegisterInfo = new RegisterInfoReg();
            var registerInfo = AESHelper.iRegisterInfo.Get() ?? new RegisterInfo();
            this.DataContext = registerInfo;
        }
        
        string BasePath;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (this.DataContext is RegisterInfo registerInfo)
            {
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

                FolderBrowserDialog dialog = new FolderBrowserDialog();
                dialog.Description = "请选择application路径";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    BasePath = dialog.SelectedPath;
                    if (XmlHelper.AddHash(BasePath))
                    {
                        AESHelper.EncryptFileName = BasePath + "\\application.xml";

                        AESHelper.iRegisterInfo.Set(registerInfo);
                        AESHelper.Encrypt();
                        MessageBox.Show("加密成功");
                        //File.Delete(AESHelper.EncryptFileName);
                        File.Move("application.sys", BasePath + "\\application.sys", true);

                        if (Checkbox1.IsChecked == true)
                        {
                            FolderBrowserDialog dialog1 = new FolderBrowserDialog();
                            dialog1.Description = "请选择保存路径";
                            if (dialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                File.WriteAllText(dialog1.SelectedPath + "\\default.json", registerInfo.ToBase64());
                            }
                        }

                    };
                }
            }
        }
        SNCode sNCode = new SNCode();
        private void Button_Click1(object sender, RoutedEventArgs e)
        {

            SNTextBolck.Text = Regex.Replace(sNCode.GetSN(), @"(\w{6}(?=[^$]))", "$1-");
        }




        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(SNTextBolck.Text);


            MessageBox.Show("复制成功");
        }



        private void Button_Click0(object sender, RoutedEventArgs e)
        {
            sNCode = new SNCode() { AreaCode = "000000", DistributorCode = "2210", EquipIdentify = "0000-xxx-xxx-x", ValidityPeriod = DateTime.Now.ToString("yyyyMMdd") };
            StackPanelSN.DataContext = sNCode;
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {



        }
    }
}
