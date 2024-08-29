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

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            const int newWidth = 800;
            const int newHeight = 600;

            window.Width = newWidth;
            window.Height = newHeight;

            return window;
        }
    }
}
