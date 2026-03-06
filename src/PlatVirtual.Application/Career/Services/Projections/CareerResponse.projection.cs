using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlatVirtual.Application.Career.Dtos;
using PlatVirtual.Domain.Entities;

namespace PlatVirtual.Application.Career.Services.Projections
{
    public static class CareerResponse
    {
        public static CareerResponseDto CareerToDto(Careers careers)
        {
            var career = new CareerResponseDto
            {
                Id = careers.Id,
                Name = careers.Name,
                Description = careers.Description,
                Duration = careers.Duration,
                Credits = careers.Credits,
            };

            return career;
        }
    }
}
