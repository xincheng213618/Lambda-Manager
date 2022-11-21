﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Global.UserControls.DrawVisual
{
    public class VisualAttritube
    {
        public string Type { get; set; }
        public int LineWidth { get; set; }
        public int LineType { get; set; }
        public Color Color { get; set; }

        public Point Point1 { get; set; }
        public Point Point2 { get; set; }
        public Point Point3 { get; set; }
        public Point Point4 { get; set; }
        public int ActiveWin { get; set; }  

        public double ratio { get; set; }
        public double acWidth { get; set; }
        public double acHeight { get; set; }
    }

    public class LineVisual : VisualAttritube

    {

        //public Point Point1 { get; set; }
        //public Point Point2 { get; set; }

    }

    public class EllipseVisual : VisualAttritube

    {

        //public Point Point3 { get; set; }
        //public Point Point4 { get; set; }

    }


    public class DrawingVisual

    {

        private LineVisual lineVisual = new LineVisual();
        public LineVisual LineVis

        {
            get { return lineVisual; }
            set
            {
                if (lineVisual != value)
                {
                    lineVisual = value;

                }
            }
        }

        private EllipseVisual ellipse = new EllipseVisual();
        public EllipseVisual EllipseVis

        {
            get { return ellipse; }
            set
            {
                if (ellipse != value)
                {
                    ellipse = value;

                }
            }
        }

    }











}
