using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp2
{
    public class UpDownButton1:UserControl
    {
        static UpDownButton1()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(UpDownButton1), new FrameworkPropertyMetadata(typeof(UpDownButton1)));
        }
        TextBlock? txt_NamberChange;

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            txt_NamberChange = (TextBlock)Template.FindName("txt_NamberChange", this);

            Button? btn_ClickUp = (Button)Template.FindName("btn_ClickUp", this);
            btn_ClickUp.Click += Btn_ClickUp_Click;

            Button? btn_ClickDown = (Button)Template.FindName("btn_ClickDown", this);
            btn_ClickDown.Click += Btn_ClickDown_Click;

            Update();
        }


        private List<string>? comboxlist= new List<string>() {""};
        private int SelectedIndex = 0;


        public void SetList(List<string> list)
        {
            comboxlist = list;
        }

        private void Btn_ClickUp_Click(object sender, RoutedEventArgs e)
        {
            SelectedIndex = ++SelectedIndex % comboxlist.Count;
            Update();
        }

        private void Update()
        {
            txt_NamberChange.Text = comboxlist[SelectedIndex];

        }


        private void Btn_ClickDown_Click(object sender, RoutedEventArgs e)
        {
            SelectedIndex = --SelectedIndex % comboxlist.Count;
            SelectedIndex = SelectedIndex < 0 ? comboxlist.Count - 1 : SelectedIndex;
            Update();
        }
    }
}
