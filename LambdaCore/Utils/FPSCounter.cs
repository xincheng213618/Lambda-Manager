using LambdaManager.Core;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;

namespace LambdaManager.Utils;

public class FPSCounter : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    /// <summary>
    /// 触发消息通知事件
    /// </summary>
    /// <param name="propertyName"></param>
    public void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    private string fps;

    public string FPS
	{
		get { return fps; }
		set { fps = value; NotifyPropertyChanged(); }
	}

	internal int Counter;

	internal DateTime Start = DateTime.Now;

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
