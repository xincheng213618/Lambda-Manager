using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaSerivceInstall
{
    internal class Program
    {
        private static string strExePath = "";
        private static string strExeName = "";

        static void Main(string[] args)
        {
            strExeName = "LambdaService";
            strExePath = AppDomain.CurrentDomain.BaseDirectory + "LambdaService.exe";

            try
            {
                WindowServiceSetup windowServiceHelper = new WindowServiceSetup();
                if (WindowServiceSetup.ServiceIsExisted(strExeName))
                {
                    Console.WriteLine("服务已存在，是否卸载服务：Y？");
                    string cmdu = Console.ReadLine();
                    if (cmdu.Trim() == "y" || cmdu.Trim() == "Y")
                    {
                        Console.WriteLine("卸载服务");
                        WindowServiceSetup.WindowServiceUnInstall(strExePath);
                        Console.WriteLine("卸载服务成功");
                    }
                }

                Console.WriteLine("是否安装服务：Y？");
                string cmd = Console.ReadLine();
                if (cmd.Trim() == "y" || cmd.Trim() == "Y")
                {
                    WindowServiceSetup.WindowServiceInstall(strExePath);

                    Console.WriteLine("自动开启服务");
                    WindowServiceSetup.StartService(strExeName);
                    Console.WriteLine("安装完成，按任意键退出");
                    Console.Read();
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                Console.WriteLine("按任意键退出");
                Console.Read();
            }
        }
    }
}
