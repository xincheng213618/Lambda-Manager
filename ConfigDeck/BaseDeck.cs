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

namespace ConfigDeck
{
    /// <summary>
    /// Follow steps 1a or 1b and then 2 to use this custom control in a XAML file.
    ///
    /// Step 1a) Using this custom control in a XAML file that exists in the current project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:ConfigDeck"
    ///
    ///
    /// Step 1b) Using this custom control in a XAML file that exists in a different project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:ConfigDeck;assembly=ConfigDeck"
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
    public class BaseDeck : LambdaControl
    {
        static BaseDeck()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(BaseDeck), new FrameworkPropertyMetadata(typeof(BaseDeck)));
        }
        private readonly System.Windows.Threading.DispatcherTimer _timer = new System.Windows.Threading.DispatcherTimer();



        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            _timer.Interval = TimeSpan.FromSeconds(0.2); //wait for the other click for 200ms
            _timer.Tick += Timer_Tick;

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




            TextBox TextBox1 = (TextBox)Template.FindName("TextBox1", this);
            TextBox TextBox2 = (TextBox)Template.FindName("TextBox2", this);
            TextBox TextBox3 = (TextBox)Template.FindName("TextBox3", this);

            if (Template.FindName("ButtonFront", this) is Button btn1)
            {
                btn1.Click += delegate
                {
                    Dictionary<string, object> data = new() { { "Step", int.Parse(TextBox1.Text) } };
                    Trigger("MOVEFRONT", btn1, data);
                };
            }
            if (Template.FindName("ButtonRear", this) is Button btn2)
            {
                btn2.Click += delegate
                {
                    Dictionary<string, object> data = new() { { "Step", int.Parse(TextBox1.Text) } };
                    Trigger("MOVEREAR", btn2, data);
                };
            }
            if (Template.FindName("ButtonRight", this) is Button btn3)
            {
                
                btn3.Click += delegate
                {
                    Dictionary<string, object> data = new() { { "Step", int.Parse(TextBox1.Text) } };
                    Trigger("MOVERIGHT", btn3, data);
                };
            }
            if (Template.FindName("ButtonLeft", this) is Button btn4)
            {
                btn4.Click += delegate
                {
                    Dictionary<string, object> data = new() { { "Step", int.Parse(TextBox1.Text) } };
                    Trigger("MOVELEFT", btn4, data);
                };
            }
            if (Template.FindName("ButtonUp", this) is Button btn5)
            {
                btn5.Click += delegate
                {
                    Dictionary<string, object> data = new() { { "Step", int.Parse(TextBox2.Text) },{ "Direction", 4 } };
                    Trigger("MOVEUP", btn5, data);
                };
            }
            if (Template.FindName("ButtonDown", this) is Button btn6)
            {
                btn6.Click += delegate
                {
                    Dictionary<string, object> data = new() { { "Step", int.Parse(TextBox2.Text) },{ "Direction",5 } };
                    Trigger("MOVEDOWN", btn6, data);
                };
            }
            if (Template.FindName("ButtonRe", this) is Button btn7)
            {
                btn7.Click += delegate
                {
                    Dictionary<string, object> data = new() { { "Step", 0},{ "Direction", 6 } };
                    Trigger("MOVERE", btn7, data);

                };
            }
            if (Template.FindName("ButtonAutoFocus", this) is Button btn8)
            {
                btn8.Click += delegate
                {
                    Dictionary<string, object> data = new() { };
                    Trigger("AUTO_FOCUS", btn8, data);
                };
                btn8.Click += delegate
                 {
                     Dictionary<string, object> data = new() { };
                     Trigger("SMALL_AUTO_FOCUS_Run", btn8, data);
                 };
            }

            AddLambdaEventHandler("Move", Logssssss, false);

        }
        private void Button_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                _timer.Stop();
                Dictionary<string, object> data = new() { };
                Trigger("AUTO_FOCUS", this, data);
            }
            else
            {
                _timer.Start();
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            _timer.Stop();

            Dictionary<string, object> data = new() { };
            Trigger("SMALL_AUTO_FOCUS_Run", this, data);
        }

        public bool Logssssss(object sender, EventArgs e)
        {
            Log(new Message() { Severity = Severity.INFO, Text = "位移台指令连接成功" });
            return true;
        }
    }
}
