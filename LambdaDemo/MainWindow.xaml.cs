using LambdaManager;
using LambdaManager.Core;
using LambdaManager.Utils;
using Quartz;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using XSolution;

namespace LambdaDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, ILambdaUI
    {
        FileSystemWatcher watcher;
        public MainWindow()
        {
            InitializeComponent();

            watcher = new FileSystemWatcher(Directory.GetCurrentDirectory())
            {
                IncludeSubdirectories = false,
            };
            watcher.Changed += Watcher_Changed;
            watcher.EnableRaisingEvents = true;
        }

        private void Watcher_Changed(object sender, FileSystemEventArgs e)
        {
            foreach (var item in DLLloads)
            {
                if (e.FullPath.Contains(item.filePath))
                {
                    Application.Current.Dispatcher.Invoke(delegate
                    {
                        LoadDLL(item);
                    });
                }
            }
        }


        List<DLLload> DLLloads = new List<DLLload>();


        public void LoadControl(string name, string lib, string mount)
        {
            string fullName = lib.Replace(".dll", "") + "." + name;
            DLLload dLLload = new DLLload() { filePath = Directory.GetCurrentDirectory() + "\\" + lib, typeName = fullName };
            DLLloads.Add(dLLload);
            byte[] dllbytes = File.ReadAllBytes(dLLload.filePath);
            Assembly assembly = Assembly.Load(dllbytes);

            if ((assembly.CreateInstance(fullName) is Control control ))
            {
                if (control is Window window)
                {
                    if (AddMenuItem(mount) is MenuItem menuItem)
                    {
                        menuItem.Click += delegate
                        {
                            window.Owner = this;
                            window.WindowStartupLocation = WindowStartupLocation.CenterOwner;
                            window.ShowDialog();
                        };
                    }
                }
                else
                {
                    stackpanel1.Children.Add(control);
                }

            }
        }
        public void LoadDLL(DLLload dll)
        {
            stackpanel1.Children.Clear();
            byte[] dllbytes = File.ReadAllBytes(dll.filePath);
            Assembly assembly = Assembly.Load(dllbytes);
            if ((assembly.CreateInstance(dll.typeName) is Control control))
            {
                if (control is Window window)
                {

                }
                else
                {
                    stackpanel1.Children.Add(control);
                }

            }
        }





        private void Button_Click(object sender, RoutedEventArgs e)
        {
            stackpanel1.Children.Clear();


            foreach (var item in DLLloads)
            {
                LoadDLL(item);
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



        private void Window_Initialized(object sender, EventArgs e)
        {
            ConfigLibrary ConfigLibrary = new ConfigLibrary();
            ConfigLibrary.lambdaUI = this;
            ConfigLibrary.Load();
            ConfigLibrary.InitializeLibrary();
            ConfigLibrary.LoadUIComponents();

            if (Common.ViewGrid is ViewGrid viewGrid)
            {
                mainView.Children.Clear();
                mainView.Children.Add(viewGrid.mainView);
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Common.CommonExit();
            Environment.Exit(-1);
        }

        public void LoadMenuCommand(string name, List<string> raises)
        {

        }
    }


    public class DLLload
    {
        public string filePath;

        public string typeName;
    }


}
