using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace LambdaManager.Mode
{
    public class PerformanceCounterHelper
    {
        private static PerformanceCounterHelper _instance = null;
        private static readonly object _lock = new object();
        public static PerformanceCounterHelper GetInstance()
        {
            lock (_lock) { if (_instance == null) _instance = new PerformanceCounterHelper(); }
            return _instance;
        }
        private PerformanceCounterHelper()
        {
            Thread thread = new Thread(() => Run())
            {
                IsBackground = true
            };
            thread.Start();
        }
        public void Run()
        {
            CPU = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            ProcessThis = new PerformanceCounter("Process", "% Processor Time", Process.GetCurrentProcess().ProcessName);
            RAM = new PerformanceCounter("Memory", "Available MBytes");
            DiskUse = new PerformanceCounter("PhysicalDisk", "% Idle Time", "_Total");
            IsOpen = true;
        }

        public bool IsOpen = false;

        public PerformanceCounter CPU;
        public PerformanceCounter ProcessThis;

        public double RAMAL = 16000000 / 1024 / 1024;
        public PerformanceCounter RAM;
        public PerformanceCounter DiskUse;

    }

    public class StatusBarGlobal : ViewModelBase, IDisposable
    {
        private Timer timer;
        private PerformanceCounterHelper PerformanceCounterHelper;

        public int updateSpeed = 1000;
        public int UpdateSpeed
        {
            get { return updateSpeed; }
            set
            {
                if (value != updateSpeed)
                {
                    updateSpeed = value; NotifyPropertyChanged();
                    if (timer != null)
                        timer.Dispose();
                    timer = new Timer(TimeRun, null, 0, UpdateSpeed);
                }
            }
        }


        public StatusBarGlobal()
        {
            PerformanceCounterHelper = PerformanceCounterHelper.GetInstance();
            timer = new Timer(TimeRun, null, 0, UpdateSpeed);
        }

        private void TimeRun(object state)
        {
            if (PerformanceCounterHelper.IsOpen)
            {
                ProcessorTotal = PerformanceCounterHelper.ProcessThis.NextValue().ToString("f1") + "%" + "/" + PerformanceCounterHelper.CPU.NextValue().ToString("f1") + "%";
                MemoryAvailable = (PerformanceCounterHelper.RAMAL - PerformanceCounterHelper.RAM.NextValue() / 1024).ToString("f1") + "/" + PerformanceCounterHelper.RAMAL.ToString("f1") + "GB";
                DiskUse = (100 - PerformanceCounterHelper.DiskUse.NextValue()).ToString("f1") + "%";
            }
        }

        public void Dispose()
        {
            timer.Dispose();
        }



        private string processorTotal = String.Empty;
        /// <summary>
        /// 总处理器占用
        /// </summary>
        public string ProcessorTotal
        {
            get { return processorTotal; }
            set
            {
                if (value != null && value != processorTotal)
                    processorTotal = value; NotifyPropertyChanged();
            }
        }

        private string memoryAvailable = String.Empty;
        /// <summary>
        /// 内存获取
        /// </summary>
        public string MemoryAvailable
        {
            get { return memoryAvailable; }
            set
            {
                if (value != null && value != memoryAvailable)
                    memoryAvailable = value; NotifyPropertyChanged();
            }
        }

        private string diskUse = String.Empty;
        /// <summary>
        /// 硬盘使用
        /// </summary>
        public string DiskUse
        {
            get { return diskUse; }
            set
            {
                if (value != null && value != diskUse)
                    diskUse = value; NotifyPropertyChanged();
            }
        }


    }

}
