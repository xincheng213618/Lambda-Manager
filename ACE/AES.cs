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
        public static bool IsInit = false;

        public static void Init()
        {
            if (File.Exists("default.json"))
            {
                fileRegisterinfo = new FileRegisterinfo(new FileRegisterCode("default.json"));
            }
            else if (File.Exists($"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\\{System.Windows.Forms.Application.ProductName}\\default.json"))
            {
                fileRegisterinfo = new FileRegisterinfo(new FileRegisterCode());
            }
            else
            {
                fileRegisterinfo = new FileRegisterinfo();
            }
            IsInit = true;
        }


        public static FileRegisterinfo  fileRegisterinfo= new FileRegisterinfo();
        public static AESHelper AESHelper = new AESHelper(fileRegisterinfo);
        public static string? GetSysConfig()
        {
            if (!IsInit) Init();
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
            if (!IsInit) Init();

            if (!File.Exists("application.xml"))
            {
                try
                {
                    var RegisterInfos = fileRegisterinfo.GetRegisterInfo();
                    if (RegisterInfos != null)
                    {
                        DateTime dt = Convert.ToDateTime(RegisterInfos.ExpirationDate);
                        return dt.ToString("yyyy/MM/dd");
                    }
                    else
                    {
                        return null;
                    }
                }
                catch
                {
                    return "1970/1/1";
                }
            }
            return null;


        }

    }
}
