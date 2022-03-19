using Mode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaManager
{
    public class Global
    {
        private static Global instance;
        private static readonly object locker = new object();

        public static Global GetInstance()
        {
            lock (locker)
            {
                // 如果类的实例不存在则创建，否则直接返回
                if (instance == null)
                {
                    instance = new Global();
                }
            }
            return instance;
        }
        public UpdateStatus updateStatus = new UpdateStatus();


    }
}
