using IT.Mechanic.Models.Configuration;

namespace IT.Mechanic.Installer;

public partial class ServerPage : ContentPage
{
	public ServerModel serverModel { get; set; }
	public ServerPage()
	{
		InitializeComponent();
		serverModel = new ServerModel();
		BindingContext = serverModel;
	}

    private async void OnNextClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//Hosting");
    }

    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///DNS");
    }
}