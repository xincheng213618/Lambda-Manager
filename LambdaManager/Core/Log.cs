using Lambda;
using LambdaManager.DataType;
using LambdaManager.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LambdaManager.Core
{
    public delegate void LogWritetHandler(Message message);

    public static class Log
    {
        private static readonly StreamWriter logger = InitLogger(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\LambdaManager");

        private static StreamWriter InitLogger(string dir)
        {
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            string fileName = dir + "\\lambda";
            string fileExtension = "log";
            string logPath = fileName + "." + fileExtension;
            FileInfo fileInfo = new FileInfo(logPath);

            StreamWriter writer;
            if (fileInfo.Exists)
            {
                if (fileInfo.Length > 10485760)
                {
                    DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 3);
                    defaultInterpolatedStringHandler.AppendFormatted(fileName);
                    defaultInterpolatedStringHandler.AppendFormatted(DateTime.Now, "yyyyMMdd");
                    defaultInterpolatedStringHandler.AppendLiteral(".");
                    defaultInterpolatedStringHandler.AppendFormatted(fileExtension);
                    File.Move(logPath, defaultInterpolatedStringHandler.ToStringAndClear());
                }
                writer = File.AppendText(logPath);
                writer.WriteLine("");
            }
            else
            {
                writer = new StreamWriter(File.Open(logPath, FileMode.OpenOrCreate), Encoding.UTF8);
            }
            writer.WriteLine(Severity.INFO.Description() + "程序启动" + DateTime.Now);
            FunctionExecutor.Solution.Writer = writer;
            return writer;
        }

        public static LogWritetHandler LogWrite;

        public static void Report(Message message)
        {
            try
            {
                logger.WriteLine(message.Severity.Description() + message.Text);
            }
            catch 
            {

            }
            System.Windows.Application.Current.Dispatcher.Invoke(delegate
            {
                LogWrite?.Invoke(message);
            });
        }

        public static void Report2(Message message)
        {
            message.Text = DateTime.Now.ToString("mm.ss.fff") + ": " + message.Text;
            Report(message);
        }

        public static void Report(Severity severity, string obj, string? name, string attr, string? value, string err)
        {
            Report(new Message() { Severity = severity, Text = $"{obj}{name}{attr}{attr}{err}" });
        }
    }
}
