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

namespace Solution
{
    /// <summary>
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class SeriesExportAsSettingWindow : BaseWindow
    {
        public SeriesProjectManager seriesProjectManager;

        AdornerLayer mAdornerLayer = null;
        public SeriesExportAsSettingWindow(SeriesProjectManager seriesProjectManager)
        {
            this.seriesProjectManager = seriesProjectManager;
            InitializeComponent();
            TextBock1.Text = seriesProjectManager.Name;
            SeriesExportTreeView1.ItemsSource = this.seriesProjectManager.VisualChildren;
            SeriesExportTreeView2.ItemsSource = this.seriesProjectManager.ExportChildren;
        }


        private void BaseWindow_Initialied(object sender, EventArgs e)
        {
            //SeriesExportTreeView2.PreviewMouseMove += SeriesExportTreeView2_PreviewMouseMove;
            //SeriesExportTreeView2.QueryContinueDrag += SeriesExportTreeView2_QueryContinueDrag;

            ContextMenu contextMenu = new ContextMenu();
            MenuItem menuItem = new MenuItem() { Header ="点"};
            foreach (var item in seriesProjectManager.seriesProjectMeta.Points.Keys)
            {
                MenuItem menuItem3 = new MenuItem() { Header = $"{item.X}  {item.Y}" };
                menuItem3.Click += (s, e) =>
                {
                    menuItem3.IsChecked = !menuItem3.IsChecked;
                    FilterButton.Content = FilterButton.Content.ToString() + menuItem3.Header.ToString();
                    foreach (var item in seriesProjectManager.seriesProjectMeta.Points[item])
                    {
                        if (menuItem3.IsChecked)
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
            MenuItem menuItem1 = new MenuItem() { Header = "Z" };
            foreach (var item in seriesProjectManager.seriesProjectMeta.ZStep)
            {
                MenuItem menuItem3 = new MenuItem() { Header = $"{item}" };
                menuItem3.Click += (s, e) =>
                {
                    FilterButton.Content = FilterButton.Content.ToString() + menuItem3.Header.ToString();
                };
                menuItem1.Items.Add(menuItem3);
            }

            MenuItem menuItem2 = new MenuItem() { Header = "T" };
            for (int i = 0; i < 10; i++)
            {
                menuItem2.Items.Add(new MenuItem() { Header = $"{i}" });
            }
            contextMenu.Items.Add(menuItem);
            contextMenu.Items.Add(menuItem1);
            contextMenu.Items.Add(menuItem2);

            FilterButton.ContextMenu = contextMenu ;
        }

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
            seriesProjectManager.ExportChildren.Insert(Indexof, new SeriesProjectExportLine());
            Indexof--;
        }

        int Indexof = 0;
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Indexof < 0 || Indexof >= seriesProjectManager.ExportChildren.Count)
                return;
            if (seriesProjectManager.ExportChildren[Indexof] is GrifFile grifFile)
            {
                seriesProjectManager.ExportChildren.Remove(grifFile);
                seriesProjectManager.ExportChildren.Insert(0, grifFile);
                grifFile.IsSelected = true;
                Indexof= 0;



            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (Indexof < 1 || Indexof > seriesProjectManager.ExportChildren.Count-1)
                return;


            if (seriesProjectManager.ExportChildren[Indexof] is GrifFile grifFile)
            {
                seriesProjectManager.ExportChildren.Remove(grifFile);
                seriesProjectManager.ExportChildren.Insert(Indexof-1, grifFile);
                grifFile.IsSelected = true;
                Indexof--;
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

            if (Indexof < 0 || Indexof > seriesProjectManager.ExportChildren.Count-2)
                return;


            if (seriesProjectManager.ExportChildren[Indexof] is GrifFile grifFile)
            {
                seriesProjectManager.ExportChildren.Remove(grifFile);
                seriesProjectManager.ExportChildren.Insert(Indexof + 1, grifFile);
                grifFile.IsSelected = true;
                Indexof++;
            }

        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (Indexof < 0 || Indexof > seriesProjectManager.ExportChildren.Count-1)
                return;

            if (seriesProjectManager.ExportChildren[Indexof] is GrifFile grifFile)
            {
                seriesProjectManager.ExportChildren.Remove(grifFile);
                seriesProjectManager.ExportChildren.Insert(seriesProjectManager.ExportChildren.Count, grifFile);
                grifFile.IsSelected = true;
                Indexof = seriesProjectManager.ExportChildren.Count-1;
            }
        }

        private void StackPanel_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            StackPanel stackPanel = sender as StackPanel;
            if (stackPanel.Tag is GrifFile grifFile)
                Indexof = seriesProjectManager.ExportChildren.IndexOf(grifFile);
            else if (stackPanel.Tag is SeriesProjectExportLine seriesProjectExportLine)
            {
                Indexof = seriesProjectManager.ExportChildren.IndexOf(seriesProjectExportLine);
                if (Indexof > 0)
                {
                    if (seriesProjectManager.ExportChildren[Indexof-1] is GrifFile grifFile1)
                    {
                        Indexof = Indexof - 1;
                        grifFile1.IsSelected = true;
                    }
                    else
                    {
                        seriesProjectManager.ExportChildren.Remove(seriesProjectExportLine);
                    }
                }
            }
        }


        private void Button_Click_01(object sender, RoutedEventArgs e)
        {
            CheckEendControl(seriesProjectManager);
        }

        public void CheckEendControl(BaseObject baseObject,bool? IsCheckNot =true,bool Add = true)
        {
            foreach (var item in baseObject.VisualChildren)
            {
                if (item is GrifFile grifFile && (IsCheckNot ==true || grifFile.IsCheck))
                {
                    if (Add)
                    {
                        if (!seriesProjectManager.ExportChildren.Contains(grifFile))
                            seriesProjectManager.ExportChildren.Add(grifFile);
                    }
                    else
                    {
                        if (seriesProjectManager.ExportChildren.Contains(grifFile))
                            seriesProjectManager.ExportChildren.Remove(grifFile);
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
            CheckEendControl(seriesProjectManager, false);
        }

        private void Button_Click_03(object sender, RoutedEventArgs e)
        {
            CheckEendControl(seriesProjectManager, false,false);
        }
        private void Button_Click_04(object sender, RoutedEventArgs e)
        {
            seriesProjectManager.ExportChildren.Clear();
        }

        int Indexof1 = 0;
        private void StackPanel1_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            StackPanel stackPanel = sender as StackPanel;
            if (stackPanel.Tag is BaseObject baseObject)
            {
                Indexof1 = seriesProjectManager.ExportChildren.IndexOf(baseObject);
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
                Indexof = seriesProjectManager.VisualChildren.IndexOf(grifFile);
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
            if (checkBox.Tag is GrifFile grifFile)
            {
                if (grifFile.Parent is ProjectFolder projectFolder)
                {
                    if (projectFolder.IsCheck ==true&& grifFile.IsCheck == false)
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


    }


}
