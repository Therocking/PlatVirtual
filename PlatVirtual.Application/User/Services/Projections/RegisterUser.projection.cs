using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlatVirtual.Application.User.Dtos;
using PlatVirtual.Domain.Entities;

namespace PlatVirtual.Application.User.Services.Projections
{
    public static class RegisterUser
    {
        public static Users RegisterUserToUser(RegisterUserDto registerUserDto)
        {
            var user = new Users
            {
                FirstName = registerUserDto.FirstName,
                LastName  = registerUserDto.LastName,
                Email = registerUserDto.Email,
                Password = registerUserDto.Password,
                PhoneNumber = registerUserDto.PhoneNumber,
                BirthDay = registerUserDto.BirthDay,
                RoleId = registerUserDto.RoleId,
                Img = registerUserDto.Img,
            };

            return user;
        }
    }
}
