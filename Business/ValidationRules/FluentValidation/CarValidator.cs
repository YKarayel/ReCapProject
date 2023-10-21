using Entities.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(p=> p.DailyPrice).NotEmpty();
            RuleFor(p => p.DailyPrice).GreaterThan(100).WithMessage("Günlük Fiyat 100'ün üzerinde olmalı");

            RuleFor(p => p.ModelYear).NotEmpty();
            RuleFor(p => p.ModelYear).GreaterThan(1990).LessThan(2023).WithMessage("Model yılı 1990 ile 2023 arasında olabilir");

			RuleFor(p => p.ColorId).NotEmpty();
            RuleFor(p => p.BrandId).NotEmpty();

        }
    }
}
