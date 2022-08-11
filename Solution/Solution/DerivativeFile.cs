using System;
using System.IO;
using System.Windows;

namespace XSolution
{
    public class DerivativeFile: BaseObject
    {

        public DerivativeFile(string FullName) :base(FullName)
        {

        }
    }

    public class DerivativeSeriesFile : BaseObject
    {
        public DerivativeSeriesFile(string FullName) : base(FullName)
        {

        }

        public override void Delete()
        {
            base.Delete();
            try
            {
                if (Directory.Exists(FullName))
                    Directory.Delete(FullName, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}
