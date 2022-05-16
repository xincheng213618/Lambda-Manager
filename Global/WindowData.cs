using Global.Hardware;
using Global.Mode;
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
        public DeviceInformation deviceInformation;

        public List<ObjectiveSetting> ObjectiveSettingList;


        private WindowData()
        {
            LambdaControl.CallEventHandler += Call;
            Hardware_Initialized();
            AddTest();
        }
        private void Hardware_Initialized()
        {
            if (File.Exists(Global.HardwareDeviceInformationSheet))
            {
                string HardwareDeviceInformation = Utils.LoadResource(Global.HardwareDeviceInformationSheet);
                if (!string.IsNullOrEmpty(HardwareDeviceInformation))
                {
                    deviceInformation = JsonConvert.DeserializeObject<DeviceInformation>(HardwareDeviceInformation);
                    ObjectiveSettingList = deviceInformation.ObjectiveSettingList;
                }
            }
            else
            {
                List<string>  strings = new List<string>();
                for (int i = 0; i < Global.expose.Count; i++)
                {
                    strings.Add($"1/{Global.expose[i]:0.######}");
                    Global.expose[i] = 1 / Global.expose[i];
                }
                Global.expose.AddRange(Global.expose1);
                strings.AddRange(Global.expose1.Select(x => x.ToString("0.######")).ToArray());

                deviceInformation = new DeviceInformation()
                {
                    ObjectiveSettingList = new() {
                        new ObjectiveSetting() { ID = 0, Name = "奥林巴斯", Magnitude = "4X", NA = 0.1, IsEnabled = false },
                        new ObjectiveSetting() { ID = 1, Name = "奥林巴斯", Magnitude = "10X", NA = 0.25, IsChecked = true },
                        new ObjectiveSetting() { ID = 2, Name = "奥林巴斯", Magnitude = "20X", NA = 0.4, IsEnabled = false },
                        new ObjectiveSetting() { ID = 3, Name = "奥林巴斯", Magnitude = "40X", NA = 0.65, IsEnabled = false },
                        new ObjectiveSetting() { ID = 4, Name = "奥林巴斯", Magnitude = "100X", NA = 0.65, IsEnabled = false },
                    },
                    CameraExpose = Global.expose,
                    CameraExposeShow = strings

                };
                deviceInformation.ToJsonFile(Global.HardwareDeviceInformationSheet);
                ObjectiveSettingList = deviceInformation.ObjectiveSettingList;
            }
        }
        public ViewWindow ViewWindow = new ViewWindow();
        public void AddTest()
        {
            LambdaControl.AddLambdaEventHandler("UPDATE_STATUS1", OnUpdateStatus, false);
        }

        public UpdateStatus updateStatus = new();

        private bool OnUpdateStatus(object sender, EventArgs e)
        {
            Dictionary<string, object>? eventData = LambdaArgs.GetEventData(e);
            if (eventData == null)
                return false;

            updateStatus.ImageX = GetStringValue(eventData, "x");
            updateStatus.ImageY = GetStringValue(eventData, "y");
            updateStatus.ImageZ = GetStringValue(eventData, "z");
            updateStatus.ImageSize = GetStringValue(eventData, "size");
            updateStatus.imageFocus = GetStringValue(eventData, "focus");
            updateStatus.CreateTime = GetStringValue(eventData, "createTime");
            string frameIndex = GetStringValue(eventData, "frameIndex");
            if (frameIndex != null)
            {
                updateStatus.FrameIndex = int.Parse(frameIndex);

            }

            string totalFrame = GetStringValue(eventData, "totalFrame");
            if (totalFrame != null)
            {
                try
                {
                    updateStatus.TotalFrame = int.Parse(totalFrame);
                }
                catch
                {
                    updateStatus.TotalFrame = 0;
                }
            }

            updateStatus.TimeElapsed = GetStringValue(eventData, "timeElapsed");
            updateStatus.TotalTime = GetStringValue(eventData, "totalTime");
            string sliceIndex = GetStringValue(eventData, "sliceIndex");
            if (sliceIndex != null)
            {
                updateStatus.SliceIndex = int.Parse(sliceIndex);
            }
            string totalSlice = GetStringValue(eventData, "totalSlice");
            if (totalSlice != null)
            {
                updateStatus.TotalSlice = int.Parse(totalSlice);
            }
            updateStatus.ZTop = GetStringValue(eventData, "zTop");
            updateStatus.ZCurrent = GetStringValue(eventData, "zCurrent");
            updateStatus.ZBottom = GetStringValue(eventData, "zBottom");
            updateStatus.Ratio = GetStringValue(eventData, "ratio");
            updateStatus.FpsState = GetStringValue(eventData, "fps");

            return true;
        }
        private static string? GetStringValue(Dictionary<string, object>? data, string key)
        {
            if (data == null)
            {
                return null;
            }
            if (data!.TryGetValue(key, out var value) && value is string str)
            {
                return str;
            }
            return null;
        }
        public string SolutionDir{
            get { return FilePath?[..(FilePath.LastIndexOf("\\") + 1)];     } 
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
            if (result.IsNullOrEmpty())
            {
                MessageBox.Show("未能加载项目文件。缺少根元素");
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
