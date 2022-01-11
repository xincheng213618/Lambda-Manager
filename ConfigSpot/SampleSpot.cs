using System.Windows;
using Lambda;

namespace ConfigSpot;

public class SampleSpot : LambdaControl
{
	static SampleSpot()
	{
		FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(SampleSpot), new FrameworkPropertyMetadata(typeof(SampleSpot)));
	}
}
