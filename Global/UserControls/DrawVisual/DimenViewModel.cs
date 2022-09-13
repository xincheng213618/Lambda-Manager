using System.Collections.Generic;
using System.Windows.Media;

namespace Global
{
    public  class DimenViewModel: ViewModelBase1
    {
		#region fields

		private Color _SelectedAccentColor;
		private double _length = 100;
		private double _angle = 0;
		private bool _label = false;

		private bool _bold = false;
		private bool _italic = false;
		private bool _underLine = false;
		private bool _autoColor = false;
		private int _dimSelectedIndex = 0;
		private FontFamily _fontFamily = new FontFamily("Arial");
		private int _fontSize = 16;
		private string _labelPos = " 上中";
		private string _dimPos = "下右";
		private bool _dimPosShow=false;
		private bool _labPosShow = false;
		private bool _dimShapeCombo = false;

		#endregion fields
		public DimenViewModel()
		{
			_SelectedAccentColor = Color.FromArgb(240, 240, 0, 0);

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
					RaisePropertyChanged(() => SelectedAccentColor);
				}
			}
		}

		public List<int> FontSizeList { get; set; }
		public List<string> LabelPosList { get; set; }
		public List<string> DimPosList { get; set; } = new List<string>() { "上左", "上右", "下左",  "下右" };

		public bool DimShapeCombo
        {
			get { return _dimShapeCombo; }
			set
			{
				if (_dimShapeCombo != value)
				{
					_dimShapeCombo = value;
					RaisePropertyChanged(nameof(DimShapeCombo));
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
					RaisePropertyChanged(nameof(FontSize));
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
					RaisePropertyChanged(nameof(DimPosShow));
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
					RaisePropertyChanged(nameof(LabelPosShow));
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
					RaisePropertyChanged(nameof(LabelPos));
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






		public FontFamily FontFam
		{
			get { return _fontFamily; }
			set
			{
				if (_fontFamily != value)
				{
					_fontFamily = value;
					RaisePropertyChanged(nameof(FontFam));
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
					RaisePropertyChanged(nameof(DimSelectedIndex));
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
					RaisePropertyChanged(nameof(Length));
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
					RaisePropertyChanged(nameof(Angle));
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
					RaisePropertyChanged(nameof(Label));
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
					RaisePropertyChanged(nameof(AutoColor));
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
					RaisePropertyChanged(nameof(Bold));
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
					RaisePropertyChanged(nameof(Italic));
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
					RaisePropertyChanged(nameof(UnderLine));
				}
			}
		}

		#endregion properties

	}
}

