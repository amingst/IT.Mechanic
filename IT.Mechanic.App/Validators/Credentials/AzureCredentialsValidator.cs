using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using IT.Mechanic.Models.Configuration.Credentials;

namespace IT.Mechanic.App.Validators.Credentials
{
    public class AzureCredentialsValidator : AbstractValidator<AzureModel>
    {
        public AzureCredentialsValidator()
        {
            RuleFor(azure => azure.ApiKey).NotEmpty().WithMessage("API Key Required");
        }
    }
}
