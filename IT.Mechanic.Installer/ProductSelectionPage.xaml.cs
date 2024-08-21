using IT.Mechanic.Models.Configuration;

namespace IT.Mechanic.Installer;

public partial class ProductSelectionPage : ContentPage
{
	public ProductSelectionModel productSelection { get; set; }
	public ProductSelectionPage()
	{
		InitializeComponent();
		productSelection = new ProductSelectionModel();
		BindingContext = productSelection;
	}

	private async void OnNextClicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("//DNS");
	}

	private async void OnBackClicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("///MainPage");
	}
}