using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Global.SettingUp.Menu
{
    public class MenuAttribute : Attribute
    {
        public static void AddMenuItem(MenuItem menuItem)
        {
            if (Application.Current.MainWindow.FindName("menu") is System.Windows.Controls.Menu menu)
            {
                menu.Items.Add(menuItem);
            }
        }
        public MenuAttribute()
        {
            AddMenuItem(new MenuItem() {  Header = Headers });
        }


        public MenuItem MenuItem { get; set; }

        public string  Headers { get; set; }

    }
}
