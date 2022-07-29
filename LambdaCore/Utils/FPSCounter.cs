using System;
using System.Runtime.CompilerServices;
using System.Windows.Controls;

namespace LambdaManager.Utils;

public class FPSCounter 
{
	private string fps;

    public string FPS
    {
        get { return fps; }
        set { fps = value;  }
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
