using System.Windows.Controls;

namespace Lambda;

public class View
{
	public Image Image { get; set; }

	public int Index { get; set; }

	public ViewState State { get; set; }

	public View(Image image, int index)
	{
		Image = image;
		Index = index;
	}
}
