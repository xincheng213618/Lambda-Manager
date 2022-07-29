using ACE.Global;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;

namespace ACE
{

    public static class AES
    {
        public static AESHelper AESHelper = new AESHelper();
        public static string? GetSysConfig()
        {
            byte[] trest1 = AESHelper.Decrypt();
            if (trest1 == null)
            {
                MessageBox.Show("软件注册信息损坏，请联系厂家修复。");
                return string.Empty;
            }
            else
            {
                return Encoding.UTF8.GetString(trest1);
            }
        }

        public static string? GetExpireDate()
        {
            if (File.Exists("application.xml"))
            {
                return String.Empty;
            }
            else
            {
                try
                {
                    IRegisterInfo registerInfo = new FileRegisterinfo();
                    var RegisterInfos = registerInfo.GetRegisterInfo();
                    if (RegisterInfos != null)
                    {
                        DateTime dt = DateTime.ParseExact(RegisterInfos.ExpirationDate, "yyyy-MM-dd", System.Globalization.CultureInfo.CurrentCulture);
                        return dt.ToString("yyyy/MM/dd");
                    }
                    else
                    {
                        return String.Empty;
                    }
                }
                catch
                {
                    return "1970/1/0";
                }
            }

       }

    }
}
