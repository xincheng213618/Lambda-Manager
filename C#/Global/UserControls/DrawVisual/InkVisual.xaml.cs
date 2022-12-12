using Global.Mode;
using Global.Mode.Config;
using Lambda;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Resources;
using System.Windows.Threading;
using static Global.DrawInkMethod;

namespace Global.UserControls.DrawVisual
{
    public class RatioClass
    {

        public double Ratio = 1;
        public double actualwidth = 1;

    }

    public enum Mode : int
    {
        BF=0,DF =1,RI=2,DP=3,QP=4,PC=5

    }
    /// <summary>
    /// InkVisual.xaml 的交互逻辑
    /// </summary>
    public partial class InkVisual : UserControl
    {

        public InkVisual(int index1, Image image1, ImageViewState.ToolTop ToolTop)

        {
            InitializeComponent();
            this.ToolTop = ToolTop;
            //this.inkMethod = inkMethod;
            topToolbar = (WrapPanel)mainwin.FindName("topToolbar");
            this.image = image1;
            this.index = index1;
            this.inkcanva = inkCanvas;
            this.ActiveMode = index1;
            //MessageBox.Show("2");
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
                            int dash = dimenViewModel.DashSelectedIndex;
                            stroke1 = InkCanvasMethod.CreatePolygon(pointList1, color, lineWidth, dash);
                            try
                            {
                                inkCanvas.Strokes.Remove(lastTempStroke);
                            }
                            catch { }
                            lastTempStroke = null;
                            inkCanvas.Strokes.Add(stroke1);

                            pointList1.Clear();
                            StrokeTransforChange(1, drawVisuals, this );


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
                     
                        defaultDim.Visibility = Visibility.Hidden;
                    }
                };
                if (e.PropertyName == "ProfileChecked")
                {
                    if (!ToolTop.ProfileChecked)
                    {
                        if (inkCanvas.Strokes.Contains(profileStroke) && profileStroke != null)
                        {
                            inkCanvas.Strokes.Remove(profileStroke);
                        }
                    };
                };

            };


            defaultDim.DataContext = inkDimViewModel;  // default Dimension bingding ViewModel
            DrawInkMethod.defdimenViewModel.PropertyChanged += delegate (object? sender, PropertyChangedEventArgs e)
            {
                if (e.PropertyName == "DimPos" || e.PropertyName == "Length" || e.PropertyName == "SelectedAccentColor" || e.PropertyName == "TextSelectedAccentColor")
                {
                    double ratio = ratio1.Ratio;
                    string position = DrawInkMethod.defdimenViewModel.DimPos;
                    double length = DrawInkMethod.defdimenViewModel.Length;
                    Color color = DrawInkMethod.defdimenViewModel.SelectedAccentColor;
                    Color TextColor = DrawInkMethod.defdimenViewModel.TextSelectedAccentColor;
                    if (index == ActiveViews.ActiveWin)
                    {
                        drawDefaultDim(position, length, color, ratio, TextColor);
                    }

                }

            };
            inkCanvas.Strokes.StrokesChanged += delegate
            {

                DrawInkMethod.StrokesCollection.Clear();

                FilterStroke(1);
                // FilterStroke1(1,RegisterStroke);



            };

            if (index1 == 0)
            {
                DrawInkMethod.ActiveInk = this.inkCanvas;
            }
            else
            {

                DrawInkMethod.ActiveViews.ActiveWin = 0;
                Color color = (Color)ColorConverter.ConvertFromString("#6EA646");
                WindowData1.GetInstance().inkVisuals[0].Border.BorderBrush = new SolidColorBrush(color);
            }

        }

        Window mainwin = Application.Current.MainWindow;
        WrapPanel topToolbar;
        private double width;
        private double height;
        public ImageViewState.ToolTop ToolTop;
        private Image image;
        public int index;
        public InkCanvas inkcanva;
        public RatioClass ratio1 = new RatioClass();
        public ProfileModel profileModel;
        // DrawInkMethod inkMethod;
        bool isMouseDown = false;
        Point iniP = new Point(0, 0);
        public Stroke lastTempStroke = null;
        public Stroke lastTempStroke0 = null;
        public int ActiveMode ;
        public StrokeCollection tempStroke = new StrokeCollection();
        public StrokeCollection RegisterStroke = new StrokeCollection();
        //  public ObservableCollection<Stroke> StrokesTransfer  = new ObservableCollection<Stroke>();
        public bool saveTempStroke = true;
        private int textFlag = 0;
        public Stroke profileStroke;
        int i = 0;
        Stroke lastTempCurveStroke = null;
        List<Point> CurvePointsList = new List<Point>();
        public InkDimViewModel inkDimViewModel = new InkDimViewModel();
        private Point movePoint = new Point(0, 0);
        public string deftDimP = "下右";
        public double defDimL = 100;
        public Color defDimC = Color.FromArgb(240, 240, 0, 0);
        public Color defDimTextC = Colors.White;

        List<System.Windows.Point> pointList1 = new List<Point>();
        List<System.Windows.Point> pointListRuler = new List<Point>();
        StylusPointCollection point1;
        public Point RecTopLeft = new Point(0, 0);
        public Point RecBottomRight = new Point(0, 0);
        Stroke stroke1;
        Point PointSt;
        Point PointStRuler;
        int[] lastTempArray = new int[4];
        int[] CurrentArray = new int[4];
        Matrix InverseMatrix = new Matrix();
        Matrix InverseMatrixDim = new Matrix();
        public ObservableCollection<VisualAttritube> drawVisuals = new ObservableCollection<VisualAttritube>();
        public List<VisualAttritube> drawVisualsCopy = new List<VisualAttritube>();
      
        public void FilterStroke(int i)
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
                if (item is QuadraticBezierpath quadraticBezier)
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
                if (item is RulerStroke ruler)
                {
                    ruler.Index = i++;
                    DrawInkMethod.StrokesCollection.Add(ruler);
                }

            }

        }

        public void DrawProfile()
        {
            Point ProfileIniP;
            Point ProfileEndP;
            if (inkCanvas.Strokes.Contains(profileStroke) && profileStroke != null)
            {
                ProfileIniP = new Point(profileStroke.StylusPoints[0].X, profileStroke.StylusPoints[0].Y);
                ProfileEndP = new Point(profileStroke.StylusPoints[1].X, profileStroke.StylusPoints[1].Y);
            }
            Color color = DrawInkMethod.dimenViewModel.SelectedAccentColor;
            profileStroke = DrawInkMethod.InkCanvasMethod.CreateProfile(ProfileIniP, ProfileEndP, profileModel, color);
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
                    int dash = dimenViewModel.DashSelectedIndex;
                    stroke = InkCanvasMethod.CreateLineStroke(iniP, endP, color0, lineWidth, dash);
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
                    int dash = dimenViewModel.DashSelectedIndex;
                    stroke = DrawInkMethod.InkCanvasMethod.CreateQuadraticBesizer(CurvePointsList, color, lineWidth, dash);
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
                    if (CurvePointsList.Count > 3)
                    {
                        CurvePointsList.RemoveAt(2);
                    }
                    CurvePointsList.Insert(2, m2);
                    Color color = DrawInkMethod.dimenViewModel.SelectedAccentColor;
                    int lineWidth = dimenViewModel.LineWidth;
                    int dash = dimenViewModel.DashSelectedIndex;
                    stroke = DrawInkMethod.InkCanvasMethod.CreateBesizer(CurvePointsList, color, lineWidth, dash);
                    try
                    {
                        inkCanvas.Strokes.Remove(lastTempCurveStroke);
                    }
                    catch { }
                    lastTempCurveStroke = stroke;
                    inkCanvas.Strokes.Add(stroke);

                }


            }
            else if (ToolTop.RulerChecked) //ruler
            {
                if (inkCanvas.Cursor == Cursors.Arrow)
                {
                    inkCanvas.UseCustomCursor = true;
                    StreamResourceInfo sri = Application.GetResourceStream(new Uri("/Global;component/usercontrols/image/Ruler.cur", UriKind.Relative));
                    inkCanvas.Cursor = new Cursor(sri.Stream);
                }
                drawRulerPolygon2(sender, e);
             

            }
            else if (isMouseDown && ToolTop.ProfileChecked)
            {


                Color color = DrawInkMethod.dimenViewModel.SelectedAccentColor;
                profileStroke = DrawInkMethod.InkCanvasMethod.CreateProfile(iniP, endP, profileModel, color);

                try
                {
                    inkCanvas.Strokes.Remove(lastTempStroke);
                }
                catch { }
                lastTempStroke = profileStroke;
                inkCanvas.Strokes.Add(profileStroke);

            }

            else if (isMouseDown && ToolTop.LineChecked) //dimension
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
                        int dash = dimenViewModel.DashSelectedIndex;
                        stroke = InkCanvasMethod.CreateLineStroke(iniP, endP, color0, lineWidth, dash);
                        break;

                    case 1:

                        Color color1 = dimenViewModel.SelectedAccentColor;
                        int lineWidth1 = dimenViewModel.LineWidth;
                        int dash1 = dimenViewModel.DashSelectedIndex;
                        stroke = InkCanvasMethod.CreateArrowStroke(iniP, endP, color1, lineWidth1, dash1);
                        break;
                    case 2:
                        int lineWidth2 = dimenViewModel.LineWidth;
                        int dash2 = dimenViewModel.DashSelectedIndex;

                        bool italic = dimenViewModel.Italic;
                        bool bold = dimenViewModel.Bold;
                        bool underline = dimenViewModel.UnderLine;
                        int fontSize = dimenViewModel.FontSize;
                        FontFamily font = dimenViewModel.FontFam;
                        string labpos = dimenViewModel.LabelPos;
                        stroke = InkCanvasMethod.CreateDim1Stroke(iniP, endP, dimenViewModel.SelectedAccentColor, ratio1, dimenViewModel.TextSelectedAccentColor, dimenViewModel.Label, lineWidth2, dash2, italic, bold, underline, fontSize, font, labpos);
                        break;
                    case 3:
                        int lineWidth3 = dimenViewModel.LineWidth;
                        int dash3 = dimenViewModel.DashSelectedIndex;
                        bool italic3 = dimenViewModel.Italic;
                        bool bold3 = dimenViewModel.Bold;
                        bool underline3 = dimenViewModel.UnderLine;
                        int fontSize3 = dimenViewModel.FontSize;
                        FontFamily font3 = dimenViewModel.FontFam;
                        string labpos3 = dimenViewModel.LabelPos;
                        stroke = InkCanvasMethod.CreateDim2Stroke(iniP, endP, dimenViewModel.SelectedAccentColor, ratio1, dimenViewModel.TextSelectedAccentColor, dimenViewModel.Label, lineWidth3, dash3, italic3, bold3, underline3, fontSize3, font3, labpos3);
                        break;
                    case 4:
                        int lineWidth4 = dimenViewModel.LineWidth;
                        int dash4 = dimenViewModel.DashSelectedIndex;
                        bool italic4 = dimenViewModel.Italic;
                        bool bold4 = dimenViewModel.Bold;
                        bool underline4 = dimenViewModel.UnderLine;
                        int fontSize4 = dimenViewModel.FontSize;
                        FontFamily font4 = dimenViewModel.FontFam;
                        string labpos4 = dimenViewModel.LabelPos;

                        stroke = InkCanvasMethod.CreateDim3Stroke(iniP, endP, dimenViewModel.SelectedAccentColor, ratio1, dimenViewModel.TextSelectedAccentColor, dimenViewModel.Label, lineWidth4, dash4, italic4, bold4, underline4, fontSize4, font4, labpos4);
                        break;
                    case 5:
                        int lineWidth5 = dimenViewModel.LineWidth;
                        int dash5 = dimenViewModel.DashSelectedIndex;
                        bool italic5 = dimenViewModel.Italic;
                        bool bold5 = dimenViewModel.Bold;
                        bool underline5 = dimenViewModel.UnderLine;
                        int fontSize5 = dimenViewModel.FontSize;
                        FontFamily font5 = dimenViewModel.FontFam;
                        string labpos5 = dimenViewModel.LabelPos;
                        stroke = InkCanvasMethod.CreateDim4Stroke(iniP, endP, dimenViewModel.SelectedAccentColor, ratio1, dimenViewModel.TextSelectedAccentColor, dimenViewModel.Label, lineWidth5, dash5, italic5, bold5, underline5, fontSize5, font5, labpos5);
                        break;

                    default:
                        Color color6 = dimenViewModel.SelectedAccentColor;
                        int lineWidth6 = dimenViewModel.LineWidth;
                        int dash6 = dimenViewModel.DashSelectedIndex;
                        stroke = InkCanvasMethod.CreateLineStroke(iniP, endP, color6, lineWidth6, dash6);
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


            else if (isMouseDown && ToolTop.MoveChecked)     //move
            {

                if (inkCanvas.Cursor == Cursors.Hand)
                {
                    StreamResourceInfo sri = Application.GetResourceStream(new Uri("/Global;component/usercontrols/image/hold.cur", UriKind.Relative));
                    inkCanvas.Cursor = new Cursor(sri.Stream);
                }
            
                var isCtrlDown = Keyboard.IsKeyDown(Key.LeftCtrl) || Keyboard.IsKeyDown(Key.RightCtrl);

                if (ratio1.Ratio != 1&& !isCtrlDown)
                {


                    Matrix matrixMove1 = new Matrix();
                    matrixMove1.Translate(endP.X - movePoint.X, endP.Y - movePoint.Y);
                    inkCanvas.Strokes.Transform(matrixMove1, false);

                    RecTopLeft = RecTopLeft * matrixMove1;
                    RecBottomRight = RecBottomRight * matrixMove1;

                    ZoomParTransform(ratio1.Ratio, inkCanvas.Strokes, this );





                }
              
                if (isCtrlDown)
                {
                    foreach (InkVisual ink in InkAll)
                    {

                        if (ink != null )
                        {

                            if (ink.ratio1.Ratio != 1)
                            {

                                Matrix matrixMove2 = new Matrix();
                                matrixMove2.Translate(endP.X - movePoint.X, endP.Y - movePoint.Y);
                                ink.inkCanvas.Strokes.Transform(matrixMove2, false);
                                ink.RecTopLeft = ink.RecTopLeft * matrixMove2;
                                ink.RecBottomRight = ink.RecBottomRight * matrixMove2;

                                ZoomParTransform(ink.ratio1.Ratio, ink.inkCanvas.Strokes,ink);
                            }

                        }

                    }

                }

                movePoint = endP;

            }

            if (isMouseDown && ToolTop.CircleChecked)
            {
                var isShiftDown = Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift);
                double delta = (iniP.X - endP.X) * (iniP.Y - endP.Y);
                if (isShiftDown && delta != 0)
                {
                    Color color = dimenViewModel.SelectedAccentColor;
                    int lineWidth = dimenViewModel.LineWidth;
                    int dash = dimenViewModel.DashSelectedIndex;
                    stroke = InkCanvasMethod.CreateCircle(iniP, endP, color, lineWidth, dash);
                    // stroke = inkMethod.GenerateCircleStroke(iniP, endP);
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
                    int dash = dimenViewModel.DashSelectedIndex;
                    stroke = InkCanvasMethod.CreateEllipse(iniP, endP, color, lineWidth, dash);

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
                    int dash = dimenViewModel.DashSelectedIndex;
                    stroke = InkCanvasMethod.CreateSquare(iniP, endP, color, lineWidth, dash);
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
                    int dash = dimenViewModel.DashSelectedIndex;
                    stroke = InkCanvasMethod.CreateRectangleStroke(iniP, endP, color, lineWidth, dash);

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
            if ( ToolTop.DimensionChecked || ToolTop.LineChecked || ToolTop.PolygonChecked || ToolTop.RectangleChecked || ToolTop.TextChecked || ToolTop.CurveChecked)
            {
                if (inkCanvas.Cursor == Cursors.Arrow || inkCanvas.Cursor == null)
                {
                    inkCanvas.Cursor = Cursors.Cross;
                }
            }
            if (ToolTop.MoveChecked)
            {
                if (inkCanvas.Cursor == Cursors.Arrow || inkCanvas.Cursor == null)
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
                    Color color = dimenViewModel.SelectedAccentColor;
                    int lineWidth = dimenViewModel.LineWidth;
                    int dash = dimenViewModel.DashSelectedIndex;
                    stroke1 = InkCanvasMethod.CreatePolygon(pointList1, color, lineWidth, dash);
                  
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
        private void drawRulerPolygon1(object sender, MouseButtonEventArgs e)
        {
            iniP = e.GetPosition(inkCanvas);
            pointListRuler.Add(iniP);
            // point1 = new StylusPointCollection(pointList1);

            if (pointListRuler.Count > 1)
            {
                Color color = dimenViewModel.SelectedAccentColor;
                int lineWidth = dimenViewModel.LineWidth;
                int dash = dimenViewModel.DashSelectedIndex;
                Color TextColor = dimenViewModel.TextSelectedAccentColor;

                bool italic = dimenViewModel.Italic;
                bool bold = dimenViewModel.Bold;
                bool underline = dimenViewModel.UnderLine;
                int fontSize = dimenViewModel.FontSize;
                FontFamily font = dimenViewModel.FontFam;
                stroke1 = InkCanvasMethod.CreateRuler(pointListRuler,color ,ratio1, TextColor, lineWidth, dash, italic, bold, fontSize, font);
                try
                {
                    inkCanvas.Strokes.Remove(lastTempStroke);
                }
                catch { }
                lastTempStroke = stroke1;
                inkCanvas.Strokes.Add(stroke1);


            }
            


        }

        private void drawRulerPolygon2(object sender, MouseEventArgs e)
        {
            Point Point2 = e.GetPosition(inkCanvas);
            if (pointListRuler.Count > 0)
            {
                pointListRuler.Add(Point2);
                Color color = dimenViewModel.SelectedAccentColor;
                int lineWidth = dimenViewModel.LineWidth;
                int dash = dimenViewModel.DashSelectedIndex;
                Color TextColor = dimenViewModel.TextSelectedAccentColor;

                bool italic = dimenViewModel.Italic;
                bool bold = dimenViewModel.Bold;
                bool underline = dimenViewModel.UnderLine;
                int fontSize = dimenViewModel.FontSize;
                FontFamily font = dimenViewModel.FontFam;
                stroke1 = InkCanvasMethod.CreateRuler(pointListRuler, color, ratio1, TextColor, lineWidth, dash, italic, bold, fontSize, font);
                try
                {
                    inkCanvas.Strokes.Remove(lastTempStroke);
                }
                catch { }
                lastTempStroke = stroke1;
                inkCanvas.Strokes.Add(stroke1);
                pointListRuler.Remove(Point2);
            }


        }

        private void drawRulerPolygon3(object sender, KeyEventArgs e)
        {
            if (pointListRuler.Count > 1)
            {

                Color color = dimenViewModel.SelectedAccentColor;
                int lineWidth = dimenViewModel.LineWidth;
                int dash = dimenViewModel.DashSelectedIndex;
                Color TextColor = dimenViewModel.TextSelectedAccentColor;

                bool italic = dimenViewModel.Italic;
                bool bold = dimenViewModel.Bold;
                bool underline = dimenViewModel.UnderLine;
                int fontSize = dimenViewModel.FontSize;
                FontFamily font = dimenViewModel.FontFam;
                stroke1 = InkCanvasMethod.CreateRuler(pointListRuler, color, ratio1, TextColor, lineWidth, dash, italic, bold, fontSize, font);
                try
                {
                    inkCanvas.Strokes.Remove(lastTempStroke);
                }
                catch { }
                lastTempStroke = null;
                inkCanvas.Strokes.Add(stroke1);
                pointListRuler.Clear();
                StrokeTransforChange(1, drawVisuals, this);

            }


        }
        private void drawRulerPolygon3()
        {
            if (pointListRuler.Count > 1)
            {

                Color color = dimenViewModel.SelectedAccentColor;
                int lineWidth = dimenViewModel.LineWidth;
                int dash = dimenViewModel.DashSelectedIndex;
                Color TextColor = dimenViewModel.TextSelectedAccentColor;

                bool italic = dimenViewModel.Italic;
                bool bold = dimenViewModel.Bold;
                bool underline = dimenViewModel.UnderLine;
                int fontSize = dimenViewModel.FontSize;
                FontFamily font = dimenViewModel.FontFam;
                stroke1 = InkCanvasMethod.CreateRuler(pointListRuler, color, ratio1, TextColor, lineWidth, dash, italic, bold, fontSize, font);
                try
                {
                    inkCanvas.Strokes.Remove(lastTempStroke);
                }
                catch { }
                lastTempStroke = null;
                inkCanvas.Strokes.Add(stroke1);
                pointListRuler.Clear();
                StrokeTransforChange(1, drawVisuals, this);

            }


        }





        private void inkCanvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            iniP = e.GetPosition(inkCanvas);
            isMouseDown = true;
            // inkCanvas.CaptureMouse();
            Stroke stroke;
            //Stroke stroke0;

            if (ToolTop.MoveChecked == true)
            {
                StreamResourceInfo hold = Application.GetResourceStream(new Uri("/Global;component/usercontrols/image/hold.cur", UriKind.Relative));
                inkCanvas.Cursor = new Cursor(hold.Stream);
                movePoint = iniP;
            };

            if (ToolTop.RulerChecked)
            {

                drawRulerPolygon1(sender, e);

                if (e.ClickCount == 2)
                {
                    drawRulerPolygon3();
                }

            }
            if (ToolTop.PolygonChecked == true)
            {

                pointList1.Add(iniP);
                // point1 = new StylusPointCollection(pointList1);

                if (pointList1.Count > 1)
                {
                    Color color = dimenViewModel.SelectedAccentColor;
                    int lineWidth = dimenViewModel.LineWidth;
                    int dash = dimenViewModel.DashSelectedIndex;
                    stroke1 = InkCanvasMethod.CreatePolygon(pointList1, color, lineWidth, dash);
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
                    InkCanvas.SetLeft(textBox, iniP.X - 3);
                    InkCanvas.SetTop(textBox, iniP.Y - 1);
                    textBox.Focus();


                    textBox.LostFocus += delegate
                    {
                        if (textBox.Text == "")
                        {
                            inkCanvas.Children.Remove(textBox);
                            return;

                        }
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
                        bool italic = DrawInkMethod.dimenViewModel.Italic;
                        bool bold = DrawInkMethod.dimenViewModel.Bold;
                        bool underLine = DrawInkMethod.dimenViewModel.UnderLine;
                        int fontSize = DrawInkMethod.dimenViewModel.FontSize;
                        FontFamily fontFamily = DrawInkMethod.dimenViewModel.FontFam;
                        Color textColor = DrawInkMethod.dimenViewModel.TextSelectedAccentColor;
                        Stroke stroke = DrawInkMethod.InkCanvasMethod.CreateTextInput(iniP, height, width, text, textColor, italic, bold, underLine, fontSize, fontFamily);
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
                    int dash = dimenViewModel.DashSelectedIndex;
                    stroke = DrawInkMethod.InkCanvasMethod.CreateQuadraticBesizer(CurvePointsList, color, lineWidth, dash);
                    try
                    {
                        inkCanvas.Strokes.Remove(lastTempCurveStroke);
                    }
                    catch { }
                    lastTempCurveStroke = stroke;
                    inkCanvas.Strokes.Add(stroke);

                }
                else if (i == 2)
                {
                    CurvePointsList.Insert(2, iniP);
                    Color color = DrawInkMethod.dimenViewModel.SelectedAccentColor;
                    int lineWidth = dimenViewModel.LineWidth;
                    int dash = dimenViewModel.DashSelectedIndex;
                    stroke = DrawInkMethod.InkCanvasMethod.CreateBesizer(CurvePointsList, color, lineWidth, dash);
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
            Point end = e.GetPosition(inkCanvas);
            if (ToolTop.PolygonChecked|| ToolTop.RulerChecked)
            {

            }
            else if (ToolTop.ProfileChecked)
            {

                Dictionary<string, object> parameters = new Dictionary<string, object>()
                            {
                            {"p1x",(int)(iniP.X/ ActualWidth * 1280)},
                            {"p1y",(int)(iniP.Y /ActualHeight * 960)},
                            {"p2x",(int)(end.X / ActualWidth * 1280)},
                            { "p2y",(int)(end.Y / ActualHeight * 960)}

                            };
                LambdaControl.Trigger("PROFILE_PARAMETERS", null, parameters);

                // MessageBox.Show(parameters.Values.Count.ToString());

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
                if (ToolTop.SelectChecked)
                    return;
                lastTempStroke = null;
                lastTempStroke0 = null;
            };
            isMouseDown = false;
            // inkCanvas.ReleaseMouseCapture();

            if (ToolTop.MoveChecked == true)
            {
                inkCanvas.Cursor = Cursors.Hand;

                movePoint = e.GetPosition(inkCanvas);

            }


            StrokeTransforChange(1, drawVisuals,this);


        }



        private void inkCanvas_PreviewKeyDown(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Escape)
            {

                try
                {
                    if (ToolTop.PolygonChecked)
                    {
                        if (pointList1.Count > 1)
                        {

                            pointList1.Add(PointSt);
                            Color color = dimenViewModel.SelectedAccentColor;
                            int lineWidth = dimenViewModel.LineWidth;
                            int dash = dimenViewModel.DashSelectedIndex;
                            stroke1 = InkCanvasMethod.CreatePolygon(pointList1, color, lineWidth, dash);
                            try
                            {
                                inkCanvas.Strokes.Remove(lastTempStroke);
                            }
                            catch { }
                            lastTempStroke = null;
                            inkCanvas.Strokes.Add(stroke1);

                            pointList1.Clear();
                            StrokeTransforChange(1, drawVisuals, this);

                        }
                    }
                    if (ToolTop.RulerChecked)
                    {
                        drawRulerPolygon3(sender,e);

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


        public void drawDefaultDim(string direction, double length, Color color, double ratio, Color textColor)
        {

            if (!DrawInkMethod.defdimenViewModel.DefDimReadOnly)
                return;
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
                    InkCanvas.SetTop(defaultDim, 20 * R.ActualWidth / 1180);
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
                    double left = R.ActualWidth - dimLength - 30 * R.ActualWidth / 1180;
                    InkCanvas.SetLeft(defaultDim, left);
                    double top = R.ActualHeight - dimText.ActualHeight - 20 * R.ActualWidth / 1180;
                    InkCanvas.SetTop(defaultDim, top);
                    break;

            }
            inkDimViewModel.DimPos = direction;
            inkDimViewModel.DimColor = color;
            inkDimViewModel.DimLength = length;
            inkDimViewModel.TextColor = textColor;
         


        }
        private async void inkCanvas_MouseWheel(object sender, MouseWheelEventArgs e)
        {

            ZoomWard = true;
            var isCtrlDown = Keyboard.IsKeyDown(Key.LeftCtrl) || Keyboard.IsKeyDown(Key.RightCtrl); 
            Point curPoint = e.GetPosition(e.Device.Target);
            Matrix matrix = new Matrix();
            if (e.Delta > 0)
            {
                if (isCtrlDown)
                {
                    foreach (InkVisual ink in InkAll)
                    {
                        if (ink != null)
                        {
                            Matrix matrixE = new Matrix();
                            double r1 = ink.ratio1.Ratio * 1.2;
                            if (r1 >= 2.49)
                            {
                                matrixE.ScaleAt(2.49 * 1.2 / r1, 2.49 * 1.2 / r1, curPoint.X, curPoint.Y);
                                ink.ratio1.Ratio = 2.49;
                            }
                            else
                            {
                                matrixE.ScaleAt(1.2, 1.2, curPoint.X, curPoint.Y);
                                ink.ratio1.Ratio = r1;

                            }

                            ink.inkCanvas.Strokes.Transform(matrixE, false);
                            ink.RecTopLeft = ink.RecTopLeft * matrixE;
                            ink.RecBottomRight = ink.RecBottomRight * matrixE;
                            ZoomParTransform(ink.ratio1.Ratio, ink.inkCanvas.Strokes,ink);
                            ink.drawDefaultDim(ink.inkDimViewModel.DimPos, ink.inkDimViewModel.DimLength, ink.inkDimViewModel.DimColor, ink.ratio1.Ratio, ink.inkDimViewModel.TextColor);

                        }
                    }

                };
                if (!isCtrlDown)
                {
                    if (ratio1.Ratio < 2.5)
                    {
                        ratio1.Ratio = ratio1.Ratio * 1.2;

                        if (ratio1.Ratio >= 2.49)
                        {
                            matrix.ScaleAt(2.49 * 1.2 / ratio1.Ratio, 2.49 * 1.2 / ratio1.Ratio, curPoint.X, curPoint.Y);
                            ratio1.Ratio = 2.49;
                        }
                        else
                        {
                            matrix.ScaleAt(1.2, 1.2, curPoint.X, curPoint.Y);
                        }
                        //  ZoomInOut++;

                        inkCanvas.Strokes.Transform(matrix, false);
                        RecTopLeft = RecTopLeft * matrix;
                        RecBottomRight = RecBottomRight * matrix;
                        if (index == DrawInkMethod.ActiveViews.ActiveWin)
                        {
                            DrawInkMethod.StrokesCollection.Clear();
                            FilterStroke(1);
                        }

                        //  RepaintDim();
                        double ratio = ratio1.Ratio;
                        WindowData.GetInstance().updateStatus.Ratio = (int)(Math.Round(ratio, 2) * 100);
                        drawDefaultDim(inkDimViewModel.DimPos, inkDimViewModel.DimLength, inkDimViewModel.DimColor, ratio, inkDimViewModel.TextColor);

                        ZoomParTransform(ratio1.Ratio, inkCanvas.Strokes,this);



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


                }


            }
            else if (e.Delta < 0 && ratio1.Ratio >= 1)
            {
                ratio1.Ratio = ratio1.Ratio / 1.2;

                if (ratio1.Ratio <= 1)
                {
                    matrix.ScaleAt(1 / (ratio1.Ratio * 1.2), 1 / (ratio1.Ratio * 1.2), curPoint.X, curPoint.Y);
                    ratio1.Ratio = 1;
                }
                else
                {
                    matrix.ScaleAt(1 / 1.2, 1 / 1.2, curPoint.X, curPoint.Y);
                }

                //ZoomInOut--;

                inkCanvas.Strokes.Transform(matrix, false);
                RecTopLeft = RecTopLeft * matrix;
                RecBottomRight = RecBottomRight * matrix;
                if (index == DrawInkMethod.ActiveViews.ActiveWin)
                {
                    DrawInkMethod.StrokesCollection.Clear();
                    FilterStroke(1);
                }
                ZoomParTransform(ratio1.Ratio, inkCanvas.Strokes,this);
                double ratio = ratio1.Ratio;
                WindowData.GetInstance().updateStatus.Ratio = (int)(Math.Round(ratio, 2) * 100);

                drawDefaultDim(inkDimViewModel.DimPos, inkDimViewModel.DimLength, inkDimViewModel.DimColor, ratio, inkDimViewModel.TextColor);

                if (isCtrlDown)
                {
                    foreach (InkVisual ink in InkAll)
                    {

                        if (ink != null && ink.index != this.index)
                        {
                            Matrix matrix1 = new Matrix();
                            double r1 = ink.ratio1.Ratio / 1.2;
                            if (r1 <= 1)
                            {
                                matrix1.ScaleAt(1 / (r1 * 1.2), 1 / (r1 * 1.2), curPoint.X, curPoint.Y);
                                ink.ratio1.Ratio = 1;
                            }
                            else
                            {
                                matrix1.ScaleAt(1 / 1.2, 1 / 1.2, curPoint.X, curPoint.Y);
                                ink.ratio1.Ratio = r1;
                            }

                            ink.inkCanvas.Strokes.Transform(matrix1, false);
                            ink.RecBottomRight = ink.RecBottomRight * matrix1;
                            ink.RecTopLeft = ink.RecTopLeft * matrix1;
                            ink.drawDefaultDim(ink.inkDimViewModel.DimPos, ink.inkDimViewModel.DimLength, ink.inkDimViewModel.DimColor, ink.ratio1.Ratio, ink.inkDimViewModel.TextColor);
                            ZoomParTransform(ink.ratio1.Ratio, ink.inkCanvas.Strokes,ink);
                        }

                    }

                }




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
            ZoomWard = false;

        }




        private void MatrixTransform()
        {

            Point beforePoint = new Point(width, height);
            Point point = new Point(R.ActualWidth, R.ActualHeight);
            double wRatio = R.ActualWidth / width;
            double hRatio = R.ActualHeight / height;
            Matrix matrix = new Matrix();
            matrix.ScaleAt(wRatio, hRatio, beforePoint.X / 2, beforePoint.Y / 2);
            inkCanvas.Strokes.Transform(matrix, false);
            // rectangle transform
            RecBottomRight = RecBottomRight * matrix;
            RecTopLeft = RecTopLeft * matrix;

            Matrix matrixMove1 = new Matrix();

            matrixMove1.Translate((R.ActualWidth - width) / 2, (R.ActualHeight - height) / 2);
            inkCanvas.Strokes.Transform(matrixMove1, false);
            RecBottomRight = RecBottomRight * matrixMove1;
            RecTopLeft = RecTopLeft * matrixMove1;

            width = R.ActualWidth;
            height = R.ActualHeight;


        }



        private void inkCanvas_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            // MessageBox.Show("11111");
            if (ActualHeight > 0 && ActualWidth > 0)
            {
                ratio1.actualwidth = ActualWidth;
                MatrixTransform();
                double ratio = ratio1.Ratio;
                drawDefaultDim(inkDimViewModel.DimPos, inkDimViewModel.DimLength, inkDimViewModel.DimColor, ratio, inkDimViewModel.TextColor);
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
                catch (Exception ex)
                {
                    // MessageBox.Show(ex.Message);
                }

            }
        }

        private void inkCanvas_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            // MessageBox.Show(index.ToString());
        }

        private void inkCanvas_SelectionChanged(object sender, EventArgs e)
        {
            if (DimenPreoperty.isForwardTran)
            {
                DimenPreoperty.isReverseTran = false;
                StrokeCollection strokes = inkCanvas.GetSelectedStrokes();
                DimenPreoperty.ListView1.SelectedItems.Clear();
                foreach (Stroke stroke in strokes)
                {
                    foreach (var item in DimenPreoperty.ListView1.Items)
                    {

                        if (stroke.Equals((Stroke)item))
                        {
                            object.Equals(stroke, item);

                            DimenPreoperty.ListView1.SelectedItems.Add(item);

                        }

                    }
                }
                DimenPreoperty.isReverseTran = true;
            }


        }

        private void inkCanvas_LayoutUpdated(object sender, EventArgs e)
        {
            //MessageBox.Show("layout");
        }

        private void inkCanvas_SelectionMoved(object sender, EventArgs e)
        {
            StrokeCollection strokes = inkCanvas.GetSelectedStrokes();
            DrawInkMethod.StrokesCollection.Clear();
            int i = 1;

            FilterStroke(i);
            //FilterStroke1(1, RegisterStroke);
            foreach (Stroke stroke in strokes)
            {
                foreach (var item in DimenPreoperty.ListView1.Items)
                {
                    if (stroke.Equals((Stroke)item))
                    {
                        DimenPreoperty.ListView1.SelectedItems.Add(item);

                    }

                }
            }



        }

        private void inkCanvas_SelectionResized(object sender, EventArgs e)
        {
            StrokeCollection strokes = inkCanvas.GetSelectedStrokes();
            DrawInkMethod.StrokesCollection.Clear();

            FilterStroke(1);
            //FilterStroke1(1, RegisterStroke);
            foreach (Stroke stroke in strokes)
            {
                foreach (var item in DimenPreoperty.ListView1.Items)
                {
                    if (stroke.Equals((Stroke)item))
                    {
                        DimenPreoperty.ListView1.SelectedItems.Add(item);

                    }

                }
            }

        }

        private void inkCanvas_SelectionChanging(object sender, InkCanvasSelectionChangingEventArgs e)
        {


        }

        private void inkCanvas_ActiveEditingModeChanged(object sender, RoutedEventArgs e)
        {

            if (inkCanvas.EditingMode == InkCanvasEditingMode.Select)
            {
                this.inkCanvas.UseCustomCursor = false;
            }
            else
            {
                this.inkCanvas.UseCustomCursor = true;
            }

        }

        private void inkCanvas_EditingModeChanged(object sender, RoutedEventArgs e)
        {
            // MessageBox.Show("EditingModeChanged");
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Global.WindowData1.ImageExportAsPath(sender,e);
        }

        private void inkCanvas_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void inkCanvas_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (DrawInkMethod.ActiveViews.ActiveWin != this.index)
            {
                DrawInkMethod.ActiveViews.ActiveWin = this.index;
                double ratio =  ratio1.Ratio;
                WindowData.GetInstance().updateStatus.Ratio = (int)(Math.Round(ratio, 2) * 100);
                DrawInkMethod.StrokesCollection.Clear();
                FilterStroke(1);
               
            }

        }

        private void inkCanvas_Loaded(object sender, RoutedEventArgs e)
        {
           
            InkAll = WindowData1.GetInstance().inkVisuals;
            
            RecBottomRight.X = this.ActualWidth;
            RecBottomRight.Y = this.ActualHeight;

            RecTopLeft.X = 0;
            RecTopLeft.Y = 0;
            Dispatcher.Invoke(new Action(() =>
            {
                RecBottomRight.X = this.ActualWidth;
                RecBottomRight.Y = this.ActualHeight;
            }), DispatcherPriority.Loaded);

        }


        public void ZoomParTransform(double ratio, StrokeCollection strokes,InkVisual inkVisual)
        {

            if (inkVisual.RecTopLeft.X > 0)
            {
                Matrix matrixMove1 = new Matrix();
                matrixMove1.Translate(-inkVisual.RecTopLeft.X, 0);
                inkVisual.RecTopLeft = inkVisual.RecTopLeft * matrixMove1;
                inkVisual.RecBottomRight = inkVisual.RecBottomRight * matrixMove1;
                strokes.Transform(matrixMove1, false);

            }
            if (inkVisual.RecTopLeft.Y > 0)
            {
                Matrix matrixMove2 = new Matrix();
                matrixMove2.Translate(0, -inkVisual.RecTopLeft.Y);
                inkVisual.RecTopLeft = inkVisual.RecTopLeft * matrixMove2;
                inkVisual.RecBottomRight = inkVisual.RecBottomRight * matrixMove2;
                strokes.Transform(matrixMove2, false);

            }
            if (inkVisual.RecBottomRight.X < inkVisual.ActualWidth)
            {
                Matrix matrixMove3 = new Matrix();
                matrixMove3.Translate(inkVisual.ActualWidth - inkVisual.RecBottomRight.X, 0);
                inkVisual.RecTopLeft = inkVisual.RecTopLeft * matrixMove3;
                inkVisual.RecBottomRight = inkVisual.RecBottomRight * matrixMove3;
                strokes.Transform(matrixMove3, false);

            }
            if (inkVisual.RecBottomRight.Y < inkVisual.ActualHeight)
            {
                Matrix matrixMove4 = new Matrix();
                matrixMove4.Translate(0, inkVisual.ActualHeight - inkVisual.RecBottomRight.Y);
                inkVisual.RecTopLeft = inkVisual.RecTopLeft * matrixMove4;
                inkVisual.RecBottomRight = inkVisual.RecBottomRight * matrixMove4;
                strokes.Transform(matrixMove4, false);

            }

            double Width = inkVisual.RecBottomRight.X - inkVisual.RecTopLeft.X;
            double Height = inkVisual.RecBottomRight.Y - inkVisual.RecTopLeft.Y;

            double x = -(inkVisual.RecTopLeft.X) * 1280 / Width;
            double y = -(inkVisual.RecTopLeft.Y) * 960 / Height;
            int m = (int)x;
            int n = (int)y;
            //double RecWid = 1280 / ratio;
            //double RecHei = 960 / ratio;

            int RecWid = (int)(1280 / ratio);
            int RecHei = (int)(960 / ratio);
            inkVisual.CurrentArray = new int[4] { m, n, RecWid, RecHei };
            if (!Enumerable.SequenceEqual(inkVisual.CurrentArray, inkVisual.lastTempArray))
            {
                //MessageBox.Show(m.ToString() + "," + n.ToString() + "," + RecWid.ToString() + "," + RecHei.ToString());


                Dictionary<string, object> parameters = new Dictionary<string, object>()
                            {
                            { "window",inkVisual.index},
                            { "x",(int)m},
                            {"y",(int)n},
                            {"width",(int)RecWid },
                            {"height",(int)RecHei}
                            };
                LambdaControl.Trigger("IMAGEING_VIEW_MATRIX", null, parameters);
                Array.Copy(inkVisual.CurrentArray, inkVisual.lastTempArray, 4);

            }




        }

        private Point ZoomPar(Point point,InkVisual inkVisual)
        {
            double Width1 = inkVisual.RecBottomRight.X - inkVisual.RecTopLeft.X;
            double Height1 = inkVisual.RecBottomRight.Y - inkVisual.RecTopLeft.Y;
            Matrix matrix = new Matrix();
            matrix.Translate(-inkVisual.RecTopLeft.X, -inkVisual.RecTopLeft.Y);
            matrix.Scale(1280 / Width1, 960 / Height1);
            inkVisual.InverseMatrix = matrix;
            inkVisual.InverseMatrix.Invert();
            point = point * matrix;
            return point;
        }
        private Point DimZoomPar(Point point, InkVisual inkVisual)
        {
            double Width1 = inkVisual.ActualWidth;
            double Height1 = inkVisual.ActualHeight;
            double ratio = inkVisual.ratio1.Ratio;
            Matrix matrix = new Matrix();
            matrix.Scale(1280 / (Width1*ratio), 960 /(Height1 * ratio));
            inkVisual.InverseMatrixDim = matrix;
            inkVisual.InverseMatrix.Invert();
            point = point * matrix;
            return point;
        }
        private List<Point> ZoomParList(List<Point> points,InkVisual inkVisual)
        {
            for (int i = 0; i < points.Count; i++)
            {

                points[i] = ZoomPar(points[i], inkVisual);
            }

            return points;
        }
        private List<Point> DimZoomParList(List<Point> points, InkVisual inkVisual)
        {

            for (int i = 0; i < points.Count; i++)
            {

                points[i] = DimZoomPar(points[i], inkVisual);
            }

            return points;
        }

        private List<Point> ZoomInverseParList(List<Point> points, InkVisual inkVisual)
        {
            for (int i = 0; i < points.Count; i++)
            {

                points[i] = points[i] * inkVisual.InverseMatrix;
            }

            return points;
        }

        private List<Point> DimZoomInverseParList(List<Point> points, InkVisual inkVisual)
        {
            for (int i = 0; i < points.Count; i++)
            {

                points[i] = points[i] * inkVisual.InverseMatrixDim;
            }

            return points;
        }
        private Point ZoomInversePar(Point point,InkVisual inkVisual)
        {
           point = point* inkVisual.InverseMatrix;

            return point;
        }

       

        private void StrokeTransforChange(int i, ObservableCollection<VisualAttritube> drawVisuals,InkVisual inkVisual)
        {


            drawVisuals.Clear();
            VisualAttritube view = new VisualAttritube();
            view.Type = "Window";
            view.winProperty.ActiveWin = this.index;
            view.winProperty.ratio = this.ratio1.Ratio;
            view.winProperty.acWidth = this.ActualWidth;
            view.winProperty.acHeight = this.ActualHeight;

            if (defaultDim.Visibility == Visibility.Visible)
            {
                DimTrans(view, view.PointList);
                view.PointList = DimZoomParList(view.PointList, inkVisual);

            }

           drawVisuals.Add(view);


            foreach (CustomStroke item in DrawInkMethod.StrokesCollection)
            {
                VisualAttritube visualAttritube = new VisualAttritube();
               
                if (item is CustomTextInput textInput)
                {
                    visualAttritube.TexT.TextColor = textInput.textColor;
                    visualAttritube.TexT.Bold = textInput.Bold;
                    visualAttritube.TexT.FontFamily = textInput.FontFamily.ToString();
                    visualAttritube.TexT.Italic = textInput.Italic;
                    visualAttritube.TexT.Fontsize = textInput.Fontsize;
                    visualAttritube.TexT.UnderLine = textInput.UnderLine;
                    visualAttritube.TexT.Content = textInput.customTextInput.Text;

                };
                if (item.Type1 =="DimA" || item.Type1 == "DimB"|| item.Type1 == "DimC"|| item.Type1 == "DimD")
                {

                    visualAttritube.TexT.TextColor = item.textColor;
                    visualAttritube.TexT.ShowText = item.showLabel;
                    visualAttritube.TexT.TextPos = item.LabPos;
                    visualAttritube.TexT.FontFamily = item.FontFamily.ToString();
                    visualAttritube.TexT.UnderLine = item.UnderLine;
                    visualAttritube.TexT.Italic = item.Italic;
                    visualAttritube.TexT.Bold = item.Bold;
                    visualAttritube.TexT.Fontsize = item.Fontsize;
                    visualAttritube.TexT.Point1 = item.Point1;
                    visualAttritube.TexT.Content = item.Content;

                }
                visualAttritube = VisualTransferChange(visualAttritube, item,inkVisual);
                drawVisuals.Add(visualAttritube);

            }
            string JSON = JsonSerializer.Serialize(drawVisuals, new JsonSerializerOptions());
            LambdaControl.Trigger("DRAWING_VISUAL", this, JSON);
            //drawVisualsCopy = JsonSerializer.Deserialize<List<VisualAttritube>>(JSON);
            foreach (CustomStroke item in DrawInkMethod.StrokesCollection)
            {
                ZoomInverseParList(item.PointList,inkVisual);
                ZoomInversePar(item.Point1, inkVisual);
            }
            // dim inverse
            DimZoomInverseParList(view.PointList, inkVisual);


        }


        private VisualAttritube VisualTransferChange(VisualAttritube visual, CustomStroke customStroke,InkVisual inkVisual)
        {

            visual.Color = customStroke.ColorBru;
            visual.LineWidth = customStroke.LineWidth;
            visual.LineType = customStroke.Dash;
            visual.Type = customStroke.Type1;
            visual.PointList = ZoomParList(customStroke.PointList, inkVisual);
            visual.TexT.Point1 = ZoomPar(customStroke.Point1, inkVisual);
            return visual;

        }

        private List<Point> DimTrans(VisualAttritube view,List<Point> pointList)
        {
            pointList.Clear();
            view.Color = inkDimViewModel.DimColor;
            view.TexT.TextColor = inkDimViewModel.TextColor;
            view.TexT.TextPos = inkDimViewModel.DimPos;

            view.TexT.ShowText = true;
            view.TexT.Point1 = new Point(inkDimViewModel.DimLength, 0);
            pathGeometry.ToString();
            GeneralTransform generalTransform1 = defaultDim.TransformToVisual(this);
            Point dimPoint = generalTransform1.Transform(new Point(0, 0));

            Point point0 = new Point(pathGeometry.Bounds.X, pathGeometry.Bounds.Y);
            double width = pathGeometry.Bounds.Width;
            double height = pathGeometry.Bounds.Height;

            Point point1 = new Point(dimPoint.X + point0.X, dimPoint.Y + point0.Y);

            Point point2 = new Point(dimPoint.X + point0.X, dimPoint.Y + point0.Y + height);

            Point point3 = new Point(dimPoint.X + point0.X + width, dimPoint.Y + point0.Y + height);

            Point point4 = new Point(dimPoint.X + point0.X + width, dimPoint.Y + point0.Y);
            pointList.Add(point1);

            pointList.Add(point2);
            pointList.Add(point3);
            pointList.Add(point4);
            return pointList;

        }

        private void RadioMenuItem_Checked(object sender, RoutedEventArgs e)
        {

        }




    }
}


