using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IT.Mechanic.Models.Configuration.App;
using IT.Mechanic.Models.Configuration.Credentials;

namespace IT.Mechanic.App.Services.Settings
{
    public interface ICredentialService
    {
        public CredentialsState CredentialsState { get; set; }
        public void InitializeSync();
        public Task AddGodaddyCredentialAsync(string name, GodaddyModel model);
    }
}
