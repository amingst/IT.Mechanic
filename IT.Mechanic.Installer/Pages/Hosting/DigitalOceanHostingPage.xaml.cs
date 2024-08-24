using IT.Mechanic.Installer.Services;

namespace IT.Mechanic.Installer.Pages.Hosting;

public partial class DigitalOceanHostingPage : ContentPage
{
    private readonly ConfigService _configService;

    public DigitalOceanHostingPage()
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
        await AppShell.Current.GoToAsync("//ReviewBuild");
    }

    private void serverSku_TextChanged(object sender, TextChangedEventArgs e)
    {

    }
}