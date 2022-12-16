using System.Diagnostics;
using System.Windows;
using System.Xml.Linq;

namespace Global.SettingUp.PC
{
    public class PerformanceCounterHelper
    {
        private static PerformanceCounterHelper _instance;
        private static readonly object _lock = new();
        public static PerformanceCounterHelper GetInstance() { lock (_lock) { return _instance ??= new PerformanceCounterHelper(); } }

        private PerformanceCounterHelper() => new Thread(() => Run()) { IsBackground = true }.Start();

        public void Run()
        {
            try
            {
                ProcessThis = new PerformanceCounter("Process", "% Processor Time", Process.GetCurrentProcess().ProcessName);
                RAM = new PerformanceCounter("Memory", "Available MBytes");

                RAMThis = new PerformanceCounter("Process", "Working Set - Private", Process.GetCurrentProcess().ProcessName);
                DiskUse = new PerformanceCounter("PhysicalDisk", "% Idle Time", "_Total");
                CPU = new PerformanceCounter("Processor", "% Processor Time", "_Total");
                IsOpen = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                //https://stackoverflow.com/questions/17980178/cannot-load-counter-name-data-because-an-invalid-index-exception
                IsOpen = false;
            }

        }

        public bool IsOpen = false;

        public PerformanceCounter CPU;
        public PerformanceCounter ProcessThis;

        public double RAMAL =  (double)Common.NativeMethods.PerformanceInfo.GetTotalMemoryInMiB()/1024;
        public PerformanceCounter RAM;
        public PerformanceCounter RAMThis;

        public PerformanceCounter DiskUse;

    }

}
