using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using IT.Mechanic.App.Helpers;
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

        public bool CredentialsExist()
        {
            var godaddyCreds = CredentialsState.GodaddyCredentials.Count() > 0;
            var awsCreds = CredentialsState.AWSCredentials.Count() > 0;
            var azureCreds = CredentialsState.AzureCredentials.Count() > 0;
            var digitaloceanCreds = CredentialsState.DigitalOceanCredentials.Count() > 0;
            var masterCreds = CredentialsState.MasterCredentials.Count() > 0;
            var rumbleCreds = CredentialsState.RumbleCredentials.Count() > 0;

            return godaddyCreds
                || awsCreds
                || azureCreds
                || digitaloceanCreds
                || masterCreds
                || rumbleCreds;
        }

        public async Task AddGodaddyCredentialAsync(string name, GodaddyModel model)
        {
            var newCredential = new CredentialRecord<GodaddyModel>(name, model);
            CredentialsState.GodaddyCredentials.Add(newCredential);
            await SaveStateAsync();
        }

        public async Task AddRumbleCredentialAsync(string name, RumbleModel model)
        {
            var newCredential = new CredentialRecord<RumbleModel>(name, model);
            CredentialsState.RumbleCredentials.Add(newCredential);
            await SaveStateAsync();
        }

        public async Task AddAzureCredentialAsync(string name, AzureModel credential)
        {
            var newCredential = new CredentialRecord<AzureModel>(name, credential);
            CredentialsState.AzureCredentials.Add(newCredential);
            await SaveStateAsync();
        }

        public async Task AddAwsCredentialAsync(string name, AWSModel credential)
        {
            var newCredential = new CredentialRecord<AWSModel>(name, credential);
            CredentialsState.AWSCredentials.Add(newCredential);
            await SaveStateAsync();
        }

        public async Task AddDigitalOceanCredentialAsync(string name, DigitalOceanModel credential)
        {
            var newCredential = new CredentialRecord<DigitalOceanModel>(name, credential);
            CredentialsState.DigitalOceanCredentials.Add(newCredential);
            await SaveStateAsync();
        }

        public async Task AddMasterCredentialAsync(string name, MasterModel credential)
        {
            var newCredential = new CredentialRecord<MasterModel>(name, credential);
            CredentialsState.MasterCredentials.Add(newCredential);
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

        public async Task AddCredentialAsync(
            string name,
            CredentialHelpers.CredentialTypes CredentialType,
            CredentialsBase credentials
        )
        {
            switch (CredentialType)
            {
                case CredentialHelpers.CredentialTypes.AWS:
                    if (credentials is AWSModel awsCredentials)
                    {
                        var newCredential = new CredentialRecord<AWSModel>(name, awsCredentials);
                        CredentialsState.AWSCredentials.Add(newCredential);
                    }
                    else
                    {
                        throw new ArgumentException("Invalid credentials type for AWS.");
                    }
                    break;

                case CredentialHelpers.CredentialTypes.Azure:
                    if (credentials is AzureModel azureCredentials)
                    {
                        var newCredential = new CredentialRecord<AzureModel>(
                            name,
                            azureCredentials
                        );
                        CredentialsState.AzureCredentials.Add(newCredential);
                    }
                    else
                    {
                        throw new ArgumentException("Invalid credentials type for Azure.");
                    }
                    break;

                case CredentialHelpers.CredentialTypes.DigitalOcean:
                    if (credentials is DigitalOceanModel digitalOceanCredentials)
                    {
                        var newCredential = new CredentialRecord<DigitalOceanModel>(
                            name,
                            digitalOceanCredentials
                        );
                        CredentialsState.DigitalOceanCredentials.Add(newCredential);
                    }
                    else
                    {
                        throw new ArgumentException("Invalid credentials type for DigitalOcean.");
                    }
                    break;

                case CredentialHelpers.CredentialTypes.GoDaddy:
                    if (credentials is GodaddyModel godaddyCredentials)
                    {
                        var newCredential = new CredentialRecord<GodaddyModel>(
                            name,
                            godaddyCredentials
                        );
                        CredentialsState.GodaddyCredentials.Add(newCredential);
                    }
                    else
                    {
                        throw new ArgumentException("Invalid credentials type for GoDaddy.");
                    }
                    break;

                case CredentialHelpers.CredentialTypes.Master:
                    if (credentials is MasterModel masterCredentials)
                    {
                        var newCredential = new CredentialRecord<MasterModel>(
                            name,
                            masterCredentials
                        );
                        CredentialsState.MasterCredentials.Add(newCredential);
                    }
                    else
                    {
                        throw new ArgumentException("Invalid credentials type for Master.");
                    }
                    break;

                case CredentialHelpers.CredentialTypes.Rumble:
                    if (credentials is RumbleModel rumbleCredentials)
                    {
                        var newCredential = new CredentialRecord<RumbleModel>(
                            name,
                            rumbleCredentials
                        );
                        CredentialsState.RumbleCredentials.Add(newCredential);
                    }
                    else
                    {
                        throw new ArgumentException("Invalid credentials type for Rumble.");
                    }
                    break;
                case CredentialHelpers.CredentialTypes.GCP:
                    if (credentials is GCPModel gcpCredentials)
                    {
                        var newCredential = new CredentialRecord<GCPModel>(name, gcpCredentials);
                        CredentialsState.GCPCredentials.Add(newCredential);
                    }
                    else
                    {
                        throw new ArgumentException("Invalid credentials type for GCP.");
                    }
                    break;
                case CredentialHelpers.CredentialTypes.Invertedtech:
                    if (credentials is InvertedTechModel invertedTechCredentials)
                    {
                        var newCredential = new CredentialRecord<InvertedTechModel>(
                            name,
                            invertedTechCredentials
                        );
                        CredentialsState.InvertedTechCredentials.Add(newCredential);
                    }
                    else
                    {
                        throw new ArgumentException("Invalid credentials type for InvertedTech.");
                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException(
                        nameof(CredentialType),
                        CredentialType,
                        null
                    );
            }

            await SaveStateAsync();
        }
    }
}
