using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using IT.Mechanic.App.ViewModels;
using IT.Mechanic.Models.Configuration;

namespace IT.Mechanic.App.Validators
{
    public class SiteConfigValidator : AbstractValidator<SiteConfigViewModel>
    {
        public SiteConfigValidator()
        {
            RuleFor(site => site.DNSProvider)
                .IsInEnum<SiteConfigViewModel, DNSModel.ProviderEnum>()
                .WithName("dns-provider-validator")
                .WithMessage("Value Must Be A DNS Provider");

            RuleFor(site => site.HostingProvider)
                .IsInEnum<SiteConfigViewModel, ServerModel.HostingProviderEnum>()
                .WithName("hosting-provider-validator")
                .WithMessage("Value Must Be A Hosting Provider");

            RuleFor(site => site.WebsiteType)
                .IsInEnum<SiteConfigViewModel, ProductSelectionModel.WebsiteTypes>()
                .WithName("website-type-validator")
                .WithMessage("Value Must Be A Website Type");
        }
    }
}
