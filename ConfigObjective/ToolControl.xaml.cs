using Global;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using Lambda;
using ConfigObjective.UserControls;
using System.Windows.Input;
using Global.Mode.Config;
using System.Text;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using System.Windows.Data;

namespace ConfigObjective
{

    public partial class ToolControl : UserControl
    {
        WindowData windowData;
        public ToolControl()
        {
            windowData = WindowData.GetInstance();
            Update.UpdateEventHandler += UpdateGlobal;
            InitializeComponent();
        }

        /// <summary>
        /// 初始化写在前面
        /// </summary>
        private void UserControl_Initialized(object sender, EventArgs e)
        {




            //TabControl tabControl = (TabControl)mainwin.FindName("leftTab");
            //Border border = (Border)tabControl.Parent;
            ////tabControl.Parent 
            //if (tabControl == null) return;
            //TabItem propertySetItem = new TabItem();
            //propertySetItem.Header = "属性设置";
            //ScrollViewer scrollViewer = new ScrollViewer();
            //scrollViewer.HorizontalScrollBarVisibility = ScrollBarVisibility.Disabled;
            //scrollViewer.VerticalScrollBarVisibility = ScrollBarVisibility.Auto;
            //Viewbox proViewBox = new Viewbox();
            //proViewBox.VerticalAlignment = VerticalAlignment.Top;
            //proViewBox.Stretch = Stretch.Uniform;
            //Binding viewBoxWidthBind = new Binding();
            //viewBoxWidthBind.Source = border;
            //viewBoxWidthBind.Path = new PropertyPath("ActualWidth");
            //proViewBox.SetBinding(Border.WidthProperty, viewBoxWidthBind);


            //proViewBox.Child = stackPanel;
            //scrollViewer.Content = proViewBox;
            //propertySetItem.Content = scrollViewer;

            //tabControl.Items.Add(propertySetItem);



            AddEventHandler();
            //初始化硬件

            ObjectiveSetting_Initialize();
            ViewMode_Initialize();
            CameraSetting_Initialize();

            Map.moveButton.DataContext = windowData.mapModel;
            Stage_Initialize();
            MulDimensional_Initialize();

            Update.UpdateGlobal();
            IsFirstUpdate = true;

            ComboBox1.ItemsSource = windowData.deviceInformation.CameraResolution;
            UpDownControl1.SelectedIndex = 60;

            #region slider
            SliderAbbreviation(Slider311, "BRIGHT_FIELD_DIAMETER", "diameter");
            //照明内径
            SliderAbbreviation(Slider321, "DARK_FIELD_INNER", "inner");
            //照明外径
            SliderAbbreviation(Slider322, "DARK_FIELD_OUTER", "outer");
            //伽马
            //SliderAbbreviation1(Slider323, "DARK_FIELD_GAMMA", "gamma");


            //背景校正
            ToggleButtonAbbreviation(Button322, "DARK _FIELD _BG_COLLECTION", "collection");
            Button322.IsChecked = false;


            ////照明内径
            //SliderAbbreviation(Slider331, "RHEIN_BERG_INNER", "inner");
            ////照明外径
            //SliderAbbreviation(Slider332, "RHEIN_BERG_OUTER", "outer");
            //明场照明亮度
            Slider333.ValueChanged += delegate (object sender, RoutedPropertyChangedEventArgs<double> e)
            {
                if (!WindowData.GetInstance().ACQUIRE)
                {

                    int darkness1 = HexToInt(Color331.Fill.ToString(), (int)Slider334.Value);
                    int darkness2 = HexToInt(Color332.Fill.ToString(), (int)Slider334.Value);
                    int bright = HexToInt(Color330.Fill.ToString(), (int)Slider333.Value);

                    if (RheinbergSelectMode == 0)
                    {
                        darkness2 = -1;
                    }
                    if (RheinbergSelectMode == 3)
                    {
                        darkness1 = -1;
                        darkness2 = -1;
                        bright = -1;
                    }

                    ViewMode.Reinberg.BrightColor = bright;

                    Dictionary<string, object> data = new() { { "mode", RheinbergSelectMode }, { "bright", bright }, { "darkness1", darkness1 }, { "darkness2", darkness2 } };
                    LambdaControl.Trigger("RHEIN_BERG_SETDATA", this, data);
                }
                else
                {
                    if (sliderfirst)
                    {
                        var result = MessageBox.Show("是否修改当前多维采集设置", "显微镜", MessageBoxButton.YesNo);
                        if (result == MessageBoxResult.No)
                        {
                            sliderfirst = false;
                            Slider333.Value = e.OldValue;
                        }
                    }
                    else
                    {
                        sliderfirst = true;
                    }
                }
            };

            //暗场照明亮度
            Slider334.ValueChanged += delegate (object sender, RoutedPropertyChangedEventArgs<double> e)
            {
                if (!WindowData.GetInstance().ACQUIRE)
                {
                    int darkness1 = HexToInt(Color331.Fill.ToString(), (int)Slider334.Value);
                    int darkness2 = HexToInt(Color332.Fill.ToString(), (int)Slider334.Value);
                    int bright = HexToInt(Color330.Fill.ToString(), (int)Slider333.Value);
                    ViewMode.Reinberg.BrightColor = darkness1;

                    if (RheinbergSelectMode == 0)
                    {
                        darkness2 = -1;
                    }
                    if (RheinbergSelectMode == 3)
                    {
                        darkness1 = -1;
                        darkness2 = -1;
                        bright = -1;
                    }

                    Dictionary<string, object> data = new() { { "mode", RheinbergSelectMode }, { "bright", bright }, { "darkness1", darkness1 }, { "darkness2", darkness2 } };
                    LambdaControl.Trigger("RHEIN_BERG_SETDATA", this, data);
                }
                else
                {
                    if (sliderfirst)
                    {
                        var result = MessageBox.Show("是否修改当前多维采集设置", "显微镜", MessageBoxButton.YesNo);
                        if (result == MessageBoxResult.No)
                        {
                            sliderfirst = false;
                            Slider334.Value = e.OldValue;
                        }
                    }
                    else
                    {
                        sliderfirst = true;
                    }
                }
            };

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

            //差分背景校正
            //ToggleButtonAbbreviation(Button341, "RELIEF_CONTRAST_BG_COLLECTION", "collection");

            //相位

            //正则化参数
            SliderAbbreviation1(Slider351, "QUANTITATIVE_PHASE_REG", "regularization");

            //细节增强
            //SliderAbbreviation(Slider352, "QUANTITATIVE_PHASE_DETAIL", "detail");
            //测试附加
            //Min
            SliderAbbreviation1(Slider353, "QUANTITATIVE_PHASE_MIN", "min");
            // Max
            SliderAbbreviation1(Slider354, "QUANTITATIVE_PHASE_MAX", "max");
            // Gamma
            SliderAbbreviation1(Slider355, "QUANTITATIVE_PHASE_GAMMA", "gamma");


            //相位背景校正
            //ToggleButtonAbbreviation(Button351, "QUANTITATIVE_PHASE_BG_COLLECTION", "collection");

            //相差

            //相差滤波
            SliderAbbreviation1(Slider361, "PHASE_CONTRAST_FILTER", "filter");
            ////对比度
            //SliderAbbreviation1(Slider362, "PHASE_CONTRAST_CONTRAST", "contrast");
            //增益
            //SliderAbbreviation1(Slider363, "PHASE_CONTRAST_GAIN", "gain");
            //明场权重
            SliderAbbreviation1(Slider364, "PHASE_CONTRAST_BF_WEIGHT", "weight");
            //测试附加
            //伽马
            SliderAbbreviation1(Slider365, "PHASE_CONTRAST_GAMMA", "gamma");
            //相差权重
            SliderAbbreviation1(Slider366, "PHASE_CONTRAST_PC_WEIGHT", "weight");

            //相差背景校正
            //ToggleButtonAbbreviation(Button361, "PHASE_CONTRAST_BG_COLLECTION", "collection");

            #endregion

        }

        bool IsFirstLoad = true;
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            if (IsFirstLoad)
            {
                IsFirstLoad = false;
                if (this.Parent is StackPanel stackPanel1)
                    if (stackPanel1.Parent is Viewbox viewbox1)
                        if (viewbox1.Parent is ScrollViewer scrollViewer1)
                        {
                            stackPanel1.Children.Remove(this);

                            StackPanel stackPanel = new StackPanel() { Name = "acquireView" };
                            stackPanel.HorizontalAlignment = HorizontalAlignment.Stretch;
                            stackPanel.Children.Add(this);
                            Viewbox viewbox = new Viewbox() { VerticalAlignment = VerticalAlignment.Top,Stretch = Stretch.Uniform};
                            viewbox.Child = stackPanel;
                            scrollViewer1.Content = viewbox;
                        }

            }

        }


        bool IsFirstUpdate = true;
        private void UpdateGlobal()
        {
            if (!IsFirstUpdate)
                MessageBox.Show("根据参数更新");

            CameraSetting_Update();
            ObjectiveSetting_Update();
            ViewMode_Update();
            Stage_Update();
            MulDimensional_Update();
            if (IsFirstUpdate)
                IsFirstUpdate = false;


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
                    Dictionary<string, object> data = new() { { TriggerParameter, (double)slider.Value } };
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


    }


}


