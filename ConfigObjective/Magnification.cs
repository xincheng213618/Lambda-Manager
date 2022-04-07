using Global;
using GLobal.Mode.Config;
using Lambda;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace ConfigObjective
{
    public class Magnification : LambdaControl
    {
        static Magnification()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Magnification), new FrameworkPropertyMetadata(typeof(Magnification)));
        }
        private readonly System.Windows.Threading.DispatcherTimer _timer = new() { Interval = TimeSpan.FromSeconds(0.2) };

        List<ObjectiveSetting> ObjectiveSettingList = new List<ObjectiveSetting>()
        {
            new ObjectiveSetting (){ID =0, Name ="奥林巴斯",Magnitude="4X", NA=0.1,IsEnabled =false},
            new ObjectiveSetting (){ID =1, Name ="奥林巴斯",Magnitude="10X", NA=0.25,IsChecked=true},
            new ObjectiveSetting (){ID =2, Name ="奥林巴斯",Magnitude="20X", NA=0.4,IsEnabled =false},
            new ObjectiveSetting (){ID =3, Name ="奥林巴斯",Magnitude="40X", NA=0.65,IsEnabled =false},
            new ObjectiveSetting (){ID =4, Name ="奥林巴斯",Magnitude="100X", NA=0.65,IsEnabled =false},
        };

        public override void BeginInit()
        {
            base.BeginInit();
        }

        static void Window_PreviewKeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            ModifierKeys modifiers = Keyboard.Modifiers;
            if (Keyboard.IsKeyDown(Key.LWin) || Keyboard.IsKeyDown(Key.RWin))
                modifiers |= ModifierKeys.Windows;
            Key key = e.Key;

            if (key == Key.System)
                key = e.SystemKey;


            // Pressing delete, backspace or escape without modifiers clears the current value
            if (modifiers == ModifierKeys.None && (key == Key.Delete || key == Key.Back || key == Key.Escape))
            {
                return;
            }

            // If no actual key was pressed - retur
            if (key == Key.LeftCtrl || key == Key.RightCtrl || key == Key.LeftAlt || key == Key.RightAlt || key == Key.LeftShift || key == Key.RightShift || key == Key.LWin || key == Key.RWin || key == Key.Clear || key == Key.OemClear || key == Key.Apps)
            {
                return;
            }

            // Update the value
            //Hotkey hotkey = new Hotkey(key, modifiers);
            //if (keymap.TryGetValue(hotkey.ToInt(), out var callback))
            //{
            //    callback();
            //}
        }
        List<double> expose = new List<double> { 40000, 35714, 31250, 27778, 25000, 21739, 19608, 17241, 15385, 13514, 12048, 10753, 10000, 8403, 7463, 6623, 5882, 5208, 4630, 4000, 3636, 3226, 2865, 2545, 2252, 2000, 1773, 1575, 1397, 1239, 1099, 1000, 864, 767, 680, 604, 535, 500, 421, 374, 331, 294, 250, 231, 205, 182, 161, 143, 120, 113, 100, 89, 79, 70, 60, 55, 49, 43, 38, 34, 30, 27, 24, 21, 19, 17, 15, 13, 12, 10, 9, 8, 7, 6, 5, 4 };
        List<double> expose1 = new List<double> { 0.287, 0.323, 0.364, 0.410, 0.463, 0.500, 0.588, 0.663, 0.747, 0.842, 1, 1.071, 1.207, 1.360, 1.534, 1.729, 2.000, 2.197, 2.477, 2.792, 3.148, 3.548, 4.000 };
        MulDimensional mulDimensional;

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            WindowStatus windowStatus = WindowStatus.GetInstance();
            Window MainWindow = Window.GetWindow(this);
            MainWindow.PreviewKeyDown += Window_PreviewKeyUp;

            for (int i = 0; i < expose.Count; i++)
                expose[i] = 1 / expose[i];

            expose.AddRange(expose1);
            #region  操作父类
            if (Parent is StackPanel stack)
            {
            }
            #endregion

            #region ToggleButton 切换按钮
            ToggleButton ToggleButton1 = (ToggleButton)Template.FindName("ToggleButton1", this);
            ToggleButton ToggleButton2 = (ToggleButton)Template.FindName("ToggleButton2", this);
            ToggleButton ToggleButton3 = (ToggleButton)Template.FindName("ToggleButton3", this);
            ToggleButton ToggleButton4 = (ToggleButton)Template.FindName("ToggleButton4", this);
            ToggleButton ToggleButton5 = (ToggleButton)Template.FindName("ToggleButton5", this);
            #endregion

            #region ViewMode 成像模式

            Button button301 = (Button)Template.FindName("Button301", this);
            Button button302 = (Button)Template.FindName("Button302", this);
            button301.Click += delegate
            {
                Dictionary<string, object> data = new() { };
                Trigger("IMAGE_MODE_RESET", data);
            };
            button302.Click += delegate
            {
                Dictionary<string, object> data = new() { };
                Trigger("IMAGE_MODE_CLOSE", data);
            };

            RadioButton Button31 = (RadioButton)Template.FindName("Button31", this);
            RadioButton Button32 = (RadioButton)Template.FindName("Button32", this);
            RadioButton Button33 = (RadioButton)Template.FindName("Button33", this);
            RadioButton Button34 = (RadioButton)Template.FindName("Button34", this);
            RadioButton Button35 = (RadioButton)Template.FindName("Button35", this);
            RadioButton Button36 = (RadioButton)Template.FindName("Button36", this);

            List<RadioButton> ViewModeradioButtons = new List<RadioButton>();
            ViewModeradioButtons.Add(Button31);
            ViewModeradioButtons.Add(Button32);
            ViewModeradioButtons.Add(Button33);
            ViewModeradioButtons.Add(Button34);
            ViewModeradioButtons.Add(Button35);
            ViewModeradioButtons.Add(Button36);
            foreach (var item in ViewModeradioButtons)
            {
                item.Click += delegate
                {
                    string s = item.Tag.ToString();
                    if (s != null)
                    {
                        Dictionary<string, object> data = new() { { "mode", int.Parse(s) } };
                        Trigger("IMAGING_MODE_SETTING", item, data);
                    }
                };
            }
            #region slider
            //照明孔径
            SliderAbbreviation("Slider311", "BRIGHT_FIELD_DIAMETER", "diameter");
            Slider Slider312 = (Slider)Template.FindName("Slider312", this);
            ColorPicker ColorPciker1 = (ColorPicker)Template.FindName("ColorPciker1", this);

            Slider312.ValueChanged += delegate (object sender, RoutedPropertyChangedEventArgs<double> e)
            {
                if (!WindowStatus.GetInstance().ACQUIRE)
                {
                    int bright = (int)Slider312.Value;

                    string hexString = ColorPciker1.SelectColor.ToString();
                    hexString = hexString.Substring(1, hexString.Length - 1);
                    byte[] returnBytes = new byte[hexString.Length / 2];
                    for (int i = 0; i < returnBytes.Length; i++)
                        returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2).Trim(), 16);

                    int a1 = (returnBytes[1] >> 4) * bright/15;
                    int a2 = (returnBytes[2] >> 4) *bright/15;
                    int a3 = (returnBytes[3] >> 4) * bright/15;

                    int result = a1 * 256 + a2 * 16 + a3;
                    //int r = result / 256;
                    //int g = (result % 256)/16;
                    //int b = (result % 256)%16;
                    Dictionary<string, object> data = new() { { "brightness", result } };
                    Trigger("BRIGHT_FIELD_BRIGHTNESS", data);
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


            //照明亮度
            //SliderAbbreviation("Slider312", "BRIGHT_FIELD_BRIGHTNESS", "brightness");


            ColorPciker1.BrushValueChanged += delegate
            {
                int bright = (int)Slider312.Value;
                string hexString = ColorPciker1.SelectColor.ToString();
                hexString = hexString.Substring(1, hexString.Length - 1);
                byte[] returnBytes = new byte[hexString.Length / 2];
                for (int i = 0; i < returnBytes.Length; i++)
                    returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2).Trim(), 16);

                int a1 = (returnBytes[1] >> 4) * bright / 15;
                int a2 = (returnBytes[2] >> 4) * bright / 15;
                int a3 = (returnBytes[3] >> 4) * bright / 15;

                int result = a1 * 256 + a2 * 16 + a3;

                Dictionary<string, object> data = new() { { "brightness", result } };
                Trigger("BRIGHT_FIELD_BRIGHTNESS", data);
            };
            ColorPicker ColorPciker11 = (ColorPicker)Template.FindName("ColorPciker11", this);
            ColorPciker11.BrushValueChanged += delegate
            {
                string hexString = ColorPciker11.SelectColor.ToString();
                hexString = hexString.Substring(1, hexString.Length-1);
                byte[] returnBytes = new byte[hexString.Length / 2];
                for (int i = 0; i < returnBytes.Length; i++)
                    returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2).Trim(), 16);

                int a1 = returnBytes[1] >> 4;
                int a2 = returnBytes[2] >> 4;
                int a3 = returnBytes[3] >> 4;

                int result = a1*256 + a2*16 + a3;

                Dictionary<string, object> data = new() { { "brightness", result } };
                Trigger("BRIGHT_FIELD_BRIGHTNESS", data);
            };





            //照明内径
            SliderAbbreviation("Slider321", "DARK_FIELD_INNER", "inner");
            //照明外径
            SliderAbbreviation("Slider322", "DARK_FIELD_OUTER", "outer");
            //照明亮度
            SliderAbbreviation("Slider323", "DARK_FIELD_BRIGHTNESS", "brightness");
            //伽马
            SliderAbbreviation1("Slider324", "DARK_FIELD_GAMMA", "gamma");
            //自动模式
            ToggleButtonAbbreviation("Button321", "DARK_FIELD_AUTO", "auto");

            ColorPicker colorPciker2 = (ColorPicker)Template.FindName("ColorPciker2", this);
            colorPciker2.BrushValueChanged += delegate
            {
                Dictionary<string, object> data = new() { { "color", colorPciker2.SelectColor.ToString() } };
                Trigger("colorPciker2", this, data);
            };


            //照明内径
            SliderAbbreviation("Slider331", "RHEIN_BERG_INNER", "inner");
            //照明外径
            SliderAbbreviation("Slider332", "RHEIN_BERG_OUTER", "outer");
            //明场照明亮度
            SliderAbbreviation("Slider333", "RHEIN_BERG_BRIGHTNESS_BF", "brightness");
            //暗场照明亮度
            SliderAbbreviation("Slider334", "RHEIN_BERG_BRIGHTNESS_DF", "brightness");
            //伽马
            SliderAbbreviation("Slider335", "RHEIN_BERG_GAMMA", "gamma");

            //差分

            //对比度
            SliderAbbreviation1("Slider341", "RELIEF_CONTRAST_CONTRAST", "contrast");
            //增益
            SliderAbbreviation1("Slider342", "RELIEF_CONTRAST_GAIN", "gain");
            //明场权重
            SliderAbbreviation1("Slider343", "RELIEF_CONTRAST_BF_WEIGHT", "weight");
            //测试附加
            //外径
            SliderAbbreviation("Slider344", "RELIEF_CONTRAST_OUTER", "outer");
            //内径
            SliderAbbreviation("Slider345", "RELIEF_CONTRAST_INNER", "inner");
            //Gamma
            SliderAbbreviation1("Slider346", "RELIEF_CONTRAST_GAMMA", "gamma");
            //相衬权重
            SliderAbbreviation1("Slider347", "RELIEF_CONTRAST_DP_WEIGHT", "weight");

            //差分背景校正
            ToggleButton Button341 = ToggleButtonAbbreviation("Button341", "RELIEF_CONTRAST_BG_COLLECTION", "collection");
            Button341.IsChecked = false;

            //相位

            //正则化参数
            SliderAbbreviation1("Slider351", "QUANTITATIVE_PHASE_REG", "regularization");

            //细节增强
            SliderAbbreviation("Slider352", "QUANTITATIVE_PHASE_DETAIL", "detail");
            //测试附加
            //Min
            SliderAbbreviation1("Slider353", "QUANTITATIVE_PHASE_MIN", "min");
            // Max
            SliderAbbreviation1("Slider354", "QUANTITATIVE_PHASE_MAX", "max");
            // Gamma
            SliderAbbreviation1("Slider355", "QUANTITATIVE_PHASE_GAMMA", "gamma");


            //相位背景校正
            ToggleButton Button351 = ToggleButtonAbbreviation("Button351", "QUANTITATIVE_PHASE_BG_COLLECTION", "collection");
            Button351.IsChecked = false;

            //相差

            //相差滤波
            SliderAbbreviation1("Slider361", "PHASE_CONTRAST_FILTER", "filter");
            //对比度
            SliderAbbreviation1("Slider362", "PHASE_CONTRAST_CONTRAST", "contrast");
            //增益
            SliderAbbreviation1("Slider363", "PHASE_CONTRAST_GAIN", "gain");
            //明场权重
            SliderAbbreviation1("Slider364", "PHASE_CONTRAST_BF_WEIGHT", "weight");
            //测试附加
            //伽马
            SliderAbbreviation1("Slider365", "PHASE_CONTRAST_GAMMA", "gamma");
            //相差权重
            SliderAbbreviation1("Slider366", "PHASE_CONTRAST_PC_WEIGHT", "weight");

            //相差背景校正
            ToggleButton Button361 = ToggleButtonAbbreviation("Button361", "PHASE_CONTRAST_BG_COLLECTION", "collection");
            Button361.IsChecked = false;

            #endregion

            #endregion

            #region  ObjectiveSettingStackPanel
            StackPanel ObjectiveSettingStackPanel = (StackPanel)Template.FindName("ObjectiveSettingStackPanel", this);
            foreach (var item in ObjectiveSettingList)
            {
                RadioButton radioButton = new RadioButton
                {
                    Style = Button31.Style,
                    Width = 55,
                    Margin = new Thickness(5, 0, 5, 0),
                    Content = item.Magnitude,
                    IsChecked = item.IsChecked,
                    IsEnabled = item.IsEnabled
                };
                radioButton.Click += delegate
                {
                    Dictionary<string, object> values = new Dictionary<string, object>()
                    {
                        {"magnitude",item.ID },
                        {"na",(double)(item.NA) },
                    };
                    Trigger("OBJECTIVE_LENS_SETTING", values);
                };
                ObjectiveSettingStackPanel.Children.Add(radioButton);
            }
            if (ObjectiveSettingList.Count < 2)
            {
                ToggleButton1.IsChecked = false;
            }


            #endregion

            #region 相机参数
            Button Button201 =(Button)Template.FindName("Button201", this);
            Button201.Click += delegate
            {
                Dictionary<string, object> data = new() { };
                Trigger("CAMERA_SETTING_WHITE_BALANCE", data);
            };
            Button Button211 = (Button)Template.FindName("Button211", this);
            Button211.Click += delegate
            {
                Dictionary<string, object> data = new() {  };
                Trigger("CAMERA_SETTING_WHITE_BALANCE", data);
            };

            //增益
            SliderAbbreviation1("Slider211", "CAMERA_SETTING_GAIN", "gain");

            //曝光
            //SliderAbbreviation("Slider212", "CAMERA_SETTING_EXPOSURE", "exposure");

            Slider Slider212 = (Slider)Template.FindName("Slider212", this);
            Slider212.ValueChanged += delegate(object sender, RoutedPropertyChangedEventArgs<double> e)
            {
                if (!WindowStatus.GetInstance().ACQUIRE)
                {
                    if (Slider212.Value < expose.Count)
                    {
                        Dictionary<string, object> data = new() { { "exposure", expose[(int)Slider212.Value] } };
                        //string data = "{\"exposure111\":" + Slider212.Value.ToString("0") + "}";
                        Trigger("CAMERA_SETTING_EXPOSURE", data);
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
            SliderAbbreviation("Slider213", "CAMERA_SETTING_SHARPNESS", "sharpness");
            //伽马
            SliderAbbreviation1("Slider214", "CAMERA_SETTING_GAMMA", "gamma");
            //降噪
            SliderAbbreviation("Slider215", "CAMERA_SETTING_DENOISE", "denoise");


            #endregion

            #region MulDimensional
            Border border = (Border)Template.FindName("Border5", this);
            mulDimensional = new MulDimensional() { };
            border.DataContext = WindowStatus.GetInstance().mulDimensional;

            #endregion







            #region  滑块的效果的

            Button Button401 = (Button)Template.FindName("Button401", this);
            Button401.Click += delegate
            {
                Dictionary<string, object> data = new() { };
                Trigger("STAGE_SETTING_RESET", data);
            };
            
            int XYStep = 1000;
            int ZStep = 1000;

            ToggleButton ToggleButtonXYF = (ToggleButton)Template.FindName("ToggleButtonXYF", this);
            ToggleButton ToggleButtonZF = (ToggleButton)Template.FindName("ToggleButtonZF", this);
            ToggleButtonXYF.Checked += delegate
            {
                XYStep = 200;  
            };
            ToggleButtonXYF.Unchecked += delegate
            {
                XYStep = 1000;
            };
            ToggleButtonZF.Checked += delegate
            {
                ZStep = 200;
            };
            ToggleButtonZF.Unchecked += delegate
            {
                ZStep = 1000;
            };



            Canvas1 = (Canvas)Template.FindName("Canvas1", this);
            Canvas1.MouseMove += MainCanvas_MouseMove;
            Canvas1.MouseLeftButtonUp += MainCanvas_MouseLeftButtonUp;
            Canvas1.MouseLeftButtonDown += MainCanvas_MouseLeftButtonDown;
            Canvas1.PreviewMouseRightButtonUp += Canvas1_PreviewMouseRightButtonUp;
            Canvas1.PreviewMouseRightButtonDown += Canvas1_PreviewMouseRightButtonDown;
            Canvas1.PreviewMouseDown += Canvas1_PreviewMouseDown;

            //滑块的效果在确认一下。
            Slider Slider1111 = (Slider)(Template.FindName("Slider1111", this));

            if (Template.FindName("ButtonFront", this) is Button ButtonFront)
            {
                ButtonFront.Click += delegate
                {
                    Dictionary<string, object> data = new() { { "step", XYStep },{ "direction",2 } };
                    Trigger("STAGE_MOVE_FRONT", ButtonFront, data);
                };
            }
            if (Template.FindName("ButtonRear", this) is Button ButtonRear)
            {
                ButtonRear.Click += delegate
                {
                    Dictionary<string, object> data = new() { { "step", XYStep }, { "direction", 3 } };
                    Trigger("STAGE_MOVE_REAR", ButtonRear, data);
                };
            }
            if (Template.FindName("ButtonRight", this) is Button ButtonRight)
            {
                ButtonRight.Click += delegate
                {
                    Dictionary<string, object> data = new() { { "step", XYStep }, { "direction", 1 } };
                    Trigger("STAGE_MOVE_RIGHT", ButtonRight, data);
                };
            }
            if (Template.FindName("ButtonLeft", this) is Button ButtonLeft)
            {
                ButtonLeft.Click += delegate
                {
                    Dictionary<string, object> data = new() { { "step", XYStep }, { "direction", 0 } }; 
                    Trigger("STAGE_MOVE_LEFT", ButtonLeft, data);
                };
            }
            if (Template.FindName("ButtonUp", this) is Button ButtonUp)
            {
                ButtonUp.Click += delegate
                {
                    Dictionary<string, object> data = new() { { "step", ZStep}, { "direction", 4 } };
                    Trigger("STAGE_MOVE_UP", ButtonUp, data);
                };
            }
            if (Template.FindName("ButtonDown", this) is Button ButtonDown)
            {
                ButtonDown.Click += delegate
                {
                    Dictionary<string, object> data = new() { { "step", ZStep }, { "direction", 5 } };
                    Trigger("STAGE_MOVE_DOWN", ButtonDown, data);
                };
            }
            if (Template.FindName("ButtonRe", this) is Button ButtonRe)
            {
                ButtonRe.Click += delegate
                {
                    Dictionary<string, object> data = new() { { "step", 0 }, { "direction", 6 } };
                    Trigger("STAGE_MOVE_CENTRE", ButtonRe, data);
                };
            }

            //单击双击的逻辑移除
            //_timer.Tick += Timer_Tick;
            if (Template.FindName("ButtonAutoFocus", this) is Button ButtonAutoFocus)
            {
                //ButtonAutoFocus.PreviewMouseLeftButtonDown += Button_PreviewMouseLeftButtonDown;
                ButtonAutoFocus.Click += delegate
                {
                    if ((bool)ToggleButtonZF.IsChecked)
                    {
                        Dictionary<string, object> data = new() { { "mode", 0 } };
                        Trigger("STAGE_AUTO_FOCUS", this, data);
                    }
                    else
                    {
                        Dictionary<string, object> data = new() { { "mode", 1 } };
                        Trigger("STAGE_AUTO_FOCUS", this, data);
                    }

                };


            }


            #endregion

            ToggleButton ToggleButton503 = (ToggleButton)Template.FindName("ToggleButton503", this);
            ToggleButton ToggleButton504 = (ToggleButton)Template.FindName("ToggleButton504", this);
            ToggleButton ToggleButton505 = (ToggleButton)Template.FindName("ToggleButton505", this);

            ToggleButton503.Checked += delegate
            {
                Update.UpdateMulDimensional(WindowStatus.GetInstance().mulDimensional);
                //ToggleButton504.IsChecked = true;
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


        }

        bool sliderfirst = true;
        /// <summary>
        /// SliderAbbreviation(int)
        /// </summary>
        private Slider SliderAbbreviation(string FindName, string TriggerName,string TriggerParameter)
        {
            Slider slider = (Slider)Template.FindName(FindName, this);
            slider.ValueChanged += delegate(object sender, RoutedPropertyChangedEventArgs<double> e)
            {
                
                if (!WindowStatus.GetInstance().ACQUIRE)
                {
                    Dictionary<string, object> data = new() { { TriggerParameter, (int)slider.Value } };
                    Trigger(TriggerName, data);
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
        private Slider SliderAbbreviation1(string FindName, string TriggerName, string TriggerParameter)
        {
            Slider slider = (Slider)Template.FindName(FindName, this);
           
            slider.ValueChanged += delegate(object sender, RoutedPropertyChangedEventArgs<double> e)
            {
                if (!WindowStatus.GetInstance().ACQUIRE)
                {
                    Dictionary<string, object> data = new() { { TriggerParameter, (double)slider.Value } };
                    Trigger(TriggerName, data);
                }
                else
                {
                    if (sliderfirst)
                    {
                        var result = MessageBox.Show("是否修改当前多维采集设置","显微镜",MessageBoxButton.YesNo);
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
        private ToggleButton ToggleButtonAbbreviation(string FindName, string TriggerName, string TriggerParameter)
        {
            ToggleButton toggleButton = (ToggleButton)Template.FindName(FindName, this);
            toggleButton.Checked += delegate
            {
                Dictionary<string, object> data = new() { { TriggerParameter, toggleButton.IsChecked } };
                Trigger(TriggerName, data);
                MessageBox.Show("test");
            };
            toggleButton.Unchecked += delegate
            {
                Dictionary<string, object> data = new() { { TriggerParameter, toggleButton.IsChecked } };
                Trigger(TriggerName, data);
            };
            return toggleButton;
        }



        //双点
        private void Button_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                _timer.Stop();
                Dictionary<string, object> data = new() { { "mode", 1 } };
                Trigger("AUTO_FOCUS", this, data);
            }
            else
            {
                _timer.Start();
            }
        }

        //单点
        private void Timer_Tick(object? sender, EventArgs e)
        {
            _timer.Stop();
            Dictionary<string, object> data = new() { { "mode", 0 } };
            Trigger("STAGE_AUTO_FOCUS", this, data);
        }




        #region  圆环
        private Canvas Canvas1;
        private Border currentBoxSelectedBorder;
        private bool isCanMove = false;//鼠标是否移动
        private Point tempStartPoint;//起始坐标

        Rectangle rectangle;
        private BrushConverter brushConverter = new BrushConverter();
        /// <summary>
        /// 鼠标按下记录起始点
        /// </summary>
        private void MainCanvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            rectangle = new Rectangle();
            rectangle.Fill = brushConverter.ConvertFrom("#2E86E1") as Brush; 
            rectangle.Opacity = 0.9;
            rectangle.Width = 10;
            rectangle.Height = 7;
            rectangle.PreviewMouseRightButtonDown += Rectangle_PreviewMouseRightButtonDown;
            Canvas element = (Canvas)sender;
            Point dragStart = e.GetPosition(element);
            Canvas.SetLeft(rectangle, dragStart.X - 3.5);
            Canvas.SetTop(rectangle, dragStart.Y - 5);
            element.Children.Add(rectangle);

            isCanMove = true;
            tempStartPoint = e.GetPosition(this.Canvas1);
        }




        private void MainCanvas_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

            if (currentBoxSelectedBorder != null)
            {
                if (currentBoxSelectedBorder.Height > 10 || currentBoxSelectedBorder.Width > 10)
                {
                    //获取选框的矩形位置
                    Point tempEndPoint = e.GetPosition(this.Canvas1);
                    Rect tempRect = new Rect(tempStartPoint, tempEndPoint);
                    //获取子控件
                    List<Rectangle> childList = GetChildObjects<Rectangle>(this.Canvas1);
                    foreach (var child in childList)
                    {
                        //获取子控件矩形位置
                        Rect childRect = new Rect(Canvas.GetLeft(child), Canvas.GetTop(child), child.Width, child.Height);
                        //若子控件与选框相交则改变样式
                        if (childRect.IntersectsWith(tempRect))
                            this.Canvas1.Children.Remove(child);
                    }

                    List<Border> childList1 = GetChildObjects<Border>(this.Canvas1);
                    foreach (var child in childList1)
                    {

                        Rect childRect = new Rect(Canvas.GetLeft(child), Canvas.GetTop(child), child.Width, child.Height);
                        if (tempRect.Contains(childRect))
                            this.Canvas1.Children.Remove(child);
                    }
                    this.Canvas1.Children.Add(currentBoxSelectedBorder);



                }

                currentBoxSelectedBorder = new Border();
                currentBoxSelectedBorder.Background = brushConverter.ConvertFrom("#2E86E1") as Brush;
                currentBoxSelectedBorder.Opacity = 0.9;
                currentBoxSelectedBorder.BorderThickness = new Thickness(2);
                currentBoxSelectedBorder.BorderBrush = brushConverter.ConvertFrom("#2E86E1FF") as Brush;
                currentBoxSelectedBorder.PreviewMouseRightButtonDown += Border_PreviewMouseRightButtonDown;
                currentBoxSelectedBorder.MouseMove += Border_MouseMove;
                currentBoxSelectedBorder.MouseLeftButtonDown += Border_MouseLeftButtonDown;
                currentBoxSelectedBorder.MouseLeftButtonUp += Border_MouseLeftButtonUp;
                this.Canvas1.Children.Add(currentBoxSelectedBorder);


            }
            isCanMove = false;


        }


        private void MainCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (bordermouve)
            {
                if (rectangle != null)
                {
                    Canvas1.Children.Remove(rectangle);
                }
            }
            else
            {
                if (isCanMove)
                {
                    Point tempEndPoint = e.GetPosition(this.Canvas1);
                    //绘制跟随鼠标移动的方框
                    DrawMultiselectBorder(tempEndPoint, tempStartPoint);
                }
                else if (isCanMove1)
                {
                    Point tempEndPoint1 = e.GetPosition(this.Canvas1);
                    //绘制跟随鼠标移动的方框
                    DrawMultiselectBorder1(tempEndPoint1, tempStartPoint1);
                }
            }

        }



        private void DrawMultiselectBorder(Point endPoint, Point startPoint)
        {
            if (currentBoxSelectedBorder == null)
            {
                currentBoxSelectedBorder = new Border();
                currentBoxSelectedBorder.Background = brushConverter.ConvertFrom("#2E86E1") as Brush;
                currentBoxSelectedBorder.Opacity = 0.9;
                currentBoxSelectedBorder.BorderThickness = new Thickness(2);
                currentBoxSelectedBorder.BorderBrush = brushConverter.ConvertFrom("#2E86E1FF") as Brush;
                currentBoxSelectedBorder.PreviewMouseRightButtonDown += Border_PreviewMouseRightButtonDown;
                currentBoxSelectedBorder.MouseMove += Border_MouseMove;
                currentBoxSelectedBorder.MouseLeftButtonDown += Border_MouseLeftButtonDown;
                currentBoxSelectedBorder.MouseLeftButtonUp += Border_MouseLeftButtonUp;


                //Canvas.SetZIndex(currentBoxSelectedBorder, 100);
                this.Canvas1.Children.Add(currentBoxSelectedBorder);
            }



            currentBoxSelectedBorder.Width = Math.Abs(endPoint.X - startPoint.X);
            currentBoxSelectedBorder.Height = Math.Abs(endPoint.Y - startPoint.Y);
            if (currentBoxSelectedBorder.Width > 2 || currentBoxSelectedBorder.Height > 2)
            {
                if (rectangle != null)
                {
                    Canvas1.Children.Remove(rectangle);
                }

            }
            if (endPoint.X - startPoint.X >= 0)
                Canvas.SetLeft(currentBoxSelectedBorder, startPoint.X);
            else
                Canvas.SetLeft(currentBoxSelectedBorder, endPoint.X);
            if (endPoint.Y - startPoint.Y >= 0)
                Canvas.SetTop(currentBoxSelectedBorder, startPoint.Y);
            else
                Canvas.SetTop(currentBoxSelectedBorder, endPoint.Y);
        }


        private void Border_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Border? border = (Border)sender;
            Canvas1.Children.Remove(border);
        }

        private void Rectangle_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Rectangle? rectangle = (Rectangle)sender;
            Canvas1.Children.Remove(rectangle);
           
        }

        private void Canvas1_PreviewMouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (currentBoxSelectedBorder1 != null)
            {
                //获取选框的矩形位置
                Point tempEndPoint = e.GetPosition(this.Canvas1);
                Rect tempRect = new Rect(tempStartPoint1, tempEndPoint);
                //获取子控件
                List<Rectangle> childList = GetChildObjects<Rectangle>(Canvas1);
                foreach (var child in childList)
                {
                    //获取子控件矩形位置
                    Rect childRect = new Rect(Canvas.GetLeft(child), Canvas.GetTop(child), child.Width, child.Height);

                    if (tempRect.Contains(childRect))
                        this.Canvas1.Children.Remove(child);
                    //child.Opacity = 0.4;
                }
                List<Border> childList1 = GetChildObjects<Border>(this.Canvas1);
                foreach (var child in childList1)
                {

                    Rect childRect = new Rect(Canvas.GetLeft(child), Canvas.GetTop(child), child.Width, child.Height);
                    if (tempRect.Contains(childRect))
                        this.Canvas1.Children.Remove(child);
                    //if (contain(tempRect, childRect))
                    //    this.Canvas1.Children.Remove(child);
                }
                this.Canvas1.Children.Remove(currentBoxSelectedBorder1);
            }
            isCanMove1 = false;
        }

        private static bool contain(Rect r, Rect l)
        {
            return r.Top < l.Top && r.Left < l.Left && r.Width > (l.Width + (l.Left - r.Left)) && r.Width > (l.Height + (l.Top - r.Top));
        }
        public static List<T> GetChildObjects<T>(System.Windows.DependencyObject obj) where T : System.Windows.FrameworkElement
        {
            System.Windows.DependencyObject? child = null;
            List<T> childList = new List<T>();
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj); i++)
            {
                child = VisualTreeHelper.GetChild(obj, i);
                if (child is T)
                {
                    childList.Add((T)child);
                }
                childList.AddRange(GetChildObjects<T>(child));
            }
            return childList;
        }


        private void Canvas1_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            isCanMove1 = true;
            tempStartPoint1 = e.GetPosition(this.Canvas1);
        }

        private Border? currentBoxSelectedBorder1;
        private bool isCanMove1 = false;//鼠标是否移动
        private Point tempStartPoint1;//起始坐标

        private void DrawMultiselectBorder1(Point endPoint, Point startPoint)
        {
            if (currentBoxSelectedBorder1 == null)
            {
                currentBoxSelectedBorder1 = new Border();
                //currentBoxSelectedBorder1.Background = new SolidColorBrush(Colors.Red);
                currentBoxSelectedBorder1.Opacity = 0.4;
                currentBoxSelectedBorder1.BorderThickness = new Thickness(2);
                currentBoxSelectedBorder1.BorderBrush = new SolidColorBrush(Colors.OrangeRed);
                Canvas.SetZIndex(currentBoxSelectedBorder1, 100);
                this.Canvas1.Children.Add(currentBoxSelectedBorder1);
            }



            currentBoxSelectedBorder1.Width = Math.Abs(endPoint.X - startPoint.X);
            currentBoxSelectedBorder1.Height = Math.Abs(endPoint.Y - startPoint.Y);

            if (endPoint.X - startPoint.X >= 0)
                Canvas.SetLeft(currentBoxSelectedBorder1, startPoint.X);
            else
                Canvas.SetLeft(currentBoxSelectedBorder1, endPoint.X);
            if (endPoint.Y - startPoint.Y >= 0)
                Canvas.SetTop(currentBoxSelectedBorder1, startPoint.Y);
            else
                Canvas.SetTop(currentBoxSelectedBorder1, endPoint.Y);
        }

        bool bordermouve = false;
        Point point1;
        private void Border_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            bordermouve = false;
            Border border = (Border)sender;
            border.ReleaseMouseCapture();
        }
        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            bordermouve = true;
            Border border = (Border)sender;
            point1 = e.GetPosition(border);
            border.CaptureMouse();
        }

        private void Border_MouseMove(object sender, MouseEventArgs e)
        {
            if (bordermouve)
            {
                Border border = (Border)sender;
                Point point = e.GetPosition(this.Canvas1);

                Double CanvasTop, CanvasLeft;
                CanvasTop = point.Y - point1.Y;
                CanvasLeft = point.X - point1.X;

                if (CanvasTop < 0)
                {
                    CanvasTop = 0;
                }

                if (CanvasLeft < 0)
                {
                    CanvasLeft = 0;
                }
                Canvas.SetTop(border, CanvasTop);
                Canvas.SetLeft(border, CanvasLeft);

            }

        }
        private void Canvas1_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                if (rectangle != null)
                {
                    Canvas1.Children.Remove(rectangle);
                }

                Point point = e.GetPosition(this.Canvas1);

                Dictionary<string, object> data = new()
                {
                    { "X", (int)((point.X)) },
                    { "Y", (int)(point.Y) },
                };
                Trigger("MOTORCONTROL", this, data);

                //MessageBox.Show((point.X - 175).ToString() + (175 - point.Y).ToString());

            }
        }

        #endregion 
    }
}
