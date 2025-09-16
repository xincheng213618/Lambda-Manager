using Lambda;
using log4net;
using System;

namespace LambdaManager.Core
{
    public delegate void LogWritetHandler(Message message);

    public static class Log
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Log));

        public static LogWritetHandler? LogWrite;

        public static void Report(Message message)
        {
            System.Windows.Application.Current.Dispatcher.Invoke(delegate
            {
                LogWrite?.Invoke(message);
            });
            log.Info(message.Text);
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
