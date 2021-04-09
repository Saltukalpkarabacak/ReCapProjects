using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CardValidator : AbstractValidator<Card>
    {
        public CardValidator()
        {
            RuleFor(p => p.Name).MinimumLength(2);
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.CardNo).NotEmpty();
            RuleFor(p => p.Cvv).NotEmpty();
            RuleFor(p => p.Month).NotEmpty();
            RuleFor(p => p.Year).NotEmpty();
            RuleFor(p => p.CardNo).MinimumLength(2);
        }
    }
}
