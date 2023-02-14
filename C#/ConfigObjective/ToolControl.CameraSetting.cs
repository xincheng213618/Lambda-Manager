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
using Global.Mode.Config;
using System.Text.Json.Nodes;
using Global;

namespace ConfigObjective
{
    public partial class ToolControl
    {
        public void CameraSetting_Initialize()
        {
            windowData.ExposureViewMode.PropertyChanged += (s, e) =>
            {
                if (e.PropertyName =="Index"&& Border2.DataContext is Camera cameraSetting)
                {
                      cameraSetting.Exposure = windowData.ExposureViewMode.Index;
                      Slider212.Value = windowData.ExposureViewMode.Index;
                }
            };
            UpDownControl1.DataContext = windowData.ExposureViewMode;
            UpDownControl1.ExposureViewMode = windowData.ExposureViewMode;
            if (Border2.DataContext is Camera cameraSetting)
            {
                LambdaControl.Trigger("CAMERA_SETTING_GAMMA", this, new Dictionary<string, object>() { { "mode", cameraSetting.SelectViewMode }, { "gamma", cameraSetting.Gamma } });
            }
        }



        public void CameraSetting_Update()
        {

        }

        public void CameraMode_Changed()
        {
            if (Border2.DataContext is Camera cameraSetting)
            {
                LambdaControl.Trigger("CAMERA_SETTING_GAMMA", this, new Dictionary<string, object>() { { "mode", cameraSetting.SelectViewMode }, { "gamma", cameraSetting.Gamma } });
                windowData.ExposureViewMode.Index = cameraSetting.Exposure;
            }
        }

        private void Button201_Click(object sender, RoutedEventArgs e)
        {
            if (Border2.DataContext is Camera cameraSetting)
                LambdaControl.Trigger("CAMERA_SETTING_RESET", this, new Dictionary<string, object>() { { "mode", cameraSetting.SelectViewMode} });
            CameraReset();
        }

        private void Button211_Click(object sender, RoutedEventArgs e)
        {
            if (Border2.DataContext is Camera cameraSetting)
                LambdaControl.Trigger("CAMERA_SETTING_WHITE_BALANCE", this, new Dictionary<string, object> { { "mode", cameraSetting.SelectViewMode } });
        }

        private void ToggleButton210_Click(object sender, RoutedEventArgs e)
        {
            if (Border2.DataContext is Camera cameraSetting)
            {
                LambdaControl.Trigger("CAMERA_SETTING_EXPOSURE_AUTO", this, new Dictionary<string, object>() { { "mode", cameraSetting.SelectViewMode }, { "auto", ToggleButton210.IsChecked } });
            }
        }


        private void ToggleButton211_Click(object sender, RoutedEventArgs e)
        {
            if (Border2.DataContext is Camera cameraSetting)
            {
                LambdaControl.Trigger("CAMERA_SETTING_GAIN_AUTO", this, new Dictionary<string, object>() { { "mode", cameraSetting.SelectViewMode }, { "auto", ToggleButton211.IsChecked } });
            }
            //Test();
        }

        public async void Test()
        {
            double value = 0.002;
            for (int i = 0; i < 1000; i++)
            {
                value += 0.002;
                windowData.ExposureViewMode.SetValue(value);
                await Task.Delay(30);
            }
        }


        private void Slider212_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Slider slider = sender as Slider;
            ToggleButton210.IsChecked = false;

            if (!windowData.ACQUIRE)
            {
                if (Slider212.Value < windowData.ExposureViewMode.ExposureInfos.Count)
                {
                    if (Border2.DataContext is Camera cameraSetting)
                    {
                        // windowData.ExposureViewMode.Index = cameraSetting.Exposure;
                        windowData.ExposureViewMode.Index = (int)Slider212.Value;
                        if (!windowData.ExposureViewMode.IsBackGroundChanged)
                        {
                            Dictionary<string, object> data = new() { { "mode", cameraSetting.SelectViewMode }, { "exposure", windowData.ExposureViewMode.Exposure } };
                            LambdaControl.Dispatch("CAMERA_SETTING_EXPOSURE", this, data);
                        }
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



        private void ComboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //if (Border2.DataContext is Camera cameraSetting)
            //{
            //    JsonObject keyValuePairs = new JsonObject();
            //    keyValuePairs["mode"] = cameraSetting.SelectViewMode;
            //    keyValuePairs["format"] = ComboBox1.SelectedItem.ToString();
            //    LambdaControl.Trigger("CAMERA_SETTING_VIDEO_FORMAT", this, keyValuePairs.ToString());
            //}
            if(Border2.DataContext is Camera cameraSetting)
            {
                string resolution = ComboBox1.SelectedItem as string;
               // MessageBox.Show(ComboBox1.SelectedIndex.ToString());
                //LambdaControl.Trigger("CAMERA_SETTING_VIDEO_FORMAT", this, new Dictionary<string, object>() { { "mode", ComboBox1.SelectedIndex } });
                LambdaControl.Trigger("CAMERA_SETTING_RESOLUTION", this, new Dictionary<string, object>() { { "mode", resolution } });
            }
            WindowData.GetInstance().setting.otherMode.Resolution = ComboBox1.SelectedIndex;
            
        }


        private void Slider211_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (Border2.DataContext is Camera cameraSetting && sender is Slider slider)
            {
                Dictionary<string, object> data = new() { { "mode", cameraSetting.SelectViewMode }, { "gain", slider.Value } };
                SliderAbbreviation(slider, e, "CAMERA_SETTING_GAIN", data);
            }


        }

        private void Slider213_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (Border2.DataContext is Camera cameraSetting && sender is Slider slider)
            {
                Dictionary<string, object> data = new() { { "mode", cameraSetting.SelectViewMode }, { "sharpness", (int)slider.Value } };
                SliderAbbreviation(slider, e, "CAMERA_SETTING_SHARPNESS", data);
            }
        }

        private void Slider214_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (Border2.DataContext is Camera cameraSetting && sender is Slider slider)
            {
                Dictionary<string, object> data = new() { { "mode", cameraSetting.SelectViewMode }, { "gamma", slider.Value } };
                SliderAbbreviation(slider, e, "CAMERA_SETTING_GAMMA", data);
            }
        }

        private void Slider215_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (Border2.DataContext is Camera cameraSetting && sender is Slider slider)
            {
                Dictionary<string, object> data = new() { { "mode", cameraSetting.SelectViewMode }, { "denoise", (int)slider.Value } };
                SliderAbbreviation(slider, e, "CAMERA_SETTING_DENOISE", data);
            }

        }

        private void CameraModeReset() //other mode
        {
            Slider211.Value = 0; 
            Slider212.Value = 35; 
            Slider213.Value = 0; 
            Slider214.Value = 1.0;  
            Slider215.Value = 0;
        }
        private void CameraModeReset1() // darkfield or  Reinberg 
        {
            Slider211.Value = 0; //增益
            Slider212.Value = 35; //曝光
            Slider213.Value = 0; // 锐度
            Slider214.Value = 1.67;  //伽马
            Slider215.Value = 0; //降噪
        }



        public void CameraReset()
        {

            if (OperatingMode.SelectViewMode == 0)
            {
                CameraModeReset();
            }
            if (OperatingMode.SelectViewMode == 1)
            {
                CameraModeReset1();
            }

            if (OperatingMode.SelectViewMode == 2)
            {
                CameraModeReset1();
            }

            if (OperatingMode.SelectViewMode == 3)
            {
                CameraModeReset();
            }

            if (OperatingMode.SelectViewMode == 4)
            {
                CameraModeReset();
            }
            if (OperatingMode.SelectViewMode == 5)
            {
                CameraModeReset();
            }


        }


    }
}
