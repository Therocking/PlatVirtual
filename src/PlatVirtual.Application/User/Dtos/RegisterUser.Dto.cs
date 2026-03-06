using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatVirtual.Application.User.Dtos
{
    public class RegisterUserDto
    {
        public string FirstName { get; set;}
        public string LastName { get; set;}
        public string Email { get; set;}
        public string Password { get; set;}
        public string? Address { get; set; }
        public string? PhoneNumber { get; set;}
        public DateOnly? BirthDay { get; set;}
        public Guid RoleId { get; set;}
        public string? Img { get; set;}
    }
}
