using Lambda;
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
using ThemeManager.Controls;

namespace Wizard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : BaseWindow
    {
        public List<string> ResourceDictionaryDark = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
            ResourceDictionaryDark.Add("/ThemeManager;component/Styles/Dark.xaml");
            ResourceDictionaryDark.Add("/ThemeManager;component/Styles/styles.xaml");

            foreach (var item in ResourceDictionaryDark)
            {
                ResourceDictionary dictionary = Application.LoadComponent(new Uri(item, UriKind.Relative)) as ResourceDictionary;
                Application.Current.Resources.MergedDictionaries.Add(dictionary);
            }
        }
        public MainWindow(string Name)
        {
            InitializeComponent();
        }

        private void BaseWindow_Initialized(object sender, EventArgs e)
        {
            Dispatcher.BeginInvoke(new Action(() => frame.Navigate(new Page1(this))));
            LambdaControl.Log(new Message() { Severity = Severity.INFO, Text = "启动配置向导" });
        }
    }
}
