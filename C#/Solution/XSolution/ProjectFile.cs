using Global.Common;
using Lambda;
using Microsoft.Win32;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using Tool;
using System.Diagnostics;
using Global.Common.Extensions;
using Solution;
using System.Drawing;
using Global.Common.NativeMethods;
using System.Windows.Media;

namespace XSolution
{


    //暂时没啥用，用来作为一个反射的一个入口
    public interface IProjectFile
    {
        public string GetExtension();
        public string[] SupportExtensions();
    };

    public class ProjectFile : BaseObject, IProjectFile
    {
        /// <summary>
        /// 图标
        /// </summary>
        public ImageSource Icon { get =>_Icon; set { _Icon = value; NotifyPropertyChanged(); } }
        private ImageSource _Icon;



        /// <summary>
        /// 文件大小
        /// </summary>
        public string FileSize { get => _FileSize; set { _FileSize = value; NotifyPropertyChanged(); } }
        private string _FileSize;

        public RelayCommand OpenFileCommand { get; set; }
        public RelayCommand AttributesCommand { get; set; }



        protected FileInfo FileInfo;

        /// <summary>
        /// 文件是否存在
        /// </summary>
        public bool Exists { get => FileInfo.Exists; }

        public ProjectFile(string FullName) : base(FullName)
        {
            FileInfo = new FileInfo(FullName);
            Name = FileInfo.Name;
            Icon = FileIcon.GetFileIcon(FullName).ToImageSource();

            OpenFileCommand = new RelayCommand((o)=>Process.Start("explorer.exe", FullName), (object value) => { return Exists; });
            AttributesCommand = new RelayCommand((o) => FileProperties.ShowFileProperties(FullName) , (object value) => { return Exists; });

            Task.Run(CalculSize);
        }

   

        public override void AddChildDialog(object obj)
        {
            OpenFileDialog dialog = new()
            {
                Title = "请选择文件",
                RestoreDirectory = true,
                Filter = "Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif |JPEG Image (.jpeg)|*.jpeg |Png Image (.png)|*.png |Tiff Image (.tiff)|*.tiff |Wmf Image (.wmf)|*.wmf"
            };
            if (dialog.ShowDialog() == true)
            {
                AddChild(new DerivativeFile(dialog.FileName)); 
            }
        }

        public void CalculSize()
        {
            if (FileInfo.Exists)
            {
                FileSize = MemorySize.MemorySizeText(FileInfo.Length);
            }
        }


        public override bool IsEditMode
        {
            get => _IsEditMode;
            set
            {
                if (value == _IsEditMode) return;
                if (_IsEditMode)
                {
                    string newpath = string.Concat(FullName.AsSpan(0, FullName.LastIndexOf("\\") + 1), Name, GetExtension());
                    if (newpath != FullName)
                    {
                        try
                        {
                            File.Move(FullName, newpath);
                            FullName = newpath;
                        }
                        catch (Exception ex)
                        {
                            MessageBox1.Show("文件名冲突:" + ex.Message,"Grid");
                            return;
                        }
                    }
                }
                _IsEditMode = value;
                NotifyPropertyChanged();
            }
        }


        public override void Delete()
        {
            base.Delete();
            try
            {
                if (File.Exists(FullName))
                    File.Delete(FullName);
            }
            catch (Exception ex)
            {
                MessageBox1.Show(ex.Message);
            }
        }


        public override void AddChild(BaseObject baseObject)
        {
            base.AddChild(baseObject);
        }

        public override void RemoveChild(BaseObject baseObject)
        {
            if (baseObject == null) return;
            baseObject.Parent = this;

            base.RemoveChild(baseObject);

            if (baseObject.Parent == this)
            {
                baseObject.Parent = null;
                VisualChildren.Remove(baseObject);
                baseObject.Delete();
            }
        }

        public string GetExtension()
        {
            return Path.GetExtension(FullName);
        }
        public string[] SupportExtensions()
        {
            //return new string[] { ".png", ".jpg", ".tiff", ".bmp", ".txt" ,".*" };
            return new string[] { ".png", ".jpg", ".tiff", ".bmp", ".txt"};

        }
    }
}
