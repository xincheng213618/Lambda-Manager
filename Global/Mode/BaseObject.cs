using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;

namespace Global.Mode
{
    public class ModeBaseObject :INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public string ToJson()
        {
            return Utils.ToJson(this);
        }
        public int ToJsonFile(string filePath)
        {
            return Utils.ToJsonFile(this ,filePath, false);
        }
    }
}
