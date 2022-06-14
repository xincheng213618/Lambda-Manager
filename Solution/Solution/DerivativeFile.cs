using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NLGSolution
{
    public class DerivativeFile: BaseObject
    {

        public DerivativeFile(string FullPath):base(FullPath)
        {

        }
    }

    public class DerivativeSeriesFile : BaseObject
    {

        public DerivativeSeriesFile(string FullPath) : base(FullPath)
        {

        }

        public override void Delete()
        {
            base.Delete();
            try
            {
                if (Directory.Exists(FullPath))
                    Directory.Delete(FullPath, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}
