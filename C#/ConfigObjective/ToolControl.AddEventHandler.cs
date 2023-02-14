using Global.UserControls;
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
using System.Linq;
using System.Text.Json;

namespace ConfigObjective
{
	public partial class ToolControl
	{
		
		private void AddEventHandler()
		{
			LambdaControl.AddLambdaEventHandler("STOP_ACQUIRE", STOP_ACQUIRE, false);		
		}

		private void ZWiseToJson(MulDimensional mulDimensional, TestMean testMean)
        {
			Global.Mode.Config.ZstackWiseSerial zstackWiseSerial = new Global.Mode.Config.ZstackWiseSerial();
			zstackWiseSerial.ZStep = mulDimensional.Zstep;
			zstackWiseSerial.ZBegin = mulDimensional.ZStart;
			zstackWiseSerial.ZEnd = mulDimensional.ZEnd;
			zstackWiseSerial.ZAbsolute = mulDimensional.ZAbsolute;
			//zstackWiseSerial.AF.AFEnable = mulDimensional.AFEnable;
			//zstackWiseSerial.AF.Slice = mulDimensional.AFSlices;
			//zstackWiseSerial.AF.Gap = mulDimensional.AFSlicesGap;
			testMean.Dimensional.ZstackWiseSerial = zstackWiseSerial;

		}
		private void TWiseToJson(MulDimensional mulDimensional, TestMean testMean)
        {
			Global.Mode.Config.TimeWiseSerial timeWiseSerial = new Global.Mode.Config.TimeWiseSerial();
			timeWiseSerial.Times = mulDimensional.TNumberEnable ? -1 : mulDimensional.TNumber;
			timeWiseSerial.Duration = mulDimensional.TIntervalEnable ? "-1" : mulDimensional.TInterval;

			switch (mulDimensional.TIntervalUnits)
			{

				case "秒":
					timeWiseSerial.Mode = "s";
					break;
				case "分钟":
					timeWiseSerial.Mode = "min";
					break;
				case "小时":
					timeWiseSerial.Mode = "h";
					break;
				case "天":
					timeWiseSerial.Mode = "d";
					break;

				default: /* 可选的 */
					timeWiseSerial.Mode = "s";
					break;
			}
			testMean.Dimensional.TimeWiseSerial = timeWiseSerial;
		
		}

		private void FocusModeToJson(MulDimensional mulDimensional, TestMean testMean)
        {

			Global.Mode.Config.Optimized optimized = new Optimized();
			optimized.Optimize = mulDimensional.OptimizedSel;
			// focus-mode
			if (mulDimensional.OptimizedSel)
			{
				optimized.IsGlobal = mulDimensional.Optimized.IsGlobal;
				optimized.IsLocal = mulDimensional.Optimized.IsLocal;
				optimized.Global = mulDimensional.Optimized.Global;
				optimized.Local = mulDimensional.Optimized.Local;
				optimized.Precision = mulDimensional.Optimized.Precision;
			}
			else if (!mulDimensional.OptimizedSel)
			{

				optimized.IsGlobal = mulDimensional.UserDefined.IsGlobal;
				optimized.IsLocal = mulDimensional.UserDefined.IsLocal;
				optimized.Global = mulDimensional.UserDefined.Global;
				optimized.Local = mulDimensional.UserDefined.Local;
				optimized.Precision = mulDimensional.UserDefined.Precision;
			}
			Global.Mode.Config.Twise twise = new Twise();
			// t-wise
			if (mulDimensional.TFirst)
			{
				twise.Interval = "first";

			}
			else if (mulDimensional.TEvery)
			{
				twise.Interval = "every";
			}
			else if (mulDimensional.TN)
			{
				twise.Interval = mulDimensional.TWiseN.ToString();

			}
			else if (mulDimensional.TwiseEnable)
			{
				twise.Interval = "null";

			}
			testMean.Dimensional.Focusmode.Twise = twise;
			Global.Mode.Config.Pwise pwise = new Pwise();
			//p-wise
			if (mulDimensional.PFirst)
			{
				pwise.Interval = "first";

			}
			else if (mulDimensional.PEvery)
			{
				pwise.Interval = "every";
			}
			else if (mulDimensional.PN)
			{
				pwise.Interval = mulDimensional.PWiseN.ToString();

			}
			else if (mulDimensional.PwiseEnable)
			{
				pwise.Interval = "null";
			}

			testMean.Dimensional.Focusmode.Pwise = pwise;
			testMean.Dimensional.Focusmode.Optimized = optimized;


			if (mulDimensional.FocusImageMod != null)
			{
				if (mulDimensional.FocusImageMod.FocusImageModeSel != null)
				{
					switch (mulDimensional.FocusImageMod.FocusImageModeSel.mode)
					{
						case "明场":
							testMean.Dimensional.Focusmode.FocusModeSelect = "bright-field";
							break;
						case "暗场":
							testMean.Dimensional.Focusmode.FocusModeSelect = "dark-field";
							break;
						case "莱茵":
							testMean.Dimensional.Focusmode.FocusModeSelect = "rheinberg";
							break;

						case "差分":
							testMean.Dimensional.Focusmode.FocusModeSelect = "relief-contrast";
							break;
						case "相差":
							testMean.Dimensional.Focusmode.FocusModeSelect = "phase-contrast";
							break;
						case "相位":
							testMean.Dimensional.Focusmode.FocusModeSelect = "quantitative-phase";
							break;
						default: /* 可选的 */
							testMean.Dimensional.Focusmode.FocusModeSelect = "";
							break;

					}

				}

			}



		}
		private void ImageModeToJson(MulDimensional mulDimensional, TestMean testMean)
        {
			List<string> Mode = new();
			if (mulDimensional.FocusImageMod.Bright == true)
				Mode.Add("bright-field");
			if (mulDimensional.FocusImageMod.Dark == true)
				Mode.Add("dark-field");
			if (mulDimensional.FocusImageMod.Rheinberg == true)
				Mode.Add("rheinberg");
			if (mulDimensional.FocusImageMod.Relief)
				Mode.Add("relief-contrast");
			if (mulDimensional.FocusImageMod.Quantitative)
				Mode.Add("quantitative-phase");
			if (mulDimensional.FocusImageMod.Phase)
				Mode.Add("phase-contrast");
			testMean.Dimensional = new Global.Mode.Config.Dimensional() { Mode = Mode };

		}

		private void DimensionsToJson(TestMean testMean)
        {
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
		}
		

		private void SpotToJson(TestMean testMean)
        {

			var spot = new Global.Mode.Config.Spot();
			List<Point> selectedPoints = new List<Point>();
			if (Map.selectedPoints.Count != 0)
			{
				selectedPoints = Map.selectedPoints.OrderBy(p => p.Y).ThenBy(p => p.X).ToList();
				foreach (var item in selectedPoints)
				{
					List<int> selectedpoint = new List<int>() { (int)item.X, (int)item.Y };
					spot.Includes.Add(selectedpoint);
				}
			}

			testMean.Spot = spot;

		}
		private void messageBox(TestMean testMean)
        {
			string message1 = "采集次数:" + windowData.mulSummary.CollectionTimes;
			string message2 = ",采集层数:" + windowData.mulSummary.CollectionLayers;
			string message3 = ",采集点数:" + windowData.mulSummary.CollectionPoints;
			string message4 = ",成像模式数:" + windowData.mulSummary.ViewModeCounts;
			string message5 = ",荧光通道数:" + windowData.mulSummary.FluorescenceChannels;

			string message6 = ",图像尺寸:" + windowData.mulSummary.ImageSize;
			string message7 = ",图像总数:" + windowData.mulSummary.ImageNums;
			string message8 = ",所需存储空间:" + windowData.mulSummary.Storage;
			string message9 = ",全部采集耗时:" + windowData.mulSummary.AllCollectionTime;
			string message10 = ",相机工作时长:" + windowData.mulSummary.CameraWorkingTime;

			string message = message1 + message2 + message3 + message4 + message5 + message6 + message7 + message8 + message9 + message10;

			MessageBoxResult result = MessageBox.Show(message, "信息提示", MessageBoxButton.OKCancel, MessageBoxImage.Information);

			if (result == MessageBoxResult.OK)
			{
				LambdaControl.Trigger("START_ACQUIRE1", this, testMean.ToJson());
			}


		}

		private bool STOP_ACQUIRE(object sender, EventArgs e)
		{
			//MessageBox.Show("1");
            var mulDimensional = windowData.MulDimensional;
			mulDimensional.mulDimensionalAreas.Clear();
			mulDimensional.mulDimensionalPoints.Clear();
			

            TestMean testMean = new TestMean();
			SpotToJson(testMean);
			ImageModeToJson(mulDimensional, testMean);
			ZWiseToJson(mulDimensional, testMean);
			TWiseToJson(mulDimensional, testMean);
			DimensionsToJson(testMean);
			FocusModeToJson(mulDimensional, testMean);
			testMean.Dimensional.Savedir = "";
			testMean.Stage = windowData.Stage;
			windowData.SolutionConfig.Dimensional = testMean.Dimensional;
			windowData.SolutionConfig.Spot = testMean.Spot;
			windowData.SolutionConfig.Stage = testMean.Stage;

			// System.Windows.MessageBox.Show(testMean.ToJson());
			string xx = JsonSerializer.Serialize(testMean);
			if (testMean.Dimensional.Mode.Count == 0)
            {
                System.Windows.MessageBox.Show("请选择成像模式  ！","信息提示",MessageBoxButton.OK,MessageBoxImage.Information);
                LambdaControl.Trigger("COLLECTION_COMPLETED", this, new Dictionary<string, object>() { });
			}
            else
            {
				
				messageBox(testMean);
			}
			
			return true;
        }
	}
}
