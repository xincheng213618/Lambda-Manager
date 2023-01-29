using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace Lambda.UI.Extension
{
    public static class VisualHelper
    {
        public static TreeView treeView = new TreeView();
        public static object GetChild(Window reference, string name)
        {
            object obj = reference.FindName(name);
            return obj;
        }
        public static object GetChild(DependencyObject reference, int index)
        {
            //foreach(Controls item in UIElements.ControlList)
            //{
            //    if(item.Index == index) { return item; }
            //}
            GenerateVisualTree(reference);
            return treeView;


        }


        public static void GenerateVisualTree(DependencyObject element)
        {
            // Clear the tree.
            treeView.Items.Clear();

            // Start processing elements, begin at the root.
            ProcessElement(element, null);
        }

        private static void ProcessElement(DependencyObject element, TreeViewItem previousItem)
        {
            // Create a TreeViewItem for the current element.
            TreeViewItem item = new TreeViewItem();
            item.Header = element.GetType().Name;
            item.IsExpanded = true;

            // Check whether this item should be added to the root of the tree
            //(if it's the first item), or nested under another item.
            if (previousItem == null)
            {
                treeView.Items.Add(item);
            }
            else
            {
                previousItem.Items.Add(item);
            }

            // Check if this element contains other elements.
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(element); i++)
            {
                DependencyObject dependencyObject = VisualTreeHelper.GetChild(element, i);
                // Process each contained element recursively.
                ProcessElement(VisualTreeHelper.GetChild(element, i), item);

            }
        }

        public static void ReplaceElement(DependencyObject element, int index, Window window)
        {
            if (index == 25)
            {
                Button jec =(Button)  window.FindName("_25");
                StackPanel stackPanel = (StackPanel)jec.Parent;
                stackPanel.Children.Remove(jec);
                stackPanel.Children.Add((UIElement)element);
            }
           
        }

        public static void RegisterWindow(Window window)
        {
            
            Grid Main = (Grid)window.Content;
            Grid grid = (Grid)window.FindName("stageAcquisition");
            DockPanel dockPanel = (DockPanel)grid.Children[1];
            StackPanel stackPanel = (StackPanel)dockPanel.Children[1];
            Button button =(Button)stackPanel.Children[1];
            ToggleButton toggleButton =(ToggleButton)stackPanel.Children[0];
            Main.RegisterName("_25", button);
            Main.RegisterName("_24", toggleButton);
        }

        public static void ResizeElement(double width,double height,int index, Window window)
        {
            if (index == 24)
            {
                ToggleButton jec = (ToggleButton)window.FindName("_24");
                jec.Height = height;
                jec.Width = width;
            }

        }

        public static void GetLogicalChildren(FrameworkElement container)
        {
            foreach (var child in LogicalTreeHelper.GetChildren(container))
            {
                FrameworkElement frameworkElement = child as FrameworkElement;
                if (frameworkElement != null)
                {
                    GetLogicalChildren(frameworkElement);
                }
            }

        }
        public static void GetVisualChildren(FrameworkElement container)
        {
            int count = VisualTreeHelper.GetChildrenCount(container);
            for (int i = 0; i < count; i++)
            {
                FrameworkElement frameworkElement = VisualTreeHelper.GetChild(container, i) as FrameworkElement;
                if (frameworkElement != null)
                {
                    GetVisualChildren(frameworkElement);
                }
            }
        }


    }
}
