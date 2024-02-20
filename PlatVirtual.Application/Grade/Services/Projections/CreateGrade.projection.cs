using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlatVirtual.Application.Career.Dtos;
using PlatVirtual.Application.Grade.Dtos;
using PlatVirtual.Domain.Entities;

namespace PlatVirtual.Application.Grade.Services.Projections
{
    public static class CreateGrade
    {
        public static Grades DtoToGrade(CreateGradeDto createDto)
        {
            var grade = new Grades
            {
                Grade = createDto.Grade,
                StudentId = createDto.StudentId,
                ProfessorId = createDto.ProfessorId,
                SubjectId = createDto.SubjectId,
            };

            return grade;
        }
    }
}
