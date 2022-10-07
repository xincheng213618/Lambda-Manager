using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Global;

namespace Global.UserControls.DrawVisual
{
    /// <summary>
    /// DimenPreoperty.xaml 的交互逻辑
    /// </summary>
    public partial class DimenPreoperty : UserControl
    {
        public DimenPreoperty()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
            if (ShapeCombo.SelectedIndex ==2|| ShapeCombo.SelectedIndex == 3||ShapeCombo.SelectedIndex ==4||ShapeCombo.SelectedIndex == 5)
            {   if (dimWrap.Visibility == Visibility.Visible)
                {
                    return;
                }
                labelWrap.Visibility = Visibility.Visible;
                labelCheck.IsChecked = true;
            }
            else
            {
                labelCheck.IsChecked = false;
                labelWrap.Visibility = Visibility.Collapsed;
            }
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void listview_Loaded(object sender, RoutedEventArgs e)
        {
            listview.ItemsSource = DrawInkMethod.StrokesCollection;
            DrawInkMethod.StrokesCollection.CollectionChanged += delegate
            {
                if (DrawInkMethod.StrokesCollection.Count>0)
                {
                    objectManageGrid.Visibility = Visibility.Visible;
                }
                else
                {
                    objectManageGrid.Visibility = Visibility.Collapsed;
                }
            };

        }

        private void _colorPicker_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (expander.IsExpanded == false)
            {
                expander.IsExpanded = true;
            }
        }
    }
}
