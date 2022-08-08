using Global.Controls;
using Global.UserControls;
using Global.UserControls.DrawVisual;
using Lambda;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;
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

    /// <summary>
    /// 监听AddInjection事件
    /// </summary>
    public partial class WindowData
    {

        private void AddInjection()
        {
            Window mainwin = Application.Current.MainWindow;

            try
            {
                WrapPanel WrapPanel1 = (WrapPanel)mainwin.FindName("rightToolbar");
                //检测如果找不到rightToolbar 直接退出
                if (WrapPanel1 == null)
                    return;
                ToggleButton buttton1 = (ToggleButton)WrapPanel1.Children[0];

                ContextMenu contextMenu = new ContextMenu();

                string WindowType = "QUATER_CLICKED2";
                buttton1.Checked += delegate
                {
                    //contextMenu.Visibility = Visibility.Visible;
                    LambdaControl.Trigger(WindowType, mainwin, new EventArgs());
                };
                buttton1.Unchecked += delegate
                {
                    //contextMenu.Visibility = Visibility.Collapsed;

                    LambdaControl.Trigger("QUATER_CLICKED1", mainwin, new EventArgs());
                };


                MenuItem menuItem2 = new MenuItem() { Header = "四" };
                MenuItem menuItem3 = new MenuItem() { Header = "六" };

                menuItem2.Click += delegate
                {
                    menuItem2.IsChecked = true;
                    menuItem3.IsChecked = false;

                    WindowType = "QUATER_CLICKED2";
                    LambdaControl.Trigger(WindowType, mainwin, new EventArgs());
                };

                menuItem3.Click += delegate
                {
                    menuItem2.IsChecked = false;
                    menuItem3.IsChecked = true;
                    WindowType = "QUATER_CLICKED3";
                    LambdaControl.Trigger(WindowType, mainwin, new EventArgs());
                };
                contextMenu.Items.Add(menuItem2);
                contextMenu.Items.Add(menuItem3);
                buttton1.ContextMenu = contextMenu;  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //ColorBar ADD
            try
            {

                DockPanel leftToolBar = (DockPanel)mainwin.FindName("leftToolbar");
                if (leftToolBar == null) return;
                 Image image = (Image)leftToolBar.Children[1];
                leftToolBar.Children.Remove(image);

                image.Visibility = Visibility.Collapsed;
                ColorBarUser colorBarUser = new ColorBarUser();
                leftToolBar.Children.Add(colorBarUser);
                WrapPanel leftToolBarChild = (WrapPanel)leftToolBar.Children[0];
                ToggleButton colorbarTogg = (ToggleButton)leftToolBarChild.Children[0];
                colorbarTogg.PreviewMouseRightButtonUp += delegate(object sender, MouseButtonEventArgs e)
                {
                    colorbarTogg.ContextMenu.HorizontalOffset = 30;
                    Point pointClicked = e.GetPosition(colorbarTogg);
                    double x = pointClicked.X;
                    double y = pointClicked.Y;
                    colorbarTogg.ContextMenu.HorizontalOffset = 30 - x;
                    colorbarTogg.ContextMenu.VerticalOffset = -y;
                };

                colorbarTogg.Checked += delegate
                {
                    colorBarUser.Visibility = Visibility.Visible;
                };
                colorbarTogg.Unchecked += delegate
                {
                    colorBarUser.Visibility = Visibility.Hidden;
                };

                List<string> colorname = new List<string> { "GRAY", "AUTUMN", "BONE", "JET", "WINTER", "RAINBOW", "OCEAN", "SUMMER", "SPRING", "COOL", "HSV", "PINK", "HOT", "PARULA", "MAGMA", "INFERNO", "PLASMA", "VIRIDIS", "CIVIDIS", "TWILIGHT", "SHIFTED", "TURBO", "DEEPGREEN"};

                ContextMenu contextMenu = new ContextMenu();

                //从配置文件中读取
                string checkedname = "GRAY";

                foreach (var item in colorname)
                {
                    RadioMenuItem menuItem = new RadioMenuItem();


                    StackPanel stackPanel = new StackPanel();
                    stackPanel.Orientation = Orientation.Horizontal;

                    Image img = new Image() { Width =50};
                    img.Source = new BitmapImage(new Uri($"/Global;component/usercontrols/image/{item.ToLower()}.jpg", UriKind.Relative));
                    stackPanel.Children.Add(img);

                    TextBlock textBlock = new TextBlock();
                    textBlock.Text = item;
                    textBlock.Margin = new Thickness(10, 0, 0, 0);
                    stackPanel.Children.Add(textBlock);

                    menuItem.Header = stackPanel;
                    menuItem.Tag = item;

                    menuItem.Click += delegate (object sender, RoutedEventArgs e)
                    {
                        ResourceDictionary resourceDictionary = new ResourceDictionary();
                        resourceDictionary.Source = new Uri("Global;Component/Themes/ColorMap.xaml", UriKind.Relative);
                        LinearGradientBrush brush = (LinearGradientBrush)resourceDictionary[item];
                        colorBarUser.colorBar.SlidBackground = brush;
                    };
                    contextMenu.Items.Add(menuItem);

                    if (checkedname == item)
                        menuItem.IsChecked = true;
                }
                colorbarTogg.ContextMenu = contextMenu;



                // MonoColor
                ToggleButton monoColorTogg = (ToggleButton)leftToolBarChild.Children[1];

                monoColorTogg.Checked += delegate
                {
                    colorBarUser.Visibility = Visibility.Hidden;
                };
                monoColorTogg.Unchecked += delegate
                {
                    colorBarUser.Visibility = Visibility.Visible;
                }; ;

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


                ((Button)topToolbar.Children[3]).SetBinding(ToggleButton.IsCheckedProperty, new Binding("FocusChecked"));

                Binding binding4 = new Binding("RulerChecked");
                ((ToggleButton)topToolbar.Children[4]).SetBinding(ToggleButton.IsCheckedProperty, binding4);


                Binding binding5 = new Binding("FocusChecked");
                ((ToggleButton)topToolbar.Children[5]).SetBinding(ToggleButton.IsCheckedProperty, binding5);


                Binding binding6 = new Binding("scale");
                Border border1 = (Border)topToolbar.Children[7];

                ((TextBox)border1.Child).SetBinding(TextBox.TextProperty, binding6);


                Binding binding13 = new Binding("EraserChecked");
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
