using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlatVirtual.Application.Enrollment.Dtos;
using PlatVirtual.Domain.Entities;

namespace PlatVirtual.Application.Enrollment.Services.Projections
{
    public static class EnrollementResponse
    {
        public static EnrollmentResponseDto EnrollmentToDto(Enrollments enrollment)
        {
            var enrollmentToDto = new EnrollmentResponseDto
            {
                Id = enrollment.Id,
                Student = enrollment.StudentId,
                Career = enrollment.CareerId,
            };

            return enrollmentToDto;
        }
    }
}
