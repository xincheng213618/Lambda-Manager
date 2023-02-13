using HotKey;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Solution
{
    /// <summary>
    /// HotKeyManger.xaml 的交互逻辑
    /// </summary>
    public partial class HotKeyManger : Window
    {
        List<HotKeys> hotKeysList;
        public HotKeyManger(List<HotKeys> hotKeysList)
        {
            InitializeComponent();
            this.hotKeysList = hotKeysList;
            foreach (HotKeys hotKeys in hotKeysList)
            {
                HotKeyStackPanel.Children.Add(new HoyKeyControl(hotKeys));
            }
        }
    }
}
