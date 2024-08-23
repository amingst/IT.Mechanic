
using IT.Mechanic.Installer.Models.Hosting;

namespace IT.Mechanic.Installer.Models
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
    }
}
