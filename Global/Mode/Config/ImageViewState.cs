using Global.Common;
using Newtonsoft.Json;

namespace Global.Mode.Config
{
    public class ImageViewState : ViewModeBase
    {
        public void SetValue(ImageViewState imageViewState)
        {
            toolLeft.SetValue(imageViewState.toolLeft);
            toolTop.SetValue(imageViewState.toolTop);
            toolRight.SetValue(imageViewState.toolRight); 
            toolBottom.SetValue(imageViewState.toolBottom);
        }


        public ToolLeft toolLeft = new ToolLeft();
        public ToolTop toolTop = new ToolTop();
        public ToolRight toolRight = new ToolRight();
        public ToolBottom toolBottom = new ToolBottom();




        /// <summary>
        /// 左侧工具栏状态
        /// </summary>
        public class ToolLeft : ViewModeBase
        {
            public void SetValue(ToolLeft toolLeft)
            {
                this.Colorbar = toolLeft.AntiPhase;
                this.AntiPhase = toolLeft.AntiPhase;
                this.Divider = toolLeft.AntiPhase;
                this.Histogram = toolLeft.Histogram;
                this.ColorMap = toolLeft.AntiPhase;

            }


            private object colorbar = null;
            [JsonProperty("color-bar")]
            public object Colorbar
            {
                get { return colorbar; }
                set { colorbar = value; NotifyPropertyChanged(); }
            }

            private object divider = null;
            [JsonProperty("divider")]
            public object Divider
            {
                get { return divider; }
                set { divider = value; NotifyPropertyChanged(); }
            }

            private object antiPhase = null;
            [JsonProperty("anti-phase")]
            public object AntiPhase
            {
                get { return antiPhase; }
                set { antiPhase = value; NotifyPropertyChanged(); }
            }

            private object histogram = null;
            [JsonProperty("histogram")]
            public object Histogram
            {
                get { return histogram; }
                set { histogram = value; NotifyPropertyChanged(); }
            }


            private object colorMap = null;
            [JsonProperty("color-map")]
            public object ColorMap
            {
                get { return colorMap; }
                set { colorMap = value; NotifyPropertyChanged(); }
            }
           
        }


        /// <summary>
        /// 顶部工具栏状态
        /// </summary>
        public class ToolTop : ViewModeBase
        {
            public void SetValue(ToolTop toolTop)
            {
                this.PointerChecked = toolTop.PointerChecked;
                this.MoveChecked = toolTop.MoveChecked;
                this.DimensionChecked = toolTop.DimensionChecked;
                this.FocusChecked = toolTop.FocusChecked;
                this.RulerChecked = toolTop.RulerChecked;
                this.TextChecked = toolTop.TextChecked;
                this.ArrowChecked = toolTop.ArrowChecked;
                this.LineChecked = toolTop.LineChecked;
                this.CurveChecked= toolTop.CurveChecked;    
                this.RectangleChecked= toolTop.RectangleChecked;
                this.PolygonChecked   = toolTop.PolygonChecked; 
                this.Selection   =toolTop.Selection;
                this.Move = toolTop.Move;   
                this.Scale = toolTop.Scale; 
                this.Dimension = toolTop.Dimension; 
                this.Text = toolTop.Text;
                this.Arrow    = toolTop.Arrow;
                this.Line = toolTop.Line;
                this.Curve = toolTop.Curve;
                this.Rectangle = toolTop.Rectangle;
                this.Polygon = toolTop.Polygon; 
            }

            private bool pointerChecked = false;
            [JsonProperty("pointer-checked")]
            public bool PointerChecked
            {
                get { return pointerChecked; }
                set { pointerChecked = value; NotifyPropertyChanged(); }
            }

            private bool moveChecked = false;
            [JsonProperty("move-checked")]
            public bool MoveChecked
            {
                get { return moveChecked; }
                set { moveChecked = value; NotifyPropertyChanged(); }
            }

            private bool dimensionChecked = false;
            [JsonProperty("dimension-checked")]
            public bool DimensionChecked
            {
                get { return dimensionChecked; }
                set { dimensionChecked = value; NotifyPropertyChanged(); }
            }

            private bool focusChecked = false;
            [JsonProperty("focus-checked")]
            public bool FocusChecked
            {
                get { return focusChecked; }
                set { focusChecked = value; NotifyPropertyChanged(); }
            }


            private bool rulerChecked = false;
            [JsonProperty("ruler-checked")]
            public bool RulerChecked
            {
                get { return rulerChecked; }
                set { rulerChecked = value; NotifyPropertyChanged(); }
            }

            private bool textChecked = false;
            [JsonProperty("text-checked")]
            public bool TextChecked
            {
                get { return textChecked; }
                set { textChecked = value; NotifyPropertyChanged(); }
            }

            private bool arrowChecked = false;
            [JsonProperty("arrow-checked")]
            public bool ArrowChecked
            {
                get { return arrowChecked; }
                set { arrowChecked = value; NotifyPropertyChanged(); }
            }

            private bool lineChecked = false;
            [JsonProperty("line-checked")]
            public bool LineChecked
            {
                get { return lineChecked; }
                set { lineChecked = value; NotifyPropertyChanged(); }
            }

            private bool curveChecked = false;
            [JsonProperty("curve-checked")]
            public bool CurveChecked
            {
                get { return curveChecked; }
                set { curveChecked = value; NotifyPropertyChanged(); }
            }

            private bool circleChecked = false;
            [JsonProperty("circle-checked")]
            public bool CircleChecked
            {
                get { return circleChecked; }
                set { circleChecked = value; NotifyPropertyChanged(); }
            }

            private bool rectangleChecked = false;
            [JsonProperty("rectangle-checked")]
            public bool RectangleChecked
            {
                get { return rectangleChecked; }
                set { rectangleChecked = value; NotifyPropertyChanged(); }
            }

            private bool polygonChecked = false;
            [JsonProperty("polygon-checked")]
            public bool PolygonChecked
            {
                get { return polygonChecked; }
                set { polygonChecked = value; NotifyPropertyChanged(); }
            }


            private object selection = false;
            /// <summary>
            /// 所有选择区域
            /// </summary>
            [JsonProperty("selection")]
            public object Selection
            {
                get { return selection; }
                set { selection = value; NotifyPropertyChanged(); }
            }

            private object move = false;
            /// <summary>
            /// 坐标偏移
            /// </summary>
            [JsonProperty("move")]
            public object Move
            {
                get { return move; }
                set { move = value; NotifyPropertyChanged(); }
            }

            private double scale = 1;
            /// <summary>
            /// 缩放比例
            /// </summary>
            [JsonProperty("scale")]
            public double Scale
            {
                get { return scale; }
                set { scale = value; NotifyPropertyChanged(); }
            }


            private object dimension = 1;
            /// <summary>
            /// 标尺信息
            /// </summary>
            [JsonProperty("dimension")]
            public object Dimension
            {
                get { return dimension; }
                set { dimension = value; NotifyPropertyChanged(); }
            }

            private object text = null;
            [JsonProperty("text")]
            public object Text
            {
                get { return text; }
                set { text = value; NotifyPropertyChanged(); }
            }

            private object arrow = null;
            [JsonProperty("arrow")]
            public object Arrow
            {
                get { return arrow; }
                set { arrow = value; NotifyPropertyChanged(); }
            }

            private object line = null;
            [JsonProperty("line")]
            public object Line
            {
                get { return line; }
                set { line = value; NotifyPropertyChanged(); }
            }

            private object curve = null;
            [JsonProperty("curve")]
            public object Curve
            {
                get { return curve; }
                set { curve = value; NotifyPropertyChanged(); }
            }

            private object circle = null;
            [JsonProperty("circle")]
            public object Circle
            {
                get { return circle; }
                set { circle = value; NotifyPropertyChanged(); }
            }

            private object rectangle = null;
            [JsonProperty("rectangle")]
            public object Rectangle
            {
                get { return rectangle; }
                set { rectangle = value; NotifyPropertyChanged(); }
            }

            private object polygon = null;
            [JsonProperty("polygon")]
            public object Polygon
            {
                get { return polygon; }
                set { polygon = value; NotifyPropertyChanged(); }
            }








        }



        /// <summary>
        /// 右侧工具栏状态
        /// </summary>
        public class ToolRight : ViewModeBase
        {
            public void SetValue(ToolRight toolRight)
            {
                this.QuaterChecked = toolRight.QuaterChecked;
            }


            private bool quaterChecked = false;
            [JsonProperty("quater-checked")]
            public bool QuaterChecked
            {
                get { return quaterChecked; }
                set { quaterChecked = value; NotifyPropertyChanged(); }
            }

            private bool dualChecked = false;
            [JsonProperty("dual-checked")]
            public bool DualChecked
            {
                get { return dualChecked; }
                set { dualChecked = value; NotifyPropertyChanged(); }
            }

            private bool bfChecked = false;
            [JsonProperty("bf-checked")]
            public bool CfChecked
            {
                get { return bfChecked; }
                set { bfChecked = value; NotifyPropertyChanged(); }
            }

            private bool dfChecked = false;
            [JsonProperty("df-checked")]
            public bool DfChecked
            {
                get { return dfChecked; }
                set { dfChecked = value; NotifyPropertyChanged(); }
            }


            private bool riChecked = false;
            [JsonProperty("ri-checked")]
            public bool RiChecked
            {
                get { return riChecked; }
                set { riChecked = value; NotifyPropertyChanged(); }
            }

            private bool dpChecked = false;
            [JsonProperty("dp-checked")]
            public bool DpChecked
            {
                get { return dpChecked; }
                set { dpChecked = value; NotifyPropertyChanged(); }
            }

            private bool phiChecked = false;
            [JsonProperty("phi-checked")]
            public bool PhiChecked
            {
                get { return phiChecked; }
                set { phiChecked = value; NotifyPropertyChanged(); }
            }

            private bool flChecked = false;
            [JsonProperty("fl-checked")]
            public bool FlChecked
            {
                get { return flChecked; }
                set { flChecked = value; NotifyPropertyChanged(); }
            }

            private bool d3checked = false;
            [JsonProperty("3d-checked")]
            public bool D3checked
            {
                get { return d3checked; }
                set { d3checked = value; NotifyPropertyChanged(); }
            }


            private bool cubeChecked = false;
            [JsonProperty("cube-checked")]
            public bool CubeChecked
            {
                get { return cubeChecked; }
                set { cubeChecked = value; NotifyPropertyChanged(); }
            }

            private bool repoChecked = false;
            [JsonProperty("repo-checked")]
            public bool RepoChecked
            {
                get { return repoChecked; }
                set { repoChecked = value; NotifyPropertyChanged(); }
            }

            private string quater = "";
            [JsonProperty("quater")]
            public string Quater
            {
                get { return quater; }
                set { quater = value; NotifyPropertyChanged(); }
            }

            private string dual = "";
            [JsonProperty("dual")]
            public string Dual
            {
                get { return dual; }
                set { dual = value; NotifyPropertyChanged(); }
            }

            private object cube = null;
            [JsonProperty("cube")]
            public object Cube
            {
                get { return cube; }
                set { cube = value; NotifyPropertyChanged(); }
            }

            private object d3 = null;
            [JsonProperty("3d")]
            public object D3
            {
                get { return d3; }
                set { d3 = value; NotifyPropertyChanged(); }
            }
        }

        /// <summary>
        /// 底部工具栏
        /// </summary>
        public class ToolBottom : ViewModeBase
        {
            public void SetValue(ToolBottom toolBottom)
            {
                this.TFps = toolBottom.TFps;
            }

            private object tFps = null;
            [JsonProperty("t-fps")]
            public object TFps
            {
                get { return tFps; }
                set { tFps = value; NotifyPropertyChanged(); }
            }
        }





    }
}
