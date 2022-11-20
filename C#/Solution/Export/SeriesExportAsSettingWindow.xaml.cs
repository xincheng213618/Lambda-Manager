using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using ThemeManager.Controls;
using Tool;
using XSolution;
using System;
using System.Windows.Documents;
using System.Windows.Media;
using XSolution.SeriesProject;
using System.Collections.Generic;
using System.Linq;
using Global.Common.Extensions;
using System.Windows.Shapes;
using System.Net;

namespace Solution
{
    /// <summary>
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class SeriesExportAsSettingWindow : BaseWindow
    {
        public SeriesProjectManager SeriesProject;

        AdornerLayer mAdornerLayer = null;
        public SeriesExportAsSettingWindow(SeriesProjectManager seriesProjectManager)
        {
            this.SeriesProject = seriesProjectManager;
            InitializeComponent();
            TextBock1.Text = seriesProjectManager.Name;
            SeriesExportTreeView1.ItemsSource = this.SeriesProject.VisualChildren;
            SeriesExportTreeView2.ItemsSource = this.SeriesProject.ExportChildren;
        }


        private void BaseWindow_Initialied(object sender, EventArgs e)
        {
            //SeriesExportTreeView2.PreviewMouseMove += SeriesExportTreeView2_PreviewMouseMove;
            //SeriesExportTreeView2.QueryContinueDrag += SeriesExportTreeView2_QueryContinueDrag;
            ContextMenu contextMenu = new ContextMenu();
            MenuItem menuItem = new MenuItem() { Header ="采集点"};
            foreach (var item in SeriesProject.Meta.DicPoints.Keys)
            {
                MenuItem menuItem3 = new MenuItem() { Header = $"{item.X}  {item.Y}", IsChecked = true };
                menuItem3.Click += (s, e) =>
                {
                    menuItem3.IsChecked = !menuItem3.IsChecked;
                    foreach (var item in SeriesProject.Meta.DicPoints[item])
                    {
                        if (!menuItem3.IsChecked)
                        {
                            item.Visibility =Visibility.Hidden; 
                        }
                        else
                        {
                            item.Visibility = Visibility.Visible;
                        }
                    }
                };
                menuItem.Items.Add(menuItem3);
            }
            MenuItem menuItem1 = new MenuItem() { Header = "聚焦层面" };

            MenuItem menuItem11= new MenuItem() { Header = $"全选" };
            menuItem11.Click += (s, e) =>
            {
                foreach (MenuItem item in menuItem1.Items)
                {
                    item.IsChecked =true;
                }
            };
            MenuItem menuItem12 = new MenuItem() { Header = $"全不选" };
            menuItem12.Click += (s, e) =>
            {
                foreach (MenuItem item in menuItem1.Items)
                {
                    item.IsChecked = false;
                }
            };
            menuItem1.Items.Add(menuItem11);
            menuItem1.Items.Add(menuItem12);
            foreach (var item in SeriesProject.Meta.DicZ.Keys)
            {
                MenuItem menuItem3 = new MenuItem() { Header = $"{item}层" ,IsChecked =true };
                menuItem3.Click += (s, e) =>
                {
                    menuItem3.IsChecked = !menuItem3.IsChecked;
                    foreach (var item in SeriesProject.Meta.DicZ[item])
                    {
                        if (!menuItem3.IsChecked)
                        {
                            item.Visibility = Visibility.Hidden;
                        }
                        else
                        {
                            foreach (var item2 in menuItem.Items)
                            {
                                if (item2 is MenuItem menuItem5)
                                    menuItem5.IsChecked = true;
                            }

                            item.Visibility = Visibility.Visible;
                        }
                    }
                };
                menuItem1.Items.Add(menuItem3);
            }

            MenuItem menuItem2 = new MenuItem() { Header = "拍摄模式" };
            foreach (var item in SeriesProject.Meta.DicOM.Keys)
            {
                MenuItem menuItem3 = new MenuItem() { Header = $"{item}层", IsChecked = true };
                menuItem3.Click += (s, e) =>
                {
                    menuItem3.IsChecked = !menuItem3.IsChecked;
                    foreach (var item in SeriesProject.Meta.DicOM[item])
                    {
                        if (!menuItem3.IsChecked)
                        {
                            item.Visibility = Visibility.Hidden;
                        }
                        else
                        {
                            foreach (var item2 in menuItem.Items)
                            {
                                if (item2 is MenuItem menuItem5)
                                    menuItem5.IsChecked = true;
                            }
                            foreach (var item2 in menuItem1.Items)
                            {
                                if (item2 is MenuItem menuItem5)
                                    menuItem5.IsChecked = true;
                            }

                            item.Visibility = Visibility.Visible;
                        }
                    }
                };
                menuItem2.Items.Add(menuItem3);
            }
            contextMenu.Items.Add(menuItem);
            contextMenu.Items.Add(menuItem1);
            contextMenu.Items.Add(menuItem2);
            FilterButton.ContextMenu = contextMenu ;
        }

        List<GrifFile> SelectGrifList = new List<GrifFile>();

        private void SeriesExportTreeView2_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            if (Mouse.LeftButton != MouseButtonState.Pressed)
                return;

            Point pos = e.GetPosition(SeriesExportTreeView2);
            HitTestResult result = VisualTreeHelper.HitTest(SeriesExportTreeView2, pos);
            if (result == null)
                return;

            TreeViewItem listBoxItem = ViewHelper.FindVisualParent<TreeViewItem>(result.VisualHit); // Find your actual visual you want to drag
            if (listBoxItem == null)
                return;

            DragDropAdorner adorner = new DragDropAdorner(listBoxItem);
            mAdornerLayer = AdornerLayer.GetAdornerLayer(RootGrid); // Window class do not have AdornerLayer
            mAdornerLayer.Add(adorner);

            GrifFile dataItem = listBoxItem.DataContext as GrifFile;
            DataObject dataObject = new DataObject(dataItem);

            DragDrop.DoDragDrop(SeriesExportTreeView2, dataObject, DragDropEffects.Copy);

            mAdornerLayer.Remove(adorner);
            mAdornerLayer = null;

        }
        private void SeriesExportTreeView2_QueryContinueDrag(object sender, QueryContinueDragEventArgs e)
        {
            if (mAdornerLayer != null)
            {
                mAdornerLayer.Update();
                //UpdateTreeViewExpandingState();
            }
        }

        private void Button_Click_0(object sender, RoutedEventArgs e)
        {
            SeriesProject.ExportChildren.Insert(Indexof, new SeriesProjectExportLine("-------------------"));
            Indexof++;
        }

        int Indexof = 0;
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SelectGrifList.Clear();
            foreach (GrifFile item in SeriesProject.ExportChildren.Cast<GrifFile>())
            {
                if (item.IsCheck)
                    SelectGrifList.Add(item);
            }
            if (SelectGrifList.Count > 1)
            {
                int index = SeriesProject.ExportChildren.IndexOf(SelectGrifList[0]);
                if (index <= 0)
                    return;

                foreach (var item in SelectGrifList)
                {
                    SeriesProject.ExportChildren.Remove(item);
                }
                for (int i = 0; i < SelectGrifList.Count; i++)
                {
                    SeriesProject.ExportChildren.Insert(i, SelectGrifList[i]);
                }
                return;
            }



            if (Indexof < 0 || Indexof >= SeriesProject.ExportChildren.Count || !IsOneExportCheck())
                return;
            if (SeriesProject.ExportChildren[Indexof] is GrifFile grifFile)
            {
                SeriesProject.ExportChildren.Remove(grifFile);
                SeriesProject.ExportChildren.Insert(0, grifFile);
                grifFile.IsSelected = true;
                Indexof= 0;
            }
        }
        public bool IsOneExportCheck()
        {
            bool IsOne = false;
            foreach (GrifFile item in SeriesProject.ExportChildren)
            {
                if (item.IsCheck&&IsOne)
                    return false;
                if (item.IsCheck)
                    IsOne = true;
            }
            return IsOne;
        }



        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            SelectGrifList.Clear();
            foreach (GrifFile item in SeriesProject.ExportChildren)
            {
                if (item.IsCheck)
                    SelectGrifList.Add(item);
            }
            if (SelectGrifList.Count > 1)
            {
                int index = SeriesProject.ExportChildren.IndexOf(SelectGrifList[0]);
                if (index <= 0)
                    return;

                foreach (var item in SelectGrifList)
                {
                    SeriesProject.ExportChildren.Remove(item);
                }
                for (int i = 0; i < SelectGrifList.Count; i++)
                {
                    SeriesProject.ExportChildren.Insert(index - 1 +i, SelectGrifList[i]);
                }
                return;
            }

            if (Indexof < 1 || Indexof > SeriesProject.ExportChildren.Count-1|| !IsOneExportCheck())
                return;

            if (SeriesProject.ExportChildren[Indexof] is GrifFile grifFile)
            {
                SeriesProject.ExportChildren.Remove(grifFile);
                SeriesProject.ExportChildren.Insert(Indexof-1, grifFile);
                grifFile.IsSelected = true;
                Indexof--;
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            SelectGrifList.Clear();
            foreach (GrifFile item in SeriesProject.ExportChildren.Cast<GrifFile>())
            {
                if (item.IsCheck)
                    SelectGrifList.Add(item);
            }
            if (SelectGrifList.Count > 1)
            {
                int index = SeriesProject.ExportChildren.IndexOf(SelectGrifList[0]);
                if (index > SeriesProject.ExportChildren.Count - SelectGrifList.Count - 1)
                    return;

                foreach (var item in SelectGrifList)
                {
                    SeriesProject.ExportChildren.Remove(item);
                }
                for (int i = 0; i < SelectGrifList.Count; i++)
                {
                    SeriesProject.ExportChildren.Insert(index + 1 + i, SelectGrifList[i]);
                }
                return;
            }



            if (Indexof < 0 || Indexof > SeriesProject.ExportChildren.Count-2 || !IsOneExportCheck())
                return;


            if (SeriesProject.ExportChildren[Indexof] is GrifFile grifFile)
            {
                SeriesProject.ExportChildren.Remove(grifFile);
                SeriesProject.ExportChildren.Insert(Indexof + 1, grifFile);
                grifFile.IsSelected = true;
                Indexof++;
            }

        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            SelectGrifList.Clear();
            foreach (GrifFile item in SeriesProject.ExportChildren.Cast<GrifFile>())
            {
                if (item.IsCheck)
                    SelectGrifList.Add(item);
            }
            if (SelectGrifList.Count > 1)
            {
                int index = SeriesProject.ExportChildren.IndexOf(SelectGrifList[0]);
                if (index > SeriesProject.ExportChildren.Count - SelectGrifList.Count - 1)
                    return;

                foreach (var item in SelectGrifList)
                {
                    SeriesProject.ExportChildren.Remove(item);
                }
                for (int i = 0; i < SelectGrifList.Count; i++)
                {
                    SeriesProject.ExportChildren.Add(SelectGrifList[i]);
                }
                return;
            }


            if (Indexof < 0 || Indexof > SeriesProject.ExportChildren.Count-1 || !IsOneExportCheck())
                return;

            if (SeriesProject.ExportChildren[Indexof] is GrifFile grifFile)
            {
                SeriesProject.ExportChildren.Remove(grifFile);
                SeriesProject.ExportChildren.Insert(SeriesProject.ExportChildren.Count, grifFile);
                grifFile.IsSelected = true;
                Indexof = SeriesProject.ExportChildren.Count-1;
            }
        }


        GrifFile grifFileLastcheck = null;
        private void Grid_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            FrameworkElement stackPanel = sender as FrameworkElement;
            if (stackPanel.Tag is SeriesProjectExportLine seriesProjectExportLine)
            {
                Indexof = SeriesProject.ExportChildren.IndexOf(seriesProjectExportLine);
                if (Indexof > 0)
                {
                    if (SeriesProject.ExportChildren[Indexof-1] is SeriesProjectExportLine)
                    {
                        SeriesProject.ExportChildren.Remove(seriesProjectExportLine);

                    }
                    else if (SeriesProject.ExportChildren[Indexof - 1] is GrifFile grifFile)
                    {
                        Indexof--;
                        grifFile.IsSelected = true;
                    }
                }
            }
            else if (stackPanel.Tag is GrifFile grifFile)
            {
                Indexof = SeriesProject.ExportChildren.IndexOf(grifFile);
                if (Keyboard.IsKeyDown(Key.LeftCtrl) || Keyboard.IsKeyDown(Key.RightCtrl))
                {
                    grifFile.IsCheck = !grifFile.IsCheck;
                }
                else if (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift))
                {
                    if (grifFileLastcheck == null)
                    {
                        grifFileLastcheck = grifFile;
                        return;
                    }
                    if (grifFileLastcheck != grifFile)
                    {
                        int a = Indexof;
                        int b = SeriesProject.ExportChildren.IndexOf(grifFileLastcheck);


                        if (b == a)
                            return;
                        if (b < a)
                        {
                            a ^= b;
                            b = a ^ b;
                            a ^= b;
                        }
                        for (int i = a; i <= b; i++)
                        {
                            if (SeriesProject.ExportChildren[i] is GrifFile grifFile1)
                            {
                                grifFile1.IsCheck = true;

                            }
                        }
                        return;

                    }
                }
                else
                {
                    foreach (GrifFile item in SeriesProject.ExportChildren)
                    {
                        item.IsCheck = false;
                    }
                    grifFile.IsCheck = true;
                }
                grifFileLastcheck = grifFile;
            }
        }


        private void Button_Click_01(object sender, RoutedEventArgs e)
        {
            CheckEendControl(SeriesProject);
        }

        public void CheckEendControl(BaseObject baseObject,bool? IsCheckNot =true,bool Add = true)
        {
            foreach (var item in baseObject.VisualChildren)
            {
                if (item is GrifFile grifFile && (IsCheckNot ==true || grifFile.IsCheck))
                {
                    if (Add)
                    {
                        if (!SeriesProject.ExportChildren.Contains(grifFile))
                            SeriesProject.ExportChildren.Add(grifFile);
                    }
                    else
                    {
                        if (SeriesProject.ExportChildren.Contains(grifFile))
                            SeriesProject.ExportChildren.Remove(grifFile);
                    }

                }
                else if (item is ProjectFolder projectFolder1)
                {
                    CheckEendControl(projectFolder1, IsCheckNot,Add);
                }
            }
        }


        private void Button_Click_02(object sender, RoutedEventArgs e)
        {
            CheckEendControl(SeriesProject, false);
        }

        private void Button_Click_03(object sender, RoutedEventArgs e)
        {
            SeriesProject.ExportChildren.RemoveAll(x => x is GrifFile grifFile && grifFile.IsCheck);
        }

        private void Button_Click_04(object sender, RoutedEventArgs e)
        {
            SeriesProject.ExportChildren.Clear();
        }

        public int Indexof1 = 0;
        private void StackPanel1_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            StackPanel stackPanel = sender as StackPanel;
            if (stackPanel.Tag is GrifFile grifFile)
            {
                Indexof1 = SeriesProject.ExportChildren.IndexOf(grifFile);
            }
        }


        private void OK_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox.Tag is GrifFile grifFile)
            {
                Indexof = SeriesProject.VisualChildren.IndexOf(grifFile);
            }
        }

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox.Tag is ProjectFolder projectFolder)
            {
                if (projectFolder.Parent is ProjectFolder projectFolder1 && projectFolder1.IsCheck ==false)
                    projectFolder1.IsCheck=null;
                CheckEend(projectFolder, true);
            }
        }

        public void CheckEend(ProjectFolder projectFolder, bool IsCheck)
        {
            foreach (var item in projectFolder.VisualChildren)
            {
                if (item is GrifFile grifFile)
                {
                    grifFile.IsCheck = IsCheck;
                }
                else if (item is ProjectFolder projectFolder1)
                {
                    projectFolder1.IsCheck = IsCheck;
                    CheckEend(projectFolder1, IsCheck);
                }
            }
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox.Tag is ProjectFolder projectFolder)
            {
                CheckEend(projectFolder, false);
            }
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox.IsChecked == null)
                checkBox.IsChecked = false;
            if (checkBox.Tag is ProjectFolder projectFolder)
            {
                if (projectFolder.Parent is ProjectFolder projectFolder1 && projectFolder.IsCheck != projectFolder1.IsCheck)
                {
                    projectFolder1.IsCheck = null;

                    bool? result = null;
                    foreach (var item in projectFolder1.VisualChildren)
                    {
                        if (item is ProjectFolder projectFolder2)
                        {
                            if (projectFolder.IsCheck != projectFolder2.IsCheck)
                            {
                                result = projectFolder2.IsCheck;
                                break;
                            }
                        }
                    }
                    if (result == null)
                        projectFolder1.IsCheck = projectFolder.IsCheck;
                }

                if (projectFolder.IsCheck == true)
                {
                    CheckEend(projectFolder, true);
                }
                else if (projectFolder.IsCheck == false)
                {
                    CheckEend(projectFolder, false);
                }



            }
        }

        private void GrifFileCheckBoxClick(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox.Tag is GrifFile grifFile && grifFile.Parent is ProjectFolder projectFolder)
            {
                if (projectFolder.IsCheck == true && grifFile.IsCheck == false)
                {
                    projectFolder.IsCheck = null;
                }
                else if (projectFolder.IsCheck == false && grifFile.IsCheck == true)
                {
                    projectFolder.IsCheck = null;
                }

                if (projectFolder.IsCheck == null)
                {
                    bool? result = null;
                    foreach (var item in projectFolder.VisualChildren)
                    {
                        if (item is GrifFile grifFile1)
                        {
                            if (grifFile.IsCheck != grifFile1.IsCheck)
                            {
                                result = grifFile.IsCheck;
                                break;
                            }
                        }
                    }
                    if (result == null)
                        projectFolder.IsCheck = grifFile.IsCheck;
                }

            }
        }

        private void FilterButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            button.ContextMenu.IsOpen = true;
        }


        private void TreeViewItem_Selected(object sender, RoutedEventArgs e)
        {
            TreeViewItem treeViewItem = sender as TreeViewItem;
            treeViewItem.BringIntoView();
        }

        Point PointS;
        bool TreeView2IsRect = false;
        Rectangle TreeView2Rect;

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Grid grid = sender as Grid;
            PointS = Mouse.GetPosition(grid);
            TreeView2Rect = new Rectangle() { HorizontalAlignment =HorizontalAlignment.Left ,VerticalAlignment =VerticalAlignment.Top ,Fill = Brushes.Green ,Opacity =0.5};
            TreeView2Rect.Margin = new Thickness(PointS.X, PointS.Y,0,0);    
            grid.Children.Add(TreeView2Rect);
            TreeView2IsRect = true;
        }

        private void Grid_MouseMove(object sender, MouseEventArgs e)
        {
            if (TreeView2IsRect)
            {
                Grid grid = sender as Grid;
                Point PointM = Mouse.GetPosition(grid);

                TreeView2Rect.Margin = new Thickness(PointM.X - PointS.X < 0 ? PointM.X : PointS.X, PointM.Y - PointS.Y < 0 ? PointM.Y : PointS.Y, 0, 0);
                TreeView2Rect.Height =  Math.Abs(PointM.Y - PointS.Y);
                TreeView2Rect.Width = Math.Abs(PointM.X - PointS.X);
            }
            else
            {
                Grid grid = sender as Grid;
                if (TreeView2Rect!=null)
                    grid.Children.Remove(TreeView2Rect);
            }
        }

        private void Grid_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Grid grid = sender as Grid;
            grid.Children.Remove(TreeView2Rect);
            TreeView2Rect = null;
            TreeView2IsRect = false;
        }

        private void Grid_MouseEnter(object sender, MouseEventArgs e)
        {
            if (TreeView2IsRect&& sender is Grid grid &&grid.Tag is GrifFile grifFile)
            {
                grifFile.IsCheck = true;
            }

        }
    }


}
