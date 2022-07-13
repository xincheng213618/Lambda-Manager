using System.Windows;
using System.Windows.Controls;

namespace Global.Controls
{
    /// <summary>
    /// 利用Tag记录指针，自行还原
    /// </summary>
    public class RadioMenuItem : MenuItem
    {
        public RadioMenuItem()
        {
            this.Click += RadioMenuItem_Click;
            this.Checked += RadioChecked;
        }

        private void RadioMenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (IsChecked)
            {
                if (this.Parent is ContextMenu contextMenu)
                {
                    if (contextMenu.Tag is RadioMenuItem MenuItem)
                    {
                        if (MenuItem == this)
                        {
                            contextMenu.Tag = null;
                        }

                    }
                }
            }
            IsChecked = !IsChecked;
        }

        private void RadioChecked(object sender, RoutedEventArgs e)
        {
            if (this.Parent is ContextMenu contextMenu)
            {
                if (contextMenu.Tag is RadioMenuItem MenuItem)
                {

                    MenuItem.IsChecked = false;
                }
                contextMenu.Tag = this;

            }
            if (this.Parent is Menu menu)
            {
                if (menu.Tag is RadioMenuItem MenuItem)
                {
                    MenuItem.IsChecked = false;
                }
                menu.Tag = this;
            }
        }
    }
}
