using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using IT.Mechanic.Models.Configuration.Credentials;

namespace IT.Mechanic.App.Validators.Credentials
{
    public class GodaddyCredentialValidator : AbstractValidator<GodaddyModel>
    {
        public GodaddyCredentialValidator()
        {
            RuleFor(godaddy => godaddy.ApiKey).NotEmpty().WithMessage("API Key Required");
            RuleFor(godaddy => godaddy.ApiSecret).NotEmpty().WithMessage("API Secret Required");
        }
    }
}
