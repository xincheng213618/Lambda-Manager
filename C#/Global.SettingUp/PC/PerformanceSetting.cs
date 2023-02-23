using Global.Common;

namespace Global.SettingUp.PC
{
    public class PerformanceSetting : ViewModelReg
    {
        private Timer timer;
        private PerformanceCounterHelper PerformanceCounterHelper;
        public int UpdateSpeed
        {
            get => _UpdateSpeed; set
            {
                if (value != _UpdateSpeed)
                {
                    _UpdateSpeed = value; NotifyPropertyChanged();
                    timer?.Dispose();
                    timer = new Timer(TimeRun, null, 0, value);
                }
            }    
        }
        public int _UpdateSpeed = 1000;


        public PerformanceSetting()
        {
            PerformanceCounterHelper = PerformanceCounterHelper.GetInstance();
            timer = new Timer(TimeRun, null, 0, UpdateSpeed);
            CurrentDrive = DriveInfo.GetDrives()[0];
            OSInfo = Environment.OSVersion.Version.Build >= 22000 ? Environment.OSVersion.ToString().Replace("10.", "11.") : Environment.OSVersion.ToString() + " " + (Environment.Is64BitOperatingSystem ? "64-bit" : "32-bit");
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
                IsMemoryLackWarning = PerformanceCounterHelper.RAMAL - PerformanceCounterHelper.RAM.NextValue() / 1024 < 4;
            }
        }
        public string OSInfo { get; set; }

        public DriveInfo CurrentDrive
        {
            get { return _CurrentDrive; }
            set
            {
                _CurrentDrive = value; NotifyPropertyChanged();
                CurrentDiskTotalSize = (CurrentDrive.TotalSize / (1024 * 1024 * 1024)).ToString() + "GB";
                DiskUse = (CurrentDrive.TotalFreeSpace / (1024 * 1024 * 1024)).ToString() + "GB";
            }
        }
        private DriveInfo _CurrentDrive = null;

        /// <summary>
        /// 当前分区硬盘大小
        /// </summary>
        public string CurrentDiskTotalSize { get => _CurrentDiskTotalSize; set { _CurrentDiskTotalSize = value; NotifyPropertyChanged(); } }
        private string _CurrentDiskTotalSize = string.Empty;

        /// <summary>
        /// 是否显示硬盘不足警告
        /// </summary>
        public bool IsDiskLackWarning { get => _IsDiskLackWarning; set { _IsDiskLackWarning = value; NotifyPropertyChanged(); } }
        private bool _IsDiskLackWarning = false;

        /// <summary>
        /// 是否显示硬盘不足警告
        /// </summary>
        public bool IsShowDiskLackWarning { get => _IsShowDiskLackWarning; set { _IsShowDiskLackWarning = value; WriteRegValue(false, nameof(IsShowDiskLackWarning)); NotifyPropertyChanged(); } }
        private bool _IsShowDiskLackWarning = ReadRegValue(nameof(IsShowDiskLackWarning));

        /// <summary>
        /// 是否显示内存不足警告
        /// </summary>
        public bool IsMemoryLackWarning { get => _IsMemoryLackWarning; set { _IsMemoryLackWarning = value; NotifyPropertyChanged(); } }
        private bool _IsMemoryLackWarning = false;

        /// <summary>
        /// 总处理器占用
        /// </summary>
        public string ProcessorTotal { get => _ProcessorTotal; set { _ProcessorTotal = value; NotifyPropertyChanged(); } }
        private string _ProcessorTotal = String.Empty;


        /// <summary>
        /// 内存获取
        /// </summary>
        public string MemoryAvailable { get => _MemoryAvailable; set { _MemoryAvailable = value; NotifyPropertyChanged(); } }
        private string _MemoryAvailable = String.Empty;

        /// <summary>
        /// 当前软件占用内存
        /// </summary>
        public string MemorytThis { get => _MemorytThis; set { _MemorytThis = value; NotifyPropertyChanged(); } }
        private string _MemorytThis = String.Empty;

        /// <summary>
        /// 硬盘使用
        /// </summary>
        public string DiskUse { get => _DiskUse;set { _DiskUse = value; NotifyPropertyChanged(); }}
        private string _DiskUse = String.Empty;
    }

}
