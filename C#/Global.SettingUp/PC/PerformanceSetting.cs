using Global.Common;

namespace Global.SettingUp.PC
{
    public class PerformanceSetting : ViewModelBase, IDisposable
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
                    timer?.Dispose();
                    timer = new Timer(TimeRun, null, 0, UpdateSpeed);
                }
            }
        }


        public PerformanceSetting()
        {
            PerformanceCounterHelper = PerformanceCounterHelper.GetInstance();
            timer = new Timer(TimeRun, null, 0, UpdateSpeed);
            CurrentDrive = System.IO.DriveInfo.GetDrives()[0];
            CurrentDiskTotalSize = (CurrentDrive.TotalSize / (1024 * 1024 * 1024)).ToString() + "GB";
            OSInfo = Environment.OSVersion.Version.Build >= 22000? Environment.OSVersion.ToString().Replace("10.","11."): Environment.OSVersion.ToString() +" "+ (Environment.Is64BitOperatingSystem?"64-bit": "32-bit");
        }

        private void TimeRun(object state)
        {
            if (PerformanceCounterHelper.IsOpen)
            {
                MemorytThis = (PerformanceCounterHelper.RAMThis.NextValue() / 1024 / 1024).ToString("f1") + "MB" + "/" + PerformanceCounterHelper.RAMAL.ToString("f1") + "GB";
                ProcessorTotal = PerformanceCounterHelper.CPU.NextValue().ToString("f1") + "%";
                //ProcessorTotal = PerformanceCounterHelper.ProcessThis.NextValue().ToString("f1") + "%" + "/" + PerformanceCounterHelper.CPU.NextValue().ToString("f1") + "%";
                MemoryAvailable = (PerformanceCounterHelper.RAMAL - PerformanceCounterHelper.RAM.NextValue() / 1024).ToString("f1") + "/" + PerformanceCounterHelper.RAMAL.ToString("f1") + "GB";

                DiskUse = (CurrentDrive.TotalFreeSpace / (1024 * 1024 * 1024)).ToString() + "GB";
                IsDiskLackWarning = CurrentDrive.TotalFreeSpace < 107374182400;
                IsMemoryLackWarning = PerformanceCounterHelper.RAMAL - PerformanceCounterHelper.RAM.NextValue() / 1024 > 4;
            }
        }
        public string OSInfo { get; set; }

        public DriveInfo currentDrive = null;
        public DriveInfo CurrentDrive
        {
            get { return currentDrive; }
            set
            {
                currentDrive = value; NotifyPropertyChanged();
            }
        }

        public string CurrentDiskTotalSize { get; set; }

        private bool _IsDiskLackWarning =false;
        public bool IsDiskLackWarning 
        {
            get => _IsDiskLackWarning;
            set 
            { 
                _IsDiskLackWarning = value;
                NotifyPropertyChanged();
            }
        }


        private bool _IsMemoryLackWarning = false;
        public bool IsMemoryLackWarning
        {
            get => _IsMemoryLackWarning;
            set
            {
                _IsMemoryLackWarning = value;
                NotifyPropertyChanged();
            }
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


        private string memoryThis = String.Empty;
        /// <summary>
        /// 当前内存
        /// </summary>
        public string MemorytThis
        {
            get { return memoryThis; }
            set
            {
                if (value != null && value != memoryThis)
                    memoryThis = value; NotifyPropertyChanged();
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

        public void Dispose()
        {
            timer.Dispose();
        }
    }

}
