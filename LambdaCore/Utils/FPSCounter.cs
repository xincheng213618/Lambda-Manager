using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;

namespace LambdaManager.Utils;

public class FPSCounter: INotifyPropertyChanged
{
	private string fps;

    public string FPS
    {
        get { return fps; }
        set { fps = value; NotifyPropertyChanged(); }
    }
    public void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public int Counter;

	public DateTime Start = DateTime.Now;

	public event PropertyChangedEventHandler PropertyChanged;

	public void Inc()
	{
		if (Counter == 0)
		{
			Start = DateTime.Now;
		}
		if (Counter == 30)
		{
			double fps = 30.0 / (DateTime.Now - Start).TotalSeconds;
            FPS = fps.ToString("0.0");
			Counter = 0;
			Start = DateTime.Now;
		}
		else
		{
			Counter++;
		}
	}
}
