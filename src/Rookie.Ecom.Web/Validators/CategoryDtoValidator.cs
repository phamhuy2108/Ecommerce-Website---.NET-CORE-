﻿using FluentValidation;
using Rookie.Ecom.Contracts.Constants;
using Rookie.Ecom.Contracts.Dtos;

namespace Rookie.Ecom.Validators
{
    public class CategoryDtoValidator : BaseValidator<CategoryDto>
    {
        public CategoryDtoValidator()
        {
            RuleFor(m => m.Name)
                  .NotEmpty()
                  .WithMessage(x => string.Format(ErrorTypes.Common.RequiredError, nameof(x.Name)));

            RuleFor(m => m.Name)
               .MaximumLength(ValidationRules.CategoryRules.MaxLenghCharactersForName)
               .WithMessage(string.Format(ErrorTypes.Common.MaxLengthError, ValidationRules.CategoryRules.MaxLenghCharactersForName))
               .When(m => !string.IsNullOrWhiteSpace(m.Name));

            RuleFor(m => m.Desc)
               .MaximumLength(ValidationRules.CategoryRules.MaxLenghCharactersForDesc)
               .WithMessage(string.Format(ErrorTypes.Common.MaxLengthError, ValidationRules.CategoryRules.MaxLenghCharactersForDesc))
               .When(m => !string.IsNullOrWhiteSpace(m.Desc));
        }
    }
}
