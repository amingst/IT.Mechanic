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
}