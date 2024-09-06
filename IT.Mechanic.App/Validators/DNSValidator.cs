using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using IT.Mechanic.Models.Configuration;

namespace IT.Mechanic.App.Validators
{
    public class DNSValidator : AbstractValidator<DNSModel>
    {
        public DNSValidator()
        {
            RuleFor(dns => dns.DomainName).NotEmpty().NotNull().WithMessage("Domain Name Required");
            RuleFor(dns => dns.Provider)
                .NotEmpty()
                .NotNull()
                .WithMessage("Provider Required")
                .IsInEnum<DNSModel, DNSModel.ProviderEnum>();
        }
    }
}
