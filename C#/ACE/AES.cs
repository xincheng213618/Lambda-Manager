using ACE.Global;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;

namespace ACE
{

    public static class AES
    {
        public static IRegisterInfo IRegisterInfo = new RegisterInfoFile();
        public static AESHelper AESHelper = new AESHelper(IRegisterInfo);

        public static EventManager eventManager = new EventManager();

        public static string? GetSysConfig()
        {
            string path = "application.xml";
            if (File.Exists(path))
                return File.ReadAllText(path) ?? null;
            return null;


            //string path = "C:\\Users\\Chen\\Desktop\\lambda\\application.xml";
            //string s = File.ReadAllText(path);

            //if (!eventManager.Parsing(s))
            //    return null;
            //if (!eventManager.ParsingXml())
            //    return null;
            //if (!eventManager.CheckMD5())
            //    return null;
            //return s;


            //AESHelper.DecryptFileName = "application.sys";
            //byte[] data = AESHelper.Decrypt();

            //if (data != null)
            //    return Encoding.UTF8.GetString(data);

            //MessageBox.Show("软件注册信息损坏，请联系厂家修复。");
            //return null;
        }

        public static string? GetExpireDate()
        {
            return "2025/1/1";
            //if (File.Exists("application.xml")) 
            //    return null;
            //try
            //{
            //    var RegisterInfos = IRegisterInfo.Get();
            //    if (RegisterInfos != null)
            //    {
            //        DateTime dt = Convert.ToDateTime(RegisterInfos.ExpirationDate);
            //        return dt.ToString("yyyy/MM/dd");
            //    }
            //    else
            //    {
            //        return null;
            //    }
            //}
            //catch
            //{
            //    return "1970/1/1";
            //}
        }

    }
}
