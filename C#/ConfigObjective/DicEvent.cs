using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ConfigObjective
{
    public partial class DicEvent : ResourceDictionary
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
    }
}
