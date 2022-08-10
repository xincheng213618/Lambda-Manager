using Microsoft.Win32;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace Grid
{
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
                if (String.IsNullOrEmpty(value))
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
                if (String.IsNullOrEmpty(value.ToString()))
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
                if (String.IsNullOrEmpty(value))
                {
                    WriteValue(path, name, true);
                    return true;
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

        /// <summary>
        /// 检测扩展
        /// </summary>
        /// <param name="Extension"></param>
        /// <returns></returns>
        public static bool HasExtension(string Extension)
        {
            string FileName = "Test." + Extension;
            bool flag = false;

            try
            {
                using (FileStream fs = File.Create(FileName))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes("This is some text in the file.");
                    fs.Write(info, 0, info.Length);
                }

                flag = HasExecutable(FileName);
                File.Delete(FileName);
            }
            catch
            {

            }
            return flag;
        }
        /// <summary>
        /// 检测文件是否存在可以打开的文件
        /// </summary>
        /// <param name="path"></param> 
        /// <returns></returns>
        public static bool HasExecutable(string path)
        {
            var executable = FindExecutable(path);
            return !string.IsNullOrEmpty(executable);
        }
        private static string FindExecutable(string path)
        {
            var executable = new StringBuilder(1024);
            FindExecutable(path, string.Empty, executable);
            return executable.ToString();
        }

        [DllImport("shell32.dll", EntryPoint = "FindExecutable")]
        private static extern long FindExecutable(string lpFile, string lpDirectory, StringBuilder lpResult);
    }
}
