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
		private double maxMum = 5;

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

		private double current = 1;

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

		private double loadingMax = 3;

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





	}
}
