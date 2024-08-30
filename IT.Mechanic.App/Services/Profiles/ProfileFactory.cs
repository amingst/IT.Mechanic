using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IT.Mechanic.Models.Configuration;
using IT.Mechanic.Models.Configuration.Credentials;

namespace IT.Mechanic.App.Services.Profiles
{
    public class ProfileFactory : IProfileFactory
    {
        public DNSModel DNS { get; set; }
        public ServerModel Server { get; set; }
        public List<CredentialsBase> Credentials { get; set; }
        public ProductSelectionModel ProductSelection { get; set; }

        public ProfileFactory()
        {
            DNS = new DNSModel();
            Server = new ServerModel();
            Credentials = new List<CredentialsBase>();
            ProductSelection = new ProductSelectionModel();
        }

        public void Clear()
        {
            DNS = new DNSModel();
            Server = new ServerModel();
            Credentials = new List<CredentialsBase>();
            ProductSelection = new ProductSelectionModel();
        }

        public MainModel BuildProfile()
        {
            return new MainModel()
            {
                SiteId = Guid.NewGuid(),
                DNS = DNS,
                Server = Server,
                Credentials = Credentials,
                ProductSelection = ProductSelection,
            };
        }

        public void SetServerDetails(string publicIp, string serverName, string user, string sshKey)
        {
            Server.ServerName = serverName;
            Server.User = user;
            Server.PublicIP = publicIp;
            Server.SSHPrivateKey = sshKey;
        }
    }
}
