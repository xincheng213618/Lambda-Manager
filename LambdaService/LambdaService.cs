using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Runtime.Remoting.Contexts;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LambdaService
{
    public partial class LambdaService : ServiceBase
    {
        public LambdaService()
        {
            InitializeComponent();
        }

        //服务开启
        protected override void OnStart(string[] args)
        {

            WriteLogs(path, "LambdaOnStart");
            Task.Factory.StartNew(Handle);
            Task.Factory.StartNew(SocketTest);

        }
        //服务关闭
        protected override void OnStop()
        {
            var context = "Stop";
            WriteLogs(path, context);
        }
        string path = AppDomain.CurrentDomain.BaseDirectory + "service.log";

        List<Socket> socketPoll = new List<Socket>();

        //需要定时执行的代码段
        private void SocketTest()
        {
            int port = 53618;
            int MaxConnection = 100;
            int ReceiveTimeout = 3000;
            IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Loopback, port);
            Socket socketLister = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socketLister.Bind(localEndPoint);
            try
            {
                socketLister.Listen(MaxConnection);
                socketLister.ReceiveTimeout = ReceiveTimeout;
                while (true)
                {
                    Socket clientSocket = socketLister.Accept();
                    socketPoll.Add(clientSocket);
                    WriteLogs(path, "连接用户");
                    Task.Run(() => SocketPool(clientSocket));
                }
            }
            catch(Exception ex)
            {
                WriteLogs(path, ex.Message);
            }
        }



        private void SocketPool(Socket clientSocket)
        {
            while (true)
            {
                Byte[] stream = new Byte[1024];
                int length = clientSocket.Receive(stream);

                string _data = Encoding.UTF8.GetString(stream,0, length);
                WriteLogs(path, "Socket" + _data.Trim());
                RegHelper.StartUp();
                foreach (Socket socket in socketPoll)
                {
                    WriteLogs(path, "发送");
                    socket.Send(Encoding.UTF8.GetBytes("LambdaStart"));

                }
            }

        }




        //需要定时执行的代码段
        private void Handle()
        {
            while (true)
            {
                Thread.Sleep(10000);
                try
                {
                    var context = "LambdaRun" + System.Windows.Forms.SystemInformation.PowerStatus.BatteryChargeStatus.ToString();
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

        public static void WriteLogs(string context) => WriteLogs(AppDomain.CurrentDomain.BaseDirectory + "service.log", context);

        public static void WriteLogs(string path, string context)
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
