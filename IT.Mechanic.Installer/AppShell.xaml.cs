using IT.Mechanic.Installer.Services;
using IT.Mechanic.Models.Configuration;

namespace IT.Mechanic.Installer
{
    public partial class AppShell : Shell
    {
        public readonly ConfigService _configService;
        // public MainModel MainModel { get; set; }
        public AppShell(ConfigService configService)
        {
            InitializeComponent();
            _configService = configService;
            BindingContext = this;
        }
    }
}
