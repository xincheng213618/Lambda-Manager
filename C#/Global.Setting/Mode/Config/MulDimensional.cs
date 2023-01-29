
using Global.Common;
using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Text.Json.Serialization;
using System.Collections.ObjectModel;
using System.Linq;

namespace Global.Mode.Config
{
    public class FocusImageMode
    {
        public int Index { get; set; }
        public string mode { get; set; }
    }
    [Serializable]
    public class MulDimensional: ViewModelBase
    {
        public void Set(MulDimensional mulDimensional)
        {
            ZEnable = mulDimensional.ZEnable;
            ZStart = mulDimensional.ZStart;
            ZEnd = mulDimensional.ZEnd;
            Zstep=mulDimensional.Zstep;
            ZAbsolute=mulDimensional.ZAbsolute;
            TEnable = mulDimensional.TEnable;
           
        }
       
        public List<MulDimensionalArea> mulDimensionalAreas { get; set; } = new List<MulDimensionalArea> { };
        public List<MulDimensionalPoint> mulDimensionalPoints { get; set; } = new List<MulDimensionalPoint> { };
       
        public List<string> TIntervalUnitsList { get; set; } = new List<string> {"秒","分钟","小时","天"};
        public List<string> ZWiseFocusItems { get; set; } = new List<string> {"不聚焦", "每次循环聚焦一次" };


        private FocusImageModeS focusImageModeS = new FocusImageModeS();
        public FocusImageModeS FocusImageMod 
        {
            get { return focusImageModeS; }
            set
            {
                focusImageModeS = value;
                NotifyPropertyChanged();
            }
        }



        public class FocusImageModeS:ViewModelBase
        {
            private bool bright = false;
            private bool dark = false;
            private bool rheinberg = false;
            private bool relief = false;
            private bool quantitative = false;
            private bool phase = false;
            private FocusImageMode brightMode = new FocusImageMode() { Index = 0, mode = "明场" };
            private FocusImageMode darkMode = new FocusImageMode() { Index = 1, mode = "暗场" };
            private FocusImageMode rheinbergMode = new FocusImageMode() { Index = 2, mode = "莱茵" };
            private FocusImageMode reliefMode = new FocusImageMode() { Index = 3, mode = "差分" };
            private FocusImageMode quantitativeMode = new FocusImageMode() { Index = 4, mode = "相差" };
            private FocusImageMode phaseMode = new FocusImageMode() { Index = 5, mode = "相位" };

            public ObservableCollection<FocusImageMode> ModeList { get; set; } = new ObservableCollection<FocusImageMode>() { };
            public ObservableCollection<FocusImageMode> ModeList1 { get; set; } = new ObservableCollection<FocusImageMode>() { };
            private FocusImageMode focusImageModeSel;
            private int modeSelectedIndex = 0;
            private bool modeSelecteShow = false;
           
            public bool ModeSelecteShow
            {
                get { return modeSelecteShow; }
                set
                {
                    modeSelecteShow = value;
                    NotifyPropertyChanged();
                }
            }
            public FocusImageMode FocusImageModeSel
            {
                get { return focusImageModeSel; }
                set
                {
                    focusImageModeSel = value;
                    NotifyPropertyChanged();
                }
            }



            public int ModeSelectedIndex
            {
                get { return modeSelectedIndex; }
                set
                {
                    modeSelectedIndex = value;
                    NotifyPropertyChanged();
                }

            }
            public bool Bright
            {
                get { return bright; }
                set
                {
                    bright = value;
                    NotifyPropertyChanged();
                    if (value)
                    {
                        if (ModeList.Contains(brightMode) == false)
                        {
                            ModeList.Add(brightMode);
                            ModeList1.Add(brightMode);
                        }
                           

                    }
                    else
                    {
                        if (ModeList.Contains(brightMode))
                        {
                            ModeList.Remove(brightMode);
                            ModeList1.Remove(brightMode);
                        }
                            
                    }
                    CollectionOrder(ModeList);
                }

            }




            public bool Dark
            {
                get { return dark; }
                set
                {
                    dark = value; NotifyPropertyChanged();

                    if (value)
                    {
                        if (ModeList.Contains(darkMode) == false)
                        {
                            ModeList.Add(darkMode);
                            ModeList1.Add(darkMode);
                        }
                            

                    }
                    else
                    {
                        if (ModeList.Contains(darkMode))
                        {
                            ModeList.Remove(darkMode);
                            ModeList1.Remove(darkMode);
                        }
                           

                    }
                    CollectionOrder(ModeList);

                }
            }
            public bool Rheinberg
            {
                get { return rheinberg; }
                set
                {
                    rheinberg = value; NotifyPropertyChanged();
                    if (value)
                    {
                        if (ModeList.Contains(rheinbergMode) == false)
                        {
                            ModeList.Add(rheinbergMode);
                            ModeList1.Add(rheinbergMode);
                        }
                           
                    }
                    else
                    {
                        if (ModeList.Contains(rheinbergMode))
                        {
                            ModeList.Remove(rheinbergMode);
                            ModeList1.Remove(rheinbergMode);
                        }
                           
                    }
                    CollectionOrder(ModeList);
                }
            }
            public bool Relief
            {
                get { return relief; }
                set
                {
                    relief = value; NotifyPropertyChanged();
                    if (value)
                    {
                        if (ModeList.Contains(reliefMode) == false)
                        {
                            ModeList.Add(reliefMode);
                            ModeList1.Add(reliefMode);

                        }
                            

                    }
                    else
                    {
                        if (ModeList.Contains(reliefMode))
                        {
                            ModeList.Remove(reliefMode);
                            ModeList1.Remove(reliefMode);
                        }
                           
                    }
                    CollectionOrder(ModeList);
                }
            }
            public bool Quantitative
            {
                get { return quantitative; }
                set
                {
                    quantitative = value; NotifyPropertyChanged();
                    if (value)
                    {
                        if (ModeList.Contains(quantitativeMode) == false)
                        {
                            ModeList.Add(quantitativeMode);
                            ModeList1.Add(quantitativeMode);
                        }
                            

                    }
                    else
                    {
                        if (ModeList.Contains(quantitativeMode))
                        {
                            ModeList.Remove(quantitativeMode);
                            ModeList1.Remove(quantitativeMode);
                        }
                           
                    }
                    CollectionOrder(ModeList);

                }
            }

            public bool Phase
            {
                get { return phase; }
                set
                {
                    phase = value; NotifyPropertyChanged();

                    if (value)
                    {
                        if (ModeList.Contains(phaseMode) == false)
                        {
                            ModeList.Add(phaseMode);
                            ModeList1.Add(phaseMode);
                        }
                           
                        
                    }
                    else
                    {
                        if (ModeList.Contains(phaseMode))
                        {
                            ModeList.Remove(phaseMode);
                            ModeList1.Remove(phaseMode);
                        }
                           
                    }
                    CollectionOrder(ModeList);

                }
            }
            public ObservableCollection<FocusImageMode> CollectionOrder(ObservableCollection<FocusImageMode> modelist)
            {
                if (modelist == null || modelist.Count == 0)
                {
                    ModeSelecteShow = false;
                    return null;
                }
                else
                {
                    ObservableCollection<FocusImageMode> ModeList1 = new ObservableCollection<FocusImageMode>(ModeList.OrderBy(item => item.Index));
                    modelist.Clear();
                    foreach (var item in ModeList1)
                    {
                        modelist.Add(item);
                    }
                    ModeSelectedIndex = 0;
                    ModeSelecteShow = true;
                    return modelist;
                }


            }


        }


        private MulCollectionMode mulColMode = new MulCollectionMode();
        public MulCollectionMode MulColMode
        {
            get { return mulColMode; }
            set { mulColMode = value; NotifyPropertyChanged(); }
        }



        private string tIntervalUnits = "小时";
        public string TIntervalUnits 
        {
            get { return tIntervalUnits; }
            set { tIntervalUnits = value;
                 NotifyPropertyChanged();
            }
        }
        
       

        private bool optimizedSel=false;
        public bool OptimizedSel
        {
            get { return optimizedSel; }
            set
            {
                optimizedSel = value; NotifyPropertyChanged();
            }
        }

        private bool userDefinedSel = false;
        public bool UserDefinedSel
        {
            get { return userDefinedSel; }
            set
            {
                userDefinedSel = value; NotifyPropertyChanged();
            }
        }


        [JsonPropertyName("Z-Enable")]
        public bool ZEnable { get; set; } = false;

        private int zStart = 16;
        [JsonPropertyName("Z-Start")]
        public int ZStart
        {
            get { return zStart; }
            set
            {
                zStart = value;
                NotifyPropertyChanged();
            }
        }

        private int zEnd = 32;

        [JsonPropertyName("Z-End")]
        public int ZEnd
        {
            get { return zEnd; }
            set 
            { 
                zEnd = value;
                NotifyPropertyChanged();
            }
        }

        private int zstep = 200;
        [JsonPropertyName("Z-step")]
        public int Zstep
        {
            get { return zstep; }
            set
            {
                zstep = value;
                NotifyPropertyChanged();
            }
        }


        private bool zAbsolute = false;

        public bool ZAbsolute
        {
            get { return zAbsolute; }
            set
            { 
                zAbsolute = value;
                NotifyPropertyChanged();
            }
        }

       // private int aFSlices = 7;
       //// [JsonPropertyName("Z-Start")]
       // public int AFSlices
       // {
       //     get { return aFSlices; }
       //     set
       //     {
       //         aFSlices = value;
       //         NotifyPropertyChanged();
       //     }
       // }
       // private int aFSlicesGap = 11;
       // // [JsonPropertyName("Z-Start")]
       // public int AFSlicesGap
       // {
       //     get { return aFSlicesGap; }
       //     set
       //     {
       //         aFSlicesGap = value;
       //         NotifyPropertyChanged();
       //     }
       // }


        //private bool aFEnable = false;
        //public bool AFEnable
        //{
        //    get { return aFEnable; }
        //    set { aFEnable = value; NotifyPropertyChanged();
        //    }
        //}



        private bool tEnable = false;

        public bool TEnable
        {
            get { return tEnable; }
            set { 
                tEnable = value;
                NotifyPropertyChanged();
            }
        }


        public bool TNumberEnable { get; set; } = false;

        private int tNumber = -1;

        [JsonPropertyName("T-Number")]
        public int TNumber
        {
            get { return tNumber ; }
            set { 
                tNumber = value;
                NotifyPropertyChanged();
            }
        }



        public bool TBooleanEnable { get; set; }  
        

        private bool tIntervalEnable = false;
        public bool TIntervalEnable
        {
            get { return tIntervalEnable; }
            set
            {
                tIntervalEnable = value;
                NotifyPropertyChanged();
            }
        }


        private string tInterval = "-1";

        [JsonPropertyName("T-Interva")]
        public string TInterval
        {
            get { return tInterval; }
            set {
                tInterval = value;
                NotifyPropertyChanged();
            }
        }


        private bool focusEnable = true;

        public bool FocusEnable
        {
            get { return focusEnable; }
            set
            {
                focusEnable = value;
                NotifyPropertyChanged();
            }
        }

        private int focusMode  = 0;
        public int FocusMode
        {
            get { return focusMode; }
            set
            {
                focusMode = value;
                NotifyPropertyChanged();
            }
        }

        // FOCUS MODE
        private bool setEnable = false;
        public bool SetEnable
        {
            get { return setEnable; }
            set
            {
                setEnable = value;
                NotifyPropertyChanged();
            }
        }



        // t-wise 

        private bool twiseEnable = true;
        public bool TwiseEnable
        {
            get { return twiseEnable; }
            set
            {
                twiseEnable = value;
                NotifyPropertyChanged();
            }
        }
        private bool tFirst=false;
       public bool TFirst
        {
            get { return tFirst; }
            set
            {
                tFirst = value;
                NotifyPropertyChanged();
            }
        }
        private bool tEvery=false;
        public bool TEvery
        {
            get { return tEvery; }
            set
            {
                tEvery = value;
                NotifyPropertyChanged();
            }
        }
        private bool tN = false;
        public bool TN
        {
            get { return tN; }
            set
            {
                tN = value;
                NotifyPropertyChanged();
            }
        }

        private int tWiseN = 10;
        public int TWiseN
        {
            get { return tWiseN; }
            set
            {
                tWiseN = value;
                NotifyPropertyChanged();
            }
        }

        //p-wise
        private bool pwiseEnable = true;
        public bool PwiseEnable
        {
            get { return pwiseEnable; }
            set
            {
                pwiseEnable = value;
                NotifyPropertyChanged();
            }
        }


        private bool pFirst= false;
        public bool PFirst
        {
            get { return pFirst; }
            set
            {
                pFirst = value;
                NotifyPropertyChanged();
            }
        }
        private bool pEvery = false;
        public bool PEvery
        {
            get { return pEvery; }
            set
            {
                pEvery = value;
                NotifyPropertyChanged();
            }
        }
        private bool pN = false;
        public bool PN
        {
            get { return pN; }
            set
            {
                pN = value;
                NotifyPropertyChanged();
            }
        }



        private int pWiseN = 20;
        public int PWiseN
        {
            get { return pWiseN; }
            set
            {
                pWiseN = value;
                NotifyPropertyChanged();
            }
        }
        // z-wise
        private string zFocusMode = "不聚焦";
        public string ZFocusMode
        {
            get { return zFocusMode; }
            set
            {
                zFocusMode = value;
                NotifyPropertyChanged();
            }

        }


        private Optimize optimized = new Optimize();
         public Optimize Optimized
        {
            get { return optimized; }
            set 
            {
                optimized = value;
                NotifyPropertyChanged();
            }
        }

        private UserDefine  userDefined = new UserDefine();
        public UserDefine UserDefined
        {
            get { return userDefined; }
            set
            {
                userDefined = value;
                NotifyPropertyChanged();
            }
        }

       
     

    }
    public class MulDimensionalPoint
    {
        public MulDimensionalPoint(System.Windows.Point point)
        {
            X = (int)point.X;
            Y = (int)point.Y;
        }
        public MulDimensionalPoint(System.Drawing.Point point)
        {
            X = point.X;
            Y = point.Y;
        }
        [JsonPropertyName("X")]
        public int X { get; set; }
        [JsonPropertyName("Y")]
        public int Y { get; set; }
    }

    public class MulDimensionalArea
    {
        public MulDimensionalArea(System.Windows.Rect rectangle)
        {
            X = (int)rectangle.Top;
            Y = (int)rectangle.Left;
            Width = (int)rectangle.Width;
            Height = (int)rectangle.Height;
        }
        public MulDimensionalArea(System.Drawing.Rectangle rectangle)
        {
            X = rectangle.Top;
            Y = rectangle.Left;
            Width = rectangle.Width;
            Height = rectangle.Height;
        }

        public MulDimensionalArea()
        {

        }
        [JsonPropertyName("X")]
        public int X { get; set; }
        [JsonPropertyName("Y")]
        public int Y { get; set; }
        [JsonPropertyName("Width")]
        public int Width { get; set; }
        [JsonPropertyName("Height")]
        public int Height { get; set; }
    }
    public class Optimize : ViewModelBase
    {

        private bool isGlobal = false;
        public bool IsGlobal
        {
            get { return isGlobal; }
            set
            {
                isGlobal = value;
                NotifyPropertyChanged();
            }
        }
        private bool isLocal = false;
        public bool IsLocal
        {
            get { return isLocal; }
            set
            {
                isLocal = value;
                NotifyPropertyChanged();
            }
        }

        private int global = 1;

        public int Global
        {
            get { return global; }
            set
            {
                global = value;
                NotifyPropertyChanged();
            }
        }

        private int local = 2;

        public int Local
        {
            get { return local; }
            set
            {
                local = value;
                NotifyPropertyChanged();
            }
        }
        private int precision = 5;
        public int Precision
        {
            get { return precision; }
            set
            {
                precision = value;
                NotifyPropertyChanged();

            }
        }



    }
    public class UserDefine : ViewModelBase
    {
        private bool isGlobal = false;
        public bool IsGlobal
        {
            get { return isGlobal; }
            set
            {
                isGlobal = value;
                NotifyPropertyChanged();
            }
        }
        private bool isLocal = false;
        public bool IsLocal
        {
            get { return isLocal; }
            set
            {
                isLocal = value;
                NotifyPropertyChanged();
            }
        }



        private int global = 3;

        public int Global
        {
            get { return global; }
            set
            {
                global = value;
                NotifyPropertyChanged();
            }
        }

        private int local = 5;

        public int Local
        {
            get { return local; }
            set
            {
                local = value;
                NotifyPropertyChanged();
            }
        }
        private int precision = 2;
        public int Precision
        {
            get { return precision; }
            set
            {
                precision = value;
                NotifyPropertyChanged();

            }
        }


    }
    public class MulCollectionMode : ViewModelBase
    {

        private bool xWiseChecked = true;
        private bool yWiseChecked = true;
        private bool zWiseChecked = false;
        private bool tWiseChecked = false;
        private bool edofWiseChecked = false;
        private bool pWiseChecked = false;
        private bool mWiseChecked = false;

        public bool XWiseChecked
        {
            get { return xWiseChecked; }
            set { xWiseChecked = value; NotifyPropertyChanged(); }
        }
        public bool YWiseChecked
        {
            get { return yWiseChecked; }
            set { yWiseChecked = value; NotifyPropertyChanged(); }
        }
        public bool ZWiseChecked
        {
            get { return zWiseChecked; }
            set { zWiseChecked = value; NotifyPropertyChanged(); }
        }
        public bool TWiseChecked
        {
            get { return tWiseChecked; }
            set { tWiseChecked = value; NotifyPropertyChanged(); }
        }
        public bool EdofWiseChecked
        {
            get { return edofWiseChecked; }
            set { edofWiseChecked = value; NotifyPropertyChanged(); }
        }
        public bool PWiseChecked
        {
            get { return pWiseChecked; }
            set { pWiseChecked = value; NotifyPropertyChanged(); }
        }
        public bool MWiseChecked
        {
            get { return mWiseChecked; }
            set { mWiseChecked = value; NotifyPropertyChanged(); }
        }



    }




}
