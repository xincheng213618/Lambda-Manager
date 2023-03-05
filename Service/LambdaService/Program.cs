using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LambdaService
{
    internal static class Program
    {


        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        static void Main(string[] args)
        {


            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new LambdaService()
            };
            ServiceBase.Run(ServicesToRun);

        }
    }
}
