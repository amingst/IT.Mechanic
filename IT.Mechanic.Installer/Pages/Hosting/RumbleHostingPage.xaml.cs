namespace IT.Mechanic.Installer.Pages.Hosting;

public partial class RumbleHostingPage : ContentPage
{
	public RumbleHostingPage()
	{
		InitializeComponent();
	}

    private void serverSku_TextChanged(object sender, TextChangedEventArgs e)
    {

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