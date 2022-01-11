using System.Windows.Controls;

namespace LambdaManager.Utils;

internal class View
{
	internal Image Image { get; set; }

	internal int Index { get; set; }

	internal ViewState State { get; set; }

	public View(Image image, int index)
	{
		Image = image;
		Index = index;
	}
}
