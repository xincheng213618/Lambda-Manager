using Global.Mode;
using Global.Mode.Config;
using Lambda;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using static Global.DrawInkMethod;

namespace Global.UserControls.DrawVisual
{
    public class RatioClass { 
    
        public double Ratio = 1;
        public double actualwidth=1;
       
    }

    /// <summary>
    /// InkVisual.xaml 的交互逻辑
    /// </summary>
    public partial class InkVisual : UserControl
    {

        public InkVisual(int index1,Image image1, ImageViewState.ToolTop ToolTop, DrawInkMethod inkMethod)
        
            {
            InitializeComponent();
            this.ToolTop = ToolTop;
            this.inkMethod = inkMethod;
            // imagingView = ImagingView;
            topToolbar = (WrapPanel)mainwin.FindName("topToolbar");
            this.image = image1;
            this.index = index1;


            ToolTop.PropertyChanged += delegate (object? sender, PropertyChangedEventArgs e)
            {

                if (ToolTop.CurveChecked == false)
                {
                     i = 0;
                     lastTempCurveStroke = null;
                    CurvePointsList.Clear();
                };
                if (ToolTop.PolygonChecked == false)
                {
                    try
                    {
                        if (pointList1.Count > 1)
                        {

                            pointList1.Add(PointSt);
                            Color color = dimenViewModel.SelectedAccentColor;
                            int lineWidth = dimenViewModel.LineWidth;
                            stroke1 = InkCanvasMethod.CreatePolygon(pointList1, color,lineWidth);
                            try
                            {
                                inkCanvas.Strokes.Remove(lastTempStroke);
                            }
                            catch { }
                            lastTempStroke = null;
                            inkCanvas.Strokes.Add(stroke1);
                           
                            pointList1.Clear();

                        }


                    }
                    catch (Exception ex)
                    {

                    }

                };
                if (e.PropertyName == "DimensionChecked")
                {
                   

                    if ((bool)ToolTop.DimensionChecked)
                    {
                        defaultDim.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        defaultDim.Visibility = Visibility.Collapsed;
                    }
                }

                
            };

            defaultDim.DataContext = DrawInkMethod.defdimenViewModel;  // default Dimension bingding ViewModel
            DrawInkMethod.defdimenViewModel.PropertyChanged += delegate(object? sender, PropertyChangedEventArgs e)
            {
                if (e.PropertyName== "DimPos" || e.PropertyName == "Length")
                {
                    double ratio = ratio1.Ratio;
                    string position = DrawInkMethod.defdimenViewModel.DimPos;
                    double length = DrawInkMethod.defdimenViewModel.Length;
                    drawDefaultDim(position, length, Colors.AliceBlue, ratio);
                }

            };
            inkCanvas.Strokes.StrokesChanged += delegate
            {
                int z = inkCanvas.Strokes.Count;
                
                DrawInkMethod.StrokesCollection.Clear();
                int i = 1;
                FilterStroke(i);
                //for (i=0; i < inkCanvas.Strokes.Count; i++)
                //{

                //}

            };

        }

        Window mainwin = Application.Current.MainWindow;
        WrapPanel topToolbar;
        private double width;
        private double height;
        public ImageViewState.ToolTop ToolTop;
        private Image image;
        public int index;

        public RatioClass ratio1 = new RatioClass();
        public ProfileModel profileModel;
        // public double ratio = 1;
        DrawInkMethod inkMethod;
        bool isMouseDown = false;
        Point iniP = new Point(0, 0);
        public Stroke lastTempStroke = null;
        public Stroke lastTempStroke0 = null;
        public int ZoomInOut = 0;

        public StrokeCollection tempStroke = new StrokeCollection();
        public StrokeCollection RegisterStroke = new StrokeCollection();
        public bool saveTempStroke = true;
        private int textFlag = 0;
        //Stroke lastTempStroke1 = null;
        //Stroke lastTempStroke2 = null;
        public Stroke profileStroke;
        //curve
        int i = 0;
        Stroke lastTempCurveStroke = null;
        List<Point> CurvePointsList = new List<Point>();


        private Point movePoint = new Point(0, 0);

        private void FilterStroke( int i)
        {
            foreach (var item in inkCanvas.Strokes)
            {


                if (item is CustomTextInput textInput)
                {
                    textInput.Index = i++;
                    DrawInkMethod.StrokesCollection.Add(item);
                };
                if (item is EllipseStroke ellipse)
                {
                    ellipse.Index = i++;
                    DrawInkMethod.StrokesCollection.Add(ellipse);
                }

                if (item is RectangleStroke rectangle)
                {
                    rectangle.Index = i++;
                    DrawInkMethod.StrokesCollection.Add(rectangle);
                }
                if (item is CircleStroke circleStroke)
                {
                    circleStroke.Index = i++;
                    DrawInkMethod.StrokesCollection.Add(circleStroke);
                }
                if (item is SquareStroke square)
                {
                    square.Index = i++;
                    DrawInkMethod.StrokesCollection.Add(square);
                }
                if (item is LineStroke line)
                {
                    line.Index = i++;
                    DrawInkMethod.StrokesCollection.Add(line);
                }
                if (item is ArrowStroke arrow)
                {
                    arrow.Index = i++;
                    DrawInkMethod.StrokesCollection.Add(arrow);
                }
                if (item is Dim1Stroke dim1)
                {
                    dim1.Index = i++;
                    DrawInkMethod.StrokesCollection.Add(dim1);
                }
                if (item is Dim2Stroke dim2)
                {
                    dim2.Index = i++;
                    DrawInkMethod.StrokesCollection.Add(dim2);
                }
                if (item is Dim3Stroke dim3)
                {
                    dim3.Index = i++;
                    DrawInkMethod.StrokesCollection.Add(dim3);
                }
                if (item is Dim4Stroke dim4)
                {
                    dim4.Index = i++;
                    DrawInkMethod.StrokesCollection.Add(dim4);
                }
                if(item is QuadraticBezierpath quadraticBezier)
                {
                    quadraticBezier.Index = i++;
                    DrawInkMethod.StrokesCollection.Add(quadraticBezier);
                }
                if (item is Bezierpath bezier)
                {
                    bezier.Index = i++;
                    DrawInkMethod.StrokesCollection.Add(bezier);

                }
                if (item is PolygonStroke polygon)
                {
                    polygon.Index = i++;
                    DrawInkMethod.StrokesCollection.Add(polygon);

                }

            }
        }


        public void DrawProfile()
        {
              Point ProfileIniP;
              Point ProfileEndP;
            if (inkCanvas.Strokes.Contains(profileStroke) && profileStroke!=null)
            {
                ProfileIniP= new Point( profileStroke.StylusPoints[0].X, profileStroke.StylusPoints[0].Y );
                ProfileEndP = new Point(profileStroke.StylusPoints[1].X, profileStroke.StylusPoints[1].Y);
            }
            Color color = DrawInkMethod.dimenViewModel.SelectedAccentColor;
            profileStroke = DrawInkMethod.InkCanvasMethod.CreateProfile(ProfileIniP, ProfileEndP, profileModel,color);
            try
            {
                inkCanvas.Strokes.Remove(lastTempStroke);
            }
            catch { }
            lastTempStroke = profileStroke;
            inkCanvas.Strokes.Add(profileStroke);
        }



        private void inkCanvas_MouseMove(object sender, MouseEventArgs e)
        {

            Point endP = e.GetPosition(inkCanvas);
            List<System.Windows.Point> pointList;
            StylusPointCollection point;
            Stroke stroke;
            Stroke stroke0;
            StrokeCollection strokes = new StrokeCollection();
          
            if (isMouseDown && ToolTop.CurveChecked)  //Curve
            {
                if (i == 0)
                {
                    double dist = GetDistance(endP, iniP);
                    if (dist < 5)
                        return;
                    Color color0 = dimenViewModel.SelectedAccentColor;
                    int lineWidth = dimenViewModel.LineWidth;
                    stroke = InkCanvasMethod.CreateLineStroke(iniP, endP, color0, lineWidth);
                    try
                    {
                        inkCanvas.Strokes.Remove(lastTempCurveStroke);
                    }
                    catch { }
                    lastTempCurveStroke = stroke;
                    inkCanvas.Strokes.Add(stroke);


                }
                if (i == 1)
                {
                    Point m1 = e.GetPosition(inkCanvas);
                    if (CurvePointsList.Count > 2)
                    {
                        CurvePointsList.RemoveAt(1);
                    }
                    CurvePointsList.Insert(1, m1);
                    Color color = DrawInkMethod.dimenViewModel.SelectedAccentColor;
                    int lineWidth = dimenViewModel.LineWidth;
                    stroke = DrawInkMethod.InkCanvasMethod.CreateQuadraticBesizer(CurvePointsList, color,lineWidth);
                    try
                    {
                        inkCanvas.Strokes.Remove(lastTempCurveStroke);
                    }
                    catch { }
                    lastTempCurveStroke = stroke;
                    inkCanvas.Strokes.Add(stroke);

                }
                if (i == 2)
                {
                    Point m2 = e.GetPosition(inkCanvas);
                    if (CurvePointsList.Count >3)
                    {
                        CurvePointsList.RemoveAt(2);
                    }
                    CurvePointsList.Insert(2, m2);
                    Color color = DrawInkMethod.dimenViewModel.SelectedAccentColor;
                    int lineWidth = dimenViewModel.LineWidth;
                    stroke = DrawInkMethod.InkCanvasMethod.CreateBesizer(CurvePointsList, color,lineWidth);
                    try
                    {
                        inkCanvas.Strokes.Remove(lastTempCurveStroke);
                    }
                    catch { }
                    lastTempCurveStroke = stroke;
                    inkCanvas.Strokes.Add(stroke);

                }


            }
            else if (ToolTop.RulerChecked ) //ruler
            {
                if (inkCanvas.Cursor == Cursors.Arrow)
                {
                    inkCanvas.UseCustomCursor = true;
                    StreamResourceInfo sri = Application.GetResourceStream(new Uri("/Global;component/usercontrols/image/Ruler.cur", UriKind.Relative));
                    inkCanvas.Cursor = new Cursor(sri.Stream);
                }
               if (isMouseDown && ToolTop.RulerChecked)
                {
                    //var isShiftDown = Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift);
                    //double deltaX = Math.Abs(iniP.X - endP.X);
                    //double deltaY = Math.Abs(iniP.Y - endP.Y);
                    //if (isShiftDown)
                    //{
                    //    if (deltaX >= deltaY)
                    //    {
                    //        endP.Y = iniP.Y;
                    //    }
                    //    else
                    //    {
                    //        endP.X = iniP.X;
                    //    }

                    //}

                    //double dist = GetDistance(endP, iniP);
                    //if (dist < 5)
                    //    return;
                    //stroke = inkMethod.GenerateRulerStroke(iniP, endP);
                    //try
                    //{
                    //    inkCanvas.Strokes.Remove(lastTempStroke);
                    //}
                    //catch { }
                    //lastTempStroke = stroke;
                    //inkCanvas.Strokes.Add(stroke);
                    //double width = ActualWidth;
                    //stroke0 = DrawInkMethod.InkCanvasMethod.CreateRulerText(iniP, endP, ratio1);
                    //try
                    //{
                    //    inkCanvas.Strokes.Remove(lastTempStroke0);
                    //}
                    //catch { }
                    //lastTempStroke0 = stroke0;
                    //inkCanvas.Strokes.Add(stroke0);
                    var isShiftDown = Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift);
                    double deltaX = Math.Abs(iniP.X - endP.X);
                    double deltaY = Math.Abs(iniP.Y - endP.Y);
                    if (isShiftDown)
                    {
                        if (deltaX >= deltaY)
                        {
                            endP.Y = iniP.Y;
                        }
                        else
                        {
                            endP.X = iniP.X;
                        }
                    }
                    double dist1 = GetDistance(endP, iniP);
                    if (dist1 < 5)
                        return;

                    switch (DrawInkMethod.dimenViewModel.DimSelectedIndex)
                    {
                        case 0:
                            Color color0 = dimenViewModel.SelectedAccentColor;
                            int lineWidth = dimenViewModel.LineWidth;
                            stroke = InkCanvasMethod.CreateLineStroke(iniP, endP, color0,lineWidth) ;
                            break;

                        case 1:

                            Color color1 = dimenViewModel.SelectedAccentColor;
                            int lineWidth1 = dimenViewModel.LineWidth;
                            stroke = InkCanvasMethod.CreateArrowStroke(iniP, endP, color1,lineWidth1);
                            break;
                        case 2:
                            int lineWidth2 = dimenViewModel.LineWidth;
                            stroke = InkCanvasMethod.CreateDim1Stroke(iniP, endP, dimenViewModel.SelectedAccentColor, ratio1, dimenViewModel.TextSelectedAccentColor, dimenViewModel.Label, lineWidth2);
                            break;
                        case 3:
                            int lineWidth3 = dimenViewModel.LineWidth;
                            stroke = InkCanvasMethod.CreateDim2Stroke(iniP, endP, dimenViewModel.SelectedAccentColor, ratio1, dimenViewModel.TextSelectedAccentColor, dimenViewModel.Label, lineWidth3);
                            break;
                        case 4:
                            int lineWidth4 = dimenViewModel.LineWidth;
                            stroke = InkCanvasMethod.CreateDim3Stroke(iniP, endP, dimenViewModel.SelectedAccentColor, ratio1, dimenViewModel.TextSelectedAccentColor, dimenViewModel.Label, lineWidth4);
                            break;
                        case 5:
                            int lineWidth5 = dimenViewModel.LineWidth;
                            stroke = InkCanvasMethod.CreateDim4Stroke(iniP, endP, dimenViewModel.SelectedAccentColor, ratio1, dimenViewModel.TextSelectedAccentColor, dimenViewModel.Label, lineWidth5);
                            break;

                        default:
                            Color color6 = dimenViewModel.SelectedAccentColor;
                            int lineWidth6 = dimenViewModel.LineWidth;
                            stroke = InkCanvasMethod.CreateLineStroke(iniP, endP, color6, lineWidth6);
                            break;

                    }
                    try
                    {
                        inkCanvas.Strokes.Remove(lastTempStroke);
                    }
                    catch { }
                    lastTempStroke = stroke;
                    inkCanvas.Strokes.Add(stroke);
                    double theta = Math.Atan2(endP.Y - iniP.Y, endP.X - iniP.X);
                    double dist = GetDistance(iniP, endP);
                    DrawInkMethod.dimenViewModel.Length = (double)dist / ratio1.actualwidth * 1689.12 / ratio1.Ratio;

                    if (theta / Math.PI * 180 == 0)
                    {
                        DrawInkMethod.dimenViewModel.Angle = 0;
                    }
                    else
                    {
                        DrawInkMethod.dimenViewModel.Angle = theta / Math.PI * 180;

                    }
                    Color color = DrawInkMethod.dimenViewModel.SelectedAccentColor;
                    if (DrawInkMethod.dimenViewModel.DimSelectedIndex == 0 || DrawInkMethod.dimenViewModel.DimSelectedIndex == 1)
                        return;


                }


            }
            else if(isMouseDown && ToolTop.ProfileChecked)
            {


                Color color = DrawInkMethod.dimenViewModel.SelectedAccentColor;
                profileStroke = DrawInkMethod.InkCanvasMethod.CreateProfile(iniP,endP, profileModel, color);
                
                try
                {
                    inkCanvas.Strokes.Remove(lastTempStroke);
                }
                catch { }
                lastTempStroke = profileStroke;
                inkCanvas.Strokes.Add(profileStroke);

            }

            else  if (isMouseDown && ToolTop.LineChecked ) //dimension
            {
                var isShiftDown = Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift);
                double deltaX = Math.Abs(iniP.X - endP.X);
                double deltaY = Math.Abs(iniP.Y - endP.Y);
                if (isShiftDown)
                {
                    if (deltaX >= deltaY)
                    {
                        endP.Y = iniP.Y;
                    }
                    else
                    {
                        endP.X = iniP.X;
                    }
                }
                double dist1 = GetDistance(endP, iniP);
                if (dist1 < 5)
                    return;

                switch (DrawInkMethod.dimenViewModel.DimSelectedIndex)
                {
                    case 0:
                        Color color0 = dimenViewModel.SelectedAccentColor;
                        int lineWidth = dimenViewModel.LineWidth;
                        stroke = InkCanvasMethod.CreateLineStroke(iniP, endP, color0, lineWidth);
                        break;

                    case 1:

                        Color color1 = dimenViewModel.SelectedAccentColor;
                        int lineWidth1 = dimenViewModel.LineWidth;
                        stroke = InkCanvasMethod.CreateArrowStroke(iniP, endP, color1, lineWidth1);
                        break;
                    case 2:
                        int lineWidth2 = dimenViewModel.LineWidth;
                        stroke = InkCanvasMethod.CreateDim1Stroke(iniP, endP, dimenViewModel.SelectedAccentColor, ratio1, dimenViewModel.TextSelectedAccentColor, dimenViewModel.Label, lineWidth2);
                        break;
                    case 3:
                        int lineWidth3 = dimenViewModel.LineWidth;
                        stroke = InkCanvasMethod.CreateDim2Stroke(iniP, endP, dimenViewModel.SelectedAccentColor, ratio1, dimenViewModel.TextSelectedAccentColor, dimenViewModel.Label, lineWidth3);
                        break;
                    case 4:
                        int lineWidth4 = dimenViewModel.LineWidth;
                        stroke = InkCanvasMethod.CreateDim3Stroke(iniP, endP, dimenViewModel.SelectedAccentColor, ratio1, dimenViewModel.TextSelectedAccentColor, dimenViewModel.Label, lineWidth4);
                        break;
                    case 5:
                        int lineWidth5 = dimenViewModel.LineWidth;
                        stroke = InkCanvasMethod.CreateDim4Stroke(iniP, endP, dimenViewModel.SelectedAccentColor, ratio1, dimenViewModel.TextSelectedAccentColor, dimenViewModel.Label, lineWidth5);
                        break;

                    default:
                        Color color6 = dimenViewModel.SelectedAccentColor;
                        int lineWidth6 = dimenViewModel.LineWidth;
                        stroke = InkCanvasMethod.CreateLineStroke(iniP, endP, color6, lineWidth6);
                        break;

                }
                try
                {
                    inkCanvas.Strokes.Remove(lastTempStroke);
                }
                catch { }
                lastTempStroke = stroke;            
                inkCanvas.Strokes.Add(stroke);
                double theta = Math.Atan2(endP.Y-iniP.Y  , endP.X-iniP.X);
                double dist = GetDistance(iniP, endP);
                DrawInkMethod.dimenViewModel.Length = (double)dist / ratio1.actualwidth * 1689.12 / ratio1.Ratio;

                if (theta/ Math.PI * 180 == 0)
                {
                    DrawInkMethod.dimenViewModel.Angle = 0;
                }
                else
                {
                    DrawInkMethod.dimenViewModel.Angle = theta / Math.PI * 180;

                }
                Color color = DrawInkMethod.dimenViewModel.SelectedAccentColor;
                if (DrawInkMethod.dimenViewModel.DimSelectedIndex == 0 || DrawInkMethod.dimenViewModel.DimSelectedIndex == 1)
                    return;
               
               

            }
           
            
            else if (isMouseDown && ToolTop.MoveChecked)     //move
            {

                if (inkCanvas.Cursor == Cursors.Hand)
                {
                    StreamResourceInfo sri = Application.GetResourceStream(new Uri("/Global;component/usercontrols/image/hold.cur", UriKind.Relative));
                    inkCanvas.Cursor = new Cursor(sri.Stream);
                }
                Dictionary<string, object> parameters = new Dictionary<string, object>()
                              {
                            { "event",(int)0},
                            {"x",(int)endP.X },
                            {"y",(int)endP.Y },
                            {"flag",(int)1 }

                                 };
                LambdaControl.Trigger("MOUSE_EVENT", null, parameters);


                if (ratio1.Ratio != 1)
                {

                    
                    Matrix matrixMove1 = new Matrix();
                    matrixMove1.Translate(endP.X - movePoint.X, endP.Y - movePoint.Y);
                    inkCanvas.Strokes.Transform(matrixMove1, false);
                    movePoint = endP;

                }


            }

            if (isMouseDown && ToolTop.CircleChecked)
            {
                var isShiftDown = Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift);
                double delta = (iniP.X - endP.X) * (iniP.Y - endP.Y);
                if (isShiftDown && delta != 0)
                {
                    Color color = dimenViewModel.SelectedAccentColor;
                    int lineWidth = dimenViewModel.LineWidth;
                    stroke = InkCanvasMethod.CreateCircle(iniP, endP, color,lineWidth);
                    try
                    {
                        inkCanvas.Strokes.Remove(lastTempStroke);
                    }
                    catch { }
                    lastTempStroke = stroke;
                    inkCanvas.Strokes.Add(stroke);

                }
                else if (delta != 0)
                {
                    Color color = dimenViewModel.SelectedAccentColor;
                    int lineWidth = dimenViewModel.LineWidth;
                    stroke = InkCanvasMethod.CreateEllipse(iniP, endP, color, lineWidth);

                    try
                    {
                        inkCanvas.Strokes.Remove(lastTempStroke);
                    }
                    catch { }
                    lastTempStroke = stroke;
                    inkCanvas.Strokes.Add(stroke);

                   

                }

               


            }
            if (isMouseDown && ToolTop.RectangleChecked)  //rectangle
            {
                var isShiftDown = Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift);

                double delta = (iniP.X - endP.X) * (iniP.Y - endP.Y);
                if (isShiftDown && delta != 0)
                {
                    Color color = dimenViewModel.SelectedAccentColor;
                    int lineWidth = dimenViewModel.LineWidth;
                    stroke = InkCanvasMethod.CreateSquare(iniP, endP, color, lineWidth);
                    try
                    {
                        inkCanvas.Strokes.Remove(lastTempStroke);
                    }
                    catch { }
                    lastTempStroke = stroke;
                    inkCanvas.Strokes.Add(stroke);
                  
                }
                else
                {
                    Color color = dimenViewModel.SelectedAccentColor;
                    int lineWidth = dimenViewModel.LineWidth;
                    stroke = InkCanvasMethod.CreateRectangleStroke(iniP, endP, color,lineWidth);

                    try
                    {
                        inkCanvas.Strokes.Remove(lastTempStroke);
                      
                    }
                    catch { }
                    lastTempStroke = stroke;
                    inkCanvas.Strokes.Add(stroke);
                 
                }
             


            }
            if (ToolTop.EraserChecked)      //eraser Cursor
            {
                if (inkCanvas.Cursor == Cursors.Arrow || inkCanvas.Cursor == null)
                {
                    inkCanvas.UseCustomCursor = true;
                    StreamResourceInfo sri = Application.GetResourceStream(new Uri("/Global;component/usercontrols/image/eraser.cur", UriKind.Relative));
                    inkCanvas.Cursor = new Cursor(sri.Stream);
                }
            }
            if (ToolTop.ArrowChecked || ToolTop.DimensionChecked || ToolTop.LineChecked || ToolTop.PolygonChecked || ToolTop.RectangleChecked || ToolTop.TextChecked||ToolTop.CurveChecked)
            {
                if(inkCanvas.Cursor == Cursors.Arrow || inkCanvas.Cursor == null)
                {
                    inkCanvas.Cursor = Cursors.Cross;
                }
            }
            if (ToolTop.MoveChecked)
            {
                if (inkCanvas.Cursor == Cursors.Arrow || inkCanvas.Cursor ==null )
                {
                    inkCanvas.Cursor = Cursors.Hand;
                }
            }



            if (ToolTop.SelectChecked)
            {

                DrawInkMethod.LoadPixelData(endP, image);
                stroke = DrawInkMethod.InkCanvasMethod.CreatePixel(endP, image);
                try
                {
                    inkCanvas.Strokes.Remove(lastTempStroke);
                }
                catch { }
                lastTempStroke = stroke;
                inkCanvas.Strokes.Add(stroke);

            }

            if (ToolTop.PolygonChecked == true)
            {
                Point Point2 = e.GetPosition(inkCanvas);
                if (pointList1.Count > 0)
                {
                    pointList1.Add(Point2);
                    // point1 = new StylusPointCollection(pointList1);
                    Color color = dimenViewModel.SelectedAccentColor;
                    int lineWidth = dimenViewModel.LineWidth;
                    stroke1 = InkCanvasMethod.CreatePolygon(pointList1, color, lineWidth);
                    //stroke1 = new Stroke(point1)
                    //{
                    //    DrawingAttributes = inkMethod.drawingAttributes.Clone()
                    //};
                    try
                    {
                        inkCanvas.Strokes.Remove(lastTempStroke);
                    }
                    catch { }
                    lastTempStroke = stroke1;
                    inkCanvas.Strokes.Add(stroke1);
                    pointList1.Remove(Point2);
                }

            }
        }

        List<System.Windows.Point> pointList1 = new List<Point>();
        StylusPointCollection point1;

        Stroke stroke1;
        Point PointSt;
        private void inkCanvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            iniP = e.GetPosition(inkCanvas);
            isMouseDown = true;
           // inkCanvas.CaptureMouse();
            Stroke stroke;
            Stroke stroke0;

           if (ToolTop.MoveChecked == true)
            {
                StreamResourceInfo hold = Application.GetResourceStream(new Uri("/Global;component/usercontrols/image/hold.cur", UriKind.Relative));
                inkCanvas.Cursor = new Cursor(hold.Stream);

                // CanMove = true;
                Dictionary<string, object> parameters = new Dictionary<string, object>()
                            {
                            {"event",(int)1},
                            {"x",(int)iniP.X },
                            {"y",(int)iniP.Y },
                            {"flag",(int)1 }

                            };
                LambdaControl.Trigger("MOUSE_EVENT", null, parameters);
                movePoint = iniP;
            };
            

            if (ToolTop.PolygonChecked == true)
            {

                pointList1.Add(iniP);
               // point1 = new StylusPointCollection(pointList1);

                if (pointList1.Count > 1)
                {
                    Color color = dimenViewModel.SelectedAccentColor;
                    int lineWidth = dimenViewModel.LineWidth;
                    stroke1 = InkCanvasMethod.CreatePolygon(pointList1, color, lineWidth);
                    try
                    {
                        inkCanvas.Strokes.Remove(lastTempStroke);
                    }
                    catch { }
                    lastTempStroke = stroke1;
                    inkCanvas.Strokes.Add(stroke1);


                }
                if (pointList1.Count == 1)
                {
                    PointSt = iniP;
                }

            }
           
            else if (ToolTop.TextChecked)
            {
               
                if (textFlag == 2) textFlag = 0;
                if (textFlag == 0)
                {

                    TextBox textBox = new TextBox()
                    { 
                        FontFamily = DrawInkMethod.dimenViewModel.FontFam,
                        FontSize = DrawInkMethod.dimenViewModel.FontSize,
                        Width = 100,
                        Style = (Style)(this.FindResource("TextBoxSty")),
                       // TextWrapping = TextWrapping.Wrap,
                        Foreground = new SolidColorBrush(DrawInkMethod.dimenViewModel.TextSelectedAccentColor)

                    };
                    if (DrawInkMethod.dimenViewModel.Italic)
                    {
                        textBox.FontStyle = FontStyles.Italic;
                    }
                    if (DrawInkMethod.dimenViewModel.Bold)
                    {
                        textBox.FontWeight = FontWeights.Bold;
                    }
                    if (DrawInkMethod.dimenViewModel.UnderLine)
                    {
                        textBox.TextDecorations = TextDecorations.Underline;
                    }


                    inkCanvas.Children.Add(textBox);
                    InkCanvas.SetLeft(textBox, iniP.X-3);
                    InkCanvas.SetTop(textBox, iniP.Y-1);
                    textBox.Focus();


                    textBox.LostFocus += delegate
                    {
                        if (textBox.Text == "")
                            inkCanvas.Children.Remove(textBox);
                        string label = (string)textBox.Text;
                        System.Windows.FontStyle fontStyle = new System.Windows.FontStyle();
                        FontWeight fontWeight = new FontWeight();
                        FontStretch fontStretch = new FontStretch();
                        if (DrawInkMethod.dimenViewModel.Italic) fontStyle = FontStyles.Italic;
                        if (DrawInkMethod.dimenViewModel.Bold) fontWeight = FontWeights.Bold;
                        Brush brush = new SolidColorBrush(DrawInkMethod.dimenViewModel.TextSelectedAccentColor);
                        FormattedText text = new FormattedText(label, CultureInfo.CurrentCulture,
                        FlowDirection.LeftToRight, new Typeface(DrawInkMethod.dimenViewModel.FontFam, fontStyle, fontWeight, fontStretch), DrawInkMethod.dimenViewModel.FontSize, brush, 1.25);

                       
                        double height = text.Height;
                        double width = text.Width;

                        Stroke stroke = DrawInkMethod.InkCanvasMethod.CreateTextInput(iniP, height, width, text, brush); 
                        inkCanvas.Strokes.Add(stroke);              
                        inkCanvas.Children.Remove(textBox);
                          

                    };


                }
                textFlag++;

            }
            else if (ToolTop.CurveChecked)
            {
              

                if (i == 0)
                {
                    CurvePointsList.Add(iniP);
                }
                else if (i == 1)
                {
                    CurvePointsList.Insert(1, iniP);
                    Color color = DrawInkMethod.dimenViewModel.SelectedAccentColor;
                    int lineWidth = dimenViewModel.LineWidth;
                    stroke = DrawInkMethod.InkCanvasMethod.CreateQuadraticBesizer(CurvePointsList, color, lineWidth);
                    try
                    {
                        inkCanvas.Strokes.Remove(lastTempCurveStroke);
                    }
                    catch { }
                    lastTempCurveStroke = stroke;
                    inkCanvas.Strokes.Add(stroke);

                }
                else if(i == 2)
                {
                    CurvePointsList.Insert(2, iniP);
                    Color color = DrawInkMethod.dimenViewModel.SelectedAccentColor;
                    int lineWidth = dimenViewModel.LineWidth;
                    stroke = DrawInkMethod.InkCanvasMethod.CreateBesizer(CurvePointsList, color,lineWidth);
                    try
                    {
                        inkCanvas.Strokes.Remove(lastTempCurveStroke);
                    }
                    catch { }
                    lastTempCurveStroke = stroke;
                    inkCanvas.Strokes.Add(stroke);

                }



            }
        }


     
      


        private void inkCanvas_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (ToolTop.PolygonChecked)
            {

            }
            else if (ToolTop.SelectChecked || ToolTop.ProfileChecked)
            {

            }
            else if (ToolTop.CurveChecked)
            {
               
               if (i == 0)
                {
                    i++;
                    Point point = e.GetPosition(inkCanvas);
                    CurvePointsList.Add(point);
                }
               else if (i == 1)
                {
                    i++;
                    Point point = e.GetPosition(inkCanvas);
                    CurvePointsList.Add(point);
                }
               else if (i == 2)
                {
                    lastTempCurveStroke = null;
                    CurvePointsList.Clear();
                    i = 0;
                }
            
            }
            else
            {
                lastTempStroke = null;
                lastTempStroke0 = null;
            };
           
            isMouseDown = false;
            inkCanvas.ReleaseMouseCapture();
            if (ToolTop.MoveChecked == true)
            {
                inkCanvas.Cursor = Cursors.Hand;

                movePoint= e.GetPosition(inkCanvas);

            }


        }



        private void inkCanvas_PreviewKeyDown(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Escape)
            {

                try
                {
                    if (pointList1.Count > 1)
                    {

                        pointList1.Add(PointSt);
                        Color color = dimenViewModel.SelectedAccentColor;
                        int lineWidth = dimenViewModel.LineWidth;
                        stroke1 = InkCanvasMethod.CreatePolygon(pointList1, color, lineWidth);
                        try
                        {
                            inkCanvas.Strokes.Remove(lastTempStroke);
                        }
                        catch { }
                        lastTempStroke = null;
                        inkCanvas.Strokes.Add(stroke1);

                        pointList1.Clear();

                    }
                   

                }
                catch (Exception ex)
                {

                }




            }

        }

        public double GetDistance(Point point1, Point point2)
        {
            return Math.Sqrt((point1.X - point2.X) * (point1.X - point2.X) + (point1.Y - point2.Y) * (point1.Y - point2.Y));
        }


        public void drawDefaultDim(string direction,double length,Color color,double ratio)
        {
            pathGeometry.Clear();
            double dimLength = length * ratio * R.ActualWidth / 1689.12;
            PathFigure pathFigure1 = new PathFigure() { StartPoint = new Point(5, 6) };
            LineSegment lineSegment0 = new LineSegment() { Point = new Point(5, 13) };
            LineSegment lineSegment1 = new LineSegment() { Point = new Point(dimLength, 13) };
            LineSegment lineSegment2 = new LineSegment() { Point = new Point(dimLength, 6) };
            pathFigure1.Segments.Add(lineSegment0);
            pathFigure1.Segments.Add(lineSegment1);
            pathFigure1.Segments.Add(lineSegment2);
            pathGeometry.Figures.Add(pathFigure1);

            switch (direction)
            {

                case "上左":

                    Canvas.SetLeft(dimText, (dimLength - dimText.ActualWidth) / 2);
                    InkCanvas.SetLeft(defaultDim, 30 * R.ActualWidth / 1180);
                    InkCanvas.SetTop(defaultDim,20 * R.ActualWidth / 1180 );
                    break;
                case "上右":
                    Canvas.SetLeft(dimText, (dimLength - dimText.ActualWidth) / 2);
                   // InkCanvas.SetLeft(defaultDim, this.ActualWidth- length * ratio-30);
                    InkCanvas.SetLeft(defaultDim, R.ActualWidth - dimLength - 30 * R.ActualWidth / 1180);
                    InkCanvas.SetTop(defaultDim, 20 * R.ActualWidth / 1180);
                    break;
                case "下左":
                    Canvas.SetLeft(dimText, (dimLength - dimText.ActualWidth) / 2);
                    InkCanvas.SetLeft(defaultDim, 20 * R.ActualWidth / 1180);
                    InkCanvas.SetTop(defaultDim, R.ActualHeight - dimText.ActualHeight - 20 * R.ActualWidth / 1180);
                    break;

                case "下右":
                    Canvas.SetLeft(dimText, (dimLength - dimText.ActualWidth) / 2);
                    InkCanvas.SetLeft(defaultDim, R.ActualWidth - dimLength - 30 * R.ActualWidth / 1180);
                    InkCanvas.SetTop(defaultDim, R.ActualHeight - dimText.ActualHeight- 20 * R.ActualWidth / 1180);
                    break;      

            }

        }
       private async void inkCanvas_MouseWheel(object sender, MouseWheelEventArgs e)
        {
           if (saveTempStroke && inkCanvas.Strokes.Count > 0)
            {
                tempStroke = inkCanvas.Strokes.Clone();
                saveTempStroke = false;
              
            }
            Point curPoint = e.GetPosition(e.Device.Target);
            Matrix matrix = new Matrix();
            if (e.Delta > 0 && ZoomInOut<5)
            {
                matrix.ScaleAt(1.2, 1.2, curPoint.X, curPoint.Y);
               // MessageBox.Show(curPoint.ToString());
                ZoomInOut++;
                //marker
                ratio1.Ratio = ratio1.Ratio * 1.2;
                inkCanvas.Strokes.Transform(matrix, false);
                RepaintDim();
                double ratio = ratio1.Ratio;
                string position = DrawInkMethod.defdimenViewModel.DimPos;
                double length = DrawInkMethod.defdimenViewModel.Length;
                drawDefaultDim(position, length, Colors.AliceBlue, ratio);
                double x = curPoint.X/ActualWidth*1280;
                double y = curPoint.Y / ActualHeight * 960;

                Dictionary<string, object> parameters = new Dictionary<string, object>()
                            {
                            { "event",(int)10},
                            {"x",(int)x},
                            {"y",(int)y },
                            {"flag",(int)1024 }

                            };
                LambdaControl.Trigger("MOUSE_EVENT", null, parameters);
                StreamResourceInfo ZoomOut = Application.GetResourceStream(new Uri("/Global;component/usercontrols/image/zoomOut.cur", UriKind.Relative));
                inkCanvas.Cursor = new Cursor(ZoomOut.Stream);
                  await Task.Delay(500);

                if (ToolTop.MoveChecked)
                {
                    inkCanvas.Cursor = Cursors.Hand;
                }
                else
                {
                    inkCanvas.Cursor = Cursors.Arrow;
                }
               

            }
            else if(e.Delta < 0 && ZoomInOut>0)
            {
                matrix.ScaleAt(1/1.2, 1/1.2, curPoint.X, curPoint.Y);
                ZoomInOut--;
                //marker
                ratio1.Ratio = ratio1.Ratio / 1.2;
                inkCanvas.Strokes.Transform(matrix, false);
                RepaintDim();
                double ratio = ratio1.Ratio;
                string position = DrawInkMethod.defdimenViewModel.DimPos;
                double length = DrawInkMethod.defdimenViewModel.Length;
                drawDefaultDim(position, length, Colors.AliceBlue, ratio);
                double x = curPoint.X / ActualWidth * 1280;
                double y = curPoint.Y / ActualHeight * 960;
                Dictionary<string, object> parameters = new Dictionary<string, object>()
                            {
                            { "event",(int)10},
                            {"x",(int)x},
                            {"y",(int)y },
                            {"flag",(int)-1024 }
                            };
                LambdaControl.Trigger("MOUSE_EVENT", null, parameters);
                StreamResourceInfo ZoomIn = Application.GetResourceStream(new Uri("/Global;component/usercontrols/image/zoomIn.cur", UriKind.Relative));
                inkCanvas.Cursor = new Cursor(ZoomIn.Stream);
                await Task.Delay(500);
                if (ToolTop.MoveChecked)
                {
                    inkCanvas.Cursor = Cursors.Hand;
                }
                else
                {
                    inkCanvas.Cursor = Cursors.Arrow;
                }
            }
        }
        // delete in the future
        private void RepaintDim()
        {
            if (inkCanvas.Strokes.Contains(inkMethod.Dimstroke))
            {
                inkCanvas.Strokes.Remove(inkMethod.Dimstroke);
                inkCanvas.Strokes.Remove(inkMethod.Textstroke);
                double w = inkCanvas.ActualWidth;
                double h = inkCanvas.ActualHeight;
                Point iniP = new Point(w * 19 / 20, h * 19 / 20);
                Point endP = new Point(w * 19 / 20 - w * 100 * ratio1.Ratio / 1689.12, h * 19 / 20);
                inkMethod.Dimstroke = inkMethod.GenerateDimensionStroke0(iniP, endP);
                inkCanvas.Strokes.Add(inkMethod.Dimstroke);       
                inkMethod.Textstroke = DrawInkMethod.InkCanvasMethod.CreateText1(iniP, endP);
                inkCanvas.Strokes.Add(inkMethod.Textstroke);

            }
        }


       
        private  void MatrixTransform()
        {
           
            Point beforePoint = new Point(width, height);
            Point point = new Point(R.ActualWidth, R.ActualHeight);
            double wRatio = R.ActualWidth / width;
            double hRatio = R.ActualHeight / height;
            Matrix matrix = new Matrix();
            matrix.ScaleAt(wRatio, hRatio, beforePoint.X / 2 , beforePoint.Y / 2 );
            inkCanvas.Strokes.Transform(matrix, false);
            Matrix matrixMove1 = new Matrix();
           
            matrixMove1.Translate((R.ActualWidth - width) / 2, (R.ActualHeight - height) / 2 );
            inkCanvas.Strokes.Transform(matrixMove1, false);
            width = R.ActualWidth;
            height = R.ActualHeight;
         

        }



        private void inkCanvas_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if(ActualHeight>0&& ActualWidth > 0)
            {
                ratio1.actualwidth = ActualWidth;
                MatrixTransform();
                double ratio = ratio1.Ratio;
                string position = DrawInkMethod.defdimenViewModel.DimPos;
                double length = DrawInkMethod.defdimenViewModel.Length;
                drawDefaultDim(position, length, Colors.AliceBlue, ratio);
            }
          

        }

        private void inkCanvas_MouseLeave(object sender, MouseEventArgs e)
        {
            if (ToolTop.SelectChecked)
            {
                try
                {
                    inkCanvas.Strokes.Remove(lastTempStroke);
                   
                }
                catch(Exception ex)
                {
                   // MessageBox.Show(ex.Message);
                }

            }
        }

        private void inkCanvas_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
           // MessageBox.Show(index.ToString());
        }



    }
}


