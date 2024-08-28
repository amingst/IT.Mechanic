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
        public IOptions<AppSettings> AppSettings { get; set; }
        // public MainModel MainModel { get; set; }
        public AppShell(ConfigService configService, ProfileService profileService, IOptions<AppSettings> appSettings)
        {
            InitializeComponent();
            _configService = configService;
            _profileService = profileService;
            AppSettings = appSettings;
            BindingContext = this;
        }
    }
}
