﻿using System.Windows.Input;

namespace XSolution
{
    public static class Commands
    {
        /// <summary>
        /// 重命名
        /// </summary>
       public static RoutedUICommand ReName = new("重命名(_M)", "重命名(_M)", typeof(Commands),new InputGestureCollection(new[] { new KeyGesture(Key.F2, ModifierKeys.None, "F2") }));

    }
}
