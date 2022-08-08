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
using System.Windows.Resources;

namespace Global
{
    public partial class WindowData
    {
        //public TabItem proSetItem;
        //public TabControl tabControl1;
        //private ToggleButton histogramTog;

        private void AddInjection1()
        {
            Window mainwin = Application.Current.MainWindow;

            //MainView
            try
            {
                Grid grid = (Grid)mainwin.FindName("grid0");
                Image image = (Image)grid.Children[0];
                InkVisual inkVisual = new InkVisual(ImageViewState.toolTop, inkMethod, ratio);
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
               
                //// Add Histogram
                //Histogram histogram = new Histogram();
                //StackPanel stackPanel = (StackPanel)mainwin.FindName("bottomView");
                //Grid grid1 = (Grid)stackPanel.Parent;
                //histogram.Height = Double.NaN;
                //// histogram.Width = 450;
                //histogram.Visibility = Visibility.Collapsed;
                //histogram.DataContext = histogramModel;
                //grid1.Children.Add(histogram);
                //Grid.SetRow(histogram, 2);
                //grid1.Children.Remove(stackPanel);
                //GridSplitter gridSplitter = (GridSplitter)grid1.Children[1];
                //gridSplitter.HorizontalAlignment = HorizontalAlignment.Stretch;
                //gridSplitter.VerticalAlignment = VerticalAlignment.Center;
                //Brush brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#444444"));
                //gridSplitter.Background = brush;
                //gridSplitter.Height = 3;
                //DockPanel leftToolBar = (DockPanel)mainwin.FindName("leftToolbar");
                //if (leftToolBar == null) return;
                //WrapPanel leftToolBarChild = (WrapPanel)leftToolBar.Children[0];
                //ToggleButton histogramTogg = (ToggleButton)leftToolBarChild.Children[3];
                //histogramTogg.Checked += delegate
                //{

                //    grid1.RowDefinitions[2].Height = new GridLength(200, GridUnitType.Pixel);
                //    histogram.Visibility = Visibility.Visible;
                //};
                //histogramTogg.Unchecked += delegate
                //{
                //    histogram.Visibility = Visibility.Collapsed;
                //    grid1.RowDefinitions[2].Height = new GridLength(0, GridUnitType.Pixel);

                //};


                //updateStatus.PropertyChanged += delegate (object? sender, PropertyChangedEventArgs e)
                //{
                //    if (e.PropertyName == "Ratio")
                //    {
                //        ratio = Convert.ToDouble(updateStatus.Ratio.Trim('%')) / 100;

                //        List<Visual> visualsList = new List<Visual>();

                //        foreach (var item in inkVisual.inkCanvas.visuals)
                //        {
                //            visualsList.Add(item);
                //        }

                //        if (visualsList.Count > 0)
                //        {
                //            foreach (DrawingVisual visual in visualsList)
                //            {
                //                inkVisual.inkCanvas.DeleteVisual(visual);
                //            }
                //            visualsList.Clear();
                //        }


                //        if (inkVisual.inkCanvas.visuals.Count == 0 && ImageViewState.toolTop.DimensionChecked)
                //        {
                //            DrawingVisual dimDefaultVisual = new DrawingVisual();
                //            inkVisual.inkCanvas.AddVisual(dimDefaultVisual);
                //            drawMethod.DrawDimension(image.ActualWidth, image.ActualHeight, ratio, new Point(0, 0), new Point(0, 0), true, dimDefaultVisual);
                //        }
                //    }
                //};






                ImageViewState.toolTop.PropertyChanged += delegate (object? sender, PropertyChangedEventArgs e)
                {
                    // MessageBox.Show("1111");
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
                    else if ((bool)ImageViewState.toolTop.DimensionChecked || (bool)ImageViewState.toolTop.ArrowChecked || (bool)ImageViewState.toolTop.CircleChecked || (bool)ImageViewState.toolTop.CurveChecked || (bool)ImageViewState.toolTop.PolygonChecked || (bool)ImageViewState.toolTop.TextChecked || (bool)ImageViewState.toolTop.LineChecked || (bool)ImageViewState.toolTop.RectangleChecked)
                    {
                        inkVisual.inkCanvas.Cursor = Cursors.Cross;
                    }
                    else if ((bool)ImageViewState.toolTop.MoveChecked)
                    {
                        inkVisual.inkCanvas.Cursor = Cursors.Hand;

                    }
                    else
                    {
                        inkVisual.inkCanvas.Cursor = Cursors.Arrow;
                    };
                    if (e.PropertyName == "DimensionChecked")
                    {
                        if ((bool)ImageViewState.toolTop.DimensionChecked )
                        {

                            if (!inkVisual.inkCanvas.Strokes.Contains(inkMethod.Dimstroke))
                            {
                                double w = inkVisual.inkCanvas.ActualWidth;
                                double h = inkVisual.inkCanvas.ActualHeight;
                                Point iniP = new Point(w * 19 / 20, h * 19 / 20);
                                Point endP = new Point(w * 19 / 20 - w * 100* inkVisual.ratio / 1689.12, h * 19 / 20);
                                inkMethod.Dimstroke = inkMethod.GenerateDimensionStroke0(iniP, endP);
                                try
                                {
                                    inkVisual.inkCanvas.Strokes.Remove(inkVisual.lastTempStroke);
                                }
                                catch { }
                                //inkVisual.lastTempStroke = inkMethod.Dimstroke;
                                inkVisual.inkCanvas.Strokes.Add(inkMethod.Dimstroke);
                                //inkVisual.lastTempStroke = null;
                                inkMethod.Textstroke = DrawInkMethod.InkCanvasMethod.CreateText1(iniP, endP);
                                inkVisual.inkCanvas.Strokes.Add(inkMethod.Textstroke);

                            }
                            else
                            {
                                inkVisual.inkCanvas.Strokes.Remove(inkMethod.Dimstroke);
                                inkVisual.inkCanvas.Strokes.Remove(inkMethod.Textstroke);
                                double w = inkVisual.inkCanvas.ActualWidth;
                                double h = inkVisual.inkCanvas.ActualHeight;
                                Point iniP = new Point(w * 19 / 20, h * 19 / 20);
                                Point endP = new Point(w * 19 / 20 - w * 100* inkVisual.ratio / 1689.12, h * 19 / 20);
                                inkMethod.Dimstroke = inkMethod.GenerateDimensionStroke0(iniP, endP);
                               
                                inkVisual.lastTempStroke = inkMethod.Dimstroke;
                                inkVisual.inkCanvas.Strokes.Add(inkMethod.Dimstroke);
                                inkVisual.lastTempStroke = null;
                                //inkVisual.lastTempStroke = null;
                                inkMethod.Textstroke = DrawInkMethod.InkCanvasMethod.CreateText1(iniP, endP);
                                inkVisual.inkCanvas.Strokes.Add(inkMethod.Textstroke);
                            }


                            
                        }
                        else
                        {

                        }

                    };
                    if (e.PropertyName == "SelectChecked")
                    {
                       
                            if ((bool)ImageViewState.toolTop.SelectChecked)
                            {
                                inkVisual.Visibility = Visibility.Collapsed;
                               
                            }
                            else
                            {
                                inkVisual.Visibility = Visibility.Visible;

                            }

                     
                    }
                    if (e.PropertyName == "CurveChecked")
                    {
                      

                    }

                };

                inkVisual.inkCanvas.MouseMove += delegate (object sender, MouseEventArgs e)
                {
                    if (ImageViewState.toolTop.SelectChecked)
                    {
                        ////if (!inkVisual.inkCanvas.visuals.Contains(drawMethod.pixelVisual))
                        ////    inkVisual.inkCanvas.AddVisual(drawMethod.pixelVisual);
                        ////WriteableBitmap writeableBitmap = image.Source as WriteableBitmap;
                        ////Point topLeftCorner = e.GetPosition(image);
                        ////try
                        ////{
                        ////    if (topLeftCorner.Y < image.ActualHeight - 130)
                        ////    {
                        ////        if (topLeftCorner.X < image.ActualWidth - 120)
                        ////        {
                        ////            drawMethod.DrawPixelSquare(writeableBitmap, drawMethod.pixelVisual, topLeftCorner, image.ActualWidth, image.ActualHeight);
                        ////        }
                        ////        else
                        ////        {
                        ////            drawMethod.DrawPixelSquareLeft(writeableBitmap, drawMethod.pixelVisual, topLeftCorner, image.ActualWidth, image.ActualHeight);
                        ////        }

                        ////    }
                        ////    else if (topLeftCorner.Y >= image.ActualHeight - 130)
                        ////    {
                        ////        if (topLeftCorner.X < image.ActualWidth - 120)
                        ////        {

                        ////            drawMethod.DrawPixelSquareUp(writeableBitmap, drawMethod.pixelVisual, topLeftCorner, image.ActualWidth, image.ActualHeight);

                        ////        }
                        ////        else
                        ////        {
                        ////            drawMethod.DrawPixelSquareLeftUp(writeableBitmap, drawMethod.pixelVisual, topLeftCorner, image.ActualWidth, image.ActualHeight);
                        ////        }

                        ////    }

                        //}
                        //catch (Exception ex)
                        //{

                        //}

                        //drawingVisualInk.ReleaseMouseCapture();
                        //// drawingCanvasInk[0] = drawingVisualInk;
                    }


                };

                inkVisual.inkCanvas.MouseLeave += delegate (object sender, MouseEventArgs e)
                {
                    //if (ImageViewState.toolTop.SelectChecked)
                    //{
                    //    if (inkVisual.inkCanvas.visuals.Contains(drawMethod.pixelVisual))
                    //        inkVisual.inkCanvas.DeleteVisual(drawMethod.pixelVisual);
                    //}
                };
                WrapPanel topToolbar = (WrapPanel)mainwin.FindName("topToolbar");
                ToggleButton ToggleButtonZoomOut = ((ToggleButton)topToolbar.Children[4]);
                ToggleButton ToggleButtonZoomIn = ((ToggleButton)topToolbar.Children[5]);
                Button ScaleButton = (Button)topToolbar.Children[6];
                ToggleButtonZoomOut.Click += delegate
                {
                    if (inkVisual.ZoomInOut < 5)
                    {
                        if (inkVisual.saveTempStroke && inkVisual.inkCanvas.Strokes.Count > 0)
                        {
                            if (inkVisual.inkCanvas.Strokes.Contains(inkMethod.Dimstroke))
                            {
                                inkVisual.inkCanvas.Strokes.Remove(inkMethod.Dimstroke);
                                inkVisual.inkCanvas.Strokes.Remove(inkMethod.Textstroke);

                            }

                            inkVisual.tempStroke = inkVisual.inkCanvas.Strokes.Clone();
                            inkVisual.inkCanvas.Strokes.Add(inkMethod.Dimstroke);
                            inkVisual.inkCanvas.Strokes.Add(inkMethod.Textstroke);

                            inkVisual.saveTempStroke = false;
                        }
                        Point curPoint = new Point(inkVisual.inkCanvas.ActualWidth / 2, inkVisual.inkCanvas.ActualHeight / 2);

                        Matrix matrix = new Matrix();
                        matrix.ScaleAt(1.2, 1.2, curPoint.X, curPoint.Y);
                        inkVisual.inkCanvas.Strokes.Transform(matrix, false);
                        inkVisual.ZoomInOut++;
                        inkVisual.ratio = inkVisual.ratio * 1.2;

                        if (inkVisual.inkCanvas.Strokes.Contains(inkMethod.Dimstroke))
                               {
                                inkVisual.inkCanvas.Strokes.Remove(inkMethod.Dimstroke);
                                inkVisual.inkCanvas.Strokes.Remove(inkMethod.Textstroke);
                                double w = inkVisual.inkCanvas.ActualWidth;
                                    double h = inkVisual.inkCanvas.ActualHeight;
                                    Point iniP = new Point(w * 19 / 20, h * 19 / 20);
                                    Point endP = new Point(w * 19 / 20 - w * 100 * inkVisual.ratio / 1689.12, h * 19 / 20);
                                    inkMethod.Dimstroke = inkMethod.GenerateDimensionStroke0(iniP, endP);
                                    try
                                    {
                                        inkVisual.inkCanvas.Strokes.Remove(inkVisual.lastTempStroke);
                                    }
                                    catch { }
                                    //inkVisual.lastTempStroke = inkMethod.Dimstroke;
                                    inkVisual.inkCanvas.Strokes.Add(inkMethod.Dimstroke);
                                    //inkVisual.lastTempStroke = null;
                                    inkMethod.Textstroke = DrawInkMethod.InkCanvasMethod.CreateText1(iniP, endP);
                                    inkVisual.inkCanvas.Strokes.Add(inkMethod.Textstroke);

                                }
                               

                            };
                  
                  
                
                };
                ToggleButtonZoomIn.Click += delegate
                {
                    if (inkVisual.ZoomInOut >0)
                    {
                        if (inkVisual.saveTempStroke && inkVisual.inkCanvas.Strokes.Count > 0)
                        {
                            if (inkVisual.inkCanvas.Strokes.Contains(inkMethod.Dimstroke))
                            {
                                inkVisual.inkCanvas.Strokes.Remove(inkMethod.Dimstroke);
                                inkVisual.inkCanvas.Strokes.Remove(inkMethod.Textstroke);

                            }

                            inkVisual.tempStroke = inkVisual.inkCanvas.Strokes.Clone();
                            inkVisual.inkCanvas.Strokes.Add(inkMethod.Dimstroke);
                            inkVisual.inkCanvas.Strokes.Add(inkMethod.Textstroke);
                            inkVisual.saveTempStroke = false;
                        }
                        Point curPoint = new Point(inkVisual.inkCanvas.ActualWidth / 2, inkVisual.inkCanvas.ActualHeight / 2);

                        Matrix matrix = new Matrix();

                        matrix.ScaleAt(1 / 1.2, 1 / 1.2, curPoint.X, curPoint.Y);
                        inkVisual.inkCanvas.Strokes.Transform(matrix, false);
                        inkVisual.ZoomInOut--;
                        inkVisual.ratio = inkVisual.ratio /1.2;

                        if (inkVisual.inkCanvas.Strokes.Contains(inkMethod.Dimstroke))
                        {
                            inkVisual.inkCanvas.Strokes.Remove(inkMethod.Dimstroke);
                            inkVisual.inkCanvas.Strokes.Remove(inkMethod.Textstroke);
                            double w = inkVisual.inkCanvas.ActualWidth;
                            double h = inkVisual.inkCanvas.ActualHeight;
                            Point iniP = new Point(w * 19 / 20, h * 19 / 20);
                            Point endP = new Point(w * 19 / 20 - w * 100 * inkVisual.ratio / 1689.12, h * 19 / 20);
                            inkMethod.Dimstroke = inkMethod.GenerateDimensionStroke0(iniP, endP);
                            try
                            {
                                inkVisual.inkCanvas.Strokes.Remove(inkVisual.lastTempStroke);
                            }
                            catch { }
                            //inkVisual.lastTempStroke = inkMethod.Dimstroke;
                            inkVisual.inkCanvas.Strokes.Add(inkMethod.Dimstroke);
                            //inkVisual.lastTempStroke = null;
                            inkMethod.Textstroke = DrawInkMethod.InkCanvasMethod.CreateText1(iniP, endP);
                            inkVisual.inkCanvas.Strokes.Add(inkMethod.Textstroke);

                        }
                       

                    };
              };
                ScaleButton.Click += delegate
                {
                    if (inkVisual.inkCanvas.Strokes.Contains(inkMethod.Dimstroke))
                    {
                        inkVisual.tempStroke.Add(inkMethod.Dimstroke);
                    }

                    inkVisual.inkCanvas.Strokes.Clear();
                    inkVisual.inkCanvas.Strokes.Add(inkVisual.tempStroke);
                    inkVisual.saveTempStroke = true;
                    inkVisual.ZoomInOut=0;
                    inkVisual.ratio = 1;
                    if (inkVisual.inkCanvas.Strokes.Contains(inkMethod.Dimstroke))
                    {
                        inkVisual.inkCanvas.Strokes.Remove(inkMethod.Dimstroke);
                        inkVisual.inkCanvas.Strokes.Remove(inkMethod.Textstroke);
                        double w = inkVisual.inkCanvas.ActualWidth;
                        double h = inkVisual.inkCanvas.ActualHeight;
                        Point iniP = new Point(w * 19 / 20, h * 19 / 20);
                        Point endP = new Point(w * 19 / 20 - w * 100 * inkVisual.ratio / 1689.12, h * 19 / 20);
                        inkMethod.Dimstroke = inkMethod.GenerateDimensionStroke0(iniP, endP);
                        try
                        {
                            inkVisual.inkCanvas.Strokes.Remove(inkVisual.lastTempStroke);
                        }
                        catch { }
                        //inkVisual.lastTempStroke = inkMethod.Dimstroke;
                        inkVisual.inkCanvas.Strokes.Add(inkMethod.Dimstroke);
                        //inkVisual.lastTempStroke = null;
                        inkMethod.Textstroke = DrawInkMethod.InkCanvasMethod.CreateText1(iniP, endP);
                        inkVisual.inkCanvas.Strokes.Add(inkMethod.Textstroke);

                    }
                };
                


            }
            catch (Exception ex)
            {

            }



        }
    }
    }
