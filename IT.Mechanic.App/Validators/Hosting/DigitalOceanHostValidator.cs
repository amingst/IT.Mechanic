using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using IT.Mechanic.Models.Configuration.Hosting;

namespace IT.Mechanic.App.Validators.Hosting
{
    public class DigitalOceanHostValidator : AbstractValidator<DigitalOceanModel>
    {
        public DigitalOceanHostValidator()
        {
            RuleFor(digitalOcean => digitalOcean.ServerSKU)
                .NotEmpty()
                .NotNull()
                .WithMessage("SKU Required");
            RuleFor(digitalOcean => digitalOcean.ServerLocation)
                .NotEmpty()
                .NotNull()
                .WithMessage("Location Required");
        }
    }
}
