using IT.Mechanic.App.Services.Settings;
using System.Text.Json;

namespace IT.Mechanic.App
{
    public partial class App : Application
    {
        private readonly JsonSerializerOptions _jsonSerializerOptions;
        private readonly ISettingsService _settingsService;
        public App(JsonSerializerOptions jsonSerializerOptions, ISettingsService settingsService)
        {
            _jsonSerializerOptions = jsonSerializerOptions;
            _settingsService = settingsService;
            InitializeComponent();

            MainPage = new MainPage(_jsonSerializerOptions, _settingsService);
        }
    }
}
