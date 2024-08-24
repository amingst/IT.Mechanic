namespace IT.Mechanic.Installer.Pages.Server;

public partial class ServerDetailsPage : ContentPage
{
	public ServerDetailsPage()
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