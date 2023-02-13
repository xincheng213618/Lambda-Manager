﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace HotKey.WindowHotKey
{
    public class WindowHotKey
    {
        /// <summary>
        /// AllKeyMap
        /// </summary>
        static Dictionary<int, HotKeyCallBackHanlder> AllKeyMap = new Dictionary<int, HotKeyCallBackHanlder>();
        
        static List<Control> ControlHook = new List<Control>();
        static Dictionary<Control,Dictionary<int, HotKeyCallBackHanlder>> ControlHookKeyMap = new ();


        public static bool Register(Control control,Hotkey hotkey, HotKeyCallBackHanlder callBack)
        {
            if (hotkey == null || hotkey == Hotkey.None) return false;
            if (!ControlHook.Contains(control))
            {
                control.PreviewKeyUp += (s,e)=> 
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
                    if (ControlHookKeyMap[control].TryGetValue(((int)modifiers << 8) + (int)key, out var callback))
                    {
                        callback();
                    }
                };
                ControlHook.Add(control);
                ControlHookKeyMap.Add(control, new Dictionary<int, HotKeyCallBackHanlder>());
            }
            int vk = hotkey.ToInt();
            if (AllKeyMap.ContainsKey(vk))
            {
                return false;
            }
            else
            {
                ControlHookKeyMap[control].Add(vk, callBack);
                AllKeyMap.Add(vk, callBack);
            }
            return true;
        }
        public static bool UnRegister(HotKeyCallBackHanlder callBack)
        {
            foreach (KeyValuePair<int, HotKeyCallBackHanlder> var in AllKeyMap)
            {
                if (var.Value == callBack)
                    AllKeyMap.Remove(var.Key);
            }
            foreach (var item in ControlHookKeyMap)
            {
                foreach (KeyValuePair<int, HotKeyCallBackHanlder> var in item.Value)
                {
                    if (var.Value == callBack)
                        item.Value.Remove(var.Key);
                }
            }
            return true;
        }






    }
}
