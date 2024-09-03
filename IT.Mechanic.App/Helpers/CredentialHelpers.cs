using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IT.Mechanic.Models.Configuration.Credentials;

namespace IT.Mechanic.App.Helpers
{
    public static class CredentialHelpers
    {
        public static CredentialsBase? BuildCredentials(
            CredentialTypes credentialType,
            string ApiKey,
            string? ApiSecret,
            string? MasterKey
        )
        {
            switch (credentialType)
            {
                case CredentialTypes.AWS:
                    return new AWSModel() { ApiKey = ApiKey };
                case CredentialTypes.Azure:
                    return new AzureModel() { ApiKey = ApiKey };
                case CredentialTypes.DigitalOcean:
                    return new DigitalOceanModel() { ApiKey = ApiKey };
                case CredentialTypes.GoDaddy:
                    return new GodaddyModel() { ApiKey = ApiKey, ApiSecret = ApiSecret };
                case CredentialTypes.Master:
                    return new MasterModel() { MasterKey = MasterKey };
                case CredentialTypes.Rumble:
                    return new RumbleModel() { ApiKey = ApiKey };
                case CredentialTypes.GCP:
                    return new GCPModel() { ApiKey = ApiKey };
                case CredentialTypes.Invertedtech:
                    return new InvertedTechModel() { ApiKey = ApiKey };
                default:
                    return null;
            }
        }

        public enum CredentialTypes
        {
            AWS,
            Azure,
            DigitalOcean,
            GCP,
            GoDaddy,
            Invertedtech,
            Master,
            Rumble,
        }
    }
}
