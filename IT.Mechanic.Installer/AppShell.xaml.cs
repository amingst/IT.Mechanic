using IT.Mechanic.Installer.Models;
using IT.Mechanic.Installer.Services;
using IT.Mechanic.Models.Configuration;
using Microsoft.Extensions.Options;

namespace IT.Mechanic.Installer
{
    public partial class AppShell : Shell
    {
        public readonly ConfigService _configService;
        public readonly ProfileService _profileService;
        public readonly SettingsService _settingsService;
        // public MainModel MainModel { get; set; }
        public AppShell(ConfigService configService, SettingsService settingsService, ProfileService profileService)
        {
            InitializeComponent();
            _settingsService = settingsService;
            _configService = configService;
            _profileService = profileService;
            BindingContext = this;
        }
    }
}
