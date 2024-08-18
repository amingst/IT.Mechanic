using System;
using System.Collections.Generic;
using System.Linq;

namespace IT.Mechanic.Models.Configuration
{
    public class DNSModel
    {
        public string DomainName { get; set; } = "";
        public ProviderEnum Provider { get; set; } = ProviderEnum.Godaddy;

        public enum ProviderEnum
        {
            Godaddy
        }
    }
}
