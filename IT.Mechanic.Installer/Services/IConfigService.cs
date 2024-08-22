using IT.Mechanic.Models.Configuration;
using IT.Mechanic.Models.Configuration.Credentials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT.Mechanic.Installer.Services
{
    public interface IConfigService
    {
        public ProductSelectionModel GetProductSelection();
        public void SetProductSelection(ProductSelectionModel productSelection);
        public DNSModel GetDNSModel();
        public void SetDNSModel(DNSModel dnsModel);
        public ServerModel GetServerModel();
        public void SetServerModel(ServerModel serverModel);
        public IEnumerable<CredentialsBase> GetCredentials();
        public void SetCredentials(IEnumerable<CredentialsBase> credentials);
    }
}
