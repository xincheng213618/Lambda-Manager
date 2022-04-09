using Global.Mode.Config;
using Lambda;
using Mode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Global
{
    public delegate void UpdateEventHandler(Object object1);

    public static class Update
    {
        public static event UpdateEventHandler UpdateEventHandler;
        public static void UpdateMulDimensional(MulDimensional mulDimensional)
        {           
            UpdateEventHandler?.Invoke(mulDimensional);
        }
        public static void UpdateSTAGE(STAGE sTAGE)
        {
            UpdateEventHandler?.Invoke(sTAGE);
        }
        
    } 

    public class WindowStatus
    {
        private static WindowStatus instance;
        private static readonly object locker = new();

        public static WindowStatus GetInstance()
        {
            lock (locker)
            {
                // 如果类的实例不存在则创建，否则直接返回  
                if (instance == null)
                {
                    instance = new WindowStatus();
                }
            }
            return instance;
        }
        private WindowStatus()
        {
            LambdaControl.CallEventHandler += Call;
            Update.UpdateEventHandler += Call1;
        }

        public MulDimensional mulDimensional = new MulDimensional();
        public STAGE STAGE = new STAGE() { XYStep =1000,ZStep=1000};
        public Config Config = new();

        private void Call1(Object object1)
        {
            if (object1 is MulDimensional mulDimensional)
                this.mulDimensional = mulDimensional;
            if (object1 is STAGE sTAGE)
                this.STAGE = sTAGE; 

        }
        private int Call(string type, object sender, EventArgs e)
        {
            if(type == "STOP_ALIVE")
            {
                ALIVE = false;
            }
            if (type == "START_ALIVE")
            {
                ALIVE = true;
            }
            if (type == "STOP_ACQUIRE")
            {
                ACQUIRE = true;
            }
            if (type == "START_ACQUIRE")
            {
                ACQUIRE = false;
            }
            return 1;
        }

        private bool aCQUIRE= false;

        public bool ACQUIRE
        {
            get { return aCQUIRE; }
            set { aCQUIRE = value; }
        }


        private bool aLIVE=false;

        public bool ALIVE
        {
            get { return aLIVE; }
            set { aLIVE = value; }
        }

        



    }
}
