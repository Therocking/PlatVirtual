using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlatVirtual.Application.Career.Dtos;
using PlatVirtual.Domain.Entities;

namespace PlatVirtual.Application.Career.Services.Projections
{
    public static class CreateCareer
    {
        public static Careers CreateDtoToCareer(CreateCareerDto createDto)
        {
            var career = new Careers
            {
                Name = createDto.Name,
                Description = createDto.Description,
                Credits = createDto.Credits,
                Duration = createDto.Duration,
            };

            return career;
        }
    }
}
