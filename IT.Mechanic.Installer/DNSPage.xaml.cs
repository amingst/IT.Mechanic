namespace IT.Mechanic.Installer;

using IT.Mechanic.Installer.Services;
using IT.Mechanic.Models.Configuration;
public partial class DNSPage : ContentPage
{
	private readonly IConfigService _configService;
	public DNSPage()
	{
		InitializeComponent();
        _configService = App.Current.Handler.MauiContext.Services.GetService<IConfigService>();
    }
}