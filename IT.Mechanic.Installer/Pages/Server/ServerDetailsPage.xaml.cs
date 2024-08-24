using IT.Mechanic.Installer.Services;
using IT.Mechanic.Models.Configuration;

namespace IT.Mechanic.Installer.Pages.Server;

public partial class ServerDetailsPage : ContentPage
{
    private readonly ConfigService _configService;
    public ServerDetailsPage()
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
        if (_configService != null)
        {
            switch (_configService.Model.Server.HostingProvider)
            {
                case (ServerModel.HostingProviderEnum.Rumble):
                    await AppShell.Current.GoToAsync("//RumbleCredentialsPage");
                    break;
                case (ServerModel.HostingProviderEnum.AWS):
                    await AppShell.Current.GoToAsync("//AWSCredentialsPage");
                    break;
                case (ServerModel.HostingProviderEnum.Azure):
                    await AppShell.Current.GoToAsync("//AzureCredentialsPage");
                    break;
                case (ServerModel.HostingProviderEnum.Digitalocean):
                    await AppShell.Current.GoToAsync("//DigitaloceanCredentialsPage");
                    break;
                case (ServerModel.HostingProviderEnum.Invertedtech):
                    await AppShell.Current.GoToAsync("//ReviewBuild");
                    break;
                case (ServerModel.HostingProviderEnum.GCP):
                    await AppShell.Current.GoToAsync("//ReviewBuild");
                    break;
                default:
                    await AppShell.Current.GoToAsync("//ReviewBuild");
                    break;
            }
        }
    }
}