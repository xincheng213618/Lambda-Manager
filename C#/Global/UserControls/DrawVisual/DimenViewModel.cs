using System.Collections.Generic;
using System.Windows.Media;

namespace Global
{
    public  class DimenViewModel: ViewModelBase1
    {
		#region fields

		private Color _SelectedAccentColor;
		private Color _TextSelectedAccentColor=Colors.White;
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
		private bool _dimPosShow=false;
		private bool _labPosShow = false;
		private bool _dimShapeCombo = false;
		private int _lineWidth = 2;
		private bool _LineProEnable = true;
		private bool _defDimReadOnly = true;

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
					NotifyPropertyChanged();
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
                    NotifyPropertyChanged();
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
                    NotifyPropertyChanged();
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
                    NotifyPropertyChanged();
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
                    NotifyPropertyChanged();
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
                    NotifyPropertyChanged();
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
                    NotifyPropertyChanged();
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
                    NotifyPropertyChanged();
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
                    NotifyPropertyChanged();
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
                    NotifyPropertyChanged();
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
                    NotifyPropertyChanged();
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
                    NotifyPropertyChanged();
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
                    NotifyPropertyChanged();
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
                    NotifyPropertyChanged();
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
                    NotifyPropertyChanged();
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
                    NotifyPropertyChanged();
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
                    NotifyPropertyChanged();
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
                    NotifyPropertyChanged();
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
                    NotifyPropertyChanged();
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
                    NotifyPropertyChanged();
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
                    NotifyPropertyChanged();
                }
            }
		}

		#endregion properties

	}
}

