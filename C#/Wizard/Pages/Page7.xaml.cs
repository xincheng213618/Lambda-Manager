using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wizard.Pages
{
    /// <summary>
    /// Page7.xaml 的交互逻辑
    /// </summary>
    public partial class Page7 : Page
    {
        public Page7()
        {
            InitializeComponent();
            ResolutionInit();
        }

        public class Res
        {
            public string Resolution { get; set; }
            public double value { get; set; }

        }
        
        private string Path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Grid\\Default\\default.gprj";
        public  List<Res> ResolutionCollection = new List<Res>();
        public  List<Res> ResolutionList = new List<Res>();
        public ObservableCollection<string> ResolutionsSelected = new ObservableCollection<string>();

        private void ResolutionInit()
        {
            ReadConfig(Path);
            ResolutionList = ListOrderBy(ResolutionCollection);
            UIInit(ResolutionList);
        }


        private void ReadConfig(string path)
        {
            string result = File.ReadAllText(path);
            JsonNode document = JsonNode.Parse(result)!;
            JsonNode root = document.Root;
            if (root["resolution"] != null)
            {
                if (root["resolution"]!["keys"] != null)
                {
                    JsonArray ResolutionArray = root["resolution"]!["keys"]!.AsArray();
                    if (ResolutionArray.Count > 0)
                    {
                        
                        for (int i = 0; i < ResolutionArray.Count; i++)
                        {
                            if (ResolutionArray[i] != null && ResolutionArray[i].ToString().Length > 0)
                            {
                                Res res = new Res();
                                res.Resolution = ResolutionArray[i].ToString();
                                ResolutionCollection.Add(res);
                            }
                        }
                    }
                }
                if (root["resolution"]!["selected"] != null)
                {
                    
                    JsonArray ResolutionSelected = root["resolution"]!["selected"]!.AsArray();
                    if (ResolutionSelected.Count > 0)
                    {

                        for (int i = 0; i < ResolutionSelected.Count; i++)
                        {
                            if (ResolutionSelected[i] != null && ResolutionSelected[i].ToString().Length > 0)
                            {
                                ResolutionsSelected.Add(ResolutionSelected[i].ToString());
                            }
                        }
                    }
                }

            }


        }

        private void UIInit(List<Res> list)
        {
            Stackpanel.Children.Clear();
            for(int i = 0; i < list.Count; i++)
            {
                CheckBox cb = new CheckBox() { Content = list[i].Resolution, Foreground = Brushes.White, FontSize = 16, FontFamily = new FontFamily("Arial"),
                    Margin = new Thickness(10, 5, 10, 5)
                     };
                cb.Checked += (s, e) =>
                {
                    if (!ResolutionsSelected.Contains(cb.Content))
                    {
                        ResolutionsSelected.Add((string)cb.Content);
                        
                    }
                };
                cb.Unchecked += (s, e) =>
                {
                    if (ResolutionsSelected.Contains(cb.Content))
                    {
                        ResolutionsSelected.Remove((string)cb.Content);
                        
                    }

                };

                Stackpanel.Children.Add(cb);
            }
            UpdateSelected(ResolutionsSelected);
        }


        





        private void UpdateSelected(ObservableCollection<string> strings)
        {

            for (int i = 0; i < strings.Count; i++)
            {
               foreach(CheckBox checkBox in Stackpanel.Children)
                {
                    if(checkBox.Content.ToString() == strings[i])
                    {
                        checkBox.IsChecked = true;
                        
                    }
                }

            }
            Stackpanel.Children[0].IsEnabled = false;

        }

        private void WriteSelected()
        {



        }
       

       

        private List<Res> ListOrderBy(List<Res> ts)
        {
            string midChar = "*";
            for (int i = 0; i < ts.Count; i++)
            {
                string width = ts[i].Resolution.Substring(0, ts[i].Resolution.IndexOf(midChar));
                string height = ts[i].Resolution.Substring(ts[i].Resolution.IndexOf(midChar)+1);
                double wid =double.Parse(width);
                double hei = double.Parse(height);
                ts[i].value = wid * hei;           
            }
            var resCollect = ts.OrderByDescending(p => p.value).ToList(); 
            return resCollect;
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
