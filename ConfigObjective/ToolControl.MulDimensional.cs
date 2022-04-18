﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ConfigObjective
{
    public partial class ToolControl
    {
        public void MulDimensional_Initialized()
        {
            var MulDimensional = WindowData.MulDimensional;
            TextBoxZstart.Text = MulDimensional.ZStart.ToString();
            TextBoxZend.Text = MulDimensional.ZEnd.ToString();
            TextBoxZStep.Text = MulDimensional.Zstep.ToString();
            var timeWiseSerial = WindowData.Config.Dimensional.TimeWiseSerial;
            MulDimensional.TNumberEnable = timeWiseSerial.Times == 0;
            MulDimensional.TNumber = timeWiseSerial.Times;
            MulDimensional.TIntervalEnable = timeWiseSerial.Duration == 0;
            MulDimensional.TInterval = timeWiseSerial.Duration;

            var Dimensions = WindowData.Config.Dimensional.Dimensions;
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
                WindowData.Config.Dimensional.Dimensions = "xy";
                ToggleButton501.IsChecked = true;
                ToggleButton502.IsChecked = true;
            }


            var mode = WindowData.Config.Dimensional.Mode;

            checkbox51.IsChecked = mode.Contains(0);
            checkbox52.IsChecked = mode.Contains(1);
            checkbox53.IsChecked = mode.Contains(2);
            checkbox54.IsChecked = mode.Contains(3);
            checkbox55.IsChecked = mode.Contains(4);
            checkbox56.IsChecked = mode.Contains(5);

        }
        private void UpdateMulZstart_Click(object sender, RoutedEventArgs e)
        {
            var MulDimensional = WindowData.MulDimensional;
            MulDimensional.ZStart = int.Parse(TextBoxZstart.Text);
        }
        private void UpdateMulZend_Click(object sender, RoutedEventArgs e)
        {
            var MulDimensional = WindowData.MulDimensional;
            MulDimensional.ZEnd = int.Parse(TextBoxZend.Text);
        }
        private void UpdateMulZStep_Click(object sender, RoutedEventArgs e)
        {
            var MulDimensional = WindowData.MulDimensional;
            MulDimensional.Zstep = int.Parse(TextBoxZStep.Text);
        }
    }
}
