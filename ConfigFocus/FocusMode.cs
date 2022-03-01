using Lambda;
using System;
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

namespace ConfigFocus
{
    /// <summary>
    /// Follow steps 1a or 1b and then 2 to use this custom control in a XAML file.
    ///
    /// Step 1a) Using this custom control in a XAML file that exists in the current project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:ConfigFocus"
    ///
    ///
    /// Step 1b) Using this custom control in a XAML file that exists in a different project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:ConfigFocus;assembly=ConfigFocus"
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
    public class FocusMode : LambdaControl
    {
        static FocusMode()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FocusMode), new FrameworkPropertyMetadata(typeof(FocusMode)));
        }

        TextBox TextBox1;
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            TextBox1 = (TextBox)Template.FindName("TextBox1", this);
            LambdaControl.CallEventHandler += Call;
            Button Test1 = (Button)Template.FindName("Button_Test1", this);
            Button Test2 = (Button)Template.FindName("Button_Test2", this);
            Button Test3 = (Button)Template.FindName("Button_Test3", this);
            Button Test4 = (Button)Template.FindName("Button_Test4", this);
            Button Test5 = (Button)Template.FindName("Button_Test5", this);
            Test1.Click += Button_Test_Click;
            Test2.Click += Button_Test_Click;
            Test3.Click += Button_Test_Click;
            Test4.Click += Button_Test_Click;
            Test5.Click += Button_Test_Click;

            Slider Slider1 = (Slider)Template.FindName("Slider1", this);
            Slider Slider2 = (Slider)Template.FindName("Slider2", this);
            Slider Slider3 = (Slider)Template.FindName("Slider3", this);
            Slider Slider4 = (Slider)Template.FindName("Slider4", this);
            Slider Slider5 = (Slider)Template.FindName("Slider5", this);
            Slider Slider6 = (Slider)Template.FindName("Slider6", this);
            Slider Slider7 = (Slider)Template.FindName("Slider7", this);
            Slider Slider8 = (Slider)Template.FindName("Slider8", this);
            Slider Slider9 = (Slider)Template.FindName("Slider9", this);

            Slider1.ValueChanged += Slider_ValueChanged;
            Slider2.ValueChanged += Slider_ValueChanged;
            Slider3.ValueChanged += Slider_ValueChanged;
            Slider4.ValueChanged += Slider_ValueChanged;
            Slider5.ValueChanged += Slider_ValueChanged;
            Slider6.ValueChanged += Slider_ValueChanged;
            Slider7.ValueChanged += Slider_ValueChanged;
            Slider8.ValueChanged += Slider_ValueChanged;
            Slider9.ValueChanged += Slider_ValueChanged;

        }
        private int Call(string type, object sender, EventArgs e)
        {
            if (e is LambdaArgs lambdaArgs)
            {
                object data = lambdaArgs.Data;
                if (data == null)
                {
                    return 1;
                }
                if (data is string text)
                {
                    TextBox1.Text = type + text;
                    return 1;
                }
                if (data is Dictionary<string, object> result)
                {
                    TextBox1.Text = type + result.ToString();
                }
            }
            return 1;
        }

        private void Slider_ValueChanged(object sender, RoutedEventArgs e)
        {
            Slider Slider = (Slider)sender;
            Dictionary<string, object> data = new()
            {
                { "Test", Slider.Value },
            };
            Trigger(Slider.Name, Slider, data);
        }


        private void Button_Test_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            switch (button.Content)
            {
                case "Test1":
                    Dictionary<string, object> data = new() { };
                    LambdaControl.Trigger("ButtonTest1", button, data);
                    break;
                case "Test2":
                    data = new() { };
                    LambdaControl.Trigger("ButtonTest2", button, data);
                    break;
                case "Test3":
                    data = new() { };
                    LambdaControl.Trigger("ButtonTest3", button, data);
                    break;
                case "Test4":
                    data = new() { };
                    LambdaControl.Trigger("ButtonTest4", button, data);
                    break;
                case "Test5":
                    data = new() { };
                    LambdaControl.Trigger("ButtonTest5", button, data);
                    break;
            }
        }
    }
}
