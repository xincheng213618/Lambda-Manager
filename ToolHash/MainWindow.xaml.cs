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
        IRegisterInfo iRegisterInfo;

        public MainWindow()
        {
            InitializeComponent();


            iRegisterInfo = new FileRegisterinfo();
            registerInfo = iRegisterInfo.GetRegisterInfo()??new RegisterInfo();
            this.DataContext = registerInfo;
            AESHelper = new AESHelper();
        }

        string BasePath;
        private bool AddHash(string BasePath)
        {
            string applicationxml = BasePath + "\\application.xml";

            if (!File.Exists(applicationxml))
            {
                MessageBox.Show($"找不到{applicationxml}");
                return false;
            }


            XDocument xmlDoc = XDocument.Load(applicationxml);
            XElement root = xmlDoc.Root;

            foreach (var item in root.Descendants("md5"))
            {
                item.RemoveAll();
            }
            XElement md5 = new XElement("md5", null);
            root.Add(md5);
            var Directoryroot = new DirectoryInfo(BasePath);
            foreach (var item in Directoryroot.GetFiles())
            {
                if (item.Extension == ".dll")
                {
                    XElement dll = new XElement("dll", null);
                    dll.SetAttributeValue("path", item.FullName.Replace(BasePath + "\\", "")); ;
                    dll.SetAttributeValue("md5", Hash.GetMD5(item.FullName));
                    md5.Add(dll);
                }
            }
            foreach (var item in Directoryroot.GetDirectories())
            {
                AddDirectory(md5, item.FullName);
            }
            xmlDoc.Save(applicationxml);
            MessageBox.Show("hash创建成功");
            return true;

        }

        public void AddDirectory(XElement xElement, string FullName)
        {
            var Directoryroot = new DirectoryInfo(FullName);
            foreach (var file in Directoryroot.GetFiles())
            {
                if (file.Extension==".dll")
                {
                    XElement dll = new XElement("dll", null);
                    dll.SetAttributeValue("path", file.FullName.Replace(BasePath+"\\", ""));
                    dll.SetAttributeValue("md5", Hash.GetMD5(file.FullName));
                    xElement.Add(dll);
                }
            }
            foreach (var directoryInfo in Directoryroot.GetDirectories())
            {
                AddDirectory(xElement,directoryInfo.FullName);
            }
        }

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
                if(AddHash(BasePath))
                {
                    AESHelper AESHelper = new AESHelper(BasePath + "\\application.xml");
                    string RegisterCode = registerInfo.MD5();

                    iRegisterInfo.SetRegisterInfo(registerInfo);
                    AESHelper.Encrypt();
                    MessageBox.Show("加密成功");
                    File.Delete(BasePath + "\\application.xml");
                    File.Move("application.sys", BasePath + "\\application.sys",true);

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
