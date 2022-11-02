using Global.Hardware;
using System;
using System.Windows;
using System.Windows.Controls;

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

        public ExposureViewMode ExposureViewMode = new ExposureViewMode();
        private void UserControl_Initialized(object sender, EventArgs e)
        {
        }

        public int index = 0;

        private void btn_ClickUp_Click(object sender, RoutedEventArgs e)
        {
            index = ExposureViewMode.Index;
            if(index== ExposureViewMode.ExposureInfos.Count-1)
            {
               
            }
            else
            {
                index = ++index % ExposureViewMode.ExposureInfos.Count;
                
            }
            ExposureViewMode.Index = index;


        }

        private void btn_ClickDown_Click(object sender, RoutedEventArgs e)
        {
            index = ExposureViewMode.Index;
            index = --index % ExposureViewMode.ExposureInfos.Count;
            index = index <= 0 ? 0 : index;
            ExposureViewMode.Index = index;
        }


    }
}
