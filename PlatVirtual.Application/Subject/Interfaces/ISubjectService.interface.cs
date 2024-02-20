using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlatVirtual.Application.Subject.Dtos;

namespace PlatVirtual.Application.Subject.Interfaces
{
    public interface ISubjectService
    {
        Task<SubjectResponseDto> Add(CreateSubjectDto createDto);
        Task<List<SubjectResponseDto>> GetAll();
        Task<SubjectResponseDto> GetById(Guid id);
        Task<SubjectResponseDto> GetByCareerName(string career);
        Task<SubjectResponseDto> GetByCourseName(string course);
        Task<SubjectResponseDto> GetByName(string name);
        Task<SubjectResponseDto> Update(UpdateSubjectDto updateDto);
        Task<SubjectResponseDto> Delete(Guid id);
    }
}
