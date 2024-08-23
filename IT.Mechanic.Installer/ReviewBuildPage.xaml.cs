using IT.Mechanic.Installer.Services;

namespace IT.Mechanic.Installer;

public partial class ReviewBuildPage : ContentPage
{
	private readonly ConfigService _configService;
	public ReviewBuildPage()
	{
		InitializeComponent();
        _configService = App.Current.Handler.MauiContext.Services.GetService<ConfigService>();
		BindingContext = _configService.Model;
		BuildProductSelection();
    }

	private void BuildProductSelection()
	{
        websiteType.Text = _configService.Model.ProductSelection.WebsiteType.ToString();
		domainName.Text = _configService.Model.DNS.DomainName.ToString();
    }
}