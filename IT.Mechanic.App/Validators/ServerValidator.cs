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

            RuleFor(server => server.PublicIP)
                .NotNull()
                .NotEmpty()
                .When(
                    server =>
                        server.HostingProvider.Equals(ServerModel.HostingProviderEnum.Expertmode)
                );
            RuleFor(server => server.SSHPrivateKey)
                .NotNull()
                .NotEmpty()
                .When(
                    server =>
                        server.HostingProvider.Equals(ServerModel.HostingProviderEnum.Expertmode)
                );
        }
    }
}
