using System;
using System.Collections.Generic;
using System.IO;

namespace Solution.RecentFile
{
    public class JsonFilePersister : IPersist
    {
        public string Filepath { get; set; }
        public Stream Stream { get; set; }

        public JsonFilePersister()
        {
            Filepath = $"{Environment.GetFolderPath(Environment.SpecialFolder.Personal)}\\Gird\\RecentFileList.json";
        }

        public JsonFilePersister(string filepath)
        {
            Filepath = filepath;
        }
        public JsonFilePersister(Stream stream)
        {
            Stream = stream;
        }

        public void InsertFile(string filepath, int max)
        {
            throw new NotImplementedException();
        }

        public List<string> RecentFiles(int max)
        {
            throw new NotImplementedException();
        }

        public void RemoveFile(string filepath, int max)
        {
            throw new NotImplementedException();
        }
    }
}
