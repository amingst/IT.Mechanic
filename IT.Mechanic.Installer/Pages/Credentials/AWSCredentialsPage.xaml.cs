namespace IT.Mechanic.Installer.Pages.Credentials;

public partial class AWSCredentialsPage : ContentPage
{
	public AWSCredentialsPage()
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