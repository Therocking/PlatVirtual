using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlatVirtual.Application.Enrollment.Dtos;
using PlatVirtual.Domain.Entities;

namespace PlatVirtual.Application.Enrollment.Interfaces
{
    public interface IEnrollmenService
    {
        Task<EnrollmentResponseDto> Add(CreateEnrollmentDto createDto);
        Task<EnrollmentResponseDto> Update(Guid career, Guid id);
        Task<List<EnrollmentResponseDto>> GetAll();
        Task<EnrollmentResponseDto> GetById(Guid id);
        Task<List<EnrollmentResponseDto>> GetAllByCareerName(string career);
        Task<List<EnrollmentResponseDto>> GetAllByDate(DateTime date);
        Task<EnrollmentResponseDto> GetByStudentName(string student);
        Task<EnrollmentResponseDto> Delete(Guid id);
    }
}
