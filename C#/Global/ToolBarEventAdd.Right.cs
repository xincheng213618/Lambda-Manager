using GalleryView;
using Global.UserControls;
using Global.UserControls.DrawVisual;
using Lambda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Media;

namespace Global
{
    public partial class WindowData1
    {

        public void ToolBarRightAddEvent()
        {

            ViewCountHandle();
            ReadViewModeHandle();
        }





        private void ReadViewModeHandle()
        {

            ModeButtonAddClickHandle();

        }

        private void ModeButtonAddClickHandle()
        {
            WrapPanel WrapPanel1 = (WrapPanel)mainwin.FindName("rightToolbar");
            ToggleButton BFTogg = (ToggleButton)WrapPanel1.Children[2];
            ToggleButton DFTogg = (ToggleButton)WrapPanel1.Children[3];
            ToggleButton RITogg = (ToggleButton)WrapPanel1.Children[4];
            ToggleButton DPTogg = (ToggleButton)WrapPanel1.Children[5];
            ToggleButton QPTogg = (ToggleButton)WrapPanel1.Children[6];
            ToggleButton PCTogg = (ToggleButton)WrapPanel1.Children[7];
            BFTogg.Click += (s, e) =>
            {
                FindModeWindow(0);
            };
            DFTogg.Click += (s, e) =>
            {
                FindModeWindow(1);
            };
            RITogg.Click += (s, e) =>
            {
                FindModeWindow(2);
            };
            DPTogg.Click += (s, e) =>
            {
                FindModeWindow(3);
            };

            QPTogg.Click += (s, e) =>
            {
                FindModeWindow(4);
            };
            PCTogg.Click += (s, e) =>
            {
                FindModeWindow(5);
            };


        }




        private void FindModeWindow(int mode)
        {
            int mode0 = GetActiveWinMode(DrawInkMethod.ActiveViews.ActiveWin); //当前焦点窗口模态
            Window mainwin = System.Windows.Application.Current.MainWindow;

            int ViwCount = DrawInkMethod.GetViewCount(mainwin);
            if (mode0 == mode)
            {
                return;
                
            }
            else
            {
                bool isExist = false;


                for(int i = 0; i < ViwCount; i++)
                {
                    if (inkVisuals[i]!= null)
                    {
                        int mode1 = GetActiveWinMode(inkVisuals[i].index);
                        if (mode1 == mode)
                        {
                            isExist = true;
                            DrawInkMethod.ActiveViews.ActiveWin = inkVisuals[i].index;
                            return;
                        }
                    }


                }
                //foreach (InkVisual ink in inkVisuals)
                //{
                //    if (ink != null)
                //    {
                //        int mode1 = GetActiveWinMode(ink.index);
                //        if(mode1== mode)
                //        {
                //            isExist = true;
                //            DrawInkMethod.ActiveViews.ActiveWin = ink.index;
                //            return;
                //        }
                //    }

                //}
                if (!isExist)
                {
                    LambdaControl.Trigger("VIEW_WINDOW", this, new Dictionary<string, object>() { { "type", 0 }, { "window", DrawInkMethod.ActiveViews.ActiveWin }, { "mode1", mode }, { "mode2", -1 } });
               
                   // 查询gallery mode 如果不匹配，请求最新模态对应zstack
                   if(RepoTogg.IsChecked == true)
                    {
                        LambdaControl.Trigger("ZSTACK_GALLERYPATH_TRIGGER", this, new Dictionary<string, object>() { { "mode", mode } });
                        //MessageBox.Show(mode.ToString());
                    }
                
                }


            }
        }
        




        private  int GetActiveWinMode(int index)
        {
            LambdaControl.Trigger("VIEW_CONTEXTMENU", this, new Dictionary<string, object>() { { "view", index } });
            if (WindowData1.contextMenuPar.status == 3)
            {
               int mode = WindowData1.contextMenuPar.mode;
               return mode;
            }
            else
            {
                return 6;
            }

        }








        public void ViewCountHandle()
        {
            WrapPanel WrapPanel1 = (WrapPanel)mainwin.FindName("rightToolbar");
            ToggleButton QuaterTogg = (ToggleButton)WrapPanel1.Children[0];
            ToggleButton DualTogg = (ToggleButton)WrapPanel1.Children[1];
            ToggleButton RepoTogg = (ToggleButton)WrapPanel1.Children[10];
            List<ToggleButton> RightTools1 = new List<ToggleButton>() { QuaterTogg, DualTogg };

            foreach (var item in RightTools1)
            {
                item.Checked += delegate (object sender, RoutedEventArgs e)
                {
                    foreach (var item1 in RightTools1)
                    {
                        if (item1 != item)
                        {
                            if (item1.IsChecked == true)
                                item1.IsChecked = false;
                        }
                    }

                };

            }

            DualViewEnbale(DualTogg);
            ViewCountChange(QuaterTogg);
           // MessageBox.Show("1");
            ZstackGallery(RepoTogg);
        }




        public void DualViewEnbale(ToggleButton DualTogg)
        {
            DualTogg.Click += delegate
            {
                if (DualTogg.IsChecked == false)
                {
                    LambdaControl.Trigger("QUATER_CLICKED0", mainwin, new Dictionary<string, object> { { "mode", (int)ViewWindowMode.FIRST_WINDOW } });
                    if (histogramTogg.IsEnabled == false)
                    {
                        histogramTogg.IsEnabled = true;
                    }

                }
                else
                {
                    LambdaControl.Trigger("QUATER_CLICKED0", mainwin, new Dictionary<string, object> { { "mode", (int)ViewWindowMode.DOUBLE_WINDOW } });
                }
                DrawInkMethod.ViewsCount.ViewCount = 1;
            };

        }


        private void ZstackGallery(ToggleButton RepoTogg)
        {
            StackPanel stackPanel = (StackPanel)mainwin.FindName("bottomView");
            Grid stackPanelParent = (Grid)stackPanel.Parent;

            RepoTogg.Checked += (s, e) =>
            {
                if (histogramTogg.IsChecked == true)
                {
                    histogramTogg.IsChecked = false;
                }
                if (ImageViewState.toolTop.ProfileChecked == true)
                {
                    ImageViewState.toolTop.ProfileChecked = false;
                }

                stackPanelParent.RowDefinitions[2].Height = new GridLength(210, GridUnitType.Pixel);
                galleryView.Visibility = Visibility.Visible;
                galleryTool.Visibility = Visibility.Visible;
                LambdaControl.Trigger("ZSTACK_GALLERY", this, new Dictionary<string, object> { });

            };

            RepoTogg.Unchecked += (s, e) =>
            {
                stackPanelParent.RowDefinitions[2].Height = new GridLength(0, GridUnitType.Pixel);
                galleryView.Visibility = Visibility.Collapsed;
                galleryTool.Visibility = Visibility.Collapsed;

            };

            WrapPanel bottomToolBar1 = (WrapPanel)mainwin.FindName("bottomToolbar");
            galleryView = new Gallery();

            Border imagingView = (Border)mainwin.FindName("imagingView");
            StackPanel stackPanel1 = (StackPanel)mainwin.FindName("bottomView");


            stackPanel1.Children.Add(galleryView);
            galleryView.Visibility = Visibility.Collapsed;
            Binding widthBingding = new Binding();
            widthBingding.Source = imagingView;
            widthBingding.Path = new PropertyPath("ActualWidth");
            galleryView.SetBinding(UserControl.WidthProperty, widthBingding);

            galleryTool = Gallery.galleryTool;
            galleryTool.HorizontalAlignment = HorizontalAlignment.Right;
            galleryTool.Margin = new Thickness(0, 0, 10, 0);
            galleryTool.Visibility = Visibility.Collapsed;
            //bottomToolBar1.Children.Add(gallyTool);

            Grid grid1 = new Grid();
            Border border = (Border)bottomToolBar1.Parent;
            border.Child = grid1;
            grid1.Children.Add(bottomToolBar1);
            grid1.Children.Add(galleryTool);

            //galleryView.mode.PropertyChanged += (s, e) =>

            //{
            //    if (e.PropertyName == "CurrentMode")
            //    {

            //        switch (galleryView.mode.CurrentMode)
            //        {
            //            case "BF":
            //                if (updateStatus.BFToggEnable == true)
            //                {
            //                    updateStatus.BFCheckEnable = true;
            //                };
            //                break;
            //            case "DF":
            //                if (updateStatus.DFToggEnable == true)
            //                {
            //                    updateStatus.DFCheckEnable = true;

            //                };
            //                break;
            //            case "DP":
            //                if (updateStatus.DPToggEnable == true)
            //                {
            //                    updateStatus.DPCheckEnable = true;

            //                };
            //                break;
            //            case "RI":
            //                if (updateStatus.RIToggEnable == true)
            //                {
            //                    updateStatus.RICheckEnable = true;

            //                };
            //                break;
            //            case "QP":
            //                if (updateStatus.QPToggEnable == true)
            //                {
            //                    updateStatus.QPCheckEnable = true;

            //                };
            //                break;
            //            case "PC":
            //                if (updateStatus.PCToggEnable == true)
            //                {
            //                    updateStatus.PCCheckEnable = true;

            //                };
            //                break;


            //        }
            //      GalleryFindMode(galleryView.mode.CurrentMode);

                //}


            //};




        }

        private void GalleryFindMode(string mode)
        {
            int M = ModeToInt(mode);
            bool isExist = false;

            if (inkVisuals[DrawInkMethod.ActiveViews.ActiveWin].ActiveMode != M)
            {
                foreach (InkVisual ink in inkVisuals)
                {
                    if (ink != null && ink.ActiveMode == M)
                    {
                        DrawInkMethod.ActiveViews.ActiveWin = ink.index;

                        isExist = true;
                    }

                }
                if (!isExist)
                {
                    inkVisuals[DrawInkMethod.ActiveViews.ActiveWin].ActiveMode = M;
                    LambdaControl.Trigger("VIEW_WINDOW", this, new Dictionary<string, object>() { { "type", 0 }, { "window", DrawInkMethod.ActiveViews.ActiveWin }, { "mode1", M }, { "mode2", -1 } });

                }
            }




        }



        //private void GetWindowMode(int i)
        //{
        //    bool isExist = false;
        //    if (inkVisuals[DrawInkMethod.ActiveViews.ActiveWin].ActiveMode != i)
        //    {
        //        foreach (InkVisual ink in inkVisuals)
        //        {
        //            if (ink != null && ink.ActiveMode == i)
        //            {
        //                DrawInkMethod.ActiveViews.ActiveWin = ink.index;
        //                isExist = true;
        //            }

        //        }
        //        if (!isExist)
        //        {
        //            LambdaControl.Trigger("VIEW_WINDOW", this, new Dictionary<string, object>() { { "type", 0 }, { "window", DrawInkMethod.ActiveViews.ActiveWin }, { "mode1", i }, { "mode2", -1 } });
        //        }
        //    }

        //}


        private int ModeToInt(string mode)
        {
            switch (mode)
            {
                case "BF":
                    return 0;
                    break;
                case "DF":
                    return 1;
                    break;
                case "RI":
                    return 2;
                    break;
                case "DP":
                    return 3;
                    break;
                case "QP":
                    return 4;
                    break;
                case "PC":
                    return 5;
                    break;
                default:
                    return 6;
            }

        }





        public void ViewCountChange(ToggleButton QuaterTogg)
        {


            Popup popup = new Popup();
            popup.AllowsTransparency = true;
            popup.PopupAnimation = PopupAnimation.Slide;
            Binding binding8 = new Binding();
            popup.PlacementTarget = QuaterTogg;
            // Point point = Mouse.GetPosition(QuaterTogg);
            popup.HorizontalOffset = -86;
            popup.VerticalOffset = -25;
            popup.StaysOpen = false;
            QuaterPopup quaterPopup = new QuaterPopup();

            popup.Child = quaterPopup;
            QuaterTogg.MouseEnter += delegate
            {
                popup.IsOpen = true;

            };
            popup.Closed += delegate { popup.IsOpen = false; };
            ;

            quaterPopup.dual.Checked += delegate
            {
                if (QuaterTogg.IsChecked == true)
                {
                    LambdaControl.Trigger("QUATER_CLICKED0", mainwin, new Dictionary<string, object> { { "mode", (int)ViewWindowMode.SECOND_WINDOW } });
                    histogramTogg.IsChecked = false;
                    histogramTogg.IsEnabled = false;
                    DrawInkMethod.ViewsCount.ViewCount = 2;
                    // DrawInkMethod.ActiveViews.ActiveWin = 0;
                }
                else
                {
                    QuaterTogg.IsChecked = true;
                }
                popup.IsOpen = false;
            };

            quaterPopup.four.Checked += delegate
            {
                if (QuaterTogg.IsChecked == true)
                {
                    LambdaControl.Trigger("QUATER_CLICKED0", mainwin, new Dictionary<string, object> { { "mode", (int)ViewWindowMode.FOURTH_WINDOW } });

                    histogramTogg.IsChecked = false;
                    histogramTogg.IsEnabled = false;
                    DrawInkMethod.ViewsCount.ViewCount = 4;
                    // DrawInkMethod.ActiveViews.ActiveWin = 0;


                }
                else
                {
                    QuaterTogg.IsChecked = true;
                }
                popup.IsOpen = false;

            };
            quaterPopup.six.Checked += delegate
            {

                if (QuaterTogg.IsChecked == true)
                {
                    LambdaControl.Trigger("QUATER_CLICKED0", mainwin, new Dictionary<string, object> { { "mode", (int)ViewWindowMode.SIXTH_WINDOW } });

                    histogramTogg.IsChecked = false;
                    histogramTogg.IsEnabled = false;
                    DrawInkMethod.ViewsCount.ViewCount = 6;
                    // DrawInkMethod.ActiveViews.ActiveWin = 0;


                }
                else
                {
                    QuaterTogg.IsChecked = true;
                }
                popup.IsOpen = false;
            };
            void FourWindowTogg_Checked(object sender, RoutedEventArgs e)
            {
                if ((bool)quaterPopup.four.IsChecked)
                {
                    LambdaControl.Trigger("QUATER_CLICKED0", mainwin, new Dictionary<string, object> { { "mode", (int)ViewWindowMode.FOURTH_WINDOW } });
                    DrawInkMethod.ViewsCount.ViewCount = 4;
                    histogramTogg.IsChecked = false;
                    histogramTogg.IsEnabled = false;

                }
                else if ((bool)quaterPopup.six.IsChecked)
                {
                    LambdaControl.Trigger("QUATER_CLICKED0", mainwin, new Dictionary<string, object> { { "mode", (int)ViewWindowMode.SIXTH_WINDOW } });
                    DrawInkMethod.ViewsCount.ViewCount = 6;
                    histogramTogg.IsChecked = false;
                    histogramTogg.IsEnabled = false;
                }
                else if ((bool)quaterPopup.dual.IsChecked)
                {
                    LambdaControl.Trigger("QUATER_CLICKED0", mainwin, new Dictionary<string, object> { { "mode", (int)ViewWindowMode.SECOND_WINDOW } });
                    DrawInkMethod.ViewsCount.ViewCount = 2;
                    histogramTogg.IsChecked = false;
                    histogramTogg.IsEnabled = false;

                }


            }



            QuaterTogg.Checked += FourWindowTogg_Checked;
            QuaterTogg.Unchecked += delegate
            {
                LambdaControl.Trigger("QUATER_CLICKED0", mainwin, new Dictionary<string, object> { { "mode", (int)ViewWindowMode.FIRST_WINDOW } });
                if (histogramTogg.IsEnabled == false)
                {
                    histogramTogg.IsEnabled = true;
                }
                if (inkVisuals[0] != null)
                {

                    inkVisuals[0].BorderBrush = new SolidColorBrush(Colors.Transparent);
                    WindowData1.GetInstance().inkVisuals[0].Border.BorderBrush = new SolidColorBrush(Colors.Transparent);
                    // DrawInkMethod.ActiveViews.ActiveWin = 0;
                }
                DrawInkMethod.ViewsCount.ViewCount = 1;
            };










        }



























    }
}


