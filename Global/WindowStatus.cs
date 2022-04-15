using Global.Mode.Config;
using Lambda;
using Mode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Global
{
    public delegate void UpdateEventHandler(Object object1);

    public static class Update
    {
        public static event UpdateEventHandler UpdateEventHandler;
        public static void UpdateMulDimensional(MulDimensional mulDimensional)
        {           
            UpdateEventHandler?.Invoke(mulDimensional);
        }
        public static void UpdateSTAGE(STAGE sTAGE)
        {
            UpdateEventHandler?.Invoke(sTAGE);
        }
        
    } 

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
        private WindowData()
        {
            LambdaControl.CallEventHandler += Call;
            Update.UpdateEventHandler += Call1;
        }
        public string FilePath;
        public MulDimensional MulDimensional = new();

        public STAGE STAGE = new STAGE() { MoveStep = new MoveStep() { XStep = 1000, ZStep = 1000 } };
        public Config Config = new();


        public void SetValue()
        {
            MulDimensional.ZStart = Config.Dimensional.ZstackWiseSerial.ZBegin;
            MulDimensional.Zstep = Config.Dimensional.ZstackWiseSerial.ZStep;
            MulDimensional.ZEnd = Config.Dimensional.ZstackWiseSerial.ZEnd;
        }

        public void SetClose()
        {
            Config.Dimensional.ZstackWiseSerial.ZBegin = MulDimensional.ZStart;
            Config.Dimensional.ZstackWiseSerial.ZStep = MulDimensional.Zstep;
            Config.Dimensional.ZstackWiseSerial.ZEnd = MulDimensional.ZEnd;

            Utils.ToJsonFile(Config, FilePath);
        }
        

        public int ReadConfig(string ConfigFileName)
        {
            string result = Global.Utils.LoadResource(ConfigFileName);
            if (!Global.Utils.IsNullOrEmpty(result))
            {
                if (File.Exists(ConfigFileName))
                {
                    Config = Global.Utils.FromJson<Config>(result);
                    if (Config != null)
                    {
                        return 0;
                    }

                }
            }
            if (Config == null)
            {
                Config = ConfigInitialized();
            }
            return 0;
        }

        private Config ConfigInitialized()
        {
            return new Config
            {
                Version = "1.0",
                Modules = new Modules
                {
                    LambdaManager = "1.0",
                    ConfigDpcMode = "1.0",
                    ConfigStage = "1.0",
                    ConfigSpot = "1.0",
                    ConfigDof = "1.0",
                    ConfigMultiDimensional = "1.0",
                    DpcAlgorithm = "1.0",
                },
                LambdaManager = new LambdaManager
                {
                    LatestClosed = new List<string>()
                        {
                            "C:\\Program Files\\NJUST-SCIL\\Lambda Manager\\Data\\上皮细胞观察组1.lmp",
                            "D:\\Data\\Images\\picture2.jpg"
                        },
                    DefaultDirectory = "D:\\Data\\",
                },

                FirmwareSetting = new FirmwareSetting
                {
                    ObjectiveSetting = new()
                    {
                        Magnitude = 20,
                        NA = 1.23
                    },
                    CameraSetting = new CameraSetting
                    {
                        VideoFormat = "RGB (1280*960)",
                        Fps = 15,
                        Brightness = 0,
                        Contrast = 0,
                        Hue = 0,
                        Saturation = 0,
                        Sharpness = 0,
                        Gamma = 1,
                        WhiteBalance = new WhiteBalance
                        {
                            Auto = false,
                            Mode = 0,
                            WhiteBalanceGreen = 64,
                            WhiteBalanceBlue = 77,
                            WhiteBalanceRed = 91,
                        },
                        gain = new Gain
                        {
                            Auto = false,
                            Value = 0.0,
                        },
                        Exposure = new Exposure
                        {
                            Auto = false,
                            Value = 0.0667,
                            AutoMax = 1,
                            AutoReference = 128,
                        },
                        Trigger = new ()
                        {
                            Enable = true,
                            Polarity = false,
                            Delay = 15.0
                        },
                        Denoise = false,
                        Strobe = false,
                        Source = new Source
                        {
                            FpgaVersion = 0.1,
                            MaxBright = 32,
                        }
                    }
                },
                LogFile = "D:\\Data\\上皮细胞观察组1.log",
            };
        }



        private void Call1(Object object1)
        {
            if (object1 is MulDimensional mulDimensional)
            {
                this.MulDimensional = mulDimensional;
            }
            if (object1 is STAGE sTAGE)
                this.STAGE = sTAGE; 

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

        private bool aCQUIRE= false;

        public bool ACQUIRE
        {
            get { return aCQUIRE; }
            set { aCQUIRE = value; }
        }


        private bool aLIVE=false;

        public bool ALIVE
        {
            get { return aLIVE; }
            set { aLIVE = value; }
        }

        



    }
}
