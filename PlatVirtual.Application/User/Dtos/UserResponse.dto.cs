using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlatVirtual.Domain.Entities;

namespace PlatVirtual.Application.User.Dtos
{
    public class UserResponseDto
    {
        public Guid Id {  get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateOnly BirthDay { get; set; }
        public Roles Role { get; set; }
        public string Adrress { get; set; }
        public string Img { get; set; }
    }
}
