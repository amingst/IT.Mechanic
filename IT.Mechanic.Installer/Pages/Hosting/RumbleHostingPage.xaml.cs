using IT.Mechanic.Installer.Services;

namespace IT.Mechanic.Installer.Pages.Hosting;

public partial class RumbleHostingPage : ContentPage
{
    private ConfigService? _configService;

    public RumbleHostingPage()
	{
		InitializeComponent();
        _configService = App.Current.Handler.MauiContext.Services.GetService<ConfigService>();
        BindingContext = _configService.Model;
    }

    private void serverSku_TextChanged(object sender, TextChangedEventArgs e)
    {

    }

    public async void OnBackClicked(object sender, EventArgs e)
    {
        await AppShell.Current.GoToAsync("///Server");
    }

    public async void OnNextClicked(object sender, EventArgs e)
    {
        await AppShell.Current.GoToAsync("//ReviewBuild");
    }
}