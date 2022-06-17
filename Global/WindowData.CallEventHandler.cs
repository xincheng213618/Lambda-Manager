using Global.Mode;
using Lambda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;

namespace Global
{
    /// <summary>
    /// 监听CallEventHandler事件
    /// </summary>
    public partial class WindowData
    {
        public bool ACQUIRE { get; set; } = false;
        public bool ALIVE { get; set; } = false;


        private int Call(string type, object sender, EventArgs e)
        {
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
        static GridLengthConverter gridLengthConverter = new GridLengthConverter();





        List<ImageParameter> imageParameters = new List<ImageParameter>();
        public async void AddImageConfident(Image image)
        {
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

                grid.RowDefinitions.Clear();
                grid.RowDefinitions.Add(new RowDefinition() { Height = (GridLength)gridLengthConverter.ConvertFrom("*") });
                for (int i = 0; i < 2; i++)
                {
                    RowDefinition rowDefinition = new RowDefinition() { Height = GridLength.Auto };
                    grid.RowDefinitions.Add(rowDefinition);
                }

                StackPanel stackPanel = new StackPanel() {  Orientation =Orientation.Horizontal };
                Grid.SetColumn(stackPanel, 0);
                Grid.SetRow(stackPanel,2);  

                Assembly assembly = Assembly.LoadFile(Environment.CurrentDirectory + "\\" + "ConfigBottomView");
                Control control = (Control)assembly.CreateInstance($"ConfigBottomView.BottomView");
                stackPanel.Children.Add(control);

                GridSplitter gridSplitter = new GridSplitter();
                gridSplitter.Height = 1;
                gridSplitter.Background = Brushes.BlanchedAlmond;
                gridSplitter.VerticalAlignment = VerticalAlignment.Stretch;

                Grid.SetColumn(gridSplitter, 0);
                Grid.SetRow(gridSplitter, 1);

                grid.Children.Clear();


                Canvas canvas1 = new Canvas()
                {
                    Background = new SolidColorBrush(Color.FromRgb(195, 195, 195)),
                    //Background = Brushes.Black,
                    ClipToBounds = true
                };

                grid.Children.Remove(image);
                Grid.SetRow(canvas1, 0);
                canvas1.Children.Add(image);
                grid.Children.Add(canvas1);
                grid.Children.Add(gridSplitter);
                grid.Children.Add(stackPanel);

            }
            if (image.Parent is Canvas canvas)
            {
                ImageParameter imageParameter = new ImageParameter();
                imageParameters.Add(imageParameter);
                image.DataContext = imageParameter;

                TransformGroup transformGroup = new();
                TranslateTransform tlt = new();
                ScaleTransform sfr = new();
                BindingOperations.SetBinding(sfr, ScaleTransform.CenterXProperty, new Binding("ScaleTransformCenterX"));
                BindingOperations.SetBinding(sfr, ScaleTransform.CenterXProperty, new Binding("ScaleTransformCenterY"));
                BindingOperations.SetBinding(sfr, ScaleTransform.ScaleXProperty, new Binding("ScaleTransformScaleX"));
                BindingOperations.SetBinding(sfr, ScaleTransform.ScaleYProperty, new Binding("ScaleTransformScaleY"));


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

                        if (Keyboard.IsKeyDown(Key.LeftCtrl))
                        {
                            foreach (var item in imageParameters)
                            {
                                item.ScaleTransformCenterX = centerPoint.X;
                                item.ScaleTransformCenterY = centerPoint.Y;
                                item.ScaleTransformScaleX += (double)e.Delta / 1000;
                                item.ScaleTransformScaleY += (double)e.Delta / 1000;

                            }
                        }
                        else
                        {
                            imageParameter.ScaleTransformCenterX = centerPoint.X;
                            imageParameter.ScaleTransformCenterY = centerPoint.Y;
                            imageParameter.ScaleTransformScaleX += (double)e.Delta / 1000;
                            imageParameter.ScaleTransformScaleY += (double)e.Delta / 1000;
                        }


                        //sfr.CenterX = centerPoint.X;
                        //sfr.CenterY = centerPoint.Y;
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
