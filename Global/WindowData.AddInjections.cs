using Global.UserControls.DrawVisual;
using Global.UserControls.SeriesMap;
using Lambda;
using System;
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
    public partial class WindowData
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
                InkVisual inkVisual = new InkVisual(0,image,ImageViewState.toolTop, inkMethod);
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
               
                ImageViewState.toolTop.PropertyChanged += delegate (object? sender, PropertyChangedEventArgs e)
                {
                    // MessageBox.Show("1111");
                    if (e.PropertyName == "FocusChecked")
                    {
                        //if (ImageViewState.toolTop.FocusChecked)
                        //{
                        //    inkVisuals[0].inkCanvas.EditingMode = InkCanvasEditingMode.Select;
                        //}
                        //else
                        //{
                        //    inkVisuals[0].inkCanvas.EditingMode = InkCanvasEditingMode.None;
                        //}


                    }

                    else if (e.PropertyName == "EraserChecked")
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





                    else if ( (bool)ImageViewState.toolTop.ArrowChecked || (bool)ImageViewState.toolTop.CircleChecked || (bool)ImageViewState.toolTop.CurveChecked || (bool)ImageViewState.toolTop.PolygonChecked || (bool)ImageViewState.toolTop.TextChecked || (bool)ImageViewState.toolTop.LineChecked || (bool)ImageViewState.toolTop.RectangleChecked)
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


                inkVisual.inkCanvas.MouseLeave += delegate (object sender, MouseEventArgs e)
                {
                    
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
                        inkVisual.ratio1.Ratio = inkVisual.ratio1.Ratio * 1.2;
                        
                        string position = DrawInkMethod.defdimenViewModel.DimPos;
                        double length = DrawInkMethod.defdimenViewModel.Length;
                        inkVisual.drawDefaultDim(position, length, Colors.AliceBlue, inkVisual.ratio1.Ratio);
                       

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
                        inkVisual.ratio1.Ratio = inkVisual.ratio1.Ratio / 1.2;

                        string position = DrawInkMethod.defdimenViewModel.DimPos;
                        double length = DrawInkMethod.defdimenViewModel.Length;
                        inkVisual.drawDefaultDim(position, length, Colors.AliceBlue, inkVisual.ratio1.Ratio);

                        
                       
                    };
              };
                ScaleButton.Click += delegate
                {
                    //register markerDrawing

                    if (!inkVisual.saveTempStroke)
                    {
                        if (inkVisual.inkCanvas.Strokes.Contains(inkMethod.Dimstroke))
                        {
                            inkVisual.tempStroke.Add(inkMethod.Dimstroke);
                        }

                        inkVisual.inkCanvas.Strokes.Clear();
                        if (inkVisual.tempStroke != null)
                        {
                            inkVisual.inkCanvas.Strokes.Add(inkVisual.tempStroke);
                        }
                        inkVisual.tempStroke = null;
                        inkVisual.saveTempStroke = true;
                        inkVisual.ZoomInOut = 0;
                        inkVisual.ratio1.Ratio = 1;
                      


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
                        MapWindow mapWindow = new MapWindow();
                        Point point= bottomPlace.PointToScreen(new Point(0, 0));
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
                        double x = point.X/ dpixRatio + bottomPlace.ActualWidth - mapWindow.ActualWidth;
                        double y = point.Y/ dpiyRatio - mapWindow.ActualHeight - 3;
                        mapWindow.Left = x;
                        mapWindow.Top = y;
                        mapWindow.DrawPointRec(mapWindow.SeriesPoints);

                        mainwin.Closing += delegate
                        {
                            mapWindow.Close();
                        };

                    }
                   

                };



            }
            catch (Exception ex)
            {
                LambdaControl.Log(new Message() { Severity = Severity.ERROR, Text = ex.Message });
            }



        }
    }
    }
