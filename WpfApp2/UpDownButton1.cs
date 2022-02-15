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
        TextBlock? textBox;

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            textBox =(TextBlock)Template.FindName("txt_NamberChange", this);
            Button? btn_ClickUp = (Button)Template.FindName("btn_ClickUp", this);
            btn_ClickUp.Click += Btn_ClickUp_Click;

            Button? btn_ClickDown = (Button)Template.FindName("btn_ClickDown", this);
            btn_ClickDown.Click += Btn_ClickDown_Click;
            //textBox.TextChanged += txt_NamberChange_TextChanged;
        }


        public double Frequency
        {
            get { return (double)GetValue(FrequencyProperty); }
            set { SetValue(FrequencyProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Frequency.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FrequencyProperty =
            DependencyProperty.Register("Frequency", typeof(double), typeof(UpDownButton1), new PropertyMetadata(0.1));



        public int Precision
        {
            get {

                return (int)GetValue(PrecisionProperty); 
            }
            set 
            {
                SetValue(PrecisionProperty, value);
            }
        }

        // Using a DependencyProperty as the backing store for Precision.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PrecisionProperty =
            DependencyProperty.Register("Precision", typeof(int), typeof(UpDownButton1), new PropertyMetadata(2));



        private void Btn_ClickUp_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = (double.Parse(textBox.Text) + Frequency).ToString($"F{Precision}"); 
        }

        private void Btn_ClickDown_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = (double.Parse(textBox.Text) - Frequency).ToString($"F{Precision}");

        }
    }
}
