using Global.Common;
using System.Collections.Generic;
using System.Windows;

namespace XSolution.SeriesProject
{
    public class SeriesProjectMeta:ViewModelBase
    {
        /// <summary>
        /// Points的List
        /// </summary>
        public Dictionary<Point, List<GrifFile>> DicPoints = new Dictionary<Point, List<GrifFile>>();

        /// <summary>
        /// Z的Dic
        /// </summary>
        public Dictionary<int, List<GrifFile>> DicZ = new Dictionary<int, List<GrifFile>>();

        /// <summary>
        /// peratingMode 的Dic
        /// </summary>
        public Dictionary<GrifFileOperatingMode, List<GrifFile>> DicOM = new Dictionary<GrifFileOperatingMode, List<GrifFile>>();


  }
}
