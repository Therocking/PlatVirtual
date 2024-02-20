using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlatVirtual.Application.User.Dtos;

namespace PlatVirtual.Application.User.Interfaces
{
    public interface IUserServices
    {
        Task<UserResponseDto> Login(LoginUserDto loginDto);
        Task<UserResponseDto> Register(RegisterUserDto registerDto);
        Task<List<UserResponseDto>> GetAll();
        Task<UserResponseDto> GetById(Guid id);
        Task<UserResponseDto> Update(UpdateUserDto updateDto);
        Task<UserResponseDto> Delete(Guid id);
    }
}
