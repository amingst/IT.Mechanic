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
        NextBtn.IsVisible = false;
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

    // TODO: Reset State if text is backspaced out
    public void OnTextChanged(object sender, TextChangedEventArgs e)
    {
        if (_configService != null)
        {
            if (e.OldTextValue != null || e.OldTextValue != "")
            {
                if (e.NewTextValue != null || e.NewTextValue != "")
                {
                    NextBtn.IsVisible = true;
                }
                else
                {
                    NextBtn.IsVisible = false;
                }
            }
            else { 
                NextBtn.IsVisible= false;
            }
        }
    }

    public async void OnNextClicked(object sender, EventArgs e)
    {
        await AppShell.Current.GoToAsync("//GodaddyCreds");
    }

    public async void OnBackClicked(object sender, EventArgs e)
    {
        await AppShell.Current.GoToAsync("///ProductSelect");
    }
}