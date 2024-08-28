using IT.Mechanic.Installer.Services;
using System.Diagnostics;

namespace IT.Mechanic.Installer;

public partial class ReviewBuildPage : ContentPage
{
	private readonly ConfigService _configService;
	private readonly ProfileService _profileService;
	public ReviewBuildPage()
	{
		InitializeComponent();
        _configService = App.Current.Handler.MauiContext.Services.GetService<ConfigService>(); 
        _profileService = App.Current.Handler.MauiContext.Services.GetService<ProfileService>();
        BindingContext = _configService.Model;
		BuildProductSelection();
    }

	private void BuildProductSelection()
	{
        websiteType.Text = _configService.Model.ProductSelection.WebsiteType.ToString();
		domainName.Text = _configService.Model.DNS.DomainName.ToString();
		hostingProvider.Text = _configService.Model.Server.HostingProvider.ToString();
		dnsProvider.Text = _configService.Model.DNS.Provider.ToString();
    }

	public async void OnSaveExitClicked(object sender, EventArgs e)
	{
		if (Application.Current != null)
		{
			if (_configService != null && _profileService != null)
			{
				_profileService.AddProfile(_configService.Model);
				await _profileService.SaveProfileToDisk();
				await AppShell.Current.GoToAsync("//MainPage");
            }
        }
	}

	public void OnBackClicked (object sender, EventArgs e)
	{
		AppShell.Current.GoToAsync("///Server");
	}

	public void OnDeployClicked(object sender, EventArgs e)
	{
        if (Application.Current != null)
        {
            Application.Current.Quit();
        }
    }

	public void OnQuitClicked(object sender, EventArgs e)
	{
        if (Application.Current != null)
        {
            Application.Current.Quit();
        }
    }
}