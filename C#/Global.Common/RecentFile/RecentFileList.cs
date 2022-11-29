﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.RecentFile
{
    public class RecentFileList
    {
        public IPersist Persister { get; set; }

        public int MaxNumberOfFiles { get; set; }
        public int MaxPathLength { get; set; }
        /// <summary>
        /// Used in: String.Format( MenuItemFormat, index, filepath, displayPath );
        /// Default = "_{0}:  {2}"
        /// </summary>
        public string MenuItemFormatOneToNine { get; set; }

        /// <summary>
        /// Used in: String.Format( MenuItemFormat, index, filepath, displayPath );
        /// Default = "{0}:  {2}"
        /// </summary>
        public string MenuItemFormatTenPlus { get; set; }

        public RecentFileList()
        {
            Persister = new RegistryPersister();
            MaxNumberOfFiles = 15;
            MaxPathLength = 50;
            MenuItemFormatOneToNine = "_{0}:  {2}";
            MenuItemFormatTenPlus = "{0}:  {2}";
        }

        public List<string> RecentFiles { get { return Persister.RecentFiles(MaxNumberOfFiles); } }
        public void RemoveFile(string filepath) { Persister.RemoveFile(filepath, MaxNumberOfFiles); }
        public void InsertFile(string filepath) { Persister.InsertFile(filepath, MaxNumberOfFiles); }

        public void Clear() { Persister.Clear(); }

        


    }
}
