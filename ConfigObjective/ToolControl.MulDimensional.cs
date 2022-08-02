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
            StackPanelMul.DataContext = windowData.MulDimensional;
            focusModePanel.DataContext = windowData.MulDimensional;
            focusModeLab.DataContext = windowData.MulDimensional;
            MulSummaryUniformGrid.DataContext = windowData.mulSummary;

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
            MulDimensional.TIntervalEnable = timeWiseSerial.Duration == 0;
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
            windowData.MulDimensional.ZEnd = windowData.WindowMsg.StageZ;
        }

        private void UpdateMulZstart_Click(object sender, RoutedEventArgs e)
        {
            windowData.MulDimensional.ZStart = windowData.WindowMsg.StageZ;
        }

        private void UpdateMulZStep_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("算法计算");
            windowData.MulDimensional.Zstep = 400;

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
    }
}
