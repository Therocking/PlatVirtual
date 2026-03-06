using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using PlatVirtual.Application.Subject.Dtos;

namespace PlatVirtual.Application.Subject.Validations
{
    public class CreateSubject: AbstractValidator<CreateSubjectDto>
    {
        public CreateSubject()
        {
            RuleFor(e => e.CourseId).NotEmpty();
            RuleFor(e => e.CareerId).NotEmpty();

            RuleFor(e => e.Credits)
                .NotEmpty()
                .GreaterThanOrEqualTo(0)
                .LessThanOrEqualTo(10);

            RuleFor(e => e.Name)
                .NotEmpty()
                .MaximumLength(50)
                .MinimumLength(4);
        }
    }

    public class UpdateValidator: AbstractValidator<UpdateSubjectDto>
    {
        public UpdateValidator()
        {
            RuleFor(e => e.CourseId).NotEmpty();
            RuleFor(e => e.Id).NotEmpty();

            RuleFor(e => e.Credits)
                .NotEmpty()
                .GreaterThanOrEqualTo(0)
                .LessThanOrEqualTo(10);

            RuleFor(e => e.Name)
                .NotEmpty()
                .MaximumLength(50)
                .MinimumLength(4);
        }
    }
}
