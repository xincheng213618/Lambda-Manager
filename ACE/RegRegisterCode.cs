using ACE.Global;
using Microsoft.Win32;

namespace ACE
{
    /// <summary>
    /// 从注册表保存注册码
    /// </summary>
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

        public string? GetRegisterCode()
        {
            RegistryKey k = Registry.CurrentUser.OpenSubKey(RegistryKey);
            if (k == null)
            {
                k = Registry.CurrentUser.CreateSubKey(RegistryKey);
            }
            return (string?)k.GetValue(Key);
        }

        public void SetRegisterCode(RegisterInfo registerInfo)
        {
            RegistryKey k = Registry.CurrentUser.OpenSubKey(RegistryKey);
            if (k == null)
            {
                k = Registry.CurrentUser.CreateSubKey(RegistryKey);
            }
            k = Registry.CurrentUser.OpenSubKey(RegistryKey, true);

            k.SetValue(Key, registerInfo.MD5());
        }
    }
}
