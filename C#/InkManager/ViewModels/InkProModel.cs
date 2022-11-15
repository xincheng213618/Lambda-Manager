using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace InkManager.ViewModels
{
    public class InkProModel :INotifyPropertyChanged
    {
		#region fields

		private Color _SelectedAccentColor = Color.FromArgb(240, 240, 0, 0);
		private Color _TextSelectedAccentColor = Colors.White;
		private double _length = 100;
		private double _angle = 0;
		private bool _label = false;

		private bool _bold = false;
		private bool _italic = false;
		private bool _underLine = false;
		private bool _autoColor = false;
		private int _dashSelectedIndex = 0;
		private int _dimSelectedIndex = 0;
		private FontFamily _fontFamily = new FontFamily("Arial");
		private int _fontSize = 16;
		private string _labelPos = " 上中";
		private string _dimPos = "下右";
		private bool _dimPosShow = false;
		private bool _labPosShow = false;
		private bool _dimShapeCombo = false;
		private int _lineWidth = 2;
		private bool _LineProEnable = true;
		private bool _defDimReadOnly = true;

		#endregion fields
		public InkProModel()
		{

			FontSizeList = new List<int> { 8, 9, 10, 11, 12, 14, 16, 18, 19, 20, 22, 24, 26, 28, 36, 48, 72 };
			LabelPosList = new List<string> { " 上左", " 上中", " 上右", " 下左", " 下中", " 下右" };

		}
		#region properties

		/// <summary>
		/// Gets/sets the currently selected color.
		/// </summary>
		public Color SelectedAccentColor
		{
			get { return _SelectedAccentColor; }
			set
			{
				if (_SelectedAccentColor != value)
				{
					_SelectedAccentColor = value;
					NotifyPropertyChanged(nameof(SelectedAccentColor));
				}
			}
		}
		public Color TextSelectedAccentColor
		{
			get { return _TextSelectedAccentColor; }
			set
			{
				if (_TextSelectedAccentColor != value)
				{
					_TextSelectedAccentColor = value;
					NotifyPropertyChanged(nameof(TextSelectedAccentColor));
				}
			}
		}

		public List<int> FontSizeList { get; set; }
		public List<string> LabelPosList { get; set; }
		public List<string> DimPosList { get; set; } = new List<string>() { "上左", "上右", "下左", "下右" };

		public bool DimShapeCombo
		{
			get { return _dimShapeCombo; }
			set
			{
				if (_dimShapeCombo != value)
				{
					_dimShapeCombo = value;
					NotifyPropertyChanged(nameof(DimShapeCombo));
				}
			}
		}
		public bool DefDimReadOnly
		{
			get { return _defDimReadOnly; }
			set
			{
				if (_defDimReadOnly != value)
				{
					_defDimReadOnly = value;
					NotifyPropertyChanged(nameof(DefDimReadOnly));
				}
			}
		}
		public bool LineProEnable
		{
			get { return _LineProEnable; }
			set
			{
				if (_LineProEnable != value)
				{
					_LineProEnable = value;
					NotifyPropertyChanged(nameof(LineProEnable));
				}
			}
		}


		public int FontSize
		{
			get { return _fontSize; }
			set
			{
				if (_fontSize != value)
				{
					_fontSize = value;
					NotifyPropertyChanged(nameof(FontSize));
				}
			}
		}

		public int LineWidth
		{
			get { return _lineWidth; }
			set
			{
				if (_lineWidth != value)
				{
					_lineWidth = value;
					NotifyPropertyChanged(nameof(LineWidth));
				}
			}
		}





		public bool DimPosShow
		{
			get { return _dimPosShow; }
			set
			{
				if (_dimPosShow != value)
				{
					_dimPosShow = value;
					NotifyPropertyChanged(nameof(DimPosShow));
				}
			}
		}

		public bool LabelPosShow
		{
			get { return _labPosShow; }
			set
			{
				if (_labPosShow != value)
				{
					_labPosShow = value;
					NotifyPropertyChanged(nameof(LabelPosShow));
				}
			}
		}

		public string LabelPos
		{
			get { return _labelPos; }
			set
			{
				if (_labelPos != value)
				{
					_labelPos = value;
					NotifyPropertyChanged(nameof(LabelPos));
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
					NotifyPropertyChanged(nameof(DimPos));
				}
			}
		}






		public FontFamily FontFam
		{
			get { return _fontFamily; }
			set
			{
				if (_fontFamily != value)
				{
					_fontFamily = value;
					NotifyPropertyChanged(nameof(FontFam));
				}
			}
		}

		public int DimSelectedIndex
		{
			get
			{
				return _dimSelectedIndex;
			}
			set
			{
				if (_dimSelectedIndex != value)
				{
					_dimSelectedIndex = value;
					//Console.WriteLine()
					NotifyPropertyChanged(nameof(DimSelectedIndex));
				}

			}

		}
		public int DashSelectedIndex
		{
			get
			{
				return _dashSelectedIndex;
			}
			set
			{
				if (_dashSelectedIndex != value)
				{
					_dashSelectedIndex = value;
					//Console.WriteLine()
					NotifyPropertyChanged(nameof(DashSelectedIndex));
				}

			}

		}

		public double Length

		{
			get { return _length; }
			set
			{
				if (_length != value)
				{
					_length = value;
					NotifyPropertyChanged(nameof(Length));
				}
			}
		}
		public double Angle
		{
			get { return _angle; }
			set
			{
				if (_angle != value)
				{
					_angle = value;
					NotifyPropertyChanged(nameof(Angle));
				}
			}
		}

		public bool Label
		{
			get { return _label; }
			set
			{
				if (_label != value)
				{
					_label = value;
					NotifyPropertyChanged(nameof(Label));
				}
			}
		}
		public bool AutoColor
		{
			get { return _autoColor; }
			set
			{
				if (_autoColor != value)
				{
					_autoColor = value;
					NotifyPropertyChanged(nameof(AutoColor));
				}
			}
		}
		public bool Bold
		{
			get { return _bold; }
			set
			{
				if (_bold != value)
				{
					_bold = value;
					NotifyPropertyChanged(nameof(Bold));
				}
			}
		}
		public bool Italic
		{
			get { return _italic; }
			set
			{
				if (_italic != value)
				{
					_italic = value;
					NotifyPropertyChanged(nameof(Italic));
				}
			}
		}

		public bool UnderLine
		{
			get { return _underLine; }
			set
			{
				if (_underLine != value)
				{
					_underLine = value;
					NotifyPropertyChanged(nameof(UnderLine));
				}
			}
		}

		#endregion properties
		#region INotifyPropertyChanged Members
		public event PropertyChangedEventHandler? PropertyChanged;
		//public event PropertyChangedEventHandler PropertyChanged;

		#endregion


		private void NotifyPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

	}


}

