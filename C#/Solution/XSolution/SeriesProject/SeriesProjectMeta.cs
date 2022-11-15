using Global.Common;
using System.Collections.Generic;
using System.Windows;

namespace XSolution.SeriesProject
{
    public class SeriesProjectMeta:ViewModelBase
    {
        public List<Point> Points { get; set; } = new List<Point>();

        public List<int> ZStep { get; set; } = new List<int> { };


  }
}
