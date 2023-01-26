using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LambdaService
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        //服务开启
        protected override void OnStart(string[] args)
        {


            WriteLogs(path, "LambdaOnStart");
            Task.Factory.StartNew(Handle);
        }
        //服务关闭
        protected override void OnStop()
        {
            var context = "Stop";
            WriteLogs(path, context);
        }
         string path = AppDomain.CurrentDomain.BaseDirectory + "service.log";

        //需要定时执行的代码段
        private void Handle()
        {
            while (true)
            {
                Thread.Sleep(1000);
                try
                {
                    var context = "LambdaRun";
                    WriteLogs(path, context);
                    //Process process = new Process();
                    //process.StartInfo.FileName = @"C:\Users\Chen\Desktop\Lambda Manager\Lambda\LambdaManager\bin\x64\Debug\net6.0-windows\\LambdaManager.exe";
                    //process.StartInfo.UseShellExecute = false;
                    //process.StartInfo.WorkingDirectory = "C:\\Users\\Chen\\Desktop\\Lambda Manager\\Lambda\\LambdaManager\\bin\\x64\\Debug\\net6.0-windows";
                    //process.Start();
                }
                catch (Exception ex)
                {
                    WriteLogs(path, ex.Message);
                }
            }
        }


        public void WriteLogs(string path, string context)
        {
            var fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
            var sw = new StreamWriter(fs);
             context  = DateTime.Now + " " + context +Environment.NewLine;

            sw.BaseStream.Seek(0, SeekOrigin.End);
            sw.WriteLine(context);

            sw.Flush();
            sw.Close();
            fs.Close();
        }

    }
}
