using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IT.Mechanic.Models.Configuration;

namespace IT.Mechanic.App.ViewModels
{
    public class SiteConfigViewModel
    {
        public DNSModel.ProviderEnum DNSProvider { get; set; }
        public ProductSelectionModel.WebsiteTypes WebsiteType { get; set; }
        public ServerModel.HostingProviderEnum HostingProvider { get; set; }
    }
}
