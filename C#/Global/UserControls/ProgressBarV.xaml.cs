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
    /// ProgressBarV.xaml 的交互逻辑
    /// </summary>
    public partial class ProgressBarV : UserControl
    {
        public ProgressBarV()
        {
            InitializeComponent();
        }
        //private void Slider_DragCompleted(object sender, System.Windows.Controls.Primitives.DragCompletedEventArgs e)
        //{
        //    LambdaControl.Trigger("TRIGGER_PROGRESSBAR_Z", this, new Dictionary<string, object> { { "CurrentZ", (int)Math.Floor(SliderV.LowerValue) } });
        //}
        int before = 0;
        bool isActive = false;
        private void RangeSlider_LowerValueChanged(object sender, RoutedEventArgs e)
        {
            int current = (int)Math.Floor(SliderV.LowerValue);
            int value = Math.Abs(before - current);
            if (value > 0 & isActive)
            {
                LambdaControl.Trigger("TRIGGER_PROGRESSBAR_Z", this, new Dictionary<string, object> { { "CurrentZ", (int)Math.Floor(SliderV.LowerValue) } });
            }
            before = (int)Math.Floor(SliderV.LowerValue);
        }

        private void P1_DragCompleted(object sender, System.Windows.Controls.Primitives.DragCompletedEventArgs e)
        {
            isActive = false;
           // LambdaControl.Trigger("TRIGGER_PROGRESSBAR", this, new Dictionary<string, object> { { "Current", (int)Math.Floor(pro.LowerValue) } });
        }

        private void drag_start(object sender, System.Windows.Controls.Primitives.DragStartedEventArgs e)
        {
            isActive = true;
        }

    }
}
