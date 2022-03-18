using HotKey;
using HotKey.GlobalHotKey;
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
        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void TextBox_PreviewKeyDown(object sender, KeyEventArgs e)
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
            if (modifiers == ModifierKeys.None &&(key == Key.Delete || key == Key.Back || key == Key.Escape))
            {
                textBox.Text = "";
                HotKeys.Hotkey = null;
                return;
            }

            // If no actual key was pressed - return
            if (key == Key.LeftCtrl || key == Key.RightCtrl || key == Key.LeftAlt || key == Key.RightAlt || key == Key.LeftShift || key == Key.RightShift || key == Key.LWin || key == Key.RWin || key == Key.Clear || key == Key.OemClear || key == Key.Apps) return;

            // Update the value
            HotKeys.Hotkey = new Hotkey(key, modifiers);
            textBox.Text = HotKeys.Hotkey.ToString();
        }
        HotKeys HotKeys;

        private void Window_Initialized(object sender, EventArgs e)
        {
            HotKeys = new HotKeys();
            HotKeys.FunctionName = "22";
            HotKeys.hotKeyHandler = MsgShow;
            this.DataContext = HotKeys;
        }

        private void MsgShow()
        {
            MessageBox.Show("2222222");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GlobalHotKeyManager globalHotKeyManager = new GlobalHotKeyManager(this);
            HotKeys.Sucess = globalHotKeyManager.Register(HotKeys.Hotkey, HotKeys.hotKeyHandler);
        }
    }



}
