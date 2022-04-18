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
            LambdaControl.Trigger("CAMERA_SETTING_RESET ", this, new Dictionary<string, object>() { });
        }

    }
}
