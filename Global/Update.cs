using Global.Mode.Config;

namespace Global
{
    public delegate void UpdateEventHandler();


    public static class Update
    {
        public static event UpdateEventHandler UpdateEvent;

        /// <summary>
        /// 更新全局参数
        /// </summary>
        public static void UpdateGlobal()
        {
            UpdateEvent?.Invoke();
        }

    } 
}
