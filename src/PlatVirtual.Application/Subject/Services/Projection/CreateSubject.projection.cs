using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlatVirtual.Application.Subject.Dtos;
using PlatVirtual.Domain.Entities;

namespace PlatVirtual.Application.Subject.Services.Projection
{
    public static class CreateSubject
    {
        public static Subjects DtoToSubject(CreateSubjectDto createDto)
        {
            var subject = new Subjects
            {
                Name = createDto.Name,
                Credits = createDto.Credits,
                CourseId = createDto.CourseId,
                CareerId = createDto.CourseId,
            };

            return subject;
        }
    }
}
