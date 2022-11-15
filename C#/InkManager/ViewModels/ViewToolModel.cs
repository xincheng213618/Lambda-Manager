using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace InkManager.ViewModels
{
    public class ViewToolModel:INotifyPropertyChanged
    {
        public ViewToolModel()
        {
         
        
        }
        private TopTool _topTool = new TopTool();


        public TopTool topTool
        {
            get { return _topTool; }
            set { _topTool = value; NotifyPropertyChanged(nameof(topTool)); }

        } 

        public class TopTool
        {
            private bool selectChecked = false;
         
            public bool SelectChecked
            {
                get { return selectChecked; }
                set { selectChecked = value; NotifyPropertyChanged(nameof(SelectChecked)); }
            }

            private bool inlineChecked = false;
       
            public bool InlineChecked
            {
                get { return inlineChecked; }
                set { inlineChecked = value; NotifyPropertyChanged(nameof(InlineChecked)); }
            }


            private bool moveChecked = false;
      
            public bool MoveChecked
            {
                get { return moveChecked; }
                set { moveChecked = value; NotifyPropertyChanged(nameof(MoveChecked)); }
            }

            private bool searchChecked = false;
    
            public bool SearchChecked
            {
                get { return searchChecked; }
                set { searchChecked = value; NotifyPropertyChanged(nameof(SearchChecked)); }
            }

            private bool zoomOutChecked = false;
     
            public bool ZoomOutChecked
            {
                get { return zoomOutChecked; }
                set { zoomOutChecked = value; NotifyPropertyChanged(nameof(ZoomOutChecked)); }
            }

            private bool zoomInChecked = false;

            public bool ZoomInChecked
            {
                get { return zoomInChecked; }
                set { zoomInChecked = value; NotifyPropertyChanged(nameof(ZoomInChecked)); }
            }

            private bool scaleChecked = false;

            public bool ScaleChecked
            {
                get { return scaleChecked; }
                set { scaleChecked = value; NotifyPropertyChanged(nameof(ScaleChecked)); }
            }


            private bool dimensionChecked = false;
 
            public bool DimensionChecked
            {
                get { return dimensionChecked; }
                set { dimensionChecked = value; NotifyPropertyChanged(nameof(DimensionChecked)); }
            }

            private bool focusChecked = false;

            public bool FocusChecked
            {
                get { return focusChecked; }
                set { focusChecked = value; NotifyPropertyChanged(nameof(FocusChecked)); }
            }

            private bool rulerChecked = false;

            public bool RulerChecked
            {
                get { return rulerChecked; }
                set { rulerChecked = value; NotifyPropertyChanged(nameof(RulerChecked)); }
            }

            private bool profileChecked = false;

            public bool ProfileChecked
            {
                get { return profileChecked; }
                set { profileChecked = value; NotifyPropertyChanged(nameof(ProfileChecked)); }
            }
            public int ratio = 100;
            public int Ratio
            {
                get { return ratio; }
                set
                {
                    ratio = value; NotifyPropertyChanged(nameof(Ratio));
                }
            }


            private bool eraserChecked = false;


            public bool EraserChecked
            {
                get { return eraserChecked; }
                set { eraserChecked = value; NotifyPropertyChanged(nameof(EraserChecked)); }
            }

            private bool textChecked = false;

            public bool TextChecked
            {
                get { return textChecked; }
                set { textChecked = value; NotifyPropertyChanged(nameof(TextChecked)); }
            }

            //private object arrow = null;
            //[JsonPropertyName("arrow")]
            //public object Arrow
            //{
            //    get { return arrow; }
            //    set { arrow = value; NotifyPropertyChanged(nameof(Arrow)); }
            //}

            private bool lineChecked = false;
            public bool LineChecked
            {
                get { return lineChecked; }
                set { lineChecked = value; NotifyPropertyChanged(nameof(LineChecked)); }
            }

            private bool curveChecked = false;
            public bool CurveChecked
            {
                get { return curveChecked; }
                set { curveChecked = value; NotifyPropertyChanged(nameof(CurveChecked)); }
            }

            private bool  circleChecked = false;
            public bool CircleChecked
            {
                get { return circleChecked; }
                set { circleChecked = value; NotifyPropertyChanged(nameof(CircleChecked)); }
            }

            private bool rectangleChecked = false;
            public bool RectangleChecked
            {
                get { return rectangleChecked; }
                set { rectangleChecked = value; NotifyPropertyChanged(nameof(RectangleChecked)); }
            }
            private bool polygonChecked = false;
            public bool PolygonChecked
            {
                get { return polygonChecked; }
                set { polygonChecked = value; NotifyPropertyChanged(nameof(PolygonChecked)); }
            }


            #region INotifyPropertyChanged Members
            public event PropertyChangedEventHandler? PropertyChanged;
            //public event PropertyChangedEventHandler PropertyChanged;

            #endregion


            private void NotifyPropertyChanged(string propertyName)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                }
            }


        }

        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler? PropertyChanged;
        //public event PropertyChangedEventHandler PropertyChanged;

        #endregion


        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }






    }
}
