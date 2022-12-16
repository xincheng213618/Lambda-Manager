using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace XSolution
{

    public class SolutionGlobal
    {
        private static SolutionGlobal _instance;
        private static readonly object _locker = new();
        public static SolutionGlobal GetInstance() { lock (_locker) { return _instance ??= new SolutionGlobal(); } }



        Dictionary<string[], Type> ProjectFileDic = new Dictionary<string[], Type>() { };

        List<Type> ProjectFileTypeList = new List<Type>();

        private SolutionGlobal()
        {
            foreach (var item in Assembly.GetExecutingAssembly().GetTypes())
            {
                if (!item.IsAbstract && typeof(IProjectFile).IsAssignableFrom(item)&&item.IsClass)
                {
                    string[] SupportExtensions = ((IProjectFile)Activator.CreateInstance(item, "1")).SupportExtensions();

                    ProjectFileDic.Add(SupportExtensions,item);
                    ProjectFileTypeList.Add(item);
                }
            }
        }

        public BaseObject GetProjectFile(string FullName)
        {
            string Extension = Path.GetExtension(FullName);
            foreach (var item in ProjectFileDic)
            {
                if (item.Key.Contains(Extension)|| item.Key.Contains(".*"))
                {
                    return (BaseObject)Activator.CreateInstance(item.Value, FullName);
                }
            };
            return null;
        }

        public static BaseObject FromDirectories(BaseObject baseObject, DirectoryInfo root)
        {
            foreach (var directoryInfo in root.GetDirectories())
            {
                ProjectFolder projectFolder = new ProjectFolder(directoryInfo.FullName);
                baseObject.AddChild(FromDirectories(projectFolder, directoryInfo));
            }
            foreach (var directoryInfo in root.GetFiles())
            {
                baseObject.AddChild(GetInstance().GetProjectFile(directoryInfo.FullName));
            }
            return baseObject;
        }





    }
}
