using GLobal.Mode.Config;
using Lambda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Global
{
    public delegate void UpdateEventHandler(MulDimensional mulDimensional);

    public static class Update
    {
        public static event UpdateEventHandler UpdateEventHandler;
        public static void UpdateMulDimensional(MulDimensional mulDimensional)
        {
            UpdateEventHandler?.Invoke(mulDimensional);
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
        private void Call1(MulDimensional mulDimensional)
        {
            this.mulDimensional = mulDimensional;
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
