using MenuISCameraSetting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Initialized(object sender, EventArgs e)
        {
            this.leftView.Children.Clear();
            List<UICofig> list = new List<UICofig>();
            list.Add(new UICofig() { path = "ConfigDPCMode.dll", name = "DPCMode" });
            list.Add(new UICofig() { path = "ConfigDeck.dll", name = "BaseDeck" });
            list.Add(new UICofig() { path = "ConfigSpot.dll", name = "SampleSpot" });
            list.Add(new UICofig() { path = "ConfigDOFMode.dll", name = "DOFMode" });
            list.Add(new UICofig() { path = "ConfigCollectInterval.dll", name = "CollectInterval" });

            foreach (var item in list)
            {
                Assembly assembly = Assembly.LoadFile(Environment.CurrentDirectory + "\\" + item.path);
                Control control = (Control)assembly.CreateInstance($"{item.path.Replace(".dll", "")}.{item.name}");
                leftView.Children.Add(control);
            }




        }
        private BrushConverter  brushConverter = new BrushConverter();

        List<Button> buttons = new List<Button>();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RadioButton button = (RadioButton)sender;

        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }


        private void Button_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DockPanel_Click(object sender, RoutedEventArgs e)
        {

        }
        
        private void ToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton toggleButton = (RadioButton)sender;
            toggleButton.Foreground = (Brush)brushConverter.ConvertFrom("#2E86E1");
            toggleButton.FontWeight = FontWeights.Bold;
        }

        private void ToggleButton_Unchecked(object sender, RoutedEventArgs e)
        {
            RadioButton toggleButton = (RadioButton)sender;
            toggleButton.Foreground = Brushes.White;
            toggleButton.FontWeight = FontWeights.Normal;
        }

        private void file_Click(object sender, RoutedEventArgs e)
        {
            CameraDialog  cameraDialog = new CameraDialog();
            cameraDialog.WindowStartupLocation = WindowStartupLocation.CenterScreen;    
            cameraDialog.Show();
        }
    }

    public class UICofig
    {
        public string path = "";
        public string name = "";   
    }
}
