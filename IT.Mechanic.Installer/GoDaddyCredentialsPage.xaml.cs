using IT.Mechanic.Installer.Services;

namespace IT.Mechanic.Installer;

public partial class GoDaddyCredentialsPage : ContentPage
{
	private ConfigService _configService {  get; set; }
	public GoDaddyCredentialsPage()
	{
		InitializeComponent();
		_configService = App.Current.Handler.MauiContext.Services.GetService<ConfigService>();
		BindingContext = _configService.Model;
	}

    public async void OnNextClicked(object sender, EventArgs e)
    {
        await AppShell.Current.GoToAsync("//Server");
    }

    public async void OnBackClicked(object sender, EventArgs e)
    {
        await AppShell.Current.GoToAsync("///DNS");
    }
}