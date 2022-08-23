using Global.Mode;
using Global.Mode.Config;
using Lambda;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Resources;

namespace Global.UserControls.DrawVisual
{
    public class RatioClass
    {
        public double Ratio = 1;
        public double actualwidth=1;
       
    }

    /// <summary>
    /// InkVisual.xaml 的交互逻辑
    /// </summary>
    public partial class InkVisual : UserControl
    {
        
        public InkVisual(Image image,ImageViewState.ToolTop ToolTop, DrawInkMethod inkMethod)
        {
            InitializeComponent();
            this.ToolTop = ToolTop;
            this.inkMethod = inkMethod;
              // imagingView = ImagingView;
            topToolbar =(WrapPanel)mainwin.FindName("topToolbar");
            this.image = image;
          
        }

        Window mainwin = Application.Current.MainWindow;
        WrapPanel topToolbar;
        private double width;
        private double height;
        public ImageViewState.ToolTop ToolTop;
        private Image image;
       
        public RatioClass ratio1 =new RatioClass();
        public ProfileModel profileModel;
        // public double ratio = 1;
        DrawInkMethod inkMethod;
        bool isMouseDown = false;
        Point iniP = new Point(0, 0);
        public  Stroke lastTempStroke = null;
        public  Stroke lastTempStroke0 = null;
        public int ZoomInOut = 0;
       
        public StrokeCollection tempStroke = new StrokeCollection();
        public StrokeCollection RegisterStroke = new StrokeCollection();
        public bool saveTempStroke = true;
        private int textFlag = 0;
        Stroke lastTempStroke1 = null;
        Stroke lastTempStroke2 = null;
        public  Stroke profileStroke;

        private Point movePoint= new Point(0, 0);

       

        public void DrawProfile()
        {
              Point ProfileIniP;
              Point ProfileEndP;
            if (inkCanvas.Strokes.Contains(profileStroke) && profileStroke!=null)
            {
                ProfileIniP= new Point( profileStroke.StylusPoints[0].X, profileStroke.StylusPoints[0].Y );
                ProfileEndP = new Point(profileStroke.StylusPoints[1].X, profileStroke.StylusPoints[1].Y);
            }

            profileStroke = DrawInkMethod.InkCanvasMethod.CreateProfile(ProfileIniP, ProfileEndP, profileModel);
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
            if (isMouseDown && ToolTop.ArrowChecked)    //Arrow
            {
                double dist = GetDistance(endP, iniP);
                if (dist < 5)
                    return;
                stroke = inkMethod.GenerateArrowLineStroke(iniP, endP);
                try
                {
                    inkCanvas.Strokes.Remove(lastTempStroke);
                }
                catch { }
                lastTempStroke = stroke;
                inkCanvas.Strokes.Add(stroke);
              
            }
           else if (isMouseDown && ToolTop.LineChecked)  //line
            {
                double dist = GetDistance(endP, iniP);
                if (dist < 5)
                    return;
                stroke = inkMethod.GenerateLineStroke(iniP, endP);
                try
                {
                    inkCanvas.Strokes.Remove(lastTempStroke);
                }
                catch { }
                lastTempStroke = stroke;
                inkCanvas.Strokes.Add(stroke);
               
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
                   
                    double dist = GetDistance(endP, iniP);
                    if (dist < 5)
                        return;
                    stroke = inkMethod.GenerateRulerStroke(iniP, endP);
                    try
                    {
                        inkCanvas.Strokes.Remove(lastTempStroke);
                    }
                    catch { }
                    lastTempStroke = stroke;
                    inkCanvas.Strokes.Add(stroke);
                    double width = ActualWidth;
                    stroke0 = DrawInkMethod.InkCanvasMethod.CreateRulerText(iniP, endP, ratio1);
                    try
                    {
                        inkCanvas.Strokes.Remove(lastTempStroke0);
                    }
                    catch { }
                    lastTempStroke0 = stroke0;
                    inkCanvas.Strokes.Add(stroke0);

                }
            
            
            }
            else if(isMouseDown && ToolTop.ProfileChecked)
            {

                //double dist = GetDistance(endP, iniP);
                //if (dist < 5)
                //    return;
                //stroke = inkMethod.GenerateProfileStroke(iniP, endP);
                //try
                //{
                //    inkCanvas.Strokes.Remove(lastTempStroke);
                //}
                //catch { }
                //lastTempStroke = stroke;
                //inkCanvas.Strokes.Add(stroke);

                //stroke0 = DrawInkMethod.InkCanvasMethod.CreateMarkerText(iniP, endP);
                //try
                //{
                //    inkCanvas.Strokes.Remove(lastTempStroke0);
                //}
                //catch { }
                //lastTempStroke0 = stroke0;
                //inkCanvas.Strokes.Add(stroke0);

                //Stroke stroke1 = inkMethod.GenerateMarker1Stroke(iniP);
                //Stroke stroke2 = inkMethod.GenerateMarker1Stroke(endP);

                //try
                //{
                //    inkCanvas.Strokes.Remove(lastTempStroke1);
                //    inkCanvas.Strokes.Remove(lastTempStroke2);
                //}
                //catch { }
                //lastTempStroke1 = stroke1;
                //lastTempStroke2 = stroke2;
                //inkCanvas.Strokes.Add(stroke1);
                //inkCanvas.Strokes.Add(stroke2);

                profileStroke = DrawInkMethod.InkCanvasMethod.CreateProfile(iniP,endP, profileModel);
                
                try
                {
                    inkCanvas.Strokes.Remove(lastTempStroke);
                }
                catch { }
                lastTempStroke = profileStroke;
                inkCanvas.Strokes.Add(profileStroke);

            }

            else  if (isMouseDown && ToolTop.DimensionChecked) //dimension
            {

                switch (DrawInkMethod.dimenViewModel.DimSelectedIndex)
                {

                    case 0:

                        stroke = inkMethod.GenerateDimensionStroke1(iniP, endP);
                        break;
                    case 1:
                        stroke = inkMethod.GenerateDimensionStroke2(iniP, endP);
                        break;
                    case 2:
                        stroke = inkMethod.GenerateDimensionStroke3(iniP, endP);
                        break;

                    case 3:
                        stroke = inkMethod.GenerateDimensionStroke4(iniP, endP);
                        break;
                    case 4:
                        stroke = inkMethod.GenerateDimensionStroke5(iniP, endP);
                        break;
                   default:
                        stroke = inkMethod.GenerateDimensionStroke1(iniP, endP);
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
               
                stroke0 = DrawInkMethod.InkCanvasMethod.CreateText(iniP, endP,ratio1);
                try
                {
                    inkCanvas.Strokes.Remove(lastTempStroke0);
                }
                catch { }
                lastTempStroke0 = stroke0;
                inkCanvas.Strokes.Add(stroke0);
               

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

                    if (inkCanvas.Strokes.Contains(inkMethod.Dimstroke))
                    {
                        inkCanvas.Strokes.Remove(inkMethod.Dimstroke);
                        inkCanvas.Strokes.Remove(inkMethod.Textstroke);

                    }
                    Matrix matrixMove1 = new Matrix();
                    matrixMove1.Translate(endP.X - movePoint.X, endP.Y - movePoint.Y);
                    inkCanvas.Strokes.Transform(matrixMove1, false);
                    if (inkMethod.Dimstroke != null && inkMethod.Textstroke != null)

                    {
                        inkCanvas.Strokes.Add(inkMethod.Dimstroke);
                        inkCanvas.Strokes.Add(inkMethod.Textstroke);
                    }
                    movePoint = endP;

                }

                //var container = VisualTreeHelper.GetChild(this,0) as UIElement;
                //container.RenderTransform = new TranslateTransform(endP.X - movePoint.X, endP.Y - movePoint.Y);

               


            }

            if (isMouseDown && ToolTop.CircleChecked)
            {
                var isShiftDown = Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift);
                double delta = (iniP.X - endP.X) * (iniP.Y - endP.Y);
                if (isShiftDown && delta != 0)
                {
                    stroke = inkMethod.GenerateCircleStroke(iniP, endP);
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
                    stroke = inkMethod.GenerateEllipseStroke(iniP, endP);
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
                    stroke = inkMethod.GenerateSquareStroke(iniP, endP);
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
                    stroke = inkMethod.GenerateRectangleStroke(iniP, endP);

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
                if (inkCanvas.Cursor == Cursors.Arrow)
                {
                    inkCanvas.UseCustomCursor = true;
                    StreamResourceInfo sri = Application.GetResourceStream(new Uri("/Global;component/usercontrols/image/eraser.cur", UriKind.Relative));
                    inkCanvas.Cursor = new Cursor(sri.Stream);
                }
            }
            if (ToolTop.ArrowChecked || ToolTop.DimensionChecked || ToolTop.LineChecked || ToolTop.PolygonChecked || ToolTop.RectangleChecked || ToolTop.TextChecked)
            {
                if(inkCanvas.Cursor == Cursors.Arrow)
                {
                    inkCanvas.Cursor = Cursors.Cross;
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
                point1 = new StylusPointCollection(pointList1);

                if (pointList1.Count > 1)
                {
                    stroke1 = new Stroke(point1)
                    {
                        DrawingAttributes = inkMethod.drawingAttributes.Clone()
                    };
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
                        Foreground = new SolidColorBrush(DrawInkMethod.dimenViewModel.SelectedAccentColor)

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
                        Brush brush = new SolidColorBrush(DrawInkMethod.dimenViewModel.SelectedAccentColor);
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
                inkMethod.bezierPointList.Add(iniP);
                point1 = new StylusPointCollection(inkMethod.bezierPointList);
                if (inkMethod.bezierPointList.Count == 4)
                {
                    stroke1 = new Stroke(point1)
                    {
                        DrawingAttributes = inkMethod.BezierdrawingAttributes.Clone()
                    };

                    try
                    {
                        inkCanvas.Strokes.Remove(lastTempStroke);
                    }
                    catch { }
                    lastTempStroke = stroke1;
                    inkCanvas.Strokes.Add(stroke1);
                    inkMethod.bezierPointList.Clear();
                }


            }
        }


     
      


        private void inkCanvas_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if(ToolTop.PolygonChecked)
            {

            }
            else if (ToolTop.SelectChecked ||ToolTop.ProfileChecked)
            {

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
                        point1 = new StylusPointCollection(pointList1);
                        stroke1 = new Stroke(point1)
                        {
                            DrawingAttributes = inkMethod.drawingAttributes.Clone()
                        };
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

        private void inkCanvas_MouseWheel(object sender, MouseWheelEventArgs e)
        {


            if (saveTempStroke && inkCanvas.Strokes.Count > 0)
            {
                if (inkCanvas.Strokes.Contains(inkMethod.Dimstroke))
                {
                    inkCanvas.Strokes.Remove(inkMethod.Dimstroke);
                    inkCanvas.Strokes.Remove(inkMethod.Textstroke);

                }

                tempStroke = inkCanvas.Strokes.Clone();
                if (inkMethod.Dimstroke != null && inkMethod.Textstroke != null)

                {
                    inkCanvas.Strokes.Add(inkMethod.Dimstroke);
                    inkCanvas.Strokes.Add(inkMethod.Textstroke);
                }

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
               

            }
            else if(e.Delta < 0 && ZoomInOut>0)
            {
                matrix.ScaleAt(1/1.2, 1/1.2, curPoint.X, curPoint.Y);
                ZoomInOut--;
                //marker
                ratio1.Ratio = ratio1.Ratio / 1.2;
                inkCanvas.Strokes.Transform(matrix, false);
                RepaintDim();
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
                
            }
            




        }
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
                //try
                //{
                //    inkCanvas.Strokes.Remove(lastTempStroke);
                //}
                //catch { }
                //inkVisual.lastTempStroke = inkMethod.Dimstroke;
                inkCanvas.Strokes.Add(inkMethod.Dimstroke);
                //inkVisual.lastTempStroke = null;
                inkMethod.Textstroke = DrawInkMethod.InkCanvasMethod.CreateText1(iniP, endP);
                inkCanvas.Strokes.Add(inkMethod.Textstroke);

            }
        }


       
        private  void MatrixTransform()
        {
           
            Point beforePoint = new Point(width, height);
            Point point = new Point(R.ActualWidth, ActualHeight);
            double wRatio = R.ActualWidth / width;
            double hRatio = R.ActualHeight / height;
            Matrix matrix = new Matrix();
            matrix.ScaleAt(wRatio, hRatio, beforePoint.X / 2 , beforePoint.Y / 2 );
            inkCanvas.Strokes.Transform(matrix, false);
            Matrix matrixMove1 = new Matrix();
           
            matrixMove1.Translate((R.ActualWidth - width) / 2, (ActualHeight - height) / 2 );
            inkCanvas.Strokes.Transform(matrixMove1, false);
            width = R.ActualWidth;
            height = ActualHeight;
         

        }



        private void inkCanvas_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if(ActualHeight>0&& ActualWidth > 0)
            {
                ratio1.actualwidth = ActualWidth;
                MatrixTransform();
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
    }
}


