using Global.Mode.Config;

namespace Global
{
    public delegate void UpdateEventHandler();
    public delegate void UpdateEventHandler1(Object object1);

    public static class Update
    {
        public static event UpdateEventHandler UpdateEventHandler;
        public static event UpdateEventHandler1 UpdateEventHandler1;

        public static void UpdateGlobal()
        {
            UpdateEventHandler?.Invoke();
        }


        public static void UpdateMulDimensional(MulDimensional mulDimensional)
        {
            UpdateEventHandler1?.Invoke(mulDimensional);
        }
        public static void UpdateSTAGE(STAGE sTAGE)
        {
            UpdateEventHandler1?.Invoke(sTAGE);
        }
        
    } 
}
