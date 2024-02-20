using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlatVirtual.Application.Course.Dtos;
using PlatVirtual.Domain.Entities;

namespace PlatVirtual.Application.Course.Services.Projections
{
    public static class CourseResponse
    {
        public static CourseResponseDto CourseToDto(Courses courses)
        {
            var course = new CourseResponseDto
            {
                Id = courses.Id,
                Name = courses.Name,
                Description = courses.Description,
                ProfessorId = courses.ProfessorId,
            };

            return course;
        }
    }
}
