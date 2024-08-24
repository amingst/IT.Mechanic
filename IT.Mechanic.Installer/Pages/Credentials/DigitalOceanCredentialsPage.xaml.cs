namespace IT.Mechanic.Installer.Pages.Credentials;

public partial class DigitalOceanCredentialsPage : ContentPage
{
	public DigitalOceanCredentialsPage()
	{
		InitializeComponent();
	}

    public async void OnBackClicked(object sender, EventArgs e)
    {
        await AppShell.Current.GoToAsync("///Server");
    }

    public async void OnNextClicked(object sender, EventArgs e)
    {
        await AppShell.Current.GoToAsync("//DigitaloceanHostingPage");
    }
}