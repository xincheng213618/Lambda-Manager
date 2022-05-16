using NLGSolution;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NLGSolution
{
    public class SeriesProjectManager : BaseObject
    {
        public SeriesProjectManager(string SeriesFolderPath) : base(SeriesFolderPath)
        {
            CanReName = false;
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

        public override bool IsEditMode
        {
            get { return isEditMode; }
            set
            {
                isEditMode = value;
                if (!isEditMode)
                {
                    string oldpath = FullPath;
                    string newpath = oldpath.Substring(0, oldpath.LastIndexOf("\\") + 1) + name;
                    if (newpath != FullPath)
                    {
                        try
                        {
                            Directory.Move(oldpath, newpath);
                            FullPath = newpath;
                            tempname = name;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("文件名冲突" + ex.Message);
                            Name = tempname;
                            isEditMode = true;
                        }
                    }
                }
                else
                {
                    tempname = name;
                }
                NotifyPropertyChanged();
            }
        }




    }


}
