using System;
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

        public static List<Point> SeriesPoints = new List<Point>();

        public static bool ReverseTrans = false;

        public ObservableCollection<SeriersPoint> SeriersPointsCollection = new ObservableCollection<SeriersPoint>();

        private  List<Point> SeriesPointsList;

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
                    if (!ReverseTrans)
                    {
                        LambdaControl.Trigger("MUL_POINT_POSITION", this, new Dictionary<string, object>() { { "Index", seriersPoint.Index }, { "X", (int)seriersPoint.PointXY.X }, { "Y", (int)seriersPoint.PointXY.Y } });

                    }
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

        public void MapUpdate()
        {
            SeriersPointsCollection.Clear();
            foreach (var item in Rectangles)
            {
                mapCanvas.Children.Remove(item);
            }
            DrawPointRec(SeriesPoints);
        }


       
    }
}

