using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.IO;
using System.ComponentModel;

namespace Solution
{
    /// <summary>
    /// UploadFile.xaml 的交互逻辑
    /// </summary>
    public partial class UploadFile : UserControl
    {
        public UploadFile()
        {
            InitializeComponent();
        }
        static FrameworkPropertyMetadata propertymetadata = new FrameworkPropertyMetadata(string.Empty, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault);


        public string NoFileLabel
        {
            get { return (string)GetValue(NoFileLabelProperty); }
            set { SetValue(NoFileLabelProperty, value); }
        }

        public static readonly DependencyProperty NoFileLabelProperty = DependencyProperty.Register("NoFileLabel", typeof(string), typeof(UploadFile), propertymetadata);


        public string FileName
        {
            get { return (string)GetValue(FileNameProperty); }
            set { SetValue(FileNameProperty, value); }
        }

        public static readonly DependencyProperty FileNameProperty = DependencyProperty.Register("FileName", typeof(string), typeof(UploadFile), new PropertyMetadata(string.Empty));



        public DragDropEffects Effects
        {
            get { return (DragDropEffects)GetValue(EffectsProperty); }
            set { SetValue(EffectsProperty, value); }
        }

        public static readonly DependencyProperty EffectsProperty = DependencyProperty.Register("Effects", typeof(DragDropEffects), typeof(UploadFile), new FrameworkPropertyMetadata(DragDropEffects.Copy, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));




        private void UIElement_OnDrop(object sender, DragEventArgs e)
        {
            var b = e.Data.GetDataPresent(DataFormats.FileDrop);

            if (b)
            {
                var sarr = e.Data.GetData(DataFormats.FileDrop);
                var a = sarr as string[];
                var fn = a.First();
                FileName = fn;
                RaiseEvent(new RoutedEventArgs(FilePathUpdatedEvent));
            }
        }

        private void UIElement_OnDragOver(object sender, DragEventArgs e)
        {

        }

        private DragDropEffects GetEffects(DragEventArgs e)
        {
            var b = e.Data.GetDataPresent(DataFormats.FileDrop);
            var isCopy = ((e.KeyStates & DragDropKeyStates.ControlKey) == DragDropKeyStates.ControlKey);
            var effects = isCopy ? DragDropEffects.Copy : DragDropEffects.Move;
            return b ? effects : DragDropEffects.None;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string FilePath = OpenFileDialog();
            if (FilePath != null)
            {
                FileName = FilePath;
                RaiseEvent(new RoutedEventArgs(FilePathUpdatedEvent));
            }
        }



        private string OpenFileDialog()
        {
            var dialog = new System.Windows.Forms.OpenFileDialog
            {
                Multiselect = false,//该值确定是否可以选择多个文件
                Title = "请选择文件",
            };
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                return dialog.FileName;
            }
            else
            {
                return null;
            }
        }


        public static readonly RoutedEvent FilePathUpdatedEvent = EventManager.RegisterRoutedEvent("FilePathUpdated ", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(UploadFile));

        [Description(" 文件被更新后发生 ")]
        public event RoutedEventHandler FilePathUpdated
        {
            add
            {
                AddHandler(FilePathUpdatedEvent, value);
            }
            remove
            {
                RemoveHandler(FilePathUpdatedEvent, value);
            }
        }

    }
}
