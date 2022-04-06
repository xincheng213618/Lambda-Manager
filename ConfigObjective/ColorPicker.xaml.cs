using Util.Media;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Runtime.CompilerServices;

namespace ConfigObjective
{
    /// <summary>
    /// ColorPicker.xaml 的交互逻辑
    /// </summary>
    public partial class ColorPicker : UserControl,INotifyPropertyChanged
    {
        public ColorPicker()
        {
            InitializeComponent();
            this.DataContext = this;

        }

        private bool basic =false;

        public bool Basic
        {
            get { return basic; }
            set { basic =value; }
        }







        private void ThumbPro_ValueChanged(double xpercent, double ypercent)
        {
            Hue = 360 * ypercent;
            HsbaColor Hcolor = new HsbaColor(Hue, 1, 1, 1);
            viewSelectColor.Fill = Hcolor.SolidColorBrush;

            Hcolor = new HsbaColor(Hue, Saturation, Brightness, 1);
            SelectColor = Hcolor.SolidColorBrush;
            ColorChange(Hcolor.RgbaColor);
        }

        private void ThumbPro_ValueChanged_1(double xpercent, double ypercent)
        {
            Saturation = xpercent;
            Brightness = 1 - ypercent;
            HsbaColor Hcolor = new HsbaColor(Hue, Saturation, Brightness, 1);

            SelectColor = Hcolor.SolidColorBrush;

            ColorChange(Hcolor.RgbaColor);
        }

        SolidColorBrush _SelectColor=Brushes.Transparent;
        public SolidColorBrush SelectColor
        {
            get
            {
                return _SelectColor;
            }
            set
            {
                _SelectColor = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SelectColor"));
                BrushValueChanged?.Invoke(this, new RoutedEventArgs());
            }
        }
        public delegate void ChangeEventHandler(object sender, RoutedEventArgs e);
        public event ChangeEventHandler BrushValueChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(propertyyName)));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            RgbaColor Hcolor = new RgbaColor(R, G, B, A);
            SelectColor = Hcolor.SolidColorBrush;
            TextHex.Text = Hcolor.HexString;
            Brightness = Hcolor.HsbaColor.B;
            Saturation = Hcolor.HsbaColor.S;
            hue = Hcolor.HsbaColor.H;

            HsbaColor Hcolor1 = new HsbaColor(Hcolor.HsbaColor.H, 1, 1, 1);

            viewSelectColor.Fill = Hcolor1.SolidColorBrush;
            UpdateThumb(Hcolor);
        }
        //HSB

        private double hue = 0;
        public double Hue
        {
            get { return hue; }
            set
            {
                hue = value;
            }

        }

        private double saturation = 1;
        public double Saturation
        {
            get { return saturation; }
            set
            {
                saturation = value;
            }
        }

        private double brightness;
        public double Brightness
        {
            get { return brightness; }
            set
            {
                brightness = value;
            }
        }






        private int r;

        public int R
        {
            get { return r; }
            set {
                r = r <= 255 ? r >= 0? value:0:255;

                NotifyPropertyChanged();
            }
        }
        private int b;

        public int B
        {
            get { return b; }
            set {
                b = b <= 255 ? b >= 0 ? value : 0 : 255;
                NotifyPropertyChanged();
            }
        }
        private int g;

        public int G
        {
            get { return g; }
            set { 
                g = g <= 255 ? g >= 0 ? value : 0 : 255;
                NotifyPropertyChanged();
            }
        }
        private int a;

        public int A
        {
            get { return a; }
            set {
                a = a <= 255 ? a >= 0 ? value : 0 : 255;
                NotifyPropertyChanged();
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;


        private void HexTextLostFocus(object sender, RoutedEventArgs e)
        {
            RgbaColor Hcolor = new RgbaColor(TextHex.Text);
            SelectColor = Hcolor.SolidColorBrush;
            R = Hcolor.R;
            G = Hcolor.G;
            B = Hcolor.B;
            A = Hcolor.A;
            UpdateThumb(Hcolor);

        }

        private void ColorChange(RgbaColor Hcolor)
        {
            R = Hcolor.R;
            G = Hcolor.G;
            B = Hcolor.B;   
            A = Hcolor.A;   
            TextHex.Text = Hcolor.HexString;

        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            pop.IsOpen = true;

            SelectColor = btn.Background as SolidColorBrush;

            RgbaColor Hcolor = new RgbaColor(SelectColor);
            ColorChange(Hcolor);
            UpdateThumb(Hcolor);

        }

        private void UpdateThumb(RgbaColor Hcolor)
        {
            var xpercent = Hcolor.HsbaColor.S;
            var ypercent = 1 - Hcolor.HsbaColor.B;

            var Ypercent = Hcolor.HsbaColor.H / 360;

            thumbH.SetTopLeftByPercent(1, Ypercent);
            thumbSB.SetTopLeftByPercent(xpercent, ypercent);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            pop.IsOpen = false;

        }
        public List<Brush> brushes = new List<Brush>() { Brushes.Red, Brushes.Lime, Brushes.Blue, Brushes.Yellow, Brushes.Cyan, Brushes.Magenta, Brushes.White,Brushes.Black};
        private void root_Initialized(object sender, EventArgs e)
        {

        }

        private void root_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (var item in brushes)
            {
                Button button = new Button
                {
                    Height = 15,
                    Width = 15,
                    Style = this.FindResource("ButtonStyle1") as Style,
                    Margin = new Thickness(1, 2, 1, 2),
                    Background = item
                };
                button.Click += delegate (object sender, RoutedEventArgs e)
                {
                    if (sender is Button button1)
                    {
                        SelectColor = button1.Background as SolidColorBrush;
                        RgbaColor Hcolor = new RgbaColor(SelectColor);
                        ColorChange(Hcolor);
                        UpdateThumb(Hcolor);
                    }

                };
                if (Basic)
                {
                    PreSetColorGrid1.Children.Add(button);
                }
                else
                {
                    PreSetColorGrid.Children.Add(button);
                }
            }
            Grid1.Visibility = Basic ? Visibility.Visible : Visibility.Collapsed;
            Grid2.Visibility = Basic ? Visibility.Collapsed : Visibility.Visible;
        }
    }

    /// <summary>
    /// 封装Canvas 到Thumb来简化 Thumb的使用，关注熟悉X,Y 表示 thumb在坐标中距离左，上的距离
    /// 默认canvas 里用一个小圆点来表示当前位置
    /// </summary>
    public class ThumbPro : Thumb
    {
        //距离Canvas的Top,模板中需要Canvas.Top 绑定此Top
        public double Top
        {
            get { return (double)GetValue(TopProperty); }
            set { SetValue(TopProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Top.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TopProperty =
            DependencyProperty.Register("Top", typeof(double), typeof(ThumbPro), new PropertyMetadata(0.0));


        //距离Canvas的Top,模板中需要Canvas.Left 绑定此Left
        public double Left
        {
            get { return (double)GetValue(LeftProperty); }
            set { SetValue(LeftProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Left.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LeftProperty =
            DependencyProperty.Register("Left", typeof(double), typeof(ThumbPro), new PropertyMetadata(0.0));

        double FirstTop;
        double FirstLeft;

        //小圆点的半径
        public double Xoffset { get; set; }
        public double Yoffset { get; set; }

        public bool VerticalOnly { get; set; } = false;

        public double Xpercent { get { return (Left + Xoffset) / ActualWidth; } }
        public double Ypercent { get { return (Top + Yoffset) / ActualHeight; } }

        public void SetTopLeftByPercent(double xpercent, double ypercent)
        {
            Top = ypercent * ActualHeight - Yoffset;
            if (!VerticalOnly)
                Left = xpercent * ActualWidth - Xoffset;
        }

        public event Action<double, double> ValueChanged;

        public ThumbPro()
        {
            Loaded += (object sender, RoutedEventArgs e) => {
                if (!VerticalOnly)
                    Left = -Xoffset;
                Top = -Yoffset;


            };
            DragStarted += (object sender, DragStartedEventArgs e) =>
            {
                //当随便点击某点，把小远点移到当前位置，注意是小远点的中心位置移到当前位置
                if (!VerticalOnly)
                {
                    Left = e.HorizontalOffset - Xoffset;
                    FirstLeft = Left;
                }
                Top = e.VerticalOffset - Yoffset;
                FirstTop = Top;

                ValueChanged?.Invoke(Xpercent, Ypercent);
            };

            DragDelta += (object sender, DragDeltaEventArgs e) =>
            {
                //按住拖拽时，小远点随着鼠标移动
                if (!VerticalOnly)
                {
                    double x = FirstLeft + e.HorizontalChange;

                    if (x < -Xoffset) Left = -Xoffset;
                    else if (x > ActualWidth - Xoffset) Left = ActualWidth - Xoffset;
                    else Left = x;
                }




                double y = FirstTop + e.VerticalChange;

                if (y < -Yoffset) Top = -Yoffset;
                else if (y > ActualHeight - Yoffset) Top = ActualHeight - Yoffset;
                else Top = y;
                ValueChanged?.Invoke(Xpercent, Ypercent);
            };
        }
    }
}
