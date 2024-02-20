using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using PlatVirtual.Application.User.Dtos;
using PlatVirtual.Application.User.Helpers;
using PlatVirtual.Application.User.Interfaces;
using PlatVirtual.Application.User.Services.Projections;
using PlatVirtual.Infra.Repositories.UsersInterfaces;

namespace PlatVirtual.Application.User.Services
{
    public class UserService : IUserServices
    {
        private readonly IUsersRepository _repository;

        public UserService(IUsersRepository repository)
        {
            _repository = repository;
        }
        public async Task<UserResponseDto> Login(LoginUserDto loginDto)
        {
            var user = await _repository.GetByEmail(loginDto.Email);
            //if(!Bcrypt.ComparePass(user.Password, loginDto.Password))
            
            return UserResponse.UserToUserResponse(user);
        }

        public async Task<UserResponseDto> Register(RegisterUserDto registerDto)
        {
            registerDto.Password = Bcrypt.HashPass(registerDto.Password);
            var userProjection = RegisterUser.RegisterUserToUser(registerDto);
            userProjection.CreatedAt = DateTime.Now;
            await _repository.Add(userProjection);

            return UserResponse.UserToUserResponse(userProjection);
        }

        public async Task<List<UserResponseDto>> GetAll()
        {
            var users = await _repository.GetAll();

            return (List<UserResponseDto>)users.Select(e => UserResponse.UserToUserResponse(e));
        }

        public async Task<UserResponseDto> GetById(Guid id)
        {
            var user = await _repository.GetById(id);

            return UserResponse.UserToUserResponse(user);
        }


        public async Task<UserResponseDto> Update(UpdateUserDto updateDto)
        {
            var user = await _repository.GetById(updateDto.Id);
            user.FirstName = updateDto.FirstName;
            user.LastName = updateDto.LastName;
            user.PhoneNumber = updateDto.PhoneNumber;
            user.Address = updateDto.Address;

            await _repository.Update(user);
            return UserResponse.UserToUserResponse(user);
        }
        public async Task<UserResponseDto> Delete(Guid id)
        {
            var user = await _repository.GetById(id);
            user.IsActive = false;
            await _repository.Update(user);

            return UserResponse.UserToUserResponse(user);
        }
    }
}
