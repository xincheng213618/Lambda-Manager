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

namespace ConfigDOFMode
{
    /// <summary>
    /// Follow steps 1a or 1b and then 2 to use this custom control in a XAML file.
    ///
    /// Step 1a) Using this custom control in a XAML file that exists in the current project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:ConfigDOFMode"
    ///
    ///
    /// Step 1b) Using this custom control in a XAML file that exists in a different project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:ConfigDOFMode;assembly=ConfigDOFMode"
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
    public class DOFMode : LambdaControl
    {
        static DOFMode()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(DOFMode), new FrameworkPropertyMetadata(typeof(DOFMode)));
        }
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
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
