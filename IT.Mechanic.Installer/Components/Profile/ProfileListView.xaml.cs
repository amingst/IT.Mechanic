using IT.Mechanic.Models.Configuration;

namespace IT.Mechanic.Installer.Components.Profile;

public partial class ProfileListView : ContentView
{
	public static readonly BindableProperty ProfilesProperty = BindableProperty.Create(nameof(Profiles), typeof(List<MainModel>), typeof(ProfileListView));
	public List<MainModel> Profiles
	{
		get => (List<MainModel>)GetValue(ProfilesProperty);
		set => SetValue(ProfilesProperty, value);
	}
	public ProfileListView()
	{
		InitializeComponent();
	}
}