using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT.Mechanic.Models.Configuration.Credentials
{
    public class GodaddyModel : CredentialsBase
    {
        public string ApiKey { get; set; } = "";
        public string ApiSecret { get; set; } = "";
    }
}
