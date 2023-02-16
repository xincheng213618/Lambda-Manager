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
using ThemeManager;
using GalleryView;
using Lambda.UI.Extension;
using System.Windows.Threading;
using System.Threading.Tasks;

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
    public partial class WindowData1
    {
        public TabItem propertySetItem;
        public TabControl tabControl;
        private ToggleButton histogramTogg;
        public List<ToggleButton> DrawingModeList;
        public Gallery galleryView;
        GalleryView.GalleryTool galleryTool;
        public static ToggleButton RepoTogg = new ToggleButton();
        Histogram histogram;
        public SplitButtonEraser SplitButtonErase = new SplitButtonEraser();
        public SplitButtonSelect SplitButtonSelec = new SplitButtonSelect();
        

       
        public async void MultiEraseEnable()
        {
            await Task.Delay(200);
            ImageViewState.toolTop.EraserChecked = true;
            ImageViewState.toolTop.MultiEraser = true;
        }
        public async void MultiInkSelectEnable()
        {
            await Task.Delay(200);
            ImageViewState.toolTop.InkSelected = true;
            ImageViewState.toolTop.InkMultiSelected = true;
        }
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
                // Add Histogram

                histogram = new Histogram();
                StackPanel stackPanel = (StackPanel)mainwin.FindName("bottomView");
                Grid grid1 = (Grid)stackPanel.Parent;
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

                    if (e.PropertyName == "Marker1Show" || e.PropertyName == "Marker2Show")
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
                histogramTogg = (ToggleButton)leftToolBarChild.Children[3];

                histogramTogg.Checked += delegate
                {
                    RepoTogg.IsChecked = false;
                    grid1.RowDefinitions[2].Height = new GridLength(180, GridUnitType.Pixel);
                    histogram.Visibility = Visibility.Visible;
                };
                histogramTogg.Unchecked += delegate
                {
                    histogram.Visibility = Visibility.Collapsed;
                    if (profile.Visibility == Visibility.Collapsed && galleryView.Visibility == Visibility.Collapsed)
                    {
                        grid1.RowDefinitions[2].Height = new GridLength(0, GridUnitType.Pixel);
                    }


                };

                int tempSelectedIndex = 0;
                //拉线剖析

                ImageViewState.toolTop.PropertyChanged += delegate (object? sender, PropertyChangedEventArgs e)
                {
                    if (e.PropertyName == "ProfileChecked")
                    {
                        if (ImageViewState.toolTop.ProfileChecked)
                        {
                            RepoTogg.IsChecked = false;
                            grid1.RowDefinitions[2].Height = new GridLength(180, GridUnitType.Pixel);
                            profile.Visibility = Visibility.Visible;
                        }
                        else
                        {
                            profile.Visibility = Visibility.Collapsed;
                            if (histogram.Visibility == Visibility.Collapsed && galleryView.Visibility == Visibility.Collapsed)
                            {
                                grid1.RowDefinitions[2].Height = new GridLength(0, GridUnitType.Pixel);
                            }
                        }

                    };

                    if (e.PropertyName == "RulerChecked" || e.PropertyName == "CircleChecked" || e.PropertyName == "CurveChecked" || e.PropertyName == "LineChecked" || e.PropertyName == "PolygonChecked" || e.PropertyName == "RectangleChecked" || e.PropertyName == "TextChecked" || e.PropertyName == "EraserChecked" || e.PropertyName == "InkSelected" || e.PropertyName == "InkAllSelected")
                    {
                        if (ImageViewState.toolTop.RulerChecked || ImageViewState.toolTop.CircleChecked || ImageViewState.toolTop.CurveChecked || ImageViewState.toolTop.LineChecked || ImageViewState.toolTop.PolygonChecked || ImageViewState.toolTop.RectangleChecked || ImageViewState.toolTop.TextChecked || ImageViewState.toolTop.InkSelected || ImageViewState.toolTop.InkAllSelected)
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
                        if (ImageViewState.toolTop.DimensionChecked == true)
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
                        if (ImageViewState.toolTop.RulerChecked || ImageViewState.toolTop.CircleChecked || ImageViewState.toolTop.CurveChecked || ImageViewState.toolTop.LineChecked || ImageViewState.toolTop.PolygonChecked || ImageViewState.toolTop.RectangleChecked || ImageViewState.toolTop.TextChecked)
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
                                DrawInkMethod.dimenViewModel.DimSelectedIndex = 0;

                            };

                        }
                    }


                };

            }
            catch (Exception ex)
            {
                LambdaControl.Log(new Message() { Severity = Severity.ERROR, Text = ex.Message });
            }


            // 右侧工具栏
            try
            {
                Border imagingView = (Border)mainwin.FindName("imagingView");
                StackPanel stackPanel = (StackPanel)mainwin.FindName("bottomView");
                Grid stackPanelParent = (Grid)stackPanel.Parent;
                WrapPanel WrapPanel1 = (WrapPanel)mainwin.FindName("rightToolbar");
                //检测如果找不到rightToolbar 直接退出
                if (WrapPanel1 == null)
                    return;
                WrapPanel1.VerticalAlignment = VerticalAlignment.Top;
                ToggleButton QuaterTogg = (ToggleButton)WrapPanel1.Children[0];
                ToggleButton DualTogg = (ToggleButton)WrapPanel1.Children[1];
                ToggleButton BFTogg = (ToggleButton)WrapPanel1.Children[2];
                ToggleButton DFTogg = (ToggleButton)WrapPanel1.Children[3];
                ToggleButton RITogg = (ToggleButton)WrapPanel1.Children[4];
                ToggleButton DPTogg = (ToggleButton)WrapPanel1.Children[5];
                ToggleButton QpiTogg = (ToggleButton)WrapPanel1.Children[6];
                ToggleButton PCTogg = (ToggleButton)WrapPanel1.Children[7];
                ToggleButton _3DTogg = (ToggleButton)WrapPanel1.Children[8];
                ToggleButton CubeTogg = (ToggleButton)WrapPanel1.Children[9];

                RepoTogg = (ToggleButton)WrapPanel1.Children[10];
                TextBlock textBlock = (TextBlock)WrapPanel1.Children[11];
                textBlock.Text = "切片";
                textBlock.TextAlignment = TextAlignment.Center;
                // add margin
                QuaterTogg.Margin = new Thickness(0, 3, 0, 3);
                DualTogg.Margin = new Thickness(0, 3, 0, 3);
                BFTogg.Margin = new Thickness(0, 3, 0, 3);
                DFTogg.Margin = new Thickness(0, 3, 0, 3);
                RITogg.Margin = new Thickness(0, 3, 0, 3);
                DPTogg.Margin = new Thickness(0, 3, 0, 3);
                QpiTogg.Margin = new Thickness(0, 3, 0, 3);
                PCTogg.Margin = new Thickness(0, 3, 0, 3);
                _3DTogg.Margin = new Thickness(0, 3, 0, 3);
                CubeTogg.Margin = new Thickness(0, 3, 0, 3);
                RepoTogg.Margin = new Thickness(0, 3, 0, 3);

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

                //Binding b7 = new Binding("RepoChecked");
                //BindingOperations.SetBinding(RepoTogg, ToggleButton.IsCheckedProperty, b7);
                //b7.Source = ImageViewState.toolRight;

                // WrapPanel1.DataContext = updateStatus;

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
                PHI.Template = (ControlTemplate)resourceDictionary["QP"];
                QpiTogg.Content = PHI;
                ContentControl FL = new ContentControl();
                FL.Template = (ControlTemplate)resourceDictionary["PC"];
                PCTogg.Content = FL;

                ContentControl _3D = new ContentControl();
                _3D.Template = (ControlTemplate)resourceDictionary["3D"];
                _3DTogg.Content = _3D;
                ContentControl cube = new ContentControl();
                cube.Template = (ControlTemplate)resourceDictionary["cube"];
                CubeTogg.Content = cube;

                WrapPanel1.DataContext = updateStatus;
                ContentControl repo = new ContentControl();
                repo.Template = (ControlTemplate)resourceDictionary["repo"];
                RepoTogg.Content = repo;

              

                List<ToggleButton> RightTools2 = new List<ToggleButton>() { BFTogg, DFTogg, RITogg, DPTogg, QpiTogg, PCTogg, _3DTogg, CubeTogg };

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

              

            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);

            }
            // histogramtogg   //leftToolBar
            try
            {
                DockPanel leftToolBar = (DockPanel)mainwin.FindName("leftToolbar");
               // MessageBox.Show("1111111");
                //DockPanel leftToolBar1 = (DockPanel)VisualHelper.GetChild(mainwin, "leftToolbar");
                //TreeView tree = (TreeView)VisualHelper.GetChild(mainwin, 1);
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
                colorbarTogg.Margin = new Thickness(1, 3, 0, 3);
                monoTogg.Margin = new Thickness(1, 3, 0, 3);
                divtogg.Margin = new Thickness(1, 3, 0, 3);
                histogg.Margin = new Thickness(1, 3, 0, 3);
                rangetogg.Margin = new Thickness(1, 3, 0, 3);
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
                ContentControl histogram1 = new ContentControl();
                histogram1.Template = (ControlTemplate)resourceDictionary["histogram"];
                histogg.Content = histogram1;
                ContentControl range = new ContentControl();
                range.Template = (ControlTemplate)resourceDictionary["range"];
                rangetogg.Content = range;
                histogram.RangeCombo.SelectionChanged += (s, e) =>
                {
                    if (s is ComboBox combo && WindowData.GetInstance().OperatingMode.SelectViewMode == 4)
                    {
                        if ((string)combo.SelectedItem == "-5,5")
                        {
                            colorBarUser.colorBar.Minimum = -5;
                            colorBarUser.colorBar.Maximum = 5;
                        }

                        else if ((string)combo.SelectedItem == "-10,10")
                        {
                            colorBarUser.colorBar.Minimum = -10;
                            colorBarUser.colorBar.Maximum = 10;
                        }
                        else if ((string)combo.SelectedItem == "-20,20")
                        {
                            colorBarUser.colorBar.Minimum = -20;
                            colorBarUser.colorBar.Maximum = 20;
                        }


                    };
                };



                OperatingMode.PropertyChanged += delegate (object? sender, PropertyChangedEventArgs e)
                {
                    if (e.PropertyName == "SelectViewMode")
                    {
                        if (OperatingMode.SelectViewMode == 0 || OperatingMode.SelectViewMode == 1 || OperatingMode.SelectViewMode == 3 || OperatingMode.SelectViewMode == 4)
                        {

                            if (OperatingMode.SelectViewMode == 4)
                            {
                                monoTogg.IsEnabled = true;
                                divtogg.IsEnabled = true;
                                colorbarTogg.IsEnabled = true;
                                colorBarUser.colorBar.SlidThumbVis = Visibility.Visible;
                                colorBarUser.colorBar.Minimum = histogramModel.SliderMinP;
                                colorBarUser.colorBar.Maximum = histogramModel.SliderMaxP;
                                colorBarUser.DataContext = histogramModel;
                            }
                            else
                            {
                                if (monoTogg.IsChecked == true)
                                {
                                    monoTogg.IsChecked = false;
                                    LambdaControl.Trigger("MONO_CLICKED", this, new Dictionary<string, object> {  });
                                };
                                if(divtogg.IsChecked == true)
                                {
                                    divtogg.IsChecked = false;
                                    LambdaControl.Trigger("DIVIDER_CLICKED", this, new Dictionary<string, object> { });
                                }
                                colorbarTogg.IsEnabled = true;
                                monoTogg.IsEnabled = false;
                                divtogg.IsEnabled = false;
                                colorBarUser.colorBar.SlidThumbVis = Visibility.Hidden;
                                colorBarUser.colorBar.Minimum = 0;
                                colorBarUser.colorBar.Maximum = 255;
                                colorBarUser.DataContext = null;
                            }

                        }
                        else
                        {
                            if (monoTogg.IsChecked == true)
                            {
                                monoTogg.IsChecked = false;
                                LambdaControl.Trigger("MONO_CLICKED", this, new Dictionary<string, object> { });
                            };
                            if (divtogg.IsChecked == true)
                            {
                                divtogg.IsChecked = false;
                                LambdaControl.Trigger("DIVIDER_CLICKED", this, new Dictionary<string, object> { });
                            }
                            monoTogg.IsEnabled = false;
                            divtogg.IsEnabled = false;
                            colorbarTogg.IsEnabled = false;
                        }

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
                    if(colorBarUser.Visibility ==Visibility.Hidden)
                    {
                        colorBarUser.Visibility = Visibility.Visible;
                    }

                    colorBarUser.colorBar.SlidThumbVis = Visibility.Hidden;
                };
                monoColorTogg.Unchecked += delegate
                {
                    colorBarUser.colorBar.SlidThumbVis = Visibility.Visible;
                };

            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }

            // 底部工具栏
            try  
            {
                WrapPanel bottomToolbar = (WrapPanel)mainwin.FindName("bottomToolbar");


                Button startButton = (Button)bottomToolbar.Children[0];
                Binding startEnable = new Binding("StartEnable");
                startEnable.Source = updateStatus;
                startButton.SetBinding(Button.IsEnabledProperty, startEnable);
                ContentControl start = new ContentControl();
                start.Template = (ControlTemplate)resourceDictionary["start"];
                startButton.Content = start;
                startButton.Padding = new Thickness(-1.5, -1, 0, 0);
                startButton.Margin = new Thickness(0, 0, 0, 0);
                Button stopButton = (Button)bottomToolbar.Children[1];
                Binding stopEnable = new Binding("StopEnable");
                stopEnable.Source = updateStatus;
                stopButton.SetBinding(Button.IsEnabledProperty, stopEnable);
                ContentControl stop = new ContentControl();
                stop.Template = (ControlTemplate)resourceDictionary["stop"];
                stopButton.Content = stop;
                stopButton.Padding = new Thickness(-1.5, -1, 0, 0);
                stopButton.Margin = new Thickness(0, 0, 0, 0);
                Button forwardButton = (Button)bottomToolbar.Children[2];
                Binding forwardEnbale = new Binding("ForwardEnbale");
                forwardEnbale.Source = updateStatus;
                forwardButton.SetBinding(Button.IsEnabledProperty, forwardEnbale);
                ContentControl forward = new ContentControl();
                forward.Template = (ControlTemplate)resourceDictionary["forward"];
                forwardButton.Content = forward;
                forwardButton.Padding = new Thickness(-1.5, -1, 0, 0);
                forwardButton.Margin = new Thickness(0, 0, 0, 0);

                Button backwardButton = (Button)bottomToolbar.Children[3];
                Binding backwardEnbale = new Binding("BackwardEnbale");
                //backwardEnbale.Converter = new ValueToEnableConverter();
                backwardEnbale.Source = updateStatus;
                backwardButton.SetBinding(Button.IsEnabledProperty, backwardEnbale);


                ContentControl backward = new ContentControl();
                backward.Template = (ControlTemplate)resourceDictionary["backward"];
                backwardButton.Content = backward;
                backwardButton.Padding = new Thickness(-1.5, -1, 0, 0);
                backwardButton.Margin = new Thickness(0, 0, 3, 0);

                TextBlock textBlockFPS = (TextBlock)bottomToolbar.Children[4];
                textBlockFPS.FontFamily = new FontFamily("Arial");

                Slider Slider1 = (Slider)bottomToolbar.Children[6];

                StackPanel StackPanel = (StackPanel)bottomToolbar.Children[7];
                TextBlock textBlock = (TextBlock)StackPanel.Children[0];
                textBlock.Text = "批次";
                textBlock.FontFamily = new FontFamily("Arial");
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
                frameIndex.FontFamily = new FontFamily("Arial");
                frameIndex.DataContext = updateStatus;
                frameIndex.SetBinding(TextBlock.TextProperty, new Binding("FrameIndex"));

                TextBlock totalFrame = (TextBlock)mainwin.FindName("totalFrame");
                totalFrame.FontFamily = new FontFamily("Arial");
                totalFrame.DataContext = updateStatus;
                totalFrame.SetBinding(TextBlock.TextProperty, new Binding("TotalFrame"));

                TextBlock timeElapsed = (TextBlock)mainwin.FindName("timeElapsed");
                timeElapsed.FontFamily = new FontFamily("Arial");
                timeElapsed.DataContext = updateStatus;
                timeElapsed.SetBinding(TextBlock.TextProperty, new Binding("TimeElapsed"));

                TextBlock totalTime = (TextBlock)mainwin.FindName("totalTime");
                totalTime.FontFamily = new FontFamily("Arial");
                Binding TotalTime = new Binding("TotalTime");
                TotalTime.Source = updateStatus;
                totalTime.SetBinding(TextBlock.TextProperty, TotalTime);


                TextBox fpsState = (TextBox)mainwin.FindName("fpsState");
                fpsState.FontFamily = new FontFamily("Arial");
                Binding fpsEnable = new Binding("FpsEnable");
                fpsEnable.Source = updateStatus;
                fpsEnable.Converter = new BooleanToVisibilityConverter1();
                fpsState.SetBinding(TextBox.VisibilityProperty, fpsEnable);
                //fpsState.Text = "100";




                TextBlock zTop = (TextBlock)mainwin.FindName("zTop");
                zTop.FontFamily = new FontFamily("Arial");
                zTop.FontSize = 12;
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
                zCurrent.FontSize = 12;
                zCurrent.FontFamily = new FontFamily("Arial");
                TextBlock zBottom = (TextBlock)mainwin.FindName("zBottom");
                Binding ZBottom = new Binding("ZBottom");
                ZBottom.Source = updateStatus;
                zBottom.SetBinding(TextBlock.TextProperty, ZBottom);
                zBottom.FontSize = 12;

                zBottom.FontFamily = new FontFamily("Arial");

                TextBlock sliceIndex = (TextBlock)mainwin.FindName("sliceIndex");
                sliceIndex.FontSize = 12;
                sliceIndex.FontFamily = new FontFamily("Arial");
                StackPanel stackPanel1 = (StackPanel)sliceIndex.Parent;
                stackPanel1.HorizontalAlignment = HorizontalAlignment.Center;
                Border border1 = (Border)stackPanel1.Parent;
                border1.CornerRadius = new CornerRadius(4);

                Binding SliceIndex = new Binding("SliceIndex");
                SliceIndex.Source = updateStatus;
                sliceIndex.SetBinding(TextBlock.TextProperty, SliceIndex);

                TextBlock totalSlice = (TextBlock)mainwin.FindName("totalSlice");
                totalSlice.FontSize = 12;
                totalSlice.FontFamily = new FontFamily("Arial");
                Binding TotalSlice = new Binding("TotalSlice");
                TotalSlice.Source = updateStatus;

                totalSlice.SetBinding(TextBlock.TextProperty, TotalSlice);

                Button bottomPlace = (Button)bottomToolbar.Children[bottomToolbar.Children.Count - 1];

                ContentControl Place = new ContentControl();
                Place.Template = (ControlTemplate)resourceDictionary["place"];
                bottomPlace.Content = Place;
                bottomPlace.Padding = new Thickness(-1.5, -1, 0, 0);
                bottomPlace.Margin = new Thickness(5, 0, 0, 0);

                WrapPanel rightToolbar = (WrapPanel)mainwin.FindName("rightToolbar");


                Slider SliderZ = (Slider)rightToolbar.Children[13];


                rightToolbar.Children.Remove(SliderZ);


                ProgressBarV progressBarV = new ProgressBarV();
                progressBarV.DataContext = progressBarModel;
                rightToolbar.Children.Insert(13, progressBarV);
                progressBarV.Margin = new Thickness(0, -15, 0, 0);




            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);

            }
            // 属性栏
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
            // 顶部工具栏

            try
            {

                WrapPanel topToolbar = (WrapPanel)mainwin.FindName("topToolbar");
                topToolbar.DataContext = ImageViewState.toolTop;
                Binding binding0 = new Binding("SelectChecked");
                ToggleButton ToggleButtonSelect = ((ToggleButton)topToolbar.Children[0]);
                ToggleButtonSelect.SetBinding(ToggleButton.IsCheckedProperty, binding0);
                ToggleButtonSelect.Margin = new Thickness(3, 0, 3, 0);
                ToggleButtonSelect.Padding = new Thickness(-1, -1, 0, 0);
                ContentControl select = new ContentControl();
                select.Template = (ControlTemplate)resourceDictionary["select"];
                ToggleButtonSelect.Content = select;
                Binding binding1 = new Binding("InlineChecked");
                ToggleButton ToggleButtonInline = ((ToggleButton)topToolbar.Children[1]);
                ToggleButtonInline.SetBinding(ToggleButton.IsCheckedProperty, binding1);
                ToggleButtonInline.Margin = new Thickness(3, 0, 3, 0);

                ToggleButtonInline.Padding = new Thickness(-1, -1, 0, 0);
                ContentControl inCline = new ContentControl();
                inCline.Template = (ControlTemplate)resourceDictionary["inCline"];
                ToggleButtonInline.Content = inCline;
                Binding binding2 = new Binding("MoveChecked");
                ToggleButton ToggleButtonMove = ((ToggleButton)topToolbar.Children[2]);
                ToggleButtonMove.SetBinding(ToggleButton.IsCheckedProperty, binding2);
                ToggleButtonMove.Margin = new Thickness(3, 0, 3, 0);
                ToggleButtonMove.Padding = new Thickness(-1, -1, 0, 0);
                ContentControl move = new ContentControl();
                move.Template = (ControlTemplate)resourceDictionary["move"];
                ToggleButtonMove.Content = move;

                //ToggleButtonMove.IsChecked = true;
                //ImageViewState.toolTop.MoveChecked = true;

                // Binding binding3 = new Binding("SearchChecked");
                Button ToggleButtonSearch = ((Button)topToolbar.Children[3]);
                // ToggleButtonSearch.SetBinding(Button.IsCheckedProperty, binding3);
                ToggleButtonSearch.Margin = new Thickness(3, 0, 3, 0);
                ToggleButtonSearch.Padding = new Thickness(-1, -1, 0, 0);
                ContentControl search = new ContentControl();
                search.Template = (ControlTemplate)resourceDictionary["serach"];
                ToggleButtonSearch.Content = search;
                ToggleButtonSearch.IsEnabled = false;


               // Binding binding4 = new Binding("ZoomOutChecked");
                Button ButtonZoomOut = ((Button)topToolbar.Children[4]);
               // ButtonZoomOut.SetBinding(Button.ClipProperty, binding4);
                ButtonZoomOut.Margin = new Thickness(3, 0, 3, 0);
                ButtonZoomOut.Padding = new Thickness(-1, -1, 0, 0);
                ContentControl ZomOut = new ContentControl();
                ZomOut.Template = (ControlTemplate)resourceDictionary["zoomOut"];
                ButtonZoomOut.Content = ZomOut;

               // Binding binding5 = new Binding("ZoomInChecked");
                Button ButtonZoomIn = ((Button)topToolbar.Children[5]);
               // ButtonZoomIn.SetBinding(Button., binding5);
                ButtonZoomIn.Margin = new Thickness(3, 0, 3, 0);
                ButtonZoomIn.Padding = new Thickness(-1, -1, 0, 0);
                ContentControl zoomIn = new ContentControl();
                zoomIn.Template = (ControlTemplate)resourceDictionary["zoomIn"];
                ButtonZoomIn.Content = zoomIn;



                //Binding binding6 = new Binding("ScaleInChecked");
                Button ToggleButtonScale = ((Button)topToolbar.Children[6]);
                ToggleButtonScale.Margin = new Thickness(3, 0, 6, 0);
                ToggleButtonScale.Padding = new Thickness(-1, -1, 0, 0);
                ContentControl sacle = new ContentControl();
                sacle.Template = (ControlTemplate)resourceDictionary["scale"];
                ToggleButtonScale.Content = sacle;



                //ToggleButtonScale.SetBinding(ToggleButton.IsCheckedProperty, binding6);

                Binding binding9 = new Binding("DimensionChecked");
                ToggleButton ToggleButtonDimen = ((ToggleButton)topToolbar.Children[9]);
                ToggleButtonDimen.SetBinding(ToggleButton.IsCheckedProperty, binding9);
                ToggleButtonDimen.Margin = new Thickness(3, 0, 3, 0);
                ToggleButtonDimen.Padding = new Thickness(-1, -1, 0, 0);
                ContentControl dimension = new ContentControl();
                dimension.Template = (ControlTemplate)resourceDictionary["dimension"];
                ToggleButtonDimen.Content = dimension;




                Binding binding10 = new Binding("FocusChecked");
                ToggleButton ToggleButtonFocus = ((ToggleButton)topToolbar.Children[10]);
                ToggleButtonFocus.SetBinding(ToggleButton.IsCheckedProperty, binding10);
                ToggleButtonFocus.Margin = new Thickness(3, 0, 3, 0);
                ToggleButtonFocus.Padding = new Thickness(-1, -1, 0, 0);
                ContentControl focus = new ContentControl();
                focus.Template = (ControlTemplate)resourceDictionary["focus"];
                ToggleButtonFocus.Content = focus;





                Binding binding11 = new Binding("RulerChecked");
                ToggleButton ToggleButtonRuler = ((ToggleButton)topToolbar.Children[11]);
                ToggleButtonRuler.SetBinding(ToggleButton.IsCheckedProperty, binding11);
                ToggleButtonRuler.Margin = new Thickness(3, 0, 3, 0);
                ToggleButtonRuler.Padding = new Thickness(-1, -1, 0, 0);
                ContentControl ruler = new ContentControl();
                ruler.Template = (ControlTemplate)resourceDictionary["ruler"];
                ToggleButtonRuler.Content = ruler;




                ToggleButton ToggleButtonProfile = ((ToggleButton)topToolbar.Children[12]);
                ToggleButtonProfile.SetBinding(ToggleButton.IsCheckedProperty, new Binding("ProfileChecked"));
                ToggleButtonProfile.Margin = new Thickness(3, 0, 3, 0);
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
                    // stageAcquisition.Children[3].Visibility = Visibility.Collapsed;
                    //stageAcquisition.Children[4].Visibility = Visibility.Collapsed;
                    //stageAcquisition.Children[5].Visibility = Visibility.Collapsed;
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
                        histogramTogg.IsChecked = false;
                    }
                };
                ToggleButtonInline.Unchecked += delegate
                {
                    ColumnDefinition leftView = (ColumnDefinition)mainwin.FindName("leftView");
                    leftView.Width = leftViewtemp;

                    Border border = (Border)mainwin.FindName("imagingView");
                    border.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#444444"));
                    border.BorderThickness = new Thickness(2);
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

               
                // delete Arrow
                ToggleButton ToggleButtonLine = ((ToggleButton)topToolbar.Children[14]);
                ToggleButtonLine.SetBinding(ToggleButton.IsCheckedProperty, new Binding("LineChecked"));
                ToggleButtonLine.Margin = new Thickness(3, 0, 3, 0);

                ToggleButtonLine.Padding = new Thickness(-1, -1, 0, 0);
                ContentControl line = new ContentControl();
                line.Template = (ControlTemplate)resourceDictionary["line"];
                ToggleButtonLine.Content = line;


                ToggleButton ToggleButtonCurve = ((ToggleButton)topToolbar.Children[15]);
                ToggleButtonCurve.SetBinding(ToggleButton.IsCheckedProperty, new Binding("CurveChecked"));
                ToggleButtonCurve.Margin = new Thickness(3, 0, 3, 0);
                ToggleButtonCurve.Padding = new Thickness(-1, -1, 0, 0);
                ContentControl curve = new ContentControl();
                curve.Template = (ControlTemplate)resourceDictionary["curve"];
                ToggleButtonCurve.Content = curve;






                ToggleButton ToggleButtonCircle = ((ToggleButton)topToolbar.Children[16]);
                ToggleButtonCircle.SetBinding(ToggleButton.IsCheckedProperty, new Binding("CircleChecked"));
                ToggleButtonCircle.Margin = new Thickness(3, 0, 3, 0);
                ToggleButtonCircle.Padding = new Thickness(-1, -1, 0, 0);
                ContentControl circle = new ContentControl();
                circle.Template = (ControlTemplate)resourceDictionary["circle"];
                ToggleButtonCircle.Content = circle;

                ToggleButton ToggleButtonRectangle = ((ToggleButton)topToolbar.Children[17]);
                ToggleButtonRectangle.SetBinding(ToggleButton.IsCheckedProperty, new Binding("RectangleChecked"));


                ToggleButtonRectangle.Margin = new Thickness(3, 0, 3, 0);
                ToggleButtonRectangle.Padding = new Thickness(-1, -1, 0, 0);
                ContentControl rectangle = new ContentControl();
                rectangle.Template = (ControlTemplate)resourceDictionary["rectangle"];
                ToggleButtonRectangle.Content = rectangle;



                ToggleButton ToggleButtonPolygon = ((ToggleButton)topToolbar.Children[18]);
                ToggleButtonPolygon.SetBinding(ToggleButton.IsCheckedProperty, new Binding("PolygonChecked"));
                ToggleButtonPolygon.Margin = new Thickness(3, 0, 3, 0);
                ToggleButtonPolygon.Padding = new Thickness(-1, -1, 0, 0);
                ContentControl polygon = new ContentControl();
                polygon.Template = (ControlTemplate)resourceDictionary["polygon"];
                ToggleButtonPolygon.Content = polygon;


                

                ToggleButton ToggleButtonText = ((ToggleButton)topToolbar.Children[19]);
                ToggleButtonText.SetBinding(ToggleButton.IsCheckedProperty, new Binding("TextChecked"));
                ToggleButtonText.Margin = new Thickness(3, 0, 3, 0);
                ToggleButtonText.Padding = new Thickness(-1, -1, 0, 0);
                ContentControl text = new ContentControl();
                text.Template = (ControlTemplate)resourceDictionary["text"];
                ToggleButtonText.Content = text;

               

                SplitButtonSelec = ((SplitButtonSelect)topToolbar.Children[20]);
                SplitButtonSelec.SelectToggle.SetBinding(ToggleButton.IsCheckedProperty, new Binding("InkSelected"));

                SplitButtonSelec.SelectToggle.MouseDoubleClick += (s, e) =>
                {
                    Application.Current.Dispatcher.Invoke(delegate
                    {
                        if (e.ChangedButton == MouseButton.Left)
                        {
                            MultiInkSelectEnable();
                        }
                    });

                };


                SplitButtonErase = ((SplitButtonEraser)topToolbar.Children[21]);
                SplitButtonErase.eraseToggle.SetBinding(ToggleButton.IsCheckedProperty, new Binding("EraserChecked"));
                SplitButtonErase.eraseToggle.MouseDoubleClick += (s, e) =>
                {
                    Application.Current.Dispatcher.Invoke(delegate
                    {
                        if (e.ChangedButton == MouseButton.Left)
                        {
                            MultiEraseEnable();
                        }
                    });

                };


                List<ToggleButton> Tools = new List<ToggleButton>() { ToggleButtonSelect, ToggleButtonInline, ToggleButtonMove, ToggleButtonFocus, ToggleButtonRuler, ToggleButtonProfile, ToggleButtonText, ToggleButtonLine, ToggleButtonCurve, ToggleButtonCircle, ToggleButtonRectangle, ToggleButtonPolygon ,SplitButtonSelec.SelectToggle, SplitButtonErase.eraseToggle };
                DrawingModeList = new List<ToggleButton>() { ToggleButtonRuler, ToggleButtonProfile,ToggleButtonText, ToggleButtonLine, ToggleButtonCurve, ToggleButtonCircle, ToggleButtonRectangle, ToggleButtonPolygon , SplitButtonErase.eraseToggle };
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


                //Application.Current.ApplyTheme(ThemeManagers.CurrentUITheme);
                foreach (var item in topToolbar.Children)
                {
                    if (item is ToggleButton toggleButton1)
                    {
                        toggleButton1.Style = (Style)resourceDictionary["ToggleButtonStyle222"];
                        // toggleButton1.Style = (Style)Application.Current.FindResource("ToggleButtonStyle222");

                    }

                    if (item is Button button)
                    {
                        button.Style = (Style)resourceDictionary["ButtonStyle222"];
                        // button.Style = (Style)Application.Current.FindResource("ButtonStyle222");

                    }



                }
                DockPanel leftToolbar = (DockPanel)mainwin.FindName("leftToolbar");
                WrapPanel leftToolbar1 = (WrapPanel)leftToolbar.Children[0];
                foreach (var item in leftToolbar1.Children)
                {
                    if (item is ToggleButton toggleButton1)
                    {
                        toggleButton1.Style = (Style)resourceDictionary["ToggleButtonStyle222"];
                        // toggleButton1.Style = (Style)Application.Current.FindResource("ToggleButtonStyle222");

                        toggleButton1.Margin = new Thickness(3, 3, 3, 3);
                    }
                }
                ToggleButton rangetogg = (ToggleButton)leftToolbar1.Children[4];
                rangetogg.Style = (Style)resourceDictionary["ToggleButtonStyle223"];
                // rangetogg.Style = (Style)Application.Current.FindResource("ToggleButtonStyle223");

                WrapPanel righttToolbar = (WrapPanel)mainwin.FindName("rightToolbar");
                foreach (var item in righttToolbar.Children)
                {
                    if (item is ToggleButton toggleButton1)
                    {
                        toggleButton1.Style = (Style)resourceDictionary["ToggleButtonStyle222"];
                        // toggleButton1.Style = (Style)Application.Current.FindResource("ToggleButtonStyle222");

                    }
                }

                try     // custom button style
                {
                    WrapPanel bottomToolBar = (WrapPanel)mainwin.FindName("bottomToolbar");
                    Button startButton = (Button)bottomToolBar.Children[0];
                    startButton.Style = (Style)resourceDictionary["ButtonStyle122"];
                    // startButton.Style = (Style)Application.Current.FindResource("ButtonStyle122");
                    Button stopButton = (Button)bottomToolBar.Children[1];
                    Button forWardButton = (Button)bottomToolBar.Children[2];
                    stopButton.Style = (Style)resourceDictionary["ButtonStyle212"];
                    // stopButton.Style = (Style)Application.Current.FindResource("ButtonStyle212");
                    forWardButton.Style = (Style)resourceDictionary["ButtonStyle212"];
                    // forWardButton.Style = (Style)Application.Current.FindResource("ButtonStyle212");
                    Button backWardButton = (Button)bottomToolBar.Children[3];
                    backWardButton.Style = (Style)resourceDictionary["ButtonStyle221"];
                    //backWardButton.Style = (Style)Application.Current.FindResource("ButtonStyle221");
                    Button placeButton = (Button)bottomToolBar.Children[bottomToolBar.Children.Count - 1];
                    //placeButton.Style = (Style)Application.Current.FindResource("ButtonStyle222");
                    placeButton.Style = (Style)resourceDictionary["ButtonStyle222"];

                }
                catch
                {

                }


                // hidden Global ratio slider
                if (Application.Current.MainWindow.Content is Grid mainGrid && mainGrid.Children[0] is Grid grid2 && grid2.Children[1] is StackPanel stackPanelMode)
                {
                    if (grid2.Children[0] is StackPanel stackPanel && stackPanel.Children[1] is Slider sliderRatio)
                    {
                        sliderRatio.Visibility = Visibility.Hidden;
                    }

                }
                try
                {
                    GridSplitter gridSplitter = (GridSplitter)mainwin.FindName("MiddleSplitter");
                    Grid grid = (Grid)gridSplitter.Parent;

                    grid.Children.Remove(grid.Children[3]);
                    grid.Children.Remove(grid.Children[3]);
                    grid.Children.Remove(grid.Children[3]);
                }
                // remove  middle gridSplitter
                catch
                {

                }

               
               



            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }

            // 多窗口拍照 当前焦点窗口
            try
            {
               
                Grid stageAcquisition = (Grid)mainwin.FindName("stageAcquisition");
                DockPanel dockPanel = (DockPanel)stageAcquisition.Children[1];
                StackPanel stackPanel1 = (StackPanel)dockPanel.Children[1];
                SplitButton Snap = (SplitButton)stackPanel1.Children[1];
                Snap.Split_Button.Click += (s, e) =>
                {
                    int view = DrawInkMethod.ActiveViews.ActiveWin;
                    LambdaControl.Trigger("SNAP_SHOT", this, new Dictionary<string, object> { { "view", view } });

                };
            }
            catch
            {

            }



        }


    }
}
