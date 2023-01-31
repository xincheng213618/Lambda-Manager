﻿using Global.Common;
using System.Collections.Generic;

namespace Solution
{
    public class ProjectExportAs : ViewModelBase
    {

        public string FullName { get; set; } = "";


        private string exportFullName = string.Empty;

        public string ExportFullName
        {
            get { return exportFullName; }
            set
            {
                if (value != null && value != exportFullName)
                    exportFullName = value; NotifyPropertyChanged();
            }
        }
        private SeriesExportKinds kinds = SeriesExportKinds.mp4;
        public SeriesExportKinds Kinds
        {
            get { return kinds; }
            set
            {
                if (value != kinds)
                    kinds = value; NotifyPropertyChanged();
            }
        }

        public List<string> Mode { get; set; } = new List<string>();
        public List<string> FrameList { get; set; } = new List<string>();


        private bool outputoverlayimage = false;
        public bool OutputOverlayImage
        {
            get { return outputoverlayimage; }
            set
            {
                if (value != outputoverlayimage)
                    outputoverlayimage = value; NotifyPropertyChanged();
            }
        }
        private bool useDirectory = false;
        public bool UseDirectory
        {
            get { return useDirectory; }
            set
            {
                if (value != useDirectory)
                    useDirectory = value; NotifyPropertyChanged();
            }
        }
        private bool savedCalloutContent = false;
        public bool SavedCalloutContent
        {
            get { return savedCalloutContent; }
            set
            {
                if (value != savedCalloutContent)
                    savedCalloutContent = value; NotifyPropertyChanged();
            }
        }

        private bool saveOriginalImage = false;
        public bool SaveOriginalImage
        {
            get { return saveOriginalImage; }
            set
            {
                if (value != saveOriginalImage)
                    saveOriginalImage = value; NotifyPropertyChanged();
            }
        }


        private bool exportView = false;
        public bool ExportView
        {
            get { return exportView; }
            set
            {
                if (value != exportView)
                    exportView = value; NotifyPropertyChanged();
            }
        }

        private bool exportViewROI = false;
        public bool ExportViewROI
        {
            get { return exportViewROI; }
            set
            {
                if (value != exportViewROI)
                    exportViewROI = value; NotifyPropertyChanged();
            }
        }

        private bool exportAllImages = false;
        public bool ExportAllImages
        {
            get { return exportAllImages; }
            set
            {
                if (value != exportAllImages)
                    exportAllImages = value; NotifyPropertyChanged();
            }
        }

        //拍照时间
        private bool photoTime = false;
        public bool PhotoTime
        {
            get { return photoTime; }
            set
            {
                if (value != photoTime)
                    photoTime = value; NotifyPropertyChanged();
            }
        }


        //相对开始采集时间间隔
        private bool relativeInterval = false;
        public bool RelativeInterval
        {
            get { return relativeInterval; }
            set
            {
                if (value != relativeInterval)
                    relativeInterval = value; NotifyPropertyChanged();
            }
        }

        //标尺信息
        private bool rulerInformation = false;
        public bool RulerInformation
        {
            get { return rulerInformation; }
            set
            {
                if (value != rulerInformation)
                    rulerInformation = value; NotifyPropertyChanged();
            }
        }

        //维度信息
        private bool dimensionInformation = false;
        public bool DimensionInformation
        {
            get { return dimensionInformation; }
            set
            {
                if (value != dimensionInformation)
                    dimensionInformation = value; NotifyPropertyChanged();
            }
        }

        private int compression = 0;
        //压缩，默认store 0
        public int Compression
        {
            get { return compression; }
            set
            {
                if (value != compression)
                    compression = value; NotifyPropertyChanged();
            }
        }


    }
}
