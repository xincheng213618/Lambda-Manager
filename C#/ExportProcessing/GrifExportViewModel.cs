using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportProcessing
{
    public class GrifExportViewModel:ViewModelBase
    {
        private string fullName = string.Empty;
        public string FullName
        {
            get { return fullName; }
            set
            {
                if (value != null && value != fullName)
                    fullName = value; NotifyPropertyChanged();
            }
        }
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

        private ExportAsKinds kinds = ExportAsKinds.png;
        public ExportAsKinds Kinds
        {
            get { return kinds; }
            set
            {
                if (value != kinds)
                    kinds = value; NotifyPropertyChanged();
            }
        }
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

        private int exportType = 0;
        public int ExportType
        {
            get { return exportType; }
            set
            {
                if (value != exportType)
                    exportType = value; NotifyPropertyChanged();
            }
        }
        private int exportWindow = 0;
        public int ExportWindow
        {
            get { return exportWindow; }
            set
            {
                if (value != exportWindow)
                    exportWindow = value; NotifyPropertyChanged();
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
            get { return relativeInterval; }
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


    }



}

