using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlatVirtual.Application.Grade.Dtos;

namespace PlatVirtual.Application.Grade.Interfaces
{
    public interface IGradeService
    {
        Task<GradeResponseDto> Add(CreateGradeDto createDto);
        Task<List<GradeResponseDto>> GetAll();
        Task<List<GradeResponseDto>> GetAllByStudentName(string student);
        Task<GradeResponseDto> GetById(Guid id);
        Task<GradeResponseDto> Update(UpdateGradeDto updateDto);
        Task<GradeResponseDto> Delete(Guid id);
    }
}
