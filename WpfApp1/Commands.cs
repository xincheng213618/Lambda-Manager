using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Solution
{
    public static class Commands
    {
        /// <summary>
        /// 重命名
        /// </summary>
       public static RoutedUICommand ReName = new RoutedUICommand("重命名", "重命名", typeof(Commands),new InputGestureCollection(new[] { new KeyGesture(Key.F2, ModifierKeys.None, "F2") }));

    }
}
