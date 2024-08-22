using IT.Mechanic.Models.Configuration;
using IT.Mechanic.Models.Configuration.Credentials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT.Mechanic.Installer.Services
{
    public class ConfigService : IConfigService
    {
        public Guid SiteId { get; set; } = Guid.Empty;
        public DNSModel DNS { get; set; } = new();
        public ServerModel Server { get; set; } = new();
        public List<CredentialsBase> Credentials { get; set; } = new();
        public ProductSelectionModel ProductSelection { get; set; } = new();

        public IEnumerable<CredentialsBase> GetCredentials()
        {
            return Credentials;
        }

        public DNSModel GetDNSModel()
        {
            return DNS;
        }

        public ProductSelectionModel GetProductSelection()
        {
            return ProductSelection;
        }

        public ServerModel GetServerModel()
        {
            return Server;
        }

        public void SetCredentials(IEnumerable<CredentialsBase> credentials)
        {
            Credentials = credentials.ToList();
        }

        public void SetDNSModel(DNSModel dnsModel)
        {
            DNS = dnsModel;
        }

        public void SetProductSelection(ProductSelectionModel productSelection)
        {
            ProductSelection = productSelection;
        }

        public void SetServerModel(ServerModel serverModel)
        {
           Server = serverModel;
        }
    }
}
