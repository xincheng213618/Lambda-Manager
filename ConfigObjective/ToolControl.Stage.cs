using Lambda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Global;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace ConfigObjective
{
    public partial class ToolControl
    {
        Global.Mode.Config.Stage Stage = WindowData.GetInstance().Stage; 
        Global.Mode.Config.MoveStep MoveStep;

        private void Stage_Initialize()
        {
            Border41.DataContext = WindowData.WindowMsg;
            MoveStep = Stage.MoveStep;
            _timer.Tick += Timer_Tick;
        }

        private void Stage_Update()
        {
            Stage = WindowData.GetInstance().Stage;
            MoveStep = Stage.MoveStep;

            ToggleButtonXYF.IsChecked = Stage.MoveStep.XStep == 200;
            ToggleButtonZF.IsChecked = Stage.MoveStep.ZStep == 200;
        }


        private void Stage_Reset_Click(object sender, RoutedEventArgs e)
        {
            LambdaControl.Trigger("STAGE_SETTING_RESET", this, new Dictionary<string, object> { });
        }

        private void ToggleButtonXYF_Checked(object sender, RoutedEventArgs e)
        {
            MoveStep.XStep = 50;
            MoveStep.YStep = 50;
        }

        private void ToggleButtonXYF_Unchecked(object sender, RoutedEventArgs e)
        {
            MoveStep.XStep = 200;
            MoveStep.YStep = 200;
        }

        private void ToggleButtonZF_Checked(object sender, RoutedEventArgs e)
        {
            MoveStep.ZStep = 100;
        }

        private void ToggleButtonZF_Unchecked(object sender, RoutedEventArgs e)
        {
            MoveStep.ZStep = 500;
        }


        int direction = 0;



        private readonly System.Windows.Threading.DispatcherTimer _timer = new System.Windows.Threading.DispatcherTimer() { Interval = TimeSpan.FromSeconds(0.5) };
        private void ButtonRight_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            _timer.Stop();
            if (IslongPress)
            {
                LambdaControl.Trigger("STAGE_MOVE_LONG", this, new Dictionary<string, object>() { { "direction", direction }, { "IsStop", true } });
            }
            else
            {
                switch (direction)
                {
                    case 0:
                        LambdaControl.Trigger("STAGE_MOVE_LEFT", this, new Dictionary<string, object> { { "step", MoveStep.XStep }, { "direction", 0 } });
                        break;
                    case 1:
                        LambdaControl.Trigger("STAGE_MOVE_RIGHT", this, new Dictionary<string, object> { { "step", MoveStep.XStep }, { "direction", 1 } });
                        break;
                    case 2:
                        LambdaControl.Trigger("STAGE_MOVE_FRONT", this, new Dictionary<string, object> { { "step", MoveStep.YStep }, { "direction", 2 } });
                        break;
                    case 3:
                        LambdaControl.Trigger("STAGE_MOVE_REAR", this, new Dictionary<string, object> { { "step", MoveStep.YStep }, { "direction", 3 } });
                        break;
                    case 4:
                        LambdaControl.Trigger("STAGE_MOVE_UP", this, new Dictionary<string, object> { { "step", MoveStep.ZStep }, { "direction", 4 } });
                        break;
                    case 5:
                        LambdaControl.Trigger("STAGE_MOVE_DOWN", this, new Dictionary<string, object> { { "step", MoveStep.ZStep }, { "direction", 5 } });
                        break;
                }
            }
            IslongPress = false;
        }

        bool IslongPress = false;
        private void Timer_Tick(object? sender, EventArgs e)
        {
            _timer.Stop();
            IslongPress = true;
            LambdaControl.Trigger("STAGE_MOVE_LONG", this, new Dictionary<string, object>() { { "direction", direction }, { "IsStop", false } });
        }

        private void ButtonLeft_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            direction = 0;
            _timer.Start();
        }

        private void ButtonRight_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            direction = 1;
            _timer.Start();
           
        }


        private void ButtonFront_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            direction = 2;
            _timer.Start();
        }

        private void ButtonRear_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            direction = 3;
            _timer.Start();
        }
        private void ButtonUp_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            direction = 4;
            _timer.Start();
        }


        private void ButtonDown_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            direction = 5;
            _timer.Start();
        }

        private void ButtonRe_Click(object sender, RoutedEventArgs e)
        {
            LambdaControl.Trigger("STAGE_MOVE_CENTRE", this, new Dictionary<string, object> { { "step", 0 }, { "direction", 6 } });
        }

        private void ButtonAutoFocus_Click(object sender, RoutedEventArgs e)
        {
            LambdaControl.Trigger("STAGE_AUTO_FOCUS", this, new Dictionary<string, object> { { "mode", (bool)ToggleButtonZF.IsChecked ? 0 : 1 } });
        }


    }
}
