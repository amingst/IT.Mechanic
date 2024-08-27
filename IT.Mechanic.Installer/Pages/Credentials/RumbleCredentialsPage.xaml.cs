using IT.Mechanic.Installer.Services;
using IT.Mechanic.Models.Configuration.Credentials;

namespace IT.Mechanic.Installer.Pages.Credentials
{
    public partial class RumbleCredentialsPage : ContentPage
    {
        private readonly ConfigService? _configService;
        public RumbleModel RumbleCredentials { get; set; } = new();

        public RumbleCredentialsPage()
        {
            InitializeComponent();
            _configService = App.Current.Handler.MauiContext.Services.GetService<ConfigService>();
            BindingContext = RumbleCredentials; // Set BindingContext to RumbleCredentials
        }

        public async void OnBackClicked(object sender, EventArgs e)
        {
            await AppShell.Current.GoToAsync("///Server");
        }

        public async void OnNextClicked(object sender, EventArgs e)
        {
            // Ensure RumbleCredentials has been updated
            _configService.Model.Credentials.Add(RumbleCredentials);
            await AppShell.Current.GoToAsync("//RumbleHostingPage");
        }
    }
}
