using System.Windows;

namespace FlexiSuiteAPP.App
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            Configurator.Configure();

            var mainWindow = new MainWindow();
            mainWindow.Show();
        }
    }
}
