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
        public DrawInkMethod inkMethod = new DrawInkMethod();
        Window mainwin = Application.Current.MainWindow;
        public InkVisual[] inkVisuals = new InkVisual[100];
        public void AddImageConfident(Image image1, int viewindex)
        {
            DrawInkMethod inkMethod = new DrawInkMethod();
            InkVisual inkVisual = new InkVisual(viewindex, image1, ImageViewState.toolTop, inkMethod);
            if (image1.Parent is Grid grid0)
            {
                try
                {
                    inkVisuals[viewindex] = inkVisual;
                    if (ViewContentMenuCache.ContainsKey(viewindex))
                        AddViewContentMenu(viewindex, ViewContentMenuCache[viewindex]);
                    if (image1.Parent is Grid grid1)
                    {
                        Binding bindingW = new Binding();
                        bindingW.Source = image1;
                        bindingW.Path = new PropertyPath("ActualWidth");
                        inkVisual.SetBinding(Image.WidthProperty, bindingW);
                        Binding bindingH = new Binding();
                        bindingH.Source = image1;
                        bindingH.Path = new PropertyPath("ActualHeight");
                        inkVisual.SetBinding(Image.HeightProperty, bindingH);
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
                            else if ((bool)ImageViewState.toolTop.ArrowChecked || (bool)ImageViewState.toolTop.CircleChecked || (bool)ImageViewState.toolTop.CurveChecked || (bool)ImageViewState.toolTop.PolygonChecked || (bool)ImageViewState.toolTop.TextChecked || (bool)ImageViewState.toolTop.LineChecked || (bool)ImageViewState.toolTop.RectangleChecked)
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
                                        inkVisual.tempStroke = inkVisual.inkCanvas.Strokes.Clone();
                                        inkVisual.saveTempStroke = false;
                                    }
                                    Point curPoint = new Point(inkVisual.ActualWidth / 2, inkVisual.ActualHeight / 2);

                                    Matrix matrix = new Matrix();
                                    matrix.ScaleAt(1.2, 1.2, curPoint.X, curPoint.Y);
                                    inkVisual.inkCanvas.Strokes.Transform(matrix, false);
                                    inkVisual.ZoomInOut++;
                                    inkVisual.ratio1.Ratio = inkVisual.ratio1.Ratio * 1.2;

                                };

                            };
                            ToggleButtonZoomIn.Click += delegate
                            {
                                if (inkVisual.ZoomInOut > 0)
                                {
                                    if (inkVisual.saveTempStroke && inkVisual.inkCanvas.Strokes.Count > 0)
                                    {

                                        inkVisual.tempStroke = inkVisual.inkCanvas.Strokes.Clone();
                                        inkVisual.saveTempStroke = false;
                                    }
                                    Point curPoint = new Point(inkVisual.ActualWidth / 2, inkVisual.ActualHeight / 2);

                                    Matrix matrix = new Matrix();

                                    matrix.ScaleAt(1 / 1.2, 1 / 1.2, curPoint.X, curPoint.Y);
                                    inkVisual.inkCanvas.Strokes.Transform(matrix, false);
                                    inkVisual.ZoomInOut--;
                                    inkVisual.ratio1.Ratio = inkVisual.ratio1.Ratio / 1.2;
                                };
                            };
                            ScaleButton.Click += delegate
                            {
                                if (inkVisual.saveTempStroke)
                                    return;
                                inkVisual.inkCanvas.Strokes.Clear();
                                inkVisual.inkCanvas.Strokes.Add(inkVisual.tempStroke);
                                inkVisual.saveTempStroke = true;
                                inkVisual.ZoomInOut = 0;
                                inkVisual.ratio1.Ratio = 1;

                            };
                        }

                   }
                }
                catch (Exception ex)
                {
                    LambdaControl.Log(new Message() { Severity = Severity.ERROR, Text = ex.Message });
                }

            }

        }
    }
}
