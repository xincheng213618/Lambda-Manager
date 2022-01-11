using Lambda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ConfigDPCMode
{
    /// <summary>
    /// Follow steps 1a or 1b and then 2 to use this custom control in a XAML file.
    ///
    /// Step 1a) Using this custom control in a XAML file that exists in the current project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:ConfigDPCMode"
    ///
    ///
    /// Step 1b) Using this custom control in a XAML file that exists in a different project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:ConfigDPCMode;assembly=ConfigDPCMode"
    ///
    /// You will also need to add a project reference from the project where the XAML file lives
    /// to this project and Rebuild to avoid compilation errors:
    ///
    ///     Right click on the target project in the Solution Explorer and
    ///     "Add Reference"->"Projects"->[Select this project]
    ///
    ///
    /// Step 2)
    /// Go ahead and use your control in the XAML file.
    ///
    ///     <MyNamespace:CustomControl1/>
    ///
    /// </summary>
    [TemplatePart(Name = "Button1", Type = typeof(ToggleButton))]
    [TemplatePart(Name = "Button2", Type = typeof(ToggleButton))]
    [TemplatePart(Name = "Button3", Type = typeof(ToggleButton))]
    [TemplatePart(Name = "Button4", Type = typeof(ToggleButton))]
    public class DPCMode : LambdaControl
    {
        private readonly ToggleButton[] buttons = new ToggleButton[4];

        static DPCMode()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(DPCMode), new FrameworkPropertyMetadata(typeof(DPCMode)));
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            if (Template.FindName("Button1", this) is ToggleButton btn1)
            {
                btn1.Click += delegate
                {
                    Dictionary<string, object> data = new() { { "dpc", 0 } };
                    Trigger("DPC_MODE_CHANGED", btn1, data);
                };
                buttons[0] = btn1;
            }
            if (Template.FindName("Button2", this) is ToggleButton btn2)
            {
                btn2.Click += delegate
                {
                    Dictionary<string, object> data = new() { { "dpc", 1 } };
                    Trigger("DPC_MODE_CHANGED", btn2, data);
                };
                buttons[1] = btn2;
            }
            if (Template.FindName("Button3", this) is ToggleButton btn3)
            {
                btn3.Click += delegate
                {
                    Dictionary<string, object> data = new() { { "dpc", 2 } };
                    Trigger("DPC_MODE_CHANGED", btn3, data);
                };
                buttons[2] = btn3;
            }
            if (Template.FindName("Button4", this) is ToggleButton btn4)
            {
                btn4.Click += delegate
                {
                    Dictionary<string, object> data = new() { { "dpc", 3 } };
                    Trigger("DPC_MODE_CHANGED", btn4, data);
                };
                buttons[3] = btn4;
            }
            AddLambdaEventHandler("DPC_MODE_CHANGED", OnDPCModeChanged,false);
        }

        public bool OnDPCModeChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                ToggleButton btn = buttons[i];
                btn.IsChecked = btn == sender;
            }
            Log(new Message() { Severity = Severity.INFO, Text = "DPC Mode Updated" });
            return true;
        }

    }
}
