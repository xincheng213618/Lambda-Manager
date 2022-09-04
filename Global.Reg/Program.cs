using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Global.Reg
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
                    "/c gpupdate /force /wait:0"
                };
                Process process = Process.Start(info);
                process.WaitForExit();
                if (process.ExitCode == 0)
                {
                    MessageBox.Show("sucesss");
                }
            }
            else
            {
                MessageBox.Show("12312312");
            }
            //Process[] processes = Process.GetProcesses();//获取所有进程信息
            //for (int i = 0; i < processes.Length; i++)
            //{
            //    if (processes[i].ProcessName.ToLower() == "explorer")
            //    {
            //        try
            //        {
            //            processes[i].Kill(); //停止进程
            //            return;
            //        }
            //        catch
            //        {
            //        }
            //    }
            //}
            //Process.Start("explorer.exe");//再启动进程
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
