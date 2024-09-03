using System;
using System.Collections.Generic;
using IT.Mechanic.Models.Configuration.Hosting;

namespace IT.Mechanic.Models.Configuration
{
    public class ServerModel
    {
        public HostingProviderEnum HostingProvider { get; set; } = HostingProviderEnum.Rumble;
        public HostingDetailsBase? HostingDetails { get; set; }

        /***** Needed for expert mode or will be filled in automatically *****/
        public string PublicIP { get; set; } = "";
        public string ServerName { get; set; } = "";
        public string User { get; set; } = "";
        public string SSHPrivateKey { get; set; } = "";

        /***** Needed for expert mode or will be filled in automatically *****/


        public enum HostingProviderEnum
        {
            Expertmode,
            Rumble,
            Digitalocean,
            Azure,
            AWS,
            GCP,
            Invertedtech,
        }

        public static IEnumerable<string> GetHostingProvidersNames()
        {
            return Enum.GetNames(typeof(HostingProviderEnum));
        }

        public static HostingProviderEnum GetHostingProviderFromName(string name)
        {
            switch (name)
            {
                case "Expertmode":
                    return HostingProviderEnum.Expertmode;
                case "Rumble":
                    return HostingProviderEnum.Rumble;
                case "Digitalocean":
                    return HostingProviderEnum.Digitalocean;
                case "Azure":
                    return HostingProviderEnum.Azure;
                case "AWS":
                    return HostingProviderEnum.AWS;
                case "GCP":
                    return HostingProviderEnum.GCP;
                case "Invertedtech":
                    return HostingProviderEnum.Invertedtech;
                default:
                    return HostingProviderEnum.Rumble;
            }
        }
    }
}
