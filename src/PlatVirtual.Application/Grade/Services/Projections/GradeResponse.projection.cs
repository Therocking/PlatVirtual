using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlatVirtual.Application.Grade.Dtos;
using PlatVirtual.Domain.Entities;

namespace PlatVirtual.Application.Grade.Services.Projections
{
    public static class GradeResponse
    {
        public static GradeResponseDto GradeToDto(Grades grade)
        {
            var newGrade = new GradeResponseDto
            {
                Id = grade.Id,
                Grade = grade.Grade,
                StudentId = grade.StudentId,
                ProfessorId = grade.ProfessorId,
                SubjectId = grade.SubjectId,
            };

            return newGrade;
        }
    }
}
