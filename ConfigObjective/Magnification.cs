using Lambda;
using Swifter.Json;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls.Primitives;

namespace ConfigObjective
{
    /// <summary>
    /// Follow steps 1a or 1b and then 2 to use this custom control in a XAML file.
    ///
    /// Step 1a) Using this custom control in a XAML file that exists in the current project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:ConfigObjective"
    ///
    ///
    /// Step 1b) Using this custom control in a XAML file that exists in a different project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:ConfigObjective;assembly=ConfigObjective"
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
    public class Magnification : LambdaControl
    {
        private readonly ToggleButton[] buttons = new ToggleButton[4];

        static Magnification()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Magnification), new FrameworkPropertyMetadata(typeof(Magnification)));
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            if (Template.FindName("Button1", this) is ToggleButton btn1)
            {
                btn1.Click += delegate
                {
                    string data = "{\"mag\":4,\"selected\":0}";
                    Trigger("MAG_CHANGED", data);
                };
                buttons[0] = btn1;
            }
            if (Template.FindName("Button2", this) is ToggleButton btn2)
            {
                btn2.Click += delegate
                {
                    Dictionary<string, object> data = new();
                    data["mag"] = 10;
                    data["selected"] = 1;
                    Trigger("MAG_CHANGED", data);
                };
                buttons[1] = btn2;
            }
            if (Template.FindName("Button3", this) is ToggleButton btn3)
            {
                btn3.Click += delegate
                {
                    string data = "{\"mag\":20,\"selected\":2}";
                    Trigger("MAG_CHANGED", data);
                };
                buttons[2] = btn3;
            }
            if (Template.FindName("Button4", this) is ToggleButton btn4)
            {
                btn4.Click += delegate
                {
                    Dictionary<string, object> data = new();
                    data["mag"] = 40;
                    data["selected"] = 3;
                    Trigger("MAG_CHANGED", data);
                };
                buttons[3] = btn4;
            }
            AddLambdaEventHandler("MAG_CHANGED", OnMagnificationChanged, false);
        }

        public bool OnMagnificationChanged(object sender, EventArgs e)
        {
            if (e is not LambdaArgs evt)
                return true;
            int selected = -1;
            if (evt.Data is Dictionary<string, object> data)
            {
                data.TryGetValue("selected", out var value);
                if (value == null)
                    return false;
                selected = (int)value;

            }
            else if (evt.Data is string json)
            {
                data = JsonFormatter.DeserializeObject<Dictionary<string, object>>(json);
                data.TryGetValue("selected", out var value);
                if (value == null)
                    return false;
                selected = (int)value;
            }

            for (int i = 0; i < buttons.Length; i++)
            {
                ToggleButton btn = buttons[i];
                btn.IsChecked = i == selected;
            }
            return true;
        }
    }
}
