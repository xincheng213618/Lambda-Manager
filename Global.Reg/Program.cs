using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Security.Principal;
using System.Windows;

namespace Global.Reg
{
    internal class Program
    {
        //http://woshub.com/how-to-rebuild-corrupted-icon-cache-in-windows-10/

        static void Main(string[] args)
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            if (!principal.IsInRole(WindowsBuiltInRole.Administrator))
            {
                MessageBox.Show("请以管理员身份运行");
                return;
            }

            if (!File.Exists($"{System.Windows.Forms.Application.StartupPath}\\Grid.exe"))
            {
                MessageBox.Show("找不到启动文件夹");
                return;
            }

            if (SetIcon(".gprj", "Grid.Launcher.gprj", System.Windows.Forms.Application.ExecutablePath + " ,0", $"{System.Windows.Forms.Application.StartupPath}\\Grid.exe %1"))
            {
                ProcessStartInfo info = new ProcessStartInfo
                {
                    WindowStyle = ProcessWindowStyle.Hidden,
                    UseShellExecute = false,
                    FileName = "cmd.exe",
                    CreateNoWindow = true,
                    RedirectStandardOutput = true,
                    Arguments =
                    "/c gpupdate /force /wait:0 & &ie4uinit.exe -show"
                };
                Process process = Process.Start(info);
                process.WaitForExit();
                if (process.ExitCode == 0)
                {

                }
            }
        }

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
