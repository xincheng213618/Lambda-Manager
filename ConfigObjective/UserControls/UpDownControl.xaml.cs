using Global;
using Global.Common;
using Global.Hardware;
using Mode;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
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

namespace ConfigObjective
{
    /// <summary>
    /// UpDownControl.xaml 的交互逻辑
    /// </summary>
    public partial class UpDownControl : UserControl 
    {
        public UpDownControl()
        {
            InitializeComponent();
        }

        public ExposureViewMode ExposureViewMode { get; set; }
        private void UserControl_Initialized(object sender, EventArgs e)
        {
            ExposureViewMode = WindowData.GetInstance().ExposureViewMode;
            txt_NamberChange.DataContext = ExposureViewMode;
        }

        public int index = 0;

        private void btn_ClickUp_Click(object sender, RoutedEventArgs e)
        {
            index = ExposureViewMode.Index;
            index = ++index % ExposureViewMode.ExposureInfos.Count;
            ExposureViewMode.Index = index;
        }

        private void btn_ClickDown_Click(object sender, RoutedEventArgs e)
        {
            index = ExposureViewMode.Index;
            index = --index % ExposureViewMode.ExposureInfos.Count;
            index = index < 0 ? ExposureViewMode.ExposureInfos.Count - 1 : index;
            ExposureViewMode.Index = index;
        }


    }
}
