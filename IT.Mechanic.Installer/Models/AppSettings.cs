using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT.Mechanic.Installer.Models
{
    public class AppSettings
    {
        public readonly string ProfilesFileName = "mechanic.json";
        public string ProfilesDownloadFilePath { get; private set; } = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public string MechanicCliPath { get; private set; } = String.Empty;
    }
}
