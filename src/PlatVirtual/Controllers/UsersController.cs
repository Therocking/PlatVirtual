using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Update;
using PlatVirtual.Application.Interfaces;
using PlatVirtual.Application.User.Dtos;
using PlatVirtual.Application.User.Interfaces;
using PlatVirtual.Application.User.Validations;

namespace PlatVirtual.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserServices _services;

        public UsersController(IUserServices services)
        {
            _services = services;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var users = await _services.GetAll();
                return Ok(users);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            try
            {
                var user = await _services.GetById(id);
                return Ok(user);
            }
            catch (Exception e)
            {
                return Ok(e.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] UpdateUserDto updateDto)
        {
            try
            {
                var validator = new UpdateValidator();
                var result = validator.Validate(updateDto);
                if (!result.IsValid) return BadRequest(result.Errors);

                updateDto.Id = id;
                var user = await _services.Update(updateDto);
                return Ok(user);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                var user = await _services.Delete(id);
                if(user != null)
                {
                    return NotFound("User not found");
                }
                return Ok(user);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
