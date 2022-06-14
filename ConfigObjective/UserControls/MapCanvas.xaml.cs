using Lambda;
using System;
using System.Collections.Generic;
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
        }
        private void UserControl_Initialized(object sender, EventArgs e)
        {
            LambdaControl.AddLambdaEventHandler("TestDataEvent", TestDataEvent, false);
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
                    //GCHandle pinnedArray = GCHandle.Alloc(aaa, GCHandleType.Pinned);
                    //IntPtr pointer = pinnedArray.AddrOfPinnedObject();
                    //pinnedArray.Free();

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
        int[,] mapArrray = new int[42, 30];
        private bool isMultiSelecting = false;
        private bool isDraging = false;
        private Point pointClickLeft;
        private Point pointClickRight;
        public DrawingVisual selectedVisual;
        // Drawing constants.
        private Brush drawingBrush0 = Brushes.Blue;
        private Brush drawingBrush1 = Brushes.Red;
        private Pen drawingPen = new Pen(Brushes.SteelBlue, 0.1);
        private Size squareSize = new Size(10, 7);
        private DrawingVisual selectionSquare;

        private Brush selectionSquareBrush = Brushes.Transparent;
        private Pen selectionSquarePen = new Pen(Brushes.Black, 1);





        private void mapCanvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Point pointClicked = e.GetPosition(mapCanvas);
            pointClickLeft = pointClicked;

            if (e.ClickCount == 2)
            {
                MessageBox.Show("Move to " + "(" + pointClicked.X.ToString() + "," + pointClicked.Y.ToString() + ")");
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

        public void DrawRectangle(Point point, bool bol) // draw rectangle
        {
            selectionSquareTopLeft = point;

            int x = (int)Math.Floor(point.X / 10);
            int y = (int)Math.Floor(point.Y / 7);

            Point drawpoint = new Point(x * 10, y * 7);
            // Rectangle Point 
            double Rx1 = Math.Pow(x * 10 - 150, 2.0);
            double Ry1 = Math.Pow(y * 7 - 150, 2.0);
            double Rx2 = Math.Pow(x * 10 + 10 - 150, 2.0);
            double Ry2 = Math.Pow(y * 7 - 150, 2.0);
            double Rx3 = Math.Pow(x * 10 - 150, 2.0);
            double Ry3 = Math.Pow(y * 7 + 7 - 150, 2.0);
            double Rx4 = Math.Pow(x * 10 + 10 - 150, 2.0);
            double Ry4 = Math.Pow(y * 7 + 7 - 150, 2.0);

            if (y >= 42 || x >= 30) return;

            if (Rx1 + Ry1 <= 22500 && Rx2 + Ry2 <= 22500 && Rx3 + Ry3 <= 22500 && Rx4 + Ry4 <= 22500 && mapArrray[y, x] == 0)
            {

                DrawingVisual visual = new DrawingVisual();

                DrawSquare(visual, drawpoint, false, drawingBrush0);

                visual.Opacity = 0.5;
                mapCanvas.AddVisual(visual);
                mapArrray[y, x] = 1;
            }
            else if (mapArrray[y, x] == 0)
            {
                DrawingVisual visual = new DrawingVisual();

                DrawSquare(visual, drawpoint, false, drawingBrush1);
                visual.Opacity = 0.5;
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
                RectangleGeometry geometry = new RectangleGeometry(
                    new Rect(selectionSquareTopLeft, e.GetPosition(mapCanvas)));
                DrawMultiRec(pointClickLeft, pointClicked);
                isMultiSelecting = false;
                mapCanvas.DeleteVisual(selectionSquare);
                mapCanvas.ReleaseMouseCapture();



            }
        }

        public void DrawMultiRec(Point pointStart, Point pointStop) // LeftMouseBUtton draging
        {
            int i, j;
            int m = (int)Math.Floor((pointStop.Y - pointStart.Y) / 7) + 1;
            int n = (int)Math.Floor((pointStop.X - pointStart.X) / 10) + 1;
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    int x = (int)pointStart.X + j * 10;
                    int y = (int)pointStart.Y + i * 7;

                    Point point = new Point(x, y);
                    DrawRectangle(point, false);

                }
            }
        }

        public void DelMultiRec(Point pointStart, Point pointStop) // RightMouseBUtton draging
        {
            int i, j;
            int m = (int)Math.Floor((pointStop.Y - pointStart.Y) / 7) + 1;
            int n = (int)Math.Floor((pointStop.X - pointStart.X) / 10) + 1;
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    int x = (int)pointStart.X + j * 10;
                    int y = (int)pointStart.Y + i * 7;
                    int c = x;
                    int d = y;
                    int a = (int)Math.Floor((double)c / 10);
                    int b = (int)Math.Floor((double)d / 7);
                    Point point = new Point(x, y);
                    if (x >= 300 || y >= 300) return;
                    DrawingVisual visual = mapCanvas.GetVisual(point);
                    if (visual != null) mapCanvas.DeleteVisual(visual);
                    if (b >= 42 || a >= 30) return;
                    mapArrray[b, a] = 0;

                }
            }
        }





        private void mapCanvas_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
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

            int x = (int)Math.Floor(pointClicked.X / 10);
            int y = (int)Math.Floor(pointClicked.Y / 7);
            if (x >= 300 || y >= 300) return;
            DrawingVisual visual = mapCanvas.GetVisual(pointClicked);
            if (visual != null)
            {
                mapCanvas.DeleteVisual(visual);
                if (y >= 42 || x >= 30) return;
                mapArrray[y, x] = 0;

            }



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


    }
}

