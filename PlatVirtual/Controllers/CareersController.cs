using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PlatVirtual.Application.Career.Dtos;
using PlatVirtual.Application.Career.Interfaces;

namespace PlatVirtual.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CareersController : ControllerBase
    {
        private readonly ICareerService _service;

        public CareersController(ICareerService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateCareerDto createDto)
        {
            try
            {
                var career = await _service.Add(createDto);
                return StatusCode(200, career);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var careers = await _service.GetAll();
                return Ok(careers);
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
                var career = await _service.GetById(id);
                return Ok(career);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("name/{name}")]
        public async Task<IActionResult> GetByName(string name)
        {
            try
            {
                var career = await _service.GetByName(name);
                return Ok(career);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] UpdateCareerDto updateDto)
        {
            try
            {
                updateDto.Id = id;
                var career = await _service.Update(updateDto);
                return Ok(career);
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
                var career = await _service.Delete(id);
                return Ok(career);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
