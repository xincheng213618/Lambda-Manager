using HotKey;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace WpfApp5
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

        HotKeyHelper HotKeyHelper;
        private void Window_Initialized(object sender, EventArgs e)
        {
            HotKeyHelper = HotKeyHelper.GetInstance();

            HotKeys HotKeys11 = new HotKeys();
            HotKeys11.FunctionName = "全局";
            HotKeys11.hotKeyHandler = MsgShow;
            HotKeys11.Kinds = HotKeyKinds.Global;
            HotKeyHelper.AddHotKeys(this, HotKeys11);

            HotKeys HotKeys1 = new HotKeys();
            HotKeys1.FunctionName = "窗口";
            HotKeys1.hotKeyHandler = MsgShow1;
            HotKeys1.Kinds = HotKeyKinds.Windows;
            HotKeyHelper.AddHotKeys(this, HotKeys1);

            HotKeys HotKeys2 = new HotKeys();
            HotKeys2.FunctionName = "窗口1";
            HotKeys2.hotKeyHandler = MsgShow2;
            HotKeys2.Kinds = HotKeyKinds.Windows;
            HotKeyHelper.AddHotKeys(this, HotKeys1);

            foreach (var item in HotKeyHelper.HotKeysList)
            {
                int vk = item.Key;
                HotKeys hotKeys = item.Value;
                DockPanel dockPanel = new DockPanel();

                Label label = new Label();
                label.Content = hotKeys.FunctionName;
                dockPanel.Children.Add(label);
                TextBox textBox = new TextBox()
                {
                    Width =200,
                    VerticalAlignment = VerticalAlignment.Center,
                    IsReadOnly = true,
                    IsUndoEnabled =false,
                    ContextMenu = new ContextMenu(){ Visibility = Visibility.Hidden}
                };
                textBox.PreviewKeyDown += delegate (object sender, KeyEventArgs e)
                {
                    TextBox textBox = (TextBox)sender;
                    e.Handled = true;
                    ModifierKeys modifiers = Keyboard.Modifiers;
                    if (Keyboard.IsKeyDown(Key.LWin) || Keyboard.IsKeyDown(Key.RWin))
                        modifiers |= ModifierKeys.Windows;
                    Key key = e.Key;

                    if (key == Key.System)
                        key = e.SystemKey;


                    // Pressing delete, backspace or escape without modifiers clears the current value
                    if (modifiers == ModifierKeys.None && (key == Key.Delete || key == Key.Back || key == Key.Escape))
                    {
                        textBox.Text = "";
                        hotKeys.Hotkey = null;
                        HotKeyHelper.UnRegisterHotKeys(vk);
                        return;
                    }

                    if (key == Key.LeftCtrl || key == Key.RightCtrl || key == Key.LeftAlt || key == Key.RightAlt || key == Key.LeftShift || key == Key.RightShift || key == Key.LWin || key == Key.RWin || key == Key.Clear || key == Key.OemClear || key == Key.Apps)
                        return;

                    hotKeys.Hotkey = new Hotkey(key, modifiers);
                    textBox.Text = hotKeys.Hotkey.ToString();
                    HotKeyHelper.ModifyHotKeys(vk);
                };
                dockPanel.Children.Add(textBox);
                StackPanel1.Children.Add(dockPanel);
            }


        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {

        }

        private void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void MsgShow()
        {
            MessageBox.Show("2222222");
        }
        private void MsgShow1()
        {
            MessageBox.Show("2111222");
        }
        private void MsgShow2()
        {
            MessageBox.Show("hcuangssss");
        }
        static GridLengthConverter gridLengthConverter = new GridLengthConverter();

        private Grid[] gridlists = new Grid[100];

        int index = 0;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            gridlists[index] = NewGrid();
            Gridshow.Add(index);
            GridSort();
            index++;
        }
        private Grid NewGrid()
        {
            Random random = new Random();
            Grid grid = new Grid()
            {
                Background = new SolidColorBrush(Color.FromRgb((byte)random.Next(0, 155), (byte)random.Next(0, 155), (byte)random.Next(0, 155))),
                Margin = new Thickness(2, 2, 2, 2),
            };
            Label label = new Label()
            {
                Content = index
            };
            Image image = new Image
            {
                Stretch = Stretch.Uniform
            };
            Canvas canvas = new Canvas()
            {
                Background = new SolidColorBrush(Color.FromRgb((byte)random.Next(0, 155), (byte)random.Next(0, 155), (byte)random.Next(0, 155))),
                ClipToBounds = true
            };
            canvas.Children.Add(image);
            grid.Children.Add(label);
            return grid;
        }




        private void GridSort()
        {
            mainView.Children.Clear();
            mainView.ColumnDefinitions.Clear();
            mainView.RowDefinitions.Clear();
            int newlist = 0;
            for (int i = 0; i < gridlists.Length; i++)
            {
                if (gridlists[i] != null)
                {
                    Grid grid = gridlists[i];
                    int location = Array.IndexOf(grids, newlist);
                    int row = (location / 10);
                    int col = (location % 10);
                    if (mainView.ColumnDefinitions.Count <= col)
                    {
                        ColumnDefinition columnDefinition = new ColumnDefinition() { Width = (GridLength)gridLengthConverter.ConvertFrom("*") };
                        mainView.ColumnDefinitions.Add(columnDefinition);
                    }
                    if (mainView.RowDefinitions.Count <= row)
                    {
                        RowDefinition rowDefinition = new RowDefinition() { Height = (GridLength)gridLengthConverter.ConvertFrom("*") };
                        mainView.RowDefinitions.Add(rowDefinition);
                    }

                    grid.SetValue(Grid.RowProperty, row);
                    grid.SetValue(Grid.ColumnProperty, col);
                    mainView.Children.Add(grid);
                    newlist++;
                }
            }

        }


        private static readonly int[] grids = new int[100]
    {
        0, 1, 4, 9, 16, 25, 36, 49, 64, 81,
        2, 3, 5, 10, 17, 26, 37, 50, 65, 82,
        6, 7, 8, 11, 18, 27, 38, 51, 66, 83,
        12, 13, 14, 15, 19, 28, 39, 52, 67, 84,
        20, 21, 22, 23, 24, 29, 40, 53, 68, 85,
        30, 31, 32, 33, 34, 35, 41, 54, 69, 86,
        42, 43, 44, 45, 46, 47, 48, 55, 70, 87,
        56, 57, 58, 59, 60, 61, 62, 63, 71, 88,
        72, 73, 74, 75, 76, 77, 78, 79, 80, 89,
        90, 91, 92, 93, 94, 95, 96, 97, 98, 99
    };
        private List<int> Gridshow = new List<int>();
        private List<int> Gridhide = new List<int>();   

        private Grid[] Gridhiden = new Grid[100];
        int index1 = 0;

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Random r = new Random();

            int sss = Gridshow[r.Next(0, Gridshow.Count)];
            Gridshow.Remove(sss);
            Gridhide.Add(sss);

            Grid grid1 = gridlists[sss];
            if (grid1 != null)
            {
                Gridhiden[sss] = grid1;
                gridlists[sss] = null;
                GridSort();
            }
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            Random r = new Random();
            if (Gridhide.Count > 0)
            {
                int sss = Gridhide[r.Next(0, Gridhide.Count)];
                Gridhide.Remove(sss);
                Gridshow.Add(sss);
                Grid grid1 = Gridhiden[sss];
                if (grid1 != null)
                {
                    gridlists[sss] = grid1;
                    Gridhiden[sss] = null;
                    GridSort();
                }
            }

        }
    }



}
