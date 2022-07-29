using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Global.Hardware;
using Lambda;

namespace ConfigObjective
{
    public partial class ToolControl
    {
        public void CameraSetting_Initialize()
        {
            if (Border2.DataContext is Global.Mode.Config.Camera cameraSetting)
            {
                LambdaControl.Trigger("CAMERA_SETTING_GAMMA", this, new Dictionary<string, object>() { { "mode", cameraSetting.SelectViewMode }, { "gamma", cameraSetting.Gamma } });
            }
        }
        public void CameraSetting_Update()
        {

        }

        public void CameraMode_Changed()
        {
            if (Border2.DataContext is Global.Mode.Config.Camera cameraSetting)
            {
                LambdaControl.Trigger("CAMERA_SETTING_GAMMA", this, new Dictionary<string, object>() { { "mode", cameraSetting.SelectViewMode }, { "gamma", cameraSetting.Gamma } });
            }
        }

        private void Button201_Click(object sender, RoutedEventArgs e)
        {
            if (Border2.DataContext is Global.Mode.Config.Camera cameraSetting)
                LambdaControl.Trigger("CAMERA_SETTING_RESET", this, new Dictionary<string, object>() { { "mode", cameraSetting.SelectViewMode} });
        }

        private void Button211_Click(object sender, RoutedEventArgs e)
        {
            if (Border2.DataContext is Global.Mode.Config.Camera cameraSetting)
                LambdaControl.Trigger("CAMERA_SETTING_WHITE_BALANCE", this, new Dictionary<string, object> { { "mode", cameraSetting.SelectViewMode } });
        }

        private void ToggleButton210_Click(object sender, RoutedEventArgs e)
        {
            if (Border2.DataContext is Global.Mode.Config.Camera cameraSetting)
            {
                LambdaControl.Trigger("CAMERA_SETTING_EXPOSURE_AUTO", this, new Dictionary<string, object>() { { "mode", cameraSetting.SelectViewMode }, { "auto", ToggleButton210.IsChecked } });
            }
        }


        private void ToggleButton211_Click(object sender, RoutedEventArgs e)
        {

            if (Border2.DataContext is Global.Mode.Config.Camera cameraSetting)
            {
                LambdaControl.Trigger("CAMERA_SETTING_GAIN_AUTO", this, new Dictionary<string, object>() { { "mode", cameraSetting.SelectViewMode }, { "auto", ToggleButton211.IsChecked } });
            }
        }

        private void UpDownControl_Loaded(object sender, RoutedEventArgs e)
        {
            UpDownControl upDownButton1 = sender as UpDownControl;
            upDownButton1.SetList(windowData.deviceInformation.CameraExposeShow);

        }

        private void Slider212_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Slider slider = sender as Slider;
            if (UpDownControl1 != null)
            {
                UpDownControl1.SelectedIndex = (int)slider.Value;
                ToggleButton210.IsChecked = false;
            }

            if (!windowData.ACQUIRE)
            {
                if (Slider212.Value < windowData.deviceInformation.CameraExpose.Count)
                {
                    if (Border2.DataContext is Global.Mode.Config.Camera cameraSetting)
                    {
                        Dictionary<string, object> data = new() { { "mode", cameraSetting.SelectViewMode }, { "exposure", windowData.deviceInformation.CameraExpose[(int)Slider212.Value] } };
                        LambdaControl.Trigger("CAMERA_SETTING_EXPOSURE", this, data);
                    }

                }
            }
            else
            {
                if (sliderfirst)
                {
                    var result = MessageBox.Show("是否修改当前多维采集设置", "显微镜", MessageBoxButton.YesNo);
                    if (result == MessageBoxResult.No)
                    {
                        sliderfirst = false;
                        Slider212.Value = e.OldValue;
                    }
                }
                else
                {
                    sliderfirst = true;
                }
            }
        }

        private void UpDownControl1_SelectionChanged(object sender, RoutedEventArgs e)
        {
            Slider212.Value = UpDownControl1.SelectedIndex;
        }


        private void ComboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Border2.DataContext is Global.Mode.Config.Camera cameraSetting)
            {
                LambdaControl.Trigger("CAMERA_SETTING_VIDEO_FORMAT", this, new Dictionary<string, object>() { { "mode", cameraSetting.SelectViewMode }, { "format", ComboBox1.SelectedItem } });
            }
        }


        private void Slider211_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (Border2.DataContext is Global.Mode.Config.Camera cameraSetting)
            {
                Slider slider = sender as Slider;
                Dictionary<string, object> data = new() { { "mode", cameraSetting.SelectViewMode }, { "gain", slider.Value } };
                SliderAbbreviation(slider, e, "CAMERA_SETTING_GAIN", data);
            }


        }

        private void Slider213_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (Border2.DataContext is Global.Mode.Config.Camera cameraSetting)
            {
                Slider slider = sender as Slider;
                Dictionary<string, object> data = new() { { "mode", cameraSetting.SelectViewMode }, { "sharpness", (int)slider.Value } };
                SliderAbbreviation(slider, e, "CAMERA_SETTING_SHARPNESS", data);
            }
            

        }

        private void Slider214_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (Border2.DataContext is Global.Mode.Config.Camera cameraSetting)
            {
                Slider slider = sender as Slider;
                Dictionary<string, object> data = new() { { "mode", cameraSetting.SelectViewMode }, { "gamma", slider.Value } };
                SliderAbbreviation(slider, e, "CAMERA_SETTING_GAMMA", data);
            }

        }

        private void Slider215_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (Border2.DataContext is Global.Mode.Config.Camera cameraSetting)
            {
                Slider slider = sender as Slider;
                Dictionary<string, object> data = new() { { "mode", cameraSetting.SelectViewMode }, { "denoise", slider.Value } };
                SliderAbbreviation(slider, e, "CAMERA_SETTING_DENOISE", data);
            }

        }


    }
}
