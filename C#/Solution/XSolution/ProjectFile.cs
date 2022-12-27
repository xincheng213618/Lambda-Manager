﻿using Global.Common;
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

        public static ObservableCollection<ProjectFile> ProjectFiles { get; set; } = new ObservableCollection<ProjectFile>();

        /// <summary>
        /// 文件大小
        /// </summary>
        public string FileSize { get => _FileSize; set { _FileSize = value; NotifyPropertyChanged(); } }
        private string _FileSize;

        public RelayCommand OpenFileCommand { get; set; }
        public RelayCommand AttributesCommand { get; set; }


        protected FileInfo FileInfo;
        public ProjectFile()
        {

        }

        public ProjectFile(string FullName) :base(FullName)
        {
            ProjectFiles.Add(this);
            FileInfo = new FileInfo(FullName);
            Name = Path.GetFileNameWithoutExtension(_FullName);
            Icon = FileIcon.GetFileIcon(FullName).ToImageSource();

            OpenFileCommand = new RelayCommand(OpenFile, (object value) => { return true; });
            AttributesCommand = new RelayCommand(delegate { FileProperties.ShowFileProperties(FullName); }, (object value) => { return true; });

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


        private void OpenFile(object value)
        {
            Process.Start("explorer.exe", FullName);
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
            get { return _IsEditMode; }
            set
            {
                if (value != _IsEditMode)
                {
                    _IsEditMode = value;
                    if (!_IsEditMode)
                    {
                        string oldpath = FullName;
                        string newpath = string.Concat(oldpath.AsSpan(0, oldpath.LastIndexOf("\\") + 1), Name, GetExtension());
                        if (newpath != FullName)
                        {
                            try
                            {
                                File.Move(oldpath, newpath);
                                FullName = newpath;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("文件名冲突" + ex.Message);
                                _IsEditMode = true;
                            }
                        }
                    }
                    NotifyPropertyChanged();
                }
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
                MessageBox.Show(ex.Message);
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
