using ConfigBottomView;
using Global.Controls;
using Global.UserControls;
using Global.UserControls.DrawVisual;
using Lambda;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Global
{

    /// <summary>
    /// 监听AddInjection事件
    /// </summary>
    public partial class WindowData
    {
        public TabItem propertySetItem;
        public TabControl tabControl;
        private ToggleButton histogramTogg;



      private void AddInjection()
        {
            Window mainwin = Application.Current.MainWindow;
           
            //等待窗口

            try
            {
              
                WrapPanel WrapPanel1 = (WrapPanel)mainwin.FindName("rightToolbar");
                //检测如果找不到rightToolbar 直接退出
                if (WrapPanel1 == null)
                    return;
                ToggleButton QuaterTogg = (ToggleButton)WrapPanel1.Children[0];
                ToggleButton DualTogg =   (ToggleButton)WrapPanel1.Children[1];
                ToggleButton BFTogg =     (ToggleButton)WrapPanel1.Children[2];
                ToggleButton DFTogg =     (ToggleButton)WrapPanel1.Children[3];
                ToggleButton RITogg =     (ToggleButton)WrapPanel1.Children[4];
                ToggleButton DPTogg =     (ToggleButton)WrapPanel1.Children[5];
                ToggleButton PhiTogg =    (ToggleButton)WrapPanel1.Children[6];
                ToggleButton FLTogg =     (ToggleButton)WrapPanel1.Children[7];
                ToggleButton _3DTogg =    (ToggleButton)WrapPanel1.Children[8];
                ToggleButton CubeTogg =   (ToggleButton)WrapPanel1.Children[9];
                ToggleButton RepoTogg =   (ToggleButton)WrapPanel1.Children[10];

                List<ToggleButton> RightTools = new List<ToggleButton>() { QuaterTogg, DualTogg, BFTogg, DFTogg, RITogg, DPTogg, PhiTogg, FLTogg, _3DTogg, CubeTogg, RepoTogg };

                foreach (var item in RightTools)
                {
                    item.Checked += delegate (object sender, RoutedEventArgs e)
                    {

                        foreach (var item1 in RightTools)
                        {
                            if (item1 != item)
                            {
                                if (item1.IsChecked == true)
                                    item1.IsChecked = false;
                            }

                        }

                    };

                }

             

                Popup popup = new Popup();
                popup.PopupAnimation = PopupAnimation.Slide;
                Binding binding8 = new Binding();
                popup.PlacementTarget = QuaterTogg;
               // Point point = Mouse.GetPosition(QuaterTogg);
                popup.HorizontalOffset =-65;
                
                popup.VerticalOffset = -20;
                popup.StaysOpen = false;
                QuaterPopup quaterPopup = new QuaterPopup();
                popup.Child = quaterPopup;
                QuaterTogg.MouseEnter += delegate
                {
                    popup.IsOpen = true;

                };
                popup.Closed +=delegate { popup.IsOpen = false; };




                quaterPopup.dual.Checked += delegate
                {
                     if (QuaterTogg.IsChecked == true)
                    {

                        LambdaControl.Trigger("QUATER_CLICKED0", mainwin, new Dictionary<string, object> { { "mode", 2 } });
                            histogramTogg.IsChecked = false;
                            histogramTogg.IsEnabled = false;
    
                    }
                    else
                    {
                        QuaterTogg.IsChecked = true;
                    }

                };



                quaterPopup.four.Checked += delegate
                {
                   
                    if (QuaterTogg.IsChecked == true)
                    {
                        LambdaControl.Trigger("QUATER_CLICKED2", mainwin, new EventArgs());
                        LambdaControl.Trigger("QUATER_CLICKED0", mainwin, new Dictionary<string, object> { { "mode", 4 } });
                        
                        histogramTogg.IsChecked = false;
                        histogramTogg.IsEnabled = false;
                       
                    }
                    else
                    {
                        QuaterTogg.IsChecked = true;
                    }


                };
                quaterPopup.six.Checked += delegate
                {
                   
                    if (QuaterTogg.IsChecked == true)
                    {
                        LambdaControl.Trigger("QUATER_CLICKED3", mainwin, new EventArgs());
                        LambdaControl.Trigger("QUATER_CLICKED0", mainwin, new Dictionary<string, object> { { "mode", 6 } });

                        histogramTogg.IsChecked = false;
                        histogramTogg.IsEnabled = false;

                    }
                    else
                    {
                        QuaterTogg.IsChecked = true;
                    }

                };
                void FourWindowTogg_Checked(object sender, RoutedEventArgs e)
                {
                    if ((bool)quaterPopup.four.IsChecked)
                       
                    {
                        LambdaControl.Trigger("QUATER_CLICKED2", mainwin, new EventArgs());

                        LambdaControl.Trigger("QUATER_CLICKED0", mainwin, new Dictionary<string, object> { { "mode", 4 } });

                        histogramTogg.IsChecked = false;
                        histogramTogg.IsEnabled = false;

                    }
                    else if ((bool)quaterPopup.six.IsChecked)
                    {
                        LambdaControl.Trigger("QUATER_CLICKED3", mainwin, new EventArgs());
                        LambdaControl.Trigger("QUATER_CLICKED0", mainwin, new Dictionary<string, object> { { "mode", 6 } });

                        histogramTogg.IsChecked = false;
                        histogramTogg.IsEnabled = false;

                    }
                    else if ((bool)quaterPopup.dual.IsChecked)
                    {
                        LambdaControl.Trigger("QUATER_CLICKED0", mainwin, new Dictionary<string, object> { { "mode", 2 } });

                        histogramTogg.IsChecked = false;
                        histogramTogg.IsEnabled = false;

                    }

                }

                DualTogg.Click += delegate
                {
                    if (DualTogg.IsChecked == false)
                    {
                        LambdaControl.Trigger("QUATER_CLICKED1", mainwin, new EventArgs());
                        LambdaControl.Trigger("QUATER_CLICKED0", mainwin, new Dictionary<string, object> { { "mode", 1 } });
                        if (histogramTogg.IsEnabled == false)
                        {
                            histogramTogg.IsEnabled = true;
                        }
                    }

                };

                QuaterTogg.Checked += FourWindowTogg_Checked;

                QuaterTogg.Unchecked += delegate
                {
                    LambdaControl.Trigger("QUATER_CLICKED1", mainwin, new EventArgs());
                    LambdaControl.Trigger("QUATER_CLICKED0", mainwin, new Dictionary<string, object> { { "mode", 1} });
                    if (histogramTogg.IsEnabled == false)
                    {
                        histogramTogg.IsEnabled = true;
                    }
                };
               
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            // histogramtogg
            try
            {
                DockPanel leftToolBar = (DockPanel)mainwin.FindName("leftToolbar");
                if (leftToolBar == null) return;
                WrapPanel leftToolBarChild = (WrapPanel)leftToolBar.Children[0];
                histogramTogg = (ToggleButton)leftToolBarChild.Children[3];


            }
            catch
            {

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
                colorBarUser.Visibility = Visibility.Hidden;
                leftToolBar.Children.Add(colorBarUser);
                WrapPanel leftToolBarChild = (WrapPanel)leftToolBar.Children[0];
                ToggleButton colorbarTogg = (ToggleButton)leftToolBarChild.Children[0];
               

                ViewMode.PropertyChanged += delegate (object? sender, PropertyChangedEventArgs e)
                {
                    if (e.PropertyName == "SelectViewMode")
                    {
                        if (ViewMode.SelectViewMode == 0 || ViewMode.SelectViewMode == 1 || ViewMode.SelectViewMode == 3 || ViewMode.SelectViewMode == 4)
                            colorbarTogg.IsEnabled = true;
                        else
                            colorbarTogg.IsEnabled = false;
                    }

                };

                colorbarTogg.PreviewMouseRightButtonUp += delegate (object sender, MouseButtonEventArgs e)
                {
                    if (colorbarTogg.IsChecked == false)
                    {
                        colorbarTogg.ContextMenu.Visibility = Visibility.Collapsed;
                        return;
                    }
                    else
                    {
                        colorbarTogg.ContextMenu.Visibility = Visibility.Visible;
                        colorbarTogg.ContextMenu.HorizontalOffset = 30;
                        Point pointClicked = e.GetPosition(colorbarTogg);
                        double x = pointClicked.X;
                        double y = pointClicked.Y;
                        colorbarTogg.ContextMenu.HorizontalOffset = 30 - x;
                        colorbarTogg.ContextMenu.VerticalOffset = -y;

                    }
                };

                colorbarTogg.Checked += delegate
                {
                    colorBarUser.Visibility = Visibility.Visible;
                };
                colorbarTogg.Unchecked += delegate
                {
                    colorBarUser.Visibility = Visibility.Hidden;
                };










                List<string> colorname = new List<string> { "AUTUMN", "BONE", "JET", "WINTER", "RAINBOW", "OCEAN", "SUMMER", "SPRING", "COOL", "HSV", "PINK", "HOT", "PARULA", "MAGMA", "INFERNO", "PLASMA", "VIRIDIS", "CIVIDIS", "TWILIGHT", "SHIFTED", "TURBO", "DEEPGREEN" };

                ContextMenu contextMenu = new ContextMenu();

                //从配置文件中读取
                string checkedname = "GRAY";
                int i = 0;
                foreach (var item in colorname)
                {
                    RadioMenuItem menuItem = new RadioMenuItem();


                    StackPanel stackPanel = new StackPanel();
                    stackPanel.Orientation = Orientation.Horizontal;

                    Image img = new Image() { Width = 50 };
                    img.Source = new BitmapImage(new Uri($"/Global;component/usercontrols/image/{item.ToLower()}.jpg", UriKind.Relative));
                    stackPanel.Children.Add(img);

                    TextBlock textBlock = new TextBlock();
                    textBlock.Text = item;
                    textBlock.Margin = new Thickness(10, 0, 0, 0);
                    stackPanel.Children.Add(textBlock);

                    menuItem.Header = stackPanel;
                    menuItem.Tag = i++;


                    menuItem.Checked += delegate (object sender, RoutedEventArgs e)
                    {
                        ResourceDictionary resourceDictionary = new ResourceDictionary();
                        resourceDictionary.Source = new Uri("Global;Component/Themes/ColorMap.xaml", UriKind.Relative);
                        LinearGradientBrush brush = (LinearGradientBrush)resourceDictionary[item];
                        colorBarUser.colorBar.SlidBackground = brush;
                        Dictionary<string, object> data = new() { { "mode", menuItem.Tag } };
                        LambdaControl.Trigger("COLORBAR_SELECTED_INDEX", this, data);
                    };

                    menuItem.Unchecked += delegate (object sender, RoutedEventArgs e)
                    {
                        if (contextMenu.Tag == null)
                        {
                            ResourceDictionary resourceDictionary = new ResourceDictionary();
                            resourceDictionary.Source = new Uri("Global;Component/Themes/ColorMap.xaml", UriKind.Relative);
                            LinearGradientBrush brush = (LinearGradientBrush)resourceDictionary["GRAY"];
                            colorBarUser.colorBar.SlidBackground = brush;
                            LambdaControl.Trigger("COLORBAR_SELECTED_INDEX", this, new Dictionary<string, object> { { "mode", 22 } });

                        }
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
                    colorBarUser.colorBar.SlidThumbVis = Visibility.Hidden;
                };
                monoColorTogg.Unchecked += delegate
                {
                    colorBarUser.colorBar.SlidThumbVis = Visibility.Visible;
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            try
            {

                tabControl = (TabControl)mainwin.FindName("leftTab");
                Border border = (Border)tabControl.Parent;
                //tabControl.Parent 
                if (tabControl == null) return;
                propertySetItem = new TabItem();
                propertySetItem.Header = "属性设置";
                ScrollViewer scrollViewer = new ScrollViewer();
                scrollViewer.HorizontalScrollBarVisibility = ScrollBarVisibility.Disabled;
                scrollViewer.VerticalScrollBarVisibility = ScrollBarVisibility.Auto;
                Viewbox proViewBox = new Viewbox();
                proViewBox.VerticalAlignment = VerticalAlignment.Top;
                proViewBox.Stretch = Stretch.Uniform;
                StackPanel stackPanel = new StackPanel();
                stackPanel.HorizontalAlignment = HorizontalAlignment.Stretch;
                DimenPreoperty dimenPreoperty = new DimenPreoperty();
                stackPanel.Children.Add(dimenPreoperty);
                proViewBox.Child = stackPanel;
                scrollViewer.Content = proViewBox;
                propertySetItem.Content = scrollViewer;
                propertySetItem.Visibility = Visibility.Collapsed;
                tabControl.Items.Add(propertySetItem);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



            try
            {
                WrapPanel topToolbar = (WrapPanel)mainwin.FindName("topToolbar");
                topToolbar.DataContext = ImageViewState.toolTop;

                Binding binding0 = new Binding("SelectChecked");
                ToggleButton ToggleButtonSelect = ((ToggleButton)topToolbar.Children[0]);
                ToggleButtonSelect.SetBinding(ToggleButton.IsCheckedProperty, binding0);

                Binding binding1 = new Binding("InlineChecked");
                ToggleButton ToggleButtonInline = ((ToggleButton)topToolbar.Children[1]);
                ToggleButtonInline.SetBinding(ToggleButton.IsCheckedProperty, binding1);

                Binding binding2 = new Binding("MoveChecked");
                ToggleButton ToggleButtonMove = ((ToggleButton)topToolbar.Children[2]);
                ToggleButtonMove.SetBinding(ToggleButton.IsCheckedProperty, binding2);

                //Binding binding3 = new Binding("SearchChecked");
                //ToggleButton ToggleButtonSearch = ((ToggleButton)topToolbar.Children[3]);
                //ToggleButtonSearch.SetBinding(ToggleButton.IsCheckedProperty, binding3);

                Binding binding4 = new Binding("ZoomOutChecked");
                ToggleButton ToggleButtonZoomOut = ((ToggleButton)topToolbar.Children[4]);
                ToggleButtonZoomOut.SetBinding(ToggleButton.IsCheckedProperty, binding4);

                Binding binding5 = new Binding("ZoomInChecked");
                ToggleButton ToggleButtonZoomIn = ((ToggleButton)topToolbar.Children[5]);
                ToggleButtonZoomIn.SetBinding(ToggleButton.IsCheckedProperty, binding5);

                //Binding binding6 = new Binding("ScaleInChecked");
                //ToggleButton ToggleButtonScale = ((ToggleButton)topToolbar.Children[6]);
                //ToggleButtonScale.SetBinding(ToggleButton.IsCheckedProperty, binding6);

                Binding binding9 = new Binding("DimensionChecked");
                ToggleButton ToggleButtonDimen = ((ToggleButton)topToolbar.Children[9]);
                ToggleButtonDimen.SetBinding(ToggleButton.IsCheckedProperty, binding9);

                Binding binding10 = new Binding("FocusChecked");
                ToggleButton ToggleButtonFocus = ((ToggleButton)topToolbar.Children[10]);
                ToggleButtonFocus.SetBinding(ToggleButton.IsCheckedProperty, binding10);

                Binding binding11 = new Binding("RulerChecked");
                ToggleButton ToggleButtonRuler = ((ToggleButton)topToolbar.Children[11]);
                ToggleButtonRuler.SetBinding(ToggleButton.IsCheckedProperty, binding11);

                ToggleButtonDimen.Checked += delegate
                {

                    propertySetItem.Visibility = Visibility.Visible;
                    propertySetItem.DataContext = drawMethod.dimenViewModel;
                    tabControl.SelectedIndex = 5;
                };
                ToggleButtonDimen.Unchecked += delegate
                {
                    // propertySetItem.Content = null;
                    propertySetItem.Visibility = Visibility.Collapsed;
                    tabControl.SelectedIndex = 1;
                };
                ToggleButtonInline.Checked += delegate
                {
                    
                    Border border = (Border)mainwin.FindName("imagingView");
                    Grid grid = (Grid)border.Child;
                    grid.Children[0].Visibility = Visibility.Collapsed;
                    grid.Children[1].Visibility = Visibility.Collapsed;
                    grid.Children[2].Visibility = Visibility.Collapsed;
                    grid.Children[3].Visibility = Visibility.Collapsed;


                };
                ToggleButtonInline.Unchecked += delegate
                {
                    Border border = (Border)mainwin.FindName("imagingView");
                    Grid grid = (Grid)border.Child;
                    grid.Children[0].Visibility = Visibility.Visible;
                    grid.Children[1].Visibility = Visibility.Visible;
                    grid.Children[2].Visibility = Visibility.Visible;
                    grid.Children[3].Visibility = Visibility.Visible;

                };
                Application.Current.MainWindow.PreviewKeyDown += delegate (object sender, KeyEventArgs e)
                {
                    if ((e.Key == Key.LeftShift || e.Key == Key.RightShift) && ImageViewState.toolTop.InlineChecked)
                    {
                        ImageViewState.toolTop.InlineChecked = false;
                    }
                };

                Binding binding13 = new Binding("EraserChecked");
                ToggleButton ToggleButtonEraser = ((ToggleButton)topToolbar.Children[13]);
                ToggleButtonEraser.SetBinding(ToggleButton.IsCheckedProperty, binding13);

                Binding binding14 = new Binding("TextChecked");
                ToggleButton ToggleButtonText = ((ToggleButton)topToolbar.Children[14]);
                ToggleButtonText.SetBinding(ToggleButton.IsCheckedProperty, binding14);

                Binding binding15 = new Binding("ArrowChecked");
                ToggleButton ToggleButtonArrow = ((ToggleButton)topToolbar.Children[15]);
                ToggleButtonArrow.SetBinding(ToggleButton.IsCheckedProperty, binding15);

                Binding binding16 = new Binding("LineChecked");
                ToggleButton ToggleButtonLine = ((ToggleButton)topToolbar.Children[16]);
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

                List<ToggleButton> Tools = new List<ToggleButton>() { ToggleButtonSelect, ToggleButtonInline, ToggleButtonMove, ToggleButtonZoomOut, ToggleButtonZoomIn, ToggleButtonDimen, ToggleButtonFocus, ToggleButtonRuler, ToggleButtonEraser, ToggleButtonText, ToggleButtonArrow, ToggleButtonLine, ToggleButtonCurve, ToggleButtonCircle, ToggleButtonRectangle, ToggleButtonPolygon };

                foreach (var item in Tools)
                {
                    item.Checked += delegate (object sender, RoutedEventArgs e)
                    {

                        foreach (var item1 in Tools)
                        {
                            if (item1 != item)
                            {
                                if (item1.IsChecked == true)
                                    item1.IsChecked = false;
                            }

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
