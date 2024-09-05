using System.Text.Json;
using IT.Mechanic.App.Services.Profiles;
using IT.Mechanic.App.Services.Settings;
using IT.Mechanic.App.Validators;

namespace IT.Mechanic.App
{
    public partial class MainPage : ContentPage
    {
        private readonly JsonSerializerOptions _jsonSerializerOptions;
        private readonly ISettingsService _settingsService;
        private readonly ICredentialService _credentialService;
        private readonly IProfileService _profileService;
        private readonly IProfileFactory _profileFactory;
        private readonly DNSValidator _dnsValidator;
        private readonly ServerValidator _serverValidator;
        private readonly ProductSelectionValidator _productSelectionValidator;

        public MainPage(
            JsonSerializerOptions jsonSerializerOptions,
            ISettingsService settingsService,
            ICredentialService credentialService,
            IProfileService profileService,
            IProfileFactory profileFactory,
            DNSValidator dnsValidator,
            ServerValidator serverValidator,
            ProductSelectionValidator productSelectionValidator
        )
        {
            _jsonSerializerOptions = jsonSerializerOptions;
            _settingsService = settingsService;
            _credentialService = credentialService;
            _profileService = profileService;
            _profileFactory = profileFactory;
            _dnsValidator = dnsValidator;
            _serverValidator = serverValidator;
            _productSelectionValidator = productSelectionValidator;
            InitializeComponent();
        }
    }
}
