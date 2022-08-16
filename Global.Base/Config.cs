using System;

namespace Global.Base
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


        public static int ConfigRead(string FileName)
        {
            return (int)ConfigReadEvent?.Invoke(FileName);
        }


    }
}
