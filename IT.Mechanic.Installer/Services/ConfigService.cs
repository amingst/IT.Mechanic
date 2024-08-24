using IT.Mechanic.Models.Configuration;
using IT.Mechanic.Models.Configuration.Credentials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT.Mechanic.Installer.Services
{
    /// <summary>
    /// Represents the service Mechanic uses to build each server profile.
    /// </summary>
    public class ConfigService
    {
        /// <summary>
        /// Configuration Model used for building a profile during the app flow.
        /// </summary>
        public MainModel Model { get; set; } = new();
    }
}
