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
using System.Windows.Resources;

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
        //private Pixel pixel = new Pixel();

        public async void AddImageConfident(Image image1,int viewindex)
        {

            if (image1.Parent is Grid grid)
            {
                grid.RowDefinitions.Clear();
                grid.RowDefinitions.Add(new RowDefinition() { Height = (GridLength)gridLengthConverter.ConvertFrom("*") });
                for (int i = 0; i < 1; i++)
                {
                    RowDefinition rowDefinition = new RowDefinition() { Height = GridLength.Auto};
                    grid.RowDefinitions.Add(rowDefinition);
                }
             
                grid.Children.Clear();

                Grid.SetRow(image1, 0);
                grid.Children.Add(image1);

                Grid stackPanel = new Grid() ;
                Grid.SetRow(stackPanel, 1);

                double height = 100;

                BottomView bottomView = new BottomView();
                bottomView.SizeChanged += delegate
                {
                    height = bottomView.ActualHeight;
                };
                bottomView.IsVisibleChanged += delegate
                {
                    if (bottomView.Visibility == Visibility.Collapsed)
                    {
                        grid.RowDefinitions.Clear();
                        grid.RowDefinitions.Add(new RowDefinition() { Height = (GridLength)gridLengthConverter.ConvertFrom("*") });
                        for (int i = 0; i < 1; i++)
                        {
                            RowDefinition rowDefinition = new RowDefinition() { Height = GridLength.Auto };
                            grid.RowDefinitions.Add(rowDefinition);
                        }
                    }
                    else
                    {
                        grid.RowDefinitions.Clear();
                        grid.RowDefinitions.Add(new RowDefinition() { Height = (GridLength)gridLengthConverter.ConvertFrom("*") });
                        for (int i = 0; i < 1; i++)
                        {
                            RowDefinition rowDefinition = new RowDefinition() { Height = new GridLength(height) };
                            grid.RowDefinitions.Add(rowDefinition);
                        }
                    }
                };

                bottomView.Visibility = Visibility.Visible; 
                stackPanel.Children.Add(bottomView);

                LambdaBottomViews[viewindex] = bottomView;

                GridSplitter gridSplitter = new GridSplitter() { Height = 2,Background= new SolidColorBrush(Color.FromRgb(68, 68, 68)), ResizeDirection = GridResizeDirection.Rows, HorizontalAlignment = HorizontalAlignment.Stretch, VerticalAlignment = VerticalAlignment.Bottom};
                Grid.SetRow(gridSplitter, 0);
                Binding binding = new Binding("Visibility");
                binding.Source = bottomView;
                gridSplitter.SetBinding(GridSplitter.VisibilityProperty, binding);

                grid.Children.Add(gridSplitter);
                grid.Children.Add(stackPanel);
            }

            await Task.Delay(1000);
            DrawingCanvas image = new DrawingCanvas();

            image.Source = image1.Source;
            if (image1.Parent is Grid grid1)
            {
                grid1.Children.Remove(image1);
                grid1.Children.Add(image);
            }
            image.SizeChanged += delegate (object sender, SizeChangedEventArgs e)
            {
                LambdaControl.Trigger("ActualSize", this, new Dictionary<string, object>() { { "Hight", image.ActualHeight }, { "Width", image.ActualWidth } });
            };


            if (image.Parent is Grid grid3)
            {
                await Task.Delay(100);
                DrawingVisual dimDefaultVisual = new DrawingVisual();
                image.AddVisual(dimDefaultVisual);
                drawMethod.DrawDimension(image.ActualWidth, image.ActualHeight, new Point(0, 0), new Point(0, 0), true, dimDefaultVisual);


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
                    }

                };
                bool isMouseLeftButtonDown = false;
                Point start, MouseStart, mouseXY;
                

                ImageViewState.toolTop.PropertyChanged += delegate(object? sender, PropertyChangedEventArgs e)
                {
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
                           // pixel.Show();
                        
                        }
                        else
                        {
                           // pixel.Close();
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
                    // start = new Point(tlt.X, tlt.Y);
                    if (ImageViewState.toolTop.MoveChecked)
                    {
                        isMouseLeftButtonDown = true;
                        Application.Current.MainWindow.Cursor = Cursors.Hand;
                    }
                    else if (ImageViewState.toolTop.RectangleChecked)
                    {
                        isMouseLeftButtonDown = true;
                        drawMethod.RectangleVisual = new DrawingVisual();
                        image.AddVisual(drawMethod.RectangleVisual);
                    }
                    else if (ImageViewState.toolTop.CircleChecked)
                    {
                        isMouseLeftButtonDown = true;
                        drawMethod.circleVisual = new DrawingVisual();
                        image.AddVisual(drawMethod.circleVisual);
                    }
                    else if (ImageViewState.toolTop.LineChecked)
                    {
                        isMouseLeftButtonDown = true;
                        drawMethod.LineVisual = new DrawingVisual();
                        image.AddVisual(drawMethod.LineVisual);
                    }

                    else if (ImageViewState.toolTop.ArrowChecked)
                    {
                        isMouseLeftButtonDown = true;
                        drawMethod.arrowVisual = new DrawingVisual();

                        image.AddVisual(drawMethod.arrowVisual);

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
                            //PointMoveOri = MouseStart;
                            //CanMove = true;
                            image.CaptureMouse();
                        }
                    }

                    else if (ImageViewState.toolTop.DimensionChecked == true)
                    {
                        Application.Current.MainWindow.Cursor = Cursors.Cross;
                        isMouseLeftButtonDown = true;
                        drawMethod.dimensionVisual = new DrawingVisual();
                        image.AddVisual(drawMethod.dimensionVisual);
                        // drawMethod.DrawScale(MouseStart);


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
                        Application.Current.MainWindow.Cursor = Cursors.Cross;
                    }
                };
                image.MouseLeftButtonUp += delegate (object sender, MouseButtonEventArgs e)
                {
                    if (isMouseLeftButtonDown)
                    {
                        isMouseLeftButtonDown = false;
                        drawMethod.isDragging = false;
                        Application.Current.MainWindow.Cursor = Cursors.Arrow;
                    }
                    if (ImageViewState.toolTop.EraserChecked)
                    {
                        // Display all the squares in this region.
                        RectangleGeometry geometry = new RectangleGeometry(
                            new Rect(MouseStart, e.GetPosition(image)));
                        List<DrawingVisual> visualsInRegion = new List<DrawingVisual>();
                        Point destPoint = e.GetPosition(image);
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

                        // MessageBox.Show(String.Format("You selected {0 } drawingVisual(s).", visualsInRegion.Count));

                        foreach (DrawingVisual visual in visualsInRegion)
                        {
                            image.DeleteVisual(visual);
                        }
                        //  isMultiSelecting = false;
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

                        //if (ImageViewState.toolTop.MoveChecked)
                        //{
                        //    //tlt.X = start.X + position.X - mouseXY.X;
                        //    //tlt.Y = start.Y + position.Y - mouseXY.Y;
                        //}
                        //else
                        if (ImageViewState.toolTop.RectangleChecked)
                        {
                            
                            drawMethod.DrawSelectionSquare(MouseStart, mousePoint);
                            return;

                        }
                        else if (ImageViewState.toolTop.DimensionChecked)
                        {
                            drawMethod.DrawDimension(image.ActualWidth, image.ActualHeight, MouseStart, mousePoint,false,drawMethod.dimensionVisual);
                            return;
                        }

                        else if (ImageViewState.toolTop.CircleChecked)
                        {
                            drawMethod.DrawEllipse(MouseStart, mousePoint);
                            return;

                        }
                        else if (ImageViewState.toolTop.EraserChecked)
                        {
                            drawMethod.DrawDeleteSquare(MouseStart, mousePoint);
                            return;
                        }
                        else if (drawMethod.isDragging)
                        {
                            if (drawMethod.selectedVisual.Transform is TranslateTransform translate)
                            {
                                translate.X = drawMethod.translateOri.X + mousePoint.X - MouseStart.X;
                                translate.Y = drawMethod.translateOri.Y + mousePoint.Y - MouseStart.Y;
                            }
                            return;
                        }
                        else if (ImageViewState.toolTop.LineChecked)
                        {
                            drawMethod.DrawLine(MouseStart, mousePoint);
                            return;
                        }
                        else if (ImageViewState.toolTop.ArrowChecked)
                        {
                            drawMethod.DrawArrow(MouseStart, mousePoint);
                            return;
                        }
                        else if (ImageViewState.toolTop.SelectChecked)
                        {
                            return;
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
                        Point mousePoint = Mouse.GetPosition(image);
                        if (ImageViewState.toolTop.SelectChecked)
                        {
                            //System.Drawing.Color color = new System.Drawing.Color();
                            //color = DrawingCanvas.GetPixelColor((int)mousePoint.X,(int)mousePoint.Y);
                            //pixel.textBlockXY.Text = mousePoint.ToString();
                            //pixel.textBlockRGB.Text = color.ToString();
                        }

                    }

                };

                image.MouseEnter += delegate (object sender, MouseEventArgs e)
                {
                   
                };

                image.SizeChanged += delegate (object sender, SizeChangedEventArgs e)
                {
 
                    RectangleGeometry geometry = new RectangleGeometry(
                    new Rect(new Point(0,0), new Point(image.ActualWidth,image.ActualHeight)));
                    List<DrawingVisual> visualsInRegion = new List<DrawingVisual>();
                    visualsInRegion =image.GetVisuals(geometry);
                    foreach (DrawingVisual visual in visualsInRegion)
                    {
                        image.DeleteVisual(visual);
                    }
                    Task.Delay(100);
                    if (image.visuals.Count==0 && image.ActualWidth>500)
                    {
                        DrawingVisual dimDefaultVisual = new DrawingVisual();
                        image.AddVisual(dimDefaultVisual);
                        drawMethod.DrawDimension(image.ActualWidth, image.ActualHeight, new Point(0, 0), new Point(0, 0), true, dimDefaultVisual);
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
  