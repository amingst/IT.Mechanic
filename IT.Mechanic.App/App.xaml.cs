using System.Text.Json;
using IT.Mechanic.App.Services.Profiles;
using IT.Mechanic.App.Services.Settings;

namespace IT.Mechanic.App
{
    public partial class App : Application
    {
        private readonly JsonSerializerOptions _jsonSerializerOptions;
        private readonly ISettingsService _settingsService;
        private readonly IProfileService _profileService;
        private readonly IProfileFactory _profileFactory;

        public App(
            JsonSerializerOptions jsonSerializerOptions,
            ISettingsService settingsService,
            IProfileService profileService,
            IProfileFactory profileFactory
        )
        {
            _jsonSerializerOptions = jsonSerializerOptions;
            _settingsService = settingsService;
            _profileService = profileService;
            _profileFactory = profileFactory;
            InitializeComponent();

            MainPage = new MainPage(
                _jsonSerializerOptions,
                _settingsService,
                _profileService,
                _profileFactory
            );
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
