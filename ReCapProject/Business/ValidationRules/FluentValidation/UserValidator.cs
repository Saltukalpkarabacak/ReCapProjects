using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<Car>
    {
        public UserValidator()
        {
            RuleFor(u => u.Id).NotEmpty();
            RuleFor(u => u.Description).MinimumLength(3);

        }
    }
}
