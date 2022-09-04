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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ConfigSetting
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class ToolSetting : UserControl
    {
        public ToolSetting()
        {
            InitializeComponent();
        }

        bool IsFirstLoad = true;
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            if (IsFirstLoad && this.Parent is StackPanel stackPanel1 && stackPanel1.Parent is Viewbox viewbox1 && viewbox1.Parent is ScrollViewer scrollViewer1)
            {
                stackPanel1.Children.Remove(this);

                StackPanel stackPanel = new StackPanel() { Name = "configView", Margin = new Thickness(2, 2, 2, 0) };
                stackPanel.HorizontalAlignment = HorizontalAlignment.Stretch;
                stackPanel.Children.Add(this);

                Viewbox viewbox = new Viewbox() { VerticalAlignment = VerticalAlignment.Top };
                viewbox.Child = stackPanel;
                scrollViewer1.Content = viewbox;
                IsFirstLoad = false;
            }
        }

        private void UserControl_Initialized(object sender, EventArgs e)
        {
            ResourceDictionary dictionary0 = Application.LoadComponent(new Uri("/ThemeManager;component/Styles/Dark.xaml", UriKind.Relative)) as ResourceDictionary;
            Application.Current.Resources.MergedDictionaries.Add(dictionary0);
            ResourceDictionary dictionary = Application.LoadComponent(new Uri("/ThemeManager;component/Styles/styles.xaml", UriKind.Relative)) as ResourceDictionary;
            Application.Current.Resources.MergedDictionaries.Add(dictionary);
            ResourceDictionary dictionary1 = Application.LoadComponent(new Uri("/ThemeManager;component/themes/Dark/Theme.xaml", UriKind.Relative)) as ResourceDictionary;
            Application.Current.Resources.MergedDictionaries.Add(dictionary1);
            ResourceDictionary dictionary2 = Application.LoadComponent(new Uri("/ThemeManager;component/themes/Base/Menu.xaml", UriKind.Relative)) as ResourceDictionary;
            Application.Current.Resources.MergedDictionaries.Add(dictionary2);
        }
        bool IS = false;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            IS = !IS;
            if (IS)
            {
                ResourceDictionary dictionary0 = Application.LoadComponent(new Uri("/ThemeManager;component/Styles/White.xaml", UriKind.Relative)) as ResourceDictionary;
                Application.Current.Resources.MergedDictionaries.Add(dictionary0);
                ResourceDictionary dictionary = Application.LoadComponent(new Uri("/ThemeManager;component/Styles/styles.xaml", UriKind.Relative)) as ResourceDictionary;
                Application.Current.Resources.MergedDictionaries.Add(dictionary);
                ResourceDictionary dictionary1 = Application.LoadComponent(new Uri("/ThemeManager;component/themes/White/Theme.xaml", UriKind.Relative)) as ResourceDictionary;
                Application.Current.Resources.MergedDictionaries.Add(dictionary1);
                ResourceDictionary dictionary2 = Application.LoadComponent(new Uri("/ThemeManager;component/themes/Base/Menu.xaml", UriKind.Relative)) as ResourceDictionary;
                Application.Current.Resources.MergedDictionaries.Add(dictionary2);
            }
            else
            {
                ResourceDictionary dictionary0 = Application.LoadComponent(new Uri("/ThemeManager;component/Styles/Dark.xaml", UriKind.Relative)) as ResourceDictionary;
                Application.Current.Resources.MergedDictionaries.Add(dictionary0);
                ResourceDictionary dictionary = Application.LoadComponent(new Uri("/ThemeManager;component/Styles/styles.xaml", UriKind.Relative)) as ResourceDictionary;
                Application.Current.Resources.MergedDictionaries.Add(dictionary);
                ResourceDictionary dictionary1 = Application.LoadComponent(new Uri("/ThemeManager;component/themes/Dark/Theme.xaml", UriKind.Relative)) as ResourceDictionary;
                Application.Current.Resources.MergedDictionaries.Add(dictionary1);
                ResourceDictionary dictionary2 = Application.LoadComponent(new Uri("/ThemeManager;component/themes/Base/Menu.xaml", UriKind.Relative)) as ResourceDictionary;
                Application.Current.Resources.MergedDictionaries.Add(dictionary2);
            }

        }
    }
}
