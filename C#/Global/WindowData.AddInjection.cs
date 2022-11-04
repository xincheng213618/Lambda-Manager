using ConfigBottomView;
using Global.Common.Controls;
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
        public List<ToggleButton> DrawingModeList;

        private void AddInjection()
        {

            ResourceDictionary resourceDictionary = new ResourceDictionary();
            resourceDictionary.Source = new Uri("Global;Component/Themes/buttonIcon.xaml", UriKind.Relative);

            Application.Current.MainWindow.Closing += delegate   // app closing close the lightBoard
            {
                LambdaControl.Trigger("IMAGE_MODE_CLOSE", this, new Dictionary<string, object>() { });
            };

            if (Application.Current.MainWindow.FindName("grid0") is not Grid) return;

            try
            {
                TabControl tabControl = (TabControl)mainwin.FindName("leftTab");    //采集配置 改为 采集设置
                TabItem tabItem = (TabItem) tabControl.Items[1];
                tabItem.Header = "采集设置";
            }
            catch
            {

            }






            try
            {   
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
                Image HistogramImage = histogram.histogramImage;
                LambdaControl.RegisterImageView(HistogramImage).ToString();


                //Profile profile = new Profile();   //profile
                profile.Height = Double.NaN;
                profile.Visibility = Visibility.Collapsed;
                profile.VerticalAlignment = VerticalAlignment.Stretch;
                profile.Margin = new Thickness(30, 0, 0, 0);
                stackPanel.Orientation = Orientation.Horizontal;
                profile.WrapPanel1.DataContext = profileModel;
                //profile.DataContext = profileModel;
                //Image ProfileImage = profile.profileImage;
                //LambdaControl.RegisterImageView(ProfileImage).ToString();

                profile.la.MouseMove += delegate
                 {
                     profileModel.Ratio1 = profile.la.X / profile.DataPoints.Count;
                     if (inkVisuals[0] != null && inkVisuals[0].inkCanvas.Strokes.Contains(inkVisuals[0].profileStroke))
                         inkVisuals[0].DrawProfile();
                 };
                profile.lb.MouseMove += delegate
                {
                    profileModel.Ratio2 = profile.lb.X / profile.DataPoints.Count;
                    if (inkVisuals[0] != null && inkVisuals[0].inkCanvas.Strokes.Contains(inkVisuals[0].profileStroke))
                        inkVisuals[0].DrawProfile();
                };
                profileModel.PropertyChanged += (s, e) =>
                {
                   
                    if (e.PropertyName == "Marker1Show"|| e.PropertyName == "Marker2Show")
                    {
                        if (inkVisuals[0] != null && inkVisuals[0].inkCanvas.Strokes.Contains(inkVisuals[0].profileStroke))
                            inkVisuals[0].DrawProfile();
                    }
                   
                };
               
            
                stackPanel.Children.Add(profile);

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
                int tempSelectedIndex = 0;

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

                    if (e.PropertyName == "RulerChecked"  || e.PropertyName == "CircleChecked"|| e.PropertyName == "CurveChecked"|| e.PropertyName== "LineChecked" || e.PropertyName == "PolygonChecked"|| e.PropertyName == "RectangleChecked"|| e.PropertyName=="TextChecked" || e.PropertyName == "EraserChecked")
                    {
                        if (ImageViewState.toolTop.RulerChecked  || ImageViewState.toolTop.CircleChecked || ImageViewState.toolTop.CurveChecked || ImageViewState.toolTop.LineChecked || ImageViewState.toolTop.PolygonChecked || ImageViewState.toolTop.RectangleChecked || ImageViewState.toolTop.TextChecked )
                        {
                            
                            propertySetItem.Visibility = Visibility.Visible;
                            propertySetItem.DataContext = DrawInkMethod.dimenViewModel;
                            if (tabControl.SelectedIndex != 5)
                                tempSelectedIndex = tabControl.SelectedIndex; ;
                            tabControl.SelectedIndex = 5;
                            DrawInkMethod.dimenViewModel.DimShapeCombo = false;
                            if (ImageViewState.toolTop.LineChecked)
                            {
                                DrawInkMethod.dimenViewModel.DimShapeCombo = true;
                            };
                        }
                        else
                        {
                            if (ImageViewState.toolTop.DimensionChecked == true || ImageViewState.toolTop.EraserChecked)
                            {
                                propertySetItem.Visibility = Visibility.Visible;
                                if (tabControl.SelectedIndex != 5)
                                    tempSelectedIndex = tabControl.SelectedIndex; 
                                tabControl.SelectedIndex = 5;
                                DrawInkMethod.defdimenViewModel.DimShapeCombo = false;
                                propertySetItem.DataContext = DrawInkMethod.defdimenViewModel;
                                DrawInkMethod.defdimenViewModel.DimPosShow = true;
                                DrawInkMethod.defdimenViewModel.DimSelectedIndex = 2;

                            }
                            else
                            {
                                if (inkVisuals[0].inkCanvas.EditingMode == InkCanvasEditingMode.Select)
                                    return;
                                propertySetItem.Visibility = Visibility.Collapsed;
                                tabControl.SelectedIndex = tempSelectedIndex;
                            };

                        }
                        

                    };
                   
                    if (e.PropertyName == "DimensionChecked")
                    {
                        if (ImageViewState.toolTop.DimensionChecked == true )
                        {
                            propertySetItem.Visibility = Visibility.Visible;
                            if (tabControl.SelectedIndex != 5)
                                tempSelectedIndex = tabControl.SelectedIndex; 
                            tabControl.SelectedIndex = 5;
                            DrawInkMethod.defdimenViewModel.DimShapeCombo = false;
                            propertySetItem.DataContext = DrawInkMethod.defdimenViewModel;
                            DrawInkMethod.defdimenViewModel.DimSelectedIndex = 2;
                            DrawInkMethod.defdimenViewModel.DimPosShow = true;
                            DrawInkMethod.defdimenViewModel.LabelPosShow = false;

                        }
                        else if (ImageViewState.toolTop.DimensionChecked == false && ImageViewState.toolTop.EraserChecked == false)
                        {
                            propertySetItem.Visibility = Visibility.Collapsed;
                            tabControl.SelectedIndex = tempSelectedIndex;
                            DrawInkMethod.defdimenViewModel.DimSelectedIndex = 0;
                            DrawInkMethod.defdimenViewModel.DimPosShow = false;
                        };
                        if(ImageViewState.toolTop.RulerChecked || ImageViewState.toolTop.CircleChecked || ImageViewState.toolTop.CurveChecked || ImageViewState.toolTop.LineChecked || ImageViewState.toolTop.PolygonChecked || ImageViewState.toolTop.RectangleChecked || ImageViewState.toolTop.TextChecked )
                        {
                            propertySetItem.Visibility = Visibility.Visible;
                            propertySetItem.DataContext = DrawInkMethod.dimenViewModel;
                            if (tabControl.SelectedIndex != 5)
                                tempSelectedIndex = tabControl.SelectedIndex;
                            tabControl.SelectedIndex = 5;
                            DrawInkMethod.dimenViewModel.DimShapeCombo = false;
                            if (ImageViewState.toolTop.LineChecked)
                            {
                                DrawInkMethod.dimenViewModel.DimShapeCombo = true;
                                DrawInkMethod.dimenViewModel.DimSelectedIndex=0;

                            };
                          
                        }
                    }
                    

                };
              
                }
            catch (Exception ex)
            {
                LambdaControl.Log(new Message() { Severity = Severity.ERROR, Text = ex.Message });
            }

           
            // right toolBar
            try
            {             
                WrapPanel WrapPanel1 = (WrapPanel)mainwin.FindName("rightToolbar");
                //检测如果找不到rightToolbar 直接退出
                if (WrapPanel1 == null)
                    return;
                WrapPanel1.VerticalAlignment = VerticalAlignment.Top;
                ToggleButton QuaterTogg = (ToggleButton)WrapPanel1.Children[0];
                ToggleButton DualTogg =   (ToggleButton)WrapPanel1.Children[1];
                ToggleButton BFTogg =     (ToggleButton)WrapPanel1.Children[2];
                ToggleButton DFTogg =     (ToggleButton)WrapPanel1.Children[3];
                ToggleButton RITogg =     (ToggleButton)WrapPanel1.Children[4];
                ToggleButton DPTogg =     (ToggleButton)WrapPanel1.Children[5];
                ToggleButton QpiTogg =    (ToggleButton)WrapPanel1.Children[6];
                ToggleButton PCTogg =     (ToggleButton)WrapPanel1.Children[7];
                ToggleButton _3DTogg =    (ToggleButton)WrapPanel1.Children[8];
                ToggleButton CubeTogg =   (ToggleButton)WrapPanel1.Children[9];
                ToggleButton RepoTogg =   (ToggleButton)WrapPanel1.Children[10];
                // add margin
                QuaterTogg.Margin = new Thickness(0, 2, 0, 2);
                DualTogg.Margin=new Thickness(0, 2, 0, 2);
                BFTogg.Margin= new Thickness(0, 2, 0, 2);
                DFTogg.Margin = new Thickness(0, 2, 0, 2);
                RITogg.Margin = new Thickness(0, 2, 0, 2);
                DPTogg.Margin = new Thickness(0, 2, 0, 2);
                QpiTogg.Margin = new Thickness(0, 2, 0, 2);
                PCTogg.Margin = new Thickness(0, 2, 0, 2);
                _3DTogg.Margin = new Thickness(0, 2, 0, 2);
                CubeTogg.Margin = new Thickness(0, 2, 0, 2);
                RepoTogg.Margin = new Thickness(0, 2, 0, 2);

                QuaterTogg.Padding = new Thickness(-1, -1, 0, 0);
                DualTogg.Padding = new Thickness(-1, -1, 0, 0);
                BFTogg.Padding = new Thickness(-1, -1, 0, 0);
                DFTogg.Padding = new Thickness(-1, -1, 0, 0);
                RITogg.Padding = new Thickness(-1, -1, 0, 0);
                DPTogg.Padding = new Thickness(-1, -1, 0, 0);
                QpiTogg.Padding = new Thickness(-1, -1, 0, 0);
                PCTogg.Padding = new Thickness(-1, -1, 0, 0);
                _3DTogg.Padding = new Thickness(-1, -1, 0, 0);
                CubeTogg.Padding = new Thickness(-1, -1, 0, 0);
                RepoTogg.Padding = new Thickness(-1, -1, 0, 0);


                Binding b1 = new Binding("BFToggEnable");
                BindingOperations.SetBinding(BFTogg, ToggleButton.IsEnabledProperty, b1);
                Binding b2 = new Binding("DFToggEnable");
                BindingOperations.SetBinding(DFTogg, ToggleButton.IsEnabledProperty, b2);
                Binding b3 = new Binding("RIToggEnable");
                BindingOperations.SetBinding(RITogg, ToggleButton.IsEnabledProperty, b3);
                Binding b4 = new Binding("DPToggEnable");
                BindingOperations.SetBinding(DPTogg, ToggleButton.IsEnabledProperty, b4);
                Binding b5 = new Binding("QPToggEnable");
                BindingOperations.SetBinding(QpiTogg, ToggleButton.IsEnabledProperty, b5);
                Binding b6 = new Binding("PCToggEnable");
                BindingOperations.SetBinding(PCTogg, ToggleButton.IsEnabledProperty, b6);
                // ischecked 
                Binding b11 = new Binding("BFCheckEnable");
                BindingOperations.SetBinding(BFTogg, ToggleButton.IsCheckedProperty, b11);
                Binding b21 = new Binding("DFCheckEnable");
                BindingOperations.SetBinding(DFTogg, ToggleButton.IsCheckedProperty, b21);
                Binding b31 = new Binding("RICheckEnable");
                BindingOperations.SetBinding(RITogg, ToggleButton.IsCheckedProperty, b31);
                Binding b41 = new Binding("DPCheckEnable");
                BindingOperations.SetBinding(DPTogg, ToggleButton.IsCheckedProperty, b41);
                Binding b51 = new Binding("QPCheckEnable");
                BindingOperations.SetBinding(QpiTogg, ToggleButton.IsCheckedProperty, b51);
                Binding b61 = new Binding("PCCheckEnable");
                BindingOperations.SetBinding(PCTogg, ToggleButton.IsCheckedProperty, b61);
                WrapPanel1.DataContext = updateStatus;

                ContentControl quarter = new ContentControl();
                quarter.Template = (ControlTemplate)resourceDictionary["quarter"];
                QuaterTogg.Content = quarter;

                ContentControl dual = new ContentControl();
                dual.Template = (ControlTemplate)resourceDictionary["dual"];
                DualTogg.Content = dual;
                //ContentControl dual = new ContentControl();
                //dual.Template = (ControlTemplate)resourceDictionary["dual"];
                //DualTogg.Content = dual;
                ContentControl BF = new ContentControl();
                BF.Template = (ControlTemplate)resourceDictionary["BF"];
                BFTogg.Content = BF;
                ContentControl DF = new ContentControl();
                DF.Template = (ControlTemplate)resourceDictionary["DF"];
                DFTogg.Content = DF;
                ContentControl RI = new ContentControl();
                RI.Template = (ControlTemplate)resourceDictionary["RI"];
                RITogg.Content = RI;
                ContentControl DP = new ContentControl();
                DP.Template = (ControlTemplate)resourceDictionary["DP"];
                DPTogg.Content = DP;
                ContentControl PHI = new ContentControl();
                PHI.Template = (ControlTemplate)resourceDictionary["PHI"];
                QpiTogg.Content = PHI;
                ContentControl FL = new ContentControl();
                FL.Template = (ControlTemplate)resourceDictionary["FL"];
                PCTogg.Content = FL;

                 ContentControl _3D = new ContentControl();
                _3D.Template = (ControlTemplate)resourceDictionary["3D"];
                _3DTogg.Content= _3D;
                ContentControl cube = new ContentControl();
                cube.Template = (ControlTemplate)resourceDictionary["cube"];
                CubeTogg.Content = cube;

                ContentControl repo = new ContentControl();
                repo.Template = (ControlTemplate)resourceDictionary["repo"];
                RepoTogg.Content = repo;






                List<ToggleButton> RightTools2 = new List<ToggleButton>() {  BFTogg, DFTogg, RITogg, DPTogg, QpiTogg, PCTogg, _3DTogg, CubeTogg, RepoTogg };

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
                popup.AllowsTransparency = true;
                popup.PopupAnimation = PopupAnimation.Slide;
                Binding binding8 = new Binding();
                popup.PlacementTarget = QuaterTogg;
               // Point point = Mouse.GetPosition(QuaterTogg);
                popup.HorizontalOffset =-86;              
                popup.VerticalOffset = -25;
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

                                ContextMenu contextMenu = new ContextMenu();
                                MenuItem menuItem = new MenuItem() { Header = "导出BMP..." };
                                menuItem.Click += delegate
                                {

                                    WindowData.ExportAs("bmp");
                                };
                                contextMenu.Items.Add(menuItem);
                                inkVisuals[0].inkCanvas.ContextMenu = contextMenu;
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
                           // inkVisuals[0].inkCanvas.ContextMenu = null;
                        }
                    }
                };
                // fontsize change 
                TextBlock sliceIndex = (TextBlock)mainwin.FindName("sliceIndex");
                TextBlock totalSlice = (TextBlock)mainwin.FindName("totalSlice");
                TextBlock zTop = (TextBlock)mainwin.FindName("zTop");
                TextBlock zCurrent = (TextBlock)mainwin.FindName("zCurrent");
                TextBlock zBottom = (TextBlock)mainwin.FindName("zBottom");
                sliceIndex.FontSize = 10;
                totalSlice.FontSize = 10;
                zTop.FontSize = 10;
                zCurrent.FontSize = 10;
                zBottom.FontSize = 10;


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

            // leftToolbar  ColorBar ADD
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
                ToggleButton monoTogg = (ToggleButton)leftToolBarChild.Children[1];
                ToggleButton divtogg = (ToggleButton)leftToolBarChild.Children[2];
                ToggleButton histogg = (ToggleButton)leftToolBarChild.Children[3];
                ToggleButton rangetogg = (ToggleButton)leftToolBarChild.Children[4];
                colorbarTogg.Margin = new Thickness(1, 2, 0, 2);
                monoTogg.Margin = new Thickness(1, 2, 0, 2);
                divtogg.Margin = new Thickness(1, 2, 0, 2);
                histogg.Margin = new Thickness(1, 2, 0, 2);
                rangetogg.Margin = new Thickness(1, 2, 0, 2);
                colorbarTogg.Padding = new Thickness(-1, -1, 0, 0);
                monoTogg.Padding = new Thickness(-1, -1, 0, 0);
                divtogg.Padding = new Thickness(-1, -1, 0, 0);
                histogg.Padding = new Thickness(-1, -1, 0, 0);
                rangetogg.Padding = new Thickness(-1, -1, 0, 0);

                ContentControl colorBar = new ContentControl();
                colorBar.Template = (ControlTemplate)resourceDictionary["colorbar"];
                colorbarTogg.Content = colorBar;

                ContentControl mono = new ContentControl();
                mono.Template = (ControlTemplate)resourceDictionary["monocolor"];
                monoTogg.Content = mono;
                ContentControl div = new ContentControl();
                div.Template = (ControlTemplate)resourceDictionary["div"];
                divtogg.Content = div;
                ContentControl histogram = new ContentControl();
                histogram.Template = (ControlTemplate)resourceDictionary["histogram"];
                histogg.Content = histogram;




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

                

                Button startButton =(Button) bottomToolbar.Children[0];
                Binding startEnable = new Binding("StartEnable");
                startEnable.Source = updateStatus;
                startButton.SetBinding(Button.IsEnabledProperty, startEnable);

                Button stopButton = (Button)bottomToolbar.Children[1];
                Binding stopEnable = new Binding("StopEnable");
                stopEnable.Source = updateStatus;
                stopButton.SetBinding(Button.IsEnabledProperty, stopEnable);

                Button forwardButton = (Button)bottomToolbar.Children[2];
                Binding forwardEnbale = new Binding("ForwardEnbale");
                forwardEnbale.Source = updateStatus;
                forwardButton.SetBinding(Button.IsEnabledProperty, forwardEnbale);

                Button backwardButton = (Button)bottomToolbar.Children[3];
                Binding backwardEnbale = new Binding("BackwardEnbale");
                backwardEnbale.Source = updateStatus;
                backwardButton.SetBinding(Button.IsEnabledProperty, backwardEnbale);



                Slider Slider1 = (Slider)bottomToolbar.Children[6];

                StackPanel StackPanel = (StackPanel)bottomToolbar.Children[7];
                TextBlock textBlock = (TextBlock) StackPanel.Children[0];
                textBlock.Text = "Batch";
               
                Brush brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#6EA646"));
               
                bottomToolbar.Children.Remove(Slider1); 
                ProgressBar1 progressBar1 = new ProgressBar1();
                progressBar1.Margin = new Thickness(0, 0, -20, 0);
                progressBar1.DataContext = progressBarModel;

                bottomToolbar.Children.Insert(6, progressBar1);

                Binding myBindingFrameIndex = new Binding("FrameIndex");
                myBindingFrameIndex.Source = updateStatus;
                myBindingFrameIndex.Mode = BindingMode.TwoWay;

                Binding myBindingTotalFrame = new Binding("TotalFrame");
                myBindingTotalFrame.Source = updateStatus;
                myBindingTotalFrame.Mode = BindingMode.TwoWay;

              

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


                TextBox fpsState = (TextBox)mainwin.FindName("fpsState");
                Binding fpsEnable = new Binding("FpsEnable");
                fpsEnable.Source = updateStatus;
                fpsEnable.Converter = new BooleanToVisibilityConverter1();
                fpsState.SetBinding(TextBox.VisibilityProperty, fpsEnable);
                //fpsState.Text = "100";


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

              
                Slider SliderZ = (Slider)rightToolbar.Children[13];

                int beforeZ = 0;
             
                rightToolbar.Children.Remove(SliderZ);
              

                ProgressBarV progressBarV = new ProgressBarV();
                progressBarV.DataContext = progressBarModel;
                rightToolbar.Children.Insert(13, progressBarV);
                progressBarV.Margin = new Thickness(0, -15, 0, -10);




            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);

            }
            try
            {

                tabControl = (TabControl)mainwin.FindName("leftTab");
                Border border = (Border)tabControl.Parent;
                border.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#444444"));
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
               // dimenPreoperty.DataContext = DrawInkMethod.dimenViewModel;
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


            try
            {
               
   
                WrapPanel topToolbar = (WrapPanel)mainwin.FindName("topToolbar");
                topToolbar.DataContext = ImageViewState.toolTop;


                Binding binding0 = new Binding("SelectChecked");
                ToggleButton ToggleButtonSelect = ((ToggleButton)topToolbar.Children[0]);
                ToggleButtonSelect.SetBinding(ToggleButton.IsCheckedProperty, binding0);
                ToggleButtonSelect.Margin = new Thickness(2, 0, 2, 0);
                ToggleButtonSelect.Padding = new Thickness(-1, -1, 0, 0);
                ContentControl select = new ContentControl();
                select.Template = (ControlTemplate)resourceDictionary["select"];
                ToggleButtonSelect.Content = select;


                Binding binding1 = new Binding("InlineChecked");
                ToggleButton ToggleButtonInline = ((ToggleButton)topToolbar.Children[1]);
                ToggleButtonInline.SetBinding(ToggleButton.IsCheckedProperty, binding1);
                ToggleButtonInline.Margin = new Thickness(2, 0, 2, 0);

                ToggleButtonInline.Padding = new Thickness(-1, -1, 0, 0);
                ContentControl inCline = new ContentControl();
                inCline.Template = (ControlTemplate)resourceDictionary["inCline"];
                ToggleButtonInline.Content = inCline;



                Binding binding2 = new Binding("MoveChecked");
                ToggleButton ToggleButtonMove = ((ToggleButton)topToolbar.Children[2]);
                ToggleButtonMove.SetBinding(ToggleButton.IsCheckedProperty, binding2);
                ToggleButtonMove.Margin = new Thickness(2, 0, 2, 0);
                ToggleButtonMove.Padding = new Thickness(-1, -1, 0, 0);
                ContentControl move = new ContentControl();
                move.Template = (ControlTemplate)resourceDictionary["move"];
                ToggleButtonMove.Content = move;

                //ToggleButtonMove.IsChecked = true;
                //ImageViewState.toolTop.MoveChecked = true;

                // Binding binding3 = new Binding("SearchChecked");
                Button ToggleButtonSearch = ((Button)topToolbar.Children[3]);
                // ToggleButtonSearch.SetBinding(Button.IsCheckedProperty, binding3);
                ToggleButtonSearch.Margin = new Thickness(2, 0, 2, 0);
                ToggleButtonSearch.Padding = new Thickness(-1, -1, 0, 0);
                ContentControl search = new ContentControl();
                search.Template = (ControlTemplate)resourceDictionary["serach"];
                ToggleButtonSearch.Content = search;
               



                //ToggleButtonSearch.Click += delegate
                //{
                //    updateStatus.Ratio++;
                //};

                Binding binding4 = new Binding("ZoomOutChecked");
                ToggleButton ToggleButtonZoomOut = ((ToggleButton)topToolbar.Children[4]);
                ToggleButtonZoomOut.SetBinding(ToggleButton.IsCheckedProperty, binding4);
                ToggleButtonZoomOut.Margin = new Thickness(2, 0, 2, 0);
                ToggleButtonZoomOut.Padding = new Thickness(-1, -1, 0, 0);
                ContentControl ZomOut = new ContentControl();
                ZomOut.Template = (ControlTemplate)resourceDictionary["zoomOut"];
                ToggleButtonZoomOut.Content = ZomOut;

                Binding binding5 = new Binding("ZoomInChecked");
                ToggleButton ToggleButtonZoomIn = ((ToggleButton)topToolbar.Children[5]);
                ToggleButtonZoomIn.SetBinding(ToggleButton.IsCheckedProperty, binding5);
                ToggleButtonZoomIn.Margin = new Thickness(2, 0, 2, 0);
                ToggleButtonZoomIn.Padding = new Thickness(-1, -1, 0, 0);
                ContentControl zoomIn = new ContentControl();
                zoomIn.Template = (ControlTemplate)resourceDictionary["zoomIn"];
                ToggleButtonZoomIn.Content = zoomIn;



                //Binding binding6 = new Binding("ScaleInChecked");
                Button  ToggleButtonScale = ((Button)topToolbar.Children[6]);
                ToggleButtonScale.Margin = new Thickness(2, 0, 4, 0);
                ToggleButtonScale.Padding = new Thickness(-1, -1, 0, 0);
                ContentControl sacle = new ContentControl();
                sacle.Template = (ControlTemplate)resourceDictionary["scale"];
                ToggleButtonScale.Content = sacle;



                //ToggleButtonScale.SetBinding(ToggleButton.IsCheckedProperty, binding6);

                Binding binding9 = new Binding("DimensionChecked");
                ToggleButton ToggleButtonDimen = ((ToggleButton)topToolbar.Children[9]);
                ToggleButtonDimen.SetBinding(ToggleButton.IsCheckedProperty, binding9);
                ToggleButtonDimen.Margin = new Thickness(2, 0, 2, 0);
                ToggleButtonDimen.Padding = new Thickness(-1, -1, 0, 0);
                ContentControl dimension = new ContentControl();
                dimension.Template = (ControlTemplate)resourceDictionary["dimension"];
                ToggleButtonDimen.Content = dimension;




                Binding binding10 = new Binding("FocusChecked");
                ToggleButton ToggleButtonFocus = ((ToggleButton)topToolbar.Children[10]);
                ToggleButtonFocus.SetBinding(ToggleButton.IsCheckedProperty, binding10);
                ToggleButtonFocus.Margin = new Thickness(2, 0, 2, 0);
                ToggleButtonFocus.Padding = new Thickness(-1, -1, 0, 0);
                //ContentControl focus = new ContentControl();
                //focus.Template = (ControlTemplate)resourceDictionary["focus"];

                Grid grid = (Grid)resourceDictionary["grid1111"];
                grid.SetBinding(Grid.BackgroundProperty, new Binding() { Source = ToggleButtonFocus, Path = new PropertyPath("Background") });
                ToggleButtonFocus.Content = grid;






                Binding binding11 = new Binding("RulerChecked");
                ToggleButton ToggleButtonRuler = ((ToggleButton)topToolbar.Children[11]);
                ToggleButtonRuler.SetBinding(ToggleButton.IsCheckedProperty, binding11);
                ToggleButtonRuler.Margin = new Thickness(2, 0, 2, 0);
                ToggleButtonRuler.Padding = new Thickness(-1, -1, 0, 0);
                ContentControl ruler = new ContentControl();
                ruler.Template = (ControlTemplate)resourceDictionary["ruler"];
                ToggleButtonRuler.Content = ruler;




                ToggleButton ToggleButtonProfile = ((ToggleButton)topToolbar.Children[12]);
                ToggleButtonProfile.SetBinding(ToggleButton.IsCheckedProperty, new Binding("ProfileChecked"));
                ToggleButtonProfile.Margin = new Thickness(2, 0, 2, 0);
                ToggleButtonProfile.Padding = new Thickness(-1, -1, 0, 0);

                ContentControl profile = new ContentControl();
                profile.Template = (ControlTemplate)resourceDictionary["profile"];
                ToggleButtonProfile.Content = profile;



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
                ToggleButtonEraser.Margin = new Thickness(2,0,2,0);

                ToggleButtonEraser.Padding = new Thickness(-1, -1, 0, 0);
                ContentControl eraser = new ContentControl();
                eraser.Template = (ControlTemplate)resourceDictionary["eraser"];
                ToggleButtonEraser.Content = eraser;








                ToggleButton ToggleButtonText = ((ToggleButton)topToolbar.Children[15]);
                ToggleButtonText.SetBinding(ToggleButton.IsCheckedProperty, new Binding("TextChecked"));
                ToggleButtonText.Margin = new Thickness(2, 0, 2, 0);
                ToggleButtonText.Padding = new Thickness(-1,-1,0, 0);
                 ContentControl text = new ContentControl();
                text.Template = (ControlTemplate)resourceDictionary["text"];
                ToggleButtonText.Content = text;



                ToggleButton ToggleButtonArrow = ((ToggleButton)topToolbar.Children[16]);
                ToggleButtonArrow.SetBinding(ToggleButton.IsCheckedProperty, new Binding("ArrowChecked"));
                ToggleButtonArrow.Visibility = Visibility.Collapsed; //     delete Arrow
                ToggleButton ToggleButtonLine = ((ToggleButton)topToolbar.Children[17]);
                ToggleButtonLine.SetBinding(ToggleButton.IsCheckedProperty, new Binding("LineChecked"));
                ToggleButtonLine.Margin = new Thickness(2,0,2,0);

                ToggleButtonLine.Padding = new Thickness(-1,-1,0,0);
                ContentControl line = new ContentControl();
                line.Template = (ControlTemplate)resourceDictionary["line"];
                ToggleButtonLine.Content = line;


                ToggleButton ToggleButtonCurve = ((ToggleButton)topToolbar.Children[18]);
                ToggleButtonCurve.SetBinding(ToggleButton.IsCheckedProperty, new Binding("CurveChecked"));
                ToggleButtonCurve.Margin = new Thickness(2, 0, 2, 0);
                ToggleButtonCurve.Padding = new Thickness(-1,-1,0, 0);
                ContentControl curve = new ContentControl();
                curve.Template = (ControlTemplate)resourceDictionary["curve"];
                ToggleButtonCurve.Content = curve;






                ToggleButton ToggleButtonCircle = ((ToggleButton)topToolbar.Children[19]);
                ToggleButtonCircle.SetBinding(ToggleButton.IsCheckedProperty, new Binding("CircleChecked"));
                ToggleButtonCircle.Margin = new Thickness(2, 0, 2, 0);
                ToggleButtonCircle.Padding = new Thickness(-1,-1,0, 0);
                ContentControl circle = new ContentControl();
                circle.Template = (ControlTemplate)resourceDictionary["circle"];
                ToggleButtonCircle.Content = circle;

                ToggleButton ToggleButtonRectangle = ((ToggleButton)topToolbar.Children[20]);
                ToggleButtonRectangle.SetBinding(ToggleButton.IsCheckedProperty, new Binding("RectangleChecked"));


                ToggleButtonRectangle.Margin = new Thickness(2, 0, 2, 0);
                ToggleButtonRectangle.Padding = new Thickness(-1, -1, 0, 0);
                ContentControl rectangle = new ContentControl();
                rectangle.Template = (ControlTemplate)resourceDictionary["rectangle"];
                ToggleButtonRectangle.Content = rectangle;



                ToggleButton ToggleButtonPolygon = ((ToggleButton)topToolbar.Children[21]);
                ToggleButtonPolygon.SetBinding(ToggleButton.IsCheckedProperty, new Binding("PolygonChecked"));
                ToggleButtonPolygon.Margin = new Thickness(2, 0, 2, 0);
                ToggleButtonPolygon.Padding = new Thickness(-1, -1, 0, 0);
                ContentControl polygon = new ContentControl();
                polygon.Template = (ControlTemplate)resourceDictionary["polygon"];
                ToggleButtonPolygon.Content = polygon;

                List<ToggleButton> Tools = new List<ToggleButton>() { ToggleButtonSelect, ToggleButtonInline, ToggleButtonMove, ToggleButtonZoomOut, ToggleButtonZoomIn, ToggleButtonFocus, ToggleButtonRuler,ToggleButtonProfile, ToggleButtonEraser, ToggleButtonText, ToggleButtonArrow, ToggleButtonLine, ToggleButtonCurve, ToggleButtonCircle, ToggleButtonRectangle, ToggleButtonPolygon };
                DrawingModeList = new List<ToggleButton>() {   ToggleButtonRuler, ToggleButtonProfile, ToggleButtonEraser, ToggleButtonText, ToggleButtonLine, ToggleButtonCurve, ToggleButtonCircle, ToggleButtonRectangle, ToggleButtonPolygon };


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



        }


    }
}
