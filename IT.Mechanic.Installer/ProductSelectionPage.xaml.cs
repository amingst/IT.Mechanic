using IT.Mechanic.Installer.Services;
using IT.Mechanic.Models.Configuration;

namespace IT.Mechanic.Installer;

public partial class ProductSelectionPage : ContentPage
{
	private readonly IConfigService _configService;
	public ProductSelectionPage()
	{
		InitializeComponent();
        _configService = App.Current.Handler.MauiContext.Services.GetService<IConfigService>();
    }

	public async void OnNextClicked(object sender, EventArgs e)
	{
		await AppShell.Current.GoToAsync("//DNS");
	}

    public async void OnBackClicked(object sender, EventArgs e)
    {
		await AppShell.Current.GoToAsync("///MainPage");
    }
}