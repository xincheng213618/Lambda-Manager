using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Global;
using Lambda;

namespace Global.UserControls.DrawVisual
{
    /// <summary>
    /// DimenPreoperty.xaml 的交互逻辑
    /// </summary>
    public partial class DimenPreoperty : UserControl
    {
        public DimenPreoperty()
        {
            InitializeComponent();
            ListView1 = listview;
        }
        //InkCanvas ink;
        public static ListView ListView1 { get; set; }
        public static bool isReverseTran = true;
        public static bool isForwardTran = true;
        private StrokeCollection StrokeCollect= new StrokeCollection();
        private StrokeCollection TextStrokeCollect = new StrokeCollection();
        private bool isReadOnly = false;
        private List<CustomStroke> geometryList = new List<CustomStroke>();
        private List<CustomStroke> textList = new List<CustomStroke>();
        private List<CustomStroke> dimGeometryList = new List<CustomStroke>();
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
            if (ShapeCombo.SelectedIndex ==2|| ShapeCombo.SelectedIndex == 3||ShapeCombo.SelectedIndex ==4||ShapeCombo.SelectedIndex == 5)
            {   if (dimWrap.Visibility == Visibility.Visible)
                {
                    return;
                }
               // labelWrap.Visibility = Visibility.Visible;
                DrawInkMethod.dimenViewModel.LabelPosShow = true;
                labelCheck.IsChecked = true;
            }
            else
            {
                labelCheck.IsChecked = false;
                DrawInkMethod.dimenViewModel.LabelPosShow = true;
              //  labelWrap.Visibility = Visibility.Collapsed;
            }
            if (!isReadOnly)
            {

                ReDrawVisual(DrawInkMethod.InkAll[DrawInkMethod.ActiveViews.ActiveWin].inkCanvas, DrawInkMethod.dimenViewModel.SelectedAccentColor, DrawInkMethod.dimenViewModel.LineWidth, DrawInkMethod.dimenViewModel.DashSelectedIndex);
            }



        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void listview_Loaded(object sender, RoutedEventArgs e)
        {
           
        }

        private void _colorPicker_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (expander.IsExpanded == false)
            {
                expander.IsExpanded = true;
            }
        }
        StrokeCollection strokes = new StrokeCollection();
       
        private void listview_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
            strokes.Clear();
            if (isReverseTran)
            {
                isForwardTran = false;
                if (sender is ListView listView)
                {
                    if (listview.SelectedItems.Count == 0)
                    {
                    };

                    if (listview.SelectedItems.Count == 1)
                    {
                        Stroke selectedStroke = (Stroke)listview.SelectedItem;
                        foreach (Stroke stroke in DrawInkMethod.StrokesCollection)
                        {

                            if (stroke.Equals(selectedStroke))
                            {
                                strokes.Add(stroke);
                            }

                        }
                        WindowData1.GetInstance().ImageViewState.toolTop.InkSelected = true;
                    }
                    else if (listview.SelectedItems.Count > 1)
                    {
                        foreach (var item in listview.SelectedItems)
                        {
                            foreach (Stroke stroke in DrawInkMethod.StrokesCollection)
                            {

                                if (stroke.Equals((Stroke)item))
                                {
                                    strokes.Add(stroke);

                                }

                            }
                        }

                        if(listview.SelectedItems.Count == DrawInkMethod.StrokesCollection.Count)
                        {
                            WindowData1.GetInstance().ImageViewState.toolTop.InkAllSelected = true;
                        }
                        else
                        {
                            WindowData1.GetInstance().ImageViewState.toolTop.InkSelected = true;
                        }

                    }

                }


                DrawInkMethod.InkAll[DrawInkMethod.ActiveViews.ActiveWin].inkCanvas.Select(strokes);
                //DrawInkMethod.ActiveInk.Select(strokes);
                isForwardTran = true;
            }
            isReadOnly = true;
            ReReadStroke(DrawInkMethod.InkAll[DrawInkMethod.ActiveViews.ActiveWin].inkCanvas);


            isReadOnly = false;
        }

        private void ReDrawVisual( InkCanvas ink1,Color color,int lineWidth, int dash)
        {
            StrokeCollect.Clear();
            StrokeCollection strokes2 = ink1.GetSelectedStrokes();

            foreach (CustomStroke stroke in strokes2)
            {
                Stroke stroke1;

                if (stroke is DrawInkMethod.Dim1Stroke || stroke is DrawInkMethod.Dim2Stroke || stroke is DrawInkMethod.Dim3Stroke || stroke is DrawInkMethod.Dim4Stroke || stroke is DrawInkMethod.LineStroke || stroke is DrawInkMethod.ArrowStroke)
                {
                    stroke1 = ReCreateDim(stroke, color, stroke.ratio, stroke.textColor, stroke.showLabel, lineWidth, dash, DrawInkMethod.dimenViewModel.Italic, DrawInkMethod.dimenViewModel.Bold, DrawInkMethod.dimenViewModel.UnderLine, DrawInkMethod.dimenViewModel.FontSize, DrawInkMethod.dimenViewModel.FontFam, DrawInkMethod.dimenViewModel.LabelPos);

                }
                else
                {
                    stroke1 = ReCreateStroke(stroke, color, lineWidth, dash);
                }

                ink1.Strokes.Insert(stroke.Index-1, stroke1);
                ink1.Strokes.Remove(stroke);
                StrokeCollect.Add(stroke1);
               
            }
            if (StrokeCollect.Count != 0)
            {
              
                ink1.Select(StrokeCollect);

            }


        }
        private void ReWriteText(InkCanvas ink2, Color color,Color textColor, bool italic, bool bold, bool underLine, int fonSize, FontFamily fontFamily)
        {
            TextStrokeCollect.Clear();
            StrokeCollect.Clear();
            StrokeCollection strokes3 = ink2.GetSelectedStrokes();
            
            foreach (CustomStroke stroke in strokes3)
            {
                if (stroke is DrawInkMethod.CustomTextInput textInput)
                {
                    System.Windows.FontStyle fontStyle = new System.Windows.FontStyle();
                    FontWeight fontWeight = new FontWeight();
                    FontStretch fontStretch = new FontStretch();
                    if (italic) fontStyle = FontStyles.Italic;
                    if (bold) fontWeight = FontWeights.Bold;
                    Brush brush = new SolidColorBrush(textColor);
                    FormattedText text = new FormattedText(stroke.customTextInput.Text, CultureInfo.CurrentCulture,
                            FlowDirection.LeftToRight, new Typeface(DrawInkMethod.dimenViewModel.FontFam, fontStyle, fontWeight, fontStretch), fonSize, brush, 1.25);
                    double width = text.Width;
                    double height = text.Height;
                    Point point = new Point(stroke.StylusPoints[0].X, stroke.StylusPoints[0].Y);
                    CustomStroke stroke1 = DrawInkMethod.InkCanvasMethod.ReCustomTextInput(point, height, width, text, textColor, italic, bold, underLine, fonSize, fontFamily);
                    ink2.Strokes.Insert(stroke.Index - 1, stroke1);
                    ink2.Strokes.Remove(stroke);
                    listview.SelectedItems.Add(stroke1);
                    TextStrokeCollect.Add(stroke1);
                }
                else if (stroke is DrawInkMethod.Dim1Stroke || stroke is DrawInkMethod.Dim2Stroke || stroke is DrawInkMethod.Dim3Stroke || stroke is DrawInkMethod.Dim4Stroke)
                {
                    int lineWidth = DrawInkMethod.dimenViewModel.LineWidth;
                    int dash = DrawInkMethod.dimenViewModel.DashSelectedIndex;
                    
                    CustomStroke stroke2 = ReCreateDim(stroke, color, stroke.ratio, textColor, stroke.showLabel, lineWidth, dash, DrawInkMethod.dimenViewModel.Italic, DrawInkMethod.dimenViewModel.Bold, DrawInkMethod.dimenViewModel.UnderLine, DrawInkMethod.dimenViewModel.FontSize, DrawInkMethod.dimenViewModel.FontFam, DrawInkMethod.dimenViewModel.LabelPos);
                    ink2.Strokes.Insert(stroke.Index - 1, stroke2);
                 
                    ink2.Strokes.Remove(stroke);
                    StrokeCollect.Add(stroke2);
                }
               


            }
            if (TextStrokeCollect.Count > 0)
            {
               
               ink2.Select(TextStrokeCollect);

               
            };
            if (StrokeCollect.Count > 0)
            {
                
               ink2.Select(StrokeCollect);

            }


        }

        private void ReReadStroke(InkCanvas ink1)
        {
            StrokeCollect.Clear();
            StrokeCollection strokes2 = ink1.GetSelectedStrokes();
            textList.Clear();
            geometryList.Clear();
            dimGeometryList.Clear();


            foreach (CustomStroke stroke in strokes2)
            {
                ParReadBack(stroke);
            }
             
            FilterDistinct(geometryList, textList, dimGeometryList);
        }


        private void FilterDistinct(List<CustomStroke> geometryList, List<CustomStroke> textList, List<CustomStroke> dimGeometryList )
        {
            
        
            // text 
            bool isTextColorDif = textList.Select(g => g.textColor).Distinct().Count() > 1;
            if (isTextColorDif)
            {
                DrawInkMethod.dimenViewModel.TextSelectedAccentColor = Colors.Transparent;
            }
            bool isTextFamDif = textList.Select(g => g.FontFamily).Distinct().Count() > 1;
            if (isTextFamDif)
            {
                DrawInkMethod.dimenViewModel.FontFam = new FontFamily("Arial"); ;
            }
            bool isTextSizeDif = textList.Select(g => g.textColor).Distinct().Count() > 1;
            if (isTextSizeDif)
            {
                DrawInkMethod.dimenViewModel.FontSize = 16; 
            }
            bool isTextBoldDif = textList.Select(g => g.Bold).Distinct().Count() > 1;
            if (isTextBoldDif)
            {
                DrawInkMethod.dimenViewModel.Bold = false;
            }
            bool isTextItaDif = textList.Select(g => g.Italic).Distinct().Count() > 1;
            if (isTextItaDif)
            {
                DrawInkMethod.dimenViewModel.Italic = false;
            }
            bool isTextUnderDif = textList.Select(g => g.UnderLine).Distinct().Count() > 1;
            if (isTextUnderDif)
            {
                DrawInkMethod.dimenViewModel.UnderLine = false;
            }

            // dim and line
            bool islengthDif = dimGeometryList.Select(g => g.length).Distinct().Count() > 1;
            if (islengthDif)
            {
                DrawInkMethod.dimenViewModel.Length = 0;
            }
            bool isAngleDif = dimGeometryList.Select(g => g.angle).Distinct().Count() > 1;
            if (isAngleDif)
            {
                DrawInkMethod.dimenViewModel.Angle = 0;
            }
            bool isDimSelDif = dimGeometryList.Select(g => g.dimSelectIndex).Distinct().Count() > 1;
            if (isDimSelDif)
            {
                DrawInkMethod.dimenViewModel.DimSelectedIndex = 0;
            }

            // geometry
            bool isGeoLineWDif = geometryList.Select(g => g.LineWidth).Distinct().Count() > 1;
            if (isGeoLineWDif)
            {
                DrawInkMethod.dimenViewModel.LineWidth = 2;
            }
            bool isGeoLineDDif = geometryList.Select(g => g.Dash).Distinct().Count() > 1;
            if (isGeoLineDDif)
            {
                DrawInkMethod.dimenViewModel.DashSelectedIndex = 0;
            }
            bool isGeoColorDDif = geometryList.Select(g => g.ColorBru).Distinct().Count() > 1;
            if (isGeoColorDDif)
            {
                DrawInkMethod.dimenViewModel.SelectedAccentColor = Colors.Transparent;
            }
          
        }








        private CustomStroke ReCreateStroke(CustomStroke cusStroke,Color color, int LineWidth, int dash)
        {
            return cusStroke.Type switch
            {
                "椭圆" => DrawInkMethod.InkCanvasMethod.ReCreateEllipse(cusStroke.StylusPoints, color, LineWidth, dash),
                "圆" => DrawInkMethod.InkCanvasMethod.ReCreateCircle(cusStroke.StylusPoints, color, LineWidth, dash),
                "多边形" => DrawInkMethod.InkCanvasMethod.ReCreatePolygon(cusStroke.StylusPoints, color, LineWidth, dash),
                "正方形" => DrawInkMethod.InkCanvasMethod.ReCreateSquare(cusStroke.StylusPoints, color, LineWidth, dash),
               //"曲线" => DrawInkMethod.InkCanvasMethod.ReCreateBesizer(cusStroke.StylusPoints, color, LineWidth, dash),
               // "曲线1" => DrawInkMethod.InkCanvasMethod.ReCreateQuadraticBesizer(cusStroke.StylusPoints, color, LineWidth, dash),
                "矩形" => DrawInkMethod.InkCanvasMethod.ReCreateRectangle(cusStroke.StylusPoints, color, LineWidth, dash),
                "曲线" => DrawInkMethod.InkCanvasMethod.ReCreatePolyBezier(cusStroke.StylusPoints, color, LineWidth, dash),
                _ => null
            } ;
        }

        private CustomStroke ReCreateDim(CustomStroke cusStroke, Color color, RatioClass ratio, Color textColor, bool showLabel, int lineWidth, int dash,bool italic, bool bold, bool underLine, int fonSize, FontFamily fontFamily,string labpos)
        {
            return cusStroke.Type switch
            {
                "标尺 A" => DrawInkMethod.InkCanvasMethod.ReCreateDim1(cusStroke.StylusPoints, color, ratio, textColor, showLabel, lineWidth, dash, italic, bold, underLine, fonSize, fontFamily, labpos),
                "标尺 B" => DrawInkMethod.InkCanvasMethod.ReCreateDim2(cusStroke.StylusPoints, color, ratio, textColor, showLabel, lineWidth, dash, italic, bold, underLine, fonSize, fontFamily, labpos),
                "标尺 C" => DrawInkMethod.InkCanvasMethod.ReCreateDim3(cusStroke.StylusPoints, color, ratio, textColor, showLabel, lineWidth, dash, italic, bold, underLine, fonSize, fontFamily, labpos),
                "标尺 D" => DrawInkMethod.InkCanvasMethod.ReCreateDim4(cusStroke.StylusPoints, color, ratio, textColor, showLabel, lineWidth, dash, italic, bold, underLine, fonSize, fontFamily, labpos),
                "直线" => DrawInkMethod.InkCanvasMethod.ReCreateLine(cusStroke.StylusPoints, color, ratio, textColor, showLabel, lineWidth, dash, italic, bold, underLine, fonSize, fontFamily, labpos),
                "箭头" => DrawInkMethod.InkCanvasMethod.ReCreateArrow(cusStroke.StylusPoints, color, ratio, textColor, showLabel, lineWidth, dash, italic, bold, underLine, fonSize, fontFamily, labpos),
            _ => null
            };
        }









        private void ParReadBack(CustomStroke stroke)
        {
           
            if (stroke is DrawInkMethod.CustomTextInput textInput)
            {
                TextReadBack(stroke);
                textList.Add(stroke);
            }
            else
            {
                DrawInkMethod.dimenViewModel.LineWidth = stroke.LineWidth;
                DrawInkMethod.dimenViewModel.DashSelectedIndex = stroke.Dash;
                DrawInkMethod.dimenViewModel.SelectedAccentColor = stroke.ColorBru;

               if (stroke is DrawInkMethod.Dim1Stroke || stroke is DrawInkMethod.Dim2Stroke || stroke is DrawInkMethod.Dim3Stroke || stroke is DrawInkMethod.Dim4Stroke)
                {
                    TextReadBack(stroke);
                    DimOnlyReadBack(stroke);
                    textList.Add(stroke);
                    dimGeometryList.Add(stroke);
                }
               if (stroke is DrawInkMethod.LineStroke || stroke is DrawInkMethod.ArrowStroke)
                {
                    DimOnlyReadBack(stroke);
                    dimGeometryList.Add(stroke);
                }

                geometryList.Add(stroke);
            }
           

        }

        private void DimOnlyReadBack(CustomStroke stroke)
        {

            DrawInkMethod.dimenViewModel.Length = stroke.length;
            DrawInkMethod.dimenViewModel.Angle = stroke.angle;
            DrawInkMethod.dimenViewModel.DimSelectedIndex = stroke.dimSelectIndex;

        }




        private void TextReadBack(CustomStroke stroke)
        {
          
            DrawInkMethod.dimenViewModel.TextSelectedAccentColor = stroke.textColor;
            DrawInkMethod.dimenViewModel.FontFam = stroke.FontFamily;
            DrawInkMethod.dimenViewModel.FontSize = stroke.Fontsize;
            DrawInkMethod.dimenViewModel.Bold = stroke.Bold;
            DrawInkMethod.dimenViewModel.Italic = stroke.Italic;
            DrawInkMethod.dimenViewModel.UnderLine = stroke.UnderLine;

        }


        private void LineShapeCombo_Loaded(object sender, RoutedEventArgs e)
        {
            LineWidthUpdown.ValueChanged += (s, e) =>
            {
                if (!isReadOnly)
                    ReDrawVisual(DrawInkMethod.ActiveInk, DrawInkMethod.dimenViewModel.SelectedAccentColor, DrawInkMethod.dimenViewModel.LineWidth, DrawInkMethod.dimenViewModel.DashSelectedIndex);

            };

        }

        private void _colorPicker_SelectedColorChanged(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            if (!isReadOnly)
                ReDrawVisual(DrawInkMethod.ActiveInk, DrawInkMethod.dimenViewModel.SelectedAccentColor, DrawInkMethod.dimenViewModel.LineWidth, DrawInkMethod.dimenViewModel.DashSelectedIndex);

        }



        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            listview.ItemsSource = DrawInkMethod.StrokesCollection;
            DrawInkMethod.StrokesCollection.CollectionChanged += delegate
            {
                objectManageGrid.Visibility = DrawInkMethod.StrokesCollection.Count > 0 ?Visibility.Visible :Visibility.Collapsed;
            };

        }

        private void ColorPicker_SelectedColorChanged(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            if (!isReadOnly)
            {
                ReWriteText(DrawInkMethod.InkAll[DrawInkMethod.ActiveViews.ActiveWin].inkCanvas, DrawInkMethod.dimenViewModel.SelectedAccentColor, DrawInkMethod.dimenViewModel.TextSelectedAccentColor, DrawInkMethod.dimenViewModel.Italic, DrawInkMethod.dimenViewModel.Bold, DrawInkMethod.dimenViewModel.UnderLine, DrawInkMethod.dimenViewModel.FontSize, DrawInkMethod.dimenViewModel.FontFam);
            }
        }

        private void FontFamilyCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!isReadOnly)
            {
                ReWriteText(DrawInkMethod.InkAll[DrawInkMethod.ActiveViews.ActiveWin].inkCanvas, DrawInkMethod.dimenViewModel.SelectedAccentColor, DrawInkMethod.dimenViewModel.TextSelectedAccentColor, DrawInkMethod.dimenViewModel.Italic, DrawInkMethod.dimenViewModel.Bold, DrawInkMethod.dimenViewModel.UnderLine, DrawInkMethod.dimenViewModel.FontSize, DrawInkMethod.dimenViewModel.FontFam);
            }
        }

        private void FontSizeComb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!isReadOnly)
            {
                ReWriteText(DrawInkMethod.InkAll[DrawInkMethod.ActiveViews.ActiveWin].inkCanvas, DrawInkMethod.dimenViewModel.SelectedAccentColor, DrawInkMethod.dimenViewModel.TextSelectedAccentColor, DrawInkMethod.dimenViewModel.Italic, DrawInkMethod.dimenViewModel.Bold, DrawInkMethod.dimenViewModel.UnderLine, DrawInkMethod.dimenViewModel.FontSize, DrawInkMethod.dimenViewModel.FontFam);
            }
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            if (!isReadOnly)
            {
                ReWriteText(DrawInkMethod.InkAll[DrawInkMethod.ActiveViews.ActiveWin].inkCanvas, DrawInkMethod.dimenViewModel.SelectedAccentColor, DrawInkMethod.dimenViewModel.TextSelectedAccentColor, DrawInkMethod.dimenViewModel.Italic, DrawInkMethod.dimenViewModel.Bold, DrawInkMethod.dimenViewModel.UnderLine, DrawInkMethod.dimenViewModel.FontSize, DrawInkMethod.dimenViewModel.FontFam);
            }
        }

        private void CheckBox_Click_1(object sender, RoutedEventArgs e)
        {
            if (!isReadOnly)
            {

                ReWriteText(DrawInkMethod.InkAll[DrawInkMethod.ActiveViews.ActiveWin].inkCanvas, DrawInkMethod.dimenViewModel.SelectedAccentColor, DrawInkMethod.dimenViewModel.TextSelectedAccentColor, DrawInkMethod.dimenViewModel.Italic, DrawInkMethod.dimenViewModel.Bold, DrawInkMethod.dimenViewModel.UnderLine, DrawInkMethod.dimenViewModel.FontSize, DrawInkMethod.dimenViewModel.FontFam);
           }
        }

        private void CheckBox_Click_2(object sender, RoutedEventArgs e)
        {
            if (!isReadOnly)
            {
                ReWriteText(DrawInkMethod.InkAll[DrawInkMethod.ActiveViews.ActiveWin].inkCanvas, DrawInkMethod.dimenViewModel.SelectedAccentColor, DrawInkMethod.dimenViewModel.TextSelectedAccentColor, DrawInkMethod.dimenViewModel.Italic, DrawInkMethod.dimenViewModel.Bold, DrawInkMethod.dimenViewModel.UnderLine, DrawInkMethod.dimenViewModel.FontSize, DrawInkMethod.dimenViewModel.FontFam);
            }
        }

        private void SnapInkSave_Checked(object sender, RoutedEventArgs e)
        {
            LambdaControl.Trigger("VISUAL_SNAP_SAVE", this, new Dictionary<string, object>() { { "mode", 1 } });
        }

        private void SnapInkSave_Unchecked(object sender, RoutedEventArgs e)
        {
            LambdaControl.Trigger("VISUAL_SNAP_SAVE", this, new Dictionary<string, object>() { { "mode", 0 } });
        }

        private void AcquireInkSave_Checked(object sender, RoutedEventArgs e)
        {
            LambdaControl.Trigger("VISUAL_ACQUIRE_SAVE", this, new Dictionary<string, object>() { { "mode", 1 } });
        }

        private void AcquireInkSave_Unchecked(object sender, RoutedEventArgs e)
        {
            LambdaControl.Trigger("VISUAL_ACQUIRE_SAVE", this, new Dictionary<string, object>() { { "mode", 0 } });
        }
    }
}
