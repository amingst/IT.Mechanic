using IT.Mechanic.Installer.Services;
using IT.Mechanic.Models.Configuration;

namespace IT.Mechanic.Installer
{
    public partial class AppShell : Shell
    {
        public readonly ConfigService _configService;
        public readonly ProfileService _profileService;
        // public MainModel MainModel { get; set; }
        public AppShell(ConfigService configService, ProfileService profileService)
        {
            InitializeComponent();
            _configService = configService;
            _profileService = profileService;
            BindingContext = this;
        }
    }
}
