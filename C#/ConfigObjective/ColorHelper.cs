using System.Windows.Media;

namespace ConfigObjective
{
    public class ColorHelper
    {
        public ColorHelper(System.Drawing.Color color)
        {
            Util.ColorToHSV(color,out Hue, out Saturation, out Brightness);
            A = color.A;
            R = color.R;
            G = color.G;
            B = color.B;
        }

        public ColorHelper(int A, int R ,int G, int B)
        {
            this.A = A;
            this.R = R;
            this.G = G;
            this.B = B;
            Util.ColorToHSV(System.Drawing.Color.FromArgb(A,R,G,B), out Hue, out Saturation, out Brightness);
        }

        public SolidColorBrush SolidColorBrush
        {
            get { return new SolidColorBrush(Color.FromArgb((byte)A, (byte)R, (byte)G, (byte)B)); }
        }
        public void ChangeBrightness(double Brightness)
        {
            this.Brightness = Brightness;
            Color = Util.ColorFromHSV(Hue,Saturation,Brightness);
            this.A = Color.A;
            this.R = Color.R;
            this.G = Color.G;
            this.B = Color.B;

        }
        public Color Color;

        public int A;
        public int R;
        public int G;
        public int B;

        public double Hue;
        public double Saturation;
        public double Brightness;




    }


}


