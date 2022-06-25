using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace Global
{
    public class DrawMethod
    {
        public Brush selectionGeometryBrush = Brushes.Transparent;
        public Pen selectionSquarePen = new Pen(Brushes.Red, 2);
        public DrawingVisual selectionSquare;
        public DrawingVisual LineVisual;
        // public DrawingVisual CircleSquare;
        public DrawingVisual circleVisual;
        public DrawingVisual polygonVisual;
        public DrawingVisual arrowVisual;
        public List<Point> PolygonList = new List<Point>();


        public void DrawSelectionSquare(Point point1, Point point2)
        {
            var isShift = Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift);
            selectionSquarePen.DashStyle = DashStyles.Dash;

            using (DrawingContext dc = selectionSquare.RenderOpen())
            {
                double deltaX = point2.X - point1.X;
                double deltaY = point2.Y - point1.Y;
                double dist = Math.Sqrt((deltaX * deltaX) + (deltaY * deltaY));
                if (isShift)
                {

                    dc.DrawRectangle(selectionGeometryBrush, selectionSquarePen,
                       new Rect(point1.X, point1.Y, dist / 2, dist / 2));
                    return;
                }

                dc.DrawRectangle(selectionGeometryBrush, selectionSquarePen,
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




    }
}
