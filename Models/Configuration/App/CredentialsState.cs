using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IT.Mechanic.Models.Configuration.Credentials;

namespace IT.Mechanic.Models.Configuration.App
{
    public class CredentialsState
    {
        public List<CredentialRecord<GodaddyModel>> GodaddyCredentials { get; set; } =
            new List<CredentialRecord<GodaddyModel>>();
        public List<CredentialRecord<AWSModel>> AWSCredentials { get; set; } =
            new List<CredentialRecord<AWSModel>>();
        public List<CredentialRecord<AzureModel>> AzureCredentials { get; set; } =
            new List<CredentialRecord<AzureModel>>();
        public List<CredentialRecord<DigitalOceanModel>> DigitalOceanCredentials { get; set; } =
            new List<CredentialRecord<DigitalOceanModel>>();
        public List<CredentialRecord<MasterModel>> MasterCredentials { get; set; } =
            new List<CredentialRecord<MasterModel>>();
        public List<CredentialRecord<RumbleModel>> RumbleCredentials { get; set; } =
            new List<CredentialRecord<RumbleModel>>();
        public List<CredentialRecord<GCPModel>> GCPCredentials { get; set; } =
            new List<CredentialRecord<GCPModel>>();
        public List<CredentialRecord<InvertedTechModel>> InvertedTechCredentials { get; set; } =
            new List<CredentialRecord<InvertedTechModel>>();
    }
}
