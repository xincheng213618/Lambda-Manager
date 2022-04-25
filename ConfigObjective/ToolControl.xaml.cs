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
            CameraSetting_Initialized();
            Stage_Initialized();
            MulDimensional_Initialized();
        }

        List<double> expose = new List<double> { 40000, 35714, 31250, 27778, 25000, 21739, 19608, 17241, 15385, 13514, 12048, 10753, 10000, 8403, 7463, 6623, 5882, 5208, 4630, 4000, 3636, 3226, 2865, 2545, 2252, 2000, 1773, 1575, 1397, 1239, 1099, 1000, 864, 767, 680, 604, 535, 500, 421, 374, 331, 294, 250, 231, 205, 182, 161, 143, 120, 113, 100, 89, 79, 70, 60, 55, 49, 43, 38, 34, 30, 27, 24, 21, 19, 17, 15, 13, 12, 10, 9, 8, 7, 6, 5, 4 };
        List<double> expose1 = new List<double> { 0.287, 0.323, 0.364, 0.410, 0.463, 0.500, 0.588, 0.663, 0.747, 0.842, 1, 1.071, 1.207, 1.360, 1.534, 1.729, 2.000, 2.197, 2.477, 2.792, 3.148, 3.548, 4.000 };
        List<string> data = new();

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
            //初始化硬件
            Update.UpdateGlobal();
            //日志监听
            LambdaControl.LogHandler += LambdaLog;
            //事件监听
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


            //照明内径
            SliderAbbreviation(Slider321, "DARK_FIELD_INNER", "inner");
            //照明外径
            SliderAbbreviation(Slider322, "DARK_FIELD_OUTER", "outer");
            //伽马
            SliderAbbreviation1(Slider323, "DARK_FIELD_GAMMA", "gamma");
            //自动模式
            ToggleButtonAbbreviation(Button321, "DARK_FIELD_AUTO", "auto");
            //亮度


            ColorPciker322.BrushValueChanged += delegate
            {
                ColorAbbreviation("DARK_FIELD_BRIGHTNESS", "brightness", ColorPciker322.SelectColor.ToString());
            };

            //背景校正
            ToggleButtonAbbreviation(Button322, "DARK _FIELD _BG_COLLECTION", "collection");
            Button322.IsChecked = false;


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
                    Mode.Add("phase-contras");

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
                testMean.ToJsonFile(filePath);

                LambdaControl.Trigger("START_ACQUIRE1", this, new Dictionary<string, object>() { { "data", filePath } });
            }
            return 1;
        }

        private void UpDownControl_Loaded(object sender, RoutedEventArgs e)
        {
            UpDownControl upDownButton1 = sender as UpDownControl;
            upDownButton1.SetList(data);
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
            LambdaControl.Trigger("CAMERA_SETTING_VIDEO_FORMAT", this, new Dictionary<string, object>() { { "format", ComboBox1.SelectedItem } });
        }

        List<RheinbergPattern> rheinbergPatterns;

        private void Button331_Click(object sender, RoutedEventArgs e)
        {
            RheinbergPatternEditorWindow rheinbergPatternEditorWindow = new(rheinbergPatterns);
            rheinbergPatternEditorWindow.Closed += RheinbergAdd;
            rheinbergPatternEditorWindow.ShowDialog();
        }
        public RheinbergPattern SelectColor;
        public int RheinbergSelectMode = 0;


        private void RheinbergAdd(object sender, EventArgs e)
        {
            RheinbergPatternEditorWindow rheinbergPatternEditorWindow = sender as RheinbergPatternEditorWindow;
            SelectColor = rheinbergPatternEditorWindow.SelectColor;
            RadioButton radioButton = rheinbergPatternEditorWindow.SelectRadionButton;

            if (radioButton.Parent is UniformGrid uniform)
            {
                uniform.Children.Remove(radioButton);
                DockPanel331.Children.Clear();
                DockPanel331.Children.Add(radioButton);

                //if (radioButton.Content is Canvas canvas)
                //{
                //    radioButton.Content = null;

                //}

            }



            Color330.Fill = SelectColor.Rheinberg0;
            Color331.Fill = SelectColor.Rheinberg1;
            Color332.Fill = SelectColor.Rheinberg2;

            RheinbergSelectMode = rheinbergPatternEditorWindow.SelectedIndex;

            int darkness1 = HexToInt(Color331.Fill.ToString(), (int)Slider334.Value);
            int darkness2 = HexToInt(Color332.Fill.ToString(), (int)Slider334.Value);
            int bright = HexToInt(Color330.Fill.ToString(), (int)Slider333.Value);

            //Color330.Visibility = Visibility.Visible;
            //Color331.Visibility = Visibility.Visible;
            //Color332.Visibility = Visibility.Visible;

            if (RheinbergSelectMode == 0)
            {
                //Color332.Visibility =Visibility.Collapsed;
                darkness2 = -1;
            }
            if (RheinbergSelectMode == 3)
            {
                darkness1 = -1;
                darkness2 = -1;
                bright = -1;

                //Color330.Visibility = Visibility.Collapsed;
                //Color331.Visibility = Visibility.Collapsed;
                //Color332.Visibility = Visibility.Collapsed;
            }

            LambdaControl.Trigger("RHEIN_BERG_SETDATA", this, new Dictionary<string, object>() { { "mode", RheinbergSelectMode }, { "bright", bright }, { "darkness1", darkness1 }, { "darkness2", darkness2 } });
            
            rheinbergPatterns = rheinbergPatternEditorWindow.rheinbergPatterns;
            rheinbergPatternEditorWindow.Closed -= RheinbergAdd;
        }

        private void ToggleButton331_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
