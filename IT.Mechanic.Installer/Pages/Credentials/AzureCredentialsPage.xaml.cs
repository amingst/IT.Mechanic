using IT.Mechanic.Installer.Services;

namespace IT.Mechanic.Installer.Pages.Credentials;

public partial class AzureCredentialsPage : ContentPage
{
    private readonly ConfigService? _configService;

    public AzureCredentialsPage()
	{
		InitializeComponent();
        _configService = App.Current.Handler.MauiContext.Services.GetService<ConfigService>();
        BindingContext = _configService.Model;
    }

    public async void OnBackClicked(object sender, EventArgs e)
    {
        await AppShell.Current.GoToAsync("///Server");
    }

    public async void OnNextClicked(object sender, EventArgs e)
    {
        await AppShell.Current.GoToAsync("//AzureHostingPage");
    }

    private void apiKeyEntry_TextChanged(object sender, TextChangedEventArgs e)
    {

    }
}