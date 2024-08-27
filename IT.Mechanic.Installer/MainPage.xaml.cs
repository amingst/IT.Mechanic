using IT.Mechanic.Installer.Services;
using Microsoft.Extensions.DependencyInjection;

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

            if (_profileService != null )
            {
                _profileService.LoadProfilesFromDisk();
            }
        }

        private async void OnStartClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//ProductSelect");
        }
    }

}
