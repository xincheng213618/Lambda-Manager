using ConfigBottomView;
using Global.Common;
using Global.Controls;
using Global.Mode.Config;
using Global.UserControls;
using Global.UserControls.DrawVisual;
using Lambda;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
namespace Global
{

    enum ViewWindowMode
    {
        FIRST_WINDOW,
        SECOND_WINDOW,
        FOURTH_WINDOW,
        SIXTH_WINDOW,
        DOUBLE_WINDOW
    };

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

            try
            {
                Grid grid = (Grid)mainwin.FindName("grid0");
                if (grid == null) return;
                Image image = (Image)grid.Children[0];


                // Add Histogram
                Histogram histogram = new Histogram();
                StackPanel stackPanel = (StackPanel)mainwin.FindName("bottomView");
                Grid grid1 =(Grid)stackPanel.Parent;
                histogram.Height = Double.NaN;
               // histogram.Width = 450;
                histogram.Visibility = Visibility.Collapsed;
                histogram.DataContext = histogramModel;
                histogram.VerticalAlignment = VerticalAlignment.Stretch;
                stackPanel.Children.Add(histogram);
                
                Profile profile = new Profile();   //profile
                profile.Height = Double.NaN;
                profile.Visibility = Visibility.Collapsed;
                profile.Margin= new Thickness(30, 0, 0, 0);
                stackPanel.Orientation = Orientation.Horizontal;
                profile.DataContext = profileModel;
                profile.doubleUpDown1.ValueChanged += delegate
                 {
                     if (inkVisuals[0] !=null &&inkVisuals[0].inkCanvas.Strokes.Contains(inkVisuals[0].profileStroke))
                         inkVisuals[0].DrawProfile();
                 };
                profile.doubleUpDown2.ValueChanged += delegate
                {
                    if (inkVisuals[0] != null && inkVisuals[0].inkCanvas.Strokes.Contains(inkVisuals[0].profileStroke))
                        inkVisuals[0].DrawProfile();
                };
                profile.Marker1Check.Click += delegate
                {
                    if (inkVisuals[0] != null && inkVisuals[0].inkCanvas.Strokes.Contains( inkVisuals[0].profileStroke))
                    inkVisuals[0].DrawProfile();
                };
                profile.Marker2Check.Click += delegate
                {
                    if (inkVisuals[0] != null && inkVisuals[0].inkCanvas.Strokes.Contains(inkVisuals[0].profileStroke))
                        inkVisuals[0].DrawProfile();
                };
                stackPanel.Children.Add(profile);

                //grid1.Children.Add(profile);
                //Grid.SetRow(profile, 2);

                // gridSplitter
                GridSplitter gridSplitter = (GridSplitter)grid1.Children[1];
                gridSplitter.HorizontalAlignment = HorizontalAlignment.Stretch;
                gridSplitter.VerticalAlignment = VerticalAlignment.Center;
                Brush brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#444444"));
                gridSplitter.Background = brush;
                gridSplitter.Height = 3;
                DockPanel leftToolBar = (DockPanel)mainwin.FindName("leftToolbar");
                if (leftToolBar == null) return;
                WrapPanel leftToolBarChild = (WrapPanel)leftToolBar.Children[0];
                ToggleButton histogramTogg = (ToggleButton)leftToolBarChild.Children[3];

                histogramTogg.Checked += delegate
                {
                   
                    grid1.RowDefinitions[2].Height = new GridLength(180, GridUnitType.Pixel);
                    histogram.Visibility = Visibility.Visible;
                };
                histogramTogg.Unchecked += delegate
                {
                    histogram.Visibility = Visibility.Collapsed;
                    if (profile.Visibility == Visibility.Collapsed)
                    {
                        grid1.RowDefinitions[2].Height = new GridLength(0, GridUnitType.Pixel);
                    }
                   

                };

                ImageViewState.toolTop.PropertyChanged += delegate (object? sender, PropertyChangedEventArgs e)
                {
                     
                    if (e.PropertyName == "ProfileChecked")
                    {
                        if (ImageViewState.toolTop.ProfileChecked)
                        {

                            grid1.RowDefinitions[2].Height = new GridLength(180, GridUnitType.Pixel);
                            profile.Visibility = Visibility.Visible;
                        }
                        else
                        {         
                            profile.Visibility = Visibility.Collapsed;
                            if (histogram.Visibility == Visibility.Collapsed)
                            {
                                grid1.RowDefinitions[2].Height = new GridLength(0, GridUnitType.Pixel);
                            }
                        }

                    };
                    
                    if (ImageViewState.toolTop.RulerChecked == true|| ImageViewState.toolTop.ArrowChecked == true|| ImageViewState.toolTop.CircleChecked==true|| ImageViewState.toolTop.CurveChecked== true|| ImageViewState.toolTop.DimensionChecked==true|| ImageViewState.toolTop.LineChecked==true|| ImageViewState.toolTop.PolygonChecked==true|| ImageViewState.toolTop.RectangleChecked==true|| ImageViewState.toolTop.TextChecked==true)
                    {
                        propertySetItem.Visibility = Visibility.Visible;
                        propertySetItem.DataContext = DrawInkMethod.dimenViewModel;
                        tabControl.SelectedIndex = 5;
                    }
                    else
                    {
                        propertySetItem.Visibility = Visibility.Collapsed;
                        //tabControl.SelectedIndex = 1;

                    };

                };
              
                }
            catch (Exception ex)
            {
                LambdaControl.Log(new Message() { Severity = Severity.ERROR, Text = ex.Message });
            }

           

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

                List<ToggleButton> RightTools2 = new List<ToggleButton>() {  BFTogg, DFTogg, RITogg, DPTogg, PhiTogg, FLTogg, _3DTogg, CubeTogg, RepoTogg };

                foreach (var item in RightTools2)
                {
                    item.Checked += delegate (object sender, RoutedEventArgs e)
                    {
                        foreach (var item1 in RightTools2)
                        {
                            if (item1 != item)
                            {
                                if (item1.IsChecked == true)
                                    item1.IsChecked = false;
                            }
                        }

                    };

                }

                List<ToggleButton> RightTools1 = new List<ToggleButton>() { QuaterTogg, DualTogg };

                foreach (var item in RightTools1)
                {
                    item.Checked += delegate (object sender, RoutedEventArgs e)
                    {
                        foreach (var item1 in RightTools1)
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
;
               
                quaterPopup.dual.Checked += delegate
                {
                    if (QuaterTogg.IsChecked == true)
                    {
                        LambdaControl.Trigger("QUATER_CLICKED0", mainwin, new Dictionary<string, object> { { "mode", (int)ViewWindowMode.SECOND_WINDOW } });
                        histogramTogg.IsChecked = false;
                        histogramTogg.IsEnabled = false;
                    }
                    else
                    {
                        QuaterTogg.IsChecked = true;
                    }
                   popup.IsOpen = false;
                };

                quaterPopup.four.Checked += delegate
                {    
                    if (QuaterTogg.IsChecked == true)
                    {
                        LambdaControl.Trigger("QUATER_CLICKED0", mainwin, new Dictionary<string, object> { { "mode", (int)ViewWindowMode.FOURTH_WINDOW } });
                        
                        histogramTogg.IsChecked = false;
                        histogramTogg.IsEnabled = false;
                       
                    }
                    else
                    {
                        QuaterTogg.IsChecked = true;
                    }
                    popup.IsOpen = false;

                };
                quaterPopup.six.Checked += delegate
                {
                   
                    if (QuaterTogg.IsChecked == true)
                    {
                        LambdaControl.Trigger("QUATER_CLICKED0", mainwin, new Dictionary<string, object> { { "mode", (int)ViewWindowMode.SIXTH_WINDOW } });

                        histogramTogg.IsChecked = false;
                        histogramTogg.IsEnabled = false;

                    }
                    else
                    {
                        QuaterTogg.IsChecked = true;
                    }
                    popup.IsOpen = false;
                };
                void FourWindowTogg_Checked(object sender, RoutedEventArgs e)
                {
                    if ((bool)quaterPopup.four.IsChecked)
                    {
                        LambdaControl.Trigger("QUATER_CLICKED0", mainwin, new Dictionary<string, object> { { "mode", (int)ViewWindowMode.FOURTH_WINDOW } });
                        histogramTogg.IsChecked = false;
                        histogramTogg.IsEnabled = false;

                    }
                    else if ((bool)quaterPopup.six.IsChecked)
                    {
                        LambdaControl.Trigger("QUATER_CLICKED0", mainwin, new Dictionary<string, object> { { "mode", (int)ViewWindowMode.SIXTH_WINDOW } });
                        histogramTogg.IsChecked = false;
                        histogramTogg.IsEnabled = false;
                    }
                    else if ((bool)quaterPopup.dual.IsChecked)
                    {
                        LambdaControl.Trigger("QUATER_CLICKED0", mainwin, new Dictionary<string, object> { { "mode", (int)ViewWindowMode.SECOND_WINDOW } });

                        histogramTogg.IsChecked = false;
                        histogramTogg.IsEnabled = false;

                    }

                }
                

                DualTogg.Click += delegate
                {
                    if (DualTogg.IsChecked == false)
                    {
                        LambdaControl.Trigger("QUATER_CLICKED0", mainwin, new Dictionary<string, object> { { "mode", (int)ViewWindowMode.FIRST_WINDOW} });
                        if (histogramTogg.IsEnabled == false)
                        {
                            histogramTogg.IsEnabled = true;
                        }
                        if (inkVisuals[0] != null)
                        {
                            if (inkVisuals[0].inkCanvas.ContextMenu != null)
                            {
                                inkVisuals[0].inkCanvas.ContextMenu = null;
                            }
                        }
                    }
                    else
                    {
                        LambdaControl.Trigger("QUATER_CLICKED0", mainwin, new Dictionary<string, object> { { "mode", (int)ViewWindowMode.DOUBLE_WINDOW } });
                    }

                };
                QuaterTogg.Checked += FourWindowTogg_Checked;
                QuaterTogg.Unchecked += delegate
                {
                    LambdaControl.Trigger("QUATER_CLICKED0", mainwin, new Dictionary<string, object> { { "mode", (int)ViewWindowMode.FIRST_WINDOW } });
                    if (histogramTogg.IsEnabled == false)
                    {
                        histogramTogg.IsEnabled = true;
                    }
                    if (inkVisuals[0]!= null)
                    {
                        if (inkVisuals[0].inkCanvas.ContextMenu != null)
                        {
                            inkVisuals[0].inkCanvas.ContextMenu = null;
                        }
                    }
                };                           
            }
            catch (Exception ex)
            {
               System.Windows.MessageBox.Show(ex.Message);

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
            try
            {
               
                
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
               

                OperatingMode.PropertyChanged += delegate (object? sender, PropertyChangedEventArgs e)
                {
                    if (e.PropertyName == "SelectViewMode")
                    {
                        if (OperatingMode.SelectViewMode == 0 || OperatingMode.SelectViewMode == 1 || OperatingMode.SelectViewMode == 3 || OperatingMode.SelectViewMode == 4)
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
                System.Windows.MessageBox.Show(ex.Message);
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
                System.Windows.MessageBox.Show(ex.Message);

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
                dimenPreoperty.DataContext = DrawInkMethod.dimenViewModel;
                proViewBox.Child = stackPanel;
                scrollViewer.Content = proViewBox;
                propertySetItem.Content = scrollViewer;
                propertySetItem.Visibility = Visibility.Collapsed;
                tabControl.Items.Add(propertySetItem);

                dimenPreoperty.ColorTextBox.TextChanged += delegate
                {
                    inkMethod.drawingAttributes.Color = DrawInkMethod.dimenViewModel.SelectedAccentColor;
                };



            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }





            // add progressBar 
            try
            {

            }
            catch
            {

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
                ToggleButtonMove.IsChecked = true;
                ImageViewState.toolTop.MoveChecked = true;

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

                ToggleButton ToggleButtonProfile = ((ToggleButton)topToolbar.Children[12]);
                ToggleButtonProfile.SetBinding(ToggleButton.IsCheckedProperty, new Binding("ProfileChecked"));

               
               


                GridLength leftViewtemp = new GridLength(0);
                double tempLeft = 0, tempTop = 0, tempWidth = 0, tempHeight = 0;
                ResizeMode resizeMode = new ResizeMode();

                // viewMax
                ToggleButtonInline.Checked += delegate
                {

                    ColumnDefinition leftView = (ColumnDefinition)mainwin.FindName("leftView");
                    leftViewtemp = leftView.Width;
                    leftView.Width = new GridLength(0);


                    Border border = (Border)mainwin.FindName("imagingView");
                    border.Background = Brushes.Transparent;
                    border.BorderThickness = new Thickness(0);
                    Grid grid = (Grid)border.Child;
                    Grid Grid1 = (Grid)grid.Children[0];

                    Grid1.Children[0].Visibility = Visibility.Collapsed;
                    Grid1.Children[1].Visibility = Visibility.Collapsed;
                    Grid1.Children[2].Visibility = Visibility.Collapsed;
                    Grid1.Children[3].Visibility = Visibility.Collapsed;

                    StatusBar statusBar = (StatusBar)mainwin.FindName("statusBar");
                    Grid stageAcquisition = (Grid)mainwin.FindName("stageAcquisition");
                    Grid mainGrid = (Grid)stageAcquisition.Parent;


                    mainGrid.Children[0].Visibility = Visibility.Collapsed;

                    statusBar.Visibility = Visibility.Collapsed;
                    stageAcquisition.Children[0].Visibility = Visibility.Collapsed;
                    stageAcquisition.Children[1].Visibility = Visibility.Collapsed;
                    stageAcquisition.Children[2].Visibility = Visibility.Collapsed;
                    stageAcquisition.Children[3].Visibility = Visibility.Collapsed;
                    stageAcquisition.Children[4].Visibility = Visibility.Collapsed;
                    stageAcquisition.Children[5].Visibility = Visibility.Collapsed;
                    System.Windows.Forms.Screen screen = System.Windows.Forms.Screen.AllScreens[0];
                    mainwin.WindowStyle = WindowStyle.None;
                    resizeMode = mainwin.ResizeMode;
                    mainwin.ResizeMode = ResizeMode.NoResize;

                    tempLeft = mainwin.Left;
                    tempTop = mainwin.Top;
                    tempWidth = mainwin.Width;
                    tempHeight = mainwin.Height;


                    mainwin.Left = screen.Bounds.Left;
                    mainwin.Top = screen.Bounds.Top;
                    mainwin.Width = screen.Bounds.Width;
                    mainwin.Height = screen.Bounds.Height; ;


                    DockPanel leftToolBar = (DockPanel)mainwin.FindName("leftToolbar");
                    if (leftToolBar == null) return;
                    WrapPanel leftToolBarChild = (WrapPanel)leftToolBar.Children[0];
                    ToggleButton histogramTogg = (ToggleButton)leftToolBarChild.Children[3];
                    if (histogramTogg.IsChecked == true)
                    {
                        histogramTogg.IsChecked =false;
                    }
                };
                ToggleButtonInline.Unchecked += delegate
                {
                    ColumnDefinition leftView = (ColumnDefinition)mainwin.FindName("leftView");
                    leftView.Width = leftViewtemp;

                    Border border = (Border)mainwin.FindName("imagingView");
                    border.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#444444"));
                    border.BorderThickness =new Thickness(2);
                    Grid grid = (Grid)border.Child;
                    Grid Grid1 = (Grid)grid.Children[0];

                    Grid1.Children[0].Visibility = Visibility.Visible;
                    Grid1.Children[1].Visibility = Visibility.Visible;
                    Grid1.Children[2].Visibility = Visibility.Visible;
                    Grid1.Children[3].Visibility = Visibility.Visible;
                    StatusBar statusBar = (StatusBar)mainwin.FindName("statusBar");
                    Grid stageAcquisition = (Grid)mainwin.FindName("stageAcquisition");
                    Grid mainGrid = (Grid)stageAcquisition.Parent;
                   
                    mainGrid.Children[0].Visibility = Visibility.Visible;
                    stageAcquisition.Children[0].Visibility = Visibility.Visible;
                    stageAcquisition.Children[1].Visibility = Visibility.Visible;
                    stageAcquisition.Children[2].Visibility = Visibility.Visible;
                    stageAcquisition.Children[3].Visibility = Visibility.Visible;
                    stageAcquisition.Children[4].Visibility = Visibility.Visible;
                    stageAcquisition.Children[5].Visibility = Visibility.Visible;

                    statusBar.Visibility = Visibility.Visible;
                    stageAcquisition.Visibility = Visibility.Visible;
                    mainwin.WindowStyle = WindowStyle.SingleBorderWindow;
                    mainwin.ResizeMode = resizeMode;

                    mainwin.Left = tempLeft;
                    mainwin.Top = tempTop;
                    mainwin.Width = tempWidth;
                    mainwin.Height = tempHeight;
                };
                try 
                { 
                    Application.Current.MainWindow.PreviewKeyDown += delegate (object sender, KeyEventArgs e)
                    {
                        if ((e.Key == Key.Escape) && ImageViewState.toolTop.InlineChecked)
                        {
                            ImageViewState.toolTop.InlineChecked = false;
                        }
                    };
                }
                catch (Exception ex)
                {
                    System.Windows.MessageBox.Show(ex.Message);
                }
               

                ToggleButton ToggleButtonEraser = ((ToggleButton)topToolbar.Children[14]);
                ToggleButtonEraser.SetBinding(ToggleButton.IsCheckedProperty, new Binding("EraserChecked"));

                ToggleButton ToggleButtonText = ((ToggleButton)topToolbar.Children[15]);
                ToggleButtonText.SetBinding(ToggleButton.IsCheckedProperty, new Binding("TextChecked"));
               
                ToggleButton ToggleButtonArrow = ((ToggleButton)topToolbar.Children[16]);
                ToggleButtonArrow.SetBinding(ToggleButton.IsCheckedProperty, new Binding("ArrowChecked"));

                ToggleButton ToggleButtonLine = ((ToggleButton)topToolbar.Children[17]);
                ToggleButtonLine.SetBinding(ToggleButton.IsCheckedProperty, new Binding("LineChecked"));



                ToggleButton ToggleButtonCurve = ((ToggleButton)topToolbar.Children[18]);
                ToggleButtonCurve.SetBinding(ToggleButton.IsCheckedProperty, new Binding("CurveChecked"));

                ToggleButton ToggleButtonCircle = ((ToggleButton)topToolbar.Children[19]);
                ToggleButtonCircle.SetBinding(ToggleButton.IsCheckedProperty, new Binding("CircleChecked"));

                ToggleButton ToggleButtonRectangle = ((ToggleButton)topToolbar.Children[20]);
                ToggleButtonRectangle.SetBinding(ToggleButton.IsCheckedProperty, new Binding("RectangleChecked"));

                ToggleButton ToggleButtonPolygon = ((ToggleButton)topToolbar.Children[21]);
                ToggleButtonPolygon.SetBinding(ToggleButton.IsCheckedProperty, new Binding("PolygonChecked"));

                List<ToggleButton> Tools = new List<ToggleButton>() { ToggleButtonSelect, ToggleButtonInline, ToggleButtonMove, ToggleButtonZoomOut, ToggleButtonZoomIn, ToggleButtonDimen, ToggleButtonFocus, ToggleButtonRuler,ToggleButtonProfile, ToggleButtonEraser, ToggleButtonText, ToggleButtonArrow, ToggleButtonLine, ToggleButtonCurve, ToggleButtonCircle, ToggleButtonRectangle, ToggleButtonPolygon };

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
                System.Windows.MessageBox.Show(ex.Message);
            }


            try
            {
                Grid gridMain = mainwin.Content as Grid;
                Grid grid2 = (Grid)gridMain.Children[0];

                StackPanel stackPanel2 = (StackPanel)grid2.Children[1];
                RadioButton radioButton3 = (RadioButton)stackPanel2.Children[2];
                //RadioButton radioButton3 = (RadioButton)mainwin.FindName("RadioButton3");

                StackPanel bottomView222 = (StackPanel)mainwin.FindName("bottomView");
                bottomView222.Visibility = Visibility.Collapsed;



                Border border = (Border)mainwin.FindName("imagingView");
                Grid grid = (Grid)border.Child;
                Grid Grid1 = (Grid)grid.Children[0];


                Border dealToolBoerder = new Border() { Style = Application.Current.MainWindow.FindResource("RadiusBorder") as Style };
                Grid.SetColumn(dealToolBoerder, 1);
                WrapPanel DealtoolWrapPanel = new WrapPanel() { Orientation = Orientation.Horizontal, HorizontalAlignment = HorizontalAlignment.Center };
                dealToolBoerder.Child = DealtoolWrapPanel;

                //这里覆盖Width并采用NaN是因为原来的样式指定了大小，这样能实现自动的效果
                ToggleButton ToggleButton1 = new ToggleButton() { Style = Application.Current.MainWindow.FindResource("ToggleButtonStyle1") as Style ,Content="2222222" ,Width=double.NaN};
                ToggleButton1.Click += delegate { MessageBox1.Show(ToggleButton1.Content.ToString()); };
                DealtoolWrapPanel.Children.Add(ToggleButton1);



                Grid1.Children.Add(dealToolBoerder);
                //初始化不显示
                dealToolBoerder.Visibility = Visibility.Collapsed;




                radioButton3.Checked += delegate
                {
                    Grid1.Children[0].Visibility = Visibility.Collapsed;
                    Grid1.Children[1].Visibility = Visibility.Collapsed;
                    Grid1.Children[2].Visibility = Visibility.Collapsed;
                    Grid1.Children[3].Visibility = Visibility.Collapsed;
                    dealToolBoerder.Visibility = Visibility.Visible;
                    bottomView222.Visibility = Visibility.Visible;
                };
                radioButton3.Unchecked += delegate
                {

                    Grid1.Children[0].Visibility = Visibility.Visible;
                    Grid1.Children[1].Visibility = Visibility.Visible;
                    Grid1.Children[2].Visibility = Visibility.Visible;
                    Grid1.Children[3].Visibility = Visibility.Visible;
                    dealToolBoerder.Visibility = Visibility.Collapsed;
                    bottomView222.Visibility = Visibility.Collapsed;
                };
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }


    }
}
