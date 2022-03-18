using HotKey;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

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
            //border1.Width = slider1.Value;
            //border1.Height = slider1.Value * (this.Height - 50) / (this.Width);
        }

        private void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            try
            {
                //border1.Width = slider1.Value;
                //border1.Height = slider1.Value * (this.Height - 50) / (this.Width);
            }
            catch
            {

            }
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

    }



}
