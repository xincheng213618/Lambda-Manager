using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Resources;
using System.Windows.Shapes;
using Global;
using Global.Mode.Config;
using Lambda;

namespace Global.UserControls.DrawVisual
{
    /// <summary>
    /// DrawingVisualInk.xaml 的交互逻辑
    /// </summary>
    public partial class DrawingVisualInk : UserControl
    {

        public DrawingVisualInk(ImageViewState.ToolTop ToolTop,DrawMethod drawMethod,double ratio)
        {
            InitializeComponent();
            this.ToolTop = ToolTop;
            this.drawMethod = drawMethod;
            this.ratio = ratio;

        }
        public ImageViewState.ToolTop ToolTop;
        private DrawMethod drawMethod = new DrawMethod();
        //public static ROIModel rOIModel = new ROIModel();
        private Point PointMoveOri { get; set; }
        private Point PolygonPoint { get; set; }
        private bool CanMove { get; set; }
        // Variables for dragging shapes.
        private bool isDragging = false;
        private Vector clickOffset;
        private DrawingVisual selectedVisual;
        public double ratio = 1;

        public List<Point> PolygonList111 = new List<Point>();


        // Variables for drawing the selection square.
        private Point selectionSquareTopLeft;

        private void InkCanvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Point pointClicked = e.GetPosition(InkCanvas);

            if (ToolTop.RectangleChecked == true)
            {
                drawMethod.RectangleVisual = new DrawingVisual();

                InkCanvas.AddVisual(drawMethod.RectangleVisual);

                selectionSquareTopLeft = pointClicked;
                CanMove = true;
                InkCanvas.CaptureMouse();

               
            }
            else if (ToolTop.LineChecked == true)
            {
                CanMove = true;
                PointMoveOri = e.GetPosition(InkCanvas);
                drawMethod.LineVisual = new DrawingVisual();
                InkCanvas.AddVisual(drawMethod.LineVisual);
                InkCanvas.CaptureMouse();
                //   drawingSurface.CaptureMouse();

            }
            else if (ToolTop.DimensionChecked == true)
            {
                CanMove = true;
                PointMoveOri = pointClicked;
                drawMethod.dimensionVisual = new DrawingVisual();
                InkCanvas.AddVisual(drawMethod.dimensionVisual);
                InkCanvas.CaptureMouse();

            }


            else if (ToolTop.ArrowChecked == true)
            {
                CanMove = true;
                PointMoveOri = e.GetPosition(InkCanvas);
                drawMethod.arrowVisual = new DrawingVisual();
                InkCanvas.AddVisual(drawMethod.arrowVisual);
                InkCanvas.CaptureMouse();
                //  drawingSurface.CaptureMouse();

            }
            
            else if (ToolTop.PolygonChecked == true)
            {
                //  drawMethod.PolygonList.Add(pointClicked);

                InkCanvas.Focus();
                InkCanvas.CaptureMouse();

                if (drawMethod.PolygonList.Count > 0)
                {
                    drawMethod.selectionSquarePen.DashStyle = DashStyles.Dash;
                    PolygonPoint = pointClicked;


                    if (e.ClickCount == 2)
                    {
                        if (drawMethod.PolygonList.Count > 1)
                        {
                            drawMethod.PolygonList.RemoveAt(drawMethod.PolygonList.Count - 1);
                            drawMethod.PolygonList.Add(drawMethod.PolygonList[0]);
                        }
                        InkCanvas.Focusable = false;
                        DrawingContent();
                        drawMethod.PolygonList.Clear();
                        return;
                    }
                    drawMethod.PolygonList.Add(PolygonPoint);
                    DrawingContent();


                }
                else if (drawMethod.PolygonList.Count == 0)
                {
                    drawMethod.PolygonList = new List<Point>();
                    drawMethod.polygonVisual = new DrawingVisual();
                    InkCanvas.AddVisual(drawMethod.polygonVisual);
                    PolygonPoint = pointClicked;
                    drawMethod.PolygonList.Add(PolygonPoint);
                    InkCanvas.Focusable = true;
                }




            }
            else if (ToolTop.CircleChecked == true)
            {
                CanMove = true;
                drawMethod.circleVisual = new DrawingVisual();

                InkCanvas.AddVisual(drawMethod.circleVisual);

                PointMoveOri = e.GetPosition(InkCanvas);
                InkCanvas.CaptureMouse();
                // isMultiSelecting = true;
                // Make sure we get the MouseLeftButtonUp event even if the user
                // moves off the Canvas. Otherwise, two selection squares could be drawn at once.
                // drawingSurface.CaptureMouse();

            }
            else if (ToolTop.MoveChecked == true)
            {
                StreamResourceInfo hold = Application.GetResourceStream(new Uri("/Global;component/usercontrols/image/hold.cur", UriKind.Relative));
                InkCanvas.Cursor = new Cursor(hold.Stream);
                CanMove = true;
                PointMoveOri = e.GetPosition(InkCanvas);
                // CanMove = true;
                Dictionary<string, object> parameters = new Dictionary<string, object>()
                            {
                            {"event",(int)1},
                            {"x",(int)PointMoveOri.X },
                            {"y",(int)PointMoveOri.Y },
                            {"flag",(int)1 }

                            };
                LambdaControl.Trigger("MOUSE_EVENT", null, parameters);



            }

            else if (ToolTop.EraserChecked == true)
            {

                DrawingVisual visual = InkCanvas.GetVisual(pointClicked);
                PointMoveOri = e.GetPosition(InkCanvas);
                if (visual != null) InkCanvas.DeleteVisual(visual);

                CanMove = true;
                InkCanvas.CaptureMouse();
                // DrawingVisual visual = image.GetVisual(MouseStart);
                if (visual != null)
                {
                    InkCanvas.DeleteVisual(visual);

                }
                else
                {
                    drawMethod.deleteVisual = new DrawingVisual();
                    InkCanvas.AddVisual(drawMethod.deleteVisual);

                    InkCanvas.CaptureMouse();
                }
            }

            else
            {
               // PointMoveOri = e.GetPosition(InkCanvas);
               //// CanMove = true;
               // Dictionary<string, object> parameters = new Dictionary<string, object>()
               //             {
               //             {"event",(int)1},
               //             {"x",(int)PointMoveOri.X },
               //             {"y",(int)PointMoveOri.Y },
               //             {"flag",(int)1 }

               //             };
               // LambdaControl.Trigger("MOUSE_EVENT", null, parameters);

            }





        }

        public void DrawingContent()
        {
            using (DrawingContext dc = drawMethod.polygonVisual.RenderOpen())
            {

                for (int i = 0; i < drawMethod.PolygonList.Count - 1; i++)
                {
                    dc.DrawLine(drawMethod.selectionSquarePen, drawMethod.PolygonList[i], drawMethod.PolygonList[i + 1]);
                }
            }
        }

        private void InkCanvas_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            isDragging = false;
           
            if (CanMove)
            {
                CanMove = false;
                if (ToolTop.MoveChecked== true)
                {
                    InkCanvas.Cursor = Cursors.Hand;
                }
                //清除绘制超出边界的绘制元素
                //List<DrawingVisual> visualsList = new List<DrawingVisual>();

                    //foreach (var item in InkCanvas.visuals)
                    //{
                    //    visualsList.Add(item);
                    //}

                    //if (visualsList.Count > 0)
                    //{
                    //    foreach (DrawingVisual visual in visualsList)
                    //    {
                    //        if (visual.ContentBounds.BottomRight.X > InkCanvas.ActualWidth || visual.ContentBounds.BottomRight.Y > InkCanvas.ActualHeight || visual.ContentBounds.BottomLeft.X < 0 || visual.ContentBounds.BottomLeft.Y > InkCanvas.ActualHeight)

                    //            InkCanvas.DeleteVisual(visual);
                    //        if (visual.ContentBounds.TopRight.X > InkCanvas.ActualWidth || visual.ContentBounds.TopRight.Y < 0 || visual.ContentBounds.TopLeft.X < 0 || visual.ContentBounds.TopLeft.Y < 0)
                    //            InkCanvas.DeleteVisual(visual);


                    //    }
                    //    visualsList.Clear();
                    //}

            }
            if (ToolTop.EraserChecked == true)
            {
                // Display all the squares in this region.
                RectangleGeometry geometry = new RectangleGeometry(
                    new Rect(PointMoveOri, e.GetPosition(InkCanvas)));
                List<DrawingVisual> visualsInRegion = new List<DrawingVisual>();
                Point destPoint = e.GetPosition(InkCanvas);
                if (PointMoveOri.X < destPoint.X && PointMoveOri.Y < destPoint.Y)
                {
                    visualsInRegion =
                     InkCanvas.GetVisuals(geometry);
                }
                else
                {
                    visualsInRegion =
                    InkCanvas.GetVisualsRev(geometry);
                }

                // MessageBox.Show(String.Format("You selected {0 } DrawVisual(s).", visualsInRegion.Count));

                foreach (DrawingVisual visual in visualsInRegion)
                {
                   InkCanvas.DeleteVisual(visual);
                }
                //  isMultiSelecting = false;
                InkCanvas.DeleteVisual(drawMethod.deleteVisual);
                InkCanvas.ReleaseMouseCapture();
            }
            InkCanvas.ReleaseMouseCapture();

        }
        
        private void InkCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            var isShift = Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift);

            if (CanMove)
            {
                Point pointDragged = e.GetPosition(InkCanvas);
                if (ToolTop.EraserChecked == true )
                {
                    if (InkCanvas.Cursor == Cursors.Arrow)
                    {
                        StreamResourceInfo sri = Application.GetResourceStream(new Uri("/Global;component/usercontrols/image/eraser.cur", UriKind.Relative));
                        InkCanvas.Cursor = new Cursor(sri.Stream);
                    }
                        
                    //Point pointDragged = e.GetPosition(InkCanvas);
                    drawMethod.DrawDeleteSquare(PointMoveOri, pointDragged);

                }

                else if (ToolTop.RectangleChecked )
                {
                   // Point pointDragged = e.GetPosition(InkCanvas);
                    drawMethod.DrawSelectionSquare(selectionSquareTopLeft, pointDragged);
                }
                else if (ToolTop.CircleChecked )
                {
                   // Point pointDragged = e.GetPosition(InkCanvas);
                    drawMethod.DrawEllipse(PointMoveOri, pointDragged);
                }
                else if (ToolTop.LineChecked )
                {
                   // Point pointDragged = e.GetPosition(InkCanvas);
                    drawMethod.DrawLine(PointMoveOri, pointDragged);

                }
                else if (ToolTop.ArrowChecked )
                {
                   // Point pointDragged = e.GetPosition(InkCanvas);
                    drawMethod.DrawArrow(PointMoveOri, pointDragged);

                }
                else if (ToolTop.DimensionChecked)
                {
                    drawMethod.DrawDimension(InkCanvas.ActualWidth, InkCanvas.ActualHeight, ratio, PointMoveOri, pointDragged, false, drawMethod.dimensionVisual);
                }
                else if (ToolTop.MoveChecked)
                {

                    if (InkCanvas.Cursor == Cursors.Hand)
                    {
                        StreamResourceInfo sri = Application.GetResourceStream(new Uri("/Global;component/usercontrols/image/hold.cur", UriKind.Relative));
                        InkCanvas.Cursor = new Cursor(sri.Stream);
                    }
                    Dictionary<string, object> parameters = new Dictionary<string, object>()
                              {
                            { "event",(int)0},
                            {"x",(int)pointDragged.X },
                            {"y",(int)pointDragged.Y },
                            {"flag",(int)1 }

                                 };
                    LambdaControl.Trigger("MOUSE_EVENT", null, parameters);
                }
               

            }
            else
            {

            }
            

           


        }

        private void InkCanvas_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                if (drawMethod.PolygonList.Count > 1)
                {

                    drawMethod.PolygonList.Add(drawMethod.PolygonList[0]);
                }
                InkCanvas.Focusable = false;
                DrawingContent();
                drawMethod.PolygonList.Clear();

            }

        }
        






        private void InkCanvas_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            Point MousePoint = e.GetPosition(InkCanvas);
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

        }

        private void UserControl_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            List<DrawingVisual> visualsList = new List<DrawingVisual>();

            foreach (var item in InkCanvas.visuals)
            {
                visualsList.Add(item);
            }

            if (visualsList.Count > 0)
            {
                foreach (DrawingVisual visual in visualsList)
                {
                    InkCanvas.DeleteVisual(visual);
                }
                visualsList.Clear();
            }


            if (InkCanvas.visuals.Count == 0 && ToolTop.DimensionChecked)
            {
                DrawingVisual dimDefaultVisual = new DrawingVisual();
                InkCanvas.AddVisual(dimDefaultVisual);
                drawMethod.DrawDimension(InkCanvas.ActualWidth, InkCanvas.ActualHeight, ratio, new Point(0, 0), new Point(0, 0), true, dimDefaultVisual);
            }


        }

       
    }
}
