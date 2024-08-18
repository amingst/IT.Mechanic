using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace IT.Mechanic.Models.Configuration.Credentials
{
    [JsonDerivedType(typeof(AWSModel), typeDiscriminator: "aws")]
    [JsonDerivedType(typeof(AzureModel), typeDiscriminator: "azure")]
    [JsonDerivedType(typeof(DigitalOceanModel), typeDiscriminator: "digitalocean")]
    [JsonDerivedType(typeof(GodaddyModel), typeDiscriminator: "godaddy")]
    [JsonDerivedType(typeof(MasterModel), typeDiscriminator: "master")]
    [JsonDerivedType(typeof(RumbleModel), typeDiscriminator: "rumble")]
    public class CredentialsBase
    {
    }
}
