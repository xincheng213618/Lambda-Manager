using System;

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
            return ConfigReadEvent?.Invoke(FileName) ?? 0;
        }

        public static void ConfigSet()
        {
            ConfigSetEvent?.Invoke();
        }

        public static void ConfigWrite(string FileName)
        {
            ConfigWriteEvent?.Invoke(FileName);
        }
    }
}
