using IT.Mechanic.Installer.Services;
using IT.Mechanic.Models.Configuration.Credentials;

namespace IT.Mechanic.Installer.Pages.Credentials
{
    public partial class DigitalOceanCredentialsPage : ContentPage
    {
        private readonly ConfigService _configService;
        public DigitalOceanModel DigitalOceanCredentials { get; set; } = new();

        public DigitalOceanCredentialsPage()
        {
            InitializeComponent();
            _configService = App.Current.Handler.MauiContext.Services.GetService<ConfigService>();
            BindingContext = DigitalOceanCredentials; // Set BindingContext to DigitalOceanCredentials
        }

        public async void OnBackClicked(object sender, EventArgs e)
        {
            await AppShell.Current.GoToAsync("///Server");
        }

        public async void OnNextClicked(object sender, EventArgs e)
        {
            // Ensure DigitalOceanCredentials has been updated
            _configService.Model.Credentials.Add(DigitalOceanCredentials);
            await AppShell.Current.GoToAsync("//DigitaloceanHostingPage");
        }

        private void apiKeyEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Optionally handle text change if needed
        }
    }
}
