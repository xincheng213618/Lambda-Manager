using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

namespace WpfApp6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FileSystemWatcher watcher = new FileSystemWatcher(@"C:\Users\Chen\Desktop\1x");
            watcher.IncludeSubdirectories = true;
            watcher.Deleted += Watcher_Deleted;
            watcher.Created += Watcher_Created;
            watcher.Renamed += Watcher_Renamed;
            watcher.EnableRaisingEvents = true;

        }
        private void Watcher_Renamed(object sender, RenamedEventArgs e)
        {
            MessageBox.Show(e.FullPath);
        }

        private static void Watcher_Deleted(object sender, FileSystemEventArgs e)
        {
            MessageBox.Show(e.FullPath);
        }

        private static void Watcher_Created(object sender, FileSystemEventArgs e)
        {
            MessageBox.Show(e.FullPath);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
