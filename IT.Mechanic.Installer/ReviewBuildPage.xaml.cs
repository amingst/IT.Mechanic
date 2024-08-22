using IT.Mechanic.Installer.Services;

namespace IT.Mechanic.Installer;

public partial class ReviewBuildPage : ContentPage
{
	private readonly IConfigService _configService;
	public ReviewBuildPage()
	{
		InitializeComponent();
        _configService = App.Current.Handler.MauiContext.Services.GetService<IConfigService>();
		BuildProductSelection();
    }

	private void BuildProductSelection()
	{
        var productSelection = _configService.GetProductSelection();
        websiteType.Text = productSelection.WebsiteType.ToString();
    }
}