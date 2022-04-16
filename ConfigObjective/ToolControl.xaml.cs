using Global;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using Lambda;
using System.Windows.Input;
using Global.Mode.Config;

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
        bool first = true;
        private void UpdateGlobal()
        {
            if (!first)
                MessageBox.Show("根据参数更新");
            else
                first= false;

            ObjectiveSetting_Initialized();
            ViewMode_Initialized();
            MulDimensional_Initialized();
        }

        List<double> expose = new List<double> { 40000, 35714, 31250, 27778, 25000, 21739, 19608, 17241, 15385, 13514, 12048, 10753, 10000, 8403, 7463, 6623, 5882, 5208, 4630, 4000, 3636, 3226, 2865, 2545, 2252, 2000, 1773, 1575, 1397, 1239, 1099, 1000, 864, 767, 680, 604, 535, 500, 421, 374, 331, 294, 250, 231, 205, 182, 161, 143, 120, 113, 100, 89, 79, 70, 60, 55, 49, 43, 38, 34, 30, 27, 24, 21, 19, 17, 15, 13, 12, 10, 9, 8, 7, 6, 5, 4 };
        List<double> expose1 = new List<double> { 0.287, 0.323, 0.364, 0.410, 0.463, 0.500, 0.588, 0.663, 0.747, 0.842, 1, 1.071, 1.207, 1.360, 1.534, 1.729, 2.000, 2.197, 2.477, 2.792, 3.148, 3.548, 4.000 };
        List<string> data = new();

        private void LambdaLog(Message message)
        {
            //MessageBox.Show(message.Text);
            //if (message.Text.Contains("[MotorControl]: Connect success"))
            //    LambdaControl.Trigger("STAGE_SETTING_RESET", this, new Dictionary<string, object> { });
            //if (message.Text.Contains("应用组件加载完毕"))
            //{
            //    Dictionary<string, object> data = new() { { "mode", ViewMode } };
            //    LambdaControl.Trigger("IMAGING_MODE_SETTING", this, data);
            //}
        }


        public int ViewMode = 0;
        List<RadioButton> ViewModeradioButtons;
        private void UserControl_Initialized(object sender, EventArgs e)
        {
            Update.UpdateGlobal();
            //初始化硬件
            LambdaControl.LogHandler += LambdaLog;
            LambdaControl.CallEventHandler += LambdaControlCall;
            UniformGrid.DataContext = WindowData.GetInstance().MulDimensional;
            ComboBox1.ItemsSource = data1;
            foreach (var item in expose)
                data.Add("1/" + item.ToString());


            foreach (var item in expose1)
                data.Add(item.ToString("0.######"));


            for (int i = 0; i < expose.Count; i++)
                expose[i] = 1 / expose[i];
            expose.AddRange(expose1);


            Button301.Click += delegate
            {
                LambdaControl.Trigger("IMAGE_MODE_RESET", this, new Dictionary<string, object>() { });
            };
            Button302.Click += delegate
            {
                LambdaControl.Trigger("IMAGE_MODE_CLOSE", this, new Dictionary<string, object>() { });
            };
            ViewModeradioButtons = new List<RadioButton>() { Button31, Button32 , Button33 , Button34, Button35, Button36};

            Button201.Click += delegate
            {
                Dictionary<string, object> data = new() { };
                LambdaControl.Trigger("CAMERA_SETTING_RESET ", this, data);
            };
            Button211.Click += delegate
            {
                Dictionary<string, object> data = new() { };
                LambdaControl.Trigger("CAMERA_SETTING_WHITE_BALANCE",this, data);
            };

            //增益
            SliderAbbreviation1(Slider211, "CAMERA_SETTING_GAIN", "gain");
            UpDownControl1.SelectionChanged += UpDownControl1_SelectionChanged;
            UpDownControl1.SelectedIndex = 60;
            Slider212.ValueChanged += delegate (object sender, RoutedPropertyChangedEventArgs<double> e)
            {
                if (!WindowData.GetInstance().ACQUIRE)
                {
                    if (Slider212.Value < expose.Count)
                    {
                        Dictionary<string, object> data = new() { { "exposure", expose[(int)Slider212.Value] } };
                        LambdaControl.Trigger("CAMERA_SETTING_EXPOSURE",this, data);
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
                            Slider212.Value = e.OldValue;
                        }
                    }
                    else
                    {
                        sliderfirst = true;
                    }
                }
            };

            //锐度
            SliderAbbreviation(Slider213, "CAMERA_SETTING_SHARPNESS", "sharpness");
            //伽马
            SliderAbbreviation1(Slider214, "CAMERA_SETTING_GAMMA", "gamma");
            //降噪
            SliderAbbreviation(Slider215, "CAMERA_SETTING_DENOISE", "denoise");



            #region slider
            //照明孔径
            SliderAbbreviation(Slider311, "BRIGHT_FIELD_DIAMETER", "diameter");

            Slider312.ValueChanged += delegate (object sender, RoutedPropertyChangedEventArgs<double> e)
            {
                if (!WindowData.GetInstance().ACQUIRE)
                {
                    ColorAbbreviation("BRIGHT_FIELD_BRIGHTNESS", "brightness", ColorPciker311.SelectColor.ToString(), (int)Slider312.Value);
                }
                else
                {
                    if (sliderfirst)
                    {
                        var result = MessageBox.Show("是否修改当前多维采集设置", "显微镜", MessageBoxButton.YesNo);
                        if (result == MessageBoxResult.No)
                        {
                            sliderfirst = false;
                            Slider312.Value = e.OldValue;
                        }
                    }
                    else
                    {
                        sliderfirst = true;
                    }
                }
            };

            ColorPciker311.BrushValueChanged += delegate
            {
                ColorAbbreviation("BRIGHT_FIELD_BRIGHTNESS", "brightness", ColorPciker311.SelectColor.ToString(), (int)Slider312.Value);
            };
            ColorPciker312.BrushValueChanged += delegate
            {
                ColorAbbreviation("BRIGHT_FIELD_BRIGHTNESS", "brightness", ColorPciker312.SelectColor.ToString());
            };
            



            //照明内径
            SliderAbbreviation(Slider321, "DARK_FIELD_INNER", "inner");
            //照明外径
            SliderAbbreviation(Slider322, "DARK_FIELD_OUTER", "outer");
            //伽马
            SliderAbbreviation1(Slider323, "DARK_FIELD_GAMMA", "gamma");
            //自动模式
            ToggleButtonAbbreviation(Button321, "DARK_FIELD_AUTO", "auto");
            //亮度

            Slider324.ValueChanged += delegate (object sender, RoutedPropertyChangedEventArgs<double> e)
            {
                if (!WindowData.GetInstance().ACQUIRE)
                {
                    ColorAbbreviation("DARK_FIELD_BRIGHTNESS", "brightness", ColorPciker321.SelectColor.ToString(), (int)Slider324.Value);
                }
                else
                {
                    if (sliderfirst)
                    {
                        var result = MessageBox.Show("是否修改当前多维采集设置", "显微镜", MessageBoxButton.YesNo);
                        if (result == MessageBoxResult.No)
                        {
                            sliderfirst = false;
                            Slider324.Value = e.OldValue;
                        }
                    }
                    else
                    {
                        sliderfirst = true;
                    }
                }
            };

            ColorPciker321.BrushValueChanged += delegate
            {
                ColorAbbreviation("DARK_FIELD_BRIGHTNESS", "brightness", ColorPciker321.SelectColor.ToString(), (int)Slider324.Value);
            };
            ColorPciker322.BrushValueChanged += delegate
            {
                ColorAbbreviation("DARK_FIELD_BRIGHTNESS", "brightness", ColorPciker322.SelectColor.ToString());
            };


            //照明内径
            SliderAbbreviation(Slider331, "RHEIN_BERG_INNER", "inner");
            //照明外径
            SliderAbbreviation(Slider332, "RHEIN_BERG_OUTER", "outer");
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
            SliderAbbreviation1(Slider335, "RHEIN_BERG_GAMMA", "gamma");

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
            ToggleButtonAbbreviation(Button341, "RELIEF_CONTRAST_BG_COLLECTION", "collection");
            Button341.IsChecked = false;

            //相位

            //正则化参数
            SliderAbbreviation1(Slider351, "QUANTITATIVE_PHASE_REG", "regularization");

            //细节增强
            SliderAbbreviation(Slider352, "QUANTITATIVE_PHASE_DETAIL", "detail");
            //测试附加
            //Min
            SliderAbbreviation1(Slider353, "QUANTITATIVE_PHASE_MIN", "min");
            // Max
            SliderAbbreviation1(Slider354, "QUANTITATIVE_PHASE_MAX", "max");
            // Gamma
            SliderAbbreviation1(Slider355, "QUANTITATIVE_PHASE_GAMMA", "gamma");


            //相位背景校正
            ToggleButtonAbbreviation(Button351, "QUANTITATIVE_PHASE_BG_COLLECTION", "collection");
            Button351.IsChecked = false;

            //相差

            //相差滤波
            SliderAbbreviation1(Slider361, "PHASE_CONTRAST_FILTER", "filter");
            //对比度
            SliderAbbreviation1(Slider362, "PHASE_CONTRAST_CONTRAST", "contrast");
            //增益
            SliderAbbreviation1(Slider363, "PHASE_CONTRAST_GAIN", "gain");
            //明场权重
            SliderAbbreviation1(Slider364, "PHASE_CONTRAST_BF_WEIGHT", "weight");
            //测试附加
            //伽马
            SliderAbbreviation1(Slider365, "PHASE_CONTRAST_GAMMA", "gamma");
            //相差权重
            SliderAbbreviation1(Slider366, "PHASE_CONTRAST_PC_WEIGHT", "weight");

            //相差背景校正
            ToggleButtonAbbreviation(Button361, "PHASE_CONTRAST_BG_COLLECTION", "collection");
            Button361.IsChecked = false;

            #endregion


            WindowData windowStatus1 = WindowData.GetInstance();
            ButtonFront.Click += delegate
            {
                Dictionary<string, object> data = new() { { "step", windowStatus1.STAGE.MoveStep.XStep }, { "direction", 2 } };
                LambdaControl.Trigger("STAGE_MOVE_FRONT", ButtonFront, data);
            };

            ButtonRear.Click += delegate
            {
                Dictionary<string, object> data = new() { { "step", windowStatus1.STAGE.MoveStep.XStep }, { "direction", 3 } };
                LambdaControl.Trigger("STAGE_MOVE_REAR", ButtonRear, data);
            };
            
            ButtonRight.Click += delegate
            {
                Dictionary<string, object> data = new() { { "step", windowStatus1.STAGE.MoveStep.XStep }, { "direction", 1 } };
                LambdaControl.Trigger("STAGE_MOVE_RIGHT", ButtonRight, data);
            };

            ButtonLeft.Click += delegate
            {
                Dictionary<string, object> data = new() { { "step", windowStatus1.STAGE.MoveStep.XStep }, { "direction", 0 } };
                LambdaControl.Trigger("STAGE_MOVE_LEFT", ButtonLeft, data);
            };

            ButtonUp.Click += delegate
            {
                Dictionary<string, object> data = new() { { "step", windowStatus1.STAGE.MoveStep.ZStep }, { "direction", 4 } };
                LambdaControl.Trigger("STAGE_MOVE_UP", ButtonUp, data);
            };

            ButtonDown.Click += delegate
            {
                Dictionary<string, object> data = new() { { "step", windowStatus1.STAGE.MoveStep.ZStep }, { "direction", 5 } };
                LambdaControl.Trigger("STAGE_MOVE_DOWN", ButtonDown, data);
            };

            ButtonRe.Click += delegate
            {
                Dictionary<string, object> data = new() { { "step", 0 }, { "direction", 6 } };
                LambdaControl.Trigger("STAGE_MOVE_CENTRE", ButtonRe, data);
            };
            ButtonAutoFocus.Click += delegate
            {
                if ((bool)ToggleButtonZF.IsChecked)
                {
                    Dictionary<string, object> data = new() { { "mode", 0 } };
                    LambdaControl.Trigger("STAGE_AUTO_FOCUS", this, data);
                }
                else
                {
                    Dictionary<string, object> data = new() { { "mode", 1 } };
                    LambdaControl.Trigger("STAGE_AUTO_FOCUS", this, data);
                }

            };

            ToggleButtonXYF.Checked += delegate
            {
                windowStatus1.STAGE.MoveStep.XStep = 200;
                Update.UpdateSTAGE(windowStatus1.STAGE);
            };
            ToggleButtonXYF.Unchecked += delegate
            {
                windowStatus1.STAGE.MoveStep.XStep = 1000;
                Update.UpdateSTAGE(windowStatus1.STAGE);
            };
            ToggleButtonZF.Checked += delegate
            {
                windowStatus1.STAGE.MoveStep.ZStep = 200;
                Update.UpdateSTAGE(windowStatus1.STAGE);
            };
            ToggleButtonZF.Unchecked += delegate
            {
                windowStatus1.STAGE.MoveStep.ZStep = 1000;
                Update.UpdateSTAGE(windowStatus1.STAGE);
            };


            ToggleButton503.Checked += delegate
            {
                Update.UpdateMulDimensional(WindowData.GetInstance().MulDimensional);
            };
            ToggleButton503.Unchecked += delegate
            {
                ToggleButton505.IsChecked = false;
            };

            ToggleButton505.Checked += delegate
            {
                ToggleButton503.IsChecked = true;
            };
            ToggleButton505.Unchecked += delegate
            {

            };

            Canvas1.MouseMove += MainCanvas_MouseMove;
            Canvas1.MouseLeftButtonUp += MainCanvas_MouseLeftButtonUp;
            Canvas1.MouseLeftButtonDown += MainCanvas_MouseLeftButtonDown;
            Canvas1.PreviewMouseRightButtonUp += Canvas1_PreviewMouseRightButtonUp;
            Canvas1.PreviewMouseRightButtonDown += Canvas1_PreviewMouseRightButtonDown;
            Canvas1.PreviewMouseDown += Canvas1_PreviewMouseDown;

        }




        private void ColorAbbreviation(string TriggerName, string TriggerParameter, string hexString, int bright = -1)
        {
            int result = HexToInt(hexString, bright);

            Dictionary<string, object> data = new() { { TriggerParameter, result } };
            LambdaControl.Trigger(TriggerName, this, data);
        }

        private int HexToInt(string hexString, int bright=-1)
        {
            if (hexString[..1] == "#")
                hexString = hexString[1..];
            byte[] returnBytes = new byte[hexString.Length / 2];
            for (int i = 0; i < returnBytes.Length; i++)
                returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2).Trim(), 16);
            int a1, a2, a3;

            if (bright > -1)
            {
                a1 = (returnBytes[1] >> 4) * bright / 15;
                a2 = (returnBytes[2] >> 4) * bright / 15;
                a3 = (returnBytes[3] >> 4) * bright / 15;
            }
            else
            {
                a1 = returnBytes[1] >> 4;
                a2 = returnBytes[2] >> 4;
                a3 = returnBytes[3] >> 4;
            }
            return (a1 << 8) + (a2 << 4) + a3;
        }


        private void ColorAbbreviation1(string TriggerName, string TriggerParameter, string hexString, string hexString1, int bright)
        {
            int result = HexToInt(hexString, bright);
            result = (result << 12) + HexToInt(hexString, bright);

            Dictionary<string, object> data = new() { { TriggerParameter, result } };
            LambdaControl.Trigger(TriggerName, this, data);
        }

        bool sliderfirst = true;

        /// <summary>
        /// SliderAbbreviation(int)
        /// </summary>
        private Slider SliderAbbreviation(Slider slider, string TriggerName, string TriggerParameter)
        {
            slider.ValueChanged += delegate (object sender, RoutedPropertyChangedEventArgs<double> e)
            {

                if (!WindowData.GetInstance().ACQUIRE)
                {
                    Dictionary<string, object> data = new() { { TriggerParameter, (int)slider.Value } };
                    LambdaControl.Trigger(TriggerName, slider,data);
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
                if (!WindowData.GetInstance().ACQUIRE)
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
                Dictionary<string, object> data = new() { { TriggerParameter, toggleButton.IsChecked } };
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
                string filePath = "222.json";
                List<System.Windows.Shapes.Rectangle> childList = GetChildObjects<System.Windows.Shapes.Rectangle>(this.Canvas1);
                var mulDimensional = WindowData.GetInstance().MulDimensional;
                mulDimensional.mulDimensionalAreas.Clear();
                mulDimensional.mulDimensionalPoints.Clear();

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
                Global.Mode.Config.Spot spot = new Global.Mode.Config.Spot();
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
                List<int> Mode = new();
                if (checkbox51.IsChecked == true)
                    Mode.Add(0);
                if (checkbox52.IsChecked == true)
                    Mode.Add(1);
                if (checkbox53.IsChecked == true)
                    Mode.Add(2);
                if (checkbox54.IsChecked == true)
                    Mode.Add(3);
                if (checkbox55.IsChecked == true)
                    Mode.Add(4);
                if (checkbox56.IsChecked == true)
                    Mode.Add(5);

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
                string Dimensions = "xy";
                if (ToggleButton503.IsChecked == true)
                {
                    Dimensions += "z";
                }
                if (ToggleButton504.IsChecked == true)
                {
                    Dimensions += "t";
                }
                if (ToggleButton506.IsChecked == true)
                {
                    Dimensions += "p";
                }
                if (ToggleButton505.IsChecked == true)
                {
                    Dimensions += "edof";
                }

                testMean.Dimensional.Dimensions = Dimensions;

                testMean.STAGE = WindowData.GetInstance().STAGE;
                WindowData.Config.Dimensional = testMean.Dimensional;
                WindowData.Config.Spot = testMean.Spot;
                WindowData.Config.STAGE = testMean.STAGE;
                testMean.ToJsonFile(filePath);
                Update.UpdateMulDimensional(WindowData.GetInstance().MulDimensional);
                Dictionary<string, object> data = new() { { "data", filePath } };
                LambdaControl.Trigger("START_ACQUIRE1", this, data);
            }
            return 1;
        }

        private void UpdateMul_Click(object sender, RoutedEventArgs e)
        {
            Update.UpdateMulDimensional(WindowData.GetInstance().MulDimensional);
        }


        private void UpDownControl_Loaded(object sender, RoutedEventArgs e)
        {
            UpDownControl upDownButton1 = sender as UpDownControl;
            upDownButton1.SetList(data);
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Slider212_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Slider slider  = sender as Slider;
            if (UpDownControl1!=null)
            {
                UpDownControl1.SelectedIndex = (int)slider.Value;
                ToggleButton210.IsChecked = false;
            }
        }

        private void UpDownControl1_SelectionChanged(object sender, RoutedEventArgs e)
        {
            Slider212.Value = UpDownControl1.SelectedIndex;
        }

        //List<string> data1 = new() { "RGB64 (256x4)", "RGB64 (320x240)", "RGB64 (320x480)", "RGB64 (352x240)", "RGB64 (352x288)", "RGB64 (384x288)", "RGB64 (640x240)", "RGB64 (640x288)", "RGB64 (640x480)", "RGB64 (704x576)", "RGB64 (720x240)", "RGB64 (720x288)", "RGB64 (720x480)", "RGB64 (720x576)", "RGB64 (768x576)", "RGB64 (1024x768)", "RGB64 (1280x960)", "RGB64 (1280x1024)", "RGB64 (1600x1200)", "RGB64 (1920x1080)", "RGB64 (2048x1536)", "RGB64 (2048x2048)", "RGB64 (2448x2048)", "Y16 (256x4)", "Y16 (320x240)", "Y16 (320x480)", "Y16 (352x240)", "Y16 (352x288)", "Y16 (384x288)", "Y16 (640x240)", "Y16 (640x288)", "Y16 (640x480)", "Y16 (704x576)", "Y16 (720x240)", "Y16 (720x288)", "Y16 (720x480)", "Y16 (720x576)", "Y16 (768x576)", "Y16 (1024x768)", "Y16 (1280x960)", "Y16 (1280x1024)", "Y16 (1600x1200)", "Y16 (1920x1080)", "Y16 (2048x1536)", "Y16 (2048x2048)", "Y16 (2448x2048)", "Y411 (256x4)", "Y411 (320x240)", "Y411 (320x480)", "Y411 (352x240)", "Y411 (352x288)", "Y411 (384x288)", "Y411 (640x240)", "Y411 (640x288)", "Y411 (640x480)", "Y411 (704x576)", "Y411 (720x240)", "Y411 (720x288)", "Y411 (720x480)", "Y411 (720x576)", "Y411 (768x576)", "Y411 (1024x768)", "Y411 (1280x960)", "Y411 (1280x1024)", "Y411 (1600x1200)", "Y411 (1920x1080)", "Y411 (2048x1536)", "Y411 (2048x2048)", "Y411 (2448x2048)", "Y800 (256x4)", "Y800 (320x240)", "Y800 (320x480)", "Y800 (352x240)", "Y800 (352x288)", "Y800 (384x288)", "Y800 (640x240)", "Y800 (640x288)", "Y800 (640x480)", "Y800 (704x576)", "Y800 (720x240)", "Y800 (720x288)", "Y800 (720x480)", "Y800 (720x576)", "Y800 (768x576)", "Y800 (1024x768)", "Y800 (1280x960)", "Y800 (1280x1024)", "Y800 (1600x1200)", "Y800 (1920x1080)", "Y800 (2048x1536)", "Y800 (2048x2048)", "Y800 (2448x2048)", "YUY2 (256x4)", "YUY2 (320x240)", "YUY2 (320x480)", "YUY2 (352x240)", "YUY2 (352x288)", "YUY2 (384x288)", "YUY2 (640x240)", "YUY2 (640x288)", "YUY2 (640x480)", "YUY2 (704x576)", "YUY2 (720x240)", "YUY2 (720x288)", "YUY2 (720x480)", "YUY2 (720x576)", "YUY2 (768x576)", "YUY2 (1024x768)", "YUY2 (1280x960)", "YUY2 (1280x1024)", "YUY2 (1600x1200)", "YUY2 (1920x1080)", "YUY2 (2048x1536)", "YUY2 (2048x2048)", "YUY2 (2448x2048)", "RGB24 (256x4)", "RGB24 (320x240)", "RGB24 (320x480)", "RGB24 (352x240)", "RGB24 (352x288)", "RGB24 (384x288)", "RGB24 (640x240)", "RGB24 (640x288)", "RGB24 (640x480)", "RGB24 (704x576)", "RGB24 (720x240)", "RGB24 (720x288)", "RGB24 (720x480)", "RGB24 (720x576)", "RGB24 (768x576)", "RGB24 (1024x768)", "RGB24 (1280x960)", "RGB24 (1280x1024)", "RGB24 (1600x1200)", "RGB24 (1920x1080)", "RGB24 (2048x1536)", "RGB24 (2048x2048)", "RGB24 (2448x2048)", "RGB32 (256x4)", "RGB32 (320x240)", "RGB32 (320x480)", "RGB32 (352x240)", "RGB32 (352x288)", "RGB32 (384x288)", "RGB32 (640x240)", "RGB32 (640x288)", "RGB32 (640x480)", "RGB32 (704x576)", "RGB32 (720x240)", "RGB32 (720x288)", "RGB32 (720x480)", "RGB32 (720x576)", "RGB32 (768x576)", "RGB32 (1024x768)", "RGB32 (1280x960)", "RGB32 (1280x1024)", "RGB32 (1600x1200)", "RGB32 (1920x1080)", "RGB32 (2048x1536)", "RGB32 (2048x2048)", "RGB32 (2448x2048)" };

        List<string> data1 = new() { "RGB32 (640x480)", "RGB32 (1280x960)" , "RGB64 (2448x2048)" };

        private void ComboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender is ComboBox combobox)
            {
                Dictionary<string, object> data = new() { { "format", combobox.SelectedItem } };
                LambdaControl.Trigger("CAMERA_SETTING_VIDEO_FORMAT", this, data);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        List<RheinbergPattern> rheinbergPatterns;

        private void Button331_Click(object sender, RoutedEventArgs e)
        {
            RheinbergPatternEditorWindow rheinbergPatternEditorWindow = new RheinbergPatternEditorWindow(rheinbergPatterns);
            rheinbergPatternEditorWindow.Closed += RheinbergAdd;
            rheinbergPatternEditorWindow.ShowDialog();
        }
        public RheinbergPattern SelectColor;
        public int RheinbergSelectMode = 0;


        private void RheinbergAdd(object sender, EventArgs e)
        {
            RheinbergPatternEditorWindow rheinbergPatternEditorWindow = sender as RheinbergPatternEditorWindow;
            SelectColor = rheinbergPatternEditorWindow.SelectColor;
            Color330.Fill = SelectColor.Rheinberg0;
            Color331.Fill = SelectColor.Rheinberg1;
            Color332.Fill = SelectColor.Rheinberg2;

            RheinbergSelectMode = rheinbergPatternEditorWindow.SelectedIndex;

            int darkness1 = HexToInt(Color331.Fill.ToString(), (int)Slider334.Value);
            int darkness2 = HexToInt(Color332.Fill.ToString(), (int)Slider334.Value);
            int bright = HexToInt(Color330.Fill.ToString(), (int)Slider333.Value);

            Color330.Visibility = Visibility.Visible;
            Color331.Visibility = Visibility.Visible;
            Color332.Visibility = Visibility.Visible;

            if (RheinbergSelectMode == 0)
            {
                Color332.Visibility =Visibility.Collapsed;
                darkness2 = -1;
            }
            if (RheinbergSelectMode == 3)
            {
                darkness1 = -1;
                darkness2 = -1;
                bright = -1;

                Color330.Visibility = Visibility.Collapsed;
                Color331.Visibility = Visibility.Collapsed;
                Color332.Visibility = Visibility.Collapsed;
            }


            Dictionary<string, object> data = new() { { "mode", RheinbergSelectMode },{ "bright", bright }, { "darkness1", darkness1 },{ "darkness2", darkness2 } };
            LambdaControl.Trigger("RHEIN_BERG_SETDATA", this, data);
            

            rheinbergPatterns = rheinbergPatternEditorWindow.rheinbergPatterns;
            rheinbergPatternEditorWindow.Closed -= RheinbergAdd;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ToggleButton radioButton = sender as ToggleButton;
            Dictionary<string, object> data = new() { { "auto", radioButton.IsChecked } };
            LambdaControl.Trigger("CAMERA_SETTING_EXPOSURE_AUTO", this, data);
        }



        private void ViewMode_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            string s = radioButton.Tag.ToString();
            if (s != null)
            {
                ViewMode = int.Parse(s);
                Dictionary<string, object> data = new() { { "mode", ViewMode } };
                LambdaControl.Trigger("IMAGING_MODE_SETTING", this, data);
            }
        }


    }
}
