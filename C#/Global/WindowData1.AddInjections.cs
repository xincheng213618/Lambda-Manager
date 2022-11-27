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



                TextBox ratioTextBox = (TextBox)mainwin.FindName("ratio");
                //ratioTextBox.Background = Brushes.Black;
                Binding bindingRatio = new Binding("Ratio")
                {
                    Mode = BindingMode.TwoWay,
                    // UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
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
                            inkVisuals[DrawInkMethod.ActiveViews.ActiveWin].ZoomParTransform(inkVisuals[DrawInkMethod.ActiveViews.ActiveWin].ratio1.Ratio, inkVisuals[DrawInkMethod.ActiveViews.ActiveWin].inkCanvas.Strokes);
                            InkDimViewModel inkDimViewModel = new InkDimViewModel();
                            inkDimViewModel = inkVisuals[DrawInkMethod.ActiveViews.ActiveWin].inkDimViewModel;
                            inkVisuals[DrawInkMethod.ActiveViews.ActiveWin].drawDefaultDim(inkDimViewModel.DimPos, inkDimViewModel.DimLength, inkDimViewModel.DimColor, ratio, inkDimViewModel.TextColor);
                            DrawInkMethod.StrokesCollection.Clear();
                            inkVisuals[DrawInkMethod.ActiveViews.ActiveWin].FilterStroke(1);

                        }




                    }
                };

                ImageViewState.toolTop.PropertyChanged += delegate (object? sender, PropertyChangedEventArgs e)
                {

                    if (e.PropertyName == "EraserChecked")
                    {
                        if (ImageViewState.toolTop.EraserChecked == true)
                        {
                            inkVisual.inkCanvas.EditingMode = InkCanvasEditingMode.EraseByStroke;
                            inkVisual.inkCanvas.UseCustomCursor = true;
                            StreamResourceInfo sri = Application.GetResourceStream(new Uri("/Global;component/usercontrols/image/eraser.cur", UriKind.Relative));
                            inkVisual.inkCanvas.Cursor = new Cursor(sri.Stream);


                        }
                        else
                        {
                            inkVisual.inkCanvas.Cursor = Cursors.Arrow;
                            inkVisual.inkCanvas.EditingMode = InkCanvasEditingMode.None;
                        }
                    }
                    else if (e.PropertyName == "RulerChecked")
                    {

                        if (ImageViewState.toolTop.RulerChecked == true)
                        {

                            inkVisual.inkCanvas.UseCustomCursor = true;
                            StreamResourceInfo sri = Application.GetResourceStream(new Uri("/Global;component/usercontrols/image/Ruler.cur", UriKind.Relative));
                            inkVisual.inkCanvas.Cursor = new Cursor(sri.Stream);

                        }
                        else
                        {
                            inkVisual.inkCanvas.Cursor = Cursors.Arrow;

                        }
                    }

                    else if ((bool)ImageViewState.toolTop.CircleChecked || (bool)ImageViewState.toolTop.CurveChecked || (bool)ImageViewState.toolTop.PolygonChecked || (bool)ImageViewState.toolTop.TextChecked || (bool)ImageViewState.toolTop.LineChecked || (bool)ImageViewState.toolTop.RectangleChecked)
                    {
                        inkVisual.inkCanvas.Cursor = Cursors.Cross;
                        // drawing Mode
                        inkVisual.inkCanvas.EditingMode = InkCanvasEditingMode.None;
                    }
                    else if ((bool)ImageViewState.toolTop.MoveChecked)
                    {
                        inkVisual.inkCanvas.Cursor = Cursors.Hand;

                    }
                    else
                    {
                        inkVisual.inkCanvas.Cursor = Cursors.Arrow;
                    };

                    if (e.PropertyName == "SelectChecked")
                    {

                        if ((bool)ImageViewState.toolTop.SelectChecked)
                        {
                            inkVisual.Visibility = Visibility.Visible;

                        }
                        else
                        {
                            inkVisual.Visibility = Visibility.Visible;

                        }


                    }


                };

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




                WrapPanel topToolbar = (WrapPanel)mainwin.FindName("topToolbar");
                ToggleButton ToggleButtonZoomOut = ((ToggleButton)topToolbar.Children[4]);
                ToggleButton ToggleButtonZoomIn = ((ToggleButton)topToolbar.Children[5]);
                Button ScaleButton = (Button)topToolbar.Children[6];

                ToggleButtonZoomOut.Click += delegate
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

                            inkVisual.ZoomParTransform(inkVisual.ratio1.Ratio, inkVisual.inkCanvas.Strokes);
                            DrawInkMethod.StrokesCollection.Clear();
                            inkVisual.FilterStroke(1);
                            //  RepaintDim();
                            double ratio = inkVisual.ratio1.Ratio;
                            WindowData.GetInstance().updateStatus.Ratio = (int)(Math.Round(ratio, 2) * 100);
                            inkVisual.drawDefaultDim(inkVisual.inkDimViewModel.DimPos, inkVisual.inkDimViewModel.DimLength, inkVisual.inkDimViewModel.DimColor, inkVisual.ratio1.Ratio, inkVisual.inkDimViewModel.TextColor);

                        };
                    }


                };
                ToggleButtonZoomIn.Click += delegate
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
                            inkVisual.ZoomParTransform(inkVisual.ratio1.Ratio, inkVisual.inkCanvas.Strokes);
                            DrawInkMethod.StrokesCollection.Clear();
                            inkVisual.FilterStroke(1);
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
                DrawInkMethod.StaticPropertyChanged += delegate
                {
                    DrawInkMethod.ActiveInk = WindowData1.GetInstance().inkVisuals[DrawInkMethod.ActiveViews.ActiveWin].inkCanvas;
                    foreach (InkVisual k in WindowData1.GetInstance().inkVisuals)
                    {
                        if (k != null)
                        {
                            if (ImageViewState.toolTop.EraserChecked)
                            {
                                k.inkCanvas.EditingMode = InkCanvasEditingMode.EraseByStroke;
                            }
                            else
                            {
                                k.inkCanvas.EditingMode = InkCanvasEditingMode.None;
                            }


                        }
                    }
                    DrawInkMethod.defdimenViewModel.DefDimReadOnly = false;
                    WindowData.GetInstance().updateStatus.Ratio = (int)(Math.Round(WindowData1.GetInstance().inkVisuals[DrawInkMethod.ActiveViews.ActiveWin].ratio1.Ratio, 2) * 100);

                    DrawInkMethod.defdimenViewModel.DimPos = WindowData1.GetInstance().inkVisuals[DrawInkMethod.ActiveViews.ActiveWin].inkDimViewModel.DimPos;
                    DrawInkMethod.defdimenViewModel.SelectedAccentColor = WindowData1.GetInstance().inkVisuals[DrawInkMethod.ActiveViews.ActiveWin].inkDimViewModel.DimColor;
                    DrawInkMethod.defdimenViewModel.Length = WindowData1.GetInstance().inkVisuals[DrawInkMethod.ActiveViews.ActiveWin].inkDimViewModel.DimLength;
                    DrawInkMethod.defdimenViewModel.TextSelectedAccentColor = WindowData1.GetInstance().inkVisuals[DrawInkMethod.ActiveViews.ActiveWin].inkDimViewModel.TextColor;
                    DrawInkMethod.defdimenViewModel.DefDimReadOnly = true;



                    //MessageBox.Show(DrawInkMethod.ActiveWindow.ToString());
                };


            }
            catch (Exception ex)
            {
                LambdaControl.Log(new Message() { Severity = Severity.ERROR, Text = ex.Message });
            }




        }
    }
}
