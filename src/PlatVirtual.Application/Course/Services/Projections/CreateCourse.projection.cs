using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlatVirtual.Application.Course.Dtos;
using PlatVirtual.Domain.Entities;

namespace PlatVirtual.Application.Course.Services.Projections
{
    public static class CreateCourse
    {
        public static Courses DtoToCourse(CreateCourseDto createDto)
        {
            var course = new Courses
            {
                Name = createDto.Name,
                Description = createDto.Description,
                ProfessorId = createDto.ProfessorId,
            };

            return course;
        }
    }
}
