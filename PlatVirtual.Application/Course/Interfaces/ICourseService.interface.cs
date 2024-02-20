using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlatVirtual.Application.Course.Dtos;
using PlatVirtual.Domain.Entities;

namespace PlatVirtual.Application.Course.Interfaces
{
    public interface ICourseService
    {
        Task<CourseResponseDto> Add(CreateCourseDto createDto);
        Task<List<CourseResponseDto>> GetAll();
        Task<CourseResponseDto> GetById(Guid id);
        Task<CourseResponseDto> GetByName(string name);
        Task<CourseResponseDto> Update(UpdateCourseDto updateDto);
        Task<CourseResponseDto> Delete(Guid id);
    }
}
