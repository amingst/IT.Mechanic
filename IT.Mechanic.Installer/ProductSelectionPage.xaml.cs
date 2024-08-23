using IT.Mechanic.Installer.Services;
using IT.Mechanic.Models.Configuration;

namespace IT.Mechanic.Installer;

// TODO: Bind Data To Model
public partial class ProductSelectionPage : ContentPage
{
	private readonly ConfigService _configService;
	public ProductSelectionModel.WebsiteTypes SelectedType { get; set; }
	public ProductSelectionPage()
	{
		InitializeComponent();
        _configService = App.Current.Handler.MauiContext.Services.GetService<ConfigService>();
		BindingContext = _configService.Model;
		SelectedType = _configService.Model.ProductSelection.WebsiteType;
	}

	public void OnCheckedChanged(object sender, CheckedChangedEventArgs e)
	{
		if (_configService != null)
		{
            if (sender is RadioButton radioButton)
            {
                var selectedContent = radioButton.Content;
                var selectedProduct = ProductSelectionModel.GetWebsiteTypesFromName(selectedContent.ToString());
                _configService.Model.ProductSelection.WebsiteType = selectedProduct;
            }
        }
	}

	public async void OnNextClicked(object sender, EventArgs e)
	{
		await AppShell.Current.GoToAsync("//DNS");
	}

    public async void OnBackClicked(object sender, EventArgs e)
    {
		await AppShell.Current.GoToAsync("///MainPage");
    }
}