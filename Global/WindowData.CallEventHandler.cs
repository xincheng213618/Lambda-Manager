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

namespace Global
{
    /// <summary>
    /// 监听CallEventHandler事件
    /// </summary>
    public partial class WindowData
    {
        public bool ACQUIRE { get; set; } = false;
        public bool ALIVE { get; set; } = false;

        static GridLengthConverter gridLengthConverter = new GridLengthConverter();
        private DrawMethod drawMethod = new DrawMethod();
        Window mainwin = Application.Current.MainWindow;

        public DrawingCanvas[] drawingCanvass = new DrawingCanvas[100];
        public double ratio =1;

        public async void AddImageConfident(Image image1, int viewindex)
        {
            // MessageBox.Show("1111");
            if (image1.Parent is Grid grid0)
            {


                DrawingCanvas image = new DrawingCanvas();
                drawingCanvass[viewindex] = image;

                if (image1.Parent is Grid grid1)
                {

                    PixelAnalysis pixelAnalysis = new PixelAnalysis();
                    StackPanel stackPanel = (StackPanel)mainwin.FindName("bottomView0");

                    pixelAnalysis.Height = Double.NaN;
                    pixelAnalysis.DataContext = histogramModel;

                    GridSplitter gridSplitter = (GridSplitter)grid1.Children[1];
                    gridSplitter.HorizontalAlignment = HorizontalAlignment.Stretch;
                    gridSplitter.VerticalAlignment = VerticalAlignment.Center;
                    Brush brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#444444"));
                    gridSplitter.Background = brush;
                    gridSplitter.Height = 3;
                    grid1.Children.Add(pixelAnalysis);
                    Grid.SetRow(pixelAnalysis, 2);


                    grid1.Children.Remove(stackPanel);

                    pixelAnalysis.Visibility = Visibility.Collapsed;

                    DockPanel leftToolBar = (DockPanel)mainwin.FindName("leftToolbar");
                    if (leftToolBar == null) return;
                    WrapPanel leftToolBarChild = (WrapPanel)leftToolBar.Children[0];
                    ToggleButton histogramTogg = (ToggleButton)leftToolBarChild.Children[3];
                    histogramTogg.Checked += delegate
                    {
                        grid1.RowDefinitions[2].Height = new GridLength(200, GridUnitType.Pixel);
                        pixelAnalysis.Visibility = Visibility.Visible;

                    };
                    histogramTogg.Unchecked += delegate
                    {
                        pixelAnalysis.Visibility = Visibility.Collapsed;
                        grid1.RowDefinitions[2].Height = new GridLength(0, GridUnitType.Pixel);

                    };

                    // grid1.Children.Remove(image1);
                    image.Visibility = Visibility.Collapsed;
                    grid1.Children.Add(image);
                    Grid.SetRow(image, 0);


                }

                if (image.Parent is Grid grid3)
                {

                    TextBox ratioN = (TextBox)mainwin.FindName("ratio");
                    string rat = ratioN.Text;
                    ratio = Convert.ToDouble(rat.Trim('%')) / 100;

                    image.MouseWheel += delegate (object sender, MouseWheelEventArgs e)
                    {
                        Point MousePoint = e.GetPosition(image);
                        if (e.Delta > 0)
                        {
                            Dictionary<string, object> parameters = new Dictionary<string, object>()
                            {
                            { "event",(int)10},
                            {"x",(int)MousePoint.X },
                            {"y",(int)MousePoint.Y },
                            {"flag",(int)1024 }

                            };
                            LambdaControl.Trigger("MOUSE_EVENT", null, parameters);
                           // ratio = ratio * 1.2;
                           // ration.Text = ratio.ToString("P");


                        }
                        else
                        {
                            Dictionary<string, object> parameters = new Dictionary<string, object>()
                            {
                            { "event",(int)10},
                            {"x",(int)MousePoint.X },
                            {"y",(int)MousePoint.Y },
                            {"flag",(int)-1024 }
                            };
                            LambdaControl.Trigger("MOUSE_EVENT", null, parameters);
                            //ratio = ratio * 0.8;
                           // ration.Text = ratio.ToString("P0");
                        }

                    };

                   

                    

                    ratioN.TextChanged += delegate (object sender, TextChangedEventArgs e)
                    {
                        List<Visual> visualsList = new List<Visual>();

                        foreach (var item in image.visuals)
                        {
                            visualsList.Add(item);
                        }

                        if (visualsList.Count > 0)
                        {
                            foreach (DrawingVisual visual in visualsList)
                            {
                                image.DeleteVisual(visual);
                            }
                            visualsList.Clear();
                        }


                        if (image.visuals.Count == 0 && ImageViewState.toolTop.DimensionChecked)
                        {
                            DrawingVisual dimDefaultVisual = new DrawingVisual();
                            image.AddVisual(dimDefaultVisual);
                            drawMethod.DrawDimension(image.ActualWidth, image.ActualHeight,ratio, new Point(0, 0), new Point(0, 0), true, dimDefaultVisual);
                        }




                    };






                    bool isMouseLeftButtonDown = false;
                    Point start, MouseStart, mouseXY;


                    ImageViewState.toolTop.PropertyChanged += delegate (object? sender, PropertyChangedEventArgs e)
                    {
                        image.Source = image1.Source;
                        image1.Visibility = Visibility.Collapsed;
                        image.Visibility = Visibility.Visible;
                        if (e.PropertyName == "PolygonChecked")
                        {
                            if (ImageViewState.toolTop.SelectChecked == false)
                            {
                                if (drawMethod.PolygonList.Count > 1)
                                {
                                    drawMethod.DrawingPoly(new Point(0, 0), true);
                                // PolygonList.Clear();
                            }
                                image.Cursor = Cursors.Arrow;
                            }
                            else
                            {
                                image.Cursor = Cursors.Cross;
                            }
                        }

                        if (e.PropertyName == "EraserChecked")
                        {
                            if (ImageViewState.toolTop.EraserChecked == true)
                            {
                                StreamResourceInfo sri = Application.GetResourceStream(new Uri("/Global;component/usercontrols/image/eraser.cur", UriKind.Relative));
                                image.Cursor = new Cursor(sri.Stream);
                            }
                            else
                            {
                                image.Cursor = Cursors.Arrow;
                            }
                        }
                        if (e.PropertyName == "SelectChecked")
                        {

                            if (ImageViewState.toolTop.SelectChecked == true)
                            {
                                if (!image.visuals.Contains(drawMethod.pixelVisual))
                                    image.AddVisual(drawMethod.pixelVisual);

                            }
                            else
                            {
                                if (image.visuals.Contains(drawMethod.pixelVisual))
                                    image.DeleteVisual(drawMethod.pixelVisual);
                            }
                        }
                        if (e.PropertyName == "DimensionChecked")
                        {
                            if (ImageViewState.toolTop.DimensionChecked == true)
                            {
                                DrawingVisual dimDefaultVisual = new DrawingVisual();
                                image.AddVisual(dimDefaultVisual);
                                drawMethod.DrawDimension(image.ActualWidth, image.ActualHeight, ratio, new Point(0, 0), new Point(0, 0), true, dimDefaultVisual);
                            }
                            else
                            {

                            }

                        }

                    };

                    Application.Current.MainWindow.PreviewKeyDown += delegate (object sender, KeyEventArgs e)
                    {
                        if (e.Key == Key.Escape && ImageViewState.toolTop.PolygonChecked)
                        {
                            if (drawMethod.PolygonList.Count > 1)
                            {
                                drawMethod.DrawingPoly(new Point(0, 0), true);

                            }
                        }
                    };

                    image.MouseLeftButtonDown += delegate (object sender, MouseButtonEventArgs e)
                    {
                        SelectImageView = viewindex;
                        image.Focus();
                        mouseXY = Mouse.GetPosition(Application.Current.MainWindow);
                        MouseStart = Mouse.GetPosition(image);

                        if (ImageViewState.toolTop.RectangleChecked)
                        {
                            isMouseLeftButtonDown = true;
                            drawMethod.RectangleVisual = new DrawingVisual();
                            image.AddVisual(drawMethod.RectangleVisual);
                            image.CaptureMouse();
                        }
                        else if (ImageViewState.toolTop.CircleChecked)
                        {
                            isMouseLeftButtonDown = true;
                            drawMethod.circleVisual = new DrawingVisual();
                            image.AddVisual(drawMethod.circleVisual);
                            image.CaptureMouse();
                        }
                        else if (ImageViewState.toolTop.LineChecked)
                        {
                            isMouseLeftButtonDown = true;
                            drawMethod.LineVisual = new DrawingVisual();
                            image.AddVisual(drawMethod.LineVisual);
                            image.CaptureMouse();
                        }

                        else if (ImageViewState.toolTop.ArrowChecked)
                        {
                            isMouseLeftButtonDown = true;
                            drawMethod.arrowVisual = new DrawingVisual();

                            image.AddVisual(drawMethod.arrowVisual);
                            image.CaptureMouse();

                        }
                        else if (ImageViewState.toolTop.EraserChecked == true)
                        {
                            isMouseLeftButtonDown = true;
                            DrawingVisual visual = image.GetVisual(MouseStart);
                            if (visual != null)
                            {
                                image.DeleteVisual(visual);

                            }
                            else
                            {
                                drawMethod.deleteVisual = new DrawingVisual();
                                image.AddVisual(drawMethod.deleteVisual);

                                image.CaptureMouse();
                            }
                        }

                        else if (ImageViewState.toolTop.DimensionChecked == true)
                        {
                            Application.Current.MainWindow.Cursor = Cursors.Cross;
                            isMouseLeftButtonDown = true;
                            drawMethod.dimensionVisual = new DrawingVisual();
                            image.AddVisual(drawMethod.dimensionVisual);
                            image.CaptureMouse();

                        }
                        else if (ImageViewState.toolTop.TextChecked == true)
                        {
                            DrawingVisual visual = image.GetVisual(MouseStart);
                            if (visual != null)
                            {

                                if (visual.Transform != null && visual.Transform is TranslateTransform translate1)
                                {
                                    drawMethod.translateOri = new Point(translate1.X, translate1.Y);
                                }
                                else
                                {
                                    TranslateTransform translate = new TranslateTransform();
                                    visual.Transform = translate;
                                    drawMethod.translateOri = new Point(translate.X, translate.Y);
                                }

                                drawMethod.isDragging = true;
                                drawMethod.selectedVisual = visual;
                            }



                        }

                        else if (ImageViewState.toolTop.PolygonChecked)
                        {
                            if (drawMethod.PolygonList.Count == 0)
                            {
                                drawMethod.polygonVisual = new DrawingVisual();
                                image.AddVisual(drawMethod.polygonVisual);
                                drawMethod.DrawingPoly(MouseStart, false);

                            }
                            else
                            {
                                drawMethod.DrawingPoly(MouseStart, false);
                            }

                        }



                        else
                        {
                            isMouseLeftButtonDown = true;
                            Dictionary<string, object> parameters = new Dictionary<string, object>()
                            {
                            {"event",(int)1},
                            {"x",(int)MouseStart.X },
                            {"y",(int)MouseStart.Y },
                            {"flag",(int)1 }

                            };
                            LambdaControl.Trigger("MOUSE_EVENT", null, parameters);

                        }
                    };

                    image.MouseLeftButtonUp += delegate (object sender, MouseButtonEventArgs e)
                    {
                        if (isMouseLeftButtonDown)
                        {
                            isMouseLeftButtonDown = false;
                            drawMethod.isDragging = false;
                            Application.Current.MainWindow.Cursor = Cursors.Arrow;
                            // 清除绘制超出边界的绘制元素
                            List<DrawingVisual> visualsList = new List<DrawingVisual>();

                            foreach (var item in image.visuals)
                            {
                                visualsList.Add(item);
                            }

                            if (visualsList.Count > 0)
                            {
                                foreach (DrawingVisual visual in visualsList)
                                {
                                    if(visual.ContentBounds.BottomRight.X>image.ActualWidth|| visual.ContentBounds.BottomRight.Y>image.ActualHeight || visual.ContentBounds.BottomLeft.X<0|| visual.ContentBounds.BottomLeft.Y>image.ActualHeight)

                                    image.DeleteVisual(visual);
                                    if (visual.ContentBounds.TopRight.X > image.ActualWidth || visual.ContentBounds.TopRight.Y < 0 || visual.ContentBounds.TopLeft.X < 0 || visual.ContentBounds.TopLeft.Y <0)
                                    image.DeleteVisual(visual);


                                }
                                visualsList.Clear();
                            }



                        }
                        if (ImageViewState.toolTop.EraserChecked)
                        {
                        // Display all the squares in this region.
                        RectangleGeometry geometry = new RectangleGeometry(
                                new Rect(MouseStart, e.GetPosition(image)));
                            List<DrawingVisual> visualsInRegion = new List<DrawingVisual>();
                            Point destPoint = e.GetPosition(image);

                            if (geometry.Rect.Width > 0)
                            {
                                if (MouseStart.X < destPoint.X && MouseStart.Y < destPoint.Y)
                                {
                                    visualsInRegion =
                                     image.GetVisuals(geometry);
                                }
                                else
                                {
                                    visualsInRegion =
                                    image.GetVisualsRev(geometry);
                                }
                                foreach (DrawingVisual visual in visualsInRegion)
                                {
                                    image.DeleteVisual(visual);
                                }

                            }


                            image.DeleteVisual(drawMethod.deleteVisual);
                            image.ReleaseMouseCapture();
                        }


                        image.ReleaseMouseCapture();
                    };

                    image.MouseMove += delegate (object sender, MouseEventArgs e)
                    {
                        if (isMouseLeftButtonDown == true)
                        {
                            Point position = Mouse.GetPosition(Application.Current.MainWindow);
                            Point mousePoint = Mouse.GetPosition(image);


                            if (ImageViewState.toolTop.RectangleChecked)
                            {

                                drawMethod.DrawSelectionSquare(MouseStart, mousePoint);

                            }
                            else if (ImageViewState.toolTop.DimensionChecked)
                            {
                                drawMethod.DrawDimension(image.ActualWidth, image.ActualHeight, ratio, MouseStart, mousePoint, false, drawMethod.dimensionVisual);

                            }

                            else if (ImageViewState.toolTop.CircleChecked)
                            {
                                //if (mousePoint.X<image.ActualWidth&& mousePoint.Y < image.ActualHeight)
                                //{
                                //    drawMethod.DrawEllipse(MouseStart, mousePoint);
                                //}
                                drawMethod.DrawEllipse(MouseStart, mousePoint);

                           



                            }
                            else if (ImageViewState.toolTop.EraserChecked)
                            {
                                drawMethod.DrawDeleteSquare(MouseStart, mousePoint);

                            }
                            else if (drawMethod.isDragging)
                            {
                                if (drawMethod.selectedVisual.Transform is TranslateTransform translate)
                                {
                                    translate.X = drawMethod.translateOri.X + mousePoint.X - MouseStart.X;
                                    translate.Y = drawMethod.translateOri.Y + mousePoint.Y - MouseStart.Y;
                                }

                            }
                            else if (ImageViewState.toolTop.LineChecked)
                            {
                                drawMethod.DrawLine(MouseStart, mousePoint);

                            }
                            else if (ImageViewState.toolTop.ArrowChecked)
                            {
                                drawMethod.DrawArrow(MouseStart, mousePoint);

                            }
                            else if (ImageViewState.toolTop.MoveChecked)
                            {
                                Application.Current.MainWindow.Cursor = Cursors.Hand;
                            }


                            Dictionary<string, object> parameters = new Dictionary<string, object>()
                              {
                            { "event",(int)0},
                            {"x",(int)mousePoint.X },
                            {"y",(int)mousePoint.Y },
                            {"flag",(int)1 }

                                 };
                            LambdaControl.Trigger("MOUSE_EVENT", null, parameters);
                        }
                        else
                        {


                            if (ImageViewState.toolTop.SelectChecked)
                            {
                                if (!image.visuals.Contains(drawMethod.pixelVisual))
                                    image.AddVisual(drawMethod.pixelVisual);
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

                                image.ReleaseMouseCapture();
                            }
                            if (ImageViewState.toolTop.MoveChecked)
                            {
                                Application.Current.MainWindow.Cursor = Cursors.Hand;
                            }

                        }

                    };

                    image.MouseEnter += delegate (object sender, MouseEventArgs e)
                    {

                    };

                    image.SizeChanged += delegate (object sender, SizeChangedEventArgs e)
                    {


                        List< DrawingVisual> visualsList = new List<DrawingVisual>();

                        foreach (var item in image.visuals)
                        {
                            visualsList.Add(item);
                        }

                        if (visualsList.Count > 0)
                        {
                            foreach (DrawingVisual visual in visualsList)
                            {
                                image.DeleteVisual(visual);
                            }
                            visualsList.Clear();
                        }

                    
                    if (image.visuals.Count == 0&& ImageViewState.toolTop.DimensionChecked)
                        {
                            DrawingVisual dimDefaultVisual = new DrawingVisual();
                            image.AddVisual(dimDefaultVisual);
                            drawMethod.DrawDimension(image.ActualWidth, image.ActualHeight, ratio, new Point(0, 0), new Point(0, 0), true, dimDefaultVisual);
                        }


                    };

                    image.MouseLeave += delegate (object sender, MouseEventArgs e)
                    {
                        if (isMouseLeftButtonDown)
                        {
                            isMouseLeftButtonDown = false;
                        }
                        image.ReleaseMouseCapture();
                        Application.Current.MainWindow.Cursor = Cursors.Arrow;
                    };

                };



            }

        }
    }
}
  