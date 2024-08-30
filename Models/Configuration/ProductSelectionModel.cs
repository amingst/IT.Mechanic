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
            Socials = 2,
        }

        public static IEnumerable<string> GetWebsiteTypesNames()
        {
            return Enum.GetNames(typeof(WebsiteTypes));
        }

        public static WebsiteTypes GetWebsiteTypesFromName(string name)
        {
            switch (name)
            {
                case "CMS":
                    return WebsiteTypes.CMS;
                case "Business":
                    return WebsiteTypes.Business;
                case "Socials":
                    return WebsiteTypes.Socials;
                default:
                    return WebsiteTypes.CMS;
            }
        }
    }
}
