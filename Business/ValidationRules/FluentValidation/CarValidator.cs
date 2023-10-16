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
            RuleFor(p => p.ModelYear).MinimumLength(4).WithMessage("Model yılı en az 4 basamaklı olmalı");
            RuleFor(p => p.ColorId).NotEmpty();
            RuleFor(p => p.BrandId).NotEmpty();




        }
    }
}
