using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Mode
{
    public class UpdateStatus :INotifyPropertyChanged
    {


        public event PropertyChangedEventHandler? PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(propertyyName)));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private string imageX = "X:1234";

        public string ImageX

        {
            get { return imageX; }
            set { 
                imageX = value;
                NotifyPropertyChanged();
            }
        }

        private string imageY = "Y:1234";

        public string ImageY

        {
            get { return imageY; }
            set
            {
                imageY = value;
                NotifyPropertyChanged();
            }
        }
        private string imageZ = "Z:1234";

        public string ImageZ

        {
            get { return imageZ; }
            set
            {
                imageZ = value;
                NotifyPropertyChanged();
            }
        }

    }
}
