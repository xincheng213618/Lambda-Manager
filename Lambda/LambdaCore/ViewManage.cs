using Lambda;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Media.Imaging;

namespace LambdaCore
{

    public class ViewChangedEvent : EventArgs
    {
        public View View { get; set; }
        public WriteableBitmap WriteableBitmap { get; set; }
    }




    public delegate void ViewChangedEventHandler(object sender, ViewChangedEvent e);

    public class ViewManager : INotifyPropertyChanged
    {
        private static ViewManager instance;
        private static readonly object locker = new();
        public static ViewManager GetInstance() { lock (locker) { return instance ??= new ViewManager(); } }

        public static List<View> Views;

        public event PropertyChangedEventHandler? PropertyChanged;
        public void NotifyPropertyChanged([CallerMemberName] string propertyName = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));


        Timer timer;
        public ViewManager()
        {
             timer = new Timer(TimeRun, null, 0, 1000);
        }

        private DateTime Start = DateTime.Now;
        private void TimeRun(object state)
        {
            if (TimerCounter != 0)
            {
                double fps = TimerCounter / (DateTime.Now - Start).TotalSeconds;
                AllFPS = fps.ToString("0.0");
                TimerCounter = 0;
                Start = DateTime.Now;
            }
        }
        public event ViewChangedEventHandler ViewChanged;

        public void Add(View view)
        {
            ViewChanged?.Invoke(this, new ViewChangedEvent() { View = view, WriteableBitmap = view.Image.Source as WriteableBitmap  });
            Views.Add(view);
        }


        public string AllFPS { get => _AllFPS; set { _AllFPS = value; NotifyPropertyChanged(); } }
        private string _AllFPS;

        private int Counter = 0;
        private int TimerCounter = 0;


        public void Inc()
        {
            Counter++;
            TimerCounter++;
        }
    }
}
