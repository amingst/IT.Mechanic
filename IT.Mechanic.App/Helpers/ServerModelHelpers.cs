using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IT.Mechanic.Models.Configuration;
using IT.Mechanic.Models.Configuration.Hosting;

namespace IT.Mechanic.App.Helpers
{
    public class ServerModelHelpers
    {
        public static HostingDetailsBase? BuildHostingDetailsModel(
            ServerModel.HostingProviderEnum Provider,
            string ServerSKU,
            string ServerLocation
        )
        {
            switch (Provider)
            {
                case ServerModel.HostingProviderEnum.Rumble:
                    return new RumbleModel()
                    {
                        ServerSKU = ServerSKU,
                        ServerLocation = ServerLocation,
                    };
                case ServerModel.HostingProviderEnum.Azure:
                    return new AzureModel()
                    {
                        ServerSKU = ServerSKU,
                        ServerLocation = ServerLocation,
                    };
                case ServerModel.HostingProviderEnum.Digitalocean:
                    return new DigitalOceanModel()
                    {
                        ServerSKU = ServerSKU,
                        ServerLocation = ServerLocation,
                    };
                default:
                    return null;
            }
        }
    }
}
