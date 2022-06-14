using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace WpfApp6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        static GridLengthConverter gridLengthConverter = new GridLengthConverter();

        public List<List<Circles>> CirclesMatrix = new List<List<Circles>>();
        int cows = 100;
        int rows = 100;

        private void canvas1_Initialized(object sender, EventArgs e)
        {


            for (int i = 0; i < cows; i++)
            {
                ColumnDefinition columnDefinition = new ColumnDefinition() { Width = (GridLength)gridLengthConverter.ConvertFrom("*") };
                ShowGrid.ColumnDefinitions.Add(columnDefinition);
            }
            for (int i = 0; i < rows; i++)
            {
                RowDefinition rowDefinition = new RowDefinition() { Height = (GridLength)gridLengthConverter.ConvertFrom("*") };
                ShowGrid.RowDefinitions.Add(rowDefinition);

            }

            for (int cow = 0; cow < cows; cow++)
            {
                List<Circles> Circless = new List<Circles>();
                for (int row = 0; row < rows; row++)
                {
                    
                    Grid grid = new Grid();
                    Circles circles = new Circles();

                    grid.DataContext = circles;
                    BindingOperations.SetBinding(grid, Grid.BackgroundProperty,new  Binding("Background"));
                    grid.MouseRightButtonDown += Grid_MouseRightButtonDown; ;
                    grid.MouseLeftButtonDown += Grid_MouseLeftButtonDown; ; ;

                    grid.SetValue(Grid.RowProperty, cow);
                    grid.SetValue(Grid.ColumnProperty, row);

                    ShowGrid.Children.Add(grid);
                    Circless.Add(circles);
                }
                CirclesMatrix.Add(Circless);    
            }
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sender == null)
                throw new NotImplementedException();

            Grid grid = sender as Grid;
            if (grid.DataContext is Circles circles)
            {
                circles.Background = new SolidColorBrush(Colors.DarkCyan);
            }
        }

        private void Grid_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sender == null)
                throw new NotImplementedException();

            Grid grid = sender as Grid;
            if (grid.DataContext is Circles circles)
            {
                circles.Background = new SolidColorBrush(Colors.Red);
            }
        }


        private void Grid_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (sender ==null)
                throw new NotImplementedException();

            Grid grid = sender as Grid; 
            if (grid.DataContext is Circles circles)
            {
                circles.Background  = new SolidColorBrush(Colors.Black);
            }
        }


        MouseMove mouseMove = new MouseMove();
        private void Window_Initialized(object sender, EventArgs e)
        {
            MouseMoveStackPanel.DataContext = mouseMove;
        }



        private void Canvas1_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                Point point = e.GetPosition(this.canvas1);
                MessageBox.Show($"X:{point.X},Y:{point.Y}");
            }
        }

        private void canvas1_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }
        private Border currentBoxSelectedBorder;
        Point StartPoint;
        bool IsSelected = false;

        private void canvas1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sender == null)
                throw new NotImplementedException();
            StartPoint = e.GetPosition(this.canvas1);
            IsSelected = true;
            Mouse.Capture(this.canvas1);

        }
        private void canvas1_MouseMove(object sender, MouseEventArgs e)
        {
            if (sender == null)
                throw new NotImplementedException();
            Point point = e.GetPosition(this.canvas1);
            mouseMove.X = point.X;
            mouseMove.Y = point.Y;
            if (IsSelected)
            {
                if (currentBoxSelectedBorder == null)
                {
                    currentBoxSelectedBorder = new Border();
                    currentBoxSelectedBorder.Opacity = 0.9;
                    currentBoxSelectedBorder.BorderThickness = new Thickness(2);
                    currentBoxSelectedBorder.Background = new SolidColorBrush(Colors.OrangeRed);
                    //Canvas.SetZIndex(currentBoxSelectedBorder, 100);
                    this.canvas1.Children.Add(currentBoxSelectedBorder);
                }
                DrawMultiselectBorder(currentBoxSelectedBorder, point, StartPoint);
            }

            if (IsCancel)
            {
                if (currentBoxCancelBorder == null)
                {
                    currentBoxCancelBorder = new Border();
                    currentBoxCancelBorder.Opacity = 0.9;
                    currentBoxCancelBorder.BorderThickness = new Thickness(2);
                    currentBoxCancelBorder.Background = new SolidColorBrush(Colors.Bisque);
                    //Canvas.SetZIndex(currentBoxSelectedBorder, 100);
                    this.canvas1.Children.Add(currentBoxCancelBorder);
                }
                DrawMultiselectBorder(currentBoxCancelBorder, point, CancelStartPoint);
            }

        }

        private void DrawMultiselectBorder(Border currentBoxSelectedBorder, Point endPoint, Point startPoint)
        {


            currentBoxSelectedBorder.Width = Math.Abs(endPoint.X - startPoint.X);
            currentBoxSelectedBorder.Height = Math.Abs(endPoint.Y - startPoint.Y);


            if (endPoint.X - startPoint.X >= 0)
                Canvas.SetLeft(currentBoxSelectedBorder, startPoint.X);
            else
                Canvas.SetLeft(currentBoxSelectedBorder, endPoint.X);
            if (endPoint.Y - startPoint.Y >= 0)
                Canvas.SetTop(currentBoxSelectedBorder, startPoint.Y);
            else
                Canvas.SetTop(currentBoxSelectedBorder, endPoint.Y);
        }


        private void canvas1_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (sender == null)
                throw new NotImplementedException();
            IsSelected = false;

            Point point = e.GetPosition(this.canvas1);

            int startX = StartPoint.X < point.X ? (int)StartPoint.X:(int)point.X;
            int startY = StartPoint.Y < point.Y ? (int)StartPoint.Y : (int)point.Y;

            int endX = StartPoint.X > point.X ? (int)StartPoint.X : (int)point.X;
            int endY = StartPoint.Y > point.Y ? (int)StartPoint.Y : (int)point.Y;


            double ScaleX = (canvas1.Height / cows);
            double ScaleY = (canvas1.Width / rows);

            startX = (int)(startX / ScaleX);
            endX = (int)(endX / ScaleX);

            startY = (int)(startY / ScaleY);
            endY = (int)(endY / ScaleY);

            for (int i = startX; i < endX; i++)
            {
                for (int j = startY; j < endY; j++)
                {
                    double tempx = i * ScaleX - 150;
                    double tempy = j * ScaleY - 150;
                    if (tempx > 0)
                        tempx += ScaleX;
                    if (tempy > 0)
                        tempy += ScaleY;
                    if (tempx*tempx +tempy*tempy<=22500)
                    {
                        Circles circles = CirclesMatrix[j][i];
                        circles.Background = new SolidColorBrush(Colors.DarkCyan);
                    }

                }
            }
            this.canvas1.Children.Remove(currentBoxSelectedBorder);
            currentBoxSelectedBorder = null;
            this.canvas1.ReleaseMouseCapture();
        }

        private Border currentBoxCancelBorder;
        Point CancelStartPoint;
        bool IsCancel = false;

        private void canvas1_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            IsCancel = true;
            CancelStartPoint = e.GetPosition(this.canvas1);
            Mouse.Capture(this.canvas1);
           
        }


        private void canvas1_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            IsCancel = false;
            Point point = e.GetPosition(this.canvas1);

            int startX = CancelStartPoint.X < point.X ? (int)CancelStartPoint.X : (int)point.X;
            int startY = CancelStartPoint.Y < point.Y ? (int)CancelStartPoint.Y : (int)point.Y;

            int endX = CancelStartPoint.X > point.X ? (int)CancelStartPoint.X : (int)point.X;
            int endY = CancelStartPoint.Y > point.Y ? (int)CancelStartPoint.Y : (int)point.Y;

            startX = (int)(startX / (canvas1.Height / cows));
            endX = (int)(endX / (canvas1.Height / cows));

            startY = (int)(startY / (canvas1.Width / rows));
            endY = (int)(endY / (canvas1.Width / rows));


            startX = startX > 0 ? startX >= cows ? cows-1 : startX : 0;
            endX = endX > 0 ? endX >= cows ? cows - 1 : endX : 0;


            startY = startY > 0 ? startY >= rows ? rows - 1 : startY : 0;
            endY = endY > 0 ? endY >= rows ? rows - 1 : endY : 0;




            for (int i = startX; i < endX; i++)
            {
                for (int j = startY; j < endY; j++)
                {
                    Circles circles = CirclesMatrix[j][i];
                    circles.Background = new SolidColorBrush(Colors.Red);
                }
            }
            this.canvas1.Children.Remove(currentBoxCancelBorder);
            currentBoxCancelBorder = null;
            this.canvas1.ReleaseMouseCapture();

        }
    }
    public class  MouseMove : ViewModeBase
    {
        private double x;
        public double X
        {
            get { return x; }
            set { x = value; NotifyPropertyChanged(); }
        }
        private double y;
        public double Y
        {
            get { return y; }
            set { y = value; NotifyPropertyChanged(); }
        }
    }


    public class Circles : ViewModeBase
    {
        private SolidColorBrush background  = new SolidColorBrush(Colors.Red);

        public SolidColorBrush Background
        {
            get { return background; }
            set { background = value; NotifyPropertyChanged(); }
        }

        private double stageX;
        public double StageX
        {
            get { return stageX; }
            set { stageX = value; NotifyPropertyChanged(); }
        }
    }
}
