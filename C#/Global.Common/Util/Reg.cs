using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Global.Common.Util
{
    /// <summary>
    /// 注册表
    /// </summary>
    public static class Reg
    {
        /// <summary>
        /// 读
        /// </summary>
        public static string ReadValue(string path, string name, string def)
        {
            RegistryKey regKey = null;
            try
            {
                regKey = Registry.CurrentUser.OpenSubKey(path, false);
                string value = regKey?.GetValue(name) as string;
                if (string.IsNullOrEmpty(value))
                {
                    WriteValue(path, name, def);
                    return def;
                }
                else
                {
                    return value;
                }
            }
            catch
            {
            }
            finally
            {
                regKey?.Close();
            }
            return def;
        }

        /// <summary>
        /// 写
        /// </summary>
        public static void WriteValue(string path, string name, object value)
        {
            RegistryKey regKey = null;
            try
            {
                regKey = Registry.CurrentUser.CreateSubKey(path);
                if (string.IsNullOrEmpty(value.ToString()))
                {
                    regKey?.DeleteValue(name, false);
                }
                else
                {
                    regKey?.SetValue(name, value);
                }
            }
            catch
            {
            }
            finally
            {
                regKey?.Close();
            }
        }




        public static bool ReadValue(string path, string name)
        {
            RegistryKey regKey = null;
            try
            {
                regKey = Registry.CurrentUser.OpenSubKey(path, false);
                string value = regKey?.GetValue(name) as string;
                if (string.IsNullOrEmpty(value))
                {
                    WriteValue(path, name, false);
                    return false;
                }
                else
                {
                    return Convert.ToBoolean(regKey?.GetValue(name));
                }

            }
            catch
            {
            }
            finally
            {
                regKey?.Close();
            }
            return false;
        }


        /// <summary>
        /// 设置扩展
        /// </summary>
        /// <param name="Extension">扩展名</param>
        /// <param name="ExtensionName">扩展备注</param>
        /// <param name="icon">图标</param>
        /// <param name="command">命令</param>
        /// <returns></returns>
        public static bool SetIcon(string Extension, string ExtensionName, string icon, string command)
        {
            RegistryKey regKey = null;
            bool flag = false;
            try
            {
                regKey = Registry.ClassesRoot.CreateSubKey(Extension);
                regKey?.SetValue("", ExtensionName);
                regKey = Registry.ClassesRoot.CreateSubKey(ExtensionName + "\\DefaultIcon");
                regKey?.SetValue("", icon);
                regKey = Registry.ClassesRoot.CreateSubKey(ExtensionName + "\\shell\\open\\command");
                regKey?.SetValue("", command);
                flag = true;
            }
            catch 
            {
                flag = false;
            }
            finally
            {
                regKey?.Close();
            }

            return flag;
        }
    }
}
