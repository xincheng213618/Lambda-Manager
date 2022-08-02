using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Global
{
    public class DrawMethod 
    {
        public Brush selectionGeometryBrush = Brushes.Transparent;
        public static Brush pixelRecBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#595959"));
        private Pen pixelRecPen = new Pen(pixelRecBrush, 1);
        private Pen pixelPen = new Pen(Brushes.White, 1);
        private Size squareSize = new Size(120, 130);
        public Pen selectionSquarePen = new Pen(Brushes.Red, 2);
        public Pen deleteSquarePen = new Pen(Brushes.Black, 2);
        public DrawingVisual RectangleVisual;
        public DrawingVisual LineVisual;
        public DrawingVisual dimensionVisual;
        public DrawingVisual circleVisual;
        public DrawingVisual polygonVisual;
        public DrawingVisual arrowVisual; 
        public DimenViewModel dimenViewModel = new DimenViewModel();
        public DrawingVisual pixelVisual = new DrawingVisual();
        public List<Point> PolygonList= new List<Point>() ;
        public bool isDragging = false;
        public Point translateOri = new Point(0, 0);
        public DrawingVisual selectedVisual;
        public DrawingVisual deleteVisual;
        private int[] pixelData;
        private int _red;
        private int _green;
        private int _blue;

        public void DrawSelectionSquare(Point point1, Point point2)
        {
            var isShift = Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift);
            selectionSquarePen.DashStyle = DashStyles.Dash;

            using (DrawingContext dc = RectangleVisual.RenderOpen())
            {
                double deltaX = point2.X - point1.X;
                double deltaY = point2.Y - point1.Y;
                double dist = Math.Sqrt((deltaX * deltaX) + (deltaY * deltaY)) / 1.4;
                if (isShift)
                {

                    // dc.DrawRectangle(selectionGeometryBrush, selectionSquarePen,
                    //  new Rect(point1.X, point1.Y, dist / 2, dist / 2));
                    if (deltaX > 0 && deltaY > 0)
                    {
                        Point pointRD = new Point(point1.X + dist, point1.Y + dist);
                        dc.DrawRectangle(selectionGeometryBrush, selectionSquarePen,
                   new Rect(point1, pointRD));

                    }
                    else if (deltaX > 0 && deltaY < 0)
                    {
                        Point pointRU = new Point(point1.X + dist, point1.Y - dist);
                        dc.DrawRectangle(selectionGeometryBrush, selectionSquarePen,
                   new Rect(point1, pointRU));

                    }
                    else if (deltaX < 0 && deltaY > 0)
                    {
                        Point pointLD = new Point(point1.X - dist, point1.Y + dist);
                        dc.DrawRectangle(selectionGeometryBrush, selectionSquarePen,
                   new Rect(point1, pointLD));

                    }
                    else if (deltaX < 0 && deltaY < 0)
                    {
                        Point pointLU = new Point(point1.X - dist, point1.Y - dist);
                        dc.DrawRectangle(selectionGeometryBrush, selectionSquarePen,
                   new Rect(point1, pointLU));

                    }

                    return;

                }

                dc.DrawRectangle(selectionGeometryBrush, selectionSquarePen,
                    new Rect(point1, point2));

            }
        }
        public void DrawDeleteSquare(Point point1, Point point2)
        {
            deleteSquarePen.DashStyle = DashStyles.Dash;

            using (DrawingContext dc = deleteVisual.RenderOpen())
            {
                dc.DrawRectangle(selectionGeometryBrush, deleteSquarePen,
                    new Rect(point1, point2));

            }
        }
        public void DrawArrow(Point point1, Point point2)
        {
            selectionSquarePen.DashStyle = DashStyles.Dash;

            using (DrawingContext dc = arrowVisual.RenderOpen())
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
                dc.DrawGeometry(selectionGeometryBrush, selectionSquarePen, geometry);

                geometry = new PathGeometry();
                figure = new PathFigure
                {
                    StartPoint = point2,
                    IsClosed = false,
                    IsFilled = true,
                };
                figure.Segments.Add(new LineSegment(pt3, true));
                geometry.Figures.Add(figure);
                dc.DrawGeometry(selectionGeometryBrush, selectionSquarePen, geometry);
                geometry = new PathGeometry();
                figure = new PathFigure
                {
                    StartPoint = point2,
                    IsClosed = false,
                    IsFilled = true,
                };
                figure.Segments.Add(new LineSegment(pt4, true));
                geometry.Figures.Add(figure);
                dc.DrawGeometry(selectionGeometryBrush, selectionSquarePen, geometry);

            }

        }





        public void DrawPolygon(Point point1, Point point2)
        {
            selectionSquarePen.DashStyle = DashStyles.Dash;
            using (DrawingContext dc = polygonVisual.RenderOpen())
            {
                dc.DrawLine(selectionSquarePen, point1, point2);
            }
        }


        public void DrawLine(Point point1, Point point2)
        {
           
            var isShift = Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift);

            selectionSquarePen.DashStyle = DashStyles.Dash;
            using (DrawingContext dc = LineVisual.RenderOpen())
            {
                double deltaX = Math.Abs(point1.X - point2.X);
                double deltaY = Math.Abs(point1.Y - point2.Y);
                if (isShift)
                {
                    if (deltaX < deltaY) point2.X = point1.X;
                    if (deltaX > deltaY) point2.Y = point1.Y;
                }

                dc.DrawLine(selectionSquarePen, point1, point2);

            }
        }



        public void DrawEllipse(Point point1, Point point2)
        {
            selectionSquarePen.DashStyle = DashStyles.Dash;

            var isShift = Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift);
            double radiusX = Math.Abs(point1.X - point2.X) / 2;
            double radiusY = Math.Abs(point1.Y - point2.Y) / 2;
            double radius = Math.Min(Math.Abs(point1.X - point2.X) / 2, Math.Abs(point1.Y - point2.Y) / 2);
            Point center = new Point((point1.X + point2.X) / 2, (point1.Y + point2.Y) / 2);
            using (DrawingContext dc = circleVisual.RenderOpen())
            {
                if (isShift)
                {
                    dc.DrawEllipse(selectionGeometryBrush, selectionSquarePen,
                  center, radius, radius);
                }
                else
                {
                    dc.DrawEllipse(selectionGeometryBrush, selectionSquarePen,
                                     center, radiusX, radiusY);
                }
            }


        }


        public void DrawingPoly( Point point ,bool isClosed)
        {

            if (PolygonList.Count > 0 && !isClosed)
            {
                selectionSquarePen.DashStyle = DashStyles.Dash;
               // PolygonPoint = point;
                
                PolygonList.Add(point);
                DrawingContent();
            }
            else if (PolygonList.Count == 0)
            {
               PolygonList.Add(point);
              // drawingSurface.Focusable = true;
            }
            else if (PolygonList.Count > 0 && isClosed)
            {
                selectionSquarePen.DashStyle = DashStyles.Dash;
                PolygonList.Add(PolygonList[0]);
                DrawingContent();
                PolygonList.Clear();
            }
        }

        public void DrawingContent()
        {
            using (DrawingContext dc = polygonVisual.RenderOpen())
            {

                for (int i = 0; i < PolygonList.Count - 1; i++)
                {
                    dc.DrawLine(selectionSquarePen, PolygonList[i], PolygonList[i + 1]);
                }
            }
        }
       
        public void LoadPixelData(WriteableBitmap bitmapImage, Point point1, double width, double height)
        {
            //var bitmapImage = new BitmapImage(new Uri("/Global;component/usercontrols/image/startpicture1.png", UriKind.Relative));
            int stride = ((bitmapImage.PixelWidth * bitmapImage.Format.BitsPerPixel) + 7) / 8;
            var pixelByteArray = new byte[bitmapImage.PixelHeight * stride];
            bitmapImage.CopyPixels(pixelByteArray, stride, 0);
            double pixelHeight;
            double pixelWidth;
            pixelHeight = Math.Round(point1.Y * bitmapImage.PixelHeight / height);
            pixelWidth = Math.Round(point1.X * bitmapImage.PixelWidth / width);
            int colorOrder = (int)Math.Round((pixelHeight * stride + pixelWidth * 3));
            _red = (int)pixelByteArray[colorOrder + 2];
            _green = (int)pixelByteArray[colorOrder + 1];
            _blue = (int)pixelByteArray[colorOrder];

        }



        public void DrawPixelSquare(WriteableBitmap bitmapImage,  DrawingVisual visual, Point topLeftCorner, double width, double height)
        {
            using (DrawingContext dc = visual.RenderOpen())
            {

                if (topLeftCorner.X < 0 || topLeftCorner.Y < 0 || topLeftCorner.X >= width || topLeftCorner.Y >= height)
                    return;
                LoadPixelData(bitmapImage, topLeftCorner, width, height);
                pixelPen.DashStyle = DashStyles.Dash;
                dc.DrawRectangle(selectionGeometryBrush, pixelRecPen,
                    new Rect(topLeftCorner, squareSize));
                dc.DrawRectangle(pixelRecBrush, pixelRecPen,
                   new Rect(new Point(topLeftCorner.X, topLeftCorner.Y + 90), new Size(120, 40)));
                string label = "X Y " + "(" + (int)topLeftCorner.X + "," +(int)topLeftCorner.Y + ")";
                string label1 = "RGB " + "(" + _red + "," + _green + "," + _blue + ")";
                dc.DrawText(new FormattedText(label, CultureInfo.CurrentCulture,
                FlowDirection.LeftToRight, new Typeface("Arial"), 14, Brushes.White, 1.25), new Point(topLeftCorner.X, topLeftCorner.Y + 90));
                dc.DrawText(new FormattedText(label1, CultureInfo.CurrentCulture,
                FlowDirection.LeftToRight, new Typeface("Arial"), 14, Brushes.White, 1.25), new Point(topLeftCorner.X, topLeftCorner.Y + 110));
                // var bitmapImage = new BitmapImage(new Uri("/Global;component/usercontrols/image/startpicture1.png", UriKind.Relative));
                if (topLeftCorner.X > 30 && topLeftCorner.Y > 22.5 && topLeftCorner.X < width - 30 && topLeftCorner.Y < height - 22.5)
                {
                    double w = bitmapImage.Width / width;
                    double h = bitmapImage.Height / height;

                    int RecW = (int)(60 * w);
                    int RecH = (int)(45 * h);
                    int x = (int)(topLeftCorner.X * w) - RecW / 2;
                    int y = (int)(topLeftCorner.Y * h) - RecH / 2;
                    var croppedBitmap = new CroppedBitmap(bitmapImage, new Int32Rect(x, y, RecW, RecH));
                    dc.DrawImage(croppedBitmap, new Rect(topLeftCorner, new Size(120, 90)));

                }

                dc.DrawLine(pixelPen, new Point(topLeftCorner.X, topLeftCorner.Y + 45), new Point(topLeftCorner.X + 120, topLeftCorner.Y + 45));
                dc.DrawLine(pixelPen, new Point(topLeftCorner.X + 60, topLeftCorner.Y), new Point(topLeftCorner.X + 60, topLeftCorner.Y + 90));


            }






        }
        public void DrawPixelSquareLeft(WriteableBitmap bitmapImage, DrawingVisual visual, Point topRightCorner, double width, double height)
        {
            using (DrawingContext dc = visual.RenderOpen())
            {

                if (topRightCorner.X < 0 || topRightCorner.Y < 0 || topRightCorner.X >= width || topRightCorner.Y >= height)
                    return;
                LoadPixelData(bitmapImage, topRightCorner, width, height);
                pixelPen.DashStyle = DashStyles.Dash;
                dc.DrawRectangle(selectionGeometryBrush, pixelRecPen,
                    new Rect(new Point(topRightCorner.X-120,topRightCorner.Y), squareSize));
                dc.DrawRectangle(pixelRecBrush, pixelRecPen,
                   new Rect(new Point(topRightCorner.X-120, topRightCorner.Y + 90), new Size(120, 40)));
                string label = "X Y " + "(" + (int)topRightCorner.X + "," +(int)topRightCorner.Y + ")";
                string label1 = "RGB " + "(" + _red + "," + _green + "," + _blue + ")";
                dc.DrawText(new FormattedText(label, CultureInfo.CurrentCulture,
                FlowDirection.LeftToRight, new Typeface("Arial"), 14, Brushes.White, 1.25), new Point(topRightCorner.X-120, topRightCorner.Y + 90));
                dc.DrawText(new FormattedText(label1, CultureInfo.CurrentCulture,
                FlowDirection.LeftToRight, new Typeface("Arial"), 14, Brushes.White, 1.25), new Point(topRightCorner.X-120, topRightCorner.Y + 110));
                // var bitmapImage = new BitmapImage(new Uri("/Global;component/usercontrols/image/startpicture1.png", UriKind.Relative));
                if (topRightCorner.X > 30 && topRightCorner.Y > 22.5 && topRightCorner.X < width - 30 && topRightCorner.Y < height - 22.5)
                {
                    double w = bitmapImage.Width / width;
                    double h = bitmapImage.Height / height;

                    int RecW = (int)(60 * w);
                    int RecH = (int)(45 * h);
                    int x = (int)(topRightCorner.X * w) - RecW / 2;
                    int y = (int)(topRightCorner.Y * h) - RecH / 2;
                    var croppedBitmap = new CroppedBitmap(bitmapImage, new Int32Rect(x, y, RecW, RecH));
                    dc.DrawImage(croppedBitmap, new Rect(new Point(topRightCorner.X-120, topRightCorner.Y), new Size(120, 90)));

                }

                dc.DrawLine(pixelPen, new Point(topRightCorner.X-120, topRightCorner.Y + 45), new Point(topRightCorner.X , topRightCorner.Y + 45));
                dc.DrawLine(pixelPen, new Point(topRightCorner.X-60, topRightCorner.Y), new Point(topRightCorner.X - 60, topRightCorner.Y + 90));

            }

        }

        public void DrawPixelSquareUp(WriteableBitmap bitmapImage, DrawingVisual visual, Point bottomLeftCorner, double width, double height)
        {
            using (DrawingContext dc = visual.RenderOpen())
            {
                if (bottomLeftCorner.X < 0 || bottomLeftCorner.Y < 0 || bottomLeftCorner.X >= width || bottomLeftCorner.Y >= height)
                    return;
                LoadPixelData(bitmapImage, bottomLeftCorner, width, height);
                pixelPen.DashStyle = DashStyles.Dash;
                dc.DrawRectangle(selectionGeometryBrush, pixelRecPen,
                    new Rect(new Point(bottomLeftCorner.X, bottomLeftCorner.Y-130) , squareSize));
                dc.DrawRectangle(pixelRecBrush, pixelRecPen,
                   new Rect(new Point(bottomLeftCorner.X, bottomLeftCorner.Y - 40), new Size(120, 40)));
                string label = "X Y " + "(" + (int)bottomLeftCorner.X + "," + (int)bottomLeftCorner.Y + ")";
                string label1 = "RGB " + "(" + _red + "," + _green + "," + _blue + ")";
                dc.DrawText(new FormattedText(label, CultureInfo.CurrentCulture,
                FlowDirection.LeftToRight, new Typeface("Arial"), 14, Brushes.White, 1.25), new Point(bottomLeftCorner.X, bottomLeftCorner.Y - 40));
                dc.DrawText(new FormattedText(label1, CultureInfo.CurrentCulture,
                FlowDirection.LeftToRight, new Typeface("Arial"), 14, Brushes.White, 1.25), new Point(bottomLeftCorner.X, bottomLeftCorner.Y - 20));
                // var bitmapImage = new BitmapImage(new Uri("/Global;component/usercontrols/image/startpicture1.png", UriKind.Relative));
                if (bottomLeftCorner.X > 30 && bottomLeftCorner.Y > 22.5 && bottomLeftCorner.X < width - 30 && bottomLeftCorner.Y < height - 22.5)
                {
                    double w = bitmapImage.Width / width;
                    double h = bitmapImage.Height / height;

                    int RecW = (int)(60 * w);
                    int RecH = (int)(45 * h);
                    int x = (int)(bottomLeftCorner.X * w) - RecW / 2;
                    int y = (int)(bottomLeftCorner.Y * h) - RecH / 2;
                    var croppedBitmap = new CroppedBitmap(bitmapImage, new Int32Rect(x, y, RecW, RecH));
                    dc.DrawImage(croppedBitmap, new Rect(new Point(bottomLeftCorner.X,bottomLeftCorner.Y-130), new Size(120, 90)));

                }

                dc.DrawLine(pixelPen, new Point(bottomLeftCorner.X, bottomLeftCorner.Y - 85), new Point(bottomLeftCorner.X + 120, bottomLeftCorner.Y -85));
                dc.DrawLine(pixelPen, new Point(bottomLeftCorner.X + 60, bottomLeftCorner.Y-130), new Point(bottomLeftCorner.X + 60, bottomLeftCorner.Y -40));

            }
        }

        public void DrawPixelSquareLeftUp(WriteableBitmap bitmapImage, DrawingVisual visual, Point bottomLeftCorner, double width, double height)
        {
            using (DrawingContext dc = visual.RenderOpen())
            {
                if (bottomLeftCorner.X < 0 || bottomLeftCorner.Y < 0 || bottomLeftCorner.X >= width || bottomLeftCorner.Y >= height)
                    return;
                LoadPixelData(bitmapImage, bottomLeftCorner, width, height);
                pixelPen.DashStyle = DashStyles.Dash;
                dc.DrawRectangle(selectionGeometryBrush, pixelRecPen,
                    new Rect(new Point(bottomLeftCorner.X-120, bottomLeftCorner.Y - 130), squareSize));
                dc.DrawRectangle(pixelRecBrush, pixelRecPen,
                   new Rect(new Point(bottomLeftCorner.X-120, bottomLeftCorner.Y - 40), new Size(120, 40)));
                string label = "X Y " + "(" + (int)bottomLeftCorner.X + "," + (int)bottomLeftCorner.Y + ")";
                string label1 = "RGB " + "(" + _red + "," + _green + "," + _blue + ")";
                dc.DrawText(new FormattedText(label, CultureInfo.CurrentCulture,
                FlowDirection.LeftToRight, new Typeface("Arial"), 14, Brushes.White, 1.25), new Point(bottomLeftCorner.X-120, bottomLeftCorner.Y - 40));
                dc.DrawText(new FormattedText(label1, CultureInfo.CurrentCulture,
                FlowDirection.LeftToRight, new Typeface("Arial"), 14, Brushes.White, 1.25), new Point(bottomLeftCorner.X-120, bottomLeftCorner.Y - 20));
                // var bitmapImage = new BitmapImage(new Uri("/Global;component/usercontrols/image/startpicture1.png", UriKind.Relative));
                if (bottomLeftCorner.X > 30 && bottomLeftCorner.Y > 22.5 && bottomLeftCorner.X < width - 30 && bottomLeftCorner.Y < height - 22.5)
                {
                    double w = bitmapImage.Width / width;
                    double h = bitmapImage.Height / height;

                    int RecW = (int)(60 * w);
                    int RecH = (int)(45 * h);
                    int x = (int)(bottomLeftCorner.X * w) - RecW / 2;
                    int y = (int)(bottomLeftCorner.Y * h) - RecH / 2;
                    var croppedBitmap = new CroppedBitmap(bitmapImage, new Int32Rect(x, y, RecW, RecH));
                    dc.DrawImage(croppedBitmap, new Rect(new Point(bottomLeftCorner.X-120, bottomLeftCorner.Y - 130), new Size(120, 90)));

                }

                dc.DrawLine(pixelPen, new Point(bottomLeftCorner.X-120, bottomLeftCorner.Y - 85), new Point(bottomLeftCorner.X, bottomLeftCorner.Y - 85));
                dc.DrawLine(pixelPen, new Point(bottomLeftCorner.X-60, bottomLeftCorner.Y - 130), new Point(bottomLeftCorner.X-60, bottomLeftCorner.Y - 40));

            }
        }

        public void DrawDimension(double length, double height, double ratio, Point point1, Point point2,bool isdefault,DrawingVisual drawingVisual )
        {
            if (isdefault)
            {
                point1.X = length - 100* ratio / 1689.12 * length - length*1/20;
                point1.Y = height*19/20;
                point2.X = length - length * 1 / 20;
                point2.Y = height * 19 / 20;
            }
            Brush brush = new SolidColorBrush(dimenViewModel.SelectedAccentColor);
            Pen selectionPen = new Pen(brush, 2);
            var isShift = Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift);
            double deltaX = Math.Abs(point1.X - point2.X);
            double deltaY = Math.Abs(point1.Y - point2.Y);
            if (isShift)
            {
                if (deltaX < deltaY) point2.X = point1.X;
                if (deltaX > deltaY) point2.Y = point1.Y;
            }




            selectionSquarePen.DashStyle = DashStyles.Solid;
            using (DrawingContext dc = drawingVisual.RenderOpen())
            {

                double x1 = point1.X;
                double y1 = point1.Y;
                double x2 = point2.X;
                double y2 = point2.Y;
                double dist = Math.Sqrt(((x1 - x2) * (x1 - x2)) + ((y1 - y2) * (y1 - y2)));
                double arrowLength = Math.Min(15, dist);
                double arrowAngle = Math.PI / 12;
                double endBarLength = Math.Min(10, dist);

                double angleOri = Math.Atan((y2 - y1) / (x2 - x1));
                if (x2 - x1 == 0) angleOri = -Math.Atan((y2 - y1) / (x2 - x1));
                double angle = Math.Atan2((y2 - y1), (x2 - x1));
                double angleDown = angleOri - arrowAngle;
                double angleUp = angleOri + arrowAngle;

                int directionFlag = (x2 > x1) ? -1 : 1;

                double x3 = x2 + (directionFlag * arrowLength * Math.Cos(angleDown));
                double y3 = y2 + (directionFlag * arrowLength * Math.Sin(angleDown));
                double x4 = x2 + (directionFlag * arrowLength * Math.Cos(angleUp));
                double y4 = y2 + (directionFlag * arrowLength * Math.Sin(angleUp));
                double x5 = x1 + (-directionFlag * arrowLength * Math.Cos(angleDown));
                double y5 = y1 + (-directionFlag * arrowLength * Math.Sin(angleDown));
                double x6 = x1 + (-directionFlag * arrowLength * Math.Cos(angleUp));
                double y6 = y1 + (-directionFlag * arrowLength * Math.Sin(angleUp));

                double x11 = x1 + (directionFlag * endBarLength * Math.Cos(angle + Math.PI / 2));
                double y11 = y1 + (directionFlag * endBarLength * Math.Sin(angle + Math.PI / 2));
                double x12 = x1 + (directionFlag * endBarLength * Math.Cos(angle - Math.PI / 2));
                double y12 = y1 + (directionFlag * endBarLength * Math.Sin(angle - Math.PI / 2));

                double x21 = x2 + (-directionFlag * endBarLength * Math.Cos(angle - Math.PI / 2));
                double y21 = y2 + (-directionFlag * endBarLength * Math.Sin(angle - Math.PI / 2));
                double x22 = x2 + (-directionFlag * endBarLength * Math.Cos(angle + Math.PI / 2));
                double y22 = y2 + (-directionFlag * endBarLength * Math.Sin(angle + Math.PI / 2));

                Point pt1 = new Point(x1, y1);//original
                Point pt2 = new Point(x2, y2);//destination
                Point pt3 = new Point(x3, y3);//destination arrow up point
                Point pt4 = new Point(x4, y4);//destination arrow down point
                Point pt5 = new Point(x5, y5);//original arrow up point
                Point pt6 = new Point(x6, y6);//original arrow down point

                Point pt11 = new Point(x11, y11);// original barend up
                Point pt12 = new Point(x12, y12);//original barend down
                Point pt21 = new Point(x21, y21);// destination barend up 
                Point pt22 = new Point(x22, y22);//destination barend down                  

                PathGeometry geometry = new PathGeometry();
                PathFigure figure = new PathFigure
                {
                    StartPoint = pt1,
                    IsClosed = false,
                    IsFilled = true,
                };
                figure.Segments.Add(new LineSegment(pt2, true)); //Main
                geometry.Figures.Add(figure);
                dc.DrawGeometry(selectionGeometryBrush, selectionPen, geometry);

                dimenViewModel.Length = (double)dist /length * 1689.12/ratio;

                if (angle / Math.PI * 180 == 0)
                {
                    dimenViewModel.Angle = 0;
                }
                else
                {
                    dimenViewModel.Angle = angle / Math.PI * 180;

                }


                if (dimenViewModel.DimSelectedIndex == 0)
                {
                    geometry = new PathGeometry();
                    figure = new PathFigure
                    {
                        StartPoint = pt1,
                        IsClosed = false,
                        IsFilled = true,
                    };
                    figure.Segments.Add(new LineSegment(pt11, true));
                    geometry.Figures.Add(figure);
                    dc.DrawGeometry(selectionGeometryBrush, selectionPen, geometry);
                    geometry = new PathGeometry();
                    figure = new PathFigure
                    {
                        StartPoint = pt2,
                        IsClosed = false,
                        IsFilled = true,
                    };
                    figure.Segments.Add(new LineSegment(pt21, true));
                    geometry.Figures.Add(figure);
                    dc.DrawGeometry(selectionGeometryBrush, selectionPen, geometry);

                }

                if (dimenViewModel.DimSelectedIndex == 1 || dimenViewModel.DimSelectedIndex == 2 || dimenViewModel.DimSelectedIndex == 3)
                {
                    geometry = new PathGeometry();
                    figure = new PathFigure
                    {
                        StartPoint = pt11,
                        IsClosed = false,
                        IsFilled = true,
                    };
                    figure.Segments.Add(new LineSegment(pt12, true));
                    geometry.Figures.Add(figure);
                    dc.DrawGeometry(selectionGeometryBrush, selectionPen, geometry);

                }
                if (dimenViewModel.DimSelectedIndex == 1 || dimenViewModel.DimSelectedIndex == 2 || dimenViewModel.DimSelectedIndex == 4)
                {
                    geometry = new PathGeometry();
                    figure = new PathFigure
                    {
                        StartPoint = pt21,
                        IsClosed = false,
                        IsFilled = true,
                    };
                    figure.Segments.Add(new LineSegment(pt22, true));
                    geometry.Figures.Add(figure);
                    dc.DrawGeometry(selectionGeometryBrush, selectionPen, geometry);
                }


                if (dimenViewModel.DimSelectedIndex == 2 || dimenViewModel.DimSelectedIndex == 4)
                {
                    geometry = new PathGeometry();
                    figure = new PathFigure
                    {
                        StartPoint = pt2,
                        IsClosed = false,
                        IsFilled = true,
                    };
                    figure.Segments.Add(new LineSegment(pt3, true));

                    geometry.Figures.Add(figure);
                    dc.DrawGeometry(selectionGeometryBrush, selectionPen, geometry);
                    geometry = new PathGeometry();
                    figure = new PathFigure
                    {
                        StartPoint = pt2,
                        IsClosed = false,
                        IsFilled = true,
                    };
                    figure.Segments.Add(new LineSegment(pt4, true));
                    geometry.Figures.Add(figure);
                    dc.DrawGeometry(selectionGeometryBrush, selectionPen, geometry);
                }

                if (dimenViewModel.DimSelectedIndex == 2 || dimenViewModel.DimSelectedIndex == 3)
                {
                    geometry = new PathGeometry();
                    figure = new PathFigure
                    {
                        StartPoint = pt1,
                        IsClosed = false,
                        IsFilled = true,
                    };
                    figure.Segments.Add(new LineSegment(pt5, true));
                    geometry.Figures.Add(figure);
                    dc.DrawGeometry(selectionGeometryBrush, selectionPen, geometry);
                    geometry = new PathGeometry();
                    figure = new PathFigure
                    {
                        StartPoint = pt1,
                        IsClosed = false,
                        IsFilled = true,
                    };
                    figure.Segments.Add(new LineSegment(pt6, true));
                    geometry.Figures.Add(figure);
                    dc.DrawGeometry(selectionGeometryBrush, selectionPen, geometry);
                }

                FontStyle fontStyle = new FontStyle();
                FontWeight fontWeight = new FontWeight();
                FontStretch fontStretch = new FontStretch();
                if (dimenViewModel.Italic) fontStyle = FontStyles.Italic;
                if (dimenViewModel.Bold) fontWeight = FontWeights.Bold;
                Point labelPosition;
                string label = Math.Round(dimenViewModel.Length, 2).ToString() + " μm";
                FormattedText formattedText = new FormattedText(label, CultureInfo.CurrentCulture,

                                              FlowDirection.LeftToRight, new Typeface(dimenViewModel.FontFam, fontStyle, fontWeight, fontStretch), dimenViewModel.FontSize, Brushes.White, 1.25);
                int textHeight =(int)formattedText.Height;
                int textWidth = (int)formattedText.Width;

                if (dimenViewModel.Label || isdefault)
                {
                    switch (dimenViewModel.LabelPos)
                    {

                        case " 上左":

                            labelPosition = new Point(pt1.X + 5, pt1.Y - textHeight -10);
                            break;
                        case " 上中":
                            labelPosition = new Point((pt1.X + pt2.X- textWidth) / 2, (pt1.Y + pt2.Y) / 2 - textHeight - 10);
                            break;
                        case " 上右":
                            labelPosition = new Point(pt2.X - textWidth-5, pt2.Y - textHeight - 10);
                            break;

                        case " 下左":
                            labelPosition = new Point(pt1.X + 10, pt1.Y + 10);
                            break;
                        case " 下中":
                            labelPosition = new Point((pt1.X + pt2.X - textWidth) / 2, (pt1.Y + pt2.Y) / 2 + 10);
                            break;
                        case " 下右":
                            labelPosition = new Point(pt2.X - textWidth-5, pt2.Y + 10);
                            break;

                    }
                   // MessageBox.Show(formattedText.Width.ToString() + formattedText.Height.ToString());
                    dc.DrawText(formattedText, labelPosition);
                    if (dimenViewModel.UnderLine)
                    {
                        dc.DrawLine(pixelPen, new Point(labelPosition.X, labelPosition.Y+ textHeight +2), new Point(labelPosition.X + textWidth, labelPosition.Y+ textHeight+2));
                    }

                        
                }







            }

        }


    }


}




