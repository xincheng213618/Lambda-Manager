using Global;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using Lambda;
using System.Windows.Input;
using Global.Mode.Config;
using System.Text;
using Global.Extensions;
using System.Windows.Media.Imaging;
using System.Windows.Media;

namespace ConfigObjective
{

    public partial class ToolControl : UserControl
    {
        WindowData WindowData = WindowData.GetInstance();
        public ToolControl()
        {
            Update.UpdateEventHandler += UpdateGlobal;
            InitializeComponent();
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

        /// <summary>
        /// 日志监听
        /// </summary>
        private void LambdaLog(Message message)
        {
            //MessageBox.Show(message.Text);
            //if (message.Text.Contains("[MotorControl]: Connect success"))
            //    LambdaControl.Trigger("STAGE_SETTING_RESET", this, new Dictionary<string, object> { });
            //if (message.Text.Contains("应用组件加载完毕"))
            //    LambdaControl.Trigger("IMAGING_MODE_SETTING", this, new Dictionary<string, object>() { { "mode", ViewMode } });
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

        }
         

        private void UserControl_Initialized(object sender, EventArgs e)
        {
            CricalBase.Fill = WindowData.image;

            //初始化硬件
            Update.UpdateGlobal();
            ObjectiveSetting_Initialize();
            ViewMode_Initialize();
            CameraSetting_Initialize();

            Stage_Initialize();
            MulDimensional_Initialize();


            IsFirstUpdate = true;

            LambdaControl.Initialize(LambdaLog, LambdaLog, null, LambdaControlCall, null, null);
            ////日志监听
            //LambdaControl.LogHandler += LambdaLog;
            ////事件监听
            //LambdaControl.CallEventHandler += LambdaControlCall;

            StackPanelMul.DataContext = WindowData.MulDimensional;

            ComboBox1.ItemsSource = data1;
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


        bool sliderfirst = true;

        /// <summary>
        /// SliderAbbreviation(int)
        /// </summary>
        private Slider SliderAbbreviation(Slider slider, string TriggerName, string TriggerParameter)
        {
            slider.ValueChanged += delegate (object sender, RoutedPropertyChangedEventArgs<double> e)
            {

                if (!WindowData.ACQUIRE)
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
                if (!WindowData.ACQUIRE)
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

        private int LambdaControlCall(string type, object sender, EventArgs e)
        {
            if (type == "STOP_ACQUIRE")
            {
                var mulDimensional = WindowData.GetInstance().MulDimensional;
                mulDimensional.mulDimensionalAreas.Clear();
                mulDimensional.mulDimensionalPoints.Clear();

                List<System.Windows.Shapes.Rectangle> childList = GetChildObjects<System.Windows.Shapes.Rectangle>(this.Canvas1);
                foreach (var child in childList)
                {
                    if (Canvas.GetLeft(child) >= 0)
                        if (child.Width == 0 || child.Height == 0)
                        {
                            mulDimensional.mulDimensionalPoints.Add(new MulDimensionalPoint(new Point(Canvas.GetLeft(child), Canvas.GetTop(child))));
                        }
                        else
                        {
                            if (child.Width > 10)
                                mulDimensional.mulDimensionalAreas.Add(new MulDimensionalArea(new Rect(Canvas.GetLeft(child), Canvas.GetTop(child), child.Width, child.Height)));

                        }

                }
                List<Border> childList1 = GetChildObjects<Border>(this.Canvas1);
                foreach (var child in childList1)
                {
                    if (Canvas.GetLeft(child) >= 0)
                        if (child.Width == 0 || child.Height == 0)
                        {
                            mulDimensional.mulDimensionalPoints.Add(new MulDimensionalPoint(new Point(Canvas.GetLeft(child), Canvas.GetTop(child))));
                        }
                        else
                        {
                            if (child.Width > 10)
                                mulDimensional.mulDimensionalAreas.Add(new MulDimensionalArea(new Rect(Canvas.GetLeft(child), Canvas.GetTop(child), child.Width, child.Height)));
                        }

                }
                var spot = new Global.Mode.Config.Spot();
                foreach (var item in mulDimensional.mulDimensionalPoints)
                {
                    List<int> points = new List<int>() { item.X, item.Y };
                    spot.Includes.Add(points);
                }
                foreach (var item in mulDimensional.mulDimensionalAreas)
                {
                    List<int> points = new List<int>() { item.X, item.Y, item.Width, item.Height };
                    spot.Includes.Add(points);
                }
                TestMean testMean = new TestMean();
                testMean.Spot = spot;

                List<string> Mode = new();
                if (checkbox51.IsChecked == true)
                    Mode.Add("bright-field");
                if (checkbox52.IsChecked == true)
                    Mode.Add("dark-field");
                if (checkbox53.IsChecked == true)
                    Mode.Add("rheinberg");
                if (checkbox54.IsChecked == true)
                    Mode.Add("relief-contrast");
                if (checkbox55.IsChecked == true)
                    Mode.Add("quantitative-phase");
                if (checkbox56.IsChecked == true)
                    Mode.Add("phase-contrast");

                testMean.Dimensional = new Global.Mode.Config.Dimensional() { Mode = Mode };


                Global.Mode.Config.TimeWiseSerial timeWiseSerial = new Global.Mode.Config.TimeWiseSerial();


                timeWiseSerial.Times = mulDimensional.TNumberEnable ? 0 : mulDimensional.TNumber;
                timeWiseSerial.Duration = mulDimensional.TIntervalEnable ? 0 : mulDimensional.TInterval;

                testMean.Dimensional.TimeWiseSerial = timeWiseSerial;

                Global.Mode.Config.ZstackWiseSerial zstackWiseSerial = new Global.Mode.Config.ZstackWiseSerial();
                zstackWiseSerial.ZStep = mulDimensional.Zstep;
                zstackWiseSerial.ZBegin = mulDimensional.ZStart;
                zstackWiseSerial.ZEnd = mulDimensional.ZEnd;
                testMean.Dimensional.ZstackWiseSerial = zstackWiseSerial;

                var Dimensions = new StringBuilder();

                Dimensions.Append("xy");
                if (ToggleButton503.IsChecked == true)
                    Dimensions.Append('z');
                if (ToggleButton504.IsChecked == true)
                    Dimensions.Append('t');
                if (ToggleButton506.IsChecked == true)
                    Dimensions.Append('p');
                if (ToggleButton505.IsChecked == true)
                    Dimensions.Append("edof");


                testMean.Dimensional.Dimensions = Dimensions.ToString();
                testMean.Dimensional.Savedir = WindowData.SolutionDir;

                testMean.Stage = WindowData.GetInstance().Stage;
                WindowData.Config.Dimensional = testMean.Dimensional;
                WindowData.Config.Spot = testMean.Spot;
                WindowData.Config.Stage = testMean.Stage;
                //testMean.ToJsonFile("222.json");
                LambdaControl.Trigger("START_ACQUIRE1", this, testMean.ToJson());
            }
            return 1;
        }


    }


}


