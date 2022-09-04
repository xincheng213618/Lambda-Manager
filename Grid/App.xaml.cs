using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace Grid
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        
        [STAThread]
        [DebuggerNonUserCode]
        [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
        public static void Main(string[] args)
        {
            App app;

            if (args.Length >= 1)
            {
                app = new App(args[0]);
            }
            else
            {
                app = new App();
            }
            app.InitializeComponent();
            app.Run();
        }
        

        private App()
        {
            MainWindow window = new MainWindow();
            window.Show();
        }
        private App(string SolutionName)
        {
            MainWindow window = new MainWindow(SolutionName);
            window.Show();
        }

    }
}
