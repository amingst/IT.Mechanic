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
}