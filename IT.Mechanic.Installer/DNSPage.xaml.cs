namespace IT.Mechanic.Installer;
using IT.Mechanic.Models.Configuration;
public partial class DNSPage : ContentPage
{
    public DNSModel dnsModel { get; set; }
	public DNSPage()
	{
		InitializeComponent();
        dnsModel = new DNSModel();
        BindingContext = dnsModel;
	}

    private async void OnNextClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//Server");
    }

    private async void OnBackClicked(object sender, EventArgs e)
    {
        // TODO: Make Go To Products
        await Shell.Current.GoToAsync("//Products");
    }
}