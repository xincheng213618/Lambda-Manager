using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using ThemeManager;

namespace ToolHash
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        [STAThread]
        [DebuggerNonUserCode]
        [GeneratedCode("PresentationBuildTasks", "7.0.0.0")]
        public static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                App app = new App();
                app.InitializeComponent();
                app.Run();
            }
            else
            {
                if (Directory.Exists(args[0]))
                {
                    XmlHelper.AddHash(args[0]);
                }
                else
                {
                    MessageBox.Show(args[0] +"不存在");
                }
            }
        }

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            Current.ApplyTheme(Theme.Dark);
        }
    }
}
