using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Resources;

namespace InkManager.UserControls
{
    public partial class InkVisual : UserControl
    {
        public TabItem propertySetItem;
        public TabControl tabControl;
        public List<ToggleButton> DrawingModeList;
        int tempSelectedIndex = 0;
        private void ToolDataBinding()
        {
         //   MessageBox.Show("1111");

            topToolbar = (WrapPanel)mainwin.FindName("topToolbar");
            Binding binding0 = new Binding("SelectChecked");
            ToggleButton ToggleButtonSelect = ((ToggleButton)topToolbar.Children[0]);
            ToggleButtonSelect.SetBinding(ToggleButton.IsCheckedProperty, binding0);

            Binding binding1 = new Binding("InlineChecked");
            ToggleButton ToggleButtonInline = ((ToggleButton)topToolbar.Children[1]);
            ToggleButtonInline.SetBinding(ToggleButton.IsCheckedProperty, binding1);

            Binding binding2 = new Binding("MoveChecked");
            ToggleButton ToggleButtonMove = ((ToggleButton)topToolbar.Children[2]);
            ToggleButtonMove.SetBinding(ToggleButton.IsCheckedProperty, binding2);

            Button ToggleButtonSearch = ((Button)topToolbar.Children[3]);

            Binding binding4 = new Binding("ZoomOutChecked");
            ToggleButton ToggleButtonZoomOut = ((ToggleButton)topToolbar.Children[4]);
            ToggleButtonZoomOut.SetBinding(ToggleButton.IsCheckedProperty, binding4);

            Binding binding5 = new Binding("ZoomInChecked");
            ToggleButton ToggleButtonZoomIn = ((ToggleButton)topToolbar.Children[5]);
            ToggleButtonZoomIn.SetBinding(ToggleButton.IsCheckedProperty, binding5);

            Button ToggleButtonScale = ((Button)topToolbar.Children[6]);

            Binding binding9 = new Binding("DimensionChecked");
            ToggleButton ToggleButtonDimen = ((ToggleButton)topToolbar.Children[9]);
            ToggleButtonDimen.SetBinding(ToggleButton.IsCheckedProperty, binding9);

            Binding binding10 = new Binding("FocusChecked");
            ToggleButton ToggleButtonFocus = ((ToggleButton)topToolbar.Children[10]);
            ToggleButtonFocus.SetBinding(ToggleButton.IsCheckedProperty, binding10);

            Binding binding11 = new Binding("RulerChecked");
            ToggleButton ToggleButtonRuler = ((ToggleButton)topToolbar.Children[11]);
            ToggleButtonRuler.SetBinding(ToggleButton.IsCheckedProperty, binding11);

            ToggleButton ToggleButtonProfile = ((ToggleButton)topToolbar.Children[12]);
            ToggleButtonProfile.SetBinding(ToggleButton.IsCheckedProperty, new Binding("ProfileChecked"));

            ToggleButton ToggleButtonEraser = ((ToggleButton)topToolbar.Children[14]);
            ToggleButtonEraser.SetBinding(ToggleButton.IsCheckedProperty, new Binding("EraserChecked"));

            ToggleButton ToggleButtonText = ((ToggleButton)topToolbar.Children[15]);
            ToggleButtonText.SetBinding(ToggleButton.IsCheckedProperty, new Binding("TextChecked"));

            ToggleButton ToggleButtonArrow = ((ToggleButton)topToolbar.Children[16]);
            ToggleButtonArrow.SetBinding(ToggleButton.IsCheckedProperty, new Binding("ArrowChecked"));
            ToggleButtonArrow.Visibility = Visibility.Collapsed; //  

            ToggleButton ToggleButtonLine = ((ToggleButton)topToolbar.Children[17]);
            ToggleButtonLine.SetBinding(ToggleButton.IsCheckedProperty, new Binding("LineChecked"));


            ToggleButton ToggleButtonCurve = ((ToggleButton)topToolbar.Children[18]);
            ToggleButtonCurve.SetBinding(ToggleButton.IsCheckedProperty, new Binding("CurveChecked"));

            ToggleButton ToggleButtonCircle = ((ToggleButton)topToolbar.Children[19]);
            ToggleButtonCircle.SetBinding(ToggleButton.IsCheckedProperty, new Binding("CircleChecked"));

            ToggleButton ToggleButtonRectangle = ((ToggleButton)topToolbar.Children[20]);
            ToggleButtonRectangle.SetBinding(ToggleButton.IsCheckedProperty, new Binding("RectangleChecked"));

            ToggleButton ToggleButtonPolygon = ((ToggleButton)topToolbar.Children[21]);
            ToggleButtonPolygon.SetBinding(ToggleButton.IsCheckedProperty, new Binding("PolygonChecked"));




            List<ToggleButton> Tools = new List<ToggleButton>() { ToggleButtonSelect, ToggleButtonInline, ToggleButtonMove, ToggleButtonZoomOut, ToggleButtonZoomIn, ToggleButtonFocus, ToggleButtonRuler, ToggleButtonProfile, ToggleButtonEraser, ToggleButtonText, ToggleButtonArrow, ToggleButtonLine, ToggleButtonCurve, ToggleButtonCircle, ToggleButtonRectangle, ToggleButtonPolygon };
            DrawingModeList = new List<ToggleButton>() { ToggleButtonRuler, ToggleButtonProfile, ToggleButtonEraser, ToggleButtonText, ToggleButtonLine, ToggleButtonCurve, ToggleButtonCircle, ToggleButtonRectangle, ToggleButtonPolygon };


            foreach (var item in Tools)
            {
               
                item.Checked += delegate (object sender, RoutedEventArgs e)
                {

                    foreach (var item1 in Tools)
                    {
                        if (item1 != item)
                        {
                            if (item1.IsChecked == true)
                                item1.IsChecked = false;
                        }

                    }

                };

            }

        }

        private void ViewToolProChanged()
        {
            DrawInkMethod.ViewTool.topTool.PropertyChanged += (s, e) =>
            {
                if (e.PropertyName == "EraserChecked")
                {
                    if (DrawInkMethod.ViewTool.topTool.EraserChecked == true)
                    {
                        this.inkCanvas.EditingMode = InkCanvasEditingMode.EraseByStroke;
                        this.inkCanvas.UseCustomCursor = true;
                        //StreamResourceInfo sri = Application.GetResourceStream(new Uri("/InkManager;component/Resources/eraser.cur", UriKind.Relative));
                        //this.inkCanvas.Cursor = new Cursor(sri.Stream);


                    }
                    else
                    {
                        this.inkCanvas.Cursor = Cursors.Arrow;
                        this.inkCanvas.EditingMode = InkCanvasEditingMode.None;
                    }
                }
                if (e.PropertyName == "DimensionChecked")
                {
                    if ((bool)DrawInkMethod.ViewTool.topTool.DimensionChecked)
                    {
                      // MessageBox.Show("1111");
                        defaultDim.Visibility = Visibility.Visible;
                    }
                    else
                    {
                       // MessageBox.Show("1111");
                        defaultDim.Visibility = Visibility.Hidden;
                    }
                };
                if (e.PropertyName == "RulerChecked")
                {
                    if (!DrawInkMethod.ViewTool.topTool.RulerChecked)
                    {

                        this.inkCanvas.Cursor = Cursors.Arrow;
                    }
                   
                };

                if (e.PropertyName == "RulerChecked" || e.PropertyName == "CircleChecked" || e.PropertyName == "CurveChecked" || e.PropertyName == "LineChecked" || e.PropertyName == "PolygonChecked" || e.PropertyName == "RectangleChecked" || e.PropertyName == "TextChecked" || e.PropertyName == "EraserChecked")
                {
                    if (DrawInkMethod.ViewTool.topTool.RulerChecked || DrawInkMethod.ViewTool.topTool.CircleChecked || DrawInkMethod.ViewTool.topTool.CurveChecked || DrawInkMethod.ViewTool.topTool.LineChecked || DrawInkMethod.ViewTool.topTool.PolygonChecked || DrawInkMethod.ViewTool.topTool.RectangleChecked || DrawInkMethod.ViewTool.topTool.TextChecked)
                    {

                        propertySetItem.Visibility = Visibility.Visible;
                        propertySetItem.DataContext = DrawInkMethod.dimenViewModel;
                        if (tabControl.SelectedIndex != 5)
                            tempSelectedIndex = tabControl.SelectedIndex; ;
                        tabControl.SelectedIndex = 5;
                        DrawInkMethod.dimenViewModel.DimShapeCombo = false;
                        if (DrawInkMethod.ViewTool.topTool.LineChecked)
                        {
                            DrawInkMethod.dimenViewModel.DimShapeCombo = true;
                        };

                       // inkCanvas.EditingMode = InkCanvasEditingMode.None;

                    }
                    else
                    {
                        if (DrawInkMethod.ViewTool.topTool.DimensionChecked == true || DrawInkMethod.ViewTool.topTool.EraserChecked)
                        {
                            propertySetItem.Visibility = Visibility.Visible;
                            if (tabControl.SelectedIndex != 5)
                                tempSelectedIndex = tabControl.SelectedIndex;
                            tabControl.SelectedIndex = 5;
                            DrawInkMethod.defdimenViewModel.DimShapeCombo = false;
                            propertySetItem.DataContext = DrawInkMethod.defdimenViewModel;
                            DrawInkMethod.defdimenViewModel.DimPosShow = true;
                            DrawInkMethod.defdimenViewModel.DimSelectedIndex = 2;

                        }
                        else
                        {
                            if (inkCanvas.EditingMode == InkCanvasEditingMode.Select)
                                return;
                            propertySetItem.Visibility = Visibility.Collapsed;
                            tabControl.SelectedIndex = tempSelectedIndex;
                        };

                    }


                };

                if (e.PropertyName == "DimensionChecked")
                {
                    if (DrawInkMethod.ViewTool.topTool.DimensionChecked == true)
                    {
                        propertySetItem.Visibility = Visibility.Visible;
                        if (tabControl.SelectedIndex != 5)
                            tempSelectedIndex = tabControl.SelectedIndex;
                        tabControl.SelectedIndex = 5;
                        DrawInkMethod.defdimenViewModel.DimShapeCombo = false;
                        propertySetItem.DataContext = DrawInkMethod.defdimenViewModel;
                        DrawInkMethod.defdimenViewModel.DimSelectedIndex = 2;
                        DrawInkMethod.defdimenViewModel.DimPosShow = true;
                        DrawInkMethod.defdimenViewModel.LabelPosShow = false;

                    }
                    else if (DrawInkMethod.ViewTool.topTool.DimensionChecked == false && DrawInkMethod.ViewTool.topTool.EraserChecked == false)
                    {
                        propertySetItem.Visibility = Visibility.Collapsed;
                        tabControl.SelectedIndex = tempSelectedIndex;
                        DrawInkMethod.defdimenViewModel.DimSelectedIndex = 0;
                        DrawInkMethod.defdimenViewModel.DimPosShow = false;
                    };
                    if (DrawInkMethod.ViewTool.topTool.RulerChecked || DrawInkMethod.ViewTool.topTool.CircleChecked || DrawInkMethod.ViewTool.topTool.CurveChecked || DrawInkMethod.ViewTool.topTool.LineChecked || DrawInkMethod.ViewTool.topTool.PolygonChecked || DrawInkMethod.ViewTool.topTool.RectangleChecked || DrawInkMethod.ViewTool.topTool.TextChecked)
                    {
                        propertySetItem.Visibility = Visibility.Visible;
                        propertySetItem.DataContext = DrawInkMethod.dimenViewModel;
                        if (tabControl.SelectedIndex != 5)
                            tempSelectedIndex = tabControl.SelectedIndex;
                        tabControl.SelectedIndex = 5;
                        DrawInkMethod.dimenViewModel.DimShapeCombo = false;
                        if (DrawInkMethod.ViewTool.topTool.LineChecked)
                        {
                            DrawInkMethod.dimenViewModel.DimShapeCombo = true;
                            DrawInkMethod.dimenViewModel.DimSelectedIndex = 0;

                        };

                    }
                }


            };



        }


        private void ReCursor()
        {

            DrawInkMethod.ViewTool.topTool.PropertyChanged += (s, e) =>
            {
                if (e.PropertyName == "EraserChecked")
                {
                    if (!DrawInkMethod.ViewTool.topTool.EraserChecked)
                    {
                        this.inkCanvas.Cursor = Cursors.Arrow;
                        this.inkCanvas.EditingMode = InkCanvasEditingMode.None;
                    }
                   

                }
                else if (e.PropertyName == "RulerChecked")
                {

                    if (!DrawInkMethod.ViewTool.topTool.RulerChecked)
                    {
                        this.inkCanvas.Cursor = Cursors.Arrow;
                    }
                    else
                    {
                        this.inkCanvas.EditingMode = InkCanvasEditingMode.None;
                    }
                }
                else if (e.PropertyName == "TextChecked")
                {
                    if (!DrawInkMethod.ViewTool.topTool.TextChecked)
                    {
                        this.inkCanvas.Cursor = Cursors.Arrow;
                    }
                    else
                    {
                        this.inkCanvas.EditingMode = InkCanvasEditingMode.None;
                    }

                }
                else if (e.PropertyName == "LineChecked")
                {

                    if (!DrawInkMethod.ViewTool.topTool.LineChecked)
                    {
                        this.inkCanvas.Cursor = Cursors.Arrow;
                    }
                    else
                    {
                        this.inkCanvas.EditingMode = InkCanvasEditingMode.None;
                    }
                }
                else if (e.PropertyName == "CurveChecked")
                {
                    if (!DrawInkMethod.ViewTool.topTool.CurveChecked)
                    {
                        this.inkCanvas.Cursor = Cursors.Arrow;
                    }
                    else
                    {
                        this.inkCanvas.EditingMode = InkCanvasEditingMode.None;
                    }   

                }
                else if (e.PropertyName == "CircleChecked")
                {
                    if (!DrawInkMethod.ViewTool.topTool.CircleChecked)
                    {
                        this.inkCanvas.Cursor = Cursors.Arrow;
                    }
                    else
                    {
                        this.inkCanvas.EditingMode = InkCanvasEditingMode.None;
                    }

                }
                else if (e.PropertyName == "RectangleChecked")
                {
                    if (!DrawInkMethod.ViewTool.topTool.RectangleChecked)
                    {
                        this.inkCanvas.Cursor = Cursors.Arrow;
                    }
                    else
                    {
                        this.inkCanvas.EditingMode = InkCanvasEditingMode.None;
                    }

                }
                else if (e.PropertyName == "PolygonChecked")
                {
                    if (!DrawInkMethod.ViewTool.topTool.PolygonChecked)
                    {
                        this.inkCanvas.Cursor = Cursors.Arrow;
                    }
                    else
                    {
                        this.inkCanvas.EditingMode = InkCanvasEditingMode.None;
                    }
                        
                }

            };



        }
















        

        private void DefDimProChanged()
        {
            DrawInkMethod.defdimenViewModel.PropertyChanged += delegate (object? sender, PropertyChangedEventArgs e)
            {
                if (e.PropertyName == "DimPos" || e.PropertyName == "Length" || e.PropertyName == "SelectedAccentColor" || e.PropertyName == "TextSelectedAccentColor")
                {
                    double ratio = ratio1.Ratio;
                    string position = DrawInkMethod.defdimenViewModel.DimPos;
                    double length = DrawInkMethod.defdimenViewModel.Length;
                    Color color = DrawInkMethod.defdimenViewModel.SelectedAccentColor;
                    Color TextColor = DrawInkMethod.defdimenViewModel.TextSelectedAccentColor;
                    if (index == DrawInkMethod.ActiveWindow)
                    {
                        drawDefaultDim(position, length, color, ratio, TextColor);
                    }


                }

            };
        }




        private void VisualProAdd()
        {

           // MessageBox.Show("111111");
            try
            {

                tabControl = (TabControl)mainwin.FindName("leftTab");
                Border border = (Border)tabControl.Parent;
                border.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#444444"));
                //tabControl.Parent 
                if (tabControl == null) return;
                propertySetItem = new TabItem();
                propertySetItem.Header = "属性设置";
                ScrollViewer scrollViewer = new ScrollViewer();
                scrollViewer.HorizontalScrollBarVisibility = ScrollBarVisibility.Disabled;
                scrollViewer.VerticalScrollBarVisibility = ScrollBarVisibility.Auto;
                Viewbox proViewBox = new Viewbox();
                proViewBox.VerticalAlignment = VerticalAlignment.Top;
                proViewBox.Stretch = Stretch.Uniform;
                StackPanel stackPanel = new StackPanel();
                stackPanel.HorizontalAlignment = HorizontalAlignment.Stretch;
                InkProperty dimenPreoperty = new InkProperty();
                stackPanel.Children.Add(dimenPreoperty);
                //dimenPreoperty.DataContext = DrawInkMethod.dimenViewModel;
                proViewBox.Child = stackPanel;
                scrollViewer.Content = proViewBox;
                propertySetItem.Content = scrollViewer;
                propertySetItem.Visibility = Visibility.Collapsed;
                tabControl.Items.Add(propertySetItem);


                dimenPreoperty.ColorTextBox.TextChanged += delegate
                {
                    inkMethod.drawingAttributes.Color = DrawInkMethod.dimenViewModel.SelectedAccentColor;
                };



            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }


        }

        private void StrokeCollectChanged()
        {
            inkCanvas.Strokes.StrokesChanged += delegate
            {

                DrawInkMethod.StrokesCollection.Clear();

                FilterStroke(1);

            };


            inkCanvas.EditingModeChanged += (s, e) =>
            {

                if (inkCanvas.EditingMode == InkCanvasEditingMode.Select)
                {
                    foreach (var item in DrawingModeList)
                    {
                        if (item.IsChecked == true)
                            item.IsChecked = false;
                    }
                }

            };


        }



    }






}


