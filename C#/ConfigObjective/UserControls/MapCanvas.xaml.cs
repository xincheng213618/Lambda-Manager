using Lambda;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
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
using ConfigObjective;
using System.Collections.ObjectModel;

namespace ConfigObjective.UserControls
{

    /// <summary>
    /// MapCanvas.xaml 的交互逻辑
    /// </summary>
    public partial class MapCanvas : UserControl
    {
        public MapCanvas()
        {
            InitializeComponent();
            var descriptor = DependencyPropertyDescriptor.FromProperty(Canvas.LeftProperty, typeof(Label));
            descriptor.AddValueChanged(moveButton, moveButtonLeft);
            var descriptor1= DependencyPropertyDescriptor.FromProperty(Canvas.LeftProperty, typeof(Label));
            descriptor1.AddValueChanged(moveButton, moveButtonTop);


            selectedPoints.CollectionChanged += (s, e) =>
            {
                selectedPoints.OrderBy(p => p.Y).ThenBy(p => p.X).ToList();

            };


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

       
        private void UserControl_Initialized(object sender, EventArgs e)
        {
            LambdaControl.AddLambdaEventHandler("TestDataEvent", TestDataEvent, false);
           // mapCanvas.Source = null;

        }

        [DllImport("kernel32.dll", EntryPoint = "RtlMoveMemory")]
        public static extern void RtlMoveMemory(IntPtr Destination, IntPtr Source, uint Length);


        private bool TestDataEvent(object sender, EventArgs e)
        {
            Application.Current.Dispatcher.Invoke(delegate
            {
                Dictionary<string, object>? eventData = LambdaArgs.GetEventData(e);
                if (eventData != null)
                {
                    int size = (int)eventData["size"];

                    IntPtr intPtr = (IntPtr)eventData["data"];
                    //byte[] aaa = new byte[size];
                    //Marshal.Copy(intPtr, aaa, 0, size);

                    if (mapCanvas.Source is WriteableBitmap writeableBitmap1)
                    {
                        Int32Rect sourceRect = new Int32Rect(0, 0, (int)writeableBitmap1.Width, (int)writeableBitmap1.Height);
                        writeableBitmap1.WritePixels(sourceRect, intPtr, (int)size, (int)writeableBitmap1.Width * writeableBitmap1.Format.BitsPerPixel / 8);

                    }
                    else
                    {
                        WriteableBitmap writeableBitmap = new WriteableBitmap(300, 300, 96.0, 96.0, PixelFormats.Bgr24, null);
                        RtlMoveMemory(writeableBitmap.BackBuffer, intPtr, (uint)size);
                        writeableBitmap.Lock();
                        writeableBitmap.AddDirtyRect(new Int32Rect(0, 0, writeableBitmap.PixelWidth, writeableBitmap.PixelHeight));
                        writeableBitmap.Unlock();
                        mapCanvas.Source = writeableBitmap;
                    }
                }
            });
            return true;
        }


        private Point selectionSquareTopLeft;
        int[,] mapArrray = new int[50, 37];
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
        private DrawingVisualE selectionSquare;

        private Brush selectionSquareBrush = Brushes.Transparent;
        private Pen selectionSquarePen = new Pen(Brushes.Black, 1);
        public ObservableCollection<Point> selectedPoints = new ObservableCollection<Point>();
        public SelectedPointCollect pointCollect = new SelectedPointCollect();
        public bool IsReadMap = false;

        public class SelectedPointCollect: INotifyPropertyChanged
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
                

                int x = (int)Math.Floor(pointClicked.X/8);
                int y = (int)Math.Floor(pointClicked.Y/6);
                Point movePoint = new Point(x*8, y*6);

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
                    if (y >= 50 || x >= 37) return;
                    mapArrray[y, x] = 0;
                    Point removePoint = new Point(x * 8, y * 6);
                    selectedPoints.Remove(removePoint);
                }

            }
            else
            {


                if (e.LeftButton == MouseButtonState.Pressed)
                {
                    selectionSquare = new DrawingVisualE();

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
        

        public void DrawRectangle(Point point, bool bol) // draw rectangle
        {
            selectionSquareTopLeft = point;

            int x = (int)Math.Floor(point.X / 8);
            int y = (int)Math.Floor(point.Y / 6);

            Point drawpoint = new Point(x * 8, y * 6);
            // Rectangle Point 
            double Rx1 = Math.Pow(x * 8 - 150, 2);
            double Ry1 = Math.Pow(y * 6 - 150, 2);
            double Rx2 = Math.Pow(x * 8 + 8 - 150, 2);
            double Ry2 = Math.Pow(y * 6 - 150, 2);
            double Rx3 = Math.Pow(x * 8 - 150, 2);
            double Ry3 = Math.Pow(y * 6 + 6 - 150, 2);
            double Rx4 = Math.Pow(x * 8 + 8 - 150, 2);
            double Ry4 = Math.Pow(y * 6 + 6 - 150, 2);

            if (y >= 50 || x >= 37) return;

            if (Rx1 + Ry1 <= 22500 && Rx2 + Ry2 <= 22500 && Rx3 + Ry3 <= 22500 && Rx4 + Ry4 <= 22500 && mapArrray[y, x] == 0)
            {

                DrawingVisual visual = new DrawingVisual();

                DrawSquare(visual, drawpoint, false, drawingBrush0);

                visual.Opacity = 0.3;
                mapCanvas.AddVisual(visual);
                mapArrray[y, x] = 1;
                selectedPoints.Add(drawpoint);

                Double moveButtonX = Canvas.GetLeft(moveButton)+4;
                Double moveButtonY = Canvas.GetTop(moveButton)+3;
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
                MessageBox.Show("?");
                
                DrawingVisual visual = new DrawingVisual();

                DrawSquare(visual, drawpoint, false, drawingBrush1);
                visual.Opacity = 0.3;
                mapCanvas.AddVisual(visual);
                mapArrray[y, x] = 1;

            }

        }



        // Rendering the square. 蓝色
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

        private void mapCanvas_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Point pointClicked = e.GetPosition(mapCanvas);

            if (isMultiSelecting)
            {
                // Display all the squares in this region.
                //RectangleGeometry geometry = new RectangleGeometry(
                //    new Rect(selectionSquareTopLeft, e.GetPosition(mapCanvas)));
                mapCanvas.DeleteVisual(selectionSquare);
                DrawMultiRec(pointClickLeft, pointClicked);
                isMultiSelecting = false;
               
                mapCanvas.ReleaseMouseCapture();

                // send selected point to multiCollection 
                pointCollect.SelectedPointsSend = false;
                pointCollect.SelectedPointsSend = true;


            }
        }

        public void DrawMultiRec(Point pointStart, Point pointStop) // LeftMouseBUtton draging
        {
            
            int m = (int)Math.Ceiling(pointStop.Y / 6) - (int)Math.Floor(pointStart.Y / 6); //行
            int n = (int)Math.Ceiling(pointStop.X / 8) - (int)Math.Floor(pointStart.X / 8); //列
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int x = (int)Math.Floor(pointStart.X / 8)*8 + j * 8;
                    int y = (int)Math.Floor(pointStart.Y / 6)*6 + i * 6;

                    Point point = new Point(x, y);
                    DrawRectangle(point, false);

                }
            }
        }

        public void DelMultiRec(Point pointStart, Point pointStop) // RightMouseBUtton draging
        {

            int m = (int)Math.Ceiling(pointStop.Y / 6) - (int)Math.Floor(pointStart.Y / 6); //行
            int n = (int)Math.Ceiling(pointStop.X / 8) - (int)Math.Floor(pointStart.X / 8); //列
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int x = (int)Math.Floor((pointStart.X) / 8) * 8 + j * 8;
                    int y = (int)Math.Floor((pointStart.Y) / 6) * 6 + i * 6;

                    int a = (int)Math.Floor((double)x / 8);
                    int b = (int)Math.Floor((double)y / 6);
                    Point point = new Point(x + 4, y + 3);
                    if (x >= 300 || y >= 300) continue;
                    DrawingVisual visual = mapCanvas.GetVisual(point);
                    if (visual != null)
                    {
                        Point removePoint = new Point(a * 8, b * 6);
                        if (visual.GetType() == typeof(DrawingVisualE))
                        {
                            mapCanvas.DeleteVisual(visual);
                            DrawingVisual visual1 = mapCanvas.GetVisual(point);
                            mapCanvas.DeleteVisual(visual1);

                        }
                        int p = mapArrray[b, a];
                        int Q = selectedPoints.Count;

                        mapCanvas.DeleteVisual(visual);
                        mapArrray[b, a] = 0;
                        selectedPoints.Remove(removePoint);

                    }
                    if (b >= 50 || a >= 37) continue;
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

        //public void DelMultiRec(Point pointStart, Point pointStop) // RightMouseBUtton draging
        //{

        //    int m = (int)Math.Ceiling(pointStop.Y / 6) - (int)Math.Floor(pointStart.Y / 6); //行
        //    int n = (int)Math.Ceiling(pointStop.X / 8) - (int)Math.Floor(pointStart.X / 8); //列
        //    for (int i = 0; i < m; i++)
        //    {
        //        for (int j = 0; j < n; j++)
        //        {
        //            int x = (int)Math.Floor((pointStart.X) / 8) * 8 + j * 8;
        //            int y = (int)Math.Floor((pointStart.Y) / 6) * 6 + i * 6;

        //            int a = (int)Math.Floor((double)x / 8);
        //            int b = (int)Math.Floor((double)y / 6);
        //            Point point = new Point(x+4 , y+3 );
        //            if (x >= 300 || y >= 300) continue;
        //            DrawingVisual visual = mapCanvas.GetVisual(point);
        //            if (visual != null)
        //            {
        //                if (visual.GetType() == typeof(DrawingVisualE))
        //                {
        //                    MessageBox.Show("11111");
        //                }
        //                Point removePoint = new Point(a * 8, b * 6);
        //                //if (selectedPoints.Contains(removePoint))
        //                //{
        //                //    mapCanvas.DeleteVisual(visual);
        //                //    mapArrray[b, a] = 0;
        //                //    selectedPoints.Remove(removePoint);
        //                //}
        //                int p = mapArrray[b, a];
        //                int Q = selectedPoints.Count;

        //                mapCanvas.DeleteVisual(visual);
        //                mapArrray[b, a] = 0;
        //                selectedPoints.Remove(removePoint);

        //            }
        //            else {
                        
        //               // MessageBox.Show("null"); 
                    
                    
                    
        //            }
        //            if (b >= 50 || a >= 37) continue;
        //        }

        //    }
        //    //int x = (int)Math.Floor((pointStart.X) / 8) * 8 ;
        //    //int y = (int)Math.Floor((pointStart.Y) / 6) * 6 ;
        //    //int x1 = (int)Math.Ceiling((pointStop.X) / 8) * 8;
        //    //int y1 = (int)Math.Ceiling((pointStop.Y) / 6) * 6;
        //    //foreach (Point item in selectedPoints)
        //    //{
        //    //    if(item.X>= x&& item.Y>=y&& item.X <= x1 && item.Y <= y1)
        //    //    {
        //    //        DrawingVisual visual = mapCanvas.GetVisual(item);
        //    //        if(visual !=null)
        //    //        {
        //    //            mapCanvas.DeleteVisual(visual);
        //    //        }
        //    //        else
        //    //        {
        //    //            MessageBox.Show("null");
        //    //        }

        //    //    }


        //    //}
















        //    //Double moveButtonX = Canvas.GetLeft(moveButton) + 4;
        //    //Double moveButtonY = Canvas.GetTop(moveButton) + 3;
        //    //Point moveButtonPoint = new Point(moveButtonX, moveButtonY);
        //    //int moveButtonX1 = (int)Math.Floor(moveButtonPoint.X / 8);
        //    //int moveButtonY1 = (int)Math.Floor(moveButtonPoint.Y / 6);

        //    //Point moveButtonPoint1 = new Point(moveButtonX1 * 8, moveButtonY1 * 6);
        //    //if (selectedPoints.Contains(moveButtonPoint1) == false)
        //    //{
        //    //    moveButton.Tag = 2;
        //    //}
        //    //// send selected point to multiCollection 
        //    //pointCollect.SelectedPointsSend = false;
        //    //pointCollect.SelectedPointsSend = true;
        //}



        private void mapCanvas_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sender is Label lab) lab.Tag = 2;
            Point pointClicked = e.GetPosition(mapCanvas);
            pointClickRight = pointClicked;

            if (e.RightButton == MouseButtonState.Pressed)
            {
                selectionSquare = new DrawingVisualE();

                mapCanvas.AddVisual(selectionSquare);

                selectionSquareTopLeft = pointClicked;
                isDraging = true;

                // Make sure we get the MouseLeftButtonUp event even if the user
                // moves off the Canvas. Otherwise, two selection squares could be drawn at once.
                mapCanvas.CaptureMouse();

            }

            int x = (int)Math.Floor(pointClicked.X / 8);
            int y = (int)Math.Floor(pointClicked.Y / 6);
            if (x >= 300 || y >= 300) return;
            //DrawingVisual visual = mapCanvas.GetVisual(pointClicked);
            //if (visual != null)
            //{
            //    mapCanvas.DeleteVisual(visual);
            //    if (y >= 50 || x >= 37) return;
            //    mapArrray[y, x] = 0;
            //    Point removePoint = new Point(x * 8, y * 6);
            //    selectedPoints.Remove(removePoint);
            //}

            Double moveButtonX = Canvas.GetLeft(moveButton)+4;
            Double moveButtonY = Canvas.GetTop(moveButton)+3;
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
            int i = mapArrray[0, 0];

        }

        private void mapCanvas_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            Point pointClicked = e.GetPosition(mapCanvas);

            if (isDraging)
            {

                DelMultiRec(pointClickRight, pointClicked);
                isDraging = false;
              
                if (selectionSquare == null)
                {
                    MessageBox.Show("11111");
                }
                mapCanvas.DeleteVisual(selectionSquare);
                mapCanvas.ReleaseMouseCapture();

            }
        }


       

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

        }
       
       
    }
}

