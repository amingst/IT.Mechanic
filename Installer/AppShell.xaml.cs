using Installer.Services;

namespace Installer
{
    public partial class AppShell : Shell
    {
        public ConfigModelService ConfigModelService { get; set; }
        public AppShell(ConfigModelService configModelService)
        {
            InitializeComponent();
            this.ConfigModelService = configModelService;
        }
    }
}
