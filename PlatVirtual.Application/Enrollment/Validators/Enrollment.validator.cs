using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using PlatVirtual.Application.Enrollment.Dtos;

namespace PlatVirtual.Application.Enrollment.Validators
{
    public class CreateEnrollmentValidator: AbstractValidator<CreateEnrollmentDto>
    {
        public CreateEnrollmentValidator()
        {
            RuleFor(e => e.Career).NotEmpty();
            RuleFor(e => e.Student).NotEmpty();
        }
    }
}
