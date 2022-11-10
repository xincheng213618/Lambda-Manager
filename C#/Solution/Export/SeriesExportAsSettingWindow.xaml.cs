using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using ThemeManager.Controls;
using Tool;
using XSolution;




namespace Solution
{
    /// <summary>
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class SeriesExportAsSettingWindow : BaseWindow
    {
        public SeriesProjectManager seriesProjectManager;

        public SeriesExportAsSettingWindow(SeriesProjectManager seriesProjectManager)
        {
            this.seriesProjectManager = seriesProjectManager;
            InitializeComponent();
            TextBock1.Text = seriesProjectManager.Name;
            SeriesExportTreeView1.ItemsSource = this.seriesProjectManager.VisualChildren;
            SeriesExportTreeView2.ItemsSource = this.seriesProjectManager.ExportChildren;
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
            }



        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (Indexof <= 0)
                return;

            BaseObject baseObject = seriesProjectManager.ExportChildren[Indexof - 1];
            seriesProjectManager.ExportChildren.Remove(baseObject);
            seriesProjectManager.ExportChildren.Insert(Indexof, baseObject);
            Indexof--;

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (Indexof + 1 >= seriesProjectManager.ExportChildren.Count)
                return;
            BaseObject baseObject = seriesProjectManager.ExportChildren[Indexof + 1];
            seriesProjectManager.ExportChildren.Remove(baseObject);
            seriesProjectManager.ExportChildren.Insert(Indexof, baseObject);
            Indexof++;
        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            BaseObject baseObject = seriesProjectManager.ExportChildren[Indexof];
            seriesProjectManager.ExportChildren.Remove(baseObject);
            seriesProjectManager.ExportChildren.Add(baseObject);
        }

        private void StackPanel_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            StackPanel stackPanel = sender as StackPanel;
            if (stackPanel.Tag is BaseObject baseObject)
                Indexof = seriesProjectManager.ExportChildren.IndexOf(baseObject);
        }


        private void Button_Click_01(object sender, RoutedEventArgs e)
        {
            foreach (var item in seriesProjectManager.VisualChildren)
            {
                if (item is ProjectFolder projectFolder)
                {
                    CheckEend(projectFolder);
                }
            }
        }

        public void CheckEend(ProjectFolder projectFolder)
        {
            foreach (var item in projectFolder.VisualChildren)
            {
                if (item is GrifFile grifFile)
                {
                    if (!seriesProjectManager.ExportChildren.Contains(grifFile))
                        seriesProjectManager.ExportChildren.Add(grifFile);
                }
                else if (item is ProjectFolder projectFolder1)
                {
                    CheckEend(projectFolder1);
                }
            }
        }


        private void Button_Click_02(object sender, RoutedEventArgs e)
        {
            if (baseObject1 != null)
            {
                seriesProjectManager.ExportChildren.Add(baseObject1);
                baseObject1 = null;
            }
        }
        private void Button_Click_03(object sender, RoutedEventArgs e)
        {
            seriesProjectManager.ExportChildren.RemoveAt(Indexof);
        }
        private void Button_Click_04(object sender, RoutedEventArgs e)
        {
            seriesProjectManager.ExportChildren.Clear();
        }

        int Indexof1 = 0;
        BaseObject baseObject1 = null;
        private void StackPanel1_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            StackPanel stackPanel = sender as StackPanel;
            if (stackPanel.Tag is BaseObject baseObject)
            {
                baseObject1 = baseObject;
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
                baseObject1 = grifFile;
                Indexof = seriesProjectManager.VisualChildren.IndexOf(grifFile);
            }
        }

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox.Tag is ProjectFolder projectFolder)
            {
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
            if (checkBox.Tag is ProjectFolder projectFolder)
            {
                CheckEend(projectFolder, projectFolder.IsCheck);

            }
        }
    }


}
