using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlatVirtual.Application.Subject.Dtos;
using PlatVirtual.Domain.Entities;

namespace PlatVirtual.Application.Subject.Services.Projection
{
    public static class SubjectResponse
    {
        public static SubjectResponseDto SubjectToDto(Subjects subject)
        {
            var newSubject = new SubjectResponseDto
            {
                Id = subject.Id,
                Name = subject.Name,
                Credits = subject.Credits,
                CareerId = subject.CareerId,
                CourseId = subject.CourseId,
            };

            return newSubject;
        }
    }
}
