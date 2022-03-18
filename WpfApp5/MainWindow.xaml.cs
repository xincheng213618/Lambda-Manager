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
            if (key == Key.LeftCtrl || key == Key.RightCtrl || key == Key.LeftAlt || key == Key.RightAlt || key == Key.LeftShift || key == Key.RightShift || key == Key.LWin || key == Key.RWin || key == Key.Clear || key == Key.OemClear || key == Key.Apps) 
                return;

            // Update the value
            HotKeys.Hotkey = new Hotkey(key, modifiers);
            textBox.Text = HotKeys.Hotkey.ToString();
        }
        private void TextBox_PreviewKeyDown1(object sender, KeyEventArgs e)
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
                HotKeys1.Hotkey = null;
                return;
            }

            // If no actual key was pressed - return
            if (key == Key.LeftCtrl || key == Key.RightCtrl || key == Key.LeftAlt || key == Key.RightAlt || key == Key.LeftShift || key == Key.RightShift || key == Key.LWin || key == Key.RWin || key == Key.Clear || key == Key.OemClear || key == Key.Apps)
                return;

            // Update the value
            HotKeys1.Hotkey = new Hotkey(key, modifiers);
            textBox.Text = HotKeys1.Hotkey.ToString();
        }

        HotKeys HotKeys;
        HotKeys HotKeys1;


        private void Window_Initialized(object sender, EventArgs e)
        {
            HotKeys = new HotKeys();
            HotKeys.FunctionName = "22";
            HotKeys.hotKeyHandler = MsgShow;

            HotKeys1 = new HotKeys();
            HotKeys1.FunctionName = "22";
            HotKeys1.hotKeyHandler = MsgShow1;
        this.DataContext = HotKeys;
            Textbox1.DataContext = HotKeys1;    
        }

        private void MsgShow()
        {
            MessageBox.Show("2222222");
        }
        private void MsgShow1()
        {
            MessageBox.Show("2111222");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //GlobalHotKeyManager globalHotKeyManager = new GlobalHotKeyManager(this);
            //HotKeys.Sucess = globalHotKeyManager.Register(HotKeys.Hotkey, HotKeys.hotKeyHandler);

            WindowHotKeyManager windowHotKeyManager = WindowHotKeyManager.GetInstance(this);
            HotKeys.Sucess =windowHotKeyManager.Register(HotKeys.Hotkey, HotKeys.hotKeyHandler);
        }


        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            WindowHotKeyManager windowHotKeyManager = WindowHotKeyManager.GetInstance(this);
            HotKeys1.Sucess = windowHotKeyManager.Register(HotKeys1.Hotkey, HotKeys1.hotKeyHandler);
        }
    }



}
