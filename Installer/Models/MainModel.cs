
using IT.Mechanic.Installer.Models.Credentials;
using System;
using System.Collections.Generic;

namespace IT.Mechanic.Installer.Models
{
    public class MainModel
    {
        public Guid SiteId { get; set; } = Guid.Empty;
        public DNSModel DNS { get; set; } = new();
        public ServerModel Server { get; set; } = new();
        public List<CredentialsBase> Credentials { get; set; } = new();
        public ProductSelectionModel ProductSelection { get; set; } = new();
    }
}
