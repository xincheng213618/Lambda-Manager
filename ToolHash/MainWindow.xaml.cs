using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
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
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string applicationxml = dialog.SelectedPath + "\\application.xml";
                XDocument xmlDoc = XDocument.Load(applicationxml);
                XElement root = xmlDoc.Root;

                foreach (var item in root.Descendants("component"))
                {
                    string FullName = dialog.SelectedPath + "\\" + item.Attribute("lib").Value.ToString();
                    item.SetAttributeValue("md5", Hash.GetHash(FullName));
                }
                xmlDoc.Save(applicationxml);
            }



            //FolderBrowserDialog dialog = new FolderBrowserDialog();
            //dialog.Description = "请选择文件路径";

            //if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    XmlDocument xmlDoc = new XmlDocument();
            //    XmlDeclaration xmlSM = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", null);
            //    xmlDoc.AppendChild(xmlSM);
            //    XmlElement xml = xmlDoc.CreateElement("", "main", "");
            //    xml.SetAttribute("title", "NJUST-SCIL多模显微镜");
            //    xmlDoc.AppendChild(xml);

            //    string foldPath = dialog.SelectedPath;
            //    DirectoryInfo root = new DirectoryInfo(foldPath);
            //    foreach (var path in root.GetFiles())
            //    {
            //        XmlElement component = xmlDoc.CreateElement("", "component", "");
            //        component.SetAttribute("lib", path.Name);
            //        component.SetAttribute("md5", Hash.GetHash(path.FullName));
            //        xml.AppendChild(component);
            //    }
            //    xmlDoc.Save("1.xml");
            //}
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
