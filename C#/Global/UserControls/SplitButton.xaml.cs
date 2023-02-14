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

namespace Global.UserControls.DrawVisual
{
    /// <summary>
    /// SplitButton.xaml 的交互逻辑
    /// </summary>
    public partial class SplitButton : UserControl
    {
        public SplitButton()
        {
            InitializeComponent();
        }

        private void Snap_click(object sender, RoutedEventArgs e)
        {

            
        }

        private void DPC_click(object sender, RoutedEventArgs e)
        {
            LambdaControl.Trigger("SNAPSHOT_MODE", this, new Dictionary<string, object> { });
            Split_Button.IsOpen = false;
        }
    }
}
