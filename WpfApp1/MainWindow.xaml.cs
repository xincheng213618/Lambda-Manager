using System;
using System.Collections.Generic;
using System.Linq;
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
        private BrushConverter  brushConverter = new BrushConverter();

        List<Button> buttons = new List<Button>();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RadioButton button = (RadioButton)sender;
            switch (button.Tag.ToString())
            {
                case "0":
                case "1":
                case "2":
                    Grid2.Visibility = Visibility.Visible;
                    Grid3.Visibility = Visibility.Collapsed;
                    break;
                case "3":
                    Grid2.Visibility = Visibility.Visible;
                    Grid3.Visibility = Visibility.Visible;
                    break;
                default:
                    break;
            }

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
    }
}
