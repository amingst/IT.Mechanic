namespace IT.Mechanic.Installer;

using IT.Mechanic.Installer.Services;
using IT.Mechanic.Models.Configuration;
public partial class DNSPage : ContentPage
{
	private readonly ConfigService _configService;
	public DNSPage()
	{
		InitializeComponent();
        _configService = App.Current.Handler.MauiContext.Services.GetService<ConfigService>();
        BindingContext = _configService.Model;
    }

    public void OnCheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (_configService != null)
        {
            if (sender is RadioButton radioButton)
            {
                var selectedContent = radioButton.Content;
                var selectedProvider = DNSModel.GetProviderFromName(selectedContent.ToString());
                _configService.Model.DNS.Provider = selectedProvider;
            }
        }
    }

    public async void OnNextClicked(object sender, EventArgs e)
    {
        await AppShell.Current.GoToAsync("//Server");
    }

    public async void OnBackClicked(object sender, EventArgs e)
    {
        await AppShell.Current.GoToAsync("///ProductSelect");
    }
}