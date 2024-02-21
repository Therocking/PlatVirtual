using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlatVirtual.Application.User.Dtos;
using PlatVirtual.Domain.Entities;

namespace PlatVirtual.Application.User.Services.Projections
{
    public static class UserResponse
    {
        public static UserResponseDto UserToUserResponse(Users user)
        {
            var userResponse = new UserResponseDto
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                BirthDay = user.BirthDay.Value,
                Role = user.RoleId,
                Adrress = user.Address,
                Img = user.Img,
            };

            return userResponse;
        }
    }
}
