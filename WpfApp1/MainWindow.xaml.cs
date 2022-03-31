using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
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
            //AddNewProject.InputGestures.Add(gesture);
        }




        public bool DoDelete(bool alert)
        {
            if (alert)
            {
                if (MessageBox.Show("dddddddd","2222222" ,MessageBoxButton.OKCancel, MessageBoxImage.Asterisk) != MessageBoxResult.OK)
                    return false;
            }

            //if (!(this.Parent as ProjectFolder).RemoveChild(this))
            //    return false;

            //if (File.Exists(this.FullName))
            //{
            //    return FileName.DeleteToRecycleBin(this.FullName);
            //}

            return false;
        }








        private void Window_Initialized(object sender, EventArgs e)
        {
            this.leftView.Children.Clear();
            List<UICofig> list = new List<UICofig>();

            list.Add(new UICofig() { path = "ConfigObjective.dll", name = "Magnification" });
            ////list.Add(new UICofig() { path = "ConfigFocus.dll", name = "FocusMode" });
            //list.Add(new UICofig() { path = "ConfigDPCMode.dll", name = "DPCMode" });
            //list.Add(new UICofig() { path = "ConfigDeck.dll", name = "BaseDeck" });
            //list.Add(new UICofig() { path = "ConfigSpot.dll", name = "SampleSpot" });
            //list.Add(new UICofig() { path = "ConfigDOFMode.dll", name = "DOFMode" });
            //list.Add(new UICofig() { path = "ConfigCollectInterval.dll", name = "CollectInterval" });

            foreach (var item in list)
            {
                Assembly assembly = Assembly.LoadFile(Environment.CurrentDirectory + "\\" + item.path);
                Control control = (Control)assembly.CreateInstance($"{item.path.Replace(".dll", "")}.{item.name}");
                leftView.Children.Add(control);
            }


        }








    }

    public class ViewHelper
    {
        /// <summary>
        /// 通过给定的依赖对象，在控件树中向上查找指定类型的控件
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static T FindVisualParent<T>(DependencyObject obj) where T : class
        {
            while (obj != null)
            {
                if (obj is T)
                    return obj as T;

                obj = VisualTreeHelper.GetParent(obj);
            }

            return null;
        }

        /// <summary>
        /// 在给定的空间中，查找给定坐标点的给定类型的控件
        /// </summary>
        public static T HitTestView<T>(Visual visual, Point pos) where T : class
        {
            HitTestResult result = VisualTreeHelper.HitTest(visual, pos);
            if (result == null)
                return null;
            DependencyObject obj = result.VisualHit;

            return FindVisualParent<T>(obj);
        }
    }

    public class UICofig
    {
        public string path = "";
        public string name = "";   
    }
}
