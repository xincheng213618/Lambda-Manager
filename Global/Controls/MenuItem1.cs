using System.Windows;
using System.Windows.Controls;

namespace Global.Controls
{
    public class MenuItem1 : MenuItem
    {
        public MenuItem1()
        {
            this.Checked += Checked1;
        }

        private void Checked1(object sender, RoutedEventArgs e)
        {
            if (this.Parent is ContextMenu menuItem)
            {
                foreach (var item in menuItem.Items)
                {
                    if (item != this && item is MenuItem menu)
                    {
                        if (menu.IsChecked == true)
                            menu.IsChecked = false;

                    }
                }
            }
        }
    }
}
