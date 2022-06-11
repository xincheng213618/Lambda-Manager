using Global.Common;
using NLGSolution;
using Solution;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Tool;

namespace NLGSolution
{
    public class SeriesProjectManager : BaseObject
    {

        private string fileSize;
        public string FileSize
        {
            get { return fileSize; }
            set { fileSize = value; NotifyPropertyChanged(); }
        }


        private async void CalculSize()
        {
            //加延迟是为了显示效果更好。
            await Task.Delay(1000);
            FileSize = MemorySize.MemorySizeText(MemorySize.GetDirectoryLength(FullPath));
        }


        /// <summary>
        /// 导出为
        /// </summary>
        public RelayCommand PoejectExportAs { get; set; }

        public SeriesProjectManager(string SeriesFolderPath) : base(SeriesFolderPath)
        {
            CanReName = false;
            PoejectExportAs = new RelayCommand(OnPoejectExportAs, (object value) => { return true; });
            Task.Run(CalculSize);

        }
        private void OnPoejectExportAs(object value)
        {
            ExportAsWindow exportAsWindow = new ExportAsWindow(this);
            exportAsWindow.ShowDialog();
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

        private string tempname;
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
