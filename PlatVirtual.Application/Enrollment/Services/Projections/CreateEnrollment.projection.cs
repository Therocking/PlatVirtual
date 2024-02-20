using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlatVirtual.Application.Enrollment.Dtos;
using PlatVirtual.Domain.Entities;

namespace PlatVirtual.Application.Enrollment.Services.Projections
{
    public static class CreateEnrollment
    {
        public static Enrollments EnrollmentDtoToEnrollment(CreateEnrollmentDto createDto)
        {
            var enrollment = new Enrollments
            {
                StudentId = createDto.Student,
                CareerId = createDto.Career,
            };

            return enrollment;
        }
    }
}
