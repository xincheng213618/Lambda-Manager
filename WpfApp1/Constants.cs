using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public static class Constants
    {
        public static class ImageRes
        {
            // See imageres.dll for more icon indexes to add
            public const int QuickAccess = 1024;

            public const int Desktop = 183;
            public const int Downloads = 184;
            public const int Documents = 112;
            public const int Pictures = 113;
            public const int Music = 108;
            public const int Videos = 189;
            public const int GenericDiskDrive = 35;
            public const int WindowsDrive = 36;
            public const int ThisPC = 109;
            public const int NetworkDrives = 25;
            public const int RecycleBin = 55;
            public const int CloudDrives = 1040;
            public const int OneDrive = 1043;
            public const int Libraries = 1023;
            public const int Folder = 3;
        }

        public static class Shell32
        {
            // See shell32.dll for more icon indexes to add
            public const int QuickAccess = 51380;
        }
        public static class CommonPaths
        {
            public const string RecycleBinPath = @"Shell:RecycleBinFolder";

            public const string NetworkFolderPath = @"Shell:NetworkPlacesFolder";

            public const string MyComputerPath = @"Shell:MyComputerFolder";
        }
    }
}
