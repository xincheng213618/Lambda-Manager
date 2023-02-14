using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace UserRegister
{
    public class IpConfig
    { ///<summary>
      /// 根据截取ipconfig /all命令的输出流获取网卡Mac，支持不同语言编码
      ///</summary>
      ///<returns></returns>
        public string GetMacByIpConfig()
        {
            List<string> macs = new List<string>();
            var runCmd = ExecuteInCmd("chcp 437&&ipconfig/all");
            foreach (var line in runCmd.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(l => l.Trim()))
            {
                if (!string.IsNullOrEmpty(line))
                {
                    if (line.StartsWith("Physical Address"))
                    {
                        macs.Add(line.Substring(36));
                    }
                    else if (line.StartsWith("DNS Servers") && line.Length > 36 && line.Substring(36).Contains("::"))
                    {
                        macs.Clear();
                    }
                    else if (macs.Count > 0 && line.StartsWith("NetBIOS") && line.Contains("Enabled"))
                    {
                        return macs.Last();
                    }
                }
            }
            return macs.FirstOrDefault();
        }
        ///<summary>
        /// 通过WMI读取系统信息里的网卡MAC(方法二)
        ///</summary>
        ///<returns></returns>
        //public string GetMacByWmi()
        //{
        //    try
        //    {
        //        //创建ManagementClass对象
        //        ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
        //        ManagementObjectCollection moc = mc.GetInstances();
        //        string macAddress = string.Empty;
        //        foreach (ManagementObject mo in moc)//遍历获取的集合
        //        {
        //            if ((bool)mo["IPEnabled"])//判断IPEnabled的属性是否为true
        //            {
        //                macAddress = mo["MacAddress"].ToString();//获取网卡的序列号
        //            }
        //        }
        //        return macAddress;
        //    }
        //    catch (Exception e)
        //    {
        //        //这里写异常的处理（最好写入日志文件）
        //        return "";
        //    }
        //}
        /// <summary>
        /// 通过NetworkInterface读取网卡Mac（方法三）
        /// </summary>
        /// <returns></returns>
        public string GetMacByNetworkInterface()
        {
            string key = "SYSTEM\\CurrentControlSet\\Control\\Network\\{4D36E972-E325-11CE-BFC1-08002BE10318}\\";
            string macAddress = string.Empty;
            try
            {
                NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
                foreach (NetworkInterface adapter in nics)
                {
                    if (adapter.NetworkInterfaceType == NetworkInterfaceType.Ethernet
                        && adapter.GetPhysicalAddress().ToString().Length != 0)
                    {
                        string fRegistryKey = key + adapter.Id + "\\Connection";
                        RegistryKey rk = Registry.LocalMachine.OpenSubKey(fRegistryKey, false);
                        if (rk != null)
                        {
                            string fPnpInstanceID = rk.GetValue("PnpInstanceID", "").ToString();
                            int fMediaSubType = Convert.ToInt32(rk.GetValue("MediaSubType", 0));
                            if (fPnpInstanceID.Length > 3 &&
                                fPnpInstanceID.Substring(0, 3) == "PCI")
                            {
                                macAddress = adapter.GetPhysicalAddress().ToString();
                                for (int i = 1; i < 6; i++)
                                {
                                    macAddress = macAddress.Insert(3 * i - 1, ":");
                                }
                                break;
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                //这里写异常的处理（最好写入日志文件）  
            }
            return macAddress;
        }
        public List<string> GetMacAddress()
        {
            List<string> macs = new List<string>();
            NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface ni in interfaces)
            {
                macs.Add(ni.GetPhysicalAddress().ToString());
            }

            return macs;

        }
        /// <summary>
        /// 执行内部命令（cmd.exe 中的命令）
        /// </summary>
        /// <param name="cmdline">命令行</param>
        /// <returns>执行结果</returns>
        public static string ExecuteInCmd(string cmdline)
        {
            using (var process = new Process())
            {
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardInput = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.CreateNoWindow = true;

                process.Start();
                process.StandardInput.AutoFlush = true;
                process.StandardInput.WriteLine(cmdline + "&exit");

                //获取cmd窗口的输出信息  
                string output = process.StandardOutput.ReadToEnd();

                process.WaitForExit();
                process.Close();

                return output;
            }
        }

    }
}
