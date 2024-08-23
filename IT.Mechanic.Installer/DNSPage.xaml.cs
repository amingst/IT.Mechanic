namespace IT.Mechanic.Installer;

using IT.Mechanic.Installer.Services;
using IT.Mechanic.Models.Configuration;
public partial class DNSPage : ContentPage
{
	private readonly ConfigService _configService;
	public DNSPage()
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
        await AppShell.Current.GoToAsync("///ProductSelect");
    }
}