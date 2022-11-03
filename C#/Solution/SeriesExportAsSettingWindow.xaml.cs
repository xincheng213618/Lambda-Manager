using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ThemeManager.Controls;
using XSolution;

namespace Solution
{
    /// <summary>
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class SeriesExportAsSettingWindow : BaseWindow
    {
        public SeriesProjectManager seriesProjectManager;

        public SeriesExportAsSettingWindow()
        {
            InitializeComponent();
        }
        int Indexof = 0;
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Indexof <= 0)
                return;

            BaseObject baseObject = seriesProjectManager.ExportChildren[Indexof - 1];
            seriesProjectManager.ExportChildren.Remove(baseObject);
            seriesProjectManager.ExportChildren.Insert(Indexof, baseObject);
            Indexof--;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            BaseObject baseObject = seriesProjectManager.ExportChildren[Indexof + 1];
            seriesProjectManager.ExportChildren.Remove(baseObject);
            seriesProjectManager.ExportChildren.Insert(Indexof, baseObject);
            Indexof++;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            seriesProjectManager.ExportChildren.Insert(Indexof, new SeriesProjectExportLine());
            Indexof--;

        }

        private void StackPanel_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            StackPanel stackPanel = sender as StackPanel;
            if (stackPanel.Tag is BaseObject baseObject)
                Indexof = seriesProjectManager.ExportChildren.IndexOf(baseObject);
        }

        private void Button_Click_01(object sender, RoutedEventArgs e)
        {
            seriesProjectManager.ExportChildren.Add(baseObject1);
        }

        private void Button_Click_02(object sender, RoutedEventArgs e)
        {
            seriesProjectManager.ExportChildren.RemoveAt(Indexof);
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
    }
}
