using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACE
{
    public static class AES
    {
        private static readonly string RegistryKey = "Software\\" + Application.CompanyName + "\\" + Application.ProductName + "\\" + "ACE";

        private static string Key = "sha512";
        public static string GetRegisterCode()
        {
            RegistryKey k = Registry.CurrentUser.OpenSubKey(RegistryKey);
            if (k == null)
            {
                k = Registry.CurrentUser.CreateSubKey(RegistryKey);
            }
            return k.GetValue("sha512").ToString();
        }


        public static void SetRegisterCode(string Code)
        {
            RegistryKey k = Registry.CurrentUser.OpenSubKey(RegistryKey);
            if (k == null)
            {
                k = Registry.CurrentUser.CreateSubKey(RegistryKey);
            }
            k.SetValue("Key", Code);
        }

        public static string GetSysConfig()
        {
            byte[] trest1 = AES_EnorDecrypt.AESDecrypt(File.ReadAllBytes("application.sys"), GetRegisterCode(), "111");
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
    }
}
