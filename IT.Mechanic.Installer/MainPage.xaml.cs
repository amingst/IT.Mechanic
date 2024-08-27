using IT.Mechanic.Installer.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Windows.Input;

namespace IT.Mechanic.Installer
{
    public partial class MainPage : ContentPage
    {
        private readonly ConfigService _configService;
        private readonly ProfileService _profileService;
       
        public MainPage()
        {
            InitializeComponent();
            _configService = App.Current.Handler.MauiContext.Services.GetService<ConfigService>();
            _profileService = App.Current.Handler.MauiContext.Services.GetService<ProfileService>();
            BindingContext = _configService.Model;
            if (_profileService != null)
            {
                _profileService.LoadProfilesFromDisk();
                LoadProfiles();
            }
        }

        private async void LoadProfiles()
        {
            if (_profileService != null)
            {
                var profiles = await _profileService.GetAllProfiles();
                ProfilesListView.ItemsSource = profiles;
            }
        }

        private async void OnStartClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//ProductSelect");
        }

        private async void OnDetailsClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//ProfileDetails");
        }

        private void OnStartServiceClicked(object sender, EventArgs e)
        {
            Console.WriteLine("Starting Service");
        }
    }
}
