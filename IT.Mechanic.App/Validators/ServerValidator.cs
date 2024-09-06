using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using IT.Mechanic.Models.Configuration;

namespace IT.Mechanic.App.Validators
{
    public class ServerValidator : AbstractValidator<ServerModel>
    {
        public ServerValidator()
        {
            RuleFor(server => server.User).NotEmpty().NotNull();
            RuleFor(server => server.ServerName).NotEmpty().NotNull();
            RuleFor(server => server.HostingProvider)
                .NotNull()
                .IsInEnum<ServerModel, ServerModel.HostingProviderEnum>();

            // TODO: CHANGE THIS BEFORE YOU CROWDSTRIKE YOURSELF
            RuleFor(server => server.PublicIP)
                .NotNull()
                .NotEmpty()
                .Matches(
                    "(\\b25[0-5]|\\b2[0-4][0-9]|\\b[01]?[0-9][0-9]?)(\\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)){3}"
                )
                .When(server =>
                    server.HostingProvider.Equals(ServerModel.HostingProviderEnum.Expertmode)
                );
            RuleFor(server => server.SSHPrivateKey)
                .NotNull()
                .NotEmpty()
                .When(server =>
                    server.HostingProvider.Equals(ServerModel.HostingProviderEnum.Expertmode)
                );
        }
    }
}
