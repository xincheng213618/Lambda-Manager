using Lambda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ConfigObjective
{
    public partial class ToolControl
    {
        private void Stage_Reset_Click(object sender, RoutedEventArgs e)
        {
            LambdaControl.Trigger("STAGE_SETTING_RESET", this, new Dictionary<string, object> { });
        }


    }
}
