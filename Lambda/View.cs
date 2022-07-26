using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;

namespace Lambda
{
    public enum ViewState
    {
        UNINITIALIZED,
        OCCUPIED,
        RUNING,
        CLOSED
    }

    /// <summary>
    /// View索引改变时
    /// </summary>
    public delegate void ViewIndexChangedEventHandler(object sender, EventArgs e);

    public delegate void ViewStateEventChangedHandler(object sender, EventArgs e);

    public class View : INotifyPropertyChanged
    {
        public event ViewStateEventChangedHandler ViewStateEventChanged;


        public event PropertyChangedEventHandler? PropertyChanged;
        public void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Image Image { get; set; }

        private int _index;
        public int Index
        {
            get { return _index; }
            set { _index = value; NotifyPropertyChanged(); }
        }


        private ViewState _State =ViewState.UNINITIALIZED;

        public ViewState State
        {
            get { return _State; }
            set {
                if (_State != value)
                {
                    _State = value;
                    ViewStateEventChanged?.Invoke(this, new EventArgs());
                    NotifyPropertyChanged();
                }
            }
        }



        public View(Image image, int index)
        {
            Image = image;
            Index = index;
        }
    }
}


