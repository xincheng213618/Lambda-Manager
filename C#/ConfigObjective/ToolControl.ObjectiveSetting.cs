using Global.Mode.Config;
using Lambda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

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
                radioButton.Checked += delegate
                {
                    if (item.ID == 0)
                    {
                        windowData.SolutionConfig.IsMultiObj.Enable = true;
                        return;
                    }
                    Dictionary<string, object> values = new Dictionary<string, object>()
                    {
                        {"magnitude",item.ID },
                        {"na",(double)(item.NA) },
                    };
                    LambdaControl.Trigger("OBJECTIVE_LENS_SETTING", this, values);
                    windowData.SolutionConfig.CurrentObjective = item.ID;
                   
                  
                    UpdateBinding(windowData.SolutionConfig.IsMultiObj.Enable== true,OperatingMode, item.ID);
                    
                };
               
                ObjectiveSettingStackPanel.Children.Add(radioButton);
            }
        }
       
        private void UpdateBinding( bool mutiObj, OperatingMode operatingMode, int  ID)
        {
            if (!mutiObj) return;

            UpdateObjBinding(operatingMode, ID);
            ledDiameterBind(ID);

        }



        public void UpdateObjBinding(OperatingMode operatingMode, int Id)
        {

           updateGainBinding(operatingMode.SelectViewMode, Id);
           // updateGainAndEXposBinding1(Id);
        }
        public void updateGainBinding(int viewMode,int Id)
        {
            Camera camera;
            camera = SwitchViewMode(viewMode);

            BindingOperations.ClearBinding(Slider211, Slider.ValueProperty);
            string BindGain = "Gain" + Id.ToString();
            Binding bindingBFGain = new Binding(BindGain);
            bindingBFGain.Source = camera.MultiObjGain;
            bindingBFGain.Mode = BindingMode.TwoWay;
            Slider211.SetBinding(Slider.ValueProperty, bindingBFGain);

            BindingOperations.ClearBinding(Slider212, Slider.ValueProperty);
            string BindExposure = "Exposure" + Id.ToString();
            Binding bindingBFExpo = new Binding(BindExposure);
            bindingBFExpo.Source = camera.MultiObjExposure;
            bindingBFExpo.Mode = BindingMode.TwoWay;
            Slider212.SetBinding(Slider.ValueProperty, bindingBFExpo);

        }
       


        private void ledDiameterBind(int Id)
        {

            BindingOperations.ClearBinding(Slider311, Slider.ValueProperty);
            string BindOuter = "Outer" + Id.ToString();
            Binding binding1 = new Binding(BindOuter);
            binding1.Mode = BindingMode.TwoWay;
            binding1.Source = windowData.SolutionConfig.OperatingMode.BrightField.MultiAperture;
            Slider311.SetBinding(Slider.ValueProperty, binding1);

        }
       

        private Camera SwitchViewMode( int viewMode)
        {
            return viewMode switch
            {
                0 => windowData.SolutionConfig.OperatingMode.BrightField.CameraSetting,
                1 => windowData.SolutionConfig.OperatingMode.DarkField.CameraSetting,
                2 => windowData.SolutionConfig.OperatingMode.Reinberg.CameraSetting,
                3 => windowData.SolutionConfig.OperatingMode.ReliefContrast.CameraSetting,
                4 => windowData.SolutionConfig.OperatingMode.QuantitativePhase.CameraSetting,
                5 => windowData.SolutionConfig.OperatingMode.PhaseContrast.CameraSetting,
                _ => null
            };
        }





    }
}
