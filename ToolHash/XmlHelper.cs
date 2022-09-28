using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ToolHash
{
    public static class XmlHelper
    {

        public static bool AddHash(string BasePath)
        {
            string applicationxml = BasePath + "\\application.xml";

            if (!File.Exists(applicationxml))
            {
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
                XmlHelper.AddDirectory(md5, item.FullName, BasePath);
            }
            xmlDoc.Save(applicationxml);
            return true;
        }

        public static void AddDirectory(XElement xElement, string FullName,string BasePath)
        {
            var Directoryroot = new DirectoryInfo(FullName);
            foreach (var file in Directoryroot.GetFiles())
            {
                if (file.Extension == ".dll")
                {
                    XElement dll = new XElement("dll", null);
                    dll.SetAttributeValue("path", file.FullName.Replace(BasePath + "\\", ""));
                    dll.SetAttributeValue("md5", Hash.GetMD5(file.FullName));
                    xElement.Add(dll);
                }
            }
            foreach (var directoryInfo in Directoryroot.GetDirectories())
            {
                AddDirectory(xElement, directoryInfo.FullName ,BasePath);
            }
        }

    }
}
