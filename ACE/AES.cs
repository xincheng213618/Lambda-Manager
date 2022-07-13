using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ACE
{
    /// <summary>
    /// 获取注册码接口
    /// </summary>
    public interface IRegisterCode
    {
        void SetRegisterCode(string Code);
        string GetRegisterCode();
    }

    public class RegRegisterCode : IRegisterCode
    {
        private string RegistryKey;

        public RegRegisterCode()
        {
            RegistryKey = "Software\\" + System.Windows.Forms.Application.CompanyName + "\\" + System.Windows.Forms.Application.ProductName + "\\" + "ACE";
        }
        private string Key = "sha512";

        public RegRegisterCode(string key)
        {
            RegistryKey = key;
        }

        public string GetRegisterCode()
        {
            RegistryKey k = Registry.CurrentUser.OpenSubKey(RegistryKey);
            if (k == null)
            {
                k = Registry.CurrentUser.CreateSubKey(RegistryKey);
            }
            return k.GetValue(Key).ToString();
        }

        public void SetRegisterCode(string Code)
        {
            RegistryKey k = Registry.CurrentUser.OpenSubKey(RegistryKey);
            if (k == null)
            {
                k = Registry.CurrentUser.CreateSubKey(RegistryKey);
            }
            k = Registry.CurrentUser.OpenSubKey(RegistryKey, true);

            k.SetValue(Key, Code);
        }
    }

    public class FileRegisterCode : IRegisterCode
    {
        private string Filepath;

        public FileRegisterCode()
        {
            Filepath = $"{Environment.GetFolderPath(Environment.SpecialFolder.Personal)}\\Gird\\rarreg.key";
        }

        public FileRegisterCode(string filepath)
        {
            Filepath = filepath;
        }

        public string GetRegisterCode()
        {
            return File.ReadAllText(Filepath);
        }

        public void SetRegisterCode(string Code)
        {
            File.WriteAllText(Filepath, Code);
        }
    }

    public static class None
    {
        public static AESHelper AESHelper = new AESHelper();
        public static string GetSysConfig()
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
    }


    public class AESHelper
    {
        public IRegisterCode registerCode;

        public AESHelper()
        {
            registerCode = new FileRegisterCode();
        }

        public void Encrypt()
        {
            byte[] bytes = AES_EnorDecrypt.AESEncrypt(File.ReadAllBytes("application.xml"), registerCode.GetRegisterCode(), "Grid");
            using (FileStream fs = new FileStream("application.sys", FileMode.OpenOrCreate, FileAccess.Write))
            {
                fs.Write(bytes, 0, bytes.Length);
            }
        }

        public byte[] Decrypt()
        {
            return AES_EnorDecrypt.AESDecrypt(File.ReadAllBytes("application.sys"), registerCode.GetRegisterCode(), "Grid");
        }



    }
}
