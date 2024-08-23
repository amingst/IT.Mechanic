using IT.Mechanic.Installer.Services;
using Microsoft.Extensions.DependencyInjection;

namespace IT.Mechanic.Installer
{
    public partial class MainPage : ContentPage
    {
        private readonly IConfigService _configService;

        public MainPage()
        {
            InitializeComponent();
            _configService = App.Current.Handler.MauiContext.Services.GetService<ConfigService>();
        }

        private async void OnStartClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//ProductSelect");
        }
    }

}
