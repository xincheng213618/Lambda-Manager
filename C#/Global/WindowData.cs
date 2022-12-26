using Global.Common.Converter.Json;
using Global.Common.Extensions;
using Global.Hardware;
using Global.Mode;
using Global.Mode.Config;
using System;
using System.IO;
using System.Text.Json;
using System.Windows;
using Global.Setting;
using Global.SettingUp;

namespace Global
{

    public partial class WindowData1
    {
        private static WindowData1 _instance;
        private static readonly object _locker = new();

        public static WindowData1 GetInstance()
        {
            lock (_locker) { _instance ??= new WindowData1(); }
            return _instance;
        }

        public MulDimensional MulDimensional = WindowData.GetInstance().MulDimensional;

       // public Stage Stage = WindowData.GetInstance().Stage;

        public OperatingMode OperatingMode = WindowData.GetInstance().OperatingMode;


        //public SolutionConfig SolutionConfig = WindowData.GetInstance().SolutionConfig;
        public MulSummary mulSummary = WindowData.GetInstance().mulSummary;
        public UpdateStatus updateStatus = WindowData.GetInstance().updateStatus;
        public ImageViewState ImageViewState = WindowData.GetInstance().ImageViewState;

        public MapModel mapModel = WindowData.GetInstance().mapModel;

        private WindowData1()
        {
            AddEventHandler();
            AddInjection();
            AddInjection1();
            GalleryInk.GalleryInking();
        }
    }




    public partial class WindowData
    {
        private static WindowData _instance;
        private static readonly object _locker = new();

        public static WindowData GetInstance()
        {
            lock (_locker) { _instance ??= new WindowData(); }
            return _instance;
        }

        public DeviceInformation deviceInformation = new DeviceInformation();
        public ExposureViewMode ExposureViewMode = new ExposureViewMode();

        public MapModel mapModel = new MapModel();

        private WindowData()
        {
            SettingUp.Config.ConfigReadEvent += ReadConfig;
            SettingUp.Config.ConfigSetEvent += SetValue;
            SettingUp.Config.ConfigWriteEvent += SaveConfig;
           
            SoftwareConfig.WindowSetting.PhotoOptionsChanged += (s) =>
            {
                MessageBox.Show(s.ToString1());
            };
            Hardware_Initialized();
        }

        public string FilePath;

        public MulDimensional MulDimensional = new();

        public Stage Stage = new() {};

        public OperatingMode OperatingMode = new();
        

        public SolutionConfig SolutionConfig = new();
        public MulSummary mulSummary = new();
        public UpdateStatus updateStatus = new();


        public void SetValue()
        {
            if (!ACQUIRE)
            {
                MulDimensional.ZStart = SolutionConfig.Dimensional.ZstackWiseSerial.ZBegin;
                MulDimensional.Zstep = SolutionConfig.Dimensional.ZstackWiseSerial.ZStep;
                MulDimensional.ZEnd = SolutionConfig.Dimensional.ZstackWiseSerial.ZEnd;

                OperatingMode.SetValue(SolutionConfig.OperatingMode);
                Stage.SetValue(SolutionConfig.Stage);
                ImageViewState.SetValue(SolutionConfig.ImageViewState);
                Update.UpdateGlobal();
            }
            else
            {
                MessageBox.Show("请先暂停采集模式，在对参数进行赋值");
            }

        }
        public ImageViewState ImageViewState = new ImageViewState();


        public void SaveConfig(string ConfigFullName)
        {
            SolutionConfig.Dimensional.ZstackWiseSerial.ZBegin = MulDimensional.ZStart;
            SolutionConfig.Dimensional.ZstackWiseSerial.ZStep = MulDimensional.Zstep;
            SolutionConfig.Dimensional.ZstackWiseSerial.ZEnd = MulDimensional.ZEnd;
            SolutionConfig.OperatingMode.SetValue(OperatingMode);
            SolutionConfig.Stage.SetValue(Stage);
            SolutionConfig.ImageViewState.SetValue(ImageViewState);
            SolutionConfig.LastOpenTime = DateTime.Now.ToString();
            SolutionConfig.Dimensional.Saveprefix = ConfigFullName;
            SolutionConfig.ToJsonFile(ConfigFullName);
        }


      





        /// <summary>
        /// 读取配置文件
        /// </summary>
        /// <returns></returns>
        public int ReadConfig(string ConfigFullName)
        {

            if (!File.Exists(ConfigFullName))
            {
                MessageBox.Show("找不到工程文件。");
                return -1;
            }
            string result = File.ReadAllText(ConfigFullName);
            if (result==null)
            {
                MessageBox.Show("未能加载项目文件。缺少根元素");
                return -2;
            }

            try
            {
                JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions();
                jsonSerializerOptions.Converters.Add(new SolidColorBrushConverter());
                SolutionConfig = JsonSerializer.Deserialize<SolutionConfig>(result, jsonSerializerOptions);
            }
            catch (Exception ex)
            {
                MessageBox.Show("未能加载项目文件。" + ex.Message);
                return -3;
            }
            FilePath = ConfigFullName;
            return 0;
        }
    }
}
