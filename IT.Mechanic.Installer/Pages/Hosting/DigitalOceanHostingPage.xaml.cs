namespace IT.Mechanic.Installer.Pages.Hosting;

public partial class DigitalOceanHostingPage : ContentPage
{
	public DigitalOceanHostingPage()
	{
		InitializeComponent();
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