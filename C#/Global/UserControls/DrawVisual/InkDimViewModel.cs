using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Global.UserControls.DrawVisual
{
    public class InkDimViewModel : ViewModelBase1
    {

		private Color color = Color.FromArgb(240, 240, 0, 0);
		private Color textcolor= Colors.White;
		private double length = 100;
		private string _dimPos = "下右";
		

		/// <summary>
		/// Gets/sets the currently selected color.
		/// </summary>
		public Color DimColor
		{
			get { return color; }
			set
			{
				if (color != value)
				{
					color = value;
					RaisePropertyChanged(() => DimColor);
				}
			}
		}
		public Color TextColor
		{
			get { return textcolor; }
			set
			{
				if (textcolor != value)
				{
					textcolor = value;
					RaisePropertyChanged(() => TextColor);
				}
			}
		}

		

		public double DimLength
		{
			get { return length; }
			set
			{
				if (length != value)
				{
					length = value;
					RaisePropertyChanged(nameof(DimLength));
				}
			}
		}
		

		

		public string DimPos
		{
			get { return _dimPos; }
			set
			{
				if (_dimPos != value)
				{
					_dimPos = value;
					RaisePropertyChanged(nameof(DimPos));
				}
			}
		}












	}
}
