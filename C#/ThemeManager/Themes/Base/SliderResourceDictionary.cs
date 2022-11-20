using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace ThemeManager
{
    public partial class SliderResourceDictionary : ResourceDictionary
    {

        public void NumberValidationTextBox(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter || e.Key == Key.Back|| e.Key==Key.Left || e.Key == Key.Right)
            {
                e.Handled = false;
                return;
            }
            if ((e.Key >= Key.D0 && e.Key <= Key.D9) ||(e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9)|| e.Key == Key.Decimal)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void TextBox_Initialized(object sender, EventArgs e)
        {
            if (sender is TextBox textBox && textBox.Tag is Track track)
            {
                textBox.Text = track.Maximum.ToString($"f2");
            }
        }
    }
}
