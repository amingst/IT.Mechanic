using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using IT.Mechanic.Models.Configuration;

namespace IT.Mechanic.App.Validators
{
    public class ProductSelectionValidator : AbstractValidator<ProductSelectionModel>
    {
        public ProductSelectionValidator()
        {
            RuleFor(product => product.WebsiteType)
                .NotNull()
                .IsInEnum<ProductSelectionModel, ProductSelectionModel.WebsiteTypes>();
        }
    }
}
