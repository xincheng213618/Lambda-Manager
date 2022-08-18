using Global.Common.Extensions;
using Global.Hardware;
using Global.Mode;
using Global.Mode.Config;
using Mode;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;

namespace Global
{

    public partial class WindowData
    {
        private static WindowData instance;
        private static readonly object locker = new();

        public static WindowData GetInstance()
        {
            lock (locker) { if (instance == null) { instance = new WindowData(); } }
            return instance;
        }

        public DeviceInformation deviceInformation = new DeviceInformation();
        public List<ObjectiveSetting> ObjectiveSettingList = new List<ObjectiveSetting>();
        public MapModel mapModel = new MapModel();

        private WindowData()
        {
            Common.Config.ConfigReadEvent += ReadConfig;
            Common.Config.ConfigSetEvent += SetValue;
            Common.Config.ConfigWriteEvent += SaveConfig;

            Hardware_Initialized();
            AddEventHandler();
            AddInjection();
            AddInjection1();
        }

        public string SolutionDir{
            get { return FilePath?[..(FilePath.LastIndexOf("\\") + 1)];     } 
        }

        public string FilePath;

        public MulDimensional MulDimensional = new();

        public WindowMsg WindowMsg = new WindowMsg();

        public Stage Stage = new() {};

        public ViewMode ViewMode = new();
        

        public Config Config = new();


        public void SetValue()
        {
            if (!ACQUIRE)
            {
                MulDimensional.ZStart = Config.Dimensional.ZstackWiseSerial.ZBegin;
                MulDimensional.Zstep = Config.Dimensional.ZstackWiseSerial.ZStep;
                MulDimensional.ZEnd = Config.Dimensional.ZstackWiseSerial.ZEnd;

                ViewMode.SetValue(Config.ViewMode);
                Stage.SetValue(Config.Stage);
                ImageViewState.SetValue(Config.ImageViewState);
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
            Config.Dimensional.ZstackWiseSerial.ZBegin = MulDimensional.ZStart;
            Config.Dimensional.ZstackWiseSerial.ZStep = MulDimensional.Zstep;
            Config.Dimensional.ZstackWiseSerial.ZEnd = MulDimensional.ZEnd;
            Config.ViewMode.SetValue(ViewMode);
            Config.Stage.SetValue(Stage);
            Config.ImageViewState.SetValue(ImageViewState);

            Config.LastOpenTime = DateTime.Now.ToString();

            Config.ToJsonFile(ConfigFullName);
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
                Config = JsonSerializer.Deserialize<Config>(result);
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
