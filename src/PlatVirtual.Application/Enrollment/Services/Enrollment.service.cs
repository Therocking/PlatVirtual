using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlatVirtual.Application.Enrollment.Dtos;
using PlatVirtual.Application.Enrollment.Interfaces;
using PlatVirtual.Application.Enrollment.Services.Projections;
using PlatVirtual.Domain.Entities;
using PlatVirtual.Infra.Repositories.EnrollmentsInterfaces;

namespace PlatVirtual.Application.Enrollment.Services
{
    public class EnrollmentService : IEnrollmenService
    {
        private readonly IEnrollmentsRepository _repository;

        public EnrollmentService(IEnrollmentsRepository repository)
        {
            _repository = repository;
        }

        public async Task<EnrollmentResponseDto> Add(CreateEnrollmentDto createDto)
        {
            var newEnrollment = CreateEnrollment.EnrollmentDtoToEnrollment(createDto);
            await _repository.Add(newEnrollment);

            return EnrollementResponse.EnrollmentToDto(newEnrollment);
        }

        public async Task<EnrollmentResponseDto> Delete(Guid id)
        {
            var enrollment = await _repository.GetById(id);
            enrollment.IsActive = false;
            await _repository.Update(enrollment);

            return EnrollementResponse.EnrollmentToDto(enrollment);
        }

        public async Task<List<EnrollmentResponseDto>> GetAll()
        {
            var enrollments = await _repository.GetAll();

            return enrollments.Select(EnrollementResponse.EnrollmentToDto).ToList();
        }

        public async Task<List<EnrollmentResponseDto>> GetAllByCareerName(string career)
        {
            var enrollments = await _repository.GetAllByCareerName(career);

            return enrollments.Select(EnrollementResponse.EnrollmentToDto).ToList();
        }

        public async Task<List<EnrollmentResponseDto>> GetAllByDate(DateTime date)
        {
            var enrollments = await _repository.GetAllByDate(date);

            return enrollments.Select(EnrollementResponse.EnrollmentToDto).ToList();
        }

        public async Task<EnrollmentResponseDto> GetById(Guid id)
        {
            var enrollment = await _repository.GetById(id);

            return EnrollementResponse.EnrollmentToDto(enrollment);
        }

        public async Task<EnrollmentResponseDto> GetByStudentName(string student)
        {
            var enrollment = await _repository.GetByStudentName(student);

            return EnrollementResponse.EnrollmentToDto(enrollment);
        }

        public async Task<EnrollmentResponseDto> Update(Guid career, Guid id)
        {
            var enrollment = await _repository.GetById(id);
            enrollment.CareerId = career;
            await _repository.Update(enrollment);

            return EnrollementResponse.EnrollmentToDto(enrollment);
        }
    }
}
