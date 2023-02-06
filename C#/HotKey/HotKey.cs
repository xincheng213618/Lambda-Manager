using System;
using System.Text;
using System.Windows.Input;

namespace HotKey
{
    public static class HotKeyExtension
    {
        public static int ToInt(this Hotkey hotkey)
        {
            return ((int)hotkey.Modifiers << 8) + (int)hotkey.Key;
        }
    }


    [Serializable]
    public class Hotkey
    {
        public readonly static Hotkey None = new (Key.None,ModifierKeys.None);

        public Key Key { get; }
        public ModifierKeys Modifiers { get; }

        public Hotkey(Key key, ModifierKeys modifiers)
        {
            Key = key;
            Modifiers = modifiers;
        }

        public override string ToString()
        {
            if (Key == Key.None && Modifiers == ModifierKeys.None)
                return "< None >";

            var str = new StringBuilder();
            if (Modifiers.HasFlag(ModifierKeys.Windows))
                str.Append("Win + ");
            if (Modifiers.HasFlag(ModifierKeys.Control))
                str.Append("Ctrl + ");
            if (Modifiers.HasFlag(ModifierKeys.Shift))
                str.Append("Shift + ");
            if (Modifiers.HasFlag(ModifierKeys.Alt))
                str.Append("Alt + ");

            str.Append(Key);
            return str.ToString();
        }
    }
}
