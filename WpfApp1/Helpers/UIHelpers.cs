using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Helpers
{
    public class UIHelpers
    {
        //private static async Task<IList<IconFileInfo>> LoadSelectedIconsAsync(string filePath, IList<int> indexes, int iconSize = 48)
        //{
        //    var connection = await AppServiceConnectionHelper.Instance;
        //    if (connection != null)
        //    {
        //        var value = new ValueSet
        //        {
        //            { "Arguments", "GetSelectedIconsFromDLL" },
        //            { "iconFile", filePath },
        //            { "requestedIconSize", iconSize },
        //            { "iconIndexes", JsonConvert.SerializeObject(indexes) }
        //        };
        //        var (status, response) = await connection.SendMessageForResponseAsync(value);
        //        if (status == AppServiceResponseStatus.Success)
        //        {
        //            var icons = JsonConvert.DeserializeObject<IList<IconFileInfo>>((string)response["IconInfos"]);
        //            if (icons != null)
        //            {
        //                foreach (IconFileInfo iFInfo in icons)
        //                {
        //                    iFInfo.IconDataBytes = Convert.FromBase64String(iFInfo.IconData);
        //                }
        //            }

        //            return icons;
        //        }
        //    }
        //    return null;
        ////}

        //private static async Task<IEnumerable<IconFileInfo>> LoadSidebarIconResources()
        //{
        //    const string imageres = @"C:\Windows\System32\imageres.dll";
        //    var imageResList = await UIHelpers.LoadSelectedIconsAsync(imageres, new List<int>() {
        //            Constants.ImageRes.RecycleBin,
        //            Constants.ImageRes.NetworkDrives,
        //            Constants.ImageRes.Libraries,
        //            Constants.ImageRes.ThisPC,
        //            Constants.ImageRes.CloudDrives,
        //            Constants.ImageRes.Folder
        //        }, 32);

        //    const string shell32 = @"C:\Windows\System32\shell32.dll";
        //    var shell32List = await UIHelpers.LoadSelectedIconsAsync(shell32, new List<int>() {
        //            Constants.Shell32.QuickAccess
        //        }, 32);

        //    if (shell32List != null && imageResList != null)
        //    {
        //        return imageResList.Concat(shell32List);
        //    }
        //    else if (shell32List != null && imageResList == null)
        //    {
        //        return shell32List;
        //    }
        //    else if (shell32List == null && imageResList != null)
        //    {
        //        return imageResList;
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}


    }
}
