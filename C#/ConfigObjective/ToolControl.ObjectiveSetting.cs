﻿using Lambda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ConfigObjective
{
    public partial class ToolControl
    {
        private void ObjectiveSetting_Initialize()
        {
            ObjectiveSettingStackPanel.Children.Clear();
            foreach (var item in windowData.deviceInformation.ObjectiveSettings)
            {
                RadioButton radioButton = new RadioButton
                {
                    Style = FindResource("ToggleButtonStyle1") as Style,
                    Width = 55,
                    Margin = new Thickness(5, 0, 5, 0),
                    Content = item.Magnitude,
                    IsChecked = item.IsChecked,
                    IsEnabled = item.IsEnabled, FontSize = 14
                };
                radioButton.Click += delegate
                {
                    Dictionary<string, object> values = new Dictionary<string, object>()
                    {
                        {"magnitude",item.ID },
                        {"na",(double)(item.NA) },
                    };
                    LambdaControl.Trigger("OBJECTIVE_LENS_SETTING", this, values);
                };
                ObjectiveSettingStackPanel.Children.Add(radioButton);
            }
        }
        private void ObjectiveSetting_Update()
        {

        }


    }
}
