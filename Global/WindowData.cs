using Global.Hardware;
using Global.Mode;
using Global.Mode.Config;
using Lambda;
using Mode;
using Newtonsoft.Json;
using System.Runtime.ExceptionServices;
using System.Windows;
using System.Windows.Threading;

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

        public DeviceInformation deviceInformation;
        public List<ObjectiveSetting> ObjectiveSettingList;
        public StageTest StageTest = new StageTest();

        private WindowData()
        {
            //LambdaControl.Initialize(null, null, null, Call, null, null);
            Hardware_Initialized();
            AddEventHandler();

            //code to wipe ass
            AddInjection();
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

                Update.UpdateGlobal();
            }
            else
            {
                MessageBox.Show("请先暂停采集模式，在对参数进行赋值");
            }

        }

        public void SaveConfig()
        {
            Config.Dimensional.ZstackWiseSerial.ZBegin = MulDimensional.ZStart;
            Config.Dimensional.ZstackWiseSerial.ZStep = MulDimensional.Zstep;
            Config.Dimensional.ZstackWiseSerial.ZEnd = MulDimensional.ZEnd;

            Config.ViewMode.SetValue(ViewMode);
            Config.Stage.SetValue(Stage);
            Utils.ToJsonFile(Config, FilePath);
        }
        
        /// <summary>
        /// 读取配置文件
        /// </summary>
        /// <returns></returns>
        public int ReadConfig(string ConfigFileName)
        {
            if (!File.Exists(ConfigFileName))
            {
                MessageBox.Show("找不到工程文件。");
                return -1;
            }

            string result = Utils.LoadResource(ConfigFileName);
            if (result.IsNullOrEmpty())
            {
                MessageBox.Show("未能加载项目文件。缺少根元素");
                return -2;
            }
 
            try
            {
                Config = JsonConvert.DeserializeObject<Config>(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show("未能加载项目文件。" + ex.Message);
                return -3;
            }
            return 0;
        }
    }
}
