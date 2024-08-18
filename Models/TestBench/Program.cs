using IT.Mechanic.Models.Configuration;
using IT.Mechanic.Models.Configuration.Credentials;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace TestBench
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var model = new MainModel()
            {
                SiteId = Guid.NewGuid(),
                DNS = new()
                {
                    Provider = DNSModel.ProviderEnum.Godaddy,
                    DomainName = "asdf.com",
                },
                ProductSelection = new()
                {
                    WebsiteType = ProductSelectionModel.WebsiteTypes.CMS,
                },
                Server = new()
                {
                    HostingProvider = ServerModel.HostingProviderEnum.Rumble,
                    HostingDetails = new IT.Mechanic.Models.Configuration.Hosting.RumbleModel()
                    {
                        ServerLocation = "florida",
                        ServerSKU = "small1",
                    }
                },
            };

            model.Credentials.Add(new MasterModel() { MasterKey = "master key goes here" });
            model.Credentials.Add(new GodaddyModel() { ApiKey = "api key goes here", ApiSecret = "api secret goes here" });
            model.Credentials.Add(new IT.Mechanic.Models.Configuration.Credentials.RumbleModel() { ApiKey = "api key goes here" });

            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                Converters =
                {
                    new JsonStringEnumConverter(JsonNamingPolicy.CamelCase)
                },
                
            };

            string jsonString = JsonSerializer.Serialize(model, options);
            Console.WriteLine(jsonString);
        }
    }
}
