using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PlatVirtual.Application.Interfaces;

namespace PlatVirtual.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Pruebas : ControllerBase
    {
        private readonly ITokenActions _tokenActions;
        private readonly IUploadImg _uploadImg;

        public Pruebas(ITokenActions tokenActions, IUploadImg uploadImg)
        {
            _tokenActions = tokenActions;
            _uploadImg = uploadImg;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var guid = Guid.NewGuid().ToString();
            var token = _tokenActions.GenerateToken(guid);
            return Ok(_tokenActions.DecodeToken(token));
        }

        [HttpPost("/uploads")]
        public async Task<IActionResult> Post(IFormFile file)
        {
            var url = await _uploadImg.UploadToCloudinary(file);
            return StatusCode(200, url);
        }
    }
}
