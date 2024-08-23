﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT.Mechanic.Installer.Models.Hosting
{
    public class AzureModel : HostingDetailsBase
    {
        public string ServerSKU { get; set; } = "";
        public string ServerLocation { get; set; } = "";
    }
}
