using ConfigBottomView;
using Global.Mode;
using Lambda;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
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
        List<ImageParameter> imageParameters = new List<ImageParameter>();
        public async void AddImageConfident(Image image1,int viewindex)
        {
            Canvas canvas1;
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


                canvas1 = new Canvas()
                {
                    Background = new SolidColorBrush(Color.FromRgb(68, 68, 68)),
                    ClipToBounds = true
                };
                canvas1.MouseLeftButtonDown += delegate
                {
                    if (IsSelectImageView)
                        SelectImageView = viewindex;
                };

                grid.Children.Remove(image1);
                Grid.SetRow(image1, 0);
                grid.Children.Add(image1);

                //Grid.SetRow(canvas1, 0);
                //canvas1.Children.Add(image1);
                //grid.Children.Add(canvas1);


                Grid stackPanel = new Grid() ;
                Grid.SetColumn(stackPanel, 0);
                Grid.SetRow(stackPanel, 1);

                //Assembly assembly = Assembly.LoadFile(Environment.CurrentDirectory + "\\" + "ConfigBottomView");
                //Control control = (Control)assembly.CreateInstance($"ConfigBottomView.BottomView");
                double height = 150;
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

            await Task.Delay(1200);
            DrawingCanvas image = new DrawingCanvas();
            image.Source = image1.Source;
            //if (image1.Parent is Canvas canvas2)
            //{
            //    canvas2.Children.Remove(image1);
            //    canvas2.Children.Add(image);
            //}
            if (image1.Parent is Grid canvas2)
            {
                canvas2.Children.Remove(image1);
                canvas2.Children.Add(image);
            }

            if (image.Parent is Canvas canvas)
            {
                ImageParameter imageParameter = new ImageParameter();
                imageParameters.Add(imageParameter);
                image.DataContext = imageParameter;
                imageParameter.PropertyChanged += delegate (object? sender, PropertyChangedEventArgs e)
                {
                    if (e.PropertyName == "ScaleTransformScaleX")
                    {
                        Dictionary<string, object> parameters = new Dictionary<string, object>()
                        {
                            { "image",viewindex},
                            {"scaletransformcenterx",imageParameter.ScaleTransformCenterX },
                            {"scaletransformcentery",imageParameter.ScaleTransformCenterY },
                            {"scaletransformscalex",imageParameter.ScaleTransformScaleX },
                            {"scaletransformscaley",imageParameter.ScaleTransformScaleY }
                        };
                        LambdaControl.Trigger("IMAGE_SCALE", null, parameters);
                    }
                };

                TransformGroup transformGroup = new();
                TranslateTransform tlt = new();
                ScaleTransform sfr = new();
                BindingOperations.SetBinding(sfr, ScaleTransform.CenterXProperty, new Binding("ScaleTransformCenterX"));
                BindingOperations.SetBinding(sfr, ScaleTransform.CenterYProperty, new Binding("ScaleTransformCenterY"));
                BindingOperations.SetBinding(sfr, ScaleTransform.ScaleXProperty, new Binding("ScaleTransformScaleX"));
                BindingOperations.SetBinding(sfr, ScaleTransform.ScaleYProperty, new Binding("ScaleTransformScaleY"));


                transformGroup.Children.Add(sfr);
                transformGroup.Children.Add(tlt);
                image.RenderTransform = transformGroup;

                image.MouseWheel += delegate (object sender, MouseWheelEventArgs e)
                {
                    if (((sfr.ScaleX < 0.2 || sfr.ScaleY < 0.2) && e.Delta < 0) || ((sfr.ScaleX > 5 || sfr.ScaleY > 5) && e.Delta > 0))
                    {

                    }
                    else
                    {
                        Point centerPoint = e.GetPosition(image);

                        if (Keyboard.IsKeyDown(Key.LeftCtrl))
                        {
                            foreach (var item in imageParameters)
                            {
                                item.ScaleTransformCenterX = centerPoint.X;
                                item.ScaleTransformCenterY = centerPoint.Y;
                                item.ScaleTransformScaleX += (double)e.Delta / 1000;
                                item.ScaleTransformScaleY += (double)e.Delta / 1000;
                            }
                        }
                        else
                        {
                            imageParameter.ScaleTransformCenterX = centerPoint.X;
                            imageParameter.ScaleTransformCenterY = centerPoint.Y;
                            imageParameter.ScaleTransformScaleX += (double)e.Delta / 1000;
                            imageParameter.ScaleTransformScaleY += (double)e.Delta / 1000;
                        }
                    }
                };
                bool isMouseLeftButtonDown = false;
                Point start, MouseStart, mouseXY;
                DrawingVisual drawingVisual = new DrawingVisual();
                List<Point> PolygonList = new List<Point>();

                ImageViewState.toolTop.PropertyChanged += delegate(object? sender, PropertyChangedEventArgs e)
                {
                    if (e.PropertyName == "PolygonChecked")
                    {
                        if (ImageViewState.toolTop.PointerChecked == false)
                        {
                            if (PolygonList.Count > 0)
                            {
                                using (DrawingContext dc = drawingVisual.RenderOpen())
                                {
                                    for (int i = 0; i < PolygonList.Count - 1; i++)
                                    {
                                        dc.DrawLine(new Pen(Brushes.Red, 1), PolygonList[i], PolygonList[i + 1]);
                                    }
                                    dc.DrawLine(new Pen(Brushes.Red, 1), PolygonList[0], PolygonList[PolygonList.Count-1]);
                                }
                                PolygonList.Clear();
                            }
                        }
                    }
                };
                Application.Current.MainWindow.PreviewKeyDown += delegate (object sender, KeyEventArgs e)
                {
                    if (e.Key == Key.Escape)
                    {
                        if (PolygonList.Count > 0)
                        {
                            using (DrawingContext dc = drawingVisual.RenderOpen())
                            {
                                for (int i = 0; i < PolygonList.Count - 1; i++)
                                {
                                    dc.DrawLine(new Pen(Brushes.Red, 1), PolygonList[i], PolygonList[i + 1]);
                                }
                                dc.DrawLine(new Pen(Brushes.Red, 1), PolygonList[0], PolygonList[PolygonList.Count - 1]);
                            }
                            PolygonList.Clear();
                        }
                    }
                };

                image.MouseLeftButtonDown += delegate (object sender, MouseButtonEventArgs e)
                {
                    image.Focus();
                    mouseXY = Mouse.GetPosition(Application.Current.MainWindow);
                    MouseStart = Mouse.GetPosition(image);
                    start = new Point(tlt.X, tlt.Y);
                    if (ImageViewState.toolTop.MoveChecked)
                    {
                        isMouseLeftButtonDown = true;
                        Application.Current.MainWindow.Cursor = Cursors.Hand;
                    }
                    else if (ImageViewState.toolTop.RectangleChecked || ImageViewState.toolTop.CircleChecked || ImageViewState.toolTop.LineChecked || ImageViewState.toolTop.ArrowChecked)
                    {
                        drawingVisual = new DrawingVisual();
                        image.AddVisual(drawingVisual);
                        isMouseLeftButtonDown = true;
                        // Make sure we get the MouseLeftButtonUp event even if the user
                        // moves off the Canvas. Otherwise, two selection squares could be drawn at once.
                        Application.Current.MainWindow.Cursor = Cursors.Cross;
                        image.CaptureMouse();
                    }
                    else if (ImageViewState.toolTop.EraserChecked == true)
                    {
                        DrawingVisual visual = image.GetVisual(MouseStart);
                        if (visual != null) image.DeleteVisual(visual);
                    }
                    else if (ImageViewState.toolTop.PolygonChecked)
                    {
                        PolygonList.Add(MouseStart);
                        isMouseLeftButtonDown = true;
                        Application.Current.MainWindow.Cursor = Cursors.Cross;

                        if (e.ClickCount == 2)
                        {
                            if (PolygonList.Count > 1)
                            {
                                PolygonList.RemoveAt(PolygonList.Count - 1);
                            }
                            using (DrawingContext dc = drawingVisual.RenderOpen())
                            {
                                for (int i = 0; i < PolygonList.Count - 1; i++)
                                {
                                    dc.DrawLine(new Pen(Brushes.Red, 1), PolygonList[i], PolygonList[i + 1]);
                                }
                                dc.DrawLine(new Pen(Brushes.Red, 1), PolygonList[0], PolygonList[PolygonList.Count - 1]);
                            }
                            PolygonList.Clear();
                            return;
                        }

                        if (PolygonList.Count == 1)
                        {
                            drawingVisual = new DrawingVisual();
                            image.AddVisual(drawingVisual);
                            Pen pen = new Pen(Brushes.Green, 1) { DashStyle = DashStyles.Dash };
                        }
                        else
                        {
                            using (DrawingContext dc = drawingVisual.RenderOpen())
                            {
                                for (int i = 0; i < PolygonList.Count-1; i++)
                                {
                                    dc.DrawLine(new Pen(Brushes.Red, 1), PolygonList[i], PolygonList[i+1]);
                                }
                            }
                        }



                    }
                    else
                    {
                        Application.Current.MainWindow.Cursor = Cursors.Cross;
                    }
                };
                image.MouseLeftButtonUp += delegate (object sender, MouseButtonEventArgs e)
                {
                    if (isMouseLeftButtonDown)
                    {
                        isMouseLeftButtonDown = false;
                        Application.Current.MainWindow.Cursor = Cursors.Arrow;
                    }
                    image.ReleaseMouseCapture();
                };

                image.MouseMove += delegate (object sender, MouseEventArgs e)
                {
                    if (isMouseLeftButtonDown == true)
                    {
                        Point position = Mouse.GetPosition(Application.Current.MainWindow);


                        if (ImageViewState.toolTop.MoveChecked)
                        {
                            tlt.X = start.X + position.X - mouseXY.X;
                            tlt.Y = start.Y + position.Y - mouseXY.Y;
                        }
                        else if (ImageViewState.toolTop.RectangleChecked)
                        {
                            using DrawingContext dc = drawingVisual.RenderOpen();
                            Brush brush = Brushes.Transparent;
                            //if (isSelected) brush = selectedDrawingBrush;
                            dc.DrawRectangle(brush, new Pen(Brushes.Red, 1), new Rect(MouseStart, (position - mouseXY)));
                        }
                        else if (ImageViewState.toolTop.CircleChecked)
                        {
                            Point center = (MouseStart + (position - mouseXY) / 2);
                            Pen pen = new Pen(Brushes.Green, 1) { DashStyle = DashStyles.Dash };

                            using (DrawingContext dc = drawingVisual.RenderOpen())
                            {
                                if (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift))
                                {
                                    double radius = Math.Min(Math.Abs(mouseXY.X - position.X) / 2, Math.Abs(mouseXY.Y - position.Y) / 2);
                                    dc.DrawEllipse(Brushes.Transparent, pen, center, radius, radius);
                                }
                                else
                                {
                                    double radiusX = Math.Abs(mouseXY.X - position.X) / 2;
                                    double radiusY = Math.Abs(mouseXY.Y - position.Y) / 2;
                                    dc.DrawEllipse(Brushes.Transparent, pen, center, radiusX, radiusY);
                                }
                            }
                        }
                        else if (ImageViewState.toolTop.LineChecked)
                        {
                            Pen pen = new Pen(Brushes.Green, 1) { DashStyle = DashStyles.Dash };

                            using (DrawingContext dc = drawingVisual.RenderOpen())
                            {
                                if (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift))
                                {
                                    double deltaX = Math.Abs(mouseXY.X - position.X);
                                    double deltaY = Math.Abs(mouseXY.Y - position.Y);
                                    if (deltaX < deltaY) mouseXY.X = position.X;
                                    if (deltaX > deltaY) mouseXY.Y = position.Y;
                                }
                                dc.DrawLine(new Pen(Brushes.Red, 1),  MouseStart, MouseStart+(position - mouseXY));
                            }
                        }
                        else if (ImageViewState.toolTop.ArrowChecked)
                        {
                            Pen pen = new Pen(Brushes.Red, 1) { DashStyle = DashStyles.Dash };
                            Point point1 = MouseStart;
                            Point point2 = MouseStart + (position - mouseXY);

                            using (DrawingContext dc = drawingVisual.RenderOpen())
                            {

                                double x1 = point1.X;
                                double y1 = point1.Y;
                                double x2 = point2.X;
                                double y2 = point2.Y;
                                double dist = Math.Sqrt(((x1 - x2) * (x1 - x2)) + ((y1 - y2) * (y1 - y2)));
                                double arrowLength = Math.Min(30, dist);
                                double arrowAngle = Math.PI / 12;

                                double angleOri = Math.Atan((y2 - y1) / (x2 - x1));

                                double angleDown = angleOri - arrowAngle;
                                double angleUp = angleOri + arrowAngle;

                                int directionFlag = (x2 > x1) ? -1 : 1;

                                double x3 = x2 + (directionFlag * arrowLength * Math.Cos(angleDown));
                                double y3 = y2 + (directionFlag * arrowLength * Math.Sin(angleDown));
                                double x4 = x2 + (directionFlag * arrowLength * Math.Cos(angleUp));
                                double y4 = y2 + (directionFlag * arrowLength * Math.Sin(angleUp));
                                Point pt3 = new Point(x3, y3);
                                Point pt4 = new Point(x4, y4);

                                PathGeometry geometry = new PathGeometry();
                                PathFigure figure = new PathFigure
                                {
                                    StartPoint = point1,
                                    IsClosed = false,
                                    IsFilled = true,
                                };
                                figure.Segments.Add(new LineSegment(point2, true));
                                geometry.Figures.Add(figure);
                                dc.DrawGeometry(Brushes.Transparent, pen, geometry);

                                geometry = new PathGeometry();
                                figure = new PathFigure
                                {
                                    StartPoint = point2,
                                    IsClosed = false,
                                    IsFilled = true,
                                };
                                figure.Segments.Add(new LineSegment(pt3, true));
                                geometry.Figures.Add(figure);
                                dc.DrawGeometry(Brushes.Transparent, pen, geometry);
                                geometry = new PathGeometry();
                                figure = new PathFigure
                                {
                                    StartPoint = point2,
                                    IsClosed = false,
                                    IsFilled = true,
                                };
                                figure.Segments.Add(new LineSegment(pt4, true));
                                geometry.Figures.Add(figure);
                                dc.DrawGeometry(Brushes.Transparent, pen, geometry);
                            }

                        }

                        else if (ImageViewState.toolTop.PolygonChecked)
                        {
                            //using (DrawingContext dc = drawingVisual.RenderOpen())
                            //{
                            //    for (int i = 0; i < PolygonList.Count - 1; i++)
                            //    {
                            //        dc.DrawLine(new Pen(Brushes.Red, 1), PolygonList[i], PolygonList[i + 1]);
                            //    }
                            //    dc.DrawLine(new Pen(Brushes.Red, 1), PolygonList[PolygonList.Count-1], PolygonList[PolygonList.Count-1] + (position - mouseXY));
                            //}
                        }

                    };

                };

                image.MouseEnter += delegate (object sender, MouseEventArgs e)
                {
                    if (ImageViewState.toolTop.EraserChecked == true)
                    {
                        StreamResourceInfo sri = Application.GetResourceStream(new Uri("/Global;component/usercontrols/image/eraser.cur", UriKind.Relative));
                        Application.Current.MainWindow.Cursor = new Cursor(sri.Stream);
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

                //double v ;
                //switch (imageParameters.Count)
                //{
                //    case 1:
                //        v = 1;
                //        break;
                //    case 2:
                //        v = 0.5;
                //        break;
                //    case 3:
                //        v = 0.5;
                //        break;
                //    case 4:
                //        v = 0.5;
                //        break;
                //    case 5:
                //        v = 0.4;
                //        break;
                //    case 6:
                //        v = 0.4;
                //        break;
                //    default:
                //        v = 1;
                //        break;
                //}

                //for (int i = 0; i < imageParameters.Count; i++)
                //{
                //    imageParameters[i].ScaleTransformScaleX = v;
                //    imageParameters[i].ScaleTransformScaleY = v;
                //}
            };

           
        }

    }
}
