using ACE;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;
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
            this.DataContext = registerInfo;
            InitializeComponent();
        }

        RegisterInfo registerInfo = new RegisterInfo();
        string BasePath;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string applicationxml = dialog.SelectedPath + "\\application.xml";
                BasePath = dialog.SelectedPath;
                XDocument xmlDoc = XDocument.Load(applicationxml);
                XElement root = xmlDoc.Root;

                XElement md5 = new XElement("md5", null);
                root.Add(md5);
                var Directoryroot = new DirectoryInfo(dialog.SelectedPath);
                foreach (var item in Directoryroot.GetFiles())
                {
                    if (item.Extension == ".dll")
                    {
                        XElement dll = new XElement("dll", null);
                        dll.SetAttributeValue("path", item.FullName.Replace(BasePath+"\\","")); ;
                        dll.SetAttributeValue("md5", Hash.GetHash(item.FullName));
                        md5.Add(dll);
                    }
                }
                foreach (var item in Directoryroot.GetDirectories())
                {
                    AddDirectory(md5, item.FullName);
                }
 
                xmlDoc.Save(applicationxml);

                MessageBox.Show("hash创建成功");
            }
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
                    dll.SetAttributeValue("md5", Hash.GetHash(file.FullName));
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
            AESHelper AESHelper = new AESHelper(BasePath + "\\application.xml");
            AESHelper.registerCode.SetRegisterCode(registerInfo.GetSha512());
            AESHelper.Encrypt();

        }
    }



    public static class Hash
    {
        public static string GetHash(string path)
        {
            //var hash = SHA256.Create();
            var hash = MD5.Create();
            //var hash = SHA1.Create();
            var stream = new FileStream(path, FileMode.Open);
            byte[] hashByte = hash.ComputeHash(stream);
            stream.Close();
            return BitConverter.ToString(hashByte).Replace("-", "");
        }
    }
}
