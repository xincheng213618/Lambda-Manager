using System.Windows;
using System.Windows.Controls;

namespace Global.Common.Controls
{
    /// <summary>
    /// 利用Tag记录指针，自行还原,泛型化
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
                if (this.Parent is Control control)
                {
                    TClick(control);
                }
            }
            IsChecked = !IsChecked;
        }



        private void RadioChecked(object sender, RoutedEventArgs e)
        {
            if (this.Parent is Control control)
            {
                TChecked(control);
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
