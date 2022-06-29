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
using ConfigObjective.UserControls;

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

		

			var spot = new Global.Mode.Config.Spot();
            foreach (var item in Map.selectedPoints)
            {
                List<int> selectedpoint = new List<int>() { (int)item.X, (int)item.Y };
                spot.Includes.Add(selectedpoint);
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
			//MessageBox.Show(testMean.ToJson());
			return true;
        }
	}
}
