using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using PlatVirtual.Application.User.Dtos;

namespace PlatVirtual.Application.User.Validations
{
    public class RegisterValidator: AbstractValidator<RegisterUserDto>
    {
        public RegisterValidator()
        {
            RuleFor(e => e.FirstName)
                .MaximumLength(50)
                .MinimumLength(3);

            RuleFor(e => e.LastName)
                .MaximumLength(50)
                .MinimumLength(4);

            RuleFor(e => e.Email)
                .EmailAddress();

            RuleFor(e => e.Password)
                .MinimumLength(5);

            RuleFor(e => e.PhoneNumber)
                .MinimumLength(10)
                .MaximumLength(11);

            RuleFor(e => e.RoleId)
                .NotEmpty();

            RuleFor(e => e.Address)
                .MaximumLength(250)
                .MinimumLength(5);
        }
    }

    public class LoginValidator: AbstractValidator<LoginUserDto>
    {
        public LoginValidator()
        {
            RuleFor(e => e.Email)
                .EmailAddress();

            RuleFor(e => e.Password)
                .MinimumLength(5);
        }
    }

    public class UpdateValidator: AbstractValidator<UpdateUserDto>
    {
        public UpdateValidator()
        {
            RuleFor(e => e.FirstName)
    .MaximumLength(50)
    .MinimumLength(3);

            RuleFor(e => e.LastName)
                .MaximumLength(50)
                .MinimumLength(4);

            RuleFor(e => e.Password)
                .MinimumLength(5);

            RuleFor(e => e.PhoneNumber)
                .MinimumLength(10)
                .MaximumLength(11);

            RuleFor(e => e.Address)
                .MaximumLength(250)
                .MinimumLength(5);
        }
    }
}
