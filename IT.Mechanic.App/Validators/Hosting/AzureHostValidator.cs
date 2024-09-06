using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using IT.Mechanic.Models.Configuration.Hosting;

namespace IT.Mechanic.App.Validators.Hosting
{
    public class AzureHostValidator : AbstractValidator<AzureModel>
    {
        public AzureHostValidator()
        {
            RuleFor(azure => azure.ServerSKU).NotEmpty();
            RuleFor(azure => azure.ServerLocation).NotEmpty();
        }
    }
}
