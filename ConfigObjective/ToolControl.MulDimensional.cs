using Global.Common.Extensions;
using Global.Mode.Config;
using Lambda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ConfigObjective
{
    public partial class ToolControl
    {
        public void MulDimensional_Initialize()
        {
			//StackPanelMul.DataContext = windowData.MulDimensional;
			//focusModePanel.DataContext = windowData.MulDimensional;
			//focusModeLab.DataContext = windowData.MulDimensional;
			MulSummaryUniformGrid.DataContext = windowData.mulSummary;
			//CollectionMode.DataContext = windowData.MulDimensional;
			multiCollectionStack.DataContext = windowData.MulDimensional;
            windowData.MulDimensional.PropertyChanged += delegate
            {
				MulCollectionUpdate();
			};
            windowData.MulDimensional.UserDefined.PropertyChanged += delegate
            {
                MulCollectionUpdate();

            };
			windowData.MulDimensional.FocusImageMod.ModeList.CollectionChanged += delegate
			{
				MulCollectionUpdate();
			};
			Map.pointCollect.PropertyChanged += delegate
			{
				if (Map.pointCollect.SelectedPointsSend)
				MulCollectionUpdate();

			};


		}
        
        public void MulDimensional_Update()
        {
            var MulDimensional = windowData.MulDimensional;
            TextBoxZstart.Text = MulDimensional.ZStart.ToString();
            TextBoxZend.Text = MulDimensional.ZEnd.ToString();
            TextBoxZStep.Text = MulDimensional.Zstep.ToString();
            var timeWiseSerial = windowData.Config.Dimensional.TimeWiseSerial;

            MulDimensional.TNumberEnable = timeWiseSerial.Times == 0;
            MulDimensional.TNumber = timeWiseSerial.Times;
            MulDimensional.TIntervalEnable = timeWiseSerial.Duration == "0";
            MulDimensional.TInterval = timeWiseSerial.Duration;

            var Dimensions = windowData.Config.Dimensional.Dimensions;
            if (Dimensions != null)
            {
                ToggleButton501.IsChecked = Dimensions.Contains('x');
                ToggleButton502.IsChecked = Dimensions.Contains('y');
                ToggleButton503.IsChecked = Dimensions.Contains('z');
                ToggleButton504.IsChecked = Dimensions.Contains('t');
                ToggleButton505.IsChecked = Dimensions.Contains("edof");
                ToggleButton506.IsChecked = Dimensions.Contains('p');
            }
            else
            {
                windowData.Config.Dimensional.Dimensions = "xy";
                ToggleButton501.IsChecked = true;
                ToggleButton502.IsChecked = true;
            }


            var mode = windowData.Config.Dimensional.Mode;

            checkbox51.IsChecked = mode.Contains("bright-field");
            checkbox52.IsChecked = mode.Contains("dark-field");
            checkbox53.IsChecked = mode.Contains("rheinberg");
            checkbox54.IsChecked = mode.Contains("relief-contrast");
            checkbox55.IsChecked = mode.Contains("quantitative-phase");
            checkbox56.IsChecked = mode.Contains("phase-contrast");
          

        }
        private void UpdateMulZend_Click(object sender, RoutedEventArgs e)
        {

            LambdaControl.Trigger("MUL_ZAXIS", this, new Dictionary<string, object>() { { "mode", 1 }, { "value", windowData.MulDimensional.ZEnd }, { "zstart", 0 }, { "zend", 0 } });
        }

        private void UpdateMulZstart_Click(object sender, RoutedEventArgs e)
        {

            LambdaControl.Trigger("MUL_ZAXIS", this, new Dictionary<string, object>() { { "mode", 0 }, { "value", windowData.MulDimensional.ZStart } ,{ "zstart", 0 }, { "zend", 0 } });


        }

        private void UpdateMulZStep_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("算法计算");
            LambdaControl.Trigger("MUL_ZAXIS", this, new Dictionary<string, object>() { { "mode", 2 }, { "value", 0 }, { "zstart", 0 }, { "zend", 0 } });


        }

        private void ToggleButton503_Unchecked(object sender, RoutedEventArgs e)
        {
            ToggleButton505.IsChecked = false;
            if ((bool)ToggleButton504.IsChecked)
            {
                ZwisePanel.Visibility = Visibility.Hidden;

            }
            else
            {
                ZwisePanel.Visibility = Visibility.Collapsed;

            }
           
        }

        private void ToggleButton505_Checked(object sender, RoutedEventArgs e)
        {
            
            ToggleButton503.IsChecked = true;
        }

        public void NumberValidationTextBox(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter || e.Key == Key.Back)
            {
                return;
            }
            if ((e.Key >= Key.D0 && e.Key <= Key.D9) || (e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9) || e.Key == Key.Decimal)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

		public  void  MulCollectionUpdate( )
		{
			
			var mulDimensional = windowData.MulDimensional;
			mulDimensional.mulDimensionalAreas.Clear();
			mulDimensional.mulDimensionalPoints.Clear();
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

			Global.Mode.Config.ZstackWiseSerial zstackWiseSerial = new Global.Mode.Config.ZstackWiseSerial();
			zstackWiseSerial.ZStep = mulDimensional.Zstep;
			zstackWiseSerial.ZBegin = mulDimensional.ZStart;
			zstackWiseSerial.ZEnd = mulDimensional.ZEnd;
			zstackWiseSerial.ZAbsolute = mulDimensional.ZAbsolute;
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
			testMean.Dimensional.Savedir = windowData.SolutionDir;

			testMean.Stage = windowData.Stage;
			windowData.Config.Dimensional = testMean.Dimensional;
			windowData.Config.Spot = testMean.Spot;
			windowData.Config.Stage = testMean.Stage;

			//System.Windows.MessageBox.Show(testMean.ToJson());

			
				
			LambdaControl.Trigger("MUL_SUMMARY_UPDATE", this, testMean.ToJson());



		
		}




	}
}
