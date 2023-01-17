using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;

namespace ACE
{
    public class MD5Info
    {
        public string path { get; set; }
        public string md5 { get; set; }
    }

    public class EventManager
    {
        XElement Root;
        public bool Parsing(string s)
        {
            if (Regex.IsMatch(s, "\\s*<\\?\\s*xml"))
                s = s.Substring(s.IndexOf(Environment.NewLine) + 2);
            try
            {
                XDocument xDocument = XDocument.Parse(s);
                if (xDocument.Root ==null)
                    return false;
                Root = xDocument.Root;
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return false;
            }
        }

        List<MD5Info> mD5Infos;
        public bool ParsingXml()
        {
            mD5Infos = (from c in Root.Descendants("md5").Descendants("dll")
             select new MD5Info
             {
                 path = c.Attribute((XName?)"path")?.Value,
                 md5 = c.Attribute((XName?)"md5")?.Value,
             }).ToList();

            return true;
        }

        public bool CheckMD5()
        {
            MD5 hash = MD5.Create();
            string GetMD5(string path)
            {
                if (File.Exists(path))
                {
                    using var stream = new FileStream(path, FileMode.Open);
                    byte[] hashByte = hash.ComputeHash(stream);
                    return BitConverter.ToString(hashByte).Replace("-", "");
                }
                return string.Empty;
            }
            foreach (var m in mD5Infos)
            {
                if (m.md5 != GetMD5("C:\\Users\\Chen\\Desktop\\lambda\\" + m.path))
                {
                    MessageBox.Show($"{m.path}已经被非法修改，请联系厂家修复");
                    return false;
                }
            }
          return true;
        }

    }
}
