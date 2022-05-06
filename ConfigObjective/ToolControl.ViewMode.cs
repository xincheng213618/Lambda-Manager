using Global;
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

namespace ConfigObjective
{
    public partial class ToolControl
    {
        Global.Mode.Config.ViewMode ViewMode = WindowData.GetInstance().ViewMode;


        public void ViewMode_Initialized()
        {

        }

        public void ViewMode_Update()
        {
            if (ViewMode == null)
                ViewMode = new Global.Mode.Config.ViewMode();

            switch (ViewMode.SelectViewMode)
            {
                case 0:
                    Button31.IsChecked = true;
                    break;
                case 1:
                    Button32.IsChecked = true;
                    break;
                case 2:
                    Button33.IsChecked = true;
                    break;
                case 3:
                    Button34.IsChecked = true;
                    break;
                case 4:
                    Button35.IsChecked = true;
                    break;
                case 5:
                    Button36.IsChecked = true;
                    break;
            }


            Border31.DataContext = ViewMode.BrightField;
            ColorPciker311.SelectColor = new SolidColorBrush(IntToColor(ViewMode.BrightField.Color,out int bright));
            Slider312.Value= bright;

            Border32.DataContext = ViewMode.DarkField;

            ColorPciker321.SelectColor = new SolidColorBrush(IntToColor(ViewMode.DarkField.Color, out int bright1));
            Slider324.Value = bright1;

            Border33.DataContext = ViewMode.Reinberg;

            IntToColor(ViewMode.Reinberg.BrightColor, out int bright2);
            IntToColor(ViewMode.Reinberg.DarkColor, out int bright3);

            Slider333.Value = bright2;
            Slider334.Value = bright3;

            Border34.DataContext = ViewMode.ReliefContrast;

            Border35.DataContext = ViewMode.QuantitativePhase;

            Border36.DataContext = ViewMode.PhaseContrast;


            //MessageBox.Show(ViewMode.ToJson());
        }



        private void Button301_Click(object sender, RoutedEventArgs e)
        {
            LambdaControl.Trigger("IMAGE_MODE_RESET", this, new Dictionary<string, object>() { });

            if (ViewMode.SelectViewMode == 0)
            {
                ViewMode.BrightField = new Global.Mode.Config.BrightField();
                Border31.DataContext = ViewMode.BrightField;
                ColorPciker311.SelectColor = new SolidColorBrush(IntToColor(ViewMode.BrightField.Color, out int bright));
                Slider312.Value = bright;
                Border2.DataContext = ViewMode.BrightField.CameraSetting;


            }
            if (ViewMode.SelectViewMode == 1)
            {
                ViewMode.DarkField = new Global.Mode.Config.DarkField();

                Border32.DataContext = ViewMode.DarkField;

                ColorPciker321.SelectColor = new SolidColorBrush(IntToColor(ViewMode.BrightField.Color, out int bright1));
                Slider324.Value = bright1;
                Border2.DataContext = ViewMode.DarkField.CameraSetting;

            }

            if (ViewMode.SelectViewMode == 2)
            {
                ViewMode.Reinberg = new Global.Mode.Config.Reinberg();
                Border33.DataContext = ViewMode.Reinberg;

                IntToColor(ViewMode.Reinberg.BrightColor, out int bright2);
                IntToColor(ViewMode.Reinberg.DarkColor, out int bright3);

                Slider333.Value = bright2;
                Slider334.Value = bright3;

                Border2.DataContext = ViewMode.Reinberg.CameraSetting;

            }

            if (ViewMode.SelectViewMode == 3)
            {
                ViewMode.ReliefContrast = new Global.Mode.Config.ReliefContrast();
                Border34.DataContext = ViewMode.ReliefContrast;
                Border2.DataContext = ViewMode.ReliefContrast.CameraSetting;

            }

            if (ViewMode.SelectViewMode == 4)
            {
                ViewMode.QuantitativePhase = new Global.Mode.Config.QuantitativePhase();
                Border35.DataContext = ViewMode.QuantitativePhase;
                Border2.DataContext = ViewMode.QuantitativePhase.CameraSetting;

            }
            if (ViewMode.SelectViewMode == 5)
            {
                ViewMode.PhaseContrast = new Global.Mode.Config.PhaseContrast();
                Border36.DataContext = ViewMode.PhaseContrast;
                Border2.DataContext = ViewMode.PhaseContrast.CameraSetting;

            }

            //ViewMode_Initialized();
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
                ViewMode.SelectViewMode = int.Parse(s);
                if (ViewMode.SelectViewMode == 0)
                {
                    Border2.DataContext = ViewMode.BrightField.CameraSetting;
                }
                if (ViewMode.SelectViewMode == 1)
                {
                    Border2.DataContext = ViewMode.DarkField.CameraSetting;
                }
                if (ViewMode.SelectViewMode == 2)
                {
                    Border2.DataContext = ViewMode.Reinberg.CameraSetting;
                }

                if (ViewMode.SelectViewMode == 3)
                {
                    Border2.DataContext = ViewMode.ReliefContrast.CameraSetting;
                }
                if (ViewMode.SelectViewMode == 4)
                {
                    Border2.DataContext = ViewMode.QuantitativePhase.CameraSetting;
                }
                if (ViewMode.SelectViewMode == 5)
                {
                    Border2.DataContext = ViewMode.PhaseContrast.CameraSetting;
                }

                LambdaControl.Trigger("IMAGE_MODE_CLOSE", this, new Dictionary<string, object>() { });
                await Task.Delay(300);
                Dictionary<string, object> data = new() { { "mode", ViewMode.SelectViewMode } };
                LambdaControl.Trigger("IMAGING_MODE_SETTING", this, data);
            }
        }


        private void ColorPciker311_BrushValueChanged(object sender, RoutedEventArgs e)
        {
            BrightFieldColor();
        }


        private void Slider312_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (!WindowData.GetInstance().ACQUIRE)
            {
                BrightFieldColor();
            }
            else
            {
                if (sliderfirst)
                {
                    var result = MessageBox.Show("是否修改当前多维采集设置", "显微镜", MessageBoxButton.YesNo);
                    if (result == MessageBoxResult.No)
                    {
                        sliderfirst = false;
                        Slider312.Value = e.OldValue;
                    }
                }
                else
                {
                    sliderfirst = true;
                }
            }
        }
        private void BrightFieldColor()
        {
            if (ColorPciker311 != null&& Slider312 != null)
            {
                int result = HexToInt(ColorPciker311.SelectColor.ToString(), (int)Slider312.Value);
                ViewMode.BrightField.Color = result;
                LambdaControl.Trigger("BRIGHT_FIELD_BRIGHTNESS", this, new Dictionary<string, object>() { { "brightness", result } });
            }
        }

        private void Slider324_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (!WindowData.GetInstance().ACQUIRE)
            {
                DarkFieldColor();          
            }
            else
            {
                if (sliderfirst)
                {
                    var result = MessageBox.Show("是否修改当前多维采集设置", "显微镜", MessageBoxButton.YesNo);
                    if (result == MessageBoxResult.No)
                    {
                        sliderfirst = false;
                        Slider324.Value = e.OldValue;
                    }
                }
                else
                {
                    sliderfirst = true;
                }
            }
        }
        private void DarkFieldColor()
        {
            if (ColorPciker321 != null && Slider324 != null)
            {
                int result = HexToInt(ColorPciker321.SelectColor.ToString(), (int)Slider324.Value);
                ViewMode.DarkField.Color = result;
                LambdaControl.Trigger("DARK_FIELD_BRIGHTNESS", this, new Dictionary<string, object>() { { "brightness", result } });
            }
        }

        private void ColorPciker312_BrushValueChanged(object sender, RoutedEventArgs e)
        {
            DarkFieldColor();
        }





        private void Slider352_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Slider slider = sender as Slider;
            if (!WindowData.ACQUIRE)
            {
                Dictionary<string, object> data = new() { { "detail", (int)(slider.Value * 10) } };
                LambdaControl.Trigger("QUANTITATIVE_PHASE_DETAIL", slider, data);
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




        private void Slider336_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            LambdaControl.Trigger("RHEIN_BERG_ANGLE", this, new Dictionary<string, object>() { { "angle", (int)Slider336.Value } });
        }

        private void ColorAbbreviation(string TriggerName, string TriggerParameter, string hexString, int bright = -1)
        {
            int result = HexToInt(hexString, bright);
            LambdaControl.Trigger(TriggerName, this, new Dictionary<string, object>() { { TriggerParameter, result } });
        }





        List<RheinbergPattern> rheinbergPatterns;

        private void Button331_Click(object sender, RoutedEventArgs e)
        {
            RheinbergPatternEditorWindow rheinbergPatternEditorWindow = new(rheinbergPatterns);
            rheinbergPatternEditorWindow.Closed += RheinbergAdd;
            rheinbergPatternEditorWindow.ShowDialog();
        }
        public RheinbergPattern SelectColor;
        public int RheinbergSelectMode = 0;


        private void RheinbergAdd(object sender, EventArgs e)
        {
            RheinbergPatternEditorWindow rheinbergPatternEditorWindow = sender as RheinbergPatternEditorWindow;
            SelectColor = rheinbergPatternEditorWindow.SelectColor;
            RadioButton radioButton = rheinbergPatternEditorWindow.SelectRadionButton;

            if (radioButton.Parent is UniformGrid uniform)
            {
                uniform.Children.Remove(radioButton);
                DockPanel331.Children.Clear();
                DockPanel331.Children.Add(radioButton);

                //if (radioButton.Content is Canvas canvas)
                //{
                //    radioButton.Content = null;

                //}

            }



            Color330.Fill = SelectColor.Rheinberg0;
            Color331.Fill = SelectColor.Rheinberg1;
            Color332.Fill = SelectColor.Rheinberg2;

            RheinbergSelectMode = rheinbergPatternEditorWindow.SelectedIndex;

            int darkness1 = HexToInt(Color331.Fill.ToString(), (int)Slider334.Value);
            int darkness2 = HexToInt(Color332.Fill.ToString(), (int)Slider334.Value);
            int bright = HexToInt(Color330.Fill.ToString(), (int)Slider333.Value);

            DockPanel332.Visibility = Visibility.Visible;
            DockPanel333.Visibility = Visibility.Visible;


            //Color330.Visibility = Visibility.Visible;
            //Color331.Visibility = Visibility.Visible;
            //Color332.Visibility = Visibility.Visible;

            if (RheinbergSelectMode == 0)
            {
                //Color332.Visibility =Visibility.Collapsed;
                darkness2 = -1;
            }
            if (RheinbergSelectMode == 3)
            {
                darkness1 = -1;
                darkness2 = -1;
                bright = -1;
                DockPanel332.Visibility = Visibility.Collapsed;
                DockPanel333.Visibility = Visibility.Collapsed;
            }

            LambdaControl.Trigger("RHEIN_BERG_SETDATA", this, new Dictionary<string, object>() { { "mode", RheinbergSelectMode }, { "bright", bright }, { "darkness1", darkness1 }, { "darkness2", darkness2 } });

            rheinbergPatterns = rheinbergPatternEditorWindow.rheinbergPatterns;
            rheinbergPatternEditorWindow.Closed -= RheinbergAdd;
        }

        private void Combox341_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LambdaControl.Trigger("RELIEF_Rotation_Angle", this, new Dictionary<string, object>() { { "rotationAngle", ViewMode.ReliefContrast.Rotationangle } });
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
