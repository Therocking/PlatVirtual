using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PlatVirtual.Application.User.Dtos;
using PlatVirtual.Application.User.Interfaces;
using PlatVirtual.Application.User.Validations;

namespace PlatVirtual.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserServices _service;

        public AuthController(IUserServices service)
        {
            _service = service;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterUserDto registerDto)
        {
            try
            {
                var validator = new RegisterValidator();
                var result = validator.Validate(registerDto);
                if(!result.IsValid) return BadRequest(result.Errors);

                var user = await _service.Register(registerDto);
                return StatusCode(202, user);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginUserDto loginDto)
        {
            try
            {
                var validator = new LoginValidator();
                var resuls = validator.Validate(loginDto);
                if (!resuls.IsValid) return BadRequest(resuls.Errors);

                var user = await _service.Login(loginDto);
                return Ok(user);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
