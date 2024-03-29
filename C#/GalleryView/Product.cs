﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Windows.Media.Imaging;

namespace GalleryView
{
    public class Product : INotifyPropertyChanged
    {
        private int modelNumber;
        public int ModelNumber
        {
            get { return modelNumber; }
            set
            {
                modelNumber = value;
                OnPropertyChanged(new PropertyChangedEventArgs("ModelNumber"));
            }
        }

        private string modelName;
        public string ModelName
        {
            get { return modelName; }
            set
            {
                modelName = value;
                OnPropertyChanged(new PropertyChangedEventArgs("ModelName"));
            }
        }
        private string mode;
        public string Mode
        {
            get { return mode; }
            set
            {
                mode = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Mode"));
            }
        }



        private decimal unitCost;
        public decimal UnitCost
        {
            get { return unitCost; }
            set
            {
                unitCost = value;
                OnPropertyChanged(new PropertyChangedEventArgs("UnitCost"));
            }
        }

        private string description;
        public string Description
        {
            get { return description; }
            set
            {
                description = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Description"));
            }
        }
        private int sizeLevel = 5;
        public int SizeLevel
        {
            get { return sizeLevel; }
            set
            {
                sizeLevel = value;
                OnPropertyChanged(new PropertyChangedEventArgs("SizeLevel"));
            }
        }
        private string categoryName;
        public string CategoryName
        {
            get { return categoryName; }
            set { categoryName = value; }
        }

        // For DataGridComboBoxColumn example.
        private int categoryID;
        public int CategoryID
        {
            get { return categoryID; }
            set { categoryID = value; }
        }

        private string productImagePath;
        public string ProductImagePath
        {
            get { return productImagePath; }
            set { productImagePath = value; }
        }
        private WriteableBitmap writeableBitmap;

        public WriteableBitmap WRiteableBitmap
        {
            get { return writeableBitmap; }
            set { writeableBitmap = value; }
        }

        public Product(int modelNumber, string modelName,
            decimal unitCost, string description)
        {
            ModelNumber = modelNumber;
            ModelName = modelName;
            UnitCost = unitCost;
            Description = description;
        }
        public Product(WriteableBitmap writeableBitmap)
        {
           
            WRiteableBitmap = writeableBitmap;
        }
        public Product(int modelNum, string modelName, string productImagePath, WriteableBitmap writeableBitmap)
        {
            modelNumber = modelNum;
            ModelName = modelName;
            ProductImagePath = productImagePath;
            WRiteableBitmap = writeableBitmap;
            Mode = modelName.Substring(0, 2);
        }

        public Product(int modelNumber, string modelName,
           decimal unitCost, string description,
           string productImagePath)
            :
           this(modelNumber, modelName, unitCost, description)
        {
            ProductImagePath = productImagePath;
        }

        public Product(int modelNumber, string modelName,
            decimal unitCost, string description, int categoryID,
            string categoryName, string productImagePath) :
            this(modelNumber, modelName, unitCost, description)
        {
            CategoryName = categoryName;
            ProductImagePath = productImagePath;
            CategoryID = categoryID;
        }

        public override string ToString()
        {
            return ModelName + " (" + ModelNumber + ")";
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, e);
        }

        // This for testing date editing. The value isn't actually stored in the database.
        private DateTime dateAdded = DateTime.Today;
        public DateTime DateAdded
        {
            get { return dateAdded; }
            set { dateAdded = value; }
        }

    }
}
