using IT.Mechanic.Installer.Services;
using IT.Mechanic.Models.Configuration.Credentials;

namespace IT.Mechanic.Installer.Pages.Credentials
{
    public partial class AzureCredentialsPage : ContentPage
    {
        private readonly ConfigService _configService;
        public AzureModel AzureCredentials { get; set; } = new();

        public AzureCredentialsPage()
        {
            InitializeComponent();
            _configService = App.Current.Handler.MauiContext.Services.GetService<ConfigService>();
            BindingContext = AzureCredentials; // Set BindingContext to AzureCredentials
        }

        public async void OnBackClicked(object sender, EventArgs e)
        {
            await AppShell.Current.GoToAsync("///Server");
        }

        public async void OnNextClicked(object sender, EventArgs e)
        {
            // Ensure AzureCredentials has been updated
            _configService.Model.Credentials.Add(AzureCredentials);
            await AppShell.Current.GoToAsync("//AzureHostingPage");
        }

        private void apiKeyEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Optionally handle text change if needed
        }
    }
}
