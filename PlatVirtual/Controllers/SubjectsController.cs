using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PlatVirtual.Application.Subject.Dtos;
using PlatVirtual.Application.Subject.Interfaces;

namespace PlatVirtual.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectsController : ControllerBase
    {
        private readonly ISubjectService _service;

        public SubjectsController(ISubjectService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateSubjectDto createDto)
        {
            try
            {
                var subject = await _service.Add(createDto);
                return Ok(subject);
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
                var subjects = await _service.GetAll();
                return Ok(subjects);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("career/{name}")]
        public async Task<IActionResult> GetByCareerName(string name)
        {
            try
            {
                var subject = await _service.GetByCareerName(name);
                return Ok(subject);
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
                var subject = await _service.GetById(id);
                return Ok(subject);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("course/{name}")]
        public async Task<IActionResult> GetByCourseName(string name)
        {
            try
            {
                var subject = await _service.GetByCourseName(name);
                return Ok(subject);
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
                var subject = await _service.GetByName(name);
                return Ok(subject);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] UpdateSubjectDto updateDto)
        {
            try
            {
                updateDto.Id = id;
                var subject = await _service.Update(updateDto);
                return Ok(subject);
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
                var subject = await _service.Delete(id);
                return Ok(subject);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
