using IT.Mechanic.Installer.Services;
using IT.Mechanic.Models.Configuration.Credentials;

namespace IT.Mechanic.Installer;

public partial class GoDaddyCredentialsPage : ContentPage
{
	private ConfigService _configService {  get; set; }
    public GodaddyModel GoDaddyCredentials { get; set; } = new();
	public GoDaddyCredentialsPage()
	{
		InitializeComponent();
		_configService = App.Current.Handler.MauiContext.Services.GetService<ConfigService>();
        BindingContext = GoDaddyCredentials;
	}

    public async void OnNextClicked(object sender, EventArgs e)
    {
        BindingContext = _configService.Model;
        if (BindingContext != null)
        {
            _configService.Model.Credentials.Add(GoDaddyCredentials);
            await AppShell.Current.GoToAsync("//Server");
        }
    }

    public async void OnBackClicked(object sender, EventArgs e)
    {
        await AppShell.Current.GoToAsync("///DNS");
    }
}