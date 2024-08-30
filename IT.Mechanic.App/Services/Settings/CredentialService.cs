using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using IT.Mechanic.Models.Configuration.App;
using IT.Mechanic.Models.Configuration.Credentials;

namespace IT.Mechanic.App.Services.Settings
{
    public class CredentialService : ICredentialService
    {
        private readonly JsonSerializerOptions _serializerOptions;
        private readonly ISettingsService _settingsService;
        private readonly string credentialsPath;
        public CredentialsState CredentialsState { get; set; } = new CredentialsState();

        public CredentialService(
            JsonSerializerOptions serializerOptions,
            ISettingsService settingsService
        )
        {
            _serializerOptions = serializerOptions;
            _settingsService = settingsService;
            credentialsPath = Path.Join(
                _settingsService.Settings.MechanicDirectory,
                "credentials.json"
            );
            InitializeSync();
        }

        public void InitializeSync()
        {
            if (!File.Exists(credentialsPath))
            {
                var stateString = JsonSerializer.Serialize<CredentialsState>(
                    CredentialsState,
                    _serializerOptions
                );
                File.WriteAllText(credentialsPath, stateString);
            }
            else
            {
                var stateString = File.ReadAllText(credentialsPath);
                var state = JsonSerializer.Deserialize<CredentialsState>(
                    stateString,
                    _serializerOptions
                );

                if (state != null)
                {
                    CredentialsState = state;
                }
            }
        }

        public async Task AddGodaddyCredentialAsync(string name, GodaddyModel model)
        {
            var newCredential = new CredentialRecord<GodaddyModel>(name, model);
            CredentialsState.GodaddyCredentials.Add(newCredential);
            await SaveStateAsync();
        }

        private async Task SaveStateAsync()
        {
            var stateString = JsonSerializer.Serialize<CredentialsState>(
                CredentialsState,
                _serializerOptions
            );
            await File.WriteAllTextAsync(credentialsPath, stateString);
        }
    }
}
