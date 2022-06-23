using Lambda;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;

namespace Global
{
    /// <summary>
    /// 监听AddInjection事件
    /// </summary>
    public partial class WindowData
    {
        public int Version = -1;
        private void AddInjection()
        {
            Window mainwin = Application.Current.MainWindow;

            Type t = mainwin.GetType();
            MethodInfo method = t.GetMethod("GetVersion");
            if (method != null)
            {
                BindingFlags flag = BindingFlags.Public | BindingFlags.Instance;
                object[] parameters = new object[] { };
                object returnValue = method.Invoke(mainwin, flag, Type.DefaultBinder, parameters, null);
                if (returnValue is int aa)
                    Version = aa;
            }

            try
            {

                WrapPanel WrapPanel1 = (WrapPanel)mainwin.FindName("rightToolbar");
                //检测如果找不到rightToolbar 直接退出
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

                frameIndex.DataContext = updateStatus;
                frameIndex.SetBinding(TextBlock.TextProperty, new Binding("FrameIndex"));

                TextBlock totalFrame = (TextBlock)mainwin.FindName("totalFrame");

                totalFrame.DataContext = updateStatus;
                totalFrame.SetBinding(TextBlock.TextProperty, new Binding("TotalFrame"));

                TextBlock timeElapsed = (TextBlock)mainwin.FindName("timeElapsed");

                timeElapsed.DataContext = updateStatus;
                timeElapsed.SetBinding(TextBlock.TextProperty, new Binding("TimeElapsed"));
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            try
            {
                WrapPanel topToolbar = (WrapPanel)mainwin.FindName("topToolbar");
                topToolbar.DataContext = ImageViewState.toolTop;

                Binding binding1 = new Binding("PointerChecked");
                ((ToggleButton)topToolbar.Children[0]).SetBinding(ToggleButton.IsCheckedProperty, binding1);
                Binding binding2 = new Binding("MoveChecked");
                ((ToggleButton)topToolbar.Children[1]).SetBinding(ToggleButton.IsCheckedProperty, binding2);
                Binding binding3 = new Binding("DimensionChecked");
                ((ToggleButton)topToolbar.Children[2]).SetBinding(ToggleButton.IsCheckedProperty, binding3);
                //((ToggleButton)topToolbar.Children[3]).SetBinding(ToggleButton.IsCheckedProperty, new Binding("FocusChecked"));

                //Binding binding4 = new Binding("RulerChecked");
                //((ToggleButton)topToolbar.Children[4]).SetBinding(ToggleButton.IsCheckedProperty, binding4);    


                Binding binding5 = new Binding("FocusChecked");
                ((ToggleButton)topToolbar.Children[5]).SetBinding(ToggleButton.IsCheckedProperty, binding5);



                Binding binding13 = new Binding("RulerChecked");
                ToggleButton ToggleButtonRuler = ((ToggleButton)topToolbar.Children[13]);
                ToggleButtonRuler.SetBinding(ToggleButton.IsCheckedProperty, binding13);

                Binding binding14 = new Binding("TextChecked");
                ToggleButton ToggleButtonText = ((ToggleButton)topToolbar.Children[14]);
                ToggleButtonText.SetBinding(ToggleButton.IsCheckedProperty, binding14);

                Binding binding15 = new Binding("ArrowChecked");
                ToggleButton ToggleButtonArrow = ((ToggleButton)topToolbar.Children[15]);
                ToggleButtonArrow.SetBinding(ToggleButton.IsCheckedProperty, binding15);

                Binding binding16 = new Binding("LineChecked");
                ToggleButton ToggleButtonLine= ((ToggleButton)topToolbar.Children[16]);
                ToggleButtonLine.SetBinding(ToggleButton.IsCheckedProperty, binding16);



                Binding binding17 = new Binding("CurveChecked");
                ToggleButton ToggleButtonCurve = ((ToggleButton)topToolbar.Children[17]);
                ToggleButtonCurve.SetBinding(ToggleButton.IsCheckedProperty, binding17);

                Binding binding18 = new Binding("CircleChecked");
                ToggleButton ToggleButtonCircle = ((ToggleButton)topToolbar.Children[18]);
                ToggleButtonCircle.SetBinding(ToggleButton.IsCheckedProperty, binding18);

                Binding binding19 = new Binding("RectangleChecked");
                ToggleButton ToggleButtonRectangle = ((ToggleButton)topToolbar.Children[19]);
                ToggleButtonRectangle.SetBinding(ToggleButton.IsCheckedProperty, binding19);

                Binding binding20 = new Binding("PolygonChecked");
                ToggleButton ToggleButtonPolygon = ((ToggleButton)topToolbar.Children[20]);
                ToggleButtonPolygon.SetBinding(ToggleButton.IsCheckedProperty, binding20);

                List<ToggleButton> Tools = new List<ToggleButton>() { ToggleButtonRuler, ToggleButtonText, ToggleButtonArrow , ToggleButtonLine , ToggleButtonCurve, ToggleButtonCircle, ToggleButtonRectangle, ToggleButtonPolygon };

                foreach (var item in Tools)
                {
                    item.Checked += delegate(object sender, RoutedEventArgs e)
                    {

                        foreach (var item1 in Tools)
                        {
                            if (item1!=item)
                                if (item1.IsChecked == true)
                                    item1.IsChecked = false;

                        }
 
                    };

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        

    }
}
