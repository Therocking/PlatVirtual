using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PlatVirtual.Application.Enrollment.Dtos;
using PlatVirtual.Application.Enrollment.Interfaces;

namespace PlatVirtual.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnrollmentsController : ControllerBase
    {
        private readonly IEnrollmenService _service;

        public EnrollmentsController(IEnrollmenService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateEnrollmentDto createDto)
        {
            try
            {
                var enrollment = await _service.Add(createDto);
                return StatusCode(200, enrollment);
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
                var enrollements = await _service.GetAll();
                return Ok(enrollements);
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
                var enrollement = await _service.GetById(id);
                return Ok(enrollement);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("career/{careerName}")]
        public async Task<IActionResult> GetAllByCareerName(string careerName)
        {
            try
            {
                var enrollements = await _service.GetAllByCareerName(careerName);
                return Ok(enrollements);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("createDate/{date}")]
        public async Task<IActionResult> GetAllByDate(DateTime date)
        {
            try
            {
                var enrollments = await _service.GetAllByDate(date);
                return Ok(enrollments);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("student/{name}")]
        public async Task<IActionResult> GetByStudentName(string name)
        {
            try
            {
                var enrollment = await _service.GetByStudentName(name);
                return Ok(enrollment);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("enrollment/{id}/career/{careerId}")]
        public async Task<IActionResult> Update(Guid id, Guid careerId)
        {
            try
            {
                var enrollement = await _service.Update(careerId, id);
                return Ok(enrollement);
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
                var enrollment = await _service.Delete(id);
                return Ok(enrollment);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
