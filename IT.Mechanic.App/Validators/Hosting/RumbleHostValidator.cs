using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using IT.Mechanic.Models.Configuration.Hosting;

namespace IT.Mechanic.App.Validators.Hosting
{
    public class RumbleHostValidator : AbstractValidator<RumbleModel>
    {
        public RumbleHostValidator()
        {
            RuleFor(rumble => rumble.ServerSKU)
                .NotEmpty()
                .NotEmpty()
                .NotNull()
                .WithMessage("SKU Required");
            RuleFor(rumble => rumble.ServerLocation)
                .NotEmpty()
                .NotNull()
                .WithMessage("Location Required");
        }
    }
}
