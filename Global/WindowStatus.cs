using Global.Mode.Config;
using Lambda;
using Mode;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Global
{

    public class WindowData
    {
        private static WindowData instance;
        private static readonly object locker = new();

        public static WindowData GetInstance()
        {
            lock (locker)
            {
                // 如果类的实例不存在则创建，否则直接返回  
                if (instance == null)
                {
                    instance = new WindowData();
                }
            }
            return instance;
        }
        public List<ObjectiveSetting> ObjectiveSettingList = new()
        {
            new ObjectiveSetting (){ID = 0, Name ="奥林巴斯",Magnitude="4X", NA=0.1, IsEnabled =false},
            new ObjectiveSetting (){ID = 1, Name ="奥林巴斯",Magnitude="10X", NA=0.25,IsChecked=true},
            new ObjectiveSetting (){ID = 2, Name ="奥林巴斯",Magnitude="20X", NA=0.4, IsEnabled =false},
            new ObjectiveSetting (){ID = 3, Name ="奥林巴斯",Magnitude="40X", NA=0.65, IsEnabled =false},
            new ObjectiveSetting (){ID = 4, Name ="奥林巴斯",Magnitude="100X", NA=0.65, IsEnabled =false},
        };
        private WindowData()
        {
            LambdaControl.CallEventHandler += Call;
        }

        public string SolutionDir { get
            {
                if (FilePath != null)
                {
                    return FilePath[..(FilePath.LastIndexOf("\\") + 1)];
                }
                return null;    
            } 
        }
        public string FilePath;

        public MulDimensional MulDimensional = new();

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
        
        public int ReadConfig(string ConfigFileName)
        {
            if (!File.Exists(ConfigFileName))
            {
                MessageBox.Show("找不到工程文件。");
                return -1;
            }

            string result = Utils.LoadResource(ConfigFileName);
            if (Utils.IsNullOrEmpty(result))
            {
                MessageBox.Show("未能加载项目文件。 缺少根元素");
                return -1;
            }
 
            try
            {
                Config = JsonConvert.DeserializeObject<Config>(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show("未能加载项目文件。" + ex.Message);
                return -1;
            }
            return 0;
        }

        private Config ConfigInitialized()
        {
            return new Config
            {
                Version = "1.0",
                Modules = new Modules(),
                LambdaManager = new LambdaManager
                {
                    LatestClosed = new List<string>()
                    {
                        "C:\\Program Files\\NJUST-SCIL\\Lambda Manager\\Data\\上皮细胞观察组1.lmp",
                        "D:\\Data\\Images\\picture2.jpg"
                    },
                    DefaultDirectory = "D:\\Data\\",
                },
                FirmwareSetting = new Firmware
                {
                    Source = new(),
                    CameraSetting = new ()
                    {
                        VideoFormat = "RGB (1280*960)",
                        Fps = 15,
                        Brightness = 0,
                        Contrast = 0,
                        Hue = 0,
                        Saturation = 0,
                        Sharpness = 0,
                        Gamma = 1,
                        WhiteBalance = new ()
                        {
                            Auto = false,
                            Mode = 0,
                            WhiteBalanceGreen = 64,
                            WhiteBalanceBlue = 77,
                            WhiteBalanceRed = 91,
                        },
                        Trigger = new ()
                        {
                            Enable = true,
                            Polarity = false,
                            Delay = 15.0
                        },
                        Denoise = false,
                        Strobe = false
                    }
                },
                LogFile = "D:\\Data\\上皮细胞观察组1.log",
            };
        }




        private int Call(string type, object sender, EventArgs e)
        {
            if(type == "STOP_ALIVE")
                ALIVE = false;

            if (type == "START_ALIVE")
                ALIVE = true;

            if (type == "STOP_ACQUIRE")
                ACQUIRE = true;

            if (type == "START_ACQUIRE")
                ACQUIRE = false;

            return 1;
        }


        public bool ACQUIRE { get; set; } = false;
        public bool ALIVE { get; set; } = false;

    }
}
