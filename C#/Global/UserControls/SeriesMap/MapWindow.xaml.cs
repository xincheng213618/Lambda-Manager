﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using ThemeManager.Controls;
using Global.Mode.Config;
using Lambda;
using System.Text.Json.Serialization;

namespace Global.UserControls.SeriesMap
{

    /// <summary>
    /// MapWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MapWindow : BaseWindow
    {
        public MapWindow()
        {
            InitializeComponent();
            ListViewP = listview;
           
        }

        public static ListView ListViewP { get; set; }
        public static Point CurrentP;
        public static List<Point> SeriesPoints = new List<Point>()
        {
            //new Point(120,66),new Point(96, 66),new Point(128, 72),new Point(184, 78),new Point(160, 84),new Point(96,84), new Point(112,84),new Point(208, 96),new Point(208, 102),new Point(128, 108),new Point(248, 108),new Point(88,114),
            //new Point(160,114),new Point(184, 120),new Point(232, 126),new Point(216, 126),new Point(56, 132),new Point(152,144), new Point(224,144),new Point(104, 150),new Point(240, 144),new Point(104, 150),new Point(192, 168),new Point(160,222)
        };
        public static bool ReverseTrans = false;
        public  ObservableCollection<SeriersPoint> SeriersPointsCollection = new ObservableCollection<SeriersPoint>();
        private static List<Point> SeriesPointsList;
        public static List<Rectangle> Rectangles = new List<Rectangle>();

        public void DrawPointRec(List<Point> points)    //Add rectangle to show acquire point 
        {
            int i = 0;
            points = points.OrderBy(p => p.Y).ThenBy(p => p.X).ToList();
            Rectangles.Clear();
            SeriersPointsCollection.Clear();

            foreach (Point p in points)
            {
                i++;
                Rectangle rectangle = new Rectangle() { Width = 8, Height = 6, Fill = Brushes.Blue, Opacity = 0.6 };
                mapCanvas.Children.Add(rectangle);
                Canvas.SetLeft(rectangle, p.X);
                Canvas.SetTop(rectangle, p.Y);
                Rectangles.Add(rectangle);
            }

            int j = 1;
            SeriesPointsList = SeriesPoints.OrderBy(P => P.Y).ThenBy(p => p.X).ToList();
            foreach (var item in SeriesPointsList)
            {
                SeriersPointsCollection.Add(new SeriersPoint() { Index = j++, PointXY = new Point(item.X, item.Y) });
            }
            listview.ItemsSource = SeriersPointsCollection;
            ReverseTransCurrentP(CurrentP);
        }







        private void listview_SelectionChanged(object sender, SelectionChangedEventArgs e)  // selected change 
        {
            
            if (sender is ListView listView)
            {
                if (listview.SelectedItems.Count ==0)
                    return;

                if (listview.SelectedItems.Count == 1)
                {
                    for (int i = 0; i < listview.Items.Count; i++)
                    {
                        Rectangles[i].Fill = Brushes.Blue;
                    }
                    SeriersPoint seriersPoint = (SeriersPoint)listView.SelectedItem;
                    int x = seriersPoint.Index;
                    Rectangles[x - 1].Fill = Brushes.Orange;


                    SpotInfor spotInfor = new SpotInfor();
                    spotInfor.Index.Add((int)seriersPoint.Index);
                    List<int> selectedpoint = new List<int>() { (int)seriersPoint.PointXY.X, (int)seriersPoint.PointXY.Y };
                    spotInfor.Coordinate.Add(selectedpoint);
                    string JSON = JsonSerializer.Serialize(spotInfor, new JsonSerializerOptions());

                    // LambdaControl.Trigger("MUL_POINT_POSITION", this, JSON);
                    if (!ReverseTrans)
                    {
                       
                        LambdaControl.Trigger("MUL_POINT_POSITION", this, new Dictionary<string, object>() { { "Index", seriersPoint.Index }, { "X", (int)seriersPoint.PointXY.X }, { "Y", (int)seriersPoint.PointXY.Y } });
                        LambdaControl.Trigger("VIEW_CONTEXTMENU", this, new Dictionary<string, object>() { { "view", 0 } });
                        if ( WindowData1.contextMenuPar.status == 3&& WindowData1.RepoTogg.IsChecked == true)
                        {
                            LambdaControl.Trigger("ZSTACK_GALLERYPATH_TRIGGER", this, new Dictionary<string, object>() { { "mode", WindowData1.contextMenuPar.mode } });
                        }
                      
                        //
                        
                    }
                 ;
                   
                    //LambdaControl.Trigger("MUL_POINT_POSITION", this, new Dictionary<string, object>() { { "Index", seriersPoint.Index }, { "X", (int)seriersPoint.PointXY.X }, { "Y", (int)seriersPoint.PointXY.Y } });
                }
                else if (listview.SelectedItems.Count > 1)
                {
                    listview.SelectedItems.Remove(listview.SelectedItems[0]);
                }
               
                SeriersPoint CurrentP0 = (SeriersPoint)listview.SelectedItems[0];
                CurrentP = CurrentP0.PointXY;
            }
        }


        private void mapCanvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Point point = e.GetPosition(mapCanvas);
            int x = (int)Math.Floor(point.X / 8);
            int y = (int)Math.Floor(point.Y / 6);

            Point selectedPoint = new Point(x * 8, y * 6);

            for (int i = 0; i < listview.Items.Count; i++)
            {
                SeriersPoint seriersPoint = (SeriersPoint)listview.Items[i];
                if (selectedPoint.Equals(seriersPoint.PointXY))
                    listview.SelectedItem = listview.Items[i];

            }

        }
        public static void ReverseTransCurrentP(Point point)
        {
            int x = (int)Math.Floor(point.X / 8);
            int y = (int)Math.Floor(point.Y / 6);

            Point selectedPoint = new Point(x * 8, y * 6);
            CurrentP = selectedPoint;
            for (int i = 0; i < ListViewP.Items.Count; i++)
            {
                SeriersPoint seriersPoint = (SeriersPoint)ListViewP.Items[i];
                if (selectedPoint.Equals(seriersPoint.PointXY))
                    ListViewP.SelectedItem = ListViewP.Items[i];
            }

        }



        public class SeriersPoint
        {
            public int Index { get; set; }
            public Point PointXY { get; set; }

        }
        [Serializable]
        public class SpotInfor
        {

            [JsonPropertyName("Index")]
            public List<int> Index { get; set; } = new List<int>();
            [JsonPropertyName("Coordinate")]
            public List<List<int>> Coordinate { get; set; } = new List<List<int>>();

        }

        //public void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    MapUpdate(SeriesPoints);
        //}


        public  void MapUpdate()
        {
            SeriersPointsCollection.Clear();
            foreach (var item in Rectangles)
            {
                mapCanvas.Children.Remove(item);
            }
          
            DrawPointRec(SeriesPoints);
        }

        private void Grid_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
           
        }

       
    }
}

