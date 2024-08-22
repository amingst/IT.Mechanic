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
}