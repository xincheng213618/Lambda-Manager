using Lambda;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace ConfigObjective
{
    /// <summary>
    /// Follow steps 1a or 1b and then 2 to use this custom control in a XAML file.
    ///
    /// Step 1a) Using this custom control in a XAML file that exists in the current project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:ConfigObjective"
    ///
    ///
    /// Step 1b) Using this custom control in a XAML file that exists in a different project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:ConfigObjective;assembly=ConfigObjective"
    ///
    /// You will also need to add a project reference from the project where the XAML file lives
    /// to this project and Rebuild to avoid compilation errors:
    ///
    ///     Right click on the target project in the Solution Explorer and
    ///     "Add Reference"->"Projects"->[Select this project]
    ///
    ///
    /// Step 2)
    /// Go ahead and use your control in the XAML file.
    ///
    ///     <MyNamespace:CustomControl1/>
    ///
    /// </summary>
    [TemplatePart(Name = "Button1", Type = typeof(RadioButton))]
    [TemplatePart(Name = "Button2", Type = typeof(RadioButton))]
    [TemplatePart(Name = "Button3", Type = typeof(RadioButton))]
    [TemplatePart(Name = "Button4", Type = typeof(RadioButton))]
    public class Magnification : LambdaControl
    {

        static Magnification()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Magnification), new FrameworkPropertyMetadata(typeof(Magnification)));
        }
        Canvas? Canvas1;
        private readonly System.Windows.Threading.DispatcherTimer _timer = new System.Windows.Threading.DispatcherTimer() { Interval = TimeSpan.FromSeconds(0.2) };

        //ObjectiveSettingList Demo ALL
        //List<ObjectiveSetting> ObjectiveSettingList = new List<ObjectiveSetting>()
        //{
        //    new ObjectiveSetting (){ID =0, Name ="奥林巴斯",Magnitude="4X", NA=0.1},
        //    new ObjectiveSetting (){ID =1, Name ="奥林巴斯",Magnitude="10X", NA=0.25},
        //    new ObjectiveSetting (){ID =2, Name ="奥林巴斯",Magnitude="20X", NA=0.4},
        //    new ObjectiveSetting (){ID =3, Name ="奥林巴斯",Magnitude="40X", NA=0.65},
        //    new ObjectiveSetting (){ID =4, Name ="奥林巴斯",Magnitude="100X", NA=1.25},
        //};

        List<ObjectiveSetting> ObjectiveSettingList = new List<ObjectiveSetting>()
        {
            new ObjectiveSetting (){ID =1, Name ="奥林巴斯",Magnitude="10X", NA=0.25},

        };

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();


            #region ToggleButton 切换按钮
            ToggleButton ToggleButton1 = (ToggleButton)Template.FindName("ToggleButton1", this);
            ToggleButton ToggleButton2 = (ToggleButton)Template.FindName("ToggleButton2", this);
            ToggleButton ToggleButton3 = (ToggleButton)Template.FindName("ToggleButton3", this);
            ToggleButton ToggleButton4 = (ToggleButton)Template.FindName("ToggleButton4", this);
            ToggleButton ToggleButton5 = (ToggleButton)Template.FindName("ToggleButton5", this);
            #endregion  



            #region ViewMode 成像模式
            RadioButton Button31  =(RadioButton)Template.FindName("Button31", this);
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
                    Dictionary<string, object> data = new() { { "dpc", int.Parse(item.Tag.ToString()) } };
                    Trigger("DPC_MODE_CHANGED", item, data);
                };
            }
            #region slider

            Slider Slider311 = (Slider)Template.FindName("Slider311", this);
            Slider311.ValueChanged += delegate
            {
                Dictionary<string, object> data = new() { { "diameter", (int)Slider311.Value} };
                Trigger("DPC_MODE_CHANGED", Slider311, data);
            };
            Slider Slider312 = (Slider)Template.FindName("Slider312", this);
            Slider312.ValueChanged += delegate
            {
                Dictionary<string, object> data = new() { { "brightness", (int)Slider312.Value } };
                Trigger("BRIGHT_FIELD_BRIGHTNESS", Slider311, data);
            };

            Slider Slider321 = (Slider)Template.FindName("Slider321", this);
            Slider321.ValueChanged += delegate
            {
                Dictionary<string, object> data = new() { { "inner", (int)Slider321.Value } };
                Trigger("DARK_FIELD_INNER", Slider311, data);
            };
            Slider Slider322 = (Slider)Template.FindName("Slider322", this);
            Slider322.ValueChanged += delegate
            {
                Dictionary<string, object> data = new() { { "outer", (int)Slider322.Value } };
                Trigger("DARK_FIELD_OUTER", Slider311, data);
            };
            Slider Slider323 = (Slider)Template.FindName("Slider323", this);
            Slider323.ValueChanged += delegate
            {
                Dictionary<string, object> data = new() { { "brightness", (int)Slider323.Value } };
                Trigger("DARK_FIELD_BRIGHTNESS", Slider311, data);
            };
            Slider Slider324 = (Slider)Template.FindName("Slider324", this);
            Slider324.ValueChanged += delegate
            {
                Dictionary<string, object> data = new() { { "gamma", (int)Slider323.Value*100} };
                Trigger("DARK_FIELD_GAMMA", Slider311, data);
            };

            Slider Slider331 = (Slider)Template.FindName("Slider331", this);
            Slider331.ValueChanged += delegate
            {
                Dictionary<string, object> data = new() { { "inner", (int)Slider331.Value } };
                Trigger("RHEIN_BERG_INNER", Slider311, data);
            };
            Slider Slider332 = (Slider)Template.FindName("Slider332", this);
            Slider332.ValueChanged += delegate
            {
                Dictionary<string, object> data = new() { { "outer", (int)Slider332.Value } };
                Trigger("RHEIN_BERG_OUTER", Slider311, data);
            };
            Slider Slider333 = (Slider)Template.FindName("Slider333", this);
            Slider333.ValueChanged += delegate
            {
                Dictionary<string, object> data = new() { { "brightness", (int)Slider333.Value } };
                Trigger("RHEIN_BERG_BRIGHTNESS_BF", Slider311, data);
            };

            Slider Slider334 = (Slider)Template.FindName("Slider334", this);
            Slider334.ValueChanged += delegate
            {
                Dictionary<string, object> data = new() { { "brightness", (int)Slider334.Value } };
                Trigger("RHEIN_BERG_BRIGHTNESS_DF", Slider311, data);
            };

            Slider Slider335 = (Slider)Template.FindName("Slider335", this);
            Slider335.ValueChanged += delegate
            {
                Dictionary<string, object> data = new() { { "gamma", (int)Slider335.Value * 100 } };
                Trigger("RHEIN_BERG_GAMMA", Slider311, data);
            };

            Slider Slider341 = (Slider)Template.FindName("Slider341", this);
            Slider341.ValueChanged += delegate
            {
                Dictionary<string, object> data = new() { { "filter", (int)Slider341.Value } };
                Trigger("PHASE_CONTRAST_FILTER", Slider311, data);
            };

            Slider Slider342 = (Slider)Template.FindName("Slider342", this);
            Slider342.ValueChanged += delegate
            {
                Dictionary<string, object> data = new() { { "contrast", (int)Slider342.Value } };
                Trigger("PHASE_CONTRAST_CONTRAST", Slider311, data);
            };

            Slider Slider343 = (Slider)Template.FindName("Slider343", this);
            Slider343.ValueChanged += delegate
            {
                Dictionary<string, object> data = new() { { "gain", (int)Slider343.Value } };
                Trigger("PHASE_CONTRAST_GAIN", Slider311, data);
            };

            Slider Slider344 = (Slider)Template.FindName("Slider344", this);
            Slider344.ValueChanged += delegate
            {
                Dictionary<string, object> data = new() { { "weight", (int)Slider344.Value } };
                Trigger("PHASE_CONTRAST_BF_WEIGHT", Slider311, data);
            };


            Slider Slider351 = (Slider)Template.FindName("Slider351", this);
            Slider351.ValueChanged += delegate
            {
                Dictionary<string, object> data = new() { { "regularization", (int)Slider351.Value } };
                Trigger("QUANTITATIVE_PHASE_REG", Slider311, data);
            };
            Slider Slider352 = (Slider)Template.FindName("Slider352", this);
            Slider352.ValueChanged += delegate
            {
                Dictionary<string, object> data = new() { { "detail", (int)Slider352.Value } };
                Trigger("QUANTITATIVE_PHASE_DETAIL", Slider311, data);
            };

            Slider Slider361 = (Slider)Template.FindName("Slider361", this);
            Slider361.ValueChanged += delegate
            {
                Dictionary<string, object> data = new() { { "contrast", (int)Slider361.Value } };
                Trigger("RELIEF_CONTRAST_CONTRAST", Slider311, data);
            };

            Slider Slider362 = (Slider)Template.FindName("Slider362", this);
            Slider362.ValueChanged += delegate
            {
                Dictionary<string, object> data = new() { { "gain", (int)Slider362.Value } };
                Trigger("PHASE_CONTRAST_CONTRAST", Slider311, data);
            };

            Slider Slider363 = (Slider)Template.FindName("Slider363", this);
            Slider363.ValueChanged += delegate
            {
                Dictionary<string, object> data = new() { { "weidght", (int)Slider363.Value } };
                Trigger("RELIEF_CONTRAST_BF_WEIDGHT ", Slider311, data);
            };



           #endregion




            #endregion


            #region  ObjectiveSettingStackPanel
            StackPanel ObjectiveSettingStackPanel = (StackPanel)Template.FindName("ObjectiveSettingStackPanel", this);
            foreach (var item in ObjectiveSettingList)
            {
                RadioButton radioButton = new RadioButton();
                radioButton.Style = Button31.Style;
                radioButton.Width = 55;
                radioButton.Margin = new Thickness(5, 0, 5, 0);
                radioButton.Content = item.Magnitude;
                radioButton.Click += delegate
                {
                    Dictionary<string, object> values = new Dictionary<string, object>()
                    {
                        {"magnitude",item.ID },
                        {"na",item.NA },
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


            #region  滑块的效果的

            int XYStep = 200;
            int ZStep = 40;

            ToggleButton ToggleButtonXYF = (ToggleButton)Template.FindName("ToggleButtonXYF", this);
            ToggleButton ToggleButtonZF = (ToggleButton)Template.FindName("ToggleButtonXYF", this);
            ToggleButtonXYF.Checked += delegate
            {
                XYStep = 1000;  
            };
            ToggleButtonXYF.Unchecked += delegate
            {
                XYStep = 200;
            };
            ToggleButtonZF.Checked += delegate
            {
                ZStep = 200;
            };
            ToggleButtonZF.Unchecked += delegate
            {
                ZStep = 40;
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
                    Dictionary<string, object> data = new() { { "Step", XYStep } };
                    Trigger("MOVEFRONT", ButtonFront, data);
                };
            }
            if (Template.FindName("ButtonRear", this) is Button ButtonRear)
            {
                ButtonRear.Click += delegate
                {
                    Dictionary<string, object> data = new() { { "Step", XYStep } };
                    Trigger("MOVEREAR", ButtonRear, data);
                };
            }
            if (Template.FindName("ButtonRight", this) is Button ButtonRight)
            {
                ButtonRight.Click += delegate
                {
                    Dictionary<string, object> data = new() { { "Step", XYStep } };
                    Trigger("MOVERIGHT", ButtonRight, data);
                };
            }
            if (Template.FindName("ButtonLeft", this) is Button ButtonLeft)
            {
                ButtonLeft.Click += delegate
                {
                    Dictionary<string, object> data = new() { { "Step", XYStep } }; 
                    Trigger("MOVELEFT", ButtonLeft, data);
                };
            }
            if (Template.FindName("ButtonUp", this) is Button ButtonUp)
            {
                ButtonUp.Click += delegate
                {
                    Dictionary<string, object> data = new() { { "Step",ZStep} };
                    Trigger("MOVEUP", ButtonUp, data);
                };
            }
            if (Template.FindName("ButtonDown", this) is Button ButtonDown)
            {
                ButtonDown.Click += delegate
                {
                    Dictionary<string, object> data = new() { { "Step", ZStep } };
                    Trigger("MOVEDOWN", ButtonDown, data);
                };
            }
            if (Template.FindName("ButtonRe", this) is Button ButtonRe)
            {
                ButtonRe.Click += delegate
                {
                    Dictionary<string, object> data = new() { { "Step", 0 }, { "Direction", 6 } };
                    Trigger("MOVERE", ButtonRe, data);

                };
            }
            _timer.Tick += Timer_Tick;
            if (Template.FindName("ButtonAutoFocus", this) is Button ButtonAutoFocus)
            {
                ButtonAutoFocus.PreviewMouseLeftButtonDown += Button_PreviewMouseLeftButtonDown;
            }


        #endregion
    }

        private void Button_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                _timer.Stop();
                Dictionary<string, object> data = new() { };
                Trigger("AUTO_FOCUS", this, data);
            }
            else
            {
                _timer.Start();
            }
        }


        private void Timer_Tick(object? sender, EventArgs e)
        {
            _timer.Stop();
            Dictionary<string, object> data = new() { };
            Trigger("SMALL_AUTO_FOCUS_Run", this, data);
        }




        #region  圆环
        private Border currentBoxSelectedBorder = null;//拖动展示的提示框
        private bool isCanMove = false;//鼠标是否移动
        private Point tempStartPoint;//起始坐标

        Rectangle? rectangle;
        /// <summary>
        /// 鼠标按下记录起始点
        /// </summary>
        private void MainCanvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            rectangle = new Rectangle();
            rectangle.Fill = (Brush)brushConverter.ConvertFrom("#2E86E1");
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



        private BrushConverter brushConverter = new BrushConverter();

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
                currentBoxSelectedBorder.Background = (Brush)brushConverter.ConvertFrom("#2E86E1");
                currentBoxSelectedBorder.Opacity = 0.9;
                currentBoxSelectedBorder.BorderThickness = new Thickness(2);
                currentBoxSelectedBorder.BorderBrush = (Brush)brushConverter.ConvertFrom("#2E86E1FF");
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
                    rectangle = null;
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
                currentBoxSelectedBorder.Background = (Brush)brushConverter.ConvertFrom("#2E86E1");
                currentBoxSelectedBorder.Opacity = 0.9;
                currentBoxSelectedBorder.BorderThickness = new Thickness(2);
                currentBoxSelectedBorder.BorderBrush = (Brush)brushConverter.ConvertFrom("#2E86E1FF");
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
                    rectangle = null;
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
            border = null;
        }

        private void Rectangle_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Rectangle rectangle = (Rectangle)sender;
            Canvas1.Children.Remove(rectangle);
            rectangle = null;
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
                currentBoxSelectedBorder1 = null;


            }
            isCanMove1 = false;
        }

        private static bool contain(Rect r, Rect l)
        {
            return r.Top < l.Top && r.Left < l.Left && r.Width > (l.Width + (l.Left - r.Left)) && r.Width > (l.Height + (l.Top - r.Top));
        }
        public static List<T> GetChildObjects<T>(System.Windows.DependencyObject obj) where T : System.Windows.FrameworkElement
        {
            System.Windows.DependencyObject child = null;
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

        private Border currentBoxSelectedBorder1 = null;//拖动展示的提示框
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
                    rectangle = null;
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
