using System;
using System.Collections.Generic;
using System.Linq;

namespace IT.Mechanic.Installer.Models
{
    public class ProductSelectionModel
    {
        public WebsiteTypes WebsiteType { get; set; } = WebsiteTypes.CMS;

        public enum WebsiteTypes
        {
            CMS = 0,
            Business = 1,
        }
    }
}
