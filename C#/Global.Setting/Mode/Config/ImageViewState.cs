using Global.Common;
using System.Text.Json.Serialization;

namespace Global.Mode.Config
{
    public class ImageViewState : ViewModelBase
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
        public class ToolLeft : ViewModelBase
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
            [JsonPropertyName("color-bar")]
            public object Colorbar
            {
                get { return colorbar; }
                set { colorbar = value; NotifyPropertyChanged(); }
            }

            private object divider = null;
            [JsonPropertyName("divider")]
            public object Divider
            {
                get { return divider; }
                set { divider = value; NotifyPropertyChanged(); }
            }

            private object antiPhase = null;
            [JsonPropertyName("anti-phase")]
            public object AntiPhase
            {
                get { return antiPhase; }
                set { antiPhase = value; NotifyPropertyChanged(); }
            }

            private object histogram = null;
            [JsonPropertyName("histogram")]
            public object Histogram
            {
                get { return histogram; }
                set { histogram = value; NotifyPropertyChanged(); }
            }


            private object colorMap = null;
            [JsonPropertyName("color-map")]
            public object ColorMap
            {
                get { return colorMap; }
                set { colorMap = value; NotifyPropertyChanged(); }
            }
           
        }


        /// <summary>
        /// 顶部工具栏状态
        /// </summary>
        public class ToolTop : ViewModelBase
        {
            public ToolTop()
            {
            }

            public void SetValue(ToolTop toolTop)
            {
                this.SelectChecked = toolTop.SelectChecked;
                this.InlineChecked = toolTop.InlineChecked;
                this.MoveChecked = toolTop.MoveChecked;
                this.SearchChecked = toolTop.SearchChecked;
                this.ZoomOutChecked = toolTop.ZoomOutChecked;
                this.ZoomInChecked = toolTop.ZoomInChecked;
                this.ScaleChecked = toolTop.ScaleChecked;
                this.DimensionChecked = toolTop.DimensionChecked;
                this.FocusChecked = toolTop.FocusChecked;
                this.RulerChecked = toolTop.RulerChecked;
                this.ProfileChecked = toolTop.ProfileChecked;
                this.EraserChecked = toolTop.EraserChecked;
                this.TextChecked = toolTop.TextChecked;
                this.ArrowChecked = toolTop.ArrowChecked;
                this.LineChecked = toolTop.LineChecked;
                this.CircleChecked = toolTop.CircleChecked;
                this.CurveChecked = toolTop.CurveChecked;
                this.RectangleChecked = toolTop.RectangleChecked;
                this.PolygonChecked = toolTop.PolygonChecked;
               
                this.Select = toolTop.Select;
                this.inline = toolTop.inline;
                this.Move = toolTop.Move;
                this.search = toolTop.search;
                this.zoomOut = toolTop.zoomOut;
                this.ZoomIn = toolTop.ZoomIn;
                this.Scale = toolTop.Scale;
                this.Dimension = toolTop.Dimension;
                this.Focus = toolTop.Focus;
                this.Profile = toolTop.Profile;
                this.Ruler = toolTop.Ruler;
                this.Eraser= toolTop.Eraser;
                this.Text = toolTop.Text;
                this.Arrow = toolTop.Arrow;
                this.Line = toolTop.Line;
                this.Curve = toolTop.Curve;
                this.Circle = toolTop.Circle;
                this.Rectangle = toolTop.Rectangle;
                this.Polygon = toolTop.Polygon;
            }

            private bool selectChecked = false;
            [JsonPropertyName("select-checked")]
            public bool SelectChecked
            {
                get { return selectChecked; }
                set { selectChecked = value; NotifyPropertyChanged(); }
            }

            private bool inlineChecked = false;
            [JsonPropertyName("inline-checked")]
            public bool InlineChecked
            {
                get { return inlineChecked; }
                set { inlineChecked = value; NotifyPropertyChanged(); }
            }


            private bool moveChecked = true;
            [JsonPropertyName("move-checked")]
            public bool MoveChecked
            {
                get { return moveChecked; }
                set { moveChecked = value; NotifyPropertyChanged(); }
            }

            private bool searchChecked = false;
            [JsonPropertyName("search-checked")]
            public bool SearchChecked
            {
                get { return searchChecked; }
                set { searchChecked = value; NotifyPropertyChanged(); }
            }

            private bool zoomOutChecked = false;
            [JsonPropertyName("zoomOut-checked")]
            public bool ZoomOutChecked
            {
                get { return zoomOutChecked; }
                set { zoomOutChecked = value; NotifyPropertyChanged(); }
            }

            private bool zoomInChecked = false;
            [JsonPropertyName("zoomIn-checked")]
            public bool ZoomInChecked
            {
                get { return zoomInChecked; }
                set { zoomInChecked = value; NotifyPropertyChanged(); }
            }

            private bool scaleChecked = false;
            [JsonPropertyName("scale-checked")]
            public bool ScaleChecked
            {
                get { return scaleChecked; }
                set { scaleChecked = value; NotifyPropertyChanged(); }
            }


            private bool dimensionChecked = false;
            [JsonPropertyName("dimension-checked")]
            public bool DimensionChecked
            {
                get { return dimensionChecked; }
                set { dimensionChecked = value; NotifyPropertyChanged(); }
            }

            private bool focusChecked = false;
            [JsonPropertyName("focus-checked")]
            public bool FocusChecked
            {
                get { return focusChecked; }
                set { focusChecked = value; NotifyPropertyChanged(); }
            }

            private bool rulerChecked = false;
            [JsonPropertyName("ruler-checked")]
            public bool RulerChecked
            {
                get { return rulerChecked; }
                set { rulerChecked = value; NotifyPropertyChanged(); }
            }

            private bool profileChecked = false;
            [JsonPropertyName("profile-Checked")]
            public bool ProfileChecked
            {
                get { return profileChecked; }
                set { profileChecked = value; NotifyPropertyChanged(); }
            }





            private bool eraserChecked = false;
            [JsonPropertyName("eraser-checked")]
            public bool EraserChecked
            {
                get { return eraserChecked; }
                set
                {
                    eraserChecked = value;
                    NotifyPropertyChanged();
                }
            }

            private bool textChecked = false;
            [JsonPropertyName("text-checked")]
            public bool TextChecked
            {
                get { return textChecked; }
                set { textChecked = value; NotifyPropertyChanged(); }
            }

            private bool arrowChecked = false;
            [JsonPropertyName("arrow-checked")]
            public bool ArrowChecked
            {
                get { return arrowChecked; }
                set { arrowChecked = value; NotifyPropertyChanged(); }
            }

            private bool lineChecked = false;
            [JsonPropertyName("line-checked")]
            public bool LineChecked
            {
                get { return lineChecked; }
                set { lineChecked = value; NotifyPropertyChanged(); }
            }

            private bool curveChecked = false;
            [JsonPropertyName("curve-checked")]
            public bool CurveChecked
            {
                get { return curveChecked; }
                set { curveChecked = value; NotifyPropertyChanged(); }
            }

            private bool circleChecked = false;
            [JsonPropertyName("circle-checked")]
            public bool CircleChecked
            {
                get { return circleChecked; }
                set { circleChecked = value; NotifyPropertyChanged(); }
            }

            private bool rectangleChecked = false;
            [JsonPropertyName("rectangle-checked")]
            public bool RectangleChecked
            {
                get { return rectangleChecked; }
                set { rectangleChecked = value; NotifyPropertyChanged(); }
            }

            private bool polygonChecked = false;
            [JsonPropertyName("polygon-checked")]
            public bool PolygonChecked
            {
                get { return polygonChecked; }
                set { polygonChecked = value; NotifyPropertyChanged(); }
            }
            private bool inkSelected = false;
           
            public bool InkSelected
            {
                get { return inkSelected; }
                set { inkSelected = value; NotifyPropertyChanged(); }
            }

            private bool inkAllSelected = false;

            public bool InkAllSelected
            {
                get { return inkAllSelected; }
                set { inkAllSelected = value; NotifyPropertyChanged(); }
            }





            private object select = false;
            /// <summary>
            /// 所有选择区域
            /// </summary>
            [JsonPropertyName("select")]
            public object Select
            {
                get { return select; }
                set { select = value; NotifyPropertyChanged(); }
            }
            private object inline = false;
            /// <summary>
            /// 
            /// </summary>
            [JsonPropertyName("inline")]
            public object Inline
            {
                get { return inline; }
                set { inline = value; NotifyPropertyChanged(); }
            }





            private object move = false;
            /// <summary>
            /// 坐标偏移
            /// </summary>
            [JsonPropertyName("move")]
            public object Move
            {
                get { return move; }
                set { move = value; NotifyPropertyChanged(); }
            }



            private object search = false;
            /// <summary>
            /// 检索
            /// </summary>
            [JsonPropertyName("search")]
            public object Search
            {
                get { return search; }
                set { search = value; NotifyPropertyChanged(); }
            }

            private object zoomOut = false;
            /// <summary>
            /// 放大
            /// </summary>
            [JsonPropertyName("zoomOut")]
            public object ZoomOut
            {
                get { return zoomOut; }
                set { zoomOut = value; NotifyPropertyChanged(); }
            }
            private object zoomIn = false;
            /// <summary>
            /// 缩小
            /// </summary>
            [JsonPropertyName("zoomIn")]
            public object ZoomIn
            {
                get { return zoomIn; }
                set { zoomIn = value; NotifyPropertyChanged(); }
            }

            private double scale = 1;
            /// <summary>
            /// 缩放比例
            /// </summary>
            [JsonPropertyName("scale")]
            public double Scale
            {
                get { return scale; }
                set { scale = value; NotifyPropertyChanged(); }
            }


            private object dimension = 1;
            /// <summary>
            /// 标尺信息
            /// </summary>
            [JsonPropertyName("dimension")]
            public object Dimension
            {
                get { return dimension; }
                set { dimension = value; NotifyPropertyChanged(); }
            }

            private bool focus =false;
            /// <summary>
            /// 
            /// </summary>
            [JsonPropertyName("focus")]
            public bool Focus
            {
                get { return focus; }
                set { focus = value; NotifyPropertyChanged(); }
            }
            private bool ruler = false;
            /// <summary>
            /// 
            /// </summary>
            [JsonPropertyName("ruler")]
            public bool Ruler
            {
                get { return ruler; }
                set { ruler = value; NotifyPropertyChanged(); }
            }

            private bool profile = false;
            [JsonPropertyName("profile")]
            public bool Profile
            {
                get { return profile; }
                set { profile = value; NotifyPropertyChanged(); }
            }






            private bool eraser = false;
            /// <summary>
            /// 
            /// </summary>
            [JsonPropertyName("eraser")]
            public bool Eraser
            {
                get { return eraser; }
                set { eraser = value; NotifyPropertyChanged(); }
            }



            private object text = null;
            [JsonPropertyName("text")]
            public object Text
            {
                get { return text; }
                set { text = value; NotifyPropertyChanged(); }
            }

            private object arrow = null;
            [JsonPropertyName("arrow")]
            public object Arrow
            {
                get { return arrow; }
                set { arrow = value; NotifyPropertyChanged(); }
            }

            private object line = null;
            [JsonPropertyName("line")]
            public object Line
            {
                get { return line; }
                set { line = value; NotifyPropertyChanged(); }
            }

            private object curve = null;
            [JsonPropertyName("curve")]
            public object Curve
            {
                get { return curve; }
                set { curve = value; NotifyPropertyChanged(); }
            }

            private object circle = null;
            [JsonPropertyName("circle")]
            public object Circle
            {
                get { return circle; }
                set { circle = value; NotifyPropertyChanged(); }
            }

            private object rectangle = null;
            [JsonPropertyName("rectangle")]
            public object Rectangle
            {
                get { return rectangle; }
                set { rectangle = value; NotifyPropertyChanged(); }
            }

            private object polygon = null;
            [JsonPropertyName("polygon")]
            public object Polygon
            {
                get { return polygon; }
                set { polygon = value; NotifyPropertyChanged(); }
            }
           

        }



        /// <summary>
        /// 右侧工具栏状态
        /// </summary>
        public class ToolRight : ViewModelBase
        {
            public void SetValue(ToolRight toolRight)
            {
                this.QuaterChecked = toolRight.QuaterChecked;
            }


            private bool quaterChecked = false;
            [JsonPropertyName("quater-checked")]
            public bool QuaterChecked
            {
                get { return quaterChecked; }
                set { quaterChecked = value; NotifyPropertyChanged(); }
            }

            private bool dualChecked = false;
            [JsonPropertyName("dual-checked")]
            public bool DualChecked
            {
                get { return dualChecked; }
                set { dualChecked = value; NotifyPropertyChanged(); }
            }

            private bool bfChecked = false;
            [JsonPropertyName("bf-checked")]
            public bool CfChecked
            {
                get { return bfChecked; }
                set { bfChecked = value; NotifyPropertyChanged(); }
            }

            private bool dfChecked = false;
            [JsonPropertyName("df-checked")]
            public bool DfChecked
            {
                get { return dfChecked; }
                set { dfChecked = value; NotifyPropertyChanged(); }
            }


            private bool riChecked = false;
            [JsonPropertyName("ri-checked")]
            public bool RiChecked
            {
                get { return riChecked; }
                set { riChecked = value; NotifyPropertyChanged(); }
            }

            private bool dpChecked = false;
            [JsonPropertyName("dp-checked")]
            public bool DpChecked
            {
                get { return dpChecked; }
                set { dpChecked = value; NotifyPropertyChanged(); }
            }

            private bool phiChecked = false;
            [JsonPropertyName("phi-checked")]
            public bool PhiChecked
            {
                get { return phiChecked; }
                set { phiChecked = value; NotifyPropertyChanged(); }
            }

            private bool flChecked = false;
            [JsonPropertyName("fl-checked")]
            public bool FlChecked
            {
                get { return flChecked; }
                set { flChecked = value; NotifyPropertyChanged(); }
            }

            private bool d3checked = false;
            [JsonPropertyName("3d-checked")]
            public bool D3checked
            {
                get { return d3checked; }
                set { d3checked = value; NotifyPropertyChanged(); }
            }


            private bool cubeChecked = false;
            [JsonPropertyName("cube-checked")]
            public bool CubeChecked
            {
                get { return cubeChecked; }
                set { cubeChecked = value; NotifyPropertyChanged(); }
            }

            private bool repoChecked = false;
            [JsonPropertyName("repo-checked")]
            public bool RepoChecked
            {
                get { return repoChecked; }
                set { repoChecked = value; NotifyPropertyChanged(); }
            }

            private string quater = "";
            [JsonPropertyName("quater")]
            public string Quater
            {
                get { return quater; }
                set { quater = value; NotifyPropertyChanged(); }
            }

            private string dual = "";
            [JsonPropertyName("dual")]
            public string Dual
            {
                get { return dual; }
                set { dual = value; NotifyPropertyChanged(); }
            }

            private object cube = null;
            [JsonPropertyName("cube")]
            public object Cube
            {
                get { return cube; }
                set { cube = value; NotifyPropertyChanged(); }
            }

            private object d3 = null;
            [JsonPropertyName("3d")]
            public object D3
            {
                get { return d3; }
                set { d3 = value; NotifyPropertyChanged(); }
            }
        }

        /// <summary>
        /// 底部工具栏
        /// </summary>
        public class ToolBottom : ViewModelBase
        {
            public void SetValue(ToolBottom toolBottom)
            {
                this.TFps = toolBottom.TFps;
            }

            private object tFps = null;
            [JsonPropertyName("t-fps")]
            public object TFps
            {
                get { return tFps; }
                set { tFps = value; NotifyPropertyChanged(); }
            }
        }





    }
}
