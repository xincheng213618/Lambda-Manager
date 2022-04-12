using System;
using System.Runtime.CompilerServices;
using System.Windows.Controls;

namespace LambdaManager.Utils;

internal class FPSCounter
{
	internal TextBox CameraStateBlock;

	internal int Counter;

	internal DateTime Start = DateTime.Now;

	public FPSCounter(TextBox block)
	{
		CameraStateBlock = block;
	}

	public void Inc()
	{
		if (Counter == 0)
		{
			Start = DateTime.Now;
		}
		if (Counter == 30)
		{
			double fps = 30.0 / (DateTime.Now - Start).TotalSeconds;
			TextBox cameraStateBlock = CameraStateBlock;
			cameraStateBlock.Text = fps.ToString("0.0");
			Counter = 0;
			Start = DateTime.Now;
		}
		else
		{
			Counter++;
		}
	}
}
