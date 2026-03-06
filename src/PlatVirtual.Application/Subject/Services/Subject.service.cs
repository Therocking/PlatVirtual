using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlatVirtual.Application.Subject.Dtos;
using PlatVirtual.Application.Subject.Interfaces;
using PlatVirtual.Application.Subject.Services.Projection;
using PlatVirtual.Infra.Repositories.SubjectsInterfaces;
using PlatVirtual.Infra.Repositories.SubjectsRepository;

namespace PlatVirtual.Application.Subject.Services
{
    public class SubjectService : ISubjectService
    {
        private readonly ISubjectsRepository _repository;

        public SubjectService(ISubjectsRepository repository)
        {
            _repository = repository;
        }

        public async Task<SubjectResponseDto> Add(CreateSubjectDto createDto)
        {
            var subject = CreateSubject.DtoToSubject(createDto);
            await _repository.Add(subject);

            return SubjectResponse.SubjectToDto(subject);
        }

        public async Task<SubjectResponseDto> Delete(Guid id)
        {
            var subject = await _repository.GetById(id);
            subject.IsActive = false;
            await _repository.Update(subject);

            return SubjectResponse.SubjectToDto(subject);
        }

        public async Task<List<SubjectResponseDto>> GetAll()
        {
            var subjects = await _repository.GetAll();

            return subjects.Select(SubjectResponse.SubjectToDto).ToList();
        }

        public async Task<SubjectResponseDto> GetByCareerName(string career)
        {
            var subject = await _repository.GetByCareer(career);

            return SubjectResponse.SubjectToDto(subject);
        }

        public async Task<SubjectResponseDto> GetByCourseName(string course)
        {
            var subject = await _repository.GetByCourse(course);

            return SubjectResponse.SubjectToDto(subject);
        }

        public async Task<SubjectResponseDto> GetById(Guid id)
        {
            var subject = await _repository.GetById(id);

            return SubjectResponse.SubjectToDto(subject);
        }

        public async Task<SubjectResponseDto> GetByName(string name)
        {
            var subject = await _repository.GetByName(name);

            return SubjectResponse.SubjectToDto(subject);
        }

        public async Task<SubjectResponseDto> Update(UpdateSubjectDto updateDto)
        {
            var subject = await _repository.GetById(updateDto.Id);
            subject.Name = updateDto.Name;
            subject.CourseId = updateDto.CourseId;
            await _repository.Update(subject);

            return SubjectResponse.SubjectToDto(subject);
        }
    }
}
