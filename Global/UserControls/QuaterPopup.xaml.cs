using System;
using Lambda;
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
    /// QuaterPopup.xaml 的交互逻辑
    /// </summary>
    public partial class QuaterPopup : UserControl
    {
        public QuaterPopup()
        {
            InitializeComponent();
        }

        private void RadioButton_checked(object sender, RoutedEventArgs e)
        {
            ////MessageBox.Show("1111");
            //if (e.OriginalSource  is RadioButton radio)
            //{
            //    if( radio.Name == "dual")
            //    {
            //        LambdaControl.Trigger("QUATER_CLICKED0", this, new Dictionary<string, object> { { "mode", 2 } });
            //    }
            //    else if(radio.Name == "four")
            //    {
            //        LambdaControl.Trigger("QUATER_CLICKED0", this, new Dictionary<string, object> { { "mode", 4 } });
            //    }
            //    else if( radio.Name == "six")
            //    {
            //        LambdaControl.Trigger("QUATER_CLICKED0", this, new Dictionary<string, object> { { "mode", 6 } });
            //    }
            //}
        }
    }
}
