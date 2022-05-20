using Global.Extensions;
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
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

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
        public void AddTest()
        {
            LambdaControl.AddLambdaEventHandler("UPDATE_STATUS1", OnUpdateStatus, false);
            LambdaControl.AddLambdaEventHandler("UPDATE_WINDOWSTATUS", OnUpdateWindowStatus, false);
        }
        private ContextMenu MenuItemAdd(ContextMenu contextMenu, int a,int check)
        {
            MenuItem1 menuItem1 = new MenuItem1() { Header = "明场" };
            MenuItem1 menuItem2 = new MenuItem1() { Header = "暗场" };
            MenuItem1 menuItem3 = new MenuItem1() { Header = "莱茵伯格" };
            MenuItem1 menuItem4 = new MenuItem1() { Header = "相差" };
            MenuItem1 menuItem5 = new MenuItem1() { Header = "差分" };
            MenuItem1 menuItem6 = new MenuItem1() { Header = "定量相位" };
            List<MenuItem1> menuItem1s = new List<MenuItem1> { menuItem1, menuItem2, menuItem3, menuItem4, menuItem5, menuItem6 };
            for (int i = 0; i < menuItem1s.Count; i++)
            {
                if (check == i)
                    menuItem1s[i].IsChecked = true;
            }

            menuItem1.Click += delegate
            {
                menuItem1.IsChecked = true;
                LambdaControl.Trigger("VIEW_WINDOW", this, new Dictionary<string, object>() { { "window", a }, { "mode", 0 } });
            };
            menuItem2.Click += delegate
            {
                menuItem2.IsChecked = true;
                LambdaControl.Trigger("VIEW_WINDOW", this, new Dictionary<string, object>() { { "window", a }, { "mode", 1 } });

            };

            menuItem3.Click += delegate
            {
                menuItem3.IsChecked = true;
                LambdaControl.Trigger("VIEW_WINDOW", this, new Dictionary<string, object>() { { "window", a }, { "mode", 2 } });

            };
            menuItem4.Click += delegate
            {
                menuItem4.IsChecked = true;
                LambdaControl.Trigger("VIEW_WINDOW", this, new Dictionary<string, object>() { { "window", a }, { "mode", 3 } });
            };
            menuItem5.Click += delegate
            {
                menuItem5.IsChecked = true;
                LambdaControl.Trigger("VIEW_WINDOW", this, new Dictionary<string, object>() { { "window", a }, { "mode", 4 } });
            };
            menuItem6.Click += delegate
            {
                menuItem6.IsChecked = true;    
                LambdaControl.Trigger("VIEW_WINDOW", this, new Dictionary<string, object>() { { "window", a }, { "mode", 5 } });

            };

            for (int i = 0; i < menuItem1s.Count; i++)
            {
                contextMenu.Items.Add(menuItem1s[i]);
            }
            return contextMenu;
        }

        private  void AddImageContextMenu(int a,int check)
        {
            Image image = LambdaControl.GetImageView(a).Image;
            if (image != null) {
                ContextMenu menu = new ContextMenu();
                menu= MenuItemAdd(menu, a, check);
                image.ContextMenu = menu;
            }
        }

       
        private async void asyncAdd(List<int> ints)
        {
            for (int i = 1; i < ints.Count; i++)
            {
                await Task.Delay(800);
                AddImageContextMenu(i, ints[i]);
            }
        }


        private  bool OnUpdateWindowStatus(object sender, EventArgs e)
        {
            Dictionary<string, object>? eventData = LambdaArgs.GetEventData(e);
            if (eventData == null)
                return false;

            updateStatus.Window = GetStringValue(eventData, "windowstatus");

            int i = updateStatus.Window.Length;
            List<int> ints = new List<int> { };
            for (int j = 0; j < updateStatus.Window.Length; j++)
            {
                ints.Add(int.Parse(updateStatus.Window.Substring(j, 1)));
            }

            asyncAdd(ints);
            //if (i == 6)
            //{
            //    AddImageContextMenu(1, ints[1]);
            //    AddImageContextMenu(2, ints[2]);
            //    AddImageContextMenu(3, ints[3]);
            //    AddImageContextMenu(4, ints[4]);
            //    AddImageContextMenu(5, ints[5]);

            //}
            //else if (i == 4)
            //{
            //    AddImageContextMenu(0, ints[0]);
            //    AddImageContextMenu(1, ints[1]);
            //    AddImageContextMenu(2, ints[2]);
            //    AddImageContextMenu(3, ints[3]);
            //}
            //else
            //{
            //    AddImageContextMenu(0, ints[0]);
            //}
            return true;

        }

        public void Test()
        {
            Image image = LambdaControl.GetImageView(0).Image;
            if (image.Parent is Grid grid)
            {
                Canvas canvas1 = new Canvas()
                {
                    Width= grid.ActualWidth,
                    Height =grid.ActualHeight,
                    //Background = new SolidColorBrush(Color.FromRgb(195, 195, 195)),
                    Background = Brushes.Black,
                    ClipToBounds = true
                };

                grid.Children.Remove(image);
                canvas1.Children.Add(image);
                grid.Children.Add(canvas1);
            }

            if (image.Parent is Canvas canvas)
            {
                TransformGroup transformGroup = new();
                TranslateTransform tlt = new();
                ScaleTransform sfr = new();
                transformGroup.Children.Add(sfr);
                transformGroup.Children.Add(tlt);
                image.RenderTransform = transformGroup;
                image.MouseWheel += delegate (object sender, MouseWheelEventArgs e)
                {
                    Point centerPoint = e.GetPosition(canvas);
                    if (sfr.ScaleX < 0.2 && sfr.ScaleY < 0.2 && e.Delta < 0)
                    {
                        return;
                    }
                    sfr.CenterX = centerPoint.X;
                    sfr.CenterY = centerPoint.Y;
                    sfr.ScaleX += (double)e.Delta / 3500;
                    sfr.ScaleY += (double)e.Delta / 3500;
                };
                bool isMouseLeftButtonDown = false;
                Point mouseXY;
                image.MouseLeftButtonDown += delegate (object sender, MouseButtonEventArgs e)
                {
                    isMouseLeftButtonDown = true;
                    mouseXY = e.GetPosition(image);
                };
                image.MouseLeftButtonUp += delegate (object sender, MouseButtonEventArgs e)
                {
                    isMouseLeftButtonDown = false;
                };
                image.MouseMove += delegate (object sender, MouseEventArgs e)
                {
                    if (isMouseLeftButtonDown == true)
                    {
                        Point position = e.GetPosition(image);
                        tlt.X += position.X - mouseXY.X;
                        tlt.Y += position.Y - mouseXY.Y;
                    }
                };
            }

        }


        public UpdateStatus updateStatus = new();

        private bool OnUpdateStatus(object sender, EventArgs e)
        {
            Dictionary<string, object>? eventData = LambdaArgs.GetEventData(e);
            if (eventData == null)
                return false;
            updateStatus.ImageX = GetStringValue(eventData, "x");
            WindowMsg.StageX = int.Parse(updateStatus.ImageX[2..]);
            updateStatus.ImageY = GetStringValue(eventData, "y");
            WindowMsg.StageY = int.Parse(updateStatus.ImageY[2..]);
            updateStatus.ImageZ = GetStringValue(eventData, "z");
            WindowMsg.StageZ = int.Parse(updateStatus.ImageZ[2..]);

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

    public class MenuItem1 : MenuItem
    {
        public MenuItem1()
        {
            this.Checked += Checked1;
        }
        private void Checked1(object sender, RoutedEventArgs e)
        {
            if (this.Parent is ContextMenu menuItem)
            {
                foreach (var item in menuItem.Items)
                {
                    if (item != this && item is MenuItem menu)
                    {
                        if (menu.IsChecked == true)
                            menu.IsChecked = false;

                    }
                }
            }
        }
    }
}
