using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT.Mechanic.Models.Configuration.Hosting
{
    public class DigitalOceanModel : HostingDetailsBase
    {
        public string ServerSKU { get; set; } = "";
        public string ServerLocation { get; set; } = "";
    }
}
