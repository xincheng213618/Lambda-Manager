using Lambda;
using System;
using System.Windows;

namespace Global.SettingUp
{

    public delegate int ConfigReadEventHandler(string FileName);
    public delegate void ConfigWriteEventHandler(string FileName);
    public delegate void ConfigSetEventHandler();

    /// <summary>
    /// Config
    /// </summary>
    public static class Config
    {
        public static event ConfigReadEventHandler ConfigReadEvent;
        public static event ConfigSetEventHandler ConfigSetEvent;
        public static event ConfigWriteEventHandler ConfigWriteEvent;


        public static int ConfigRead(string FileName)
        {
            try
            {
                return ConfigReadEvent?.Invoke(FileName) ?? 0;
            }
            catch (Exception ex)
            {
                LambdaControl.Log(new Message() { Severity = Severity.ERROR, Text = ex.Message });
                return -1;
            }
        }

        public static void ConfigSet()
        {
            try
            {
                ConfigSetEvent?.Invoke();
            }
            catch ( Exception ex)
            {
                LambdaControl.Log(new Message() { Severity = Severity.ERROR,Text = ex.Message});
            }
        }

        public static void ConfigWrite(string FileName)
        {
            try
            {
                ConfigWriteEvent?.Invoke(FileName);
            }
            catch (Exception ex)
            {
                LambdaControl.Log(new Message() { Severity = Severity.ERROR, Text = ex.Message });
            }
        }
    }
}
