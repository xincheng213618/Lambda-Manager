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

namespace ConfigCollectInterval
{
    /// <summary>
    /// Follow steps 1a or 1b and then 2 to use this custom control in a XAML file.
    ///
    /// Step 1a) Using this custom control in a XAML file that exists in the current project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:ConfigCollectInterval"
    ///
    ///
    /// Step 1b) Using this custom control in a XAML file that exists in a different project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:ConfigCollectInterval;assembly=ConfigCollectInterval"
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
    public class CollectInterval : LambdaControl
    {
        static CollectInterval()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CollectInterval), new FrameworkPropertyMetadata(typeof(CollectInterval)));
        }
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

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

            StackPanel StackContent1 = (StackPanel)Template.FindName("StackContent1", this);
            Button buttonheader11 = (Button)Template.FindName("buttonheader11", this);
            Path Path11 = (Path)Template.FindName("Path11", this);
            Path Path21 = (Path)Template.FindName("Path21", this);

            buttonheader11.Click += delegate
            {
                if (StackContent1.Visibility == Visibility.Visible)
                {
                    StackContent1.Visibility = Visibility.Collapsed;
                    Path11.Visibility = Visibility.Collapsed;
                    Path21.Visibility = Visibility.Visible;
                }
                else
                {
                    StackContent1.Visibility = Visibility.Visible;
                    Path11.Visibility = Visibility.Visible;
                    Path21.Visibility = Visibility.Collapsed;
                }
            };

            Grid StackContent2 = (Grid)Template.FindName("StackContent2", this);
            Button buttonheader12 = (Button)Template.FindName("buttonheader12", this);
            Path Path12 = (Path)Template.FindName("Path12", this);
            Path Path22 = (Path)Template.FindName("Path22", this);

            buttonheader12.Click += delegate
            {
                if (StackContent2.Visibility == Visibility.Visible)
                {
                    StackContent2.Visibility = Visibility.Collapsed;
                    Path12.Visibility = Visibility.Collapsed;
                    Path22.Visibility = Visibility.Visible;
                }
                else
                {
                    StackContent2.Visibility = Visibility.Visible;
                    Path12.Visibility = Visibility.Visible;
                    Path22.Visibility = Visibility.Collapsed;
                }
            };

            StackPanel StackContent3 = (StackPanel)Template.FindName("StackContent3", this);
            Button buttonheader13 = (Button)Template.FindName("buttonheader13", this);
            Path Path13 = (Path)Template.FindName("Path13", this);
            Path Path23 = (Path)Template.FindName("Path23", this);

            buttonheader13.Click += delegate
            {
                if (StackContent3.Visibility == Visibility.Visible)
                {
                    StackContent3.Visibility = Visibility.Collapsed;
                    Path13.Visibility = Visibility.Collapsed;
                    Path23.Visibility = Visibility.Visible;
                }
                else
                {
                    StackContent3.Visibility = Visibility.Visible;
                    Path13.Visibility = Visibility.Visible;
                    Path23.Visibility = Visibility.Collapsed;
                }
            };
        }
    }
}
