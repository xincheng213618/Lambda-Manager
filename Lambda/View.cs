using System;
using System.ComponentModel;
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

    public delegate void ViewIndexChangedEventHandler(object sender, EventArgs e);

    public delegate void ViewStateEventChangedHandler(object sender, EventArgs e);

    public class View
    {
        public event ViewStateEventChangedHandler ViewStateEventChanged;

        public Image Image { get; set; }

        public int Index { get; set; }

        private ViewState _State =ViewState.UNINITIALIZED;

        public ViewState State
        {
            get { return _State; }
            set {
                if (_State != value)
                {
                    _State = value;
                    ViewStateEventChanged?.Invoke(this, new EventArgs());
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


