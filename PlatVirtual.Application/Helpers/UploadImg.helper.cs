using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;
using PlatVirtual.Application.Interfaces;

namespace PlatVirtual.Application.Helpers
{
    public class UploadImg : IUploadImg
    {
        public async Task<Uri> UploadToCloudinary(IFormFile file)
        {
            var cloudUrl = Envs.GetEnvString("CLOUDINARY_URL");
            var cloudinary = new Cloudinary(cloudUrl);
            cloudinary.Api.Secure = true;

            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(file.FileName, file.OpenReadStream()),
                UseFilename = true,
                UniqueFilename = false,
                Overwrite = true
            };

            var uploadResult = await cloudinary.UploadAsync(uploadParams);

            return uploadResult.SecureUrl;
        }
    }
}
