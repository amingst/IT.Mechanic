using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IT.Mechanic.Models.Configuration.Credentials;

namespace IT.Mechanic.Models.Configuration.App
{
    public class CredentialRecord<TCredential>
    {
        public Guid CredentialId { get; set; } = Guid.Empty;
        public string CredentialName { get; set; } = string.Empty;
        public TCredential Credentials { get; set; }

        public CredentialRecord(string credentialName, TCredential credentials)
        {
            CredentialId = Guid.NewGuid();
            CredentialName = credentialName;
            Credentials = credentials;
        }
    }
}
