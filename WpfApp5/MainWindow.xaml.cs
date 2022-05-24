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
        static GridLengthConverter gridLengthConverter = new GridLengthConverter();

        HotKeyHelper HotKeyHelper;
        private void Window_Initialized(object sender, EventArgs e)
        {
            //if (image1.Parent is Grid grid)
            //{
            //    //grid.Children.Clear();
            //    grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = (GridLength)gridLengthConverter.ConvertFrom("*") });
            //    grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = (GridLength)gridLengthConverter.ConvertFrom("*") });

            //    Grid grid1 = new Grid() { Background = Brushes.Transparent };
            //    grid1.SetValue(Grid.ColumnProperty, 0);
            //    ContextMenu contextMenu = new ContextMenu();
            //    MenuItem menuItem = new MenuItem() { Header = "11111" };
            //    contextMenu.Items.Add(menuItem);
            //    grid1.ContextMenu = contextMenu;

            //    Grid grid2 = new Grid() { Background = Brushes.Transparent };
            //    grid2.SetValue(Grid.ColumnProperty, 1);
            //    ContextMenu contextMenu1 = new ContextMenu();
            //    MenuItem menuItem1 = new MenuItem() { Header = "22222222" };
            //    contextMenu1.Items.Add(menuItem1);
            //    grid2.ContextMenu = contextMenu1;
            //    image1.SetValue(Grid.ColumnProperty, 0);
            //    image1.SetValue(Grid.ColumnSpanProperty, 2);
            //    //grid.Children.Add(image1);
            //    grid.Children.Add(grid1);
            //    grid.Children.Add(grid2);
            //}




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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //System.Windows.Forms.ColorDialog colorDialog = new System.Windows.Forms.ColorDialog();
            //colorDialog.AllowFullOpen = true;
            //colorDialog.FullOpen = true;
            //colorDialog.AnyColor = false;
            //colorDialog.CustomColors = new int[] { 0x6987FC, 15195440, 16107657, 1836924, 3758726, 12566463, 7526079, 7405793, 6945974, 241502, 2296476, 5130294, 3102017, 7324121, 14993507, 11730944 };
            //colorDialog.ShowHelp = true;
            //if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    System.Drawing.SolidBrush sb = new System.Drawing.SolidBrush(colorDialog.Color);
            //    SolidColorBrush solidColorBrush = new SolidColorBrush(System.Windows.Media.Color.FromArgb(sb.Color.A, sb.Color.R, sb.Color.G, sb.Color.B));
            //    Button1.Background = solidColorBrush;
            //}


            if (image1.Parent is Grid grid)
            {
                Canvas canvas1 = new Canvas()
                {
                    Height = image1.ActualHeight,
                    Width = image1.ActualWidth,
                    Background = Brushes.Black,
                    ClipToBounds = true
                };
                grid.Children.Clear();
                canvas1.Children.Add(image1);
                grid.Children.Add(canvas1);
            }

            if (image1.Parent is Canvas canvas)
            {
                TransformGroup transformGroup = new();
                TranslateTransform tlt = new();
                ScaleTransform sfr = new();
                transformGroup.Children.Add(sfr);
                transformGroup.Children.Add(tlt);
                image1.RenderTransform = transformGroup;
                image1.MouseWheel += delegate (object sender, MouseWheelEventArgs e)
                {
                    Point centerPoint = e.GetPosition(canvas);
                    if (sfr.ScaleX < 0.2 && sfr.ScaleY < 0.2 && e.Delta < 0)
                    {
                        return;
                    }
                    sfr.CenterX = centerPoint.X;
                    sfr.CenterY = centerPoint.Y;
                    sfr.ScaleX += (double)e.Delta / 3500;
                    sfr.ScaleY += (double)e.Delta / 3500;
                };
                bool isMouseLeftButtonDown = false;
                Point mouseXY;
                image1.MouseLeftButtonDown += delegate (object sender, MouseButtonEventArgs e)
                {
                    isMouseLeftButtonDown = true;
                    mouseXY = e.GetPosition(image1);
                };
                image1.MouseLeftButtonUp += delegate (object sender, MouseButtonEventArgs e)
                {
                    isMouseLeftButtonDown = false;
                };
                image1.MouseMove += delegate (object sender, MouseEventArgs e)
                {
                    if (isMouseLeftButtonDown == true)
                    {
                        Point position = e.GetPosition(image1);
                        tlt.X += position.X - mouseXY.X;
                        tlt.Y += position.Y - mouseXY.Y;
                    }
                };
            }


        }

    }



}
