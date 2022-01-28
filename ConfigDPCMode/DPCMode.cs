using Lambda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ConfigDPCMode
{
    /// <summary>
    /// Follow steps 1a or 1b and then 2 to use this custom control in a XAML file.
    ///
    /// Step 1a) Using this custom control in a XAML file that exists in the current project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:ConfigDPCMode"
    ///
    ///
    /// Step 1b) Using this custom control in a XAML file that exists in a different project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:ConfigDPCMode;assembly=ConfigDPCMode"
    ///
    /// You will also need to add a project reference from the project where the XAML file lives
    /// to this project and Rebuild to avoid compilation errors:
    ///
    ///     Right click on the target project in the Solution Explorer and
    ///     "Add Reference"->"Projects"->[Select this project]
    ///
    ///
    /// Step 2)
    /// Go ahead and use your control in the XAML file.
    ///
    ///     <MyNamespace:CustomControl1/>
    ///
    /// </summary>
    [TemplatePart(Name = "Button1", Type = typeof(ToggleButton))]
    [TemplatePart(Name = "Button2", Type = typeof(ToggleButton))]
    [TemplatePart(Name = "Button3", Type = typeof(ToggleButton))]
    [TemplatePart(Name = "Button4", Type = typeof(ToggleButton))]
    public class DPCMode : LambdaControl
    {
        private readonly ToggleButton[] buttons = new ToggleButton[4];

        static DPCMode()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(DPCMode), new FrameworkPropertyMetadata(typeof(DPCMode)));
        }
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            StackPanel StackPanel0 = (StackPanel)Template.FindName("StackPanel0", this);
            StackPanel StackPanel1 = (StackPanel)Template.FindName("StackPanel1", this);
            StackPanel StackPanel2 = (StackPanel)Template.FindName("StackPanel2", this);
            StackPanel StackPanel3 = (StackPanel)Template.FindName("StackPanel3", this);
            StackPanel StackPanel4 = (StackPanel)Template.FindName("StackPanel4", this);

            



            Label label1 = (Label)Template.FindName("label1", this);
            Label label2 = (Label)Template.FindName("label2", this);

            StackPanel StackContent = (StackPanel)Template.FindName("StackContent", this);
            Button buttonheader1 = (Button)Template.FindName("buttonheader1", this);
            Path Path1 = (Path)Template.FindName("Path1", this);
            Path Path2 = (Path)Template.FindName("Path2", this);

            buttonheader1.Click += delegate
            {
                if (StackContent.Visibility == Visibility.Visible)
                {
                    StackContent.Visibility = Visibility.Collapsed;
                    Path1.Visibility = Visibility.Collapsed;
                    Path2.Visibility = Visibility.Visible;
                }
                else
                {
                    StackContent.Visibility = Visibility.Visible;
                    Path1.Visibility = Visibility.Visible;
                    Path2.Visibility = Visibility.Collapsed;
                }
            }; 

            RadioButton radioButton1 = (RadioButton)Template.FindName("Button1", this);
            RadioButton radioButton2 = (RadioButton)Template.FindName("Button2", this);
            RadioButton radioButton3 = (RadioButton)Template.FindName("Button3", this);
            RadioButton radioButton4 = (RadioButton)Template.FindName("Button4", this);
            radioButton1.Checked += RadioButton_Checked;
            radioButton1.Unchecked += RadioButton_Unchecked;

            radioButton2.Checked += RadioButton_Checked;
            radioButton2.Unchecked += RadioButton_Unchecked;

            radioButton3.Checked += RadioButton_Checked;
            radioButton3.Unchecked += RadioButton_Unchecked;

            radioButton4.Checked += RadioButton_Checked;
            radioButton4.Unchecked += RadioButton_Unchecked;

            radioButton1.IsChecked = true;
            if (Template.FindName("Button1", this) is RadioButton btn1)
            {
                btn1.Click += delegate
                {

                    StackPanel0.Visibility = Visibility.Visible;
                    StackPanel1.Visibility = Visibility.Collapsed;
                    StackPanel2.Visibility = Visibility.Collapsed;
                    StackPanel3.Visibility = Visibility.Collapsed;
                    StackPanel4.Visibility = Visibility.Collapsed;

                    Dictionary<string, object> data = new() { { "dpc", 0 } };
                    Trigger("DPC_MODE_CHANGED", btn1, data);
                };
                buttons[0] = btn1;
            }
            if (Template.FindName("Button2", this) is RadioButton btn2)
            {
                btn2.Click += delegate
                {
                    StackPanel0.Visibility = Visibility.Collapsed;
                    StackPanel1.Visibility = Visibility.Visible;
                    StackPanel2.Visibility = Visibility.Collapsed;
                    StackPanel3.Visibility = Visibility.Collapsed;
                    StackPanel4.Visibility = Visibility.Collapsed;

                    Dictionary<string, object> data = new() { { "dpc", 1 } };
                    Trigger("DPC_MODE_CHANGED", btn2, data);
                };
                buttons[1] = btn2;
            }
            if (Template.FindName("Button3", this) is RadioButton btn3)
            {
                btn3.Click += delegate
                {
                    StackPanel0.Visibility = Visibility.Collapsed;
                    StackPanel1.Visibility = Visibility.Collapsed;
                    StackPanel2.Visibility = Visibility.Visible;
                    StackPanel3.Visibility = Visibility.Collapsed;
                    StackPanel4.Visibility = Visibility.Collapsed;

                    Dictionary<string, object> data = new() { { "dpc", 2 } };
                    Trigger("DPC_MODE_CHANGED", btn3, data);
                };
                buttons[2] = btn3;
            }
            if (Template.FindName("Button4", this) is RadioButton btn4)
            {
                btn4.Click += delegate
                {

                    StackPanel0.Visibility = Visibility.Collapsed;
                    StackPanel1.Visibility = Visibility.Collapsed;
                    StackPanel2.Visibility = Visibility.Collapsed;
                    StackPanel3.Visibility = Visibility.Visible;
                    StackPanel4.Visibility = Visibility.Collapsed;
                    Dictionary<string, object> data = new() { { "dpc", 3 } };
                    Trigger("DPC_MODE_CHANGED", btn4, data);
                };
                buttons[3] = btn4;
            }
            if (Template.FindName("Button5", this) is RadioButton btn5)
            {
                btn5.Click += delegate
                {
                    StackPanel0.Visibility = Visibility.Collapsed;
                    StackPanel1.Visibility = Visibility.Collapsed;
                    StackPanel2.Visibility = Visibility.Collapsed;
                    StackPanel3.Visibility = Visibility.Collapsed;
                    StackPanel4.Visibility = Visibility.Visible;

                    Dictionary<string, object> data = new() { { "dpc", 4 } };
                    Trigger("DPC_MODE_CHANGED", btn5, data);
                };
                buttons[3] = btn5;
            }

            slider1 = (Slider)Template.FindName("slider1",this);
            slider2 = (Slider)Template.FindName("slider2",this);
            slider3 = (Slider)Template.FindName("slider3", this);
            slider4 = (Slider)Template.FindName("slider4", this);
            slider5 = (Slider)Template.FindName("slider5", this);
            slider6 = (Slider)Template.FindName("slider6", this);
            slider7 = (Slider)Template.FindName("slider7", this);
            slider8 = (Slider)Template.FindName("slider8", this);
            slider9 = (Slider)Template.FindName("slider9", this);
            slider10 = (Slider)Template.FindName("slider10", this);
            slider11 = (Slider)Template.FindName("slider11", this);
            slider12 = (Slider)Template.FindName("slider12", this);
            slider13 = (Slider)Template.FindName("slider13", this);
            slider14 = (Slider)Template.FindName("slider14", this);
            slider15 = (Slider)Template.FindName("slider15", this);
            slider16 = (Slider)Template.FindName("slider16", this);
            slider17 = (Slider)Template.FindName("slider17", this);
            slider18 = (Slider)Template.FindName("slider18", this);

            slider1.ValueChanged += Slider_ValueChanged1;
            slider2.ValueChanged += Slider_ValueChanged2;
            slider3.ValueChanged += Slider_ValueChanged3;
            slider4.ValueChanged += Slider_ValueChanged4;
            slider5.ValueChanged += Slider_ValueChanged5;
            slider6.ValueChanged += Slider_ValueChanged6;
            slider7.ValueChanged += Slider_ValueChanged7;
            slider8.ValueChanged += Slider_ValueChanged8;
            slider9.ValueChanged += Slider_ValueChanged9;
            slider10.ValueChanged += Slider_ValueChanged10;
            slider11.ValueChanged += Slider_ValueChanged11;
            slider12.ValueChanged += Slider_ValueChanged12;
            slider13.ValueChanged += Slider_ValueChanged13;
            slider14.ValueChanged += Slider_ValueChanged14;
            slider15.ValueChanged += Slider_ValueChanged15;
            slider16.ValueChanged += Slider_ValueChanged16;
            slider17.ValueChanged += Slider_ValueChanged17;
            slider18.ValueChanged += Slider_ValueChanged18;


            AddLambdaEventHandler("DPC_MODE_CHANGED", OnDPCModeChanged,false);
        }

        Slider slider1;
        Slider slider2;
        Slider slider3;
        Slider slider4;
        Slider slider5;
        Slider slider6;
        Slider slider7;
        Slider slider8;
        Slider slider9;
        Slider slider10;
        Slider slider11;
        Slider slider12;
        Slider slider13;
        Slider slider14;
        Slider slider15;
        Slider slider16;
        Slider slider17;
        Slider slider18;


        private void Slider_ValueChanged1(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Dictionary<string, object> data = new() { { "nRadius", (int)slider1.Value }, { "nColor", 6 } };
            Trigger("BRIGHT_FIELD_CHANGED", this, data);
        }
        private void Slider_ValueChanged2(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Dictionary<string, object> data = new() { { "nRadius", (int)slider2.Value }, { "nColor", 6 } };
            Trigger("DARK_FIELD_CHANGED", this, data);
        }

        private void Slider_ValueChanged3(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Dictionary<string, object> data = new() { 
                { "nOutRadius", (int)slider3.Value },
                { "nDirection", 1 },
                { "nGain", (int)slider5.Value },
                { "nGamma", (int)slider6.Value },
                { "nBrightfield", (int)slider7.Value },
                { "nDpc", (int)slider8.Value },
            };
            Trigger("DPC_FIELD_CHANGED", this, data);
        }
        private void Slider_ValueChanged4(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Dictionary<string, object> data = new()
            {
                { "nOutRadius", (int)slider3.Value },
                { "nDirection", 1 },
                { "nGain", (int)slider5.Value },
                { "nGamma", (int)slider6.Value },
                { "nBrightfield", (int)slider7.Value },
                { "nDpc", (int)slider8.Value },
            };
            Trigger("DPC_FIELD_CHANGED", this, data);
        }
        private void Slider_ValueChanged5(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Dictionary<string, object> data = new()
            {
                { "nOutRadius", (int)slider3.Value },
                { "nDirection", 1 },
                { "nGain", (int)slider5.Value },
                { "nGamma", (int)slider6.Value },
                { "nBrightfield", (int)slider7.Value },
                { "nDpc", (int)slider8.Value },
            };
            Trigger("DPC_FIELD_CHANGED", this, data);
        }

        private void Slider_ValueChanged6(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Dictionary<string, object> data = new()
            {
                { "nOutRadius", (int)slider3.Value },
                { "nDirection", 1 },
                { "nGain", (int)slider5.Value },
                { "nGamma", (int)slider6.Value },
                { "nBrightfield", (int)slider7.Value },
                { "nDpc", (int)slider8.Value },
            };
            Trigger("DPC_FIELD_CHANGED", this, data);
        }
        private void Slider_ValueChanged7(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Dictionary<string, object> data = new()
            {
                { "nOutRadius", (int)slider3.Value },
                { "nDirection", 1 },
                { "nGain", (int)slider5.Value },
                { "nGamma", (int)slider6.Value },
                { "nBrightfield", (int)slider7.Value },
                { "nDpc", (int)slider8.Value },
            };
            Trigger("DPC_FIELD_CHANGED", this, data);
        }
        private void Slider_ValueChanged8(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Dictionary<string, object> data = new()
            {
                { "nOutRadius", (int)slider3.Value },
                { "nDirection", 1 },
                { "nGain", (int)slider5.Value },
                { "nGamma", (int)slider6.Value },
                { "nBrightfield", (int)slider7.Value },
                { "nDpc", (int)slider8.Value },
            };
            Trigger("DPC_FIELD_CHANGED", this, data);
        }

        private void Slider_ValueChanged9(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Dictionary<string, object> data = new()
            {
                { "nOutRadius", (int)slider3.Value },
                { "nDirection", 1 },
                { "nGain", (int)slider5.Value },
                { "nGamma", (int)slider6.Value },
                { "nBrightfield", (int)slider7.Value },
                { "nDpc", (int)slider8.Value },
            };
            Trigger("DPC_FIELD_CHANGED", this, data);
        }

        private void Slider_ValueChanged10(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Dictionary<string, object> data = new()
            {
                { "nFiler", (double)slider9.Value },
                { "nGamma", (double)slider10.Value },
                { "nGain", (double)slider11.Value },
                { "nBrightfield", (double)slider12.Value },
                { "nPhase", (double)slider13.Value },
            };
            Trigger("QFI_FIELD_CHANGED", this, data);
        }

        private void Slider_ValueChanged11(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Dictionary<string, object> data = new()
            {
                { "nFiler", (double)slider9.Value },
                { "nGamma", (double)slider10.Value },
                { "nGain", (double)slider11.Value },
                { "nBrightfield", (double)slider12.Value },
                { "nPhase", (double)slider13.Value },
            };
            Trigger("QFI_FIELD_CHANGED", this, data);
        }

        private void Slider_ValueChanged12(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Dictionary<string, object> data = new()
            {
                { "nFiler", (double)slider9.Value },
                { "nGamma", (double)slider10.Value },
                { "nGain", (double)slider11.Value },
                { "nBrightfield", (double)slider12.Value },
                { "nPhase", (double)slider13.Value },
            };
            Trigger("QFI_FIELD_CHANGED", this, data);
        }
        private void Slider_ValueChanged13(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Dictionary<string, object> data = new()
            {
                { "nFiler", (double)slider9.Value },
                { "nGamma", (double)slider10.Value },
                { "nGain", (double)slider11.Value },
                { "nBrightfield", (double)slider12.Value },
                { "nPhase", (double)slider13.Value },
            };
            Trigger("QFI_FIELD_CHANGED", this, data);
        }

        private void Slider_ValueChanged14(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Dictionary<string, object> data = new()
            {
                { "nReg", (double)slider14.Value },
                { "nMin", (double)slider15.Value },
                { "nMax", (double)slider16.Value },
                { "nDetail", (int)slider17.Value },
                { "nGamma", (double)slider18.Value },
            };
            Trigger("PHASE_FIELD_CHANGED", this, data); 
        }

        private void Slider_ValueChanged15(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Dictionary<string, object> data = new()
            {
                { "nReg", (double)slider14.Value },
                { "nMin", (double)slider15.Value },
                { "nMax", (double)slider16.Value },
                { "nDetail", (int)slider17.Value },
                { "nGamma", (double)slider18.Value },
            };
            Trigger("PHASE_FIELD_CHANGED", this, data);
        }

        private void Slider_ValueChanged16(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Dictionary<string, object> data = new()
            {
                { "nReg", (double)slider14.Value },
                { "nMin", (double)slider15.Value },
                { "nMax", (double)slider16.Value },
                { "nDetail", (int)slider17.Value },
                { "nGamma", (double)slider18.Value },
            };
            Trigger("PHASE_FIELD_CHANGED", this, data);
        }

        private void Slider_ValueChanged17(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Dictionary<string, object> data = new()
            {
                { "nReg", (double)slider14.Value },
                { "nMin", (double)slider15.Value },
                { "nMax", (double)slider16.Value },
                { "nDetail", (int)slider17.Value },
                { "nGamma", (double)slider18.Value },
            };
            Trigger("PHASE_FIELD_CHANGED", this, data);
        }

        private void Slider_ValueChanged18(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Dictionary<string, object> data = new()
            {
                { "nReg", (double)slider14.Value },
                { "nMin", (double)slider15.Value },
                { "nMax", (double)slider16.Value },
                { "nDetail", (int)slider17.Value },
                { "nGamma", (double)slider18.Value },
            };
            Trigger("PHASE_FIELD_CHANGED", this, data);
        }



        private BrushConverter brushConverter = new BrushConverter();

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton toggleButton = (RadioButton)sender;
            toggleButton.Foreground = (Brush)brushConverter.ConvertFrom("#2E86E1");
            toggleButton.FontWeight = FontWeights.Bold;
        }

        private void RadioButton_Unchecked(object sender, RoutedEventArgs e)
        {
            RadioButton toggleButton = (RadioButton)sender;
            toggleButton.Foreground = Brushes.White;
            toggleButton.FontWeight = FontWeights.Normal;
        }


        public bool OnDPCModeChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                ToggleButton btn = buttons[i];
                btn.IsChecked = btn == sender;
            }
            Log(new Message() { Severity = Severity.INFO, Text = "DPC Mode Updated" });
            return true;
        }

    }
}
