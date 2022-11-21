using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
namespace GalleryView
{
    public class TileView : ViewBase
    {
        private DataTemplate itemTemplate;
        public DataTemplate ItemTemplate
        {
            get { return itemTemplate; }
            set { itemTemplate = value; }
        }

        private Brush selectedBackground;
        public Brush SelectedBackground
        {
            get { return selectedBackground; }
            set { selectedBackground = value; }
        }




        private Brush selectedBorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#6EA646"));
        public Brush SelectedBorderBrush
        {
            get { return selectedBorderBrush; }
            set { selectedBorderBrush = value; }
        }

        protected override object DefaultStyleKey
        {
            get { return new ComponentResourceKey(GetType(), "TileView"); }
        }

        protected override object ItemContainerDefaultStyleKey
        {
            get { return new ComponentResourceKey(GetType(), "TileViewItem"); }
        }
    }
}
