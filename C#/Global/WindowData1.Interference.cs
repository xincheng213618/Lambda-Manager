using Global.Common;
using Global.Common.Extensions;
using Lambda;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace Global
{
    public partial class WindowData1
    {
        public void Interference()
        {
            //C++可以显示MessageBox
            LambdaControl.AddLambdaEventHandler("MessageBox", ShowMessageBox, false);
            LambdaControl.AddLambdaEventHandler("WaitWindow", ShowWaitContorl, false);          
        }

        public bool ShowWaitContorl(object sender, EventArgs e)
        {
            Dictionary<string, object>? eventData = LambdaArgs.GetEventData(e);
            if (eventData == null)
                return false;
            Application.Current.Dispatcher.Invoke(delegate
            {
                string Visibility = eventData.GetString("Visibility");
                string TextBox = eventData.GetString("Text");
                WaitContorl.GetInstance().textBox.Text = TextBox;
                if (Visibility == "Visible")
                {
                    WaitContorl.GetInstance().Show();
                }
                else
                {
                    WaitContorl.GetInstance().Hidden();
                }
            });
            return true;
        }


        public bool ShowMessageBox(object sender, EventArgs e)
        {
            Dictionary<string, object>? eventData = LambdaArgs.GetEventData(e);
            if (eventData == null)
                return false;
            MessageBoxResult messageBoxResult = MessageBoxResult.Yes;
            Application.Current.Dispatcher.Invoke(delegate
            {
                string messageBoxText = eventData.GetString("messageBoxText");
                string caption = eventData.GetString("caption");
                string buttonstring = eventData.GetString("button");
                if (String.IsNullOrEmpty(caption))
                    caption = "Grid";
                MessageBoxButton button = MessageBoxButton.OK;  
                switch (buttonstring)
                {
                    case "YesNo":
                        button = MessageBoxButton.YesNo;
                        break;
                    default:
                        button = MessageBoxButton.OK;
                        break;
                }
                messageBoxResult = MessageBox1.Show(messageBoxText, caption, button);

            });
            LambdaControl.Trigger("MessageBoxResult",this, new Dictionary<string, object>() { { "MessageBoxResult", messageBoxResult.ToString() } });
            return messageBoxResult == MessageBoxResult.Yes;
        }



    }
}
