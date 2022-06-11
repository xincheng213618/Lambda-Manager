using Global.Mode.Config;

namespace Global
{
    public delegate void UpdateEventHandler();
    public delegate void AddUpdateEventHandler();


    public static class Update
    {
        public static event UpdateEventHandler UpdateEventHandler;

        public static event AddUpdateEventHandler AddUpdateEventHandler;

        /// <summary>
        /// 更新全局参数
        /// </summary>
        public static void UpdateGlobal()
        {
            UpdateEventHandler?.Invoke();
        }
        public static void AddUpdateGlobal()
        {
            AddUpdateEventHandler?.Invoke();
        }

    } 
}
