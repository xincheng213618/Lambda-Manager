using ACE;
using ACE.Global;
using System;
using System.IO;
using System.Security.Cryptography;
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
        public MainWindow()
        {
            registerInfo = fileRegisterinfo.GetRegisterInfo(); 
            this.DataContext = registerInfo;
            InitializeComponent();
        }
        FileRegisterinfo fileRegisterinfo = new FileRegisterinfo();
        RegisterInfo registerInfo;
        string BasePath;
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

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

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择application路径";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                BasePath = dialog.SelectedPath;
                if(AddHash(BasePath))
                {
                    fileRegisterinfo.SetRegisterInfo(registerInfo);
                    AESHelper AESHelper = new AESHelper(BasePath + "\\application.xml");
                    AESHelper.Encrypt();
                    MessageBox.Show("加密成功");
                    File.Delete(BasePath + "\\application.xml");
                };
            }

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
