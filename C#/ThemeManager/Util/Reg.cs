using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ThemeManager.Util
{
    /// <summary>
    /// 注册表
    /// </summary>
    public static class Reg
    {
        /// <summary>
        /// 读
        /// </summary>
        public static Theme ReadValue([CallerMemberName] string name = "", string path = "Software\\Grid")
        {
            RegistryKey regKey = null;
            try
            {
                regKey = Registry.CurrentUser.OpenSubKey(path, false);
                string value = regKey?.GetValue(name) as string;
                if (!string.IsNullOrEmpty(value))
                {
                    foreach (var item in Enum.GetValues(typeof(Theme)).Cast<Theme>())
                    {
                        if (item.ToString() == value.ToString())
                        {
                            return item;
                        }
                    }
                }
            }
            catch
            {
            }
            finally
            {
                regKey?.Close();
            }
            return Theme.Dark;
        }

        /// <summary>
        /// 写
        /// </summary>
        public static void WriteValue(Theme value, [CallerMemberName] string name = "", string path = "Software\\Grid")
        {
            RegistryKey regKey = null;
            try
            {
                regKey = Registry.CurrentUser.CreateSubKey(path);
                regKey?.SetValue(name, value);
            }
            catch
            {
            }
            finally
            {
                regKey?.Close();
            }
        }
    }
}
