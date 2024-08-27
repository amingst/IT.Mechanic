using IT.Mechanic.Installer.Services;
using IT.Mechanic.Models.Configuration.Credentials;

namespace IT.Mechanic.Installer.Pages.Credentials
{
    public partial class AWSCredentialsPage : ContentPage
    {
        private readonly ConfigService _configService;
        public AWSModel AWSCredentials { get; set; } = new();

        public AWSCredentialsPage()
        {
            InitializeComponent();
            _configService = App.Current.Handler.MauiContext.Services.GetService<ConfigService>();
            BindingContext = AWSCredentials; // Set BindingContext to AWSCredentials
        }

        public async void OnBackClicked(object sender, EventArgs e)
        {
            await AppShell.Current.GoToAsync("///Server");
        }

        public async void OnNextClicked(object sender, EventArgs e)
        {
            // Ensure AWSCredentials has been updated
            _configService.Model.Credentials.Add(AWSCredentials);
            await AppShell.Current.GoToAsync("//ReviewBuild");
        }
    }
}
