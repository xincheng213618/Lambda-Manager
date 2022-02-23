using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using ConfigDeck;
namespace WpfApp2
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




        private Border currentBoxSelectedBorder = null;//拖动展示的提示框
        private bool isCanMove = false;//鼠标是否移动
        private Point tempStartPoint;//起始坐标

        Rectangle rectangle;
        /// <summary>
        /// 鼠标按下记录起始点
        /// </summary>
        private void MainCanvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            rectangle = new Rectangle();
            rectangle.Fill = (Brush)brushConverter.ConvertFrom("#2E86E1");
            rectangle.Opacity = 0.9;
            rectangle.Width = 10;
            rectangle.Height = 7;
            rectangle.PreviewMouseRightButtonDown += Rectangle_PreviewMouseRightButtonDown;
            Canvas element = (Canvas)sender;
            Point dragStart = e.GetPosition(element);
            Canvas.SetLeft(rectangle, dragStart.X - 3.5);
            Canvas.SetTop(rectangle, dragStart.Y - 5);
            element.Children.Add(rectangle);
            
            isCanMove = true;
            tempStartPoint = e.GetPosition(this.Canvas1);
        }



        private BrushConverter brushConverter = new BrushConverter();

        private void MainCanvas_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            
            if (currentBoxSelectedBorder != null)
            {
                if (currentBoxSelectedBorder.Height>10|| currentBoxSelectedBorder.Width > 10)
                {
                    //获取选框的矩形位置
                    Point tempEndPoint = e.GetPosition(this.Canvas1);
                    Rect tempRect = new Rect(tempStartPoint, tempEndPoint);
                    //获取子控件
                    List<Rectangle> childList = GetChildObjects<Rectangle>(this.Canvas1);
                    foreach (var child in childList)
                    {
                        //获取子控件矩形位置
                        Rect childRect = new Rect(Canvas.GetLeft(child), Canvas.GetTop(child), child.Width, child.Height);
                        //若子控件与选框相交则改变样式
                        if (childRect.IntersectsWith(tempRect))
                            this.Canvas1.Children.Remove(child);
                    }

                    List<Border> childList1 = GetChildObjects<Border>(this.Canvas1);
                    foreach (var child in childList1)
                    {

                        Rect childRect = new Rect(Canvas.GetLeft(child), Canvas.GetTop(child), child.Width, child.Height);
                        if (tempRect.Contains(childRect))
                            this.Canvas1.Children.Remove(child);
                    }
                    this.Canvas1.Children.Add(currentBoxSelectedBorder);



                }

                currentBoxSelectedBorder = new Border();
                currentBoxSelectedBorder.Background = (Brush)brushConverter.ConvertFrom("#2E86E1");
                currentBoxSelectedBorder.Opacity = 0.9;
                currentBoxSelectedBorder.BorderThickness = new Thickness(2);
                currentBoxSelectedBorder.BorderBrush = (Brush)brushConverter.ConvertFrom("#2E86E1FF");
                currentBoxSelectedBorder.PreviewMouseRightButtonDown += Border_PreviewMouseRightButtonDown;
                currentBoxSelectedBorder.MouseMove += Border_MouseMove;
                currentBoxSelectedBorder.MouseLeftButtonDown += Border_MouseLeftButtonDown;
                currentBoxSelectedBorder.MouseLeftButtonUp += Border_MouseLeftButtonUp;
                this.Canvas1.Children.Add(currentBoxSelectedBorder);


            }
            isCanMove = false;


        }


        private void MainCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (bordermouve)
            {
                if (rectangle != null)
                {
                    Canvas1.Children.Remove(rectangle);
                    rectangle = null;
                }
            }
            else
            {
                if (isCanMove)
                {
                    Point tempEndPoint = e.GetPosition(this.Canvas1);
                    //绘制跟随鼠标移动的方框
                    DrawMultiselectBorder(tempEndPoint, tempStartPoint);
                }
                else if (isCanMove1)
                {
                    Point tempEndPoint1 = e.GetPosition(this.Canvas1);
                    //绘制跟随鼠标移动的方框
                    DrawMultiselectBorder1(tempEndPoint1, tempStartPoint1);
                }
            }

        }



        private void DrawMultiselectBorder(Point endPoint, Point startPoint)
        {
            if (currentBoxSelectedBorder == null)
            {
                currentBoxSelectedBorder = new Border();
                currentBoxSelectedBorder.Background = (Brush)brushConverter.ConvertFrom("#2E86E1");
                currentBoxSelectedBorder.Opacity = 0.9;
                currentBoxSelectedBorder.BorderThickness = new Thickness(2);
                currentBoxSelectedBorder.BorderBrush = (Brush)brushConverter.ConvertFrom("#2E86E1FF");
                currentBoxSelectedBorder.PreviewMouseRightButtonDown += Border_PreviewMouseRightButtonDown;
                currentBoxSelectedBorder.MouseMove += Border_MouseMove;
                currentBoxSelectedBorder.MouseLeftButtonDown += Border_MouseLeftButtonDown;
                currentBoxSelectedBorder.MouseLeftButtonUp += Border_MouseLeftButtonUp;


                //Canvas.SetZIndex(currentBoxSelectedBorder, 100);
                this.Canvas1.Children.Add(currentBoxSelectedBorder);
            }



            currentBoxSelectedBorder.Width = Math.Abs(endPoint.X - startPoint.X);
            currentBoxSelectedBorder.Height = Math.Abs(endPoint.Y - startPoint.Y);
            if (currentBoxSelectedBorder.Width > 2 || currentBoxSelectedBorder.Height > 2)
            {
                if (rectangle != null)
                {
                    Canvas1.Children.Remove(rectangle);
                    rectangle = null;
                }

            }
            if (endPoint.X - startPoint.X >= 0)
                Canvas.SetLeft(currentBoxSelectedBorder, startPoint.X);
            else
                Canvas.SetLeft(currentBoxSelectedBorder, endPoint.X);
            if (endPoint.Y - startPoint.Y >= 0)
                Canvas.SetTop(currentBoxSelectedBorder, startPoint.Y);
            else
                Canvas.SetTop(currentBoxSelectedBorder, endPoint.Y);
        }


        private void Border_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Border? border = (Border)sender;
            Canvas1.Children.Remove(border);
            border = null;
        }

        private void Rectangle_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Rectangle? rectangle = (Rectangle)sender;
            Canvas1.Children.Remove(rectangle);
            rectangle = null;
        }

        private void Canvas1_PreviewMouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (currentBoxSelectedBorder1 != null)
            {
                //获取选框的矩形位置
                Point tempEndPoint = e.GetPosition(this.Canvas1);
                Rect tempRect = new Rect(tempStartPoint1, tempEndPoint);
                //获取子控件
                List<Rectangle> childList = GetChildObjects<Rectangle>(this.Canvas1);
                foreach (var child in childList)
                {
                    //获取子控件矩形位置
                    Rect childRect = new Rect(Canvas.GetLeft(child), Canvas.GetTop(child), child.Width, child.Height);

                    if (tempRect.Contains(childRect))
                        this.Canvas1.Children.Remove(child);
                        //child.Opacity = 0.4;
                }
                List<Border> childList1 = GetChildObjects<Border>(this.Canvas1);
                foreach (var child in childList1)
                {

                    Rect childRect = new Rect(Canvas.GetLeft(child), Canvas.GetTop(child), child.Width, child.Height);
                    if (tempRect.Contains(childRect))
                        this.Canvas1.Children.Remove(child);
                    //if (contain(tempRect, childRect))
                    //    this.Canvas1.Children.Remove(child);
                }
                this.Canvas1.Children.Remove(currentBoxSelectedBorder1);
                currentBoxSelectedBorder1 = null;


            }
            isCanMove1 = false;
        }

        private static bool contain(Rect r,Rect l)
        {
            return r.Top < l.Top && r.Left < l.Left && r.Width > (l.Width + (l.Left - r.Left)) && r.Width > (l.Height + (l.Top - r.Top));
        }
        public static List<T> GetChildObjects<T>(System.Windows.DependencyObject obj) where T : System.Windows.FrameworkElement
        {
            System.Windows.DependencyObject child = null;
            List<T> childList = new List<T>();
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj); i++)
            {
                child = VisualTreeHelper.GetChild(obj, i);
                if (child is T)
                {
                    childList.Add((T)child);
                }
                childList.AddRange(GetChildObjects<T>(child));
            }
            return childList;
        }
        

        private void Canvas1_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            isCanMove1 = true;
            tempStartPoint1 = e.GetPosition(this.Canvas1);
        }

        private Border currentBoxSelectedBorder1 = null;//拖动展示的提示框
        private bool isCanMove1 = false;//鼠标是否移动
        private Point tempStartPoint1;//起始坐标

        private void DrawMultiselectBorder1(Point endPoint, Point startPoint)
        {
            if (currentBoxSelectedBorder1 == null)
            {
                currentBoxSelectedBorder1 = new Border();
                currentBoxSelectedBorder1.Background = new SolidColorBrush(Colors.Red);
                currentBoxSelectedBorder1.Opacity = 0.4;
                currentBoxSelectedBorder1.BorderThickness = new Thickness(2);
                currentBoxSelectedBorder1.BorderBrush = new SolidColorBrush(Colors.OrangeRed);
                Canvas.SetZIndex(currentBoxSelectedBorder1, 100);
                this.Canvas1.Children.Add(currentBoxSelectedBorder1);
            }
            


            currentBoxSelectedBorder1.Width = Math.Abs(endPoint.X - startPoint.X);
            currentBoxSelectedBorder1.Height = Math.Abs(endPoint.Y - startPoint.Y);

            if (endPoint.X - startPoint.X >= 0)
                Canvas.SetLeft(currentBoxSelectedBorder1, startPoint.X);
            else
                Canvas.SetLeft(currentBoxSelectedBorder1, endPoint.X);
            if (endPoint.Y - startPoint.Y >= 0)
                Canvas.SetTop(currentBoxSelectedBorder1, startPoint.Y);
            else
                Canvas.SetTop(currentBoxSelectedBorder1, endPoint.Y);
        }

        bool bordermouve = false;
        Point point1;
        private void Border_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            bordermouve = false;
            Border border = (Border)sender;
            border.ReleaseMouseCapture();
        }
        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            bordermouve = true;
            Border border = (Border)sender;
            point1 =e.GetPosition(border);
            border.CaptureMouse();
        }

        private void Border_MouseMove(object sender, MouseEventArgs e)
        {
            if (bordermouve)
            {
                Border border = (Border)sender;
                Point point = e.GetPosition(this.Canvas1);

                Double CanvasTop, CanvasLeft;
                CanvasTop = point.Y -point1.Y ;
                CanvasLeft = point.X- point1.X;   

                if (CanvasTop < 0)
                {
                    CanvasTop = 0;
                }

                if (CanvasLeft < 0)
                {
                    CanvasLeft = 0;
                }
                Canvas.SetTop(border, CanvasTop);
                Canvas.SetLeft(border, CanvasLeft);
              
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            ComboBoxItem comboBoxItem = comboBox.SelectedItem as ComboBoxItem;
        }
        double Frequency = 0.001;


        

        List<string> llllss = new List<string>()
        {
            "X4","X10","X20","X40","X100"
        };


        private void txt_NamberChange_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btn_ClickUp_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }
         
        private void btn_ClickUp_MouseUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {

        }

        private void HexTextLostFocus(object sender, RoutedEventArgs e)
        {
            
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
        }
        private List<string> comboxlist;
        private int SelectedIndex =0;

        private void Border_Initialized(object sender, EventArgs e)
        {
            SetList(llllss);
        }
        private void SetList(List<string> list)
        {
            comboxlist = list;
            if (comboxlist.Count > 0)
            {
                Update();
            }
        }

        private void Btn_ClickUp_Click(object sender, RoutedEventArgs e)
        {
            SelectedIndex = ++SelectedIndex % comboxlist.Count;
            Update();
        }

        private void Update()
        {
            this.txt_NamberChange.Text = comboxlist[SelectedIndex];
        }


        private void Btn_ClickDown_Click(object sender, RoutedEventArgs e)
        {
            SelectedIndex = --SelectedIndex% comboxlist.Count;
            SelectedIndex = SelectedIndex < 0 ? comboxlist.Count - 1 : SelectedIndex;
            Update();
        }

        private void UpDownButton11_Initialized(object sender, EventArgs e)
        {
            UpDownButton1? upDownButton11 = (UpDownButton1)sender;
            if (upDownButton11 != null)
            {
                upDownButton11.SetList(llllss);
            }
        }
    }
}
