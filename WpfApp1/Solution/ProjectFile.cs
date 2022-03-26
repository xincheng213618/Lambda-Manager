using System.Windows.Input;

namespace Solution
{
    public class ProjectFile
    {
        public static RoutedUICommand Rename = new RoutedUICommand();

        public string FileName { get; set; }
        public string FilePath { get; set; }


    }
}
