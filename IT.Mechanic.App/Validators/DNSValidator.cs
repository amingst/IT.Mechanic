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
            RuleFor(dns => dns.DomainName).NotEmpty().NotNull();
            RuleFor(dns => dns.Provider)
                .NotEmpty()
                .NotNull()
                .IsInEnum<DNSModel, DNSModel.ProviderEnum>();
        }
    }
}
