using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LambdaService
{
    public static class RegHelper
    {
        public static string InstallPath  { get => Registry.CurrentUser.OpenSubKey("Software\\Grid")?.GetValue("InstallPath") as string; }

        public static void StartUp(string i)
        {
            RegistryKey regKey;
            regKey = Registry.ClassesRoot.CreateSubKey(".grif");
            regKey?.SetValue("", "Grid.Launcher.grif");
            regKey = Registry.ClassesRoot.CreateSubKey("Grid.Launcher.grif" + "\\DefaultIcon");
            LambdaService.WriteLogs(InstallPath);
            regKey?.SetValue("", "C:\\Program Files\\Zircon\\Grid" + "\\GridIcons64.dll ,"+i);
            regKey?.Close();
        }




        public static bool UpdateIconCache()
        {
            string Arguments = string.Empty;
            if (Environment.OSVersion.Version.Major == 6)
            {
                Arguments = "/c gpupdate /force /wait:0 && ie4uinit.exe -ClearIconCache";

            }
            else if (Environment.OSVersion.Version.Major > 6)
            {
                Arguments = "/c gpupdate /force /wait:0 && ie4uinit.exe -show";
            }
            ProcessStartInfo info = new ProcessStartInfo
            {
                WindowStyle = ProcessWindowStyle.Hidden,
                UseShellExecute = false,
                FileName = "cmd.exe",
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                Arguments = Arguments
            };
            Process process = Process.Start(info);
            process.WaitForExit();
            return process.ExitCode != 0;
        }




    }
}
