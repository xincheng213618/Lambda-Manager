using Global.Common;
using System.Collections.Generic;
using System.Windows;

namespace XSolution.SeriesProject
{
    public class SeriesProjectMeta:ViewModelBase
    {

        public Dictionary<Point, List<GrifFile>> Points = new Dictionary<Point, List<GrifFile>>();


        public List<int> ZStep { get; set; } = new List<int> { };


  }
}
