using System;
using System.Text;
using System.Windows.Input;

namespace HotKey
{
    [Serializable]
    public class Hotkey
    {
        public Key Key { get; }
        public ModifierKeys Modifiers { get; }
        public Hotkey(Key key, ModifierKeys modifiers)
        {
            Key = key;
            Modifiers = modifiers;
        }
        public int ToInt()
        {
            return (int)Modifiers>>8+ (int)Key;
        }

        public override string ToString()
        {
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
