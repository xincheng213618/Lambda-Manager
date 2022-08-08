using ConfigBottomView;
using Global.Controls;
using Global.Mode.Config;
using Global.UserControls;
using Global.UserControls.DrawVisual;
using Lambda;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
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
using System.Windows.Media.Media3D;
using System.Windows.Resources;

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
            Window mainwin = Application.Current.MainWindow;

            //MainView
            try
            {
                Grid grid = (Grid)mainwin.FindName("grid0");
                Image image = (Image)grid.Children[0];

                DrawingVisualInk drawingVisualInk = new DrawingVisualInk(ImageViewState.toolTop, drawMethod, ratio);
                drawingCanvasInk[0] = drawingVisualInk; // First InkCanvas
                Binding bindingW = new Binding();
                bindingW.Source = image;
                bindingW.Path = new PropertyPath("ActualWidth");
                drawingVisualInk.SetBinding(DrawingVisualInk.WidthProperty, bindingW);

                Binding bindingH = new Binding();
                bindingH.Source = image;
                bindingH.Path = new PropertyPath("ActualHeight");
                drawingVisualInk.SetBinding(DrawingVisualInk.HeightProperty, bindingH);
                drawingVisualInk.Visibility = Visibility.Collapsed; //add 
                grid.Children.Add(drawingVisualInk);
                Grid.SetRow(drawingVisualInk, 0);
                // Add Histogram
                Histogram histogram = new Histogram();
                StackPanel stackPanel = (StackPanel)mainwin.FindName("bottomView");
                Grid grid1 =(Grid)stackPanel.Parent;
                histogram.Height = Double.NaN;
               // histogram.Width = 450;
                histogram.Visibility = Visibility.Collapsed;
                histogram.DataContext = histogramModel;
                grid1.Children.Add(histogram);
                Grid.SetRow(histogram, 2);
                grid1.Children.Remove(stackPanel);
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
                   
                    grid1.RowDefinitions[2].Height = new GridLength(200, GridUnitType.Pixel);
                    histogram.Visibility = Visibility.Visible;
                };
                histogramTogg.Unchecked += delegate
                {
                    histogram.Visibility = Visibility.Collapsed;
                    grid1.RowDefinitions[2].Height = new GridLength(0, GridUnitType.Pixel);

                };
                

                //updateStatus.PropertyChanged += delegate (object? sender, PropertyChangedEventArgs e)
                // {
                //     if (e.PropertyName == "Ratio")
                //     {
                //         ratio = Convert.ToDouble(updateStatus.Ratio.Trim('%')) / 100;

                //         List<Visual> visualsList = new List<Visual>();

                //         foreach (var item in drawingVisualInk.InkCanvas.visuals)
                //         {
                //             visualsList.Add(item);
                //         }

                //         if (visualsList.Count > 0)
                //         {
                //             foreach (DrawingVisual visual in visualsList)
                //             {
                //                 drawingVisualInk.InkCanvas.DeleteVisual(visual);
                //             }
                //             visualsList.Clear();
                //         }


                //         if (drawingVisualInk.InkCanvas.visuals.Count == 0 && ImageViewState.toolTop.DimensionChecked)
                //         {
                //             DrawingVisual dimDefaultVisual = new DrawingVisual();
                //             drawingVisualInk.InkCanvas.AddVisual(dimDefaultVisual);
                //             drawMethod.DrawDimension(image.ActualWidth, image.ActualHeight, ratio, new Point(0, 0), new Point(0, 0), true, dimDefaultVisual);
                //         }
                //     }
                // };






                ImageViewState.toolTop.PropertyChanged += delegate (object? sender, PropertyChangedEventArgs e)
                {
                    // MessageBox.Show("1111");
                    if (e.PropertyName == "EraserChecked")
                    {
                        if (ImageViewState.toolTop.EraserChecked == true)
                        {
                            StreamResourceInfo sri = Application.GetResourceStream(new Uri("/Global;component/usercontrols/image/hold.cur", UriKind.Relative));
                            drawingVisualInk.InkCanvas.Cursor = new Cursor(sri.Stream);
                        }
                        else
                        {
                            drawingVisualInk.InkCanvas.Cursor = Cursors.Arrow;
                        }
                    }
                    else if ((bool)ImageViewState.toolTop.DimensionChecked || (bool)ImageViewState.toolTop.ArrowChecked || (bool)ImageViewState.toolTop.CircleChecked || (bool)ImageViewState.toolTop.CurveChecked || (bool)ImageViewState.toolTop.PolygonChecked || (bool)ImageViewState.toolTop.TextChecked || (bool)ImageViewState.toolTop.LineChecked || (bool)ImageViewState.toolTop.RectangleChecked)
                    {
                        drawingVisualInk.InkCanvas.Cursor = Cursors.Cross;
                    }
                    else if ((bool)ImageViewState.toolTop.MoveChecked)
                    {
                        drawingVisualInk.InkCanvas.Cursor = Cursors.Hand;

                    }
                    else
                    {
                        drawingVisualInk.InkCanvas.Cursor = Cursors.Arrow;
                    };
                    if (e.PropertyName == "DimensionChecked")
                    {
                        if ((bool)ImageViewState.toolTop.DimensionChecked)
                        {
                            
                               DrawingVisual dimDefaultVisual = new DrawingVisual();
                            drawingVisualInk.InkCanvas.AddVisual(dimDefaultVisual);
                            drawMethod.DrawDimension(image.ActualWidth, image.ActualHeight, ratio, new Point(0, 0), new Point(0, 0), true, dimDefaultVisual);
                        }
                        else
                        {
                            

                        }

                    };
                    if (e.PropertyName == "SelectChecked")
                    {

                        if (ImageViewState.toolTop.SelectChecked == true)
                        {
                            drawingVisualInk.Visibility = Visibility.Visible;

                            if (!drawingVisualInk.InkCanvas.visuals.Contains(drawMethod.pixelVisual))
                                drawingVisualInk.InkCanvas.AddVisual(drawMethod.pixelVisual);

                        }
                        else
                        {
                            if (drawingVisualInk.InkCanvas.visuals.Contains(drawMethod.pixelVisual))
                                drawingVisualInk.InkCanvas.DeleteVisual(drawMethod.pixelVisual);
                            drawingVisualInk.Visibility = Visibility.Collapsed;
                        }
                    }
                    if(e.PropertyName== "CurveChecked")
                    { if (ImageViewState.toolTop.CurveChecked == true)
                        {
                            drawingVisualInk.InkCanvas.EditingMode = InkCanvasEditingMode.Ink;
                        }
                        else 
                        {
                            drawingVisualInk.InkCanvas.EditingMode = InkCanvasEditingMode.None;

                        }
                       
                    }

                };
                drawingVisualInk.InkCanvas.MouseMove += delegate (object sender, MouseEventArgs e)
                {
                    if (ImageViewState.toolTop.SelectChecked)
                    {
                        if (!drawingVisualInk.InkCanvas.visuals.Contains(drawMethod.pixelVisual))
                            drawingVisualInk.InkCanvas.AddVisual(drawMethod.pixelVisual);
                        WriteableBitmap writeableBitmap = image.Source as WriteableBitmap;
                        Point topLeftCorner = e.GetPosition(image);
                        try
                        {
                            if (topLeftCorner.Y < image.ActualHeight - 130)
                            {
                                if (topLeftCorner.X < image.ActualWidth - 120)
                                {
                                    drawMethod.DrawPixelSquare(writeableBitmap, drawMethod.pixelVisual, topLeftCorner, image.ActualWidth, image.ActualHeight);
                                }
                                else
                                {
                                    drawMethod.DrawPixelSquareLeft(writeableBitmap, drawMethod.pixelVisual, topLeftCorner, image.ActualWidth, image.ActualHeight);
                                }

                            }
                            else if (topLeftCorner.Y >= image.ActualHeight - 130)
                            {
                                if (topLeftCorner.X < image.ActualWidth - 120)
                                {

                                    drawMethod.DrawPixelSquareUp(writeableBitmap, drawMethod.pixelVisual, topLeftCorner, image.ActualWidth, image.ActualHeight);

                                }
                                else
                                {
                                    drawMethod.DrawPixelSquareLeftUp(writeableBitmap, drawMethod.pixelVisual, topLeftCorner, image.ActualWidth, image.ActualHeight);
                                }

                            }

                        }
                        catch (Exception ex)
                        {

                        }

                        drawingVisualInk.ReleaseMouseCapture();
                       // drawingCanvasInk[0] = drawingVisualInk;
                    }


                };

                drawingVisualInk.InkCanvas.MouseLeave += delegate (object sender, MouseEventArgs e)
                {
                    if (ImageViewState.toolTop.SelectChecked)
                    {
                        if (drawingVisualInk.InkCanvas.visuals.Contains(drawMethod.pixelVisual))
                            drawingVisualInk.InkCanvas.DeleteVisual(drawMethod.pixelVisual);
                    }
                };
                }
            catch (Exception ex)
            {

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

                List<ToggleButton> RightTools2 = new List<ToggleButton>() { QuaterTogg, DualTogg, BFTogg, DFTogg, RITogg, DPTogg, PhiTogg, FLTogg, _3DTogg, CubeTogg, RepoTogg };

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
                //popup.MouseLeave += delegate
                // {
                //     if (popup.IsOpen)
                //     {
                //         popup.IsOpen = false;
                //     };
                // };
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
                        if (drawingCanvasInk[0] != null)
                        {
                            if (drawingCanvasInk[0].InkCanvas.ContextMenu != null)
                            {
                                drawingCanvasInk[0].InkCanvas.ContextMenu = null;
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
                    if (drawingCanvasInk[0] != null)
                    {
                        if (drawingCanvasInk[0].InkCanvas.ContextMenu != null)
                        {
                            drawingCanvasInk[0].InkCanvas.ContextMenu = null;
                        }
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
                    MessageBox.Show(ex.Message);
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
