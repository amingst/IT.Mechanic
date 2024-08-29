using IT.Mechanic.App.Services.Settings;
using System.Text.Json;

namespace IT.Mechanic.App
{
    public partial class MainPage : ContentPage
    {
        private readonly JsonSerializerOptions _jsonSerializerOptions;
        private readonly ISettingsService _settingsService;
        public MainPage(JsonSerializerOptions jsonSerializerOptions, ISettingsService  settingsService)
        {
            _jsonSerializerOptions = jsonSerializerOptions;
            _settingsService = settingsService;
            InitializeComponent();
        }
    }
}
