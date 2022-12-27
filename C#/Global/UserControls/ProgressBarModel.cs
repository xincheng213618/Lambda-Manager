using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Global
{
    public  class ProgressBarModel : ViewModelBase1
    {
		private double miniMum = 0;

		public double MiniMum
		{
			get { return miniMum; }
			set
			{
				if (miniMum != value)
				{
					miniMum = value;
					RaisePropertyChanged(nameof(MiniMum));
				}
			}
		}
		private double sliderValueH = 0;

		public double SliderValueH
		{
			get { return sliderValueH; }
			set
			{
				if (sliderValueH != value)
				{
					sliderValueH = value;
					RaisePropertyChanged(nameof(SliderValueH));
				}
			}
		}

		private double sliderValueV = 0;

		public double SliderValueV
		{
			get { return sliderValueV; }
			set
			{
				if (sliderValueV != value)
				{
					sliderValueV = value;
					RaisePropertyChanged(nameof(SliderValueV));
				}
			}
		}

		private double maxMum = 0;

		public double MaxMum
		{
			get { return maxMum; }
			set
			{
				if (maxMum != value)
				{
					maxMum = value;
					RaisePropertyChanged(nameof(MaxMum));
				}
			}
		}

		private double current = 0;

		public double Current
		{
			get { return current; }
			set
			{
				if (current != value)
				{
					current = value;
					RaisePropertyChanged(nameof(Current));
				}
			}
		}

		private double loadingMax =0;

		public double LoadingMax
		{
			get { return loadingMax; }
			set
			{
				if (loadingMax != value)
				{
					loadingMax = value;
					RaisePropertyChanged(nameof(LoadingMax));
				}
			}
		}

		private double miniMumZ = 0;

		public double MiniMumZ
		{
			get { return miniMumZ; }
			set
			{
				if (miniMumZ != value)
				{
					miniMumZ = value;
					RaisePropertyChanged(nameof(MiniMumZ));
				}
			}
		}
		private double maxMumZ = 0;

		public double MaxMumZ
		{
			get { return maxMumZ; }
			set
			{
				if (maxMumZ != value)
				{
					maxMumZ = value;
					RaisePropertyChanged(nameof(MaxMumZ));
				}
			}
		}

		private double currentZ = 0;

		public double CurrentZ
		{
			get { return currentZ; }
			set
			{
				if (currentZ != value)
				{
					currentZ = value;
					RaisePropertyChanged(nameof(CurrentZ));
				}
			}
		}

		private double loadingMaxZ = 0;

		public double LoadingMaxZ
		{
			get { return loadingMaxZ; }
			set
			{
				if (loadingMaxZ != value)
				{
					loadingMaxZ = value;
					RaisePropertyChanged(nameof(LoadingMaxZ));
				}
			}
		}



	}
}
