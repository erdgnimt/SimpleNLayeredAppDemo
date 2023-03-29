using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Northwind.Entities.Concrete;

namespace Northwind.Business.ValidationRules.FluentValidation
{
   public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty().WithMessage("Product name is not null");
            RuleFor(p => p.CategoryId).NotEmpty().WithMessage("Category Id is not null");
            RuleFor(p => p.UnitPrice).NotEmpty().WithMessage("UnitPrice is not null");
            RuleFor(p => p.QuantityPerUnit).NotEmpty().WithMessage("QuantityPerUnit is not null");
            RuleFor(p => p.UnitsInStock).NotEmpty().WithMessage("Stock is not null");

            RuleFor(p => p.UnitPrice).GreaterThan(0);
            RuleFor(p => p.UnitsInStock).GreaterThanOrEqualTo((short)0);
            RuleFor(p => p.UnitPrice).GreaterThan(10).When(p => p.CategoryId == 2);
        }
    }
}
