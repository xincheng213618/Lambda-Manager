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
using System.Text.Json.Nodes;
using System.Collections.Generic;
using System.Windows.Controls;
using Global.Setting.Mode;
using Global.UserControls.DrawVisual;
using Global.Common.MVVM;

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
        public static UpdateStatus updateStatus = WindowData.GetInstance().updateStatus;
        public ImageViewState ImageViewState = WindowData.GetInstance().ImageViewState;
        public MapModel mapModel = WindowData.GetInstance().mapModel;
        
       
        private WindowData1()
        {
           
            Interference();
            AddEventHandler();
            UIExtension();
            ToolBarTopAddEvent();
            ToolBarRightAddEvent();
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
        public string CurrentProjectPath;

        public MapModel mapModel = new MapModel();

        private WindowData()
        {
            
            SettingUp.Config.ConfigReadEvent += ReadConfig;
            SettingUp.Config.ConfigSetEvent += SetValue;
            SettingUp.Config.ConfigWriteEvent += SaveConfig;
            setting.otherMode.SnapMode =(int) SoftwareConfig.WindowSetting.PhotoOptions;
            setting.otherMode.InkMode = (int)SoftwareConfig.WindowSetting.DrawGraphicsOptions;

            SoftwareConfig.WindowSetting.PhotoOptionsChanged += (s) =>
            {
                setting.otherMode.SnapMode = (int)s;
            };
            SoftwareConfig.WindowSetting.DrawGraphicsOptionsChanged += (s) =>
            {
                if(setting.otherMode.InkMode == 2)
                {
                    SaveConfig(CurrentProjectPath);
                };

                setting.otherMode.InkMode = (int)s;
                WindowData1.AllInkStrokeClear();
                if (setting.otherMode.InkMode == 2)
                {
                    ReadConfig(CurrentProjectPath);
                    string json = JsonSerializer.Serialize(SolutionConfig.Visuals, new JsonSerializerOptions());
                    GalleryInk.VisualsDrawBack(json, DrawInkMethod.InkAll);
                }
                WriteDefaultConfig(DirectoryPath);


            };

            LambdaSettingUp.HardwareSettingConnectionEvent += CheckHardWareConnection;
            ReadDefaultConfig(DirectoryPath);
            Hardware_Initialized(ObjParaList,ObjList);
          
            
        }

        public string FilePath;
        public MulDimensional MulDimensional = new();
        public Stage Stage = new() {};
        public OperatingMode OperatingMode = new();
        public SolutionConfig SolutionConfig = new();
        public MulSummary mulSummary = new();
        public UpdateStatus updateStatus = new();
        public Settings setting = new Settings();

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
            WriteVisualOnInkMode(setting.otherMode.InkMode);
            SolutionConfig.ToJsonFile(ConfigFullName);
            if(ConfigFullName!= null)
            {
                SaveCustomConfig(ConfigFullName, ObjList);
            }
            WriteDefaultConfig(DirectoryPath);


        }
        public void SaveDefaultConfig(string path)
        {
            WriteDefaultConfig(path);

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
                CurrentProjectPath = ConfigFullName;
                JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions();
                jsonSerializerOptions.Converters.Add(new SolidColorBrushConverter());
                SolutionConfig = JsonSerializer.Deserialize<SolutionConfig>(result, jsonSerializerOptions);
                ReadVisualOnInkMode(setting.otherMode.InkMode);
                ReadCustomConfig(result, ObjList);
                IsAcquireShow();

            }
            catch (Exception ex)
            {
                MessageBox.Show("未能加载项目文件。" + ex.Message);
                return -3;
            }
            FilePath = ConfigFullName;
            return 0;
        }
        //事件预留，硬件实时检测
        private bool CheckHardWareConnection(object sender, EventArgs e)
        {
            if (SoftwareConfig.HardwareSetting.IsCameraConnection && SoftwareConfig.HardwareSetting.IsLightConnection && SoftwareConfig.HardwareSetting.IsStageConnection)
            {
                AcquireModule(true);
                return true;
            }
            else
            {
                AcquireModule(false);
                return false;
            }

        }
        public void IsAcquireShow()
        {
            
            if (setting.otherMode.DevelopMode == true)
            {
                AcquireModule(true);
            }
            else
            {
                if (SoftwareConfig.HardwareSetting.IsCameraConnection && SoftwareConfig.HardwareSetting.IsLightConnection && SoftwareConfig.HardwareSetting.IsStageConnection)
                {
                    AcquireModule(true);

                }
                else
                {
                    AcquireModule(false);
                }
            }

        }





        public void AcquireModule(bool IsConnect)
        {
            if (IsConnect)
            {
                Window mainwin = Application.Current.MainWindow;
                TabControl tabControl = (TabControl)mainwin.FindName("leftTab");
                TabItem tabItem = (TabItem)tabControl.Items[1];
                if (tabItem.Visibility == Visibility.Visible)
                {
                    return;
                }
                tabItem.Visibility = Visibility.Visible;
                tabControl.SelectedIndex = 1;


            }
            else
            {
                Window mainwin = Application.Current.MainWindow;
                TabControl tabControl = (TabControl)mainwin.FindName("leftTab");
                TabItem tabItem = (TabItem)tabControl.Items[1];
                tabItem.Visibility = Visibility.Collapsed;
                tabControl.SelectedIndex = 0;

            }


        }
      
        private void ReadVisualOnInkMode(int mode)
        {
            if (mode == 2)
            {
                DrawInkMethod.Visuals = WindowData.GetInstance().SolutionConfig.Visuals;
                string json = JsonSerializer.Serialize(SolutionConfig.Visuals, new JsonSerializerOptions());
                GalleryInk.VisualsDrawBack(json, DrawInkMethod.InkAll);

            }
            
        }

        private void WriteVisualOnInkMode(int mode)
        {
            if(mode == 2)
            {
                
                foreach (InkVisual ink in DrawInkMethod.InkAll)  //右键菜单导出前，刷新标记数据
                {
                    if (ink != null)
                    {
                        ink.StrokeToBackUpdate();
                    }

                }
                WindowData.GetInstance().SolutionConfig.Visuals = DrawInkMethod.Visuals;
            }
            
        }



    }
}
