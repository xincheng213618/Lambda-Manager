using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using WpfApp3.Mode;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public Config config;

        private void Window_Initialized(object sender, EventArgs e)
        {
            LoadConfig(ref config);
            Utils.ToJsonFile(config, "config.json");
        }


        /// <summary>
        /// 载入配置文件
        /// </summary>
        /// <param name="config"></param>
        /// <returns></returns>
        public static int LoadConfig(ref Config config)
        {
            //载入配置文件 
            string result = Utils.LoadResource("config.json");
            if (!Utils.IsNullOrEmpty(result))
            {
                //转成Json
                config = Utils.FromJson<Config>(result);
            }
            else
            {
                if (File.Exists("config.json"))
                {
                    return -1;
                }
            }

            if (config == null)
            {
                config = new Config
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

                    FirmwareSetting =new FirmwareSetting
                    {
                        ObjectiveSetting = new ObjectiveSetting
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
                            Gamma =1,
                            WhiteBalance = new WhiteBalance
                            {
                                Auto = false,
                                Mode =0,
                                WhiteBalanceGreen = 64,
                                WhiteBalanceBlue = 77,
                                WhiteBalanceRed = 91,
                            },
                            gain = new Gain
                            {
                                Auto = false,
                                Value =0.0,
                            },
                            Exposure = new Exposure
                            {
                                 Auto = false,
                                 Value =0.0667,
                                 AutoMax =1,
                                 AutoReference =128,
                            },
                            Trigger = new WpfApp3.Mode.Trigger
                            {
                                Enable = true,
                                Polarity = false,
                                Delay = 15.0
                            },
                            Denoise =false,
                            Strobe = false,
                            Source = new Source
                            {
                                FpgaVersion =0.1,
                                MaxBright=32,
                            }
                        }
                    },
                    LogFile = "D:\\Data\\上皮细胞观察组1.log",
                };
            }
            return 0;
        }


    }
}
