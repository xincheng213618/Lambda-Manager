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
using System.Windows.Resources;
using Global.Mode.Config;


namespace Global.UserControls.DrawVisual
{
    /// <summary>
    /// DrawImageCanv.xaml 的交互逻辑
    /// </summary>
    public partial class DrawImageCanv : UserControl
    {
        public DrawImageCanv(ImageViewState.ToolTop ToolTop)
        {
            this.ToolTop = ToolTop;
            InitializeComponent();
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

        public List<Point> PolygonList111 = new List<Point>();


        // Variables for drawing the selection square.
        private Point selectionSquareTopLeft;

        private void drawingSurface_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Point pointClicked = e.GetPosition(drawingSurface);

            if (ToolTop.RectangleChecked == true)
            {
                drawMethod.RectangleVisual = new DrawingVisual();

                drawingSurface.AddVisual(drawMethod.RectangleVisual);

                selectionSquareTopLeft = pointClicked;
                CanMove = true;

                // Make sure we get the MouseLeftButtonUp event even if the user
                // moves off the Canvas. Otherwise, two selection squares could be drawn at once.
                //   drawingSurface.CaptureMouse();
            }
            else if (ToolTop.LineChecked == true)
            {
                CanMove = true;
                PointMoveOri = e.GetPosition(drawingSurface);
                drawMethod.LineVisual = new DrawingVisual();
                drawingSurface.AddVisual(drawMethod.LineVisual);
                //   drawingSurface.CaptureMouse();

            }
            else if (ToolTop.TextChecked == true)
            {

            }


            else if (ToolTop.ArrowChecked == true)
            {
                CanMove = true;
                PointMoveOri = e.GetPosition(drawingSurface);
                drawMethod.arrowVisual = new DrawingVisual();
                drawingSurface.AddVisual(drawMethod.arrowVisual);
                //  drawingSurface.CaptureMouse();

            }
            else if (ToolTop.PolygonChecked == true)
            {
                //  drawMethod.PolygonList.Add(pointClicked);

                drawingSurface.Focus();

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
                        drawingSurface.Focusable = false;
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
                    drawingSurface.AddVisual(drawMethod.polygonVisual);
                    PolygonPoint = pointClicked;
                    drawMethod.PolygonList.Add(PolygonPoint);
                    drawingSurface.Focusable = true;
                }




            }
            else if (ToolTop.CircleChecked == true)
            {
                CanMove = true;
                drawMethod.circleVisual = new DrawingVisual();

                drawingSurface.AddVisual(drawMethod.circleVisual);

                PointMoveOri = e.GetPosition(drawingSurface);
                // isMultiSelecting = true;
                // Make sure we get the MouseLeftButtonUp event even if the user
                // moves off the Canvas. Otherwise, two selection squares could be drawn at once.
                // drawingSurface.CaptureMouse();

            }

            else if (ToolTop.EraserChecked  == true)
          {
                DrawingVisual visual = drawingSurface.GetVisual(pointClicked);

                if (visual != null) drawingSurface.DeleteVisual(visual);
            }

            //else if (ToolTop.EraserChecked == true)
            //{
            //    DrawingVisual visual = drawingSurface.GetVisual(pointClicked);
            //    if (visual != null)
            //    {
            //        // Calculate the top-left corner of the square.
            //        // This is done by looking at the current bounds and
            //        // removing half the border (pen thickness).
            //        // An alternate solution would be to store the top-left
            //        // point of every visual in a collection in the 
            //        // DrawingCanvas, and provide this point when hit testing.
            //        Point topLeftCorner = new Point(
            //            visual.ContentBounds.TopLeft.X + drawingPen.Thickness / 2,
            //            visual.ContentBounds.TopLeft.Y + drawingPen.Thickness / 2);
            //        DrawSquare(visual, topLeftCorner, true);

            //        clickOffset = topLeftCorner - pointClicked;
            //        isDragging = true;

            //        if (selectedVisual != null && selectedVisual != visual)
            //        {
            //            // The selection has changed. Clear the previous selection.
            //            ClearSelection();
            //        }
            //        selectedVisual = visual;
            //    }
            //}

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



        // Drawing constants.
        private Brush drawingBrush = null;
        private Brush selectedDrawingBrush = Brushes.LightGoldenrodYellow;
        private Pen drawingPen = new Pen(Brushes.Red, 10);
        private Size squareSize = new Size(30, 30);
        private DrawingVisual selectionSquare;
        // private DrawingVisual CircleSquare;

        // Rendering the square.
        private void DrawSquare(DrawingVisual visual, Point topLeftCorner, bool isSelected)
        {
            using (DrawingContext dc = visual.RenderOpen())
            {
                Brush brush = drawingBrush;
                if (isSelected) brush = selectedDrawingBrush;

                dc.DrawRectangle(brush, drawingPen,
                    new Rect(topLeftCorner, squareSize));
            }
        }





        private void drawingSurface_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            isDragging = false;


            if (CanMove)
            {
                CanMove = false;
                //  drawingSurface.DeleteVisual(drawMethod.CircleSquare);
                //  drawingSurface.ReleaseMouseCapture();
            }

        }


        private void ClearSelection()
        {
            Point topLeftCorner = new Point(
                        selectedVisual.ContentBounds.TopLeft.X + drawingPen.Thickness / 2,
                        selectedVisual.ContentBounds.TopLeft.Y + drawingPen.Thickness / 2);
            DrawSquare(selectedVisual, topLeftCorner, false);
            selectedVisual = null;
        }

        private void drawingSurface_MouseMove(object sender, MouseEventArgs e)
        {
            var isShift = Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift);
           

            // string path1 = Path.Combine(Directory.GetCurrentDirectory(), "eraser.png");
           if (ToolTop.EraserChecked ==true)
           {
                StreamResourceInfo sri = Application.GetResourceStream(new Uri("/Global;component/usercontrols/drawvisual/eraser.cur", UriKind.Relative));
                Cursor customCursor = new Cursor(sri.Stream);
                DispalyArea.Cursor = customCursor;
            }
           else
            {
                DispalyArea.Cursor = Cursors.Cross;

            };

            if (isDragging)
            {
                Point pointDragged = e.GetPosition(drawingSurface) + clickOffset;
                DrawSquare(selectedVisual, pointDragged, true);
            }
            else if (ToolTop.RectangleChecked && CanMove)
            {
                Point pointDragged = e.GetPosition(drawingSurface);
                drawMethod.DrawSelectionSquare(selectionSquareTopLeft, pointDragged);
            }
            else if (ToolTop.CircleChecked && CanMove)
            {
                Point pointDragged = e.GetPosition(drawingSurface);
                drawMethod.DrawEllipse(PointMoveOri, pointDragged);
            }
            else if (ToolTop.LineChecked && CanMove)
            {
                Point pointDragged = e.GetPosition(drawingSurface);
                drawMethod.DrawLine(PointMoveOri, pointDragged);

            }
            else if (ToolTop.ArrowChecked && CanMove)
            {
                Point pointDragged = e.GetPosition(drawingSurface);
                drawMethod.DrawArrow(PointMoveOri, pointDragged);

            }
            //else if (rOIModel.Text && CanMove)
            //{



            //}


        }

        private void drawingSurface_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                if (drawMethod.PolygonList.Count > 1)
                {

                    drawMethod.PolygonList.Add(drawMethod.PolygonList[0]);
                }
                drawingSurface.Focusable = false;
                DrawingContent();
                drawMethod.PolygonList.Clear();

            }

        }

    }


}

