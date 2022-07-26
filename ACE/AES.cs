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
                string result = File.ReadAllText("default.json");
                if (result == null)
                {
                    return String.Empty;
                }
                var config = JsonSerializer.Deserialize<Config>(result);
                if (config == null)
                {
                    return String.Empty;
                }
                else
                {
                    try
                    {
                        DateTime dt = DateTime.ParseExact(config.RegisterInfo.ExpirationDate, "yyyy-MM-dd", System.Globalization.CultureInfo.CurrentCulture);
                        return dt.ToString("yyyy/MM/dd");
                    }
                    catch
                    {
                        return  "1970/1/0";
                    }

                }
            }

       }

    }
}
