using Global.Common;
using Global.Common.Extensions;
using Global.RecentFile;
using Global.SettingUp;
using Global.SettingUp.Configure;
using Global.SettingUp.Hardware;
using Global.SettingUp.PC;
using Lambda;
using NvAPIWrapper.GPU;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using ThemeManager;
using Wizard;

namespace ConfigSetting
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class ToolSetting : UserControl
    {
        public ToolSetting()
        {
            Application.Current.ApplyTheme(ThemeManagers.CurrentUITheme);
            //最优先的部分
            InitializeComponent();
        }

        public void SocketCloseGrid()
        {
            //try
            //{
            //    int port = 53618;
            //    IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Loopback, port);
            //    Socket sssss = new Socket(IPAddress.Loopback.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            //    sssss.Connect(localEndPoint);
            //    string aaa = "LambdaStart";
            //    sssss.Send(Encoding.UTF8.GetBytes(aaa));
            //}
            //catch
            //{

            //}

        }

        public ObservableCollection<FirmwareUpdate> firmwareUpdates;

        bool IsFirstLoad = true;
        private async void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            if (IsFirstLoad && this.Parent is StackPanel stackPanel1 && stackPanel1.Parent is Viewbox viewbox1 && viewbox1.Parent is ScrollViewer scrollViewer1)
            {
                Application.Current.MainWindow.Title = "";
                Application.Current.ApplyTheme(ThemeManagers.CurrentUITheme);
                IsFirstLoad = false;

                _ = Task.Run(() => SocketCloseGrid());

                Calibration.GetInstance();
                SystemSettingGrid.DataContext = SoftwareConfig.HardwareSetting.PerformanceSetting;
                OutOfMemorySign.Source = System.Drawing.SystemIcons.Warning.ToImageSource();

                //GPU信息
                PhysicalGPU[] physicalGPUs;
                try
                {
                    physicalGPUs = PhysicalGPU.GetPhysicalGPUs();
                }
                catch
                {
                    physicalGPUs = new PhysicalGPU[0];
                }
                GPUInfo GPUInfo = SoftwareConfig.HardwareSetting.GPUInfo;
                GPUGrid.DataContext = GPUInfo;
                if (physicalGPUs.Count() > 0)
                {
                    GPUInfo.IsGPUCapable = true;
                    GPUInfo.GPUName = physicalGPUs[0].FullName;
                    double a = (double)(physicalGPUs[0].MemoryInformation.AvailableDedicatedVideoMemoryInkB) / 1024 / 1024;
                    GPUInfo.GPUaccessibleRAM = (uint)Math.Round(a);
                }
                LambdaControl.Trigger("IsGPUCapable", this,new Dictionary<string, object>() { { "Value", GPUInfo.IsOpenGPUAccelerate } });
                GPUAccelerateCombox.ItemsSource = new List<string> { "开启", "关闭" };
                GPUAccelerateCombox.SelectedIndex = GPUInfo.IsOpenGPUAccelerate ? 0 : 1;
                SoftwareConfig.WindowSetting.PropertyChanged += (s, e) =>
                {
                    if (e.PropertyName == "IsOpenGPUAccelerate")
                    {
                        GPUAccelerateCombox.SelectedIndex = GPUInfo.IsOpenGPUAccelerate ? 0 : 1;
                        LambdaControl.Trigger("IsGPUCapable", this, new Dictionary<string, object>() { { "Value", GPUInfo.IsOpenGPUAccelerate } });
                    }
                };
                GPUAccelerateCombox.SelectionChanged += (s, e) =>
                {
                    GPUInfo.IsOpenGPUAccelerate = GPUAccelerateCombox.SelectedIndex == 0;
                };

                if (!SoftwareConfig.HardwareSetting.IsIniWizard)
                {

                    //这里让窗口最小化
                    await Task.Delay(50);
                    SystemCommands.MinimizeWindow(Application.Current.MainWindow);
                    await Task.Delay(100);

                    if (SoftwareConfig.HardwareSetting.CameraStatus != CameraStatus.Ok || SoftwareConfig.HardwareSetting.LightStatus != SerialPortStatus.NoError || SoftwareConfig.HardwareSetting.StageStatus != SerialPortStatus.NoError)
                    {
                        if (!SoftwareConfig.HardwareSetting.IsIniWizard)
                        {
                            MessageBox1.Show($"硬件连接异常:\n\r相机状态:{SoftwareConfig.HardwareSetting.CameraStatus}\n\r光源状态:{SoftwareConfig.HardwareSetting.LightStatus}\n\r位移台状态:{SoftwareConfig.HardwareSetting.StageStatus}", "Grid");
                            if (MessageBox1.Show("您是否要继续完成初始化 ", "Grid", MessageBoxButton.YesNo) == MessageBoxResult.No)
                            {
                                goto TouchDown;
                                //Environment.Exit(0);
                            }
                        }
                    }

                    WizardWindow mainWindow = new WizardWindow();
                    mainWindow.ShowDialog();
                    TouchDown:
                    if (SoftwareConfig.HardwareSetting.IsIniWizard)
                    {
                        SystemCommands.RestoreWindow(Application.Current.MainWindow);
                    }
                }


                Test_Click(sender, e);

                if (SoftwareConfig.PerformanceSetting.IsDiskLackWarning)
                {
                    SoftwareConfig.PerformanceSetting.IsShowDiskLackWarning = !MessageBox1.ShowAgain("硬盘剩余存储空间不足", "Grid", !SoftwareConfig.PerformanceSetting.IsShowDiskLackWarning);
                }

                if (Application.Current.MainWindow.FindName("leftView") is ColumnDefinition leftView && Application.Current.MainWindow.FindName("leftTab") is TabControl leftTab)
                {
                    leftView.Width = new GridLength(SoftwareConfig.WindowSetting.LeftViewWidth, GridUnitType.Pixel);
                    leftTab.SizeChanged += (s, e) => { if (leftTab.ActualWidth > 0) SoftwareConfig.WindowSetting.LeftViewWidth = leftTab.ActualWidth; };
                }

                if (Application.Current.MainWindow.FindName("msgList") is ComboBox combobox)
                {


                    combobox.Visibility = SoftwareConfig.WindowSetting.IsShowLog ? Visibility.Visible : Visibility.Hidden;
                    ShowLogCombox.ItemsSource = new List<string> { "显示", "隐藏" };
                    ShowLogCombox.SelectedIndex = SoftwareConfig.WindowSetting.IsShowLog ? 0 : 1;
                    SoftwareConfig.WindowSetting.PropertyChanged += (s, e) =>
                    {
                        if (e.PropertyName == "IsShowLog" )
                        {
                            ShowLogCombox.SelectedIndex = SoftwareConfig.WindowSetting.IsShowLog ? 0 : 1;
                            combobox.Visibility = SoftwareConfig.WindowSetting.IsShowLog ? Visibility.Visible : Visibility.Hidden;
                        }
                    };
                    ShowLogCombox.SelectionChanged += (s, e) =>
                    {
                        SoftwareConfig.WindowSetting.IsShowLog = ShowLogCombox.SelectedIndex == 0;
                    };
                }

                bool DecorateLight = false;
                DecorateLightCombox.ItemsSource = new List<string> { "关闭", "打开" };
                DecorateLightCombox.SelectedIndex = -1;
                DecorateLightCombox.SelectionChanged += (s, e) =>
                {
                    DecorateLight = ShowLogCombox.SelectedIndex == 0;
                    LambdaControl.Trigger("DECORATIVE_LIGHTS_CONTROL", this, new Dictionary<string, object> { { "mode", ShowLogCombox.SelectedIndex } });
                };



                firmwareUpdates = new ObservableCollection<FirmwareUpdate> {  };
                ListView1.ItemsSource = firmwareUpdates;


                SolutionGrid.DataContext = SoftwareConfig.SolutionSetting;
                SupportMultiProjectCombox.ItemsSource = new List<string> {  "是" , "否" };
                SupportMultiProjectCombox.SelectedIndex = SoftwareConfig.SolutionSetting.IsSupportMultiProject ? 0 : 1;
                SoftwareConfig.SolutionSetting.PropertyChanged += (s, e) =>
                {
                    if (e.PropertyName == "IsSupportMultiProject")
                    {
                        SupportMultiProjectCombox.SelectedIndex = SoftwareConfig.SolutionSetting.IsSupportMultiProject ? 0 : 1;
                    }
                };
                SupportMultiProjectCombox.SelectionChanged += (s, e) =>
                {
                    SoftwareConfig.SolutionSetting.IsSupportMultiProject = SupportMultiProjectCombox.SelectedIndex == 0;
                };



                stackPanel1.Children.Remove(this);
                if (Application.Current.MainWindow.FindName("stageConfig") is Grid stageConfig && Application.Current.MainWindow.FindName("stageAcquisition") is Grid stageAcquisition)
                {
                    stageConfig.Children.Add(this);
                    stageConfig.SetResourceReference(Grid.BackgroundProperty, "WindowBackgroundBrush");
                    
                    if (Application.Current.MainWindow.Content is Grid mainGrid&& mainGrid.Children[0] is Grid grid2 && grid2.Children[1] is StackPanel stackPanelMode)
                    {
                        if (grid2.Children[0] is StackPanel stackPanel && stackPanel.Children[0] is Button button && button.Content is Image image)
                        {
                            image.Source = new BitmapImage(new Uri("/ConfigSetting;component/image/application-logo-3.0.png", UriKind.Relative));
                        }

                        foreach (var item in stackPanelMode.Children)
                        {
                            if (item is RadioButton radioButton1)
                            {
                                radioButton1.SetResourceReference(RadioButton.StyleProperty, "PhaseButton");
                            }
                        }

                        if (Application.Current.MainWindow.FindName("menu") is Menu menu)
                        {
                            menu.BorderBrush = Brushes.Transparent;
                            menu.Background = Brushes.Transparent;

                            foreach (var item in menu.Items.Cast<MenuItem>().ToList())
                            {
                                item.Width = 60;
                            }
                        }

                        if (stackPanelMode.Children[0] is RadioButton radioButton)
                        {
                            stageConfig.Visibility = radioButton.IsChecked ==true ? Visibility.Visible : Visibility.Collapsed;
                            stageAcquisition.Visibility = radioButton.IsChecked != true ? Visibility.Visible : Visibility.Collapsed;

                            radioButton.Checked += delegate
                            {
                                stageConfig.Visibility = Visibility.Visible;
                                stageAcquisition.Visibility = Visibility.Hidden;

                                DecorateLightCombox.SelectedIndex = -1;
                            };
                            radioButton.Unchecked += delegate
                            {
                                stageAcquisition.Visibility = Visibility.Visible;
                                stageConfig.Visibility = Visibility.Hidden;

                            };
                        }
                    }

                }


                InitConnect();
                InitEmun();


                GroupBox13.DataContext = SoftwareConfig.HardwareConfig;
                GroupBox21.DataContext = SoftwareConfig.HardwareConfig.LightSourceConfig;
                GroupBox24.DataContext = SoftwareConfig.HardwareConfig.CameraConfig;
                LambdaControl.Trigger("CameraSettingFlipV", this, new Dictionary<string, object>() { { "bflip", SoftwareConfig.HardwareConfig.CameraConfig.ImageFlipV } });
                LambdaControl.Trigger("CameraSettingFlipH", this, new Dictionary<string, object>() { { "bflip", SoftwareConfig.HardwareConfig.CameraConfig.ImageFlipH } });
                //SoftwareConfig.HardwareConfig.LightSourceConfig = Json.Deserialize<LightSourceConfig>("LightSourceConfig");
                //GroupBox21.DataContext = SoftwareConfig.HardwareConfig.LightSourceConfig;
                //SoftwareConfig.HardwareConfig.LightSourceConfig.ToJsonFile("LightSourceConfig");
            }
        }


        private void UserControl_Initialized(object sender, EventArgs e)
        {


        }

        private void TreeViewItem_Selected(object sender, RoutedEventArgs e)
        {
            if (sender is TreeViewItem treeViewItem)
            {
                if (treeViewItem.Tag is GroupBox groupBox)
                {
                    var currentScrollPosition = ScrollViewer1.VerticalOffset;
                    var point = new Point(0, currentScrollPosition);

                    var targetPosition = groupBox.TransformToVisual(ScrollViewer1).Transform(point);
                    ScrollViewer1.ScrollToVerticalOffset(targetPosition.Y);
                }
            }
        }



        public void Button_Click_6(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("实验内容，点击后请确认给予权限");
            Process p = new Process();
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p.StartInfo.FileName = "Global.Reg.exe";
            p.StartInfo.UseShellExecute = true;
            p.StartInfo.Verb = "runas";
            p.Start();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button && button.Tag is FirmwareUpdate firmwareUpdate)
            {
                MessageBox.Show(firmwareUpdate.UpdateUrl);
            }
        }


        private void Calibration_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button && button.Tag is string value)
            {
                Dictionary<int, HardwareCalibration> HardwareCalibrationDic = new Dictionary<int, HardwareCalibration>();
                Dictionary<int, string> HardwareCalibrationDicString = new Dictionary<int, string>();
                //硬触发
                HardwareCalibrationDic.Add(0, new HardwareCalibration() { Hardware = "Camera", Type = "HardTrigger" });
                HardwareCalibrationDicString.Add(0, "相机触发校准");
                //位移台移动完整性
                HardwareCalibrationDic.Add(10, new HardwareCalibration() { Hardware = "Stage", Type = "Integrity" });
                HardwareCalibrationDicString.Add(10, "位移台移动完整性");
                //放大倍数
                HardwareCalibrationDic.Add(11, new HardwareCalibration() { Hardware = "Stage", Type = "Magnification" });
                HardwareCalibrationDicString.Add(11, "放大倍数");

                //回城校准
                HardwareCalibrationDic.Add(12, new HardwareCalibration() { Hardware = "Stage", Type = "Backhaul" });
                HardwareCalibrationDicString.Add(12, "回程校准");

                //零点
                HardwareCalibrationDic.Add(13, new HardwareCalibration() { Hardware = "Stage", Type = "Zero" });
                HardwareCalibrationDicString.Add(13, "零点校准");


                //中心点
                HardwareCalibrationDic.Add(20, new HardwareCalibration() { Hardware = "Light", Type = "CenterPoint" });
                HardwareCalibrationDicString.Add(20, "灯光中心点校准");

                //光源完整性
                HardwareCalibrationDic.Add(21, new HardwareCalibration() { Hardware = "Light", Type = "Integrity" });
                HardwareCalibrationDicString.Add(21, "光源完整性校准");

                //白平衡
                HardwareCalibrationDic.Add(22, new HardwareCalibration() { Hardware = "Light", Type = "WhiteBalance" });
                HardwareCalibrationDicString.Add(22, "白平衡校准");

                //光源明场暗场半径
                HardwareCalibrationDic.Add(23, new HardwareCalibration() { Hardware = "Light", Type = "RadiusOfLightSource" });
                HardwareCalibrationDicString.Add(23, "光源明场暗场半径校准");


                // 背景校正
                HardwareCalibrationDic.Add(30, new HardwareCalibration() { Hardware = "Initialize", Type = "BackgroundCorrection" });
                HardwareCalibrationDicString.Add(30, "初始化背景矫正");
                HardwareCalibrationDic.Add(31, new HardwareCalibration() { Hardware = "Initialize", Type = "TransferFunction" });
                HardwareCalibrationDicString.Add(31, "初始化传递函数");

                HardwareCalibrationType hardwareCalibrationType = HardwareCalibrationType.All;

                switch (value)
                {
                    case "All":
                        break;
                    default:
                        List<int> list = new List<int>();
                        foreach (var item in HardwareCalibrationDic)
                        {
                            if (item.Value.Hardware != value)
                            {
                                list.Add(item.Key);
                            }
                        }
                        foreach (var item in list)
                        {
                            HardwareCalibrationDic.Remove(item);
                            HardwareCalibrationDicString.Remove(item);
                        }
                        break;
                }

                switch (value)
                {
                    case "All":
                        hardwareCalibrationType = HardwareCalibrationType.All;
                        break;
                    case "Camera":
                        hardwareCalibrationType = HardwareCalibrationType.Camera;
                        break;
                    case "Stage":
                        hardwareCalibrationType = HardwareCalibrationType.Stage;
                        break;
                    case "Light":
                        hardwareCalibrationType = HardwareCalibrationType.Light;
                        break;
                    case "Initialize":
                        hardwareCalibrationType = HardwareCalibrationType.Initialize;
                        break;
                    default:
                        break;

                }


                CalibrationWindow calibrationWindow = new CalibrationWindow(hardwareCalibrationType, HardwareCalibrationDic, HardwareCalibrationDicString);
                calibrationWindow.Show();


            }
        }


        private void Test_Click(object sender, RoutedEventArgs e)
        {
            string result = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Grid\\Default\\default.gprj");

            try
            {
                JsonObject lamdbda = (JsonObject)JsonNode.Parse(result);
                if (lamdbda != null)
                {
                    SoftwareConfig.HardwareConfig.DeviceType = lamdbda["device-type"]?.ToString();
                    SoftwareConfig.HardwareConfig.InstallSize = lamdbda["install-size"]?.ToString();

                    if (lamdbda["firmware"] is JsonObject firmware)
                    {

                        if (firmware["source"] is JsonObject source)
                        {
                            var LightSourceConfig = SoftwareConfig.HardwareConfig.LightSourceConfig;
                            LightSourceConfig.LEDRowsAndColumns = source["led-size"]?.ToString();
                            LightSourceConfig.LEDSpacing = source["led-spacing"]?.ToString();
                            LightSourceConfig.LEDHeight = source["led-height"]?.ToString();
                            LightSourceConfig.LEDCenterWavelength = source["center-wave-length"]?.ToString();
                            LightSourceConfig.MaxRefreshRate = source["max-frequency"]?.ToString();
                            LightSourceConfig.MaxBrightness = source["brightness"]?.ToString();
                            LightSourceConfig.LEDColors = source["hdr"]?.ToString();
                            LightSourceConfig.MaxNumericalAperture = source["NA"]?.ToString();
                        }
                        if (firmware["camera"] is JsonObject camera)
                        {
                            var CameraConfig = SoftwareConfig.HardwareConfig.CameraConfig;
                            CameraConfig.CameraModel = camera["type"]?.ToString();
                            CameraConfig.TargetSize = camera["ccd-size"]?.ToString();
                            CameraConfig.DynamicRange = camera["hdr"]?.ToString();
                            CameraConfig.MAXFrameRate = camera["max-fps"]?.ToString();
                            CameraConfig.TriggerMode = camera["trigger"]?.ToString();
                        }
                        if (firmware["objective"] is JsonObject objective)
                        {
                            var ObjectiveConfigs = SoftwareConfig.HardwareConfig.ObjectiveConfigs;

                            try
                            {

                                if ((bool)lamdbda["multi-objectives"]! == true)
                                {
                                    List<string> ObjectiveConfigsLists = new List<string>() { };

                                    JsonArray jsonArray = (JsonArray)lamdbda["lambda-manager"]!["objective-keys"];
                                    foreach (var item in jsonArray!)
                                    {
                                        ObjectiveConfigsLists.Add(item!.ToString());
                                    }

                                    List<string> ObjectiveConfigsList = new List<string>();
                                    if (objective["magnitude"] is JsonObject magnitude)
                                    {
                                        foreach (var item in ObjectiveConfigsLists)
                                        {
                                            if (magnitude[item] is not null)
                                                ObjectiveConfigsList.Add(item);
                                        }
                                    }
                                    List<ObjectiveConfig> AvailableObjectives = new List<ObjectiveConfig> { };
                                    foreach (var item in ObjectiveConfigsList)
                                    {
                                        ObjectiveConfig objectiveConfig = new ObjectiveConfig();
                                        objectiveConfig.ObjectiveKey = item.ToString();
                                        objectiveConfig.Magnitude = (int)objective["magnitude"]![item]!;
                                        objectiveConfig.NA = (double)objective["NA"]![item]!;
                                        objectiveConfig.Achromatic = (bool)objective["achromatic"]![item]!;
                                        objectiveConfig.Multiple = (double)objective["multiple"]![item]!;
                                        objectiveConfig.WorkingDistance = objective["WD"]![item]?.ToString();
                                        AvailableObjectives.Add(objectiveConfig);
                                    }

                                    ObjectiveConfigs.AvailableObjectives = AvailableObjectives;

                                    foreach (var item in AvailableObjectives)
                                    {
                                        if (item.Magnitude == (int)objective["current-magnitude"]!)
                                        {
                                            ObjectiveConfigs.CurrentObjectiveConfig = item;
                                            break;
                                        }
                                    }

                                }
                                else
                                {
                                    ObjectiveConfig objectiveConfig = new ObjectiveConfig();
                                    objectiveConfig.ObjectiveKey = ((JsonArray)lamdbda["lambda-manager"]!["objective-keys"]!)[0]!.ToString();
                                    objectiveConfig.Magnitude = (int)objective["magnitude"]!;
                                    objectiveConfig.NA = (double)objective["NA"]!;
                                    objectiveConfig.Achromatic = (bool)objective["achromatic"]!;
                                    objectiveConfig.Multiple = (double)objective["multiple"]!;
                                    objectiveConfig.WorkingDistance = objective["WD"]?.ToString();
                                    List<ObjectiveConfig> AvailableObjectives = new List<ObjectiveConfig> { objectiveConfig };

                                    ObjectiveConfigs.AvailableObjectives = AvailableObjectives;
                                    ObjectiveConfigs.CurrentObjectiveConfig = objectiveConfig;
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("无法正确解析硬件参数，请检查文件是否损坏: \n\r" + ex.Message);
                            }

                        }             
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



            foreach (var item in SoftwareConfig.HardwareConfig.ObjectiveConfigs.AvailableObjectives)
            {
                TextBlock230.Children.Add(new TextBlock() { Width = 120, Text = $"{item.ObjectiveKey}:   {item.Magnitude}" });
                TextBlock231.Children.Add(new TextBlock() { Width = 120, Text = $"{item.ObjectiveKey}:   {item.NA}" });
                TextBlock232.Children.Add(new TextBlock() { Width = 120, Text = $"{item.ObjectiveKey}:   {item.WorkingDistance}mm" });
                TextBlock233.Children.Add(new TextBlock() { Width = 120, Text = $"{item.ObjectiveKey}:   " + (item.Achromatic ? "是" : "否") });
            }
            SoftwareConfig.HardwareConfig.INIEDInvoke();
            LambdaControl.Log(new Message() { Severity =Severity.INFO,Text = "参数读取完成"});
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Process.Start("cleanmgr.exe", string.Concat("/D ", SoftwareConfig.PerformanceSetting.CurrentDrive.Name.AsSpan(0,1)));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            RecentFileList recentFileList;
            foreach (var item in RecentFileList.RegistryKeyList)
            {
                recentFileList = new RecentFileList() { Persister = new RegistryPersister(item) };
                recentFileList.Clear();
            }
            MessageBox1.Show("缓存清理完成");
            MessageBox1.ShowAgain("缓存清理完成","sss", false);

        }
    }
}
