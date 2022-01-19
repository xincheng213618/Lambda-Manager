using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;
using Lambda;

namespace ConfigSpot;

public class SampleSpot : LambdaControl
{
	static SampleSpot()
	{
		FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(SampleSpot), new FrameworkPropertyMetadata(typeof(SampleSpot)));
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
    }
}
