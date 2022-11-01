using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace XSolution
{
    public static class ReflectiveEnumerator
    {
        static ReflectiveEnumerator() { }

        public static IEnumerable<T> GetEnumerableOfType<T>(params object[] constructorArgs) where T : class, IComparable<T>
        {
            List<T> objects = new List<T>();
            foreach (Type type in Assembly.GetAssembly(typeof(T)).GetTypes().Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(T))))
            {
                objects.Add((T)Activator.CreateInstance(type, constructorArgs));
            }
            objects.Sort();
            return objects;
        }
    }

    //单例 + 反射 + 迭代 + Linq
    public class SolutionGlobal
    {
        private static SolutionGlobal _instance;
        private static readonly object _locker = new();

        Dictionary<string[], Type> ProjectFileDic = new Dictionary<string[], Type>() { };

        List<Type> ProjectFileTypeList = new List<Type>();
        List<string[]> ProjectFileSupportExList = new List<string[]>();

        public static SolutionGlobal GetInstance()
        {
            lock (_locker) { _instance ??= new SolutionGlobal(); }
            return _instance;
        }

        private SolutionGlobal()
        {
            foreach (var item in Assembly.GetExecutingAssembly().GetTypes())
            {
                if (!item.IsAbstract && typeof(IProjectFile).IsAssignableFrom(item)&&item.IsClass)
                {
                    string[] SupportExtensions = ((IProjectFile)Activator.CreateInstance(item, "11")).SupportExtensions();

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
                if (item.Key.Contains(Extension))
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
