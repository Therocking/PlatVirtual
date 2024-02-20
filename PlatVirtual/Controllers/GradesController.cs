using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PlatVirtual.Application.Grade.Dtos;
using PlatVirtual.Application.Grade.Interfaces;

namespace PlatVirtual.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GradesController : ControllerBase
    {
        private readonly IGradeService _service;

        public GradesController(IGradeService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateGradeDto createDto)
        {
            try
            {
                var grade = await _service.Add(createDto);
                return StatusCode(200, grade);
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
                var grades = await _service.GetAll();
                return Ok(grades);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("student/{name}")]
        public async Task<IActionResult> GetAllByStudentName(string name)
        {
            try
            {
                var grades = await _service.GetAllByStudentName(name);
                return Ok(grades);
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
                var grade = await _service.GetById(id);
                return Ok(grade);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] UpdateGradeDto updateDto)
        {
            try
            {
                updateDto.Id = id;
                var grade = await _service.Update(updateDto);
                return Ok(grade);
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
                var grade = await _service.Delete(id);
                return Ok(grade);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
