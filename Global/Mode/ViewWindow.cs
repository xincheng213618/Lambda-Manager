using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Global.Mode
{
    public class ViewWindow:ModeBaseObject
    {
        private bool isFourWindow = false;
        public bool IsFourWindow
        {
            get { return isFourWindow; }
            set { isFourWindow = value; NotifyPropertyChanged(); }
        }

        private Visibility isFourWindowVisibility = Visibility.Visible;
        public Visibility IsFourWindowVisibility
        {
            get { return isFourWindowVisibility; }
            set { isFourWindowVisibility = value; NotifyPropertyChanged(); }
        }


    }
}
