using IT.Mechanic.Installer.Models;
using IT.Mechanic.Installer.Services;
using IT.Mechanic.Models.Configuration;
using Microsoft.Extensions.Options;

namespace IT.Mechanic.Installer
{
    public partial class App : Application
    {
        public App(ConfigService _configService, ProfileService _profileService, SettingsService _settingsService)
        {
            InitializeComponent();

            MainPage = new AppShell(_configService,  _settingsService, _profileService);
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            const int newWidth = 800;
            const int newHeight = 600;

            window.Width = newWidth;
            window.Height = newHeight;

            return window;
        }
    }
}
