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
using Global.Common.Helper;
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
        public ImageSource Icon { get; set; }

        public static ObservableCollection<ProjectFile> ProjectFiles { get; set; } = new ObservableCollection<ProjectFile>();

        private string fileSize;
        public string FileSize
        {
            get { return fileSize; }
            set { fileSize = value; NotifyPropertyChanged(); }
        }
        public RelayCommand OpenExplorerCommand { get; set; }
        public RelayCommand AttributesCommand { get; set; }


        public RelayCommand ExportAsTiffCommand { get; set; }
        public RelayCommand ExportAsJPEGCommand { get; set; }

        public RelayCommand ExportAsPNGCommand { get; set; }
        public RelayCommand ExportAsBMPCommand { get; set; }


        protected FileInfo FileInfo;
        public ProjectFile(string FullName) :base(FullName)
        {
            ProjectFiles.Add(this);
            FileInfo = new FileInfo(FullName);
            Name = Path.GetFileNameWithoutExtension(fullName);
            Icon = FileIcon.GetFileIcon(FullName).ToImageSource();

            OpenExplorerCommand = new RelayCommand(OpenFolder, (object value) => { return true; });
            ExportAsTiffCommand = new RelayCommand(ExportAsTiff, (object value) => { return true; });
            ExportAsJPEGCommand = new RelayCommand(ExportAsJPEG, (object value) => { return true; });
            ExportAsPNGCommand = new RelayCommand(ExportAsPNG, (object value) => { return true; });
            ExportAsBMPCommand = new RelayCommand(ExportAsBMP, (object value) => { return true; });
            Task.Run(CalculSize);
        }


        private void ExportAsBMP(object value)
        {
            ExportAs(value, "bmp");
        }
        private void ExportAsTiff(object value)
        {
            ExportAs(value, "tiff");
        }
        private void ExportAsJPEG(object value)
        {
            ExportAs(value, "jpeg");
        }
        private void ExportAsPNG(object value)
        {
            ExportAs(value,"png");
        }
   
        public void ExportAs(object value,string kinds)
        {
            string Filter;
            switch (kinds)
            {
                case "png":
                    Filter = "(*.png) | *.png";
                    break;
                case "jpeg":
                    Filter = "(*.jpeg) | *.jpeg";
                    break;
                case "tiff":
                    Filter = "(*.tiff) | *.tiff";
                    break;
                case "bmp":
                    Filter = "(*.bmp) | *.bmp";
                    break;
                default:
                    return;
            }
            SaveFileDialog dialog = new()
            {
                Title = "另存为",
                RestoreDirectory = true,
                Filter = Filter,
            };
            bool? result = dialog.ShowDialog();
            if (result == true)
            {
                GrifExportAs grifExportAs = new GrifExportAs() { FullName = FullName,ExportFullName =dialog.FileName,Kinds =kinds};
                LambdaControl.Trigger("GrifExportAs", this , grifExportAs.ToJson());
            };
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


        private void OpenFolder(object value)
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
            get { return isEditMode; }
            set
            {
                if (value != isEditMode)
                {
                    isEditMode = value;
                    if (!isEditMode)
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
                                isEditMode = true;
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
            return new string[] { ".png", ".jpg", ".tiff", ".bmp", ".txt" };
        }
    }
}