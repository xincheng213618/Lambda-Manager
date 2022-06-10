using Global;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using Lambda;
using System.Windows.Input;
using Global.Mode.Config;
using System.Text;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using Global.Common.Extensions;

namespace ConfigObjective
{
	public partial class ToolControl
	{
		private void AddEventHandler()
		{
			LambdaControl.AddLambdaEventHandler("STOP_ACQUIRE", STOP_ACQUIRE, false);
		}

		private bool STOP_ACQUIRE(object sender, EventArgs e)
		{
			var mulDimensional = WindowData.MulDimensional;
			mulDimensional.mulDimensionalAreas.Clear();
			mulDimensional.mulDimensionalPoints.Clear();

			List<System.Windows.Shapes.Rectangle> childList = GetChildObjects<System.Windows.Shapes.Rectangle>(this.Canvas1);
			foreach (var child in childList)
			{
				if (Canvas.GetLeft(child) >= 0)
					if (child.Width == 0 || child.Height == 0)
					{
						mulDimensional.mulDimensionalPoints.Add(new MulDimensionalPoint(new Point(Canvas.GetLeft(child), Canvas.GetTop(child))));
					}
					else
					{
						if (child.Width > 10)
							mulDimensional.mulDimensionalAreas.Add(new MulDimensionalArea(new Rect(Canvas.GetLeft(child), Canvas.GetTop(child), child.Width, child.Height)));

					}

			}
			List<Border> childList1 = GetChildObjects<Border>(this.Canvas1);
			foreach (var child in childList1)
			{
				if (Canvas.GetLeft(child) >= 0)
					if (child.Width == 0 || child.Height == 0)
					{
						mulDimensional.mulDimensionalPoints.Add(new MulDimensionalPoint(new Point(Canvas.GetLeft(child), Canvas.GetTop(child))));
					}
					else
					{
						if (child.Width > 10)
							mulDimensional.mulDimensionalAreas.Add(new MulDimensionalArea(new Rect(Canvas.GetLeft(child), Canvas.GetTop(child), child.Width, child.Height)));
					}

			}
			var spot = new Global.Mode.Config.Spot();
			foreach (var item in mulDimensional.mulDimensionalPoints)
			{
				List<int> points = new List<int>() { item.X, item.Y };
				spot.Includes.Add(points);
			}
			foreach (var item in mulDimensional.mulDimensionalAreas)
			{
				List<int> points = new List<int>() { item.X, item.Y, item.Width, item.Height };
				spot.Includes.Add(points);
			}
			TestMean testMean = new TestMean();
			testMean.Spot = spot;

			List<string> Mode = new();
			if (checkbox51.IsChecked == true)
				Mode.Add("bright-field");
			if (checkbox52.IsChecked == true)
				Mode.Add("dark-field");
			if (checkbox53.IsChecked == true)
				Mode.Add("rheinberg");
			if (checkbox54.IsChecked == true)
				Mode.Add("relief-contrast");
			if (checkbox55.IsChecked == true)
				Mode.Add("quantitative-phase");
			if (checkbox56.IsChecked == true)
				Mode.Add("phase-contrast");

			testMean.Dimensional = new Global.Mode.Config.Dimensional() { Mode = Mode };


			Global.Mode.Config.TimeWiseSerial timeWiseSerial = new Global.Mode.Config.TimeWiseSerial();


			timeWiseSerial.Times = mulDimensional.TNumberEnable ? 0 : mulDimensional.TNumber;
			timeWiseSerial.Duration = mulDimensional.TIntervalEnable ? 0 : mulDimensional.TInterval;

			testMean.Dimensional.TimeWiseSerial = timeWiseSerial;

			Global.Mode.Config.ZstackWiseSerial zstackWiseSerial = new Global.Mode.Config.ZstackWiseSerial();
			zstackWiseSerial.ZStep = mulDimensional.Zstep;
			zstackWiseSerial.ZBegin = mulDimensional.ZStart;
			zstackWiseSerial.ZEnd = mulDimensional.ZEnd;
			testMean.Dimensional.ZstackWiseSerial = zstackWiseSerial;

			var Dimensions = new StringBuilder();

			Dimensions.Append("xy");
			if (ToggleButton503.IsChecked == true)
				Dimensions.Append('z');
			if (ToggleButton504.IsChecked == true)
				Dimensions.Append('t');
			if (ToggleButton506.IsChecked == true)
				Dimensions.Append('p');
			if (ToggleButton505.IsChecked == true)
				Dimensions.Append("edof");


			testMean.Dimensional.Dimensions = Dimensions.ToString();
			testMean.Dimensional.Savedir = WindowData.SolutionDir;

			testMean.Stage = WindowData.Stage;
			WindowData.Config.Dimensional = testMean.Dimensional;
			WindowData.Config.Spot = testMean.Spot;
			WindowData.Config.Stage = testMean.Stage;
			LambdaControl.Trigger("START_ACQUIRE1", this, testMean.ToJson());
			return true;
        }
	}
}
