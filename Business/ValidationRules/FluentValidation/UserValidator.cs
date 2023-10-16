using Entities.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.Email).EmailAddress().WithMessage("Lütfen uygun bir email giriniz");
            RuleFor(u => u.FirstName).MinimumLength(3).WithMessage("İsim 3 karakterden az olamaz");
            RuleFor(u => u.LastName).MinimumLength(3).WithMessage("Soyisim 3 karakterden az olamaz");
            RuleFor(u => u.CustomerId).NotEmpty();






        }
    }
}
