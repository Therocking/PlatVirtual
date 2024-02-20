using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Microsoft.Identity.Client;
using PlatVirtual.Application.Course.Dtos;

namespace PlatVirtual.Application.Course.Validators
{
    public class CreateCourseValidator: AbstractValidator<CreateCourseDto>
    {
        public CreateCourseValidator()
        {
            RuleFor(e => e.ProfessorId).NotEmpty();

            RuleFor(e => e.Name)
                .NotEmpty()
                .MaximumLength(50)
                .MinimumLength(4);

            RuleFor(e => e.Description)
                .MaximumLength(50)
                .MinimumLength(10);
        }
    }

    public class UpdateCourseValidator: AbstractValidator<UpdateCourseDto>
    {
        public UpdateCourseValidator()
        {
            RuleFor(e => e.ProfessorId).NotEmpty();
            RuleFor(e => e.Id).NotEmpty();

            RuleFor(e => e.Name)
                .NotEmpty()
                .MaximumLength(50)
                .MinimumLength(4);

            RuleFor(e => e.Description)
                .MaximumLength(50)
                .MinimumLength(10);
        }
    }
}
