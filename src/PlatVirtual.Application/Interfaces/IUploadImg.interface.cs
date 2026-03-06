using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace PlatVirtual.Application.Interfaces
{
    public interface IUploadImg
    {
        Task<Uri> UploadToCloudinary(IFormFile file);
    }
}
