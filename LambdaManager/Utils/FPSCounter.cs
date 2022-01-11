using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;

namespace LambdaManager.Utils;

internal class FPSCounter
{
	internal TextBlock CameraStateBlock;

	internal int Counter;

	internal DateTime Start = DateTime.Now;

	public FPSCounter(TextBlock block)
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
			object state = Application.Current.Resources["CameraRunning"];
			TextBlock cameraStateBlock = CameraStateBlock;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 2);
			defaultInterpolatedStringHandler.AppendFormatted<object>(state);
			defaultInterpolatedStringHandler.AppendLiteral("[fps: ");
			defaultInterpolatedStringHandler.AppendFormatted(fps, "#.#");
			defaultInterpolatedStringHandler.AppendLiteral("]");
			cameraStateBlock.Text = defaultInterpolatedStringHandler.ToStringAndClear();
			Counter = 0;
			Start = DateTime.Now;
		}
		else
		{
			Counter++;
		}
	}
}
