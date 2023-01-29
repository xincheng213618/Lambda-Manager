using Global.UserControls.DrawVisual;
using Global.UserControls.SeriesMap;
using Lambda;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Resources;

namespace Global
{
    public partial class WindowData1
    {
        public void AddDevelopMode()
        {
            Grid AncestorGrid = (Grid)mainwin.Content;
            Grid grid1 = (Grid)AncestorGrid.Children[0];
            StackPanel stackPanel = (StackPanel)grid1.Children[2];
            Menu menu = (Menu)stackPanel.Children[0];
            MenuItem menuItem1 = (MenuItem)menu.Items[0];
            bool AddDevelopMode = false;
            ItemCollection menuItems = menuItem1.Items;
            foreach(MenuItem item in menuItems)
            {
                if (item.Header.ToString() == "开发模式")
                {
                    item.Click += (s, e) =>
                    {
                        WindowData.GetInstance().setting.otherMode.DevelopMode = !WindowData.GetInstance().setting.otherMode.DevelopMode;
                        bool? isDevMode = WindowData.GetInstance().setting.otherMode.DevelopMode;
                        if (isDevMode == true)
                        {
                            WindowData.GetInstance().AcquireModule(true);
                        }
                        else
                        {
                            WindowData.GetInstance().AcquireModule(false);
                        }

                    };
                }

            }


        }

        private void RatioTextBind(Window mainwin)
        {
            TextBox ratioTextBox = (TextBox)mainwin.FindName("ratio");
            Binding bindingRatio = new Binding("Ratio")
            {
                Mode = BindingMode.TwoWay,
            };
            bindingRatio.Source = updateStatus;
            bindingRatio.Converter = new ValueClassTodPercentonverter();
            ratioTextBox.SetBinding(TextBox.TextProperty, bindingRatio);
            ratioTextBox.PreviewKeyDown += (s, e) =>
            {

                if (e.Key == Key.Enter)
                {
                    var traversalRequest = new TraversalRequest(FocusNavigationDirection.Down);
                    ratioTextBox.MoveFocus(traversalRequest);
                }

            };
            double ReRatio = 1;
            updateStatus.PropertyChanged += delegate (object? sender, PropertyChangedEventArgs e)
            {
                if (e.PropertyName == "Ratio")
                {
                    if (!DrawInkMethod.ZoomWard)
                    {
                        ReRatio = inkVisuals[DrawInkMethod.ActiveViews.ActiveWin].ratio1.Ratio;
                        double ratio = updateStatus.Ratio / 100.0;
                        Matrix matrix = new Matrix();
                        double centerX = inkVisuals[0].inkCanvas.ActualWidth / 2.0;
                        double centerY = inkVisuals[0].inkCanvas.ActualHeight / 2.0;

                        //  ReRatio =1/ReRatio * ratio;
                        matrix.ScaleAt(ratio / ReRatio, ratio / ReRatio, centerX, centerY);
                        inkVisuals[DrawInkMethod.ActiveViews.ActiveWin].inkCanvas.Strokes.Transform(matrix, false);
                        inkVisuals[DrawInkMethod.ActiveViews.ActiveWin].ratio1.Ratio = ratio;
                        inkVisuals[DrawInkMethod.ActiveViews.ActiveWin].RecTopLeft = inkVisuals[DrawInkMethod.ActiveViews.ActiveWin].RecTopLeft * matrix;
                        inkVisuals[DrawInkMethod.ActiveViews.ActiveWin].RecBottomRight = inkVisuals[DrawInkMethod.ActiveViews.ActiveWin].RecBottomRight * matrix;
                        inkVisuals[DrawInkMethod.ActiveViews.ActiveWin].ZoomParTransform(inkVisuals[DrawInkMethod.ActiveViews.ActiveWin].ratio1.Ratio, inkVisuals[DrawInkMethod.ActiveViews.ActiveWin].inkCanvas.Strokes, inkVisuals[DrawInkMethod.ActiveViews.ActiveWin]);
                        InkDimViewModel inkDimViewModel = new InkDimViewModel();
                        inkDimViewModel = inkVisuals[DrawInkMethod.ActiveViews.ActiveWin].inkDimViewModel;
                        inkVisuals[DrawInkMethod.ActiveViews.ActiveWin].drawDefaultDim(inkDimViewModel.DimPos, inkDimViewModel.DimLength, inkDimViewModel.DimColor, ratio, inkDimViewModel.TextColor);
                        DrawInkMethod.StrokesCollection.Clear();
                        inkVisuals[DrawInkMethod.ActiveViews.ActiveWin].FilterStroke(1, inkVisuals[DrawInkMethod.ActiveViews.ActiveWin].inkCanvas);

                    }

                };


                if (e.PropertyName == "BFCheckEnable" || e.PropertyName == "DFCheckEnable" || e.PropertyName == "RICheckEnable" || e.PropertyName == "DPCheckEnable" || e.PropertyName == "QPCheckEnable" || e.PropertyName == "PCCheckEnable")
                {

                    ActiveModeMatch(e.PropertyName);

                }


            };



        }



        private void AddInjection1()
        {
            Window mainwin = System.Windows.Application.Current.MainWindow;

            //MainView
            try
            {
                Grid grid = (Grid)mainwin.FindName("grid0");
                if (grid == null) return;
                Image image = (Image)grid.Children[0];
                InkVisual inkVisual = new InkVisual(0, image, ImageViewState.toolTop);
                inkVisual.profileModel = profileModel;

                inkVisuals[0] = inkVisual; // First InkCanvas
                Binding bindingW = new Binding();
                bindingW.Source = image;
                bindingW.Path = new PropertyPath("ActualWidth");
                inkVisual.SetBinding(InkVisual.WidthProperty, bindingW);

                Binding bindingH = new Binding();
                bindingH.Source = image;
                bindingH.Path = new PropertyPath("ActualHeight");
                inkVisual.SetBinding(InkVisual.HeightProperty, bindingH);
                grid.Children.Add(inkVisual);
                Grid.SetRow(inkVisual, 0);


                RatioTextBind(mainwin);

                inkVisual.inkCanvas.EditingModeChanged += (s, e) =>
                {

                    if (inkVisual.inkCanvas.EditingMode == InkCanvasEditingMode.Select)
                    {
                        foreach (var item in DrawingModeList)
                        {
                            if (item.IsChecked == true)
                                item.IsChecked = false;
                        }
                    }



                };
                inkVisual.Loaded += (s, e) =>
                {
                    AddDevelopMode();

                };

                //MessageBox.Show("1");
                WrapPanel topToolbar = (WrapPanel)mainwin.FindName("topToolbar");
                Button ButtonZoomOut = ((Button)topToolbar.Children[4]);
                Button ButtonZoomIn = ((Button)topToolbar.Children[5]);
                Button buttonEraseAll = ((Button)topToolbar.Children[23]);
                Button ScaleButton = (Button)topToolbar.Children[6];
                ToggleButton toggleButtonSelect = (ToggleButton)topToolbar.Children[20];
                ToggleButton toggleButtonSelectAll = (ToggleButton)topToolbar.Children[21];


                ButtonZoomOut.Click += delegate
                {
                    if (inkVisual.index == DrawInkMethod.ActiveViews.ActiveWin)
                    {
                        if (inkVisual.ratio1.Ratio < 2.5)
                        {
                            Point curPoint = new Point(inkVisual.ActualWidth / 2, inkVisual.ActualHeight / 2);
                            inkVisual.ratio1.Ratio = inkVisual.ratio1.Ratio * 1.2;
                            Matrix matrix = new Matrix();
                            if (inkVisual.ratio1.Ratio >= 2.49)
                            {
                                matrix.ScaleAt(2.49 * 1.2 / inkVisual.ratio1.Ratio, 2.49 * 1.2 / inkVisual.ratio1.Ratio, curPoint.X, curPoint.Y);
                                inkVisual.ratio1.Ratio = 2.49;
                            }
                            else
                            {
                                matrix.ScaleAt(1.2, 1.2, curPoint.X, curPoint.Y);
                            }
                            //  ZoomInOut++;
                            inkVisual.inkCanvas.Strokes.Transform(matrix, false);

                            inkVisual.RecTopLeft = inkVisual.RecTopLeft * matrix;
                            inkVisual.RecBottomRight = inkVisual.RecBottomRight * matrix;

                            inkVisual.ZoomParTransform(inkVisual.ratio1.Ratio, inkVisual.inkCanvas.Strokes, inkVisual);
                            DrawInkMethod.StrokesCollection.Clear();
                            inkVisual.FilterStroke(1, inkVisual.inkCanvas);
                            //  RepaintDim();
                            double ratio = inkVisual.ratio1.Ratio;
                            WindowData.GetInstance().updateStatus.Ratio = (int)(Math.Round(ratio, 2) * 100);
                            inkVisual.drawDefaultDim(inkVisual.inkDimViewModel.DimPos, inkVisual.inkDimViewModel.DimLength, inkVisual.inkDimViewModel.DimColor, inkVisual.ratio1.Ratio, inkVisual.inkDimViewModel.TextColor);

                        };
                    }


                };
               ButtonZoomIn.Click += delegate
                {
                    if (inkVisual.index == DrawInkMethod.ActiveViews.ActiveWin)
                    {

                        if (inkVisual.ratio1.Ratio >= 1)
                        {

                            Point curPoint = new Point(inkVisual.ActualWidth / 2, inkVisual.ActualHeight / 2);

                            Matrix matrix = new Matrix();
                            inkVisual.ratio1.Ratio = inkVisual.ratio1.Ratio / 1.2;
                            if (inkVisual.ratio1.Ratio <= 1)
                            {
                                matrix.ScaleAt(1 / (inkVisual.ratio1.Ratio * 1.2), 1 / (inkVisual.ratio1.Ratio * 1.2), curPoint.X, curPoint.Y);
                                inkVisual.ratio1.Ratio = 1;
                            }
                            else
                            {
                                matrix.ScaleAt(1 / 1.2, 1 / 1.2, curPoint.X, curPoint.Y);
                            }
                            inkVisual.inkCanvas.Strokes.Transform(matrix, false);
                            inkVisual.RecTopLeft = inkVisual.RecTopLeft * matrix;
                            inkVisual.RecBottomRight = inkVisual.RecBottomRight * matrix;
                            inkVisual.ZoomParTransform(inkVisual.ratio1.Ratio, inkVisual.inkCanvas.Strokes, inkVisual);
                            DrawInkMethod.StrokesCollection.Clear();
                            inkVisual.FilterStroke(1,inkVisual.inkCanvas);
                            double ratio = inkVisual.ratio1.Ratio;
                            WindowData.GetInstance().updateStatus.Ratio = (int)(Math.Round(ratio, 2) * 100);
                            inkVisual.drawDefaultDim(inkVisual.inkDimViewModel.DimPos, inkVisual.inkDimViewModel.DimLength, inkVisual.inkDimViewModel.DimColor, inkVisual.ratio1.Ratio, inkVisual.inkDimViewModel.TextColor);

                        };

                    }
                };
                ScaleButton.Click += delegate
                {

                    WindowData.GetInstance().updateStatus.Ratio = 100;

                };
                buttonEraseAll.Click += delegate
                {


                    int index = DrawInkMethod.ActiveViews.ActiveWin;
                    MessageBoxResult result = MessageBox.Show("是否删除当前" + index.ToString()+ "窗口的所有绘制图形 ", "信息提示", MessageBoxButton.YesNo, MessageBoxImage.Question);
                    switch (result)
                    {
                        case MessageBoxResult.Yes:
                            inkVisuals[DrawInkMethod.ActiveViews.ActiveWin].inkCanvas.Strokes.Clear();

                           // inkVisuals[DrawInkMethod.ActiveViews.ActiveWin].StrokeTransforAdapter(inkVisuals[DrawInkMethod.ActiveViews.ActiveWin]);
                            break;
                        case MessageBoxResult.No:
                            break;
                       
                    }
                   

                };

                WrapPanel bottomToolbar = (WrapPanel)mainwin.FindName("bottomToolbar");  // multiPoint position show 
                int count = bottomToolbar.Children.Count;
                Button bottomPlace = (Button)bottomToolbar.Children[count - 1];

                bottomPlace.Click += delegate
                {

                    bool isMapWindowshow = false;
                    foreach (Window w in Application.Current.Windows)
                    {
                        if (w is MapWindow)
                        {

                            isMapWindowshow = true;
                            w.Activate();
                        };

                    }
                    if (!isMapWindowshow)
                    {
                        // MessageBox.Show(MapWindow.SeriesPoints.Count.ToString());
                        if (MapWindow.SeriesPoints.Count == 0)
                            return;
                        MapWindow mapWindow = new MapWindow();
                        Point point = bottomPlace.PointToScreen(new Point(0, 0));
                        //Point point = bottomPlace.TransformToAncestor(mainwin).Transform(new Point(0, 0));
                        mapWindow.Show();
                        mapWindow.Topmost = true;
                        // monitor system Screen  ratio
                        var dpiXProperty = typeof(SystemParameters).GetProperty("DpiX", BindingFlags.NonPublic | BindingFlags.Static);
                        var dpiYProperty = typeof(SystemParameters).GetProperty("Dpi", BindingFlags.NonPublic | BindingFlags.Static);
                        var dpiX = (int)dpiXProperty.GetValue(null, null);
                        var dpiY = (int)dpiYProperty.GetValue(null, null);
                        double dpixRatio = (double)dpiX / 96;
                        double dpiyRatio = (double)dpiX / 96;
                        double x = point.X / dpixRatio + bottomPlace.ActualWidth - mapWindow.ActualWidth;
                        double y = point.Y / dpiyRatio - mapWindow.ActualHeight - 3;
                        mapWindow.Left = x;
                        mapWindow.Top = y;
                        mapWindow.DrawPointRec(MapWindow.SeriesPoints);

                        mainwin.Closing += delegate
                        {
                            mapWindow.Close();
                        };




                    }


                };
                toggleButtonSelect.Checked += delegate
                {
                    foreach (InkVisual item in DrawInkMethod.InkAll)
                    {
                        if (item != null)
                        {
                            if(item.index!= DrawInkMethod.ActiveViews.ActiveWin)
                            {
                                item.inkCanvas.EditingMode = InkCanvasEditingMode.None;
                            }
                            else
                            {
                                if(item.inkCanvas.EditingMode!= InkCanvasEditingMode.Select)
                                {
                                    item.inkCanvas.EditingMode = InkCanvasEditingMode.Select;
                                }
                            }
                            
                        }

                    }

                };
                toggleButtonSelect.Unchecked += delegate
                {
                    foreach(InkVisual item in DrawInkMethod.InkAll)
                    {
                        if (item != null)
                        {
                            item.inkCanvas.EditingMode = InkCanvasEditingMode.None;
                        }

                    }
                    if (WindowData1.GetInstance().ImageViewState.toolTop.EraserChecked)
                    {
                        inkVisuals[DrawInkMethod.ActiveViews.ActiveWin].inkCanvas.EditingMode = InkCanvasEditingMode.EraseByStroke;
                    }

                };

                toggleButtonSelectAll.Checked += delegate
                     {
                         foreach (InkVisual item in DrawInkMethod.InkAll)
                         {
                             if (item != null)
                             {
                                 item.inkCanvas.EditingMode = InkCanvasEditingMode.None;
                             }

                         }
                         inkVisuals[DrawInkMethod.ActiveViews.ActiveWin].inkCanvas.EditingMode = InkCanvasEditingMode.Select;

                         inkVisuals[DrawInkMethod.ActiveViews.ActiveWin].inkCanvas.Select(inkVisuals[DrawInkMethod.ActiveViews.ActiveWin].inkCanvas.Strokes);


                     };
                toggleButtonSelectAll.Unchecked += delegate
                {

                    foreach (InkVisual item in DrawInkMethod.InkAll)
                    {
                        if (item != null)
                        {
                            item.inkCanvas.EditingMode = InkCanvasEditingMode.None;
                        }
                       
                    }
                    if (WindowData1.GetInstance().ImageViewState.toolTop.EraserChecked)
                    {
                        inkVisuals[DrawInkMethod.ActiveViews.ActiveWin].inkCanvas.EditingMode = InkCanvasEditingMode.EraseByStroke;
                    }
                  
                };
              
            }
            catch (Exception ex)
            {
                LambdaControl.Log(new Message() { Severity = Severity.ERROR, Text = ex.Message });
            }




        }
        private void GetWindowMode(int i)
        {
            bool isExist = false;
            if (inkVisuals[DrawInkMethod.ActiveViews.ActiveWin].ActiveMode != i)
            {
                foreach (InkVisual ink in inkVisuals)
                {
                    if (ink != null && ink.ActiveMode == i)
                    {
                        DrawInkMethod.ActiveViews.ActiveWin = ink.index;
                        isExist = true;
                    }

                }
                if (!isExist)
                {
                    LambdaControl.Trigger("VIEW_WINDOW", this, new Dictionary<string, object>() { { "type", 0 }, { "window", DrawInkMethod.ActiveViews.ActiveWin }, { "mode1", i }, { "mode2", -1 } });
                }
            }

        }


        private void ActiveModeMatch(string mode)
        {
            switch (mode)
            {
                case "BFCheckEnable":
                    if (updateStatus.BFCheckEnable)
                        GetWindowMode(0);
                    break;
                case "DFCheckEnable":
                    if (updateStatus.DFCheckEnable)
                    {
                        GetWindowMode(1);
                    }
                    break;
                case "RICheckEnable":
                    if (updateStatus.RICheckEnable)
                    {
                        GetWindowMode(2);
                    }
                    break;
                case "DPCheckEnable":
                    if (updateStatus.DPCheckEnable)
                    {
                        GetWindowMode(3);
                    }
                    break;
                case "QPCheckEnable":
                    if (updateStatus.QPCheckEnable)
                    {
                        GetWindowMode(4);
                    }
                    break;
                case "PCCheckEnable":
                    if (updateStatus.PCCheckEnable)
                    {
                        GetWindowMode(5);
                    }
                    break;
                default:
                    return;
            }

        }
    }
}
