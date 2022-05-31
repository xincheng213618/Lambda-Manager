using Lambda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Global
{
    public partial class WindowData
    {
        public bool ACQUIRE { get; set; } = false;
        public bool ALIVE { get; set; } = false;

        private int Call(string type, object sender, EventArgs e)
        {
            if (type == "IMAGE_VIEW_CREATED")
            {
                Dictionary<string, object>? eventData = LambdaArgs.GetEventData(e);
                View view = (View)eventData["view"];
                AddImageConfident(view.Image);
            }

            if (type == "STOP_ALIVE")
                ALIVE = false;

            if (type == "START_ALIVE")
                ALIVE = true;

            if (type == "STOP_ACQUIRE")
                ACQUIRE = true;

            if (type == "START_ACQUIRE")
                ACQUIRE = false;

            return 1;
        }

        public async void AddImageConfident(Image image)
        {
            await Task.Delay(1000);
            if (image.Parent is Grid grid)
            {
                //grid.Children.Clear();
                //grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = (GridLength)gridLengthConverter.ConvertFrom("*") });
                //grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = (GridLength)gridLengthConverter.ConvertFrom("*") });

                //Grid grid1 = new Grid() { Background = Brushes.Transparent };
                //grid1.SetValue(Grid.ColumnProperty, 0);
                //ContextMenu contextMenu = new ContextMenu();
                //MenuItem menuItem = new MenuItem() { Header = "11111" };
                //contextMenu.Items.Add(menuItem);
                //grid1.ContextMenu = contextMenu;

                //Grid grid2 = new Grid() { Background = Brushes.Transparent };
                //grid2.SetValue(Grid.ColumnProperty, 1);
                //ContextMenu contextMenu1 = new ContextMenu();
                //MenuItem menuItem1 = new MenuItem() { Header = "22222222" };
                //contextMenu1.Items.Add(menuItem1);
                //grid2.ContextMenu = contextMenu1;
                //image.SetValue(Grid.ColumnProperty, 0);
                //image.SetValue(Grid.ColumnSpanProperty, 2);
                ////grid.Children.Add(image1);
                //grid.Children.Add(grid1);
                //grid.Children.Add(grid2);

                //grid.Background = Brushes.Red;
                Canvas canvas1 = new Canvas()
                {
                    Width = image.ActualWidth,
                    Height = image.ActualWidth,
                    Background = new SolidColorBrush(Color.FromRgb(195, 195, 195)),
                    //Background = Brushes.Black,
                    //ClipToBounds = true
                };

                grid.Children.Remove(image);
                grid.Children.Add(canvas1);
                canvas1.Children.Add(image);

            }
            if (image.Parent is Canvas canvas)
            {
                TransformGroup transformGroup = new();
                TranslateTransform tlt = new();
                ScaleTransform sfr = new();
                transformGroup.Children.Add(sfr);
                transformGroup.Children.Add(tlt);
                image.RenderTransform = transformGroup;
                image.MouseWheel += delegate (object sender, MouseWheelEventArgs e)
                {
                    if (((sfr.ScaleX < 0.2 || sfr.ScaleY < 0.2) && e.Delta < 0) || ((sfr.ScaleX > 5 || sfr.ScaleY > 5) && e.Delta > 0))
                    {

                    }
                    else
                    {
                        Point centerPoint = e.GetPosition(canvas);
                        sfr.CenterX = centerPoint.X;
                        sfr.CenterY = centerPoint.Y;
                        sfr.ScaleX += (double)e.Delta / 1000;
                        sfr.ScaleY += (double)e.Delta / 1000;
                    }



                };
                bool isMouseLeftButtonDown = false;
                Point start, mouseXY;
                image.MouseLeftButtonDown += delegate (object sender, MouseButtonEventArgs e)
                {
                    mouseXY = Mouse.GetPosition(Application.Current.MainWindow);
                    start = new Point(tlt.X, tlt.Y);
                    isMouseLeftButtonDown = true;
                    Application.Current.MainWindow.Cursor = Cursors.Hand;
                };
                image.MouseLeftButtonUp += delegate (object sender, MouseButtonEventArgs e)
                {
                    isMouseLeftButtonDown = false;
                    Application.Current.MainWindow.Cursor = Cursors.Arrow;
                };
                image.MouseLeave += delegate (object sender, MouseEventArgs e)
                {
                    isMouseLeftButtonDown = false;
                    Application.Current.MainWindow.Cursor = Cursors.Arrow;
                };
                image.MouseMove += delegate (object sender, MouseEventArgs e)
                {
                    if (isMouseLeftButtonDown == true)
                    {
                        Point position = Mouse.GetPosition(Application.Current.MainWindow);
                        tlt.X = start.X + position.X - mouseXY.X;
                        tlt.Y = start.Y + position.Y - mouseXY.Y;
                    }
                };

            }
        }

    }
}
