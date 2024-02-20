using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using PlatVirtual.Application.Career.Dtos;

namespace PlatVirtual.Application.Career.Validations
{
    public class CreateCareerValidator: AbstractValidator<CreateCareerDto>
    {
        public CreateCareerValidator()
        {
            RuleFor(e => e.Name)
                .MaximumLength(50)
                .MinimumLength(10)
                .NotEmpty();

            RuleFor(e => e.Description)
                .MinimumLength(5);

            RuleFor(e => e.Credits)
                .GreaterThan(0);
        }
    }

    public class UpdateCareerValidator: AbstractValidator<UpdateCareerDto>
    {
        public UpdateCareerValidator()
        {
            RuleFor(e => e.Id).NotEmpty();

            RuleFor(e => e.Name)
                .MaximumLength(50)
                .MinimumLength(10)
                .NotEmpty();

            RuleFor(e => e.Description)
                .MinimumLength(5);

            RuleFor(e => e.Credits)
                .GreaterThan(0);
        }
    }
}
