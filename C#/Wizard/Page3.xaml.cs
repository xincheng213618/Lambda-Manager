using Global.Hardware;
using Global.SettingUp;
using Global.SettingUp.Configure;
using Global.SettingUp.Hardware;
using Global.SettingUp.Mode.Hardware;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
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

namespace Wizard
{


    /// <summary>
    /// Page2.xaml 的交互逻辑
    /// </summary>
    public partial class Page3 : Page
    {
        public List<ObjectiveConfig> DefaultObjectiveConfig = new List<ObjectiveConfig>()
        {
            new ObjectiveConfig() { No=0,Brand ="国产", ObjectiveKey ="10x",Magnitude =10,NA=0.25,WorkingDistance ="10.6",Achromatic=false, Multiple=5.5},
            new ObjectiveConfig() { No=1,Brand ="国产", ObjectiveKey ="20x",Magnitude =20,NA=0.4,WorkingDistance ="10.6",Achromatic=false, Multiple=3.2},
            new ObjectiveConfig() { No=2,Brand ="国产", ObjectiveKey ="20xl",Magnitude =20,NA=0.4,WorkingDistance ="10.6",Achromatic=false, Multiple=3.2},
            new ObjectiveConfig() { No=3,Brand ="国产", ObjectiveKey ="20xs",Magnitude =20,NA=0.4,WorkingDistance ="10.6",Achromatic=false, Multiple=3.2}
        };


        public ObjectiveConfig SelectObjective;

        public bool IsMul = false;

        WizardWindow Window;
        public Page3(WizardWindow window)
        {
            InitializeComponent();
            Window = window;
            foreach (var item in DefaultObjectiveConfig)
            {
                Button button = new Button() { Margin = new Thickness(10), BorderBrush = Brushes.Green, BorderThickness = new Thickness(0), Content = $"{item.Brand} {item.ObjectiveKey} {item.NA}",Tag =item };
                button.Click += Button_Click_1;
                ObjectGrid.Children.Add(button);
            }
            if (ObjectGrid.Children[0] is Button button1)
            {
                ObjectGrid.Tag = button1;
                button1.BorderThickness = new Thickness(2);
            }
            SelectObjective = DefaultObjectiveConfig[0];
        }



        private void Pages()
        {
            Dispatcher.BeginInvoke(new Action(() => Window.frame.Navigate(Content)));

            string result = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Grid\\Default\\default.gprj");
            try
            {
                JsonObject lamdbda = (JsonObject)JsonNode.Parse(result);
                if (lamdbda != null)
                {
                    SoftwareConfig.HardwareConfig.DeviceType = lamdbda["device-type"]?.ToString();
                    SoftwareConfig.HardwareConfig.InstallSize = lamdbda["install-size"]?.ToString();

                    if (lamdbda["firmware"] is JsonObject firmware)
                    {

                        if (firmware["source"] is JsonObject source)
                        {
                            var LightSourceConfig = SoftwareConfig.HardwareConfig.LightSourceConfig;
                            source["led-size"] = "64x64";
                            source["led-spacing"] = "2mm";
                            source["led-height"] = "62mm";
                            source["hdr"] = "4096";
                            source["center-wave-length"] = "15nm";
                            source["brightness"] = "300nit";
                            source["NA"] = "0.8";
                            source["max-frequency"] = "1MHZ";
                        }
                        if (firmware["camera"] is JsonObject camera)
                        {
                            var CameraConfig = SoftwareConfig.HardwareConfig.CameraConfig;
                            camera["type"] = "DFK 33UX264";
                            camera["ccd-size"] = "8.3mm*7.0mm";
                            camera["hdr"] = "12bit";
                            camera["max-fps"] = 38;
                            camera["trigger"] = "硬触发";
                        }

                        if (IsMul)
                        {
                            if (firmware["objective"] is JsonObject objective)
                            {

                                lamdbda["multi-objectives"] = true;
                                objective["magnitude"] = new JsonObject();
                                objective["NA"] = new JsonObject();
                                objective["achromatic"] = new JsonObject();
                                objective["multiple"] = new JsonObject();
                                objective["WD"] = new JsonObject();
                                foreach (var item in DefaultObjectiveConfig)
                                {
                                    objective["magnitude"]![item.ObjectiveKey] = item.Magnitude;
                                    objective["NA"]![item.ObjectiveKey] = item.NA;
                                    objective["achromatic"]![item.ObjectiveKey] = item.Achromatic;
                                    objective["multiple"]![item.ObjectiveKey] = item.Multiple;
                                    objective["WD"]![item.ObjectiveKey] = item.WorkingDistance;

                                }
                            }
                            JsonArray jsonArray = new JsonArray();
                            foreach (var item in DefaultObjectiveConfig)
                            {
                                jsonArray.Add(item.ObjectiveKey);
                            }
                            lamdbda["lambda-manager"] = new JsonObject();
                            lamdbda["lambda-manager"]!["objective-keys"] = jsonArray;
                        }
                        else
                        {

                            if (firmware["objective"] is JsonObject objective)
                            {

                                var ObjectiveConfigs = SoftwareConfig.HardwareConfig.ObjectiveConfigs;
                                lamdbda["multi-objectives"] = false;
                                objective["magnitude"] = SelectObjective.Magnitude;
                                objective["NA"] = SelectObjective.NA;
                                objective["achromatic"] = SelectObjective.Achromatic;
                                objective["multiple"] = SelectObjective.Multiple;
                                objective["WD"] = SelectObjective.WorkingDistance;
                            }
                            JsonArray jsonArray = new JsonArray();
                            jsonArray.Add(SelectObjective.ObjectiveKey);
                            lamdbda["lambda-manager"] = new JsonObject();
                            lamdbda["lambda-manager"]!["objective-keys"] = jsonArray;
                        }

                    }
                    File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Grid\\Default\\default.gprj", lamdbda.ToJsonString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Page_Initialized(object sender, EventArgs e)
        {
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Content = new Page5(Window);
            Pages();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Content = new Page2(Window);
            Pages();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Button button1 = (Button)sender;
            if (button1.Tag is ObjectiveConfig objectiveConfig)
                SelectObjective = objectiveConfig;
            if (button1.Parent is UniformGrid control)
            {
                if (control.Tag is Button button)
                    button.BorderThickness = new Thickness(0);
                control.Tag = button1;
            }
            button1.BorderThickness = new Thickness(2,2,2,2);


        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            IsMul = true;
            Content = new Page5(Window);
            Pages();
        }
    }
}
