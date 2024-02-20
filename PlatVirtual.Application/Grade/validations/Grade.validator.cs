using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using PlatVirtual.Application.Grade.Dtos;

namespace PlatVirtual.Application.Grade.validations
{
    public class CreateGradeValidator: AbstractValidator<CreateGradeDto>
    {
        public CreateGradeValidator()
        {
            RuleFor(e => e.ProfessorId).NotEmpty();
            RuleFor(e => e.StudentId).NotEmpty();
            RuleFor(e => e.SubjectId).NotEmpty();

            RuleFor(e => e.Grade)
                .GreaterThanOrEqualTo(10)
                .LessThanOrEqualTo(0)
                .NotEmpty();
        }
    }

    public class UpdateGradeValidator: AbstractValidator<UpdateGradeDto>
    {
        public UpdateGradeValidator()
        {
            RuleFor(e => e.StudentId).NotEmpty();
            RuleFor(e => e.SubjectId).NotEmpty();

            RuleFor(e => e.Grade)
                .GreaterThanOrEqualTo(10)
                .LessThanOrEqualTo(0)
                .NotEmpty();
        }
    }
}
