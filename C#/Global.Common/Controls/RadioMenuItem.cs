using System.Windows;
using System.Windows.Controls;

namespace Global.Common.Controls
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
                if (this.Parent is ContextMenu contextMenu )
                {
                    TClick(contextMenu);
                };
                if (this.Parent is MenuItem menuItem)
                {
                    TClick(menuItem);
                }
            }
            IsChecked = !IsChecked;
        }



        private void RadioChecked(object sender, RoutedEventArgs e)
        {
            if (this.Parent is ContextMenu contextMenu)
            {
                TChecked(contextMenu);
            }
            if (this.Parent is Menu menu)
            {
                TChecked(menu);
            }
            if (this.Parent is MenuItem menuItem)
            {
                TChecked(menuItem);
            }
        }
        public void TChecked<T>(T ParentObject) where T : Control
        {
            if (ParentObject.Tag is RadioMenuItem MenuItem)
            {
                MenuItem.IsChecked = false;
            }
            ParentObject.Tag = this;
        }
        public void TClick<T>(T ParentObject) where T : Control
        {
            if (ParentObject.Tag is RadioMenuItem MenuItem)
            {
                if (MenuItem == this)
                {
                    ParentObject.Tag = null;
                }

            }
        }
    }
}
