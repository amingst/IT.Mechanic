using IT.Mechanic.Installer.Services;
using IT.Mechanic.Models.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Windows.Input;

namespace IT.Mechanic.Installer
{
    public partial class MainPage : ContentPage
    {
        private readonly ConfigService _configService;
        private readonly ProfileService _profileService;

        public ICommand DetailsCommand { get; }

        public MainPage()
        {
            InitializeComponent();
            _configService = App.Current.Handler.MauiContext.Services.GetService<ConfigService>();
            _profileService = App.Current.Handler.MauiContext.Services.GetService<ProfileService>();
            BindingContext = this;

            if (_profileService != null)
            {
                _profileService.LoadProfilesFromDisk();
                LoadProfiles();
            }

            DetailsCommand = new Command<MainModel>(OnDetailsClicked);
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

        private async void OnStartServiceClicked(object sender, EventArgs e)
        {
            Console.WriteLine("Starting Service");
        }

        private async void OnDetailsClicked(MainModel profile)
        {
            // Access the SiteId of the clicked profile
            var siteId = profile.SiteId;

            // Navigate to the ProfileDetails page and pass the SiteId
            await Shell.Current.GoToAsync($"//ProfileDetails?siteId={siteId}");
        }

        private void OnQuitClicked(object sender, EventArgs e)
        {
            Application.Current.Quit();
        }

        private async void OnSettingsClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//Settings");
        }
    }
}
