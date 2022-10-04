using Global.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XSolution
{
    public class FileBase:ViewModelBase
    {
        public static ObservableCollection<FileBase> FileKinds { get; set; } = new ObservableCollection<FileBase>();

        public FileBase()
        {  
            FileKinds.Add(this);
        }
    }
    public class FileBase1 : FileBase
    {
        public FileBase1() : base()
        {

        }
    }

}
