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
        private int viewNums = 0;
        public int ViewNums
        {
            get { return viewNums; }
            set { viewNums = value; NotifyPropertyChanged(); }
        }
        private Visibility viewVisibility0 = Visibility.Visible;
        public Visibility ViewVisibility0
        {
            get { return viewVisibility0; }
            set { viewVisibility0 = value; NotifyPropertyChanged(); }
        }

        private Visibility viewVisibility1 = Visibility.Visible;
        public Visibility ViewVisibility1
        {
            get { return viewVisibility1; }
            set { viewVisibility1 = value; NotifyPropertyChanged(); }
        }
        private Visibility viewVisibility2 = Visibility.Visible;
        public Visibility ViewVisibility2
        {
            get { return viewVisibility2; }
            set { viewVisibility2 = value; NotifyPropertyChanged(); }
        }
        private Visibility viewVisibility3 = Visibility.Visible;
        public Visibility ViewVisibility3
        {
            get { return viewVisibility3; }
            set { viewVisibility3 = value; NotifyPropertyChanged(); }
        }
        private Visibility viewVisibility4 = Visibility.Visible;
        public Visibility ViewVisibility4
        {
            get { return viewVisibility4; }
            set { viewVisibility4 = value; NotifyPropertyChanged(); }
        }
        private Visibility viewVisibility5 = Visibility.Visible;

        public Visibility ViewVisibility5
        {
            get { return viewVisibility5; }
            set { viewVisibility5 = value; NotifyPropertyChanged(); }
        }



    }
}
