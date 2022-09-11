using Lambda;
using LambdaUtils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace LambdaCore
{

    public class ViewChangedEvent : EventArgs
    {
        public View View { get; set; }
        public WriteableBitmap WriteableBitmap { get; set; }
    }

    public delegate void ViewChangedEventHandler(object sender, ViewChangedEvent e);

    public class ViewManager: INotifyPropertyChanged
    {
        private static ViewManager instance;
        private static readonly object locker = new();

        public static ViewManager GetInstance()
        {
            lock (locker) { instance ??= new ViewManager(); }
            return instance;
        }



        public ViewChangedEventHandler ViewChanged;


        public void Add(View view)
        {
            System.Windows.Application.Current.Dispatcher.Invoke(delegate
            {
                if (view.Image.Source is WriteableBitmap writeableBitmap)
                {
                    ViewChanged?.Invoke(this, new ViewChangedEvent() { View = view, WriteableBitmap = writeableBitmap });
                }
                else
                {
                    ViewChanged?.Invoke(this, new ViewChangedEvent() { View = view, WriteableBitmap = null });
                }
            });

        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private string fps;
        public string AllFPS
        {
            get { return fps; }
            set { fps = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AllFPS))); }
        }
        private int Counter = 0;
        private DateTime Start = DateTime.Now;

        public void Inc()
        {
            Counter++;
            if (Counter % 30 == 0)
            {
                double fps = 30.0 / (DateTime.Now - Start).TotalSeconds;
                AllFPS = fps.ToString("0.0");
                Start = DateTime.Now;
            }
        }





    }
}
