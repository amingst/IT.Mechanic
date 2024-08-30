using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IT.Mechanic.Models.Configuration.Credentials;

namespace IT.Mechanic.Models.Configuration
{
    public class MechanicSettings
    {
        public string MechanicDirectory { get; private set; } =
            Path.Join(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "mechanic");
        public string ProfilesDirectory { get; private set; } =
            Path.Join(
                Path.Join(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "mechanic"),
                "profiles"
            );
        public string MechanicCliPath { get; private set; } = string.Empty;
        public IEnumerable<CredentialsBase> Credentials { get; private set; } =
            new List<CredentialsBase>();
    }
}
