using Global;
using Global.Mode.Config;
using Lambda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using System.Windows.Media.Media3D;

namespace ConfigObjective
{
    public partial class ToolControl
    {
        Global.Mode.Config.OperatingMode OperatingMode = WindowData.GetInstance().OperatingMode;

        ColorHelper colorHelp1 = new(255, 255, 255, 255);
        ColorHelper colorHelp2 = new(255, 255, 255, 255);

        public void OperatingMode_Initialize()
        {
            OperatingMode ??= new Global.Mode.Config.OperatingMode();
        }

        public void OperatingMode_Update()
        {

            switch (OperatingMode.SelectViewMode)
            {
                case 0:
                    Border31.DataContext = OperatingMode.BrightField;
                    colorHelp1 = new ColorHelper(255, OperatingMode.BrightField.Color[0], OperatingMode.BrightField.Color[1], OperatingMode.BrightField.Color[2]);
                    ColorButton311.Background = colorHelp1.SolidColorBrush;
                    Slider312.Value = (int)(colorHelp1.Brightness * 240);
                    Button31.IsChecked = true;
                    break;
                case 1:
                    Border32.DataContext = OperatingMode.DarkField;
                    colorHelp2 = new ColorHelper(255, OperatingMode.DarkField.Color[0], OperatingMode.DarkField.Color[1], OperatingMode.DarkField.Color[2]);
                    ColorButton321.Background = colorHelp2.SolidColorBrush;
                    Slider324.Value = (int)(colorHelp2.Brightness * 240);

                    Button32.IsChecked = true;
                    break;
                case 2:
                    Border33.DataContext = OperatingMode.Reinberg;
                    Reinberg_RheinbergSelectMode_Changed();
                    IntToColor(OperatingMode.Reinberg.BrightColor, out int bright2);
                    IntToColor(OperatingMode.Reinberg.DarkColor, out int bright3);

                    Slider333.Value = bright2;
                    Slider334.Value = bright3;

                    Button33.IsChecked = true;


                    break;
                case 3:
                    Border34.DataContext = OperatingMode.ReliefContrast;
                    Button34.IsChecked = true;
                    break;
                case 4:
                    Border35.DataContext = OperatingMode.QuantitativePhase;
                    Button35.IsChecked = true;
                    break;
                case 5:
                    Border36.DataContext = OperatingMode.PhaseContrast;
                    Button36.IsChecked = true;
                    break;
            }
        }



        private void Button301_Click(object sender, RoutedEventArgs e)
        {
            LambdaControl.Trigger("IMAGE_MODE_RESET", this, new Dictionary<string, object>() { });

            if (OperatingMode.SelectViewMode == 0)
            {
                OperatingMode.BrightField = new Global.Mode.Config.BrightField();
                Border31.DataContext = OperatingMode.BrightField;
                colorHelp1 = new ColorHelper(255, OperatingMode.BrightField.Color[0], OperatingMode.BrightField.Color[1], OperatingMode.BrightField.Color[2]);
                ColorButton311.Background = colorHelp1.SolidColorBrush;
                Slider312.Value = (int)(colorHelp1.Brightness * 240);

                Border2.DataContext = OperatingMode.BrightField.CameraSetting;
            }
            if (OperatingMode.SelectViewMode == 1)
            {
                OperatingMode.DarkField = new Global.Mode.Config.DarkField();

                Border32.DataContext = OperatingMode.DarkField;

                colorHelp2 = new ColorHelper(255, OperatingMode.DarkField.Color[0], OperatingMode.DarkField.Color[1], OperatingMode.DarkField.Color[2]);
                ColorButton321.Background = colorHelp2.SolidColorBrush;
                Slider324.Value = (int)(colorHelp2.Brightness * 240);

                Border2.DataContext = OperatingMode.DarkField.CameraSetting;
            }

            if (OperatingMode.SelectViewMode == 2)
            {
                OperatingMode.Reinberg = new Global.Mode.Config.Reinberg();
                Border33.DataContext = OperatingMode.Reinberg;

                IntToColor(OperatingMode.Reinberg.BrightColor, out int bright2);
                IntToColor(OperatingMode.Reinberg.DarkColor, out int bright3);

                Slider333.Value = bright2;
                Slider334.Value = bright3;

                Border2.DataContext = OperatingMode.Reinberg.CameraSetting;

            }

            if (OperatingMode.SelectViewMode == 3)
            {
                OperatingMode.ReliefContrast = new Global.Mode.Config.ReliefContrast();
                Border34.DataContext = OperatingMode.ReliefContrast;
                Border2.DataContext = OperatingMode.ReliefContrast.CameraSetting;

            }

            if (OperatingMode.SelectViewMode == 4)
            {
                OperatingMode.QuantitativePhase = new Global.Mode.Config.QuantitativePhase();
                Border35.DataContext = OperatingMode.QuantitativePhase;
                Border2.DataContext = OperatingMode.QuantitativePhase.CameraSetting;

            }
            if (OperatingMode.SelectViewMode == 5)
            {
                OperatingMode.PhaseContrast = new Global.Mode.Config.PhaseContrast();
                Border36.DataContext = OperatingMode.PhaseContrast;
                Border2.DataContext = OperatingMode.PhaseContrast.CameraSetting;

            }
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.ColorDialog colorDialog = new System.Windows.Forms.ColorDialog();
            colorDialog.AllowFullOpen = true;
            colorDialog.FullOpen = true;
            colorDialog.AnyColor = false;
            colorDialog.CustomColors = new int[] { 0x6987FC, 15195440, 16107657, 1836924, 3758726, 12566463, 7526079, 7405793, 6945974, 241502, 2296476, 5130294, 3102017, 7324121, 14993507, 11730944 };
            colorDialog.ShowHelp = true;

            if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                colorHelp1 = new ColorHelper(colorDialog.Color);
                ColorButton311.Background = colorHelp1.SolidColorBrush;
                Slider312.Value = (int)(colorHelp1.Brightness * 100);

                OperatingMode.BrightField.Color = new List<int> { colorHelp1.R, colorHelp1.G, colorHelp1.B };
                LambdaControl.Trigger("BRIGHT_FIELD_BRIGHTNESS", this, new int[] { colorHelp1.SolidColorBrush.Color.R, colorHelp1.SolidColorBrush.Color.G, colorHelp1.SolidColorBrush.Color.B });
            }
        }
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.ColorDialog colorDialog = new System.Windows.Forms.ColorDialog();
            colorDialog.AllowFullOpen = true;
            colorDialog.FullOpen = true;
            colorDialog.AnyColor = false;
            colorDialog.CustomColors = new int[] { 0x6987FC, 15195440, 16107657, 1836924, 3758726, 12566463, 7526079, 7405793, 6945974, 241502, 2296476, 5130294, 3102017, 7324121, 14993507, 11730944 };
            colorDialog.ShowHelp = true;

            if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                colorHelp2 = new ColorHelper(colorDialog.Color);
                ColorButton321.Background = colorHelp2.SolidColorBrush;
                Slider324.Value = (int)(colorHelp2.Brightness * 100);

                OperatingMode.DarkField.Color = new List<int> { colorHelp2.R, colorHelp2.G, colorHelp2.B };
                LambdaControl.Trigger("DARK_FIELD_BRIGHTNESS", this, new int[] { colorHelp2.SolidColorBrush.Color.R, colorHelp2.SolidColorBrush.Color.G, colorHelp2.SolidColorBrush.Color.B });
            }
        }

        private void Slider312_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (ColorButton311.Background is SolidColorBrush solidColorBrush)
            {
                colorHelp1.ChangeBrightness(e.NewValue / 100);
                ColorButton311.Background = colorHelp1.SolidColorBrush;
                OperatingMode.BrightField.Color = new List<int> { colorHelp1.R, colorHelp1.G, colorHelp1.B };
                
                LambdaControl.Trigger("BRIGHT_FIELD_BRIGHTNESS", this,new int[] { colorHelp1.SolidColorBrush.Color.R, colorHelp1.SolidColorBrush.Color.G, colorHelp1.SolidColorBrush.Color.B });
            }
        }

        private void Slider324_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (ColorButton321.Background is SolidColorBrush solidColorBrush)
            {
                colorHelp2.ChangeBrightness(e.NewValue / 100);
                ColorButton321.Background = colorHelp2.SolidColorBrush;
                OperatingMode.DarkField.Color = new List<int> { colorHelp2.R, colorHelp2.G, colorHelp2.B };
                LambdaControl.Trigger("DARK_FIELD_BRIGHTNESS", this, new int[] { colorHelp2.SolidColorBrush.Color.R, colorHelp2.SolidColorBrush.Color.G, colorHelp2.SolidColorBrush.Color.B });
            }
        }


        private void Button302_Click(object sender, RoutedEventArgs e)
        {
            LambdaControl.Trigger("IMAGE_MODE_CLOSE", this, new Dictionary<string, object>() { });
        }
        private void Button341_Click(object sender, RoutedEventArgs e)
        {
            LambdaControl.Trigger("RELIEF_CONTRAST_BG_COLLECTION", this, new Dictionary<string, object>() { });
        }
        private void Button351_Click(object sender, RoutedEventArgs e)
        {
            LambdaControl.Trigger("QUANTITATIVE_PHASE_BG_COLLECTION", this, new Dictionary<string, object>() { });
        }
        private void Button361_Click(object sender, RoutedEventArgs e)
        {
            LambdaControl.Trigger("PHASE_CONTRAST_BG_COLLECTION", this, new Dictionary<string, object>() { });
        }

        private void Button362_Checked(object sender, RoutedEventArgs e)
        {
            LambdaControl.Trigger("QUANTITATIVE_PHASE_PN", this, new Dictionary<string, object>() { { "pn",true } });

            
        }

        private void Button362_Unchecked(object sender, RoutedEventArgs e)
        {
            LambdaControl.Trigger("QUANTITATIVE_PHASE_PN", this, new Dictionary<string, object>() { { "pn", false } });

        }

        


        private async void ViewMode_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            string s = radioButton.Tag.ToString();

            if (s != null)
            {
                OperatingMode.SelectViewMode = int.Parse(s);
                if (OperatingMode.SelectViewMode == 0)
                {
                    Border2.DataContext = OperatingMode.BrightField.CameraSetting;
                }
                if (OperatingMode.SelectViewMode == 1)
                {
                    Border2.DataContext = OperatingMode.DarkField.CameraSetting;
                }
                if (OperatingMode.SelectViewMode == 2)
                {
                    Border2.DataContext = OperatingMode.Reinberg.CameraSetting;
                }

                if (OperatingMode.SelectViewMode == 3)
                {
                    Border2.DataContext = OperatingMode.ReliefContrast.CameraSetting;
                }
                if (OperatingMode.SelectViewMode == 4)
                {
                    Border2.DataContext = OperatingMode.QuantitativePhase.CameraSetting;
                }
                if (OperatingMode.SelectViewMode == 5)
                {
                    Border2.DataContext = OperatingMode.PhaseContrast.CameraSetting;
                }

                CameraMode_Changed();
                OperatingMode_Update();
                Dictionary<string, object> data = new() { { "mode", OperatingMode.SelectViewMode } };
                LambdaControl.Trigger("IMAGING_MODE_SETTING", this, data);
            }
        }






        private void Slider323_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Slider slider = sender as Slider;
            Dictionary<string, object> data = new() { { "mode", 1 }, { "gamma", slider.Value + 1 } };
            SliderAbbreviation(slider,e,"DARK_FIELD_GAMMA", data);
        }
        private void Slider335_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Slider slider = sender as Slider;
            Dictionary<string, object> data = new() { { "mode",2}, { "gamma", slider.Value + 1 } };
            SliderAbbreviation(slider, e, "RHEIN_BERG_GAMMA", data);
        }

        private void SliderAbbreviation(Slider slider, RoutedPropertyChangedEventArgs<double> e,string TriggerName, Dictionary<string, object> data)
        {
            if (!windowData.ACQUIRE)
            {
                LambdaControl.Trigger(TriggerName, slider, data);
            }
            else
            {
                if (sliderfirst)
                {
                    var result = MessageBox.Show("是否修改当前多维采集设置", "显微镜", MessageBoxButton.YesNo);
                    if (result == MessageBoxResult.No)
                    {
                        sliderfirst = false;
                        slider.Value = e.OldValue;
                    }

                    else
                    {
                        sliderfirst = true;
                    }
                }
            }
        }




        private void Slider352_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Slider slider = sender as Slider;
            Dictionary<string, object> data = new() { { "detail", (int)(slider.Value * 10) } };
            SliderAbbreviation(slider, e, "QUANTITATIVE_PHASE_DETAIL", data);
        }

        private void Slider348_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Slider slider = sender as Slider;
            Dictionary<string, object> data = new() { { "rotationAngle", ((int)(slider.Value / 15))%12 } };
            SliderAbbreviation(slider, e, "RELIEF_Rotation_Angle", data);
        }

        private void Slider363_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Slider slider = sender as Slider;
            Dictionary<string, object> data = new() { { "gain", slider.Value  } };
            SliderAbbreviation(slider, e, "PHASE_CONTRAST_GAIN", data);

        }

        private void ToggleButton33_Checked(object sender, RoutedEventArgs e)
        {
            int auto = 0;
            if ((bool)ToggleButton331.IsChecked)
                auto = 0;
            if ((bool)ToggleButton332.IsChecked)
                auto = 1;
            if ((bool)ToggleButton333.IsChecked)
                auto = 2;

            LambdaControl.Trigger("RHEIN_BERG_AUTO", this, new Dictionary<string, object>() { { "auto", auto } });
        }




        private  void Slider336_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if ((int)Slider336.Value == 360)
            {
                Slider336.Value = 0;
                return;
            }
            ToggleButton331.IsChecked = false;
            ToggleButton332.IsChecked = false;
            ToggleButton333.IsChecked = false;

            LambdaControl.Trigger("RHEIN_BERG_ANGLE", this, new Dictionary<string, object>() { { "angle", (int)Slider336.Value } });
        }



        private void Button331_Click(object sender, RoutedEventArgs e)
        {
            RheinbergPatternEditorWindow rheinbergPatternEditorWindow = new(OperatingMode.Reinberg.RheinbergPatterns, OperatingMode.Reinberg.RheinbergSelectMode);
            rheinbergPatternEditorWindow.Closed += RheinbergAdd;
            rheinbergPatternEditorWindow.ShowDialog();
        }



        private void RheinbergAdd(object sender, EventArgs e)
        {
            RheinbergPatternEditorWindow rheinbergPatternEditorWindow = sender as RheinbergPatternEditorWindow;
            OperatingMode.Reinberg.RheinbergPatterns = rheinbergPatternEditorWindow.rheinbergPatterns;
            OperatingMode.Reinberg.RheinbergSelectMode = rheinbergPatternEditorWindow.SelectedIndex;
            Reinberg_RheinbergSelectMode_Changed();

            int darkness1 = HexToInt(Color331.Fill.ToString(), (int)Slider334.Value);
            int darkness2 = HexToInt(Color332.Fill.ToString(), (int)Slider334.Value);
            int bright = HexToInt(Color330.Fill.ToString(), (int)Slider333.Value);

            if (OperatingMode.Reinberg.RheinbergSelectMode == 0)
            {
                darkness2 = -1;
            }
            if (OperatingMode.Reinberg.RheinbergSelectMode == 3)
            {
               darkness1 = -1;
                darkness2 = -1;
                bright = -1;
            }
            LambdaControl.Trigger("RHEIN_BERG_SETDATA", this, new Dictionary<string, object>() { { "mode", OperatingMode.Reinberg.RheinbergSelectMode }, { "bright", bright }, { "darkness1", darkness1 }, { "darkness2", darkness2 } });

            rheinbergPatternEditorWindow.Closed -= RheinbergAdd;
        }

        public void Reinberg_RheinbergSelectMode_Changed()
        {
            if (OperatingMode.Reinberg.RheinbergPatterns != null&& OperatingMode.Reinberg.RheinbergPatterns.Count>=3)
            {
                Color330.Fill = OperatingMode.Reinberg.RheinbergPatterns[OperatingMode.Reinberg.rheinbergSelectMode].Rheinberg0;
                Color331.Fill = OperatingMode.Reinberg.RheinbergPatterns[OperatingMode.Reinberg.rheinbergSelectMode].Rheinberg1;
                Color332.Fill = OperatingMode.Reinberg.RheinbergPatterns[OperatingMode.Reinberg.rheinbergSelectMode].Rheinberg2;
            }

            List<Canvas> canvass = new List<Canvas> { Canvas331,Canvas332, Canvas333,Canvas334 };

            for (int i = 0; i < canvass.Count; i++)
            {
                canvass[i].Visibility = i == OperatingMode.Reinberg.RheinbergSelectMode ? Visibility.Visible : Visibility.Collapsed;
            }

            if (OperatingMode.Reinberg.RheinbergSelectMode == 3)
            {
                DockPanel335.Visibility = Visibility.Visible;
                Slider336.Visibility = Visibility.Visible;
                DockPanel332.Visibility = Visibility.Collapsed;
                DockPanel333.Visibility = Visibility.Collapsed;
            }
            else
            {
                DockPanel332.Visibility = Visibility.Visible;
                DockPanel333.Visibility = Visibility.Visible;
                DockPanel335.Visibility = Visibility.Collapsed;
                Slider336.Visibility = Visibility.Collapsed;
            }
        }




        private void OperatingMode_Reinberg_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (Color331 == null || Color332 == null || Color330 == null || Slider334 == null || Slider333 == null)
                return;
            if (!WindowData.GetInstance().ACQUIRE)
            {
                int darkness1 = HexToInt(Color331.Fill.ToString(), (int)Slider334.Value);
                int darkness2 = HexToInt(Color332.Fill.ToString(), (int)Slider334.Value);
                int bright = HexToInt(Color330.Fill.ToString(), (int)Slider333.Value);

                OperatingMode.Reinberg.BrightColor = bright;
                OperatingMode.Reinberg.DarkColor = darkness1;
                OperatingMode.Reinberg.DarkColor1 = darkness2;


                if (OperatingMode.Reinberg.RheinbergSelectMode == 0)
                {
                    darkness2 = -1;
                }
                if (OperatingMode.Reinberg.RheinbergSelectMode == 3)
                {
                    darkness1 = -1;
                    darkness2 = -1;
                    bright = -1;
                }

                Dictionary<string, object> data = new() { { "mode", OperatingMode.Reinberg.RheinbergSelectMode }, { "bright", bright }, { "darkness1", darkness1 }, { "darkness2", darkness2 } };
                LambdaControl.Trigger("RHEIN_BERG_SETDATA", this, data);
            }
            else
            {
                if (sliderfirst)
                {
                    var result = MessageBox.Show("是否修改当前多维采集设置", "显微镜", MessageBoxButton.YesNo);
                    if (result == MessageBoxResult.No)
                    {
                        sliderfirst = false;
                        Slider334.Value = e.OldValue;
                    }
                }
                else
                {
                    sliderfirst = true;
                }
            }

        }





        private int HexToInt(string hexString, int bright = -1)
        {
            if (hexString[..1] == "#")
                hexString = hexString[1..];
            byte[] returnBytes = new byte[hexString.Length / 2];
            for (int i = 0; i < returnBytes.Length; i++)
                returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2).Trim(), 16);
            int a1, a2, a3;

            if (bright > -1)
            {
                a1 = (returnBytes[1] >> 4) * bright / 15;
                a2 = (returnBytes[2] >> 4) * bright / 15;
                a3 = (returnBytes[3] >> 4) * bright / 15;
            }
            else
            {
                a1 = returnBytes[1] >> 4;
                a2 = returnBytes[2] >> 4;
                a3 = returnBytes[3] >> 4;
            }
            return (a1 << 8) + (a2 << 4) + a3;
        }
        private Color IntToColor(int result, out int bright)
        {
            int r = result / 256;
            int g = (result % 256) / 16;
            int b = (result % 256) % 16;
            bright = r > 0 ? r : g > 0 ? g : b > 0 ? b : 0;
            r = r != 0 ? 255 : 0;
            g = g != 0 ? 255 : 0;
            b = b != 0 ? 255 : 0;

            return Color.FromRgb((byte)r, (byte)g, (byte)b); ;
        }
    }
}
