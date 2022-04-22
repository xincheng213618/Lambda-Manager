using Global;
using Lambda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ConfigObjective
{
    public partial class ToolControl
    {
        Global.Mode.Config.ViewMode ViewMode = WindowData.GetInstance().ViewMode;

        public void ViewMode_Initialized()
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

            ColorPciker321.SelectColor = new SolidColorBrush(IntToColor(ViewMode.BrightField.Color, out int bright1));
            Slider324.Value = bright;

            Border33.DataContext = ViewMode.Reinberg;

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

        private void ViewMode_Checked(object sender, RoutedEventArgs e)
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
            BrightFieldColor();
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

        private void ColorPciker312_BrushValueChanged(object sender, RoutedEventArgs e)
        {
            int result = HexToInt(ColorPciker312.SelectColor.ToString(), -1);
            ViewMode.BrightField.Color = result;
            LambdaControl.Trigger("BRIGHT_FIELD_BRIGHTNESS", this, new Dictionary<string, object> (){ { "brightness", result } });
        }

        private void ColorAbbreviation(string TriggerName, string TriggerParameter, string hexString, int bright = -1)
        {
            int result = HexToInt(hexString, bright);
            Dictionary<string, object> data = new() { { TriggerParameter, result } };
            LambdaControl.Trigger(TriggerName, this, data);
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
