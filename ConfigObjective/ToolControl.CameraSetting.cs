using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Lambda;

namespace ConfigObjective
{
    public partial class ToolControl
    {
        public void CameraSetting_Initialized()
        {

        }
        private void Button201_Click(object sender, RoutedEventArgs e)
        {
            LambdaControl.Trigger("CAMERA_SETTING_RESET", this, new Dictionary<string, object>() { });
        }

        private void Button211_Click(object sender, RoutedEventArgs e)
        {
            LambdaControl.Trigger("CAMERA_SETTING_WHITE_BALANCE", this, new Dictionary<string, object> { });
        }

        private void ToggleButton210_Click(object sender, RoutedEventArgs e)
        {
            LambdaControl.Trigger("CAMERA_SETTING_EXPOSURE_AUTO", this, new Dictionary<string, object>() { { "auto", ToggleButton210.IsChecked } });
        }

    }
}
