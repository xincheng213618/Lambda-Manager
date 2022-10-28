using Lambda;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Shapes;

namespace ConfigObjective.UserControls
{
    /// <summary>
    /// SlideMap.xaml 的交互逻辑
    /// </summary>
    public partial class SlideMap : UserControl
    {
        public SlideMap()
        {
            InitializeComponent();

            var descriptor
            = DependencyPropertyDescriptor.FromProperty(
             Canvas.LeftProperty, typeof(Label));

            descriptor.AddValueChanged(moveButton, moveButtonLeft);

            var descriptor1
             = DependencyPropertyDescriptor.FromProperty(
              Canvas.TopProperty, typeof(Label));

            descriptor1.AddValueChanged(moveButton, moveButtonTop);


        }
        private Point selectionSquareTopLeft;
        int[,] mapArrray = new int[33, 25];
        private bool isMultiSelecting = false;
        private bool isDraging = false;
        private Point pointClickLeft;
        private Point pointClickRight;
        public DrawingVisual selectedVisual;
        // Drawing constants.
        private Brush drawingBrush0 = Brushes.Blue;
        private Brush drawingBrush1 = Brushes.Red;
        private Pen drawingPen = new Pen(Brushes.SteelBlue, 0.1);
        private Size squareSize = new Size(8, 6);
        private DrawingVisual selectionSquare;

        private Brush selectionSquareBrush = Brushes.Transparent;
        private Pen selectionSquarePen = new Pen(Brushes.Black, 1);
        public List<Point> selectedPoints = new List<Point>();
        public SelectedPointCollect pointCollect = new SelectedPointCollect();

        public class SelectedPointCollect : INotifyPropertyChanged
        {
            private bool selectedPointsSend = false;
            public bool SelectedPointsSend
            {
                get { return selectedPointsSend; }
                set
                {
                    selectedPointsSend = value;
                    RaisePropertyChanged(nameof(SelectedPointsSend));
                }
            }
            public event PropertyChangedEventHandler PropertyChanged;
            protected virtual void RaisePropertyChanged(string propertyName)
            {
                // Cache the handler to make this thread safe
                var handler = PropertyChanged;

                if (handler != null)
                    handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }









        private void mapCanvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            Point pointClicked = e.GetPosition(mapCanvas);
            pointClickLeft = pointClicked;

            if (e.ClickCount == 2)
            {


                int x = (int)Math.Floor(pointClicked.X / 8);
                int y = (int)Math.Floor(pointClicked.Y / 6);
                Point movePoint = new Point(x * 8, y * 6);

                Dictionary<string, object> data = new Dictionary<string, object>()
                {
                    { "X", (int)(movePoint.X) },
                    { "Y", (int)(movePoint.Y) },
                };
                LambdaControl.Trigger("MOTORCONTROL", this, data);

                DrawingVisual visual = mapCanvas.GetVisual(pointClicked);
                if (visual != null)
                {
                    mapCanvas.DeleteVisual(visual);
                    if (y >= 33 || x >= 25) return;
                    mapArrray[y, x] = 0;
                    Point removePoint = new Point(x * 8, y * 6);
                    selectedPoints.Remove(removePoint);
                }

            }
            else
            {


                if (e.LeftButton == MouseButtonState.Pressed)
                {
                    selectionSquare = new DrawingVisual();

                    mapCanvas.AddVisual(selectionSquare);

                    selectionSquareTopLeft = pointClicked;
                    isMultiSelecting = true;

                    // Make sure we get the MouseLeftButtonUp event even if the user
                    // moves off the Canvas. Otherwise, two selection squares could be drawn at once.
                    mapCanvas.CaptureMouse();

                }

            }
            //  DrawRectangle(pointClicked);
        }
        private void mapCanvas_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Point pointClicked = e.GetPosition(mapCanvas);

            if (isMultiSelecting)
            {
                // Display all the squares in this region.
                RectangleGeometry geometry = new RectangleGeometry(
                    new Rect(selectionSquareTopLeft, e.GetPosition(mapCanvas)));
                DrawMultiRec(pointClickLeft, pointClicked);

                isMultiSelecting = false;
                mapCanvas.DeleteVisual(selectionSquare);
                mapCanvas.ReleaseMouseCapture();

                // send selected point to multiCollection 
                pointCollect.SelectedPointsSend = false;
                pointCollect.SelectedPointsSend = true;


            }
        }
        private void mapCanvas_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sender is Label lab) lab.Tag = 2;
            Point pointClicked = e.GetPosition(mapCanvas);
            pointClickRight = pointClicked;

            if (e.RightButton == MouseButtonState.Pressed)
            {
                selectionSquare = new DrawingVisual();

                mapCanvas.AddVisual(selectionSquare);

                selectionSquareTopLeft = pointClicked;
                isDraging = true;

                // Make sure we get the MouseLeftButtonUp event even if the user
                // moves off the Canvas. Otherwise, two selection squares could be drawn at once.
                mapCanvas.CaptureMouse();

            }

            int x = (int)Math.Floor(pointClicked.X / 8);
            int y = (int)Math.Floor(pointClicked.Y / 6);
            if (x >= 200 || y >= 200) return;
            DrawingVisual visual = mapCanvas.GetVisual(pointClicked);
            if (visual != null)
            {
                mapCanvas.DeleteVisual(visual);
                if (y >= 33 || x >= 25) return;
                mapArrray[y, x] = 0;
                Point removePoint = new Point(x * 8, y * 6);
                selectedPoints.Remove(removePoint);
            }

            Double moveButtonX = Canvas.GetLeft(moveButton) + 4;
            Double moveButtonY = Canvas.GetTop(moveButton) + 3;
            Point moveButtonPoint = new Point(moveButtonX, moveButtonY);
            int moveButtonX1 = (int)Math.Floor(moveButtonPoint.X / 8);
            int moveButtonY1 = (int)Math.Floor(moveButtonPoint.Y / 6);

            Point moveButtonPoint1 = new Point(moveButtonX1 * 8, moveButtonY1 * 6);
            if (selectedPoints.Contains(moveButtonPoint1) == false)
            {
                moveButton.Tag = 2;
            }
            // send selected point to multiCollection 
            pointCollect.SelectedPointsSend = false;
            pointCollect.SelectedPointsSend = true;
        }

        private void mapCanvas_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            Point pointClicked = e.GetPosition(mapCanvas);

            if (isDraging)
            {

                DelMultiRec(pointClickRight, pointClicked);
                isDraging = false;
                mapCanvas.DeleteVisual(selectionSquare);
                mapCanvas.ReleaseMouseCapture();

            }

        }
        private void mapCanvas_MouseMove(object sender, MouseEventArgs e) // 
        {
            Point point = e.GetPosition(mapCanvas);
            if (isMultiSelecting)
            {
                Point pointDragged = e.GetPosition(mapCanvas);
                DrawSelectionSquare(selectionSquareTopLeft, pointDragged);
            }
            if (isDraging)
            {
                Point pointDragged = e.GetPosition(mapCanvas);
                DrawSelectionSquare(selectionSquareTopLeft, pointDragged);
            }




        }
        public void DrawRectangle(Point point, bool bol) // draw rectangle
        {
            selectionSquareTopLeft = point;

            int x = (int)Math.Floor(point.X / 8);
            int y = (int)Math.Floor(point.Y / 6);

            Point drawpoint = new Point(x * 8, y * 6);
           

            if (y >= 33 || x >= 25) return;

            if ( mapArrray[y, x] == 0)
            {

                DrawingVisual visual = new DrawingVisual();

                DrawSquare(visual, drawpoint, false, drawingBrush0);

                visual.Opacity = 0.3;
                mapCanvas.AddVisual(visual);
                mapArrray[y, x] = 1;
                selectedPoints.Add(drawpoint);

                Double moveButtonX = Canvas.GetLeft(moveButton) + 4;
                Double moveButtonY = Canvas.GetTop(moveButton) + 3;
                Point moveButtonPoint = new Point(moveButtonX, moveButtonY);
                int moveButtonX1 = (int)Math.Floor(moveButtonPoint.X / 8);
                int moveButtonY1 = (int)Math.Floor(moveButtonPoint.Y / 6);

                Point moveButtonPoint1 = new Point(moveButtonX1 * 8, moveButtonY1 * 6);
                if (selectedPoints.Contains(moveButtonPoint1))
                {
                    moveButton.Tag = 0;
                }
            }
            else if (mapArrray[y, x] == 0)
            {
                DrawingVisual visual = new DrawingVisual();

                DrawSquare(visual, drawpoint, false, drawingBrush1);
                visual.Opacity = 0.3;
                mapCanvas.AddVisual(visual);
                mapArrray[y, x] = 1;

            }

        }

        // Rendering the square.
        public void DrawSquare(DrawingVisual visual, Point topLeftCorner, bool isSelected, Brush drawingBrush)
        {

            using (DrawingContext dc = visual.RenderOpen())
            {
                Brush brush = drawingBrush;
                dc.DrawRectangle(brush, drawingPen, new Rect(topLeftCorner, squareSize));

            }


        }


        private void DrawSelectionSquare(Point point1, Point point2)
        {
            selectionSquarePen.DashStyle = DashStyles.Dash;

            using (DrawingContext dc = selectionSquare.RenderOpen())
            {
                dc.DrawRectangle(selectionSquareBrush, selectionSquarePen,
                    new Rect(point1, point2));
            }
        }
        public void DrawMultiRec(Point pointStart, Point pointStop) // LeftMouseBUtton draging
        {
            int i, j;
            int m = (int)Math.Floor((pointStop.Y - pointStart.Y) / 6) + 1;
            int n = (int)Math.Floor((pointStop.X - pointStart.X) / 8) + 1;
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    int x = (int)pointStart.X + j * 8;
                    int y = (int)pointStart.Y + i * 6;

                    Point point = new Point(x, y);
                    DrawRectangle(point, false);

                }
            }
        }
        public void DelMultiRec(Point pointStart, Point pointStop) // RightMouseBUtton draging
        {
            int i, j;
            int m = (int)Math.Floor((pointStop.Y - pointStart.Y) / 6) + 1;
            int n = (int)Math.Floor((pointStop.X - pointStart.X) / 8) + 1;
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    int x = (int)pointStart.X + j * 8;
                    int y = (int)pointStart.Y + i * 6;
                    int c = x;
                    int d = y;
                    int a = (int)Math.Floor((double)c / 8);
                    int b = (int)Math.Floor((double)d / 6);
                    Point point = new Point(x, y);
                    if (x >= 200 || y >= 200) continue;
                    DrawingVisual visual = mapCanvas.GetVisual(point);
                    if (visual != null) mapCanvas.DeleteVisual(visual);
                    if (b >= 33 || a >= 25) continue;
                    mapArrray[b, a] = 0;
                    Point removePoint = new Point(a * 8, b * 6);
                    selectedPoints.Remove(removePoint);

                }

            }
            Double moveButtonX = Canvas.GetLeft(moveButton) + 4;
            Double moveButtonY = Canvas.GetTop(moveButton) + 3;
            Point moveButtonPoint = new Point(moveButtonX, moveButtonY);
            int moveButtonX1 = (int)Math.Floor(moveButtonPoint.X / 8);
            int moveButtonY1 = (int)Math.Floor(moveButtonPoint.Y / 6);

            Point moveButtonPoint1 = new Point(moveButtonX1 * 8, moveButtonY1 * 6);
            if (selectedPoints.Contains(moveButtonPoint1) == false)
            {
                moveButton.Tag = 2;
            }
            // send selected point to multiCollection 
            pointCollect.SelectedPointsSend = false;
            pointCollect.SelectedPointsSend = true;
        }
        private void moveButtonLeft(object sender, EventArgs e)
        {
            Double moveButtonX = Canvas.GetLeft(moveButton) + 4;
            Double moveButtonY = Canvas.GetTop(moveButton) + 3;
            Point moveButtonPoint = new Point(moveButtonX, moveButtonY);
            int moveButtonX1 = (int)Math.Floor(moveButtonPoint.X / 8);
            int moveButtonY1 = (int)Math.Floor(moveButtonPoint.Y / 6);

            Point moveButtonPoint1 = new Point(moveButtonX1 * 8, moveButtonY1 * 6);
            if (selectedPoints.Contains(moveButtonPoint1) == false)
            {
                moveButton.Tag = 2;
            }
            else
            {
                moveButton.Tag = 1;
            }

        }
        private void moveButtonTop(object sender, EventArgs e)
        {
            Double moveButtonX = Canvas.GetLeft(moveButton) + 4;
            Double moveButtonY = Canvas.GetTop(moveButton) + 3;
            Point moveButtonPoint = new Point(moveButtonX, moveButtonY);
            int moveButtonX1 = (int)Math.Floor(moveButtonPoint.X / 8);
            int moveButtonY1 = (int)Math.Floor(moveButtonPoint.Y / 6);

            Point moveButtonPoint1 = new Point(moveButtonX1 * 8, moveButtonY1 * 6);
            if (selectedPoints.Contains(moveButtonPoint1) == false)
            {
                moveButton.Tag = 2;
            }
            else
            {
                moveButton.Tag = 1;
            }

        }



    }
}
