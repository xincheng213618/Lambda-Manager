using Global.Common.Controls;
using Global.Common.Extensions;
using Global.Mode;
using Global.Mode.Config;
using Global.UserControls.SeriesMap;
using Lambda;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using ConfigBottomView;
using System.Runtime.InteropServices;
using System.IO;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using System.Drawing;
using Microsoft.Win32;
using System.Text;

namespace Global
{

    /// <summary>
    /// 注册AddEventHandler事件
    /// </summary>
    public partial class WindowData
    {
        public bool ACQUIRE { get; set; } = false;
        public bool ALIVE { get; set; } = false;
        private void AddEventHandler()
        {
            LambdaControl.AddLambdaEventHandler("STOP_ALIVE", STOP_ALIVE, false);
            LambdaControl.AddLambdaEventHandler("START_ALIVE", START_ALIVE, false);
            LambdaControl.AddLambdaEventHandler("STOP_ACQUIRE", STOP_ACQUIRE, false);
            LambdaControl.AddLambdaEventHandler("START_ACQUIRE", START_ACQUIRE, false);
 
        }






        /// <summary>


        // START ALIVE
        private bool STOP_ALIVE(object sender, EventArgs e)
        {
            ALIVE = false;
            return true;
        }


        private bool START_ALIVE(object sender, EventArgs e)
        {
            ALIVE = true;
            return true;
            
        }
        // start acquire
        private bool STOP_ACQUIRE(object sender, EventArgs e)
        {
            ACQUIRE = true;
            return true;

        }





        private bool START_ACQUIRE(object sender, EventArgs e)
        {
            ACQUIRE = false;
            return true;
          
        }








       

        







  
    }
}
