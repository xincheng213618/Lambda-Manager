using ConfigBottomView;
using Lambda;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using Global.UserControls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.IO;
using Global.UserControls.DrawVisual;

namespace Global
{
    /// <summary>
    /// 监听CallEventHandler事件
    /// </summary>
    public partial class WindowData
    {
        public bool ACQUIRE { get; set; } = false;
        public bool ALIVE { get; set; } = false;

       // static GridLengthConverter gridLengthConverter = new GridLengthConverter();
        public DrawMethod drawMethod = new DrawMethod();
        public DrawInkMethod inkMethod = new DrawInkMethod();
        Window mainwin = Application.Current.MainWindow;

        public DrawingVisualInk[] drawingCanvasInk = new DrawingVisualInk[100];
        public InkVisual[] inkVisuals = new InkVisual[100];
       // public double ratio =1;


        public  void AddImageConfident(Image image1, int viewindex)
        {
           
             double ratio = 1;
            DrawInkMethod inkMethod = new DrawInkMethod();
            InkVisual inkVisual = new InkVisual(ImageViewState.toolTop, inkMethod);
            if (image1.Parent is Grid grid0)
            {
                try
                {
                    //drawingCanvasInk[viewindex] = drawingVisualInk;
                    inkVisuals[viewindex] = inkVisual;
                    if (ViewContentMenuCache.ContainsKey(viewindex))
                        AddViewContentMenu(viewindex, ViewContentMenuCache[viewindex]);

                    if (image1.Parent is Grid grid1)
                    {
                        Binding bindingW = new Binding();
                        bindingW.Source = image1;
                        bindingW.Path = new PropertyPath("ActualWidth");
                        inkVisual.SetBinding(DrawingVisualInk.WidthProperty, bindingW);

                        Binding bindingH = new Binding();
                        bindingH.Source = image1;
                        bindingH.Path = new PropertyPath("ActualHeight");
                        inkVisual.SetBinding(DrawingVisualInk.HeightProperty, bindingH);
                        grid1.Children.Add(inkVisual);
                        Grid.SetRow(inkVisual, 0);

                    }
                    if (image1.Parent is Grid grid2)
                    {
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
                                if ((bool)ImageViewState.toolTop.DimensionChecked)
                                {

                                    if (!inkVisual.inkCanvas.Strokes.Contains(inkMethod.Dimstroke))
                                    {
                                        double w = inkVisual.ActualWidth;
                                        double h = inkVisual.ActualHeight;
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
                                    else
                                    {
                                        inkVisual.inkCanvas.Strokes.Remove(inkMethod.Dimstroke);
                                        inkVisual.inkCanvas.Strokes.Remove(inkMethod.Textstroke);
                                        double w = inkVisual.ActualWidth;
                                        double h = inkVisual.ActualHeight;
                                        Point iniP = new Point(w * 19 / 20, h * 19 / 20);
                                        Point endP = new Point(w * 19 / 20 - w * 100 * inkVisual.ratio / 1689.12, h * 19 / 20);
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



                        if (image1.Parent is Grid grid3)
                        {
                            WrapPanel topToolbar = (WrapPanel)mainwin.FindName("topToolbar");
                            if (topToolbar == null)
                                return;
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
                                        if (inkMethod.Dimstroke != null)
                                        {
                                            inkVisual.inkCanvas.Strokes.Add(inkMethod.Dimstroke);
                                            inkVisual.inkCanvas.Strokes.Add(inkMethod.Textstroke);
                                        }
                                       

                                        inkVisual.saveTempStroke = false;
                                    }
                                    Point curPoint = new Point(inkVisual.ActualWidth / 2, inkVisual.ActualHeight / 2);

                                    Matrix matrix = new Matrix();
                                    matrix.ScaleAt(1.2, 1.2, curPoint.X, curPoint.Y);
                                    inkVisual.inkCanvas.Strokes.Transform(matrix, false);
                                    inkVisual.ZoomInOut++;
                                    inkVisual.ratio = inkVisual.ratio * 1.2;

                                    if (inkVisual.inkCanvas.Strokes.Contains(inkMethod.Dimstroke))
                                    {
                                        inkVisual.inkCanvas.Strokes.Remove(inkMethod.Dimstroke);
                                        inkVisual.inkCanvas.Strokes.Remove(inkMethod.Textstroke);
                                        double w = inkVisual.ActualWidth;
                                        double h = inkVisual.ActualHeight;
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
                                if (inkVisual.ZoomInOut > 0)
                                {
                                    if (inkVisual.saveTempStroke && inkVisual.inkCanvas.Strokes.Count > 0)
                                    {
                                        if (inkVisual.inkCanvas.Strokes.Contains(inkMethod.Dimstroke))
                                        {
                                            inkVisual.inkCanvas.Strokes.Remove(inkMethod.Dimstroke);
                                            inkVisual.inkCanvas.Strokes.Remove(inkMethod.Textstroke);

                                        }

                                        inkVisual.tempStroke = inkVisual.inkCanvas.Strokes.Clone();
                                        if (inkMethod.Dimstroke != null)
                                        {
                                            inkVisual.inkCanvas.Strokes.Add(inkMethod.Dimstroke);
                                            inkVisual.inkCanvas.Strokes.Add(inkMethod.Textstroke);
                                        }

                                        inkVisual.saveTempStroke = false;
                                    }
                                    Point curPoint = new Point(inkVisual.ActualWidth / 2, inkVisual.ActualHeight / 2);

                                    Matrix matrix = new Matrix();

                                    matrix.ScaleAt(1 / 1.2, 1 / 1.2, curPoint.X, curPoint.Y);
                                    inkVisual.inkCanvas.Strokes.Transform(matrix, false);
                                    inkVisual.ZoomInOut--;
                                    inkVisual.ratio = inkVisual.ratio / 1.2;

                                    if (inkVisual.inkCanvas.Strokes.Contains(inkMethod.Dimstroke))
                                    {
                                        inkVisual.inkCanvas.Strokes.Remove(inkMethod.Dimstroke);
                                        inkVisual.inkCanvas.Strokes.Remove(inkMethod.Textstroke);
                                        double w = inkVisual.ActualWidth;
                                        double h = inkVisual.ActualHeight;
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
                               if (inkVisual.saveTempStroke)
                                    return;
                                if (inkVisual.inkCanvas.Strokes.Contains(inkMethod.Dimstroke))
                                {
                                    inkVisual.tempStroke.Add(inkMethod.Dimstroke);
                                }

                                inkVisual.inkCanvas.Strokes.Clear();
                                inkVisual.inkCanvas.Strokes.Add(inkVisual.tempStroke);
                                inkVisual.saveTempStroke = true;
                                inkVisual.ZoomInOut = 0;
                                inkVisual.ratio = 1;
                                if (inkVisual.inkCanvas.Strokes.Contains(inkMethod.Dimstroke))
                                {
                                    inkVisual.inkCanvas.Strokes.Remove(inkMethod.Dimstroke);
                                    inkVisual.inkCanvas.Strokes.Remove(inkMethod.Textstroke);
                                    double w = inkVisual.ActualWidth;
                                    double h = inkVisual.ActualHeight;
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
                        if (image1.Parent is Grid grid4)
                        {
                            DrawMethod drawMethod = new DrawMethod();
                            DrawingVisualInk drawingVisualInk = new DrawingVisualInk(ImageViewState.toolTop, drawMethod);
                            drawingCanvasInk[viewindex] = drawingVisualInk;

                            Binding bindingW = new Binding();
                            bindingW.Source = image1;
                            bindingW.Path = new PropertyPath("ActualWidth");
                            drawingVisualInk.SetBinding(DrawingVisualInk.WidthProperty, bindingW);

                            Binding bindingH = new Binding();
                            bindingH.Source = image1;
                            bindingH.Path = new PropertyPath("ActualHeight");
                            drawingVisualInk.SetBinding(DrawingVisualInk.HeightProperty, bindingH);
                            drawingVisualInk.Visibility = Visibility.Collapsed;
                            grid4.Children.Add(drawingVisualInk);
                            Grid.SetRow(drawingVisualInk, 0);

                            ImageViewState.toolTop.PropertyChanged += delegate (object? sender, PropertyChangedEventArgs e)
                            {
                                if (e.PropertyName == "SelectChecked")
                                {

                                    if (ImageViewState.toolTop.SelectChecked == true)
                                    {
                                        drawingVisualInk.Visibility = Visibility.Visible;
                                        if (!drawingVisualInk.InkCanvas.visuals.Contains(drawMethod.pixelVisual))
                                        {
                                            drawMethod.pixelVisual = new DrawingVisual();
                                            drawingVisualInk.InkCanvas.AddVisual(drawMethod.pixelVisual);
                                           
                                        }                                          
                                            ;
                                       

                                    }
                                    else
                                    {
                                        drawingVisualInk.Visibility = Visibility.Collapsed;
                                        if (drawingVisualInk.InkCanvas.visuals.Contains(drawMethod.pixelVisual))
                                            drawingVisualInk.InkCanvas.DeleteVisual(drawMethod.pixelVisual);
                                       
                                    }
                                }
                            };

                           drawingVisualInk.InkCanvas.MouseMove += delegate (object sender, MouseEventArgs e)
                            {
                                if (ImageViewState.toolTop.SelectChecked)
                                {
                                    if (!drawingVisualInk.InkCanvas.visuals.Contains(drawMethod.pixelVisual))
                                    {
                                        drawMethod.pixelVisual = new DrawingVisual();
                                        drawingVisualInk.InkCanvas.AddVisual(drawMethod.pixelVisual);
                                    }
                                        
                                    WriteableBitmap writeableBitmap = image1.Source as WriteableBitmap;
                                    Point topLeftCorner = e.GetPosition(image1);
                                    try
                                    {
                                        if (topLeftCorner.Y < image1.ActualHeight - 130)
                                        {
                                            if (topLeftCorner.X < image1.ActualWidth - 120)
                                            {
                                                drawMethod.DrawPixelSquare(writeableBitmap, drawMethod.pixelVisual, topLeftCorner, image1.ActualWidth, image1.ActualHeight);
                                            }
                                            else
                                            {
                                                drawMethod.DrawPixelSquareLeft(writeableBitmap, drawMethod.pixelVisual, topLeftCorner, image1.ActualWidth, image1.ActualHeight);
                                            }

                                        }
                                        else if (topLeftCorner.Y >= image1.ActualHeight - 130)
                                        {
                                            if (topLeftCorner.X < image1.ActualWidth - 120)
                                            {

                                                drawMethod.DrawPixelSquareUp(writeableBitmap, drawMethod.pixelVisual, topLeftCorner, image1.ActualWidth, image1.ActualHeight);

                                            }
                                            else
                                            {
                                                drawMethod.DrawPixelSquareLeftUp(writeableBitmap, drawMethod.pixelVisual, topLeftCorner, image1.ActualWidth, image1.ActualHeight);
                                            }

                                        }

                                    }
                                    catch (Exception ex)
                                    {

                                    }

                                        //  image1.ReleaseMouseCapture();
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


                    }
                }




                catch (Exception ex)
                {

                }


               

                  


            }

        }
    }
}
  