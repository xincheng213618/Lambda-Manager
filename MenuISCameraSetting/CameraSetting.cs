using System.Windows;
using System.Windows.Controls;
using Lambda;
namespace MenuISCameraSetting
{
	public class CameraSetting : LambdaControl
	{
		static CameraSetting()
		{
			FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(CameraSetting), new FrameworkPropertyMetadata(typeof(CameraSetting)));
		}
	}
}


