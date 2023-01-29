using Global.UserControls.DrawVisual;
using Lambda;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using System.Windows.Threading;

namespace Global
{
    public class GalleryInk
    {

        public GalleryInk()
        {


        }

        public static void GalleryInking()
        {
           // addInjection();
            addEvent();
        }
        static  Window mainwin = Application.Current.MainWindow;

        static List<VisualAttritube> InkBack = new List<VisualAttritube>();
       
      

        // public ObservableCollection<VisualAttritube> drawVisuals = new ObservableCollection<VisualAttritube>();
        private static void addEvent()
        {

        LambdaControl.AddLambdaEventHandler("GALLERY_INK_BACK", InkBackDeserialize, false);
           
        }

        private static bool InkBackDeserialize(object sender, EventArgs e)
        {
            Dictionary<string, object>? eventData = LambdaArgs.GetEventData(e);
            if (eventData == null)
                return false;
            object inkStack = null;
            eventData.TryGetValue("GALLERY_INK", out inkStack);
            if (inkStack != null)
            {
                if ((string)inkStack == "null")
                {
                    InkBack.Clear();
                }
                else
                {
                    InkBack = JsonSerializer.Deserialize<List<VisualAttritube>>((string)inkStack);
                    for (int i = 1; i < InkBack.Count; i++)
                    {
                        InkBack[i].PointList = ZoomParList(InkBack[i].PointList);
                    }
                }
                
            }
            // 绘图跟随图像 预留 回显

            //if (WindowData.GetInstance().SolutionConfig.OtherMode.InkMode == 0)
            //{
            //    Application.Current.Dispatcher.Invoke(delegate
            //    { InkEcho(); });

            //}

            return true;
        }

        public static async void VisualsDrawBack(string jsonNodes, InkVisual[] inks)
        {
            await Task.Delay(500);
            List<WindowVisual> visuals = JsonSerializer.Deserialize<List<WindowVisual>>(jsonNodes);
            Global.GalleryInk.ListInkDrawBack(visuals, inks);

  
        }









        public static void ListInkDrawBack(List<WindowVisual> visuals, InkVisual[] inks)
        {

            for (int i = 0; i < visuals.Count; i++)
            {
                if(visuals[i] != null)
                {
                    InkDrawBack(visuals[i], inks[i]);
                }

            }

        }
        public static async void InkDrawBack(WindowVisual windowVisual, InkVisual ink)
        {

           
            if (ink != null && ink.index == windowVisual.Window)
                {
                  await Task.Delay(100);
                   ink.ratio1.Ratio = 1;
                   ink.inkcanva.Strokes.Clear();
                    foreach (VisualAttritube visual in windowVisual.VisualsList)
                    {
                        visual.PointList = ZoomParList1(visual.PointList,windowVisual.AcWidth, windowVisual.AcHeight);
                        CustomStroke stroke = ReDrawVisual(visual);
                        if (stroke != null)
                        {
                        ink.inkcanva.Strokes.Add(stroke);
                        }

                    }
                }
           
        }



        private static void InkEcho()
        {
            
            DrawInkMethod.InkAll[DrawInkMethod.ActiveViews.ActiveWin].inkcanva.Strokes.Clear();
           // double ratio = DrawInkMethod.InkAll[0].ratio1.Ratio;
            DrawInkMethod.InkAll[DrawInkMethod.ActiveViews.ActiveWin].ratio1.Ratio = 1;
            foreach (VisualAttritube item in InkBack)
            {
                CustomStroke stroke = ReDrawVisual(item);
                if (stroke != null)
                {
                    DrawInkMethod.InkAll[DrawInkMethod.ActiveViews.ActiveWin].inkcanva.Strokes.Add(stroke);
                } 

            }

        }



        private static CustomStroke ReDrawVisual(VisualAttritube visual)
        {
            
                if (visual.Type == "DimA" || visual.Type == "DimB" || visual.Type == "DimC"|| visual.Type == "DimD"|| visual.Type == "Ruler"||visual.Type =="Line"||visual.Type == "Arrow")
                {

                    RatioClass ratioClass = new RatioClass() { Ratio = 1,actualwidth = DrawInkMethod.InkAll[0].inkcanva.ActualWidth };
                    FontFamily fontFamily = new FontFamily(visual.TexT.FontFamily);   
                    CustomStroke stroke = ReCreateDim(visual.Type, visual.PointList, visual.Color, ratioClass,visual.TexT.TextColor,visual.TexT.ShowText, visual.LineWidth,visual.LineType,visual.TexT.Italic,visual.TexT.Bold,visual.TexT.UnderLine,visual.TexT.Fontsize, fontFamily,visual.TexT.TextPos);
                    return stroke;
                }

                else
                {
                    CustomStroke stroke = ReCreateStroke(visual.Type, visual.PointList, visual.Color, visual.LineWidth, visual.LineType);
                    return stroke;
                }

            
        }
         
         






        private static CustomStroke ReCreateStroke(string type, List<Point> pointList, Color color, int LineWidth, int dash)
        {
            CustomStroke stroke1;
            switch (type)
            {

                case "Ellipse":
                    stroke1 = DrawInkMethod.InkCanvasMethod.CreateEllipse(pointList[0], pointList[1], color, LineWidth, dash);
                    return stroke1;

                case "Circle":
                    stroke1 = DrawInkMethod.InkCanvasMethod.CreateCircle(pointList[0], pointList[1], color, LineWidth, dash);
                    return stroke1;
                case "Polygon":
                    stroke1 = DrawInkMethod.InkCanvasMethod.CreatePolygon(pointList, color, LineWidth, dash);
                    return stroke1;
                case "Square":
                    stroke1 = DrawInkMethod.InkCanvasMethod.CreateSquare(pointList[0], pointList[1], color, LineWidth, dash);
                    return stroke1;
                case "Curve":
                    stroke1 = DrawInkMethod.InkCanvasMethod.CreatePolyBezier(pointList, color, LineWidth, dash);
                    return stroke1;
                //case "Curve1":
                //    stroke1 = DrawInkMethod.InkCanvasMethod.CreateQuadraticBesizer(pointList, color, LineWidth, dash);
                //    return stroke1;
                case "Rectangle":
                    stroke1 = DrawInkMethod.InkCanvasMethod.CreateRectangleStroke(pointList[0], pointList[1], color, LineWidth, dash);
                    return stroke1;
                

            }

            return null;
        }


        private static CustomStroke ReCreateDim(string type, List<Point> pointList, Color color, RatioClass ratio, Color textColor, bool showLabel, int lineWidth, int dash, bool italic, bool bold, bool underLine, int fonSize, FontFamily fontFamily, string labpos)
        {
            CustomStroke stroke1;
            switch (type)
            {



                case "DimA":
                    stroke1 = DrawInkMethod.InkCanvasMethod.CreateDim1Stroke(pointList[0], pointList[3], color, ratio, textColor, showLabel, lineWidth, dash, italic, bold, underLine, fonSize, fontFamily, labpos);
                    return stroke1;

                case "DimB":
                    stroke1 = DrawInkMethod.InkCanvasMethod.CreateDim2Stroke(pointList[0], pointList[4], color, ratio, textColor, showLabel, lineWidth, dash, italic, bold, underLine, fonSize, fontFamily, labpos);
                    return stroke1;
                case "DimC":
                    stroke1 = DrawInkMethod.InkCanvasMethod.CreateDim3Stroke(pointList[0], pointList[8], color, ratio, textColor, showLabel, lineWidth, dash, italic, bold, underLine, fonSize, fontFamily, labpos);
                    return stroke1;
                case "DimD":
                    stroke1 = DrawInkMethod.InkCanvasMethod.CreateDim4Stroke(pointList[0], pointList[8], color, ratio, textColor, showLabel, lineWidth, dash, italic, bold, underLine, fonSize, fontFamily, labpos);
                    return stroke1;
                case "Ruler":
                    stroke1 = DrawInkMethod.InkCanvasMethod.CreateRuler(pointList, color, ratio, textColor, lineWidth, dash, italic, bold, fonSize, fontFamily);
                    return stroke1;
                case "Line":
                    stroke1 = DrawInkMethod.InkCanvasMethod.CreateLineStroke(pointList[0], pointList[1], color, ratio, textColor, showLabel, lineWidth, dash, italic, bold, underLine, fonSize, fontFamily, labpos);
                    return stroke1;
                case "Arrow":
                    stroke1 = DrawInkMethod.InkCanvasMethod.CreateArrowStroke(pointList[0], pointList[1], color, ratio, textColor, showLabel, lineWidth, dash, italic, bold, underLine, fonSize, fontFamily, labpos);
                    return stroke1;

            }

            return null;
        }


       
        private static Point ZoomPar(Point point)
        {
            double Width1 = DrawInkMethod.InkAll[0].ActualWidth;
            double Height1 = DrawInkMethod.InkAll[0].ActualHeight;
            Matrix matrix = new Matrix();
            matrix.Scale(Width1 /1280 ,  Height1/ 960);
            point = point * matrix;
            return point;
        }

        private static  List<Point> ZoomParList(List<Point> points)
        {
            for (int i = 0; i < points.Count; i++)
            {

                points[i] = ZoomPar(points[i]);
            }

            return points;
        }
        private static Point ZoomPar1(Point point,double width,double height)
        {
            double Width1 = DrawInkMethod.InkAll[0].ActualWidth;
            double Height1 = DrawInkMethod.InkAll[0].ActualHeight;
            Matrix matrix = new Matrix();
            matrix.Scale(Width1 / width, Height1 / height);
            point = point * matrix;
            return point;
        }
        private static List<Point> ZoomParList1(List<Point> points,double width,double height)
        {
            for (int i = 0; i < points.Count; i++)
            {

                points[i] = ZoomPar1(points[i],width,height);
            }

            return points;
        }




    }
}
