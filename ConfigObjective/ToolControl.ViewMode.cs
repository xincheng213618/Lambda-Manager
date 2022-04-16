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
        public void ViewMode_Initialized()
        {
            var config = WindowData.Config;
            //MessageBox.Show(config.ToJson());

        }
    }
}
