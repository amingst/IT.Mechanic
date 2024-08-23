using Installer.Services;

namespace Installer
{
    public partial class App : Application
    {
        public App(ConfigModelService configModelService)
        {
            InitializeComponent();

            MainPage = new AppShell(configModelService);
        }
    }
}
