using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using NLGSolution;
using Mode;
using Tool;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Initialized(object sender, EventArgs e)
        {
            this.leftView.Children.Clear();
            //List<UICofig> list = new List<UICofig>();

            
            //list.Add(new UICofig() { path = "ConfigObjective.dll", name = "Magnification" });
            ////list.Add(new UICofig() { path = "ConfigFocus.dll", name = "FocusMode" });
            //list.Add(new UICofig() { path = "ConfigDPCMode.dll", name = "DPCMode" });
            //list.Add(new UICofig() { path = "ConfigDeck.dll", name = "BaseDeck" });
            //list.Add(new UICofig() { path = "ConfigSpot.dll", name = "SampleSpot" });
            //list.Add(new UICofig() { path = "ConfigDOFMode.dll", name = "DOFMode" });
            //list.Add(new UICofig() { path = "ConfigCollectInterval.dll", name = "CollectInterval" });

            //foreach (var item in list)
            //{
            //    Assembly assembly = Assembly.LoadFile(Environment.CurrentDirectory + "\\" + item.path);
            //    Control control = (Control)assembly.CreateInstance($"{item.path.Replace(".dll", "")}.{item.name}");
            //    leftView.Children.Add(control);
            //}


        }

        private void Window_Closed(object sender, EventArgs e)
        {

        }
    }

}
