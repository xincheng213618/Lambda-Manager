using LambdaManager;
using LambdaManager.DataType;
using LambdaManager.Utils;
using Mode;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LambdaDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, ILambdaUI
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        bool first = false;
        public void LoadControl(string name, string lib, string mount)
        {
            Assembly assembly = Assembly.LoadFile(Directory.GetCurrentDirectory() + "/" + lib);
            string fullName = lib.Replace(".dll", "") + "." + name;

            if ((assembly.CreateInstance(fullName) is Control control ))
            {
                if (control is Window window)
                {
                    MenuItem menuItem = AddMenuItem(mount);
                    menuItem.Click += delegate
                    {
                        window.Owner = this;
                        window.WindowStartupLocation = WindowStartupLocation.CenterOwner;
                        window.ShowDialog();
                    };
                }
                else
                {
                    stackpanel1.Children.Add(control);
                    first = true;
                }

            }
        }
        public MenuItem? AddMenuItem(string path)
        {
            ItemCollection items = menu.Items;
            if (items == null)
            {
                return null;
            }
            MenuItem last = null;
            string[] array = path.Split("/");
            foreach (string name in array)
            {
                bool found = false;
                foreach (MenuItem item in (IEnumerable)items)
                {
                    if (item.Header.ToString() == name)
                    {
                        found = true;
                        items = item.Items;
                        break;
                    }
                }
                if (!found)
                {
                    MenuItem menuItem = new MenuItem();
                    menuItem.Header = name;
                    items.Add(menuItem);
                    items = menuItem.Items;

                    last = menuItem;
                }
            }
            return last;
        }

        public void LoadMenuCommand(Command command)
        {

        }

        private void Window_Initialized(object sender, EventArgs e)
        {
            ConfigLibrary ConfigLibrary = new ConfigLibrary();
            ConfigLibrary.lambdaUI = this;
            ConfigLibrary.Load();
            ConfigLibrary.InitializeLibrary();

            mainView.Children.Clear();
            mainView.Children.Add(ViewGrid.mainView);
        }
    }


}
