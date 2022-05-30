﻿using Global.Extensions;
using Global.Hardware;
using Global.Mode;
using Global.Mode.Config;
using Lambda;
using Mode;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

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
            //Application.DispatcherUnhandledException += App_DispatcherUnhandledException;
            //AppDomain.CurrentDomain.FirstChanceException += App_FirstChanceException;
            //AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            LambdaControl.Initialize(null, null, null, Call, null, null);
            //LambdaControl.CallEventHandler += Call;
            Hardware_Initialized();
            AddEventHandler();
            AddInjection();
        }

        private void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            //Log.WriteException(e.ExceptionObject as Exception);
        }
        private void App_DispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            if (e.Exception.GetType() != typeof(StackOverflowException))
            {
                e.Handled = true;
            }
            else
            {
                Application.Current.Shutdown();
            }
        }
        private void Log( string Text)
        {
            LambdaControl.Log( new Message { Severity =Severity.INFO,Text = Text });
        }

        private void App_FirstChanceException(object sender, FirstChanceExceptionEventArgs e)
        {
            Log(e.Exception.Message);
        }

        private void AddInjection()
        {
            Window mainwin = Application.Current.MainWindow;
            try
            {
                WrapPanel WrapPanel1 = (WrapPanel)mainwin.FindName("rightToolbar");
                if (WrapPanel1 == null)
                    return;
                ToggleButton buttton1 = (ToggleButton)WrapPanel1.Children[0];

                ContextMenu contextMenu = new ContextMenu();
                MenuItem menuItem1 = new MenuItem() { Header = "一" };
                menuItem1.Click += delegate
                {
                    LambdaControl.Trigger("QUATER_CLICKED1", mainwin, new EventArgs());
                };
                MenuItem menuItem2 = new MenuItem() { Header = "四" };
                menuItem2.Click += delegate
                {
                    LambdaControl.Trigger("QUATER_CLICKED2", mainwin, new EventArgs());
                };

                MenuItem menuItem3 = new MenuItem() { Header = "六" };
                menuItem3.Click += delegate
                {
                    LambdaControl.Trigger("QUATER_CLICKED3", mainwin, new EventArgs());
                };
                contextMenu.Items.Add(menuItem1);
                contextMenu.Items.Add(menuItem2);
                contextMenu.Items.Add(menuItem3);
                buttton1.ContextMenu = contextMenu;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            try
            {
                WrapPanel bottomToolbar = (WrapPanel)mainwin.FindName("bottomToolbar");

                Slider Slider1 = (Slider)bottomToolbar.Children[6];

                Binding myBindingFrameIndex = new Binding("FrameIndex");
                myBindingFrameIndex.Source = updateStatus;
                myBindingFrameIndex.Mode = BindingMode.TwoWay;

                Binding myBindingTotalFrame = new Binding("TotalFrame");
                myBindingTotalFrame.Source = updateStatus;
                myBindingTotalFrame.Mode = BindingMode.TwoWay;
                Slider1.Minimum = 1;
                Slider1.SetBinding(Slider.ValueProperty, myBindingFrameIndex);
                Slider1.SetBinding(Slider.MaximumProperty, myBindingTotalFrame);       
                Slider1.ValueChanged += delegate (object sender, RoutedPropertyChangedEventArgs<double> e)
                {
                    LambdaControl.Trigger("TSERIES_CHANGED", sender, new Dictionary<string, object>() { { "num", (int)Slider1.Value - 1 } });
                };


                TextBlock frameIndex = (TextBlock)mainwin.FindName("frameIndex");

                Binding FrameIndex1 = new Binding("FrameIndex");
                FrameIndex1.Source = updateStatus;
                frameIndex.SetBinding(TextBlock.TextProperty, FrameIndex1);

                TextBlock totalFrame = (TextBlock)mainwin.FindName("totalFrame");
                Binding TotalFrame1 = new Binding("TotalFrame");
                TotalFrame1.Source = updateStatus;
                totalFrame.SetBinding(TextBlock.TextProperty, TotalFrame1);
                   
                

                TextBlock timeElapsed = (TextBlock)mainwin.FindName("timeElapsed");
                
                Binding TimeElapsed = new Binding("TimeElapsed");
                TimeElapsed.Source = updateStatus;
                timeElapsed.SetBinding(TextBlock.TextProperty, TimeElapsed);


                TextBlock totalTime = (TextBlock)mainwin.FindName("totalTime");

                Binding TotalTime = new Binding("TotalTime");
                TotalTime.Source = updateStatus;
                totalTime.SetBinding(TextBlock.TextProperty, TotalTime);

                TextBlock zTop = (TextBlock)mainwin.FindName("zTop");
                StackPanel stackPanel = (StackPanel)zTop.Parent;
                stackPanel.HorizontalAlignment = HorizontalAlignment.Center;
                Border border = (Border)stackPanel.Parent;
                border.CornerRadius = new CornerRadius(4);

                Binding ZTop = new Binding("ZTop");
                ZTop.Source = updateStatus;
                zTop.SetBinding(TextBlock.TextProperty, ZTop);


                TextBlock zCurrent = (TextBlock)mainwin.FindName("zCurrent");
                Binding ZCurrent = new Binding("ZCurrent");
                ZCurrent.Source = updateStatus;
                zCurrent.SetBinding(TextBlock.TextProperty, ZCurrent);


                TextBlock zBottom = (TextBlock)mainwin.FindName("zBottom");
                Binding ZBottom = new Binding("ZBottom");
                ZBottom.Source = updateStatus;
                zBottom.SetBinding(TextBlock.TextProperty, ZBottom);

                TextBlock sliceIndex = (TextBlock)mainwin.FindName("sliceIndex");

                StackPanel stackPanel1 = (StackPanel)sliceIndex.Parent;
                stackPanel1.HorizontalAlignment = HorizontalAlignment.Center;
                Border border1 = (Border)stackPanel1.Parent;
                border1.CornerRadius = new CornerRadius(4);

                Binding SliceIndex = new Binding("SliceIndex");
                SliceIndex.Source = updateStatus;
                sliceIndex.SetBinding(TextBlock.TextProperty, SliceIndex);

                TextBlock totalSlice = (TextBlock)mainwin.FindName("totalSlice");
                Binding TotalSlice = new Binding("TotalSlice");
                TotalSlice.Source = updateStatus;

                totalSlice.SetBinding(TextBlock.TextProperty, TotalSlice);



                WrapPanel rightToolbar = (WrapPanel)mainwin.FindName("rightToolbar");

                Slider Slider2 = (Slider)rightToolbar.Children[13];

                Binding TotalSlice1 = new Binding("TotalSlice");
                TotalSlice1.Source = updateStatus;
                TotalSlice1.Mode = BindingMode.TwoWay;

                Binding SliceIndex1 = new Binding("SliceIndex");
                SliceIndex1.Source = updateStatus;
                SliceIndex1.Mode = BindingMode.TwoWay;

                Slider2.Minimum = 1;
                Slider2.SetBinding(Slider.ValueProperty, SliceIndex1);
                Slider2.SetBinding(Slider.MaximumProperty, TotalSlice1);
                Slider2.ValueChanged += delegate (object sender, RoutedPropertyChangedEventArgs<double> e)
                {
                    LambdaControl.Trigger("ZINDEX_CHANGED", sender, new Dictionary<string, object>() { { "num", (int)Slider2.Value - 1 } });
                };
                

            }
            catch
            {

            }


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
        private void AddEventHandler()
        {
            LambdaControl.AddLambdaEventHandler("UPDATE_STATUS1", OnUpdateStatus, false);
            LambdaControl.AddLambdaEventHandler("UPDATE_WINDOWSTATUS", OnUpdateWindowStatus, false);
            LambdaControl.AddLambdaEventHandler("UPDATE_MULMSG", OnUpdateWindowStatus, false);
            LambdaControl.AddLambdaEventHandler("TestDataEvent", TestDataEvent, false);
        }

        [DllImport("kernel32.dll", EntryPoint = "RtlMoveMemory")]
        public static extern void CopyMemory(IntPtr Destination, IntPtr Source, uint Length);
        public ImageBrush image = new ImageBrush();

        private bool TestDataEvent(object sender, EventArgs e)
        {
            //MessageBox.Show("TestDataEvent Acvtive");
            Dictionary<string, object>? eventData = LambdaArgs.GetEventData(e);
            //MessageBox.Show(eventData.Count.ToString());
            if (eventData != null)
            {
                int size = (int)eventData["size"];
                //MessageBox.Show(size.ToString());

                IntPtr intPtr = (IntPtr)eventData["data"];
                //byte[] aaa = new byte[size];
                //Marshal.Copy(intPtr, aaa, 0, size);

                //GCHandle pinnedArray = GCHandle.Alloc(aaa, GCHandleType.Pinned);
                //IntPtr pointer = pinnedArray.AddrOfPinnedObject();
                //pinnedArray.Free();

                if (image.ImageSource is WriteableBitmap writeableBitmap1)
                {
                    Int32Rect sourceRect = new Int32Rect(0, 0, (int)writeableBitmap1.Width, (int)writeableBitmap1.Height);
                    writeableBitmap1.WritePixels(sourceRect, intPtr, (int)size, (int)writeableBitmap1.Width * writeableBitmap1.Format.BitsPerPixel / 8);

                }
                else
                {
                    WriteableBitmap writeableBitmap = new WriteableBitmap(64, 48, 96.0, 96.0, PixelFormats.Bgr24, null);
                    CopyMemory(writeableBitmap.BackBuffer, intPtr, (uint)size);
                    writeableBitmap.Lock();
                    writeableBitmap.AddDirtyRect(new Int32Rect(0, 0, writeableBitmap.PixelWidth, writeableBitmap.PixelHeight));
                    writeableBitmap.Unlock();
                    image.ImageSource = writeableBitmap;
                }



                //Window window = new Window();
                //window.Content = image;
                //window.Show();

                //using (System.IO.MemoryStream ms = new System.IO.MemoryStream(aaa))
                //{
                //    BitmapImage image = new BitmapImage();
                //    image.BeginInit();
                //    image.StreamSource = ms;
                //    image.EndInit();

                //    BitmapEncoder encoder = new PngBitmapEncoder();
                //    encoder.Frames.Add(BitmapFrame.Create(image));

                //    using (var fileStream = new System.IO.FileStream("1.jpg", System.IO.FileMode.Create))
                //    {
                //        encoder.Save(fileStream);
                //    }
                //}


            }




            return true;
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
            return true;

        }
        static GridLengthConverter gridLengthConverter = new GridLengthConverter();

        public async void Test(Image image)
        {
            await Task.Delay(1000);
            if (image.Parent is Grid grid)
            {
                //grid.Children.Clear();
                //grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = (GridLength)gridLengthConverter.ConvertFrom("*") });
                //grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = (GridLength)gridLengthConverter.ConvertFrom("*") });

                //Grid grid1 = new Grid() { Background = Brushes.Transparent };
                //grid1.SetValue(Grid.ColumnProperty, 0);
                //ContextMenu contextMenu = new ContextMenu();
                //MenuItem menuItem = new MenuItem() { Header = "11111" };
                //contextMenu.Items.Add(menuItem);
                //grid1.ContextMenu = contextMenu;

                //Grid grid2 = new Grid() { Background = Brushes.Transparent };
                //grid2.SetValue(Grid.ColumnProperty, 1);
                //ContextMenu contextMenu1 = new ContextMenu();
                //MenuItem menuItem1 = new MenuItem() { Header = "22222222" };
                //contextMenu1.Items.Add(menuItem1);
                //grid2.ContextMenu = contextMenu1;
                //image.SetValue(Grid.ColumnProperty, 0);
                //image.SetValue(Grid.ColumnSpanProperty, 2);
                ////grid.Children.Add(image1);
                //grid.Children.Add(grid1);
                //grid.Children.Add(grid2);

                //grid.Background = Brushes.Red;
                Canvas canvas1 = new Canvas()
                {
                    Width = image.ActualWidth,
                    Height = image.ActualWidth,
                    Background = new SolidColorBrush(Color.FromRgb(195, 195, 195)),
                    //Background = Brushes.Black,
                    //ClipToBounds = true
                };

                grid.Children.Remove(image);
                grid.Children.Add(canvas1);
                canvas1.Children.Add(image);

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
                    if (((sfr.ScaleX < 0.2|| sfr.ScaleY < 0.2) && e.Delta < 0) || ((sfr.ScaleX > 5 || sfr.ScaleY > 5) && e.Delta > 0))
                    {

                    }
                    else
                    {
                        Point centerPoint = e.GetPosition(canvas);
                        sfr.CenterX = centerPoint.X;
                        sfr.CenterY = centerPoint.Y;
                        sfr.ScaleX += (double)e.Delta / 1000;
                        sfr.ScaleY += (double)e.Delta / 1000;
                    }



                };
                bool isMouseLeftButtonDown = false;
                Point start, mouseXY;
                image.MouseLeftButtonDown += delegate (object sender, MouseButtonEventArgs e)
                {
                    mouseXY = Mouse.GetPosition(Application.Current.MainWindow);
                    start = new Point(tlt.X, tlt.Y);
                    isMouseLeftButtonDown = true;
                    Application.Current.MainWindow.Cursor = Cursors.Hand;
                };
                image.MouseLeftButtonUp += delegate (object sender, MouseButtonEventArgs e)
                {
                    isMouseLeftButtonDown = false;
                    Application.Current.MainWindow.Cursor = Cursors.Arrow;
                };
                image.MouseLeave += delegate (object sender, MouseEventArgs e)
                {
                    isMouseLeftButtonDown = false;
                    Application.Current.MainWindow.Cursor = Cursors.Arrow;
                };
                image.MouseMove += delegate (object sender, MouseEventArgs e)
                {
                    if (isMouseLeftButtonDown == true)
                    {
                        Point position = Mouse.GetPosition(Application.Current.MainWindow);
                        tlt.X = start.X + position.X - mouseXY.X;
                        tlt.Y = start.Y + position.Y - mouseXY.Y;
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
            LambdaControl.Log(new Message() { Severity= Severity.INFO, Text = type });

            if (type == "IMAGE_VIEW_CREATED")
            {
                //MessageBox.Show(" 窗口创建");
                Dictionary<string, object>? eventData = LambdaArgs.GetEventData(e);
                View view = (View)eventData["view"];
                Test(view.Image);
            }


            if (type == "STOP_ALIVE")
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
