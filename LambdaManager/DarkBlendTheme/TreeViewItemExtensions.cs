using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace DarkBlendTheme;

public static class TreeViewItemExtensions
{
	public static int GetDepth(this TreeViewItem item)
	{
		TreeViewItem parent;
		if ((parent = GetParent(item)) != null)
		{
			return parent.GetDepth() + 1;
		}
		return 0;
	}

	private static TreeViewItem? GetParent(TreeViewItem item)
	{
		DependencyObject parent = VisualTreeHelper.GetParent(item);
		while (parent is not TreeViewItem && parent is not TreeView)
		{
			if (parent == null)
			{
				return null;
			}
			parent = VisualTreeHelper.GetParent(parent);
		}
		return parent as TreeViewItem;
	}
}
