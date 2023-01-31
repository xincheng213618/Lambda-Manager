using ACE.Global;
using Microsoft.Win32;
using System.Text.Json;
using System.Text;
using System;

namespace ACE
{
    /// <summary>
    /// 从注册表保存注册码
    /// </summary>
    public class RegisterInfoReg : IRegisterInfo
    {
        private static string RegistryKey = "Software\\Grid";
        private static string Key = "RegisterInfo";

        public RegisterInfo? Get()
        {
            RegistryKey k = Registry.CurrentUser.OpenSubKey(RegistryKey);
            k ??= Registry.CurrentUser.CreateSubKey(RegistryKey);
            string base64 = k.GetValue(Key)?.ToString();
            if (string.IsNullOrEmpty(base64)) return null;
            string info = Encoding.UTF8.GetString(Convert.FromBase64String(base64));
            if (string.IsNullOrEmpty(info)) return null;
            return JsonSerializer.Deserialize<RegisterInfo>(info);
        }

        public void Set(RegisterInfo registerCode)
        {
            string msg = registerCode?.ToBase64();
            RegistryKey k = Registry.CurrentUser.OpenSubKey(RegistryKey);
            _ = k ?? Registry.CurrentUser.CreateSubKey(RegistryKey);
            k = Registry.CurrentUser.OpenSubKey(RegistryKey, true);
            k?.SetValue(Key, msg??string.Empty);


        }
    }
}
