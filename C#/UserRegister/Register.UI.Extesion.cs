using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace UserRegister
{
    public  class  Register
    {
       

        public static void DisableAll()
        {

            Window mainwin = Application.Current.MainWindow;
            Grid stageConfig = (Grid)mainwin.FindName("stageConfig");
            Grid stageAcquisition = (Grid)mainwin.FindName("stageAcquisition");
            Grid AncestorGrid = (Grid)mainwin.Content;
            Grid grid1 = (Grid)AncestorGrid.Children[0];
            StackPanel stackPanel = (StackPanel)grid1.Children[1];
            RadioButton config = (RadioButton)stackPanel.Children[0];
            RadioButton acquire = (RadioButton)stackPanel.Children[1];
            stageConfig.IsEnabled = false;
            stageAcquisition.IsEnabled = false;
            config.IsEnabled = false;
            acquire.IsEnabled = false;


        }
        public static void EnableAll()
        {

            Window mainwin = Application.Current.MainWindow;
            Grid stageConfig = (Grid)mainwin.FindName("stageConfig");
            Grid stageAcquisition = (Grid)mainwin.FindName("stageAcquisition");
            Grid AncestorGrid = (Grid)mainwin.Content;
            Grid grid1 = (Grid)AncestorGrid.Children[0];
            StackPanel stackPanel = (StackPanel)grid1.Children[1];
            RadioButton config = (RadioButton)stackPanel.Children[0];
            RadioButton acquire = (RadioButton)stackPanel.Children[1];
            stageConfig.IsEnabled = true;
            stageAcquisition.IsEnabled = true;
            config.IsEnabled = true;
            acquire.IsEnabled = true;


        }



    }
}
