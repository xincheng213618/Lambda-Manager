using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace HotKey.WindowHotKey
{
    public static class WindowHotKey
    {
        static Dictionary<int, HotKeyCallBackHanlder> keymap = new Dictionary<int, HotKeyCallBackHanlder>();
        static Dictionary<Window, bool> WindowHook = new Dictionary<Window, bool>();

        public static bool Register(Window window,Hotkey hotkey, HotKeyCallBackHanlder callBack)
        {
            if (hotkey == null) return false;
            if (WindowHook.TryGetValue(window, out bool bool1))
            {
                if (!bool1)
                    window.PreviewKeyUp += Window_PreviewKeyUp;
            }
            else
            {
                window.PreviewKeyUp += Window_PreviewKeyUp;
                WindowHook.Add(window, true);
            }

            int vk = hotkey.ToInt();
            if (keymap.ContainsKey(vk))
            {
                keymap[vk] = callBack;
            }
            else
            {
                keymap.Add(vk, callBack);
            }
            return true;
        }
        public static bool UnRegister(HotKeyCallBackHanlder callBack)
        {
            foreach (KeyValuePair<int, HotKeyCallBackHanlder> var in keymap)
            {
                if (var.Value == callBack)
                    keymap.Remove(var.Key);
            }
            return true;
        }





        static void Window_PreviewKeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            ModifierKeys modifiers = Keyboard.Modifiers;
            if (Keyboard.IsKeyDown(Key.LWin) || Keyboard.IsKeyDown(Key.RWin))
                modifiers |= ModifierKeys.Windows;
            Key key = e.Key;

            if (key == Key.System)
                key = e.SystemKey;


            // Pressing delete, backspace or escape without modifiers clears the current value
            if (modifiers == ModifierKeys.None && (key == Key.Delete || key == Key.Back || key == Key.Escape))
            {
                return;
            }

            // If no actual key was pressed - retur
            if (key == Key.LeftCtrl || key == Key.RightCtrl || key == Key.LeftAlt || key == Key.RightAlt || key == Key.LeftShift || key == Key.RightShift || key == Key.LWin || key == Key.RWin || key == Key.Clear || key == Key.OemClear || key == Key.Apps)
                return;

            // Update the value
            if (keymap.TryGetValue(((int)modifiers >> 8) + (int)key, out var callback))
            {
                callback();
            }
        }
    }
}
