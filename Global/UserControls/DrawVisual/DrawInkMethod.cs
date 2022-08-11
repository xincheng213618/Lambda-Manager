using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;

namespace Global
{
    public class DrawInkMethod
    {

        public DrawInkMethod()
        {
            //drawingAttributes = new DrawingAttributes
            //{
            //    //Color = Colors.Red,
            //    Color = dimenViewModel.SelectedAccentColor,
            //    Width = 2,
            //    Height = 2,
            //    StylusTip = StylusTip.Rectangle,
            //    FitToCurve = false,
            //    IsHighlighter = true,
            //    IgnorePressure = true,
            //};

        }

        public DrawingAttributes drawingAttributes = new DrawingAttributes()
        { //Color = Colors.Red,
            Color = dimenViewModel.SelectedAccentColor,
            Width = 2,
            Height = 2,
            StylusTip = StylusTip.Rectangle,
            FitToCurve = false,
            IsHighlighter = true,
            IgnorePressure = true,
        };
        public static DimenViewModel dimenViewModel = new DimenViewModel();
        public Stroke Dimstroke;
        public Stroke Textstroke;
        public Stroke GenerateLineStroke(System.Windows.Point st, System.Windows.Point ed)
        {
            List<System.Windows.Point> pointList = new List<System.Windows.Point>();
            StylusPointCollection point;
            Stroke stroke;
            pointList = new List<System.Windows.Point>{
                new System.Windows.Point(st.X, st.Y),
                new System.Windows.Point(ed.X, ed.Y)
            };
            point = new StylusPointCollection(pointList);
            stroke = new Stroke(point)
            {
                DrawingAttributes = drawingAttributes.Clone()
            };
            return stroke;
        }

        public Stroke GenerateDimensionStroke0(System.Windows.Point st, System.Windows.Point ed)
        {
            List<Point> pointList = new List<Point>();
            StylusPointCollection point;
            Stroke stroke;

            double w = 20, h = 7;
            double theta = Math.Atan2(st.Y - ed.Y, st.X - ed.X);
            double sint = Math.Sin(theta);
            double cost = Math.Cos(theta);

            double theta1 = Math.Atan2(ed.Y - st.Y, ed.X - st.X);
            double sint1 = Math.Sin(theta1);
            double cost1 = Math.Cos(theta1);

            pointList = new List<Point>
            {
                new Point(st.X, st.Y),
                //new Point (st.X-10*Math.Cos(theta1+Math.PI / 2),st.Y-10*Math.Sin(theta1+Math.PI / 2)),
                new Point (st.X-10*Math.Cos(theta1-Math.PI / 2),st.Y-10*Math.Sin(theta1-Math.PI / 2)),
                new Point(st.X, st.Y),
                new Point(ed.X , ed.Y),
                new Point (ed.X-10*Math.Cos(theta+Math.PI / 2),ed.Y-10*Math.Sin(theta+Math.PI / 2)),
                //new Point (ed.X-10*Math.Cos(theta-Math.PI / 2),ed.Y-10*Math.Sin(theta-Math.PI / 2)),

            };
            point = new StylusPointCollection(pointList);
            stroke = new Stroke(point)
            {
                DrawingAttributes = drawingAttributes.Clone()
            };
            return stroke;
        }




        public Stroke GenerateDimensionStroke1(System.Windows.Point st, System.Windows.Point ed)
        {
            List<Point> pointList = new List<Point>();
            StylusPointCollection point;
            Stroke stroke;

            double w = 20, h = 7;
            double theta = Math.Atan2(st.Y - ed.Y, st.X - ed.X);
            double sint = Math.Sin(theta);
            double cost = Math.Cos(theta);

            double theta1 = Math.Atan2(ed.Y - st.Y, ed.X - st.X);
            double sint1 = Math.Sin(theta1);
            double cost1 = Math.Cos(theta1);

            pointList = new List<Point>
            {
                new Point(st.X, st.Y),
                new Point (st.X-10*Math.Cos(theta1+Math.PI / 2),st.Y-10*Math.Sin(theta1+Math.PI / 2)),
                //new Point (st.X-10*Math.Cos(theta1-Math.PI / 2),st.Y-10*Math.Sin(theta1-Math.PI / 2)),
                new Point(st.X, st.Y),
                new Point(ed.X , ed.Y),
                //new Point (ed.X-10*Math.Cos(theta+Math.PI / 2),ed.Y-10*Math.Sin(theta+Math.PI / 2)),
                new Point (ed.X-10*Math.Cos(theta-Math.PI / 2),ed.Y-10*Math.Sin(theta-Math.PI / 2)),

            };
            point = new StylusPointCollection(pointList);
            stroke = new Stroke(point)
            {
                DrawingAttributes = drawingAttributes.Clone()
            };
            return stroke;
        }







        public Stroke GenerateDimensionStroke2(System.Windows.Point st, System.Windows.Point ed)
        {
            List<Point> pointList = new List<Point>();
            StylusPointCollection point;
            Stroke stroke;

            double w = 20, h = 7;
            double theta = Math.Atan2(st.Y - ed.Y, st.X - ed.X);
            double sint = Math.Sin(theta);
            double cost = Math.Cos(theta);

            double theta1 = Math.Atan2(ed.Y - st.Y, ed.X - st.X);
            double sint1 = Math.Sin(theta1);
            double cost1 = Math.Cos(theta1);

            pointList = new List<Point>
            {
                new Point(st.X, st.Y),
                new Point (st.X-10*Math.Cos(theta1+Math.PI / 2),st.Y-10*Math.Sin(theta1+Math.PI / 2)),
                new Point (st.X-10*Math.Cos(theta1-Math.PI / 2),st.Y-10*Math.Sin(theta1-Math.PI / 2)),
                new Point(st.X, st.Y),
                new Point(ed.X , ed.Y),
                new Point (ed.X-10*Math.Cos(theta+Math.PI / 2),ed.Y-10*Math.Sin(theta+Math.PI / 2)),
                new Point (ed.X-10*Math.Cos(theta-Math.PI / 2),ed.Y-10*Math.Sin(theta-Math.PI / 2)),

            };
            point = new StylusPointCollection(pointList);
            stroke = new Stroke(point)
            {
                DrawingAttributes = drawingAttributes.Clone()
            };
            return stroke;
        }





        public Stroke GenerateDimensionStroke4(System.Windows.Point st, System.Windows.Point ed)
        {
            List<Point> pointList = new List<Point>();
            StylusPointCollection point;
            Stroke stroke;

            double w = 20, h = 7;
            double theta = Math.Atan2(st.Y - ed.Y, st.X - ed.X);
            double sint = Math.Sin(theta);
            double cost = Math.Cos(theta);

            double theta1 = Math.Atan2(ed.Y - st.Y, ed.X - st.X);
            double sint1 = Math.Sin(theta1);
            double cost1 = Math.Cos(theta1);

            pointList = new List<Point>
            {
               new Point(st.X, st.Y),
                new Point(st.X + (w * cost1 - h * sint1), st.Y + (w * sint1 + h * cost1)),
                new Point(st.X, st.Y),
                new Point(st.X + (w * cost1 + h * sint1), st.Y - (h * cost1 - w * sint1)),
                new Point(st.X, st.Y),
                new Point (st.X-10*Math.Cos(theta1+Math.PI / 2),st.Y-10*Math.Sin(theta1+Math.PI / 2)),
                new Point (st.X-10*Math.Cos(theta1-Math.PI / 2),st.Y-10*Math.Sin(theta1-Math.PI / 2)),
                new Point(st.X, st.Y),
                new Point(ed.X , ed.Y),



            };
            point = new StylusPointCollection(pointList);
            stroke = new Stroke(point)
            {
                DrawingAttributes = drawingAttributes.Clone()
            };
            return stroke;
        }

        public Stroke GenerateDimensionStroke3(System.Windows.Point st, System.Windows.Point ed)
        {
            List<Point> pointList = new List<Point>();
            StylusPointCollection point;
            Stroke stroke;

            double w = 20, h = 7;
            double theta = Math.Atan2(st.Y - ed.Y, st.X - ed.X);
            double sint = Math.Sin(theta);
            double cost = Math.Cos(theta);

            double theta1 = Math.Atan2(ed.Y - st.Y, ed.X - st.X);
            double sint1 = Math.Sin(theta1);
            double cost1 = Math.Cos(theta1);

            pointList = new List<Point>
            {
                new Point(st.X, st.Y),
                new Point(st.X + (w * cost1 - h * sint1), st.Y + (w * sint1 + h * cost1)),
                new Point(st.X, st.Y),
                new Point(st.X + (w * cost1 + h * sint1), st.Y - (h * cost1 - w * sint1)),
                new Point(st.X, st.Y),
                new Point (st.X-10*Math.Cos(theta1+Math.PI / 2),st.Y-10*Math.Sin(theta1+Math.PI / 2)),
                new Point (st.X-10*Math.Cos(theta1-Math.PI / 2),st.Y-10*Math.Sin(theta1-Math.PI / 2)),
                new Point(st.X, st.Y),
                new Point(ed.X , ed.Y),
                new Point(ed.X + (w * cost - h * sint), ed.Y + (w * sint + h * cost)),
                new Point(ed.X,ed.Y),
                new Point(ed.X + (w * cost + h * sint), ed.Y - (h * cost - w * sint)),
                new Point(ed.X,ed.Y),
                new Point (ed.X-10*Math.Cos(theta+Math.PI / 2),ed.Y-10*Math.Sin(theta+Math.PI / 2)),
                new Point (ed.X-10*Math.Cos(theta-Math.PI / 2),ed.Y-10*Math.Sin(theta-Math.PI / 2)),

            };
            point = new StylusPointCollection(pointList);
            stroke = new Stroke(point)
            {
                DrawingAttributes = drawingAttributes.Clone()
            };
            return stroke;


        }

        public Stroke GenerateDimensionStroke5(System.Windows.Point st, System.Windows.Point ed)
        {
            List<Point> pointList = new List<Point>();
            StylusPointCollection point;
            Stroke stroke;

            double w = 20, h = 7;
            double theta = Math.Atan2(st.Y - ed.Y, st.X - ed.X);
            double sint = Math.Sin(theta);
            double cost = Math.Cos(theta);

            double theta1 = Math.Atan2(ed.Y - st.Y, ed.X - st.X);
            double sint1 = Math.Sin(theta1);
            double cost1 = Math.Cos(theta1);

            pointList = new List<Point>
            {
                new Point(st.X, st.Y),
                new Point(ed.X , ed.Y),
                new Point(ed.X + (w * cost - h * sint), ed.Y + (w * sint + h * cost)),
                new Point(ed.X,ed.Y),
                new Point(ed.X + (w * cost + h * sint), ed.Y - (h * cost - w * sint)),
                new Point(ed.X,ed.Y),
                new Point (ed.X-10*Math.Cos(theta+Math.PI / 2),ed.Y-10*Math.Sin(theta+Math.PI / 2)),
                new Point (ed.X-10*Math.Cos(theta-Math.PI / 2),ed.Y-10*Math.Sin(theta-Math.PI / 2)),

            };
            point = new StylusPointCollection(pointList);
            drawingAttributes.Color = dimenViewModel.SelectedAccentColor;
            stroke = new Stroke(point)
            {
                DrawingAttributes = drawingAttributes.Clone()
            };
            return stroke;
        }


        public Stroke GenerateEllipseStroke(System.Windows.Point st, System.Windows.Point ed)
        {
            List<System.Windows.Point> pointList = GenerateEllipseGeometry(st, ed);
            StylusPointCollection point = new StylusPointCollection(pointList);
            Stroke stroke;
            
            point = new StylusPointCollection(pointList);
            drawingAttributes.Color = dimenViewModel.SelectedAccentColor;
            stroke = new Stroke(point)
            {
                DrawingAttributes = drawingAttributes.Clone()
            };
            return stroke;
        }


        public Stroke GenerateCircleStroke(System.Windows.Point st, System.Windows.Point ed)
        {

            double dist = Math.Sqrt(Math.Pow(ed.X - st.X, 2) + Math.Pow(ed.Y - st.Y, 2));
            double deltaX = ed.X - st.X;
            double deltaY = ed.Y - st.Y;

            double x = deltaX / Math.Abs(deltaX) * dist / 1.4;
            double y = deltaY / Math.Abs(deltaY) * dist / 1.4;
            ed = new Point(st.X + x, st.Y + y);
            List<System.Windows.Point> pointList = GenerateEllipseGeometry(st, ed);
            StylusPointCollection point = new StylusPointCollection(pointList);
            Stroke stroke;
           
            point = new StylusPointCollection(pointList);
            stroke = new Stroke(point)
            {
                DrawingAttributes = drawingAttributes.Clone()
            };
            return stroke;
        }


        public Stroke GenerateArrowLineStroke(Point st, Point ed)
        {
            List<Point> pointList = new List<Point>();
            StylusPointCollection point;
            Stroke stroke;

            double w = 20, h = 7;
            double theta = Math.Atan2(st.Y - ed.Y, st.X - ed.X);
            double sint = Math.Sin(theta);
            double cost = Math.Cos(theta);

            pointList = new List<Point>
            {
                new Point(st.X, st.Y),
                new Point(ed.X , ed.Y),
                new Point(ed.X + (w * cost - h * sint), ed.Y + (w * sint + h * cost)),
                new Point(ed.X,ed.Y),
                new Point(ed.X + (w * cost + h * sint), ed.Y - (h * cost - w * sint))
            };
            point = new StylusPointCollection(pointList);
            drawingAttributes.Color = dimenViewModel.SelectedAccentColor;
            stroke = new Stroke(point)
            {
               
                DrawingAttributes = drawingAttributes.Clone()

            };
            return stroke;
        }

        public Stroke GenerateRectangleStroke(Point st, Point ed)
        {

            List<Point> pointList = new List<Point>();
            StylusPointCollection point;
            Stroke stroke;
            pointList = new List<System.Windows.Point>{
                        new System.Windows.Point(st.X, st.Y),
                        new System.Windows.Point(st.X, ed.Y),
                        new System.Windows.Point(ed.X, ed.Y),
                        new System.Windows.Point(ed.X, st.Y),
                        new System.Windows.Point(st.X, st.Y)
                    };
            point = new StylusPointCollection(pointList);
            drawingAttributes.Color = dimenViewModel.SelectedAccentColor;
            stroke = new Stroke(point)
            {
                DrawingAttributes = drawingAttributes.Clone()
            };

            return stroke;
        }

        public Stroke GenerateSquareStroke(Point st, Point ed)
        {

            double dist = Math.Sqrt(Math.Pow(ed.X - st.X, 2) + Math.Pow(ed.Y - st.Y, 2));
            double deltaX = ed.X - st.X;
            double deltaY = ed.Y - st.Y;

            double x = deltaX / Math.Abs(deltaX) * dist / 1.4;
            double y = deltaY / Math.Abs(deltaY) * dist / 1.4;
            ed = new Point(st.X + x, st.Y + y);

            List<Point> pointList = new List<Point>();
            StylusPointCollection point;
            Stroke stroke;
            pointList = new List<System.Windows.Point>{
                        new System.Windows.Point(st.X, st.Y),
                        new System.Windows.Point(st.X, ed.Y),
                        new System.Windows.Point(ed.X, ed.Y),
                        new System.Windows.Point(ed.X, st.Y),
                        new System.Windows.Point(st.X, st.Y)
                    };
            point = new StylusPointCollection(pointList);
            drawingAttributes.Color = dimenViewModel.SelectedAccentColor;
            stroke = new Stroke(point)
            {
                DrawingAttributes = drawingAttributes.Clone()
            };
            return stroke;
        }
        public List<System.Windows.Point> GenerateEllipseGeometry(System.Windows.Point st, System.Windows.Point ed, bool isDrawTop = true, bool isDrawBottom = true)
        {
            double a = 0.5 * (ed.X - st.X);
            double b = 0.5 * (ed.Y - st.Y);
            List<System.Windows.Point> pointList = new List<System.Windows.Point>();
            if (isDrawTop && isDrawBottom)
            {
                for (double r = 0; r <= 2 * Math.PI; r = r + 0.01)
                {
                    pointList.Add(new System.Windows.Point(0.5 * (st.X + ed.X) + a * Math.Cos(r), 0.5 * (st.Y + ed.Y) + b * Math.Sin(r)));
                }
            }
            else
            {
                if (isDrawBottom)
                {
                    for (double r = 0; r <= Math.PI; r = r + 0.01)
                    {
                        pointList.Add(new System.Windows.Point(0.5 * (st.X + ed.X) + a * Math.Cos(r), 0.5 * (st.Y + ed.Y) + b * Math.Sin(r)));
                    }
                }
                if (isDrawTop)
                {
                    for (double r = Math.PI; r <= 2 * Math.PI; r = r + 0.01)
                    {
                        pointList.Add(new System.Windows.Point(0.5 * (st.X + ed.X) + a * Math.Cos(r), 0.5 * (st.Y + ed.Y) + b * Math.Sin(r)));
                    }
                }
            }
            return pointList;
        }

        public static class InkCanvasMethod
        {
            public static Color ColorDefault = Color.FromArgb(0xFF, 0xFF, 0xA5, 0x00);
            public static Color ColorEidting = Color.FromArgb(0xFF, 0x07, 0xAA, 0xE5);
            public static Brush StrokeBrushDefault = new SolidColorBrush(ColorDefault);
            public static Brush StrokeBrushEdit = new SolidColorBrush(ColorEidting);

            /// <summary>
            /// 设置笔迹属性
            /// </summary>
            public static DrawingAttributes SetInkAttributes(double thickness = 2)
            {
                DrawingAttributes attributes = new DrawingAttributes
                {
                    FitToCurve = false,
                    Width = thickness,
                    Height = thickness,
                    Color = ColorDefault,
                    StylusTip = StylusTip.Rectangle,
                    IsHighlighter = false,
                    IgnorePressure = true,
                };
                return attributes;
            }

            /// <summary>
            /// 实线 Pen
            /// </summary>
            /// <returns></returns>
            public static Pen SetPenSolid(int thickness = 2)
            {
                Pen pen = new Pen
                {
                    Brush = StrokeBrushDefault,
                    Thickness = thickness,
                    DashCap = PenLineCap.Round,
                    
                    LineJoin = PenLineJoin.Round,
                    MiterLimit = 0.0
                };
                return pen;
            }



            public static CustomText CreateText(Point point1, Point point2, Point point3)
            {
                StylusPointCollection points = new StylusPointCollection()
                  {
                new StylusPoint(point1.X, point1.Y),
                new StylusPoint(point2.X, point2.Y),
                new StylusPoint(point3.X, point3.Y),

                    };
                CustomText stroke = new CustomText(new StylusPointCollection(points))
                {
                    DrawingAttributes = SetInkAttributes(),
                };
                return stroke;
            }

            public static CustomText1 CreateText1(Point point1, Point point2)
            {
                StylusPointCollection points = new StylusPointCollection()
                  {
                new StylusPoint(point1.X, point1.Y),
                new StylusPoint(point2.X, point2.Y),
               

                    };
                CustomText1 stroke = new CustomText1(new StylusPointCollection(points))
                {
                    DrawingAttributes = SetInkAttributes(),
                };
                return stroke;
            }

            public static CustomTextInput CreateTextInput(Point point1, double height, double width)
            {
                StylusPointCollection points = new StylusPointCollection()
                  {
                   new StylusPoint(point1.X, point1.Y),
                   new StylusPoint(point1.X+width, point1.Y),
                   new StylusPoint(point1.X, point1.Y+height),
                   new StylusPoint(point1.X+width, point1.Y+height),
                    };
                CustomTextInput stroke = new CustomTextInput(new StylusPointCollection(points))
                {
                    DrawingAttributes = SetInkAttributes(),
                };
                return stroke;
            }


        }


        public class CustomText1 : Stroke
        {
            public CustomText1(StylusPointCollection points) : base(points)
            {
                StylusPoints = points.Clone();
            }

            protected override void DrawCore(DrawingContext drawingContext, DrawingAttributes drawingAttributes)
            {

                double x1 = StylusPoints[0].X;
                double y1 = StylusPoints[0].Y;
                double x2 = StylusPoints[1].X;
                double y2 = StylusPoints[1].Y;
                Point labPoint = new Point((x1+x2)/2-20, y1 - 20);

                drawingContext.DrawText(new FormattedText("100 μm", CultureInfo.CurrentCulture,
                FlowDirection.LeftToRight, new Typeface("Microsoft YaHei UI"), 12, Brushes.White, 1.25), labPoint);

            }
        }
        public static FormattedText customTextInput;

        public class CustomTextInput : Stroke
        {
            public CustomTextInput(StylusPointCollection points) : base(points)
            {
                StylusPoints = points.Clone();
            }

            protected override void DrawCore(DrawingContext drawingContext, DrawingAttributes drawingAttributes)
            {

                double x1 = StylusPoints[0].X;
                double y1 = StylusPoints[0].Y;
                
                Point labPoint = new Point(x1 + 5, y1 + 3);

                drawingContext.DrawText(customTextInput, labPoint);

            }
        }





        public class CustomText : Stroke
        {
            public CustomText(StylusPointCollection points) : base(points)
            {
                StylusPoints = points.Clone();
            }

            protected override void DrawCore(DrawingContext drawingContext, DrawingAttributes drawingAttributes)
            {

                double x1 = StylusPoints[0].X;
                double y1 = StylusPoints[0].Y;
                double x2 = StylusPoints[1].X;
                double y2 = StylusPoints[1].Y;
                double x3 = StylusPoints[2].X;
                double y3 = StylusPoints[2].Y;

                double dist = GetDistance(new Point(x1, y1), new Point(x3, y3));
                //dist= (double)dist / inkCanvas.ActualWidth * 1689.12 ;
                string label = Math.Round(dist, 2).ToString() + " μm";

                FontStyle fontStyle = new FontStyle();
                FontWeight fontWeight = new FontWeight();
                FontStretch fontStretch = new FontStretch();
                if (dimenViewModel.Italic) fontStyle = FontStyles.Italic;
                if (dimenViewModel.Bold) fontWeight = FontWeights.Bold;
                Point labelPosition;
                FormattedText formattedText = new FormattedText(label, CultureInfo.CurrentCulture,

                                              FlowDirection.LeftToRight, new Typeface(dimenViewModel.FontFam, fontStyle, fontWeight, fontStretch), dimenViewModel.FontSize, Brushes.White, 1.25);
                int textHeight = (int)formattedText.Height;
                int textWidth = (int)formattedText.Width;
                if (dimenViewModel.Label)
                {
                    switch (dimenViewModel.LabelPos)
                    {

                        case " 上左":

                            labelPosition = new Point(x1 + 5, y1 - textHeight - 10);
                            break;
                        case " 上中":
                            labelPosition = new Point((x1 + x2 - textWidth) / 2, (y1 + y2) / 2 - textHeight - 10);
                            break;
                        case " 上右":
                            labelPosition = new Point(x2 - textWidth - 5, y2 - textHeight - 10);
                            break;

                        case " 下左":
                            labelPosition = new Point(x1 + 10, y1 + 10);
                            break;
                        case " 下中":
                            labelPosition = new Point((x1 + x2 - textWidth) / 2, (y1 + y2) / 2 + 10);
                            break;
                        case " 下右":
                            labelPosition = new Point(x2 - textWidth - 5, y2 + 10);
                            break;

                    }
                    // MessageBox.Show(formattedText.Width.ToString() + formattedText.Height.ToString());
                    drawingContext.DrawText(formattedText, labelPosition);
                    if (dimenViewModel.UnderLine)
                    {
                        drawingContext.DrawLine(InkCanvasMethod.SetPenSolid(), new Point(labelPosition.X, labelPosition.Y + textHeight + 2), new Point(labelPosition.X + textWidth, labelPosition.Y + textHeight + 2));
                    }


                }
            }
        }
           
            public static double GetDistance(Point point1, Point point2)
            {
                return Math.Sqrt((point1.X - point2.X) * (point1.X - point2.X) + (point1.Y - point2.Y) * (point1.Y - point2.Y));
            }
        }
    }

