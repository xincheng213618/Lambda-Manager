using Global.Mode.Config;

namespace Global
{
    public delegate void UpdateEventHandler();

    public static class Update
    {
        public static event UpdateEventHandler UpdateEventHandler;

        public static void UpdateGlobal()
        {
            UpdateEventHandler?.Invoke();
        }     
    } 
}
