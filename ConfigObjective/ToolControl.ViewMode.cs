using Lambda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ConfigObjective
{
    public partial class ToolControl
    {
        public void ViewMode_Initialized()
        {
            var config = WindowData.Config;
            //MessageBox.Show(config.ToJson());
        }

        private void Button301_Click(object sender, RoutedEventArgs e)
        {
            LambdaControl.Trigger("IMAGE_MODE_RESET", this, new Dictionary<string, object>() { });
        }

        private void Button302_Click(object sender, RoutedEventArgs e)
        {
            LambdaControl.Trigger("IMAGE_MODE_CLOSE", this, new Dictionary<string, object>() { });
        }

        private void ViewMode_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            string s = radioButton.Tag.ToString();

            if (s != null)
            {
                ViewMode = int.Parse(s);
                Dictionary<string, object> data = new() { { "mode", ViewMode } };
                LambdaControl.Trigger("IMAGING_MODE_SETTING", this, data);
            }
        }
    }
}
