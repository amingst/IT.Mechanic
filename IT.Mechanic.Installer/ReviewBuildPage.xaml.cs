using IT.Mechanic.Installer.Services;

namespace IT.Mechanic.Installer;

public partial class ReviewBuildPage : ContentPage
{
	private readonly IConfigService _configService;
	public string _title { get; set; }
	public ReviewBuildPage()
	{
		InitializeComponent();
        _configService = App.Current.Handler.MauiContext.Services.GetService<IConfigService>();
		websiteType.Text = _configService.GetWebsiteType();
    }
}