using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ConfigObjective
{
    /// <summary>
    /// UpDownControl.xaml 的交互逻辑
    /// </summary>
    public partial class UpDownControl : UserControl ,INotifyPropertyChanged
    {
        public UpDownControl()
        {
            InitializeComponent();
            txt_NamberChange.DataContext = this;
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        public void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public delegate void SelectionChangedEventArgs(object sender, RoutedEventArgs e);

        public event SelectionChangedEventArgs SelectionChanged;    

        private string selectValue;

        public string SelectValue
        {
            get { return selectValue; }
            set
            {
                selectValue = value;
                NotifyPropertyChanged();
            }
        }


        private List<string>? comboxlist = new List<string>();
        private int selectedIndex=0;

        public int SelectedIndex
        {
            get { return selectedIndex; }
            set
            {
                selectedIndex = value;
                Update();
                NotifyPropertyChanged();
                SelectionChanged?.Invoke(this, new RoutedEventArgs());
            }
        }


        public void SetList(List<string> list)
        {
            comboxlist = list;
            if (comboxlist != null)
            {
                if (SelectedIndex > comboxlist.Count)
                    SelectedIndex = comboxlist.Count;
                SelectValue = comboxlist[SelectedIndex];
            }
        }

        private void btn_ClickUp_Click(object sender, RoutedEventArgs e)
        {
            SelectedIndex = ++SelectedIndex % comboxlist.Count;
        }

        private void Update()
        {
            if (selectedIndex > -1 && selectedIndex< comboxlist.Count)
            SelectValue = comboxlist[SelectedIndex];
        }


        private void btn_ClickDown_Click(object sender, RoutedEventArgs e)
        {
            SelectedIndex = --SelectedIndex % comboxlist.Count;
            SelectedIndex = SelectedIndex < 0 ? comboxlist.Count - 1 : SelectedIndex;
        }
    }
}
