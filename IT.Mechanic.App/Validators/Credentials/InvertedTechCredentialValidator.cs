using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using IT.Mechanic.Models.Configuration.Credentials;

namespace IT.Mechanic.App.Validators.Credentials
{
    public class InvertedTechCredentialValidator : AbstractValidator<InvertedTechModel>
    {
        public InvertedTechCredentialValidator()
        {
            RuleFor(invertedTech => invertedTech.ApiKey).NotEmpty().WithMessage("API Key Required");
        }
    }
}
