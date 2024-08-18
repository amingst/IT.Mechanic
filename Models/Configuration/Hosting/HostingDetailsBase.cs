using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace IT.Mechanic.Models.Configuration.Hosting
{
    [JsonDerivedType(typeof(AzureModel), typeDiscriminator: "azure")]
    [JsonDerivedType(typeof(DigitalOceanModel), typeDiscriminator: "digitalocean")]
    [JsonDerivedType(typeof(RumbleModel), typeDiscriminator: "rumble")]
    public class HostingDetailsBase
    {
    }
}
