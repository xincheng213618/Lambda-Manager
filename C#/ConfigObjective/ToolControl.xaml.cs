using Global;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using Lambda;
using System.Windows.Input;
using System.Windows.Media;
using Global.Common.Util;
using Global.Common;
using System.Timers;
using System.ComponentModel;
using Global.Setting;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Global.SettingUp;
using UserRegister;

namespace ConfigObjective
{

    public partial class ToolControl : UserControl
    {
        WindowData windowData;
        WindowData1 windowData1;
        public ToolControl()
        {
            //Validate();
            windowData = WindowData.GetInstance();
            windowData1 = WindowData1.GetInstance();
            WindowData1.GetInstance();
            Update.UpdateEvent += UpdateGlobal;
            InitializeComponent();
            InitCheckList();
           

        }
        private List<CheckBox> checklist = new List<CheckBox>();
        private CheckBox checkCurrent;
        private CheckBox checkCurrent1;
        private void InitCheckList()
        {
            checklist.Add(_25x25);
            checklist.Add(_35mm);
            checklist.Add(_45mm);
        }
        bool IsFirstUpdate = true;
        private void UpdateGlobal()
        {
            if (!IsFirstUpdate)
            {
                IsFirstUpdate = false;
                MessageBox1.Show("根据参数更新","Grid");
            }
            CameraSetting_Update();
            OperatingMode_Update();
            Stage_Update();
            MulDimensional_Update();
        }

        //private void Validate()
        //{

        //    IpConfig  ipConfig = new IpConfig();
        //    List<string> macs = ipConfig.GetMacAddress();

        //}
        public async void Validate()
        {
            
           // MessageBox.Show("111");
            await Task.Delay(10000);
            if (!SoftwareConfig.HardwareSetting.IsIniWizard)
            {
                return;
            }
            IpConfig ipConfig = new IpConfig();
            List<string> macS2 = ipConfig.GetMacAddress();
            String URL = "https://v3.xincheng213618.com:18888/checkregister";
            MessageBox.Show("111111");
            bool Connect = HttpsRequest.CheckUrlConnect(URL);
            if (Connect)
            {

                //SN 通过读取默认工程文件获取
                string result = HttpRequest1(URL, "D822D1-10E8C1-CE535A-6797C8", macS2);
                RegisterBack regBack = JsonSerializer.Deserialize<RegisterBack>(result, new JsonSerializerOptions());
                if (regBack.State == 1)
                {
                    //预留
                    if (regBack.Message == "找不到注册信息")
                    {
                        MessageBoxResult res = MessageBox.Show("当前序列号未注册，是否重新注册 ？", "信息提示", MessageBoxButton.OKCancel, MessageBoxImage.Information);

                        if(res == MessageBoxResult.OK)
                        {
                            UserRegister.MainWindow userRegsterWindow = new UserRegister.MainWindow();

                            userRegsterWindow.ShowDialog();
                        }
                        else
                        {
                            Register.DisableAll();
                        }
                    }
                    else
                    { 
                            MessageBox.Show("当前序列号已注册到其他机器");
                            Register.DisableAll();
                            //MessageBoxResult boxResult = MessageBox.Show("恢复正常状态？", "信息提示", MessageBoxButton.OKCancel, MessageBoxImage.Information);

                            //if (boxResult == MessageBoxResult.OK)
                            //{
                            //    Register.EnableAll();
                            // }
                        

                    }

                }
            }
           
        }
        








        public string HttpRequest1(string uri,string SN,List<string> macAddress)
        {

            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("sn", SN);
            StringBuilder stringBuilder = new StringBuilder();
            if(macAddress.Count > 0)
            {
                for (int i = 0; i < macAddress.Count; i++)
                {
                    if (i != macAddress.Count - 1)
                    {
                        stringBuilder.Append(macAddress[i]);
                        stringBuilder.Append(";");
                    }
                    else
                    {
                        stringBuilder.Append(macAddress[i]);
                    }
                }

            }
            dic.Add("mac-array", stringBuilder.ToString());
            string message = HttpsRequest.Post(uri, dic);
            MessageBox.Show(message);
            return message;

        }


        /// <summary>
        /// 初始化写在前面
        /// </summary>
        private void UserControl_Initialized(object sender, EventArgs e)
        {
            AddEventHandler();
            //初始化硬件

            ObjectiveSetting_Initialize();
            OperatingMode_Initialize();
            CameraSetting_Initialize();
        

            Map.moveButton.DataContext = windowData.mapModel;
            Stage_Initialize();
            MulDimensional_Initialize();

            Update.UpdateGlobal();
            IsFirstUpdate = true;
           

            #region slider
            SliderAbbreviation(Slider311, "BRIGHT_FIELD_DIAMETER", "diameter");
            //照明内径
            SliderAbbreviation(Slider321, "DARK_FIELD_INNER", "inner");
            //照明外径
            SliderAbbreviation(Slider322, "DARK_FIELD_OUTER", "outer");


            //背景校正
            ToggleButtonAbbreviation(Button322, "DARK _FIELD _BG_COLLECTION", "collection");
            Button322.IsChecked = false;


            //伽马
            //SliderAbbreviation1(Slider335, "RHEIN_BERG_GAMMA", "gamma");

            //差分

            //对比度
            SliderAbbreviation1(Slider341, "RELIEF_CONTRAST_CONTRAST", "contrast");
            //增益
            SliderAbbreviation1(Slider342, "RELIEF_CONTRAST_GAIN", "gain");
            //明场权重
            SliderAbbreviation1(Slider343, "RELIEF_CONTRAST_BF_WEIGHT", "weight");
            //测试附加
            //外径
            SliderAbbreviation(Slider344, "RELIEF_CONTRAST_OUTER", "outer");
            //内径
            SliderAbbreviation(Slider345, "RELIEF_CONTRAST_INNER", "inner");
            //Gamma
            SliderAbbreviation1(Slider346, "RELIEF_CONTRAST_GAMMA", "gamma");
            //相衬权重
            SliderAbbreviation1(Slider347, "RELIEF_CONTRAST_DP_WEIGHT", "weight");


            //相位

            //正则化参数
            // SliderAbbreviation1(Slider351, "QUANTITATIVE_PHASE_REG", "regularization");
           
            //Min
            SliderAbbreviation1(Slider353, "QUANTITATIVE_PHASE_MIN", "min");
            // Max
            SliderAbbreviation1(Slider354, "QUANTITATIVE_PHASE_MAX", "max");
            // Gamma
            SliderAbbreviation1(Slider355, "QUANTITATIVE_PHASE_GAMMA", "gamma");

            //相差

            //相差滤波
            SliderAbbreviation1(Slider361, "PHASE_CONTRAST_FILTER", "filter");
            //明场权重
            SliderAbbreviation1(Slider364, "PHASE_CONTRAST_BF_WEIGHT", "weight");
            //伽马
            SliderAbbreviation1(Slider365, "PHASE_CONTRAST_GAMMA", "gamma");
            //相差权重
            SliderAbbreviation1(Slider366, "PHASE_CONTRAST_PC_WEIGHT", "weight");

            #endregion

        }

        bool IsFirstLoad = true;
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            if (IsFirstLoad && this.Parent is StackPanel stackPanel && stackPanel.Parent is Viewbox viewbox)
            {
                stackPanel.Margin = new Thickness(2, 2, 2, 0);
                viewbox.Width = double.NaN;
                IsFirstLoad = false;
                if (Reg.ReadValue("Software\\Grid", "InitializeStage"))
                {
                    WaitContorl.GetInstance().Show();
                    WaitContorl.GetInstance().textBox.Text = "位移台校准中";
                    WaitContorl.GetInstance().ShowTimeOut = 60000;
                    LambdaControl.Dispatch("STAGE_SETTING_RESET", this, new Dictionary<string, object> { });
                }
            }
            ComboBox1.ItemsSource = windowData.deviceInformation.CameraResolution;
            ComboBox1.SelectedIndex = (int)WindowData.GetInstance().setting.otherMode.Resolution;
            //多物镜 延迟切换绑定当前物镜
            if (windowData.SolutionConfig.IsMultiObj.Enable == true)
            {
                foreach(var item in windowData.deviceInformation.ObjectiveSettings)
                {
                    if(item.IsChecked == true)
                    {
                        foreach(ToggleButton toggleButton in ObjectiveSettingStackPanel.Children)
                        {
                           if( toggleButton.Content.ToString() == item.Name)
                            {
                                toggleButton.IsChecked = true;
                            }

                        }
                    }
                }


            }


        }







        //修改滑块的时候会触发两次，所以在这里加一个Tigger用来屏蔽掉第二次的触发，这里得(未来)重写。
        bool sliderfirst = true;
        /// <summary>
        /// SliderAbbreviation(int)
        /// </summary>
        private Slider SliderAbbreviation(Slider slider, string TriggerName, string TriggerParameter)
        {
            slider.ValueChanged += delegate (object sender, RoutedPropertyChangedEventArgs<double> e)
            {

                if (!windowData.ACQUIRE)
                {
                    Dictionary<string, object> data = new() { { TriggerParameter, (int)slider.Value } };
                    LambdaControl.Trigger(TriggerName, slider, data);
                }
                else
                {
                    if (sliderfirst)
                    {
                        var result = MessageBox.Show("是否修改当前多维采集设置", "显微镜", MessageBoxButton.YesNo);
                        if (result == MessageBoxResult.No)
                        {
                            sliderfirst = false;
                            slider.Value = e.OldValue;
                        }
                    }
                    else
                    {
                        sliderfirst = true;
                    }
                }

            };
            return slider;
        }

        /// <summary>
        /// SliderAbbreviation(double)
        /// </summary>
        private Slider SliderAbbreviation1(Slider slider, string TriggerName, string TriggerParameter)
        {
            slider.ValueChanged += delegate (object sender, RoutedPropertyChangedEventArgs<double> e)
            {
                if (!windowData.ACQUIRE)
                {
                    if (slider.Name == "Slider351")
                    {
                        Dictionary<string, object> data = new() { { TriggerParameter, (double)slider.Value*0.01 } };
                        LambdaControl.Trigger(TriggerName, slider, data);
                    }
                    else
                    {
                        Dictionary<string, object> data = new() { { TriggerParameter, (double)slider.Value } };
                        LambdaControl.Trigger(TriggerName, slider, data);
                    }

                }
                else
                {
                    if (sliderfirst)
                    {
                        var result = MessageBox.Show("是否修改当前多维采集设置", "显微镜", MessageBoxButton.YesNo);
                        if (result == MessageBoxResult.No)
                        {
                            sliderfirst = false;
                            slider.Value = e.OldValue;
                        }
                    }
                    else
                    {
                        sliderfirst = true;
                    }
                }

            };
            return slider;
        }

        /// <summary>
        /// ToggleButton缩写优化
        /// </summary>
        /// <param name="FindName"></param>
        /// <param name="TriggerName"></param>
        /// <param name="TriggerParameter"></param>
        private ToggleButton ToggleButtonAbbreviation(ToggleButton toggleButton, string TriggerName, string TriggerParameter)
        {
            toggleButton.Checked += delegate
            {
                Dictionary<string, object> data = new Dictionary<string, object>() { { TriggerParameter, toggleButton.IsChecked } };
                LambdaControl.Trigger(TriggerName, toggleButton, data);
            };
            toggleButton.Unchecked += delegate
            {
                Dictionary<string, object> data = new() { { TriggerParameter, toggleButton.IsChecked } };
                LambdaControl.Trigger(TriggerName, toggleButton, data);
            };
            return toggleButton;
        }

        private void ToggleButton222_Checked(object sender, RoutedEventArgs e)
        {
           windowData.MulDimensional.TInterval = ">>";
        }

        private void ToggleButton221_Checked(object sender, RoutedEventArgs e)
        {
             windowData.MulDimensional.TNumber = -1;
        }

        private void ToggleButton504_Checked(object sender, RoutedEventArgs e)
        {
           if (!(bool)ToggleButton503.IsChecked)
            {
                ZwisePanel.Visibility = Visibility.Hidden;
            }
        }

        private void ToggleButton504_Unchecked(object sender, RoutedEventArgs e)
        {
            if (!(bool)ToggleButton503.IsChecked)
            {
                ZwisePanel.Visibility = Visibility.Collapsed;
            }
        }

        private void ToggleButton503_Checked(object sender, RoutedEventArgs e)
        {
            ZwisePanel.Visibility = Visibility.Visible;

            AutoFocusModuleShow();

        }
        private void AutoFocusModuleShow()
        {
            if (windowData.MulDimensional.ZAbsolute)
            {
                AutoFocusBar.Visibility = Visibility.Visible;
                AutoFocusModule.Visibility = Visibility.Visible;
            }
            else
            {
                AutoFocusBar.Visibility = Visibility.Collapsed;
                AutoFocusModule.Visibility = Visibility.Collapsed;
            }

        }




        private void ToggleButton5221_Checked(object sender, RoutedEventArgs e)
        {
            ZAbsolute.Text = "Z-相对坐标";
            LambdaControl.Trigger("MUL_ZAXIS", this, new Dictionary<string, object>() { { "mode", 3 }, { "value", 1 }, { "zstart", windowData.MulDimensional.ZStart }, { "zend", windowData.MulDimensional.ZEnd } });
            AutoFocusModuleShow();

        }

        private void ToggleButton5221_Unchecked(object sender, RoutedEventArgs e)
        {
            ZAbsolute.Text = "Z-绝对坐标";
            LambdaControl.Trigger("MUL_ZAXIS", this, new Dictionary<string, object>() { { "mode", 3 }, { "value", 0 }, { "zstart", windowData.MulDimensional.ZStart }, { "zend", windowData.MulDimensional.ZEnd } });
            AutoFocusModuleShow();
        }


       
        private void ToggleButton222_Unchecked(object sender, RoutedEventArgs e)
        {
          //windowData.MulDimensional.TInterval = "-1";
            windowData.MulDimensional.TInterval = "0";
        }
        private static Dictionary<string, Timer> timers = new Dictionary<string, Timer>();
        //延时触发实现
        public static void AddEventTimer(string type, int millis, ElapsedEventHandler callback)
        {
            if (timers.TryGetValue(type, out var value))
            {
                value.Enabled = false;
                timers.Remove(type);
            }
            Timer timer = new Timer(millis);
            timer.Elapsed += callback;
            //timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            timer.AutoReset = false;
            timer.Enabled = true;
            timer.Start();
            timers.Add(type, timer);
        }
        
        private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            //Application.Current.Dispatcher.Invoke(delegate
            //{
            //    WaitContorl.GetInstance().Hidden();
            //});

            Dictionary<string, object> data = new() { { "regularization", (double)windowData.OperatingMode.QuantitativePhase.Regularization * 0.01 } };
            LambdaControl.Trigger("QUANTITATIVE_PHASE_REG", Slider351, data);
           // MessageBox.Show(e.SignalTime.ToString());

        }

        private void Slider351_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            AddEventTimer("351", 300, OnTimedEvent);

        }

        private void ToggleButton221_Unchecked(object sender, RoutedEventArgs e)
        {
           windowData.MulDimensional.TNumber = 0;
        }

        private void ColorButton311_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void ToggleButton2_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void popUp42_Closed(object sender, EventArgs e)
        {
            popUp42.IsOpen = false;
        }

       

       

        private void _35mm_Checked(object sender, RoutedEventArgs e)
        {
            
            popUp42.IsOpen = false;
            if (Map != null)
            {
                Map.mapEllipse.RadiusX = 130;
                Map.mapEllipse.RadiusY = 130;
                string dataH = "M 20 150 280 150";
                string dataV = "M 150 20  150 280";
                var converter = TypeDescriptor.GetConverter(typeof(Geometry));
                Map.LineHor.Data = (Geometry)converter.ConvertFrom(dataH);
                Map.LineVer.Data = (Geometry)converter.ConvertFrom(dataV);
            }
            Button42.IsChecked = true;
            var current = (System.Windows.Controls.CheckBox)sender;
            checkCurrent = current;
            checkCurrent1 = current;
            foreach (var checkBox in checklist)
            {
                if (checkBox != current)
                {
                    checkBox.IsChecked = false;
                }
            }


        }

        private void _45mm_Checked(object sender, RoutedEventArgs e)
        {
            popUp42.IsOpen = false;
            if (Map != null)
            {
                Map.mapEllipse.RadiusX = 150;
                Map.mapEllipse.RadiusY = 150;
                string dataH = "M 2 150 300 150";
                string dataV = "M  150 2  150 300";
                var converter = TypeDescriptor.GetConverter(typeof(Geometry));
                Map.LineHor.Data = (Geometry)converter.ConvertFrom(dataH);
                Map.LineVer.Data = (Geometry)converter.ConvertFrom(dataV);
            }
            Button42.IsChecked = true;
            var current = (System.Windows.Controls.CheckBox)sender;
            checkCurrent = current;
            checkCurrent1 = current;
            foreach (var checkBox in checklist)
            {
                if (checkBox != current)
                {
                    checkBox.IsChecked = false;
                }
            }


        }
        private void _25x25_Checked(object sender, RoutedEventArgs e)
        {
            popUp41.IsOpen = false;
            var current = (System.Windows.Controls.CheckBox)sender;
            checkCurrent = current;
            foreach (var checkBox in checklist)
            {
                if (checkBox != current)
                {
                    checkBox.IsChecked = false;
                }
            }


        }

        private void popUp42_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            e.Handled = true;
           // popUp42.IsOpen = false;
        }

        private void popUp41_Closed(object sender, EventArgs e)
        {
            popUp41.IsOpen = false;
        }

       

        private void popUp41_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            e.Handled = true;
        }


        private void _Unchecked(object sender, RoutedEventArgs e)
        {
            int i = 0;
            foreach (var checkBox in checklist)
            {
                if (checkBox.IsChecked == false)
                {
                    i++;
                }
                
            }
            if (i == checklist.Count)
            {
                checkCurrent.IsChecked = true;
            }
            
        }

        private void Button42_Checked(object sender, RoutedEventArgs e)
        {
            if (popUp42 != null)
            {
                if (_35mm.IsChecked == false && _45mm.IsChecked == false)
                {
                    checkCurrent1.IsChecked = true;
                }
            }
          
        }

        private void StackPanel_MouseLeave(object sender, MouseEventArgs e)
        {
            if (Button42.IsMouseOver)
                return;
            popUp42.IsOpen = false; 
        }

        private void StackPanel_MouseLeave_1(object sender, MouseEventArgs e)
        {
            if (Button41.IsMouseOver)
                return;
            popUp41.IsOpen = false;
        }

        private void Button42_Click(object sender, RoutedEventArgs e)
        {
            popUp42.IsOpen = true;
        }

        private void Button41_Click(object sender, RoutedEventArgs e)
        {
            popUp41.IsOpen = true;
        }

        private void SnapInkSave_Checked(object sender, RoutedEventArgs e)
        {
            LambdaControl.Trigger("VISUAL_SNAP_SAVE", this, new Dictionary<string, object>() { { "mode", 1 } });
        }

        private void SnapInkSave_Unchecked(object sender, RoutedEventArgs e)
        {
            LambdaControl.Trigger("VISUAL_SNAP_SAVE", this, new Dictionary<string, object>() { { "mode", 0 } });
        }

        private void AcquireInkSave_Checked(object sender, RoutedEventArgs e)
        {
            LambdaControl.Trigger("VISUAL_ACQUIRE_SAVE", this, new Dictionary<string, object>() { { "mode", 1 } });
        }

        private void AcquireInkSave_Unchecked(object sender, RoutedEventArgs e)
        {
            LambdaControl.Trigger("VISUAL_ACQUIRE_SAVE", this, new Dictionary<string, object>() { { "mode", 0 } });
        }

        private void ToggleButton1_Unchecked(object sender, RoutedEventArgs e)
        {
           if(ObjectiveSettingStackPanel.Children.Count == 1)
            {
                if (ObjectiveSettingStackPanel.Children[0] is RadioButton radio)
                {
                    ObjFoldText.Text = radio.Content.ToString();
                }

            }
        }

        private void ToggleButton2_Unchecked(object sender, RoutedEventArgs e)
        {
            ExposureFoldText.Text = WindowData.GetInstance().ExposureViewMode.ExposureShow;
        }

        private void StackPanel_MouseUp(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void StackPanel_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            //LambdaControl.Trigger("VIEW_CONTEXTMENU", this, new Dictionary<string, object>() { { "view", 0 } });
            //if (WindowData1.contextMenuPar.status == 4 )
            //{
            //    StartPreview();
            //};
           
        }

        private void StackPanel_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //MessageBox.Show("111111");
        }

        private void StartPreview()
        {
            Application.Current.Dispatcher.Invoke(delegate
            {
                Window mainwin = Application.Current.MainWindow;
                if (mainwin != null)
                {
                    Grid grid = (Grid)mainwin.FindName("stageAcquisition");
                    if (grid != null)
                    {
                        DockPanel dockPanel = (DockPanel)grid.Children[1];
                        ToggleButton toggleButton = (ToggleButton)dockPanel.Children[0];
                        if (toggleButton != null && toggleButton.IsChecked == false)
                        {
                            toggleButton.IsChecked = true;
                            toggleButton.Content = "停止预览";
                        }
                    }
                }

            });

          

        }








    }


}


