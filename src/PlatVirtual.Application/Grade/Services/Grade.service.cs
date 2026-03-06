using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlatVirtual.Application.Grade.Dtos;
using PlatVirtual.Application.Grade.Interfaces;
using PlatVirtual.Application.Grade.Services.Projections;
using PlatVirtual.Infra.Repositories.GradesInterfaces;

namespace PlatVirtual.Application.Grade.Services
{
    public class GradeService : IGradeService
    {
        private readonly IGradesRepository _repository;

        public GradeService(IGradesRepository repository)
        {
            _repository = repository;
        }

        public async Task<GradeResponseDto> Add(CreateGradeDto createDto)
        {
            var newCourse = CreateGrade.DtoToGrade(createDto);
            await _repository.Add(newCourse);

            return GradeResponse.GradeToDto(newCourse);
        }

        public async Task<GradeResponseDto> Delete(Guid id)
        {
            var grade = await _repository.GetById(id);
            grade.IsActive = false;
            await _repository.Update(grade);

            return GradeResponse.GradeToDto(grade);
        }

        public async Task<List<GradeResponseDto>> GetAll()
        {
            var grades = await _repository.GetAll();

            return grades.Select(GradeResponse.GradeToDto).ToList();
        }

        public async Task<List<GradeResponseDto>> GetAllByStudentName(string student)
        {
            var grade = await _repository.GetAllByStudent(student);
            
            return grade.Select(GradeResponse.GradeToDto).ToList();
        }

        public async Task<GradeResponseDto> GetById(Guid id)
        {
            var grade = await _repository.GetById(id);

            return GradeResponse.GradeToDto(grade);
        }

        public async Task<GradeResponseDto> Update(UpdateGradeDto updateDto)
        {
            var grade = await _repository.GetById(updateDto.Id);
            grade.Grade = updateDto.Grade;
            grade.StudentId = updateDto.StudentId;
            grade.SubjectId = updateDto.SubjectId;
            await _repository.Update(grade);

            return GradeResponse.GradeToDto(grade);
        }
    }
}
