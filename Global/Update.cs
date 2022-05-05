using Global.Mode.Config;

namespace Global
{
    public delegate void UpdateEventHandler();

    public static class Update
    {
        public static event UpdateEventHandler UpdateEventHandler;

        /// <summary>
        /// 更新参数的
        /// </summary>
        public static void UpdateGlobal()
        {
            UpdateEventHandler?.Invoke();
        }


     
    } 
}
