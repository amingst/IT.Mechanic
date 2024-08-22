using IT.Mechanic.Installer.Services;
using IT.Mechanic.Models.Configuration;

namespace IT.Mechanic.Installer;

public partial class ServerPage : ContentPage
{
	private readonly IConfigService _configService;
	public ServerPage()
	{
		InitializeComponent();
        _configService = App.Current.Handler.MauiContext.Services.GetService<IConfigService>();
    }

    public async void OnNextClicked(object sender, EventArgs e)
    {
        await AppShell.Current.GoToAsync("//ReviewBuild");
    }

    public async void OnBackClicked(object sender, EventArgs e)
    {
        await AppShell.Current.GoToAsync("///DNS");
    }
}