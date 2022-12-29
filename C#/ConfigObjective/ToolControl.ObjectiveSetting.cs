using Global.Mode.Config;
using Global.UserControls.DrawVisual;
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
                    Margin = new Thickness(20, 0, 20, 0),
                    Content = item.Magnitude,
                    IsChecked = item.IsChecked,
                    IsEnabled = item.IsEnabled, FontSize = 14
                };
                radioButton.Checked += delegate
                {
                   
                    Dictionary<string, object> values = new Dictionary<string, object>()
                    {
                        {"magnitude",item.ID },
                        {"na",(double)(item.NA) },
                    };
                    LambdaControl.Trigger("OBJECTIVE_LENS_SETTING", this, values);
                    windowData.SolutionConfig.CurrentObjective = item.ID;
                    ObjFoldText.Text = radioButton.Content.ToString();
                    UpdateBinding(windowData.SolutionConfig.IsMultiObj.Enable== true,OperatingMode, item.ID);
                    LensFactorChange(item.ID);
                    //物镜切换，标记尺寸失效
                    foreach(InkVisual item in Global.DrawInkMethod.InkAll)
                    {
                        if (item != null)
                        {
                            item.inkcanva.Strokes.Clear();
                            item.defDim.Visibility = Visibility.Hidden;
                        }
                    }
                    if (windowData.ImageViewState.toolTop.DimensionChecked)
                    {
                        windowData.ImageViewState.toolTop.DimensionChecked=false;
                    }


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

        private void LensFactorChange(int Id)
        {
            switch (Id)
            {

                case 0:
                    Global.DrawInkMethod.lens.factor = 1;
                    break;
                case 1:
                    Global.DrawInkMethod.lens.factor = 1;
                    break;
                case 2:
                    Global.DrawInkMethod.lens.factor = 0.5;
                    break;
                case 3:
                    Global.DrawInkMethod.lens.factor = 0.25;
                    break;
                case 4:
                    Global.DrawInkMethod.lens.factor = 1;
                    break;
                default:
                    Global.DrawInkMethod.lens.factor = 1;
                    break;

            }


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
            switch (viewMode)
            {

                case 0:
                   return windowData.SolutionConfig.OperatingMode.BrightField.CameraSetting;
                    break;
                case 1:
                    return windowData.SolutionConfig.OperatingMode.DarkField.CameraSetting;
                    break;
                case 2:
                    return windowData.SolutionConfig.OperatingMode.Reinberg.CameraSetting;
                    break;
                case 3:
                    return windowData.SolutionConfig.OperatingMode.ReliefContrast.CameraSetting;
                    break;
                case 5:
                    return windowData.SolutionConfig.OperatingMode.PhaseContrast.CameraSetting;
                    break;
                case 4:
                    return windowData.SolutionConfig.OperatingMode.QuantitativePhase.CameraSetting;
                    break;
                default: return null;

            }




        }





    }
}
