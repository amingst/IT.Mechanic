using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IT.Mechanic.App.Helpers;
using IT.Mechanic.Models.Configuration.App;
using IT.Mechanic.Models.Configuration.Credentials;

namespace IT.Mechanic.App.Services.Settings
{
    public interface ICredentialService
    {
        public CredentialsState CredentialsState { get; set; }
        public void InitializeSync();

        public Task AddCredentialAsync(
            string name,
            CredentialHelpers.CredentialTypes CredentialType,
            CredentialsBase credentials
        );

        public bool CredentialsExist();
        public Task AddGodaddyCredentialAsync(string name, GodaddyModel model);
        public Task AddRumbleCredentialAsync(string name, RumbleModel model);
        public Task AddAzureCredentialAsync(string name, AzureModel credential);
        public Task AddAwsCredentialAsync(string name, AWSModel credential);
        public Task AddDigitalOceanCredentialAsync(string name, DigitalOceanModel credential);
        public Task AddMasterCredentialAsync(string name, MasterModel credential);
    }
}
