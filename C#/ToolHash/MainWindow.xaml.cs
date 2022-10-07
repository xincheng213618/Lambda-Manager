using ACE;
using ACE.Global;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Forms;
using System.Xml.Linq;
using MessageBox = System.Windows.MessageBox;

namespace ToolHash
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        RegisterInfo registerInfo;
        AESHelper AESHelper;
        FileRegisterinfo FileRegisterinfo;
        public MainWindow()
        {
            InitializeComponent();


            FileRegisterinfo = new FileRegisterinfo();
            registerInfo = FileRegisterinfo.GetRegisterInfo()??new RegisterInfo();
            this.DataContext = registerInfo;
            AESHelper = new AESHelper(FileRegisterinfo);
        }

        string BasePath;

        private void Button_Click(object sender, RoutedEventArgs e)
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


            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择application路径";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                BasePath = dialog.SelectedPath;
                if(XmlHelper.AddHash(BasePath))
                {
                    AESHelper.EncryptFileName = BasePath + "\\application.xml";

                    FileRegisterinfo.SetRegisterInfo(registerInfo);
                    AESHelper.Encrypt();
                    MessageBox.Show("加密成功");
                    File.Delete(AESHelper.EncryptFileName);
                    File.Move("application.sys", BasePath + "\\application.sys",true);

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

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            registerInfo.UserName = "test";
            registerInfo.Email = "123456@gmail.com";
            registerInfo.RegistrationDate = "2020-08-30";
            registerInfo.ExpirationDate = "2026-08-30";
            registerInfo.PhoneNumber = "18846080683";
            registerInfo.RegisteredAddress = "南京市";


        }
    }



    public static class Hash
    {
        public static string GetMD5(string path)
        {
            var hash = MD5.Create();
            var stream = new FileStream(path, FileMode.Open);
            byte[] hashByte = hash.ComputeHash(stream);
            stream.Close();
            return BitConverter.ToString(hashByte).Replace("-", "");
        }
    }
}
