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

namespace Global.UserControls
{
    /// <summary>
    /// ProgressBar.xaml 的交互逻辑
    /// </summary>
    public partial class ProgressBar1 : UserControl
    {
        public ProgressBar1()
        {
            InitializeComponent();
           // (this.Content as FrameworkElement).DataContext = new ProgressBarModel();
            
        }
        int before=0;
        bool isActive = false;
        private void RangeSlider_LowerValueChanged(object sender, RoutedEventArgs e)
        {
            int current = (int)Math.Floor(pro.LowerValue);
            int value = Math.Abs(before - current);
            if (value > 0& isActive)
            {
                LambdaControl.Trigger("TRIGGER_PROGRESSBAR", this, new Dictionary<string, object> { { "Current", (int)Math.Floor(pro.LowerValue) } });
            }
            before = (int)Math.Floor(pro.LowerValue);
        }

        private void P1_DragCompleted(object sender, System.Windows.Controls.Primitives.DragCompletedEventArgs e)
        {
            isActive = false;
          //  LambdaControl.Trigger("TRIGGER_PROGRESSBAR", this, new Dictionary<string, object> { { "Current", (int)Math.Floor(pro.LowerValue) } });
        }

        private void drag_start(object sender, System.Windows.Controls.Primitives.DragStartedEventArgs e)
        {
            isActive = true;
        }


    }
}
