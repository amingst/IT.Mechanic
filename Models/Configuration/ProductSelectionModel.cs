using System;
using System.Collections.Generic;
using System.Linq;

namespace IT.Mechanic.Models.Configuration
{
    public class ProductSelectionModel
    {
        public WebsiteTypes WebsiteType { get; set; } = WebsiteTypes.CMS;

        public enum WebsiteTypes
        {
            CMS = 0,
            Business = 1,
            Socials = 2
        }
    }
}
