using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IT.Mechanic.Models.Configuration;
using IT.Mechanic.Models.Configuration.Credentials;

namespace IT.Mechanic.App.Services.Profiles
{
    public interface IProfileFactory
    {
        public DNSModel DNS { get; set; }
        public ServerModel Server { get; set; }
        public List<CredentialsBase> Credentials { get; set; }
        public ProductSelectionModel ProductSelection { get; set; }
        public void Clear();
        public MainModel BuildProfile();

        public void SetServerDetails(
            string publicIp,
            string serverName,
            string user,
            string sshKey
        );
    }
}
