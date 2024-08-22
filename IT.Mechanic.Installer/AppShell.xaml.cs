using IT.Mechanic.Installer.Services;
using IT.Mechanic.Models.Configuration;

namespace IT.Mechanic.Installer
{
    public partial class AppShell : Shell
    {
        public readonly IConfigService _configService;
        // public MainModel MainModel { get; set; }
        public AppShell(IConfigService configService)
        {
            InitializeComponent();
            _configService = configService;
            BindingContext = this;
        }
    }
}
