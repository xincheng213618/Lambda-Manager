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

            // 读图 模态切换

            updateStatus.PropertyChanged += delegate (object? sender, PropertyChangedEventArgs e)
            {
                if (e.PropertyName == "Ratio")
                {
                    if (!DrawInkMethod.ZoomWard)
                    {

                        inkVisuals[DrawInkMethod.ActiveViews.ActiveWin].ZoomRatio(updateStatus.Ratio);

                    }

                };


                //if (e.PropertyName == "BFCheckEnable" || e.PropertyName == "DFCheckEnable" || e.PropertyName == "RICheckEnable" || e.PropertyName == "DPCheckEnable" || e.PropertyName == "QPCheckEnable" || e.PropertyName == "PCCheckEnable")
                //{

                //    ActiveModeMatch(e.PropertyName);

                //}


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
                InkVisual inkVisual = new InkVisual(0, image, ImageViewState.toolTop,profileModel);

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

                inkVisual.Loaded += (s, e) =>
                {
                    AddDevelopMode();
                    AddHandleOfflineRegister();

                };

                //MessageBox.Show("1");
                WrapPanel topToolbar = (WrapPanel)mainwin.FindName("topToolbar");
                Button buttonEraseAll = SplitButtonErase.EraseAllBUtton;
                
                ToggleButton toggleButtonSelect = SplitButtonSelec.SelectToggle;
                Button selectAllButton = SplitButtonSelec.SelectAllBUtton; ;
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

                selectAllButton.Click +=(s,e)=>
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
              
              
            }
            catch (Exception ex)
            {
                LambdaControl.Log(new Message() { Severity = Severity.ERROR, Text = ex.Message });
            }




        }
       
    }
}
