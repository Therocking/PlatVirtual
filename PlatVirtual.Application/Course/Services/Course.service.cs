using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlatVirtual.Application.Interfaces;
using PlatVirtual.Application.Course.Dtos;
using PlatVirtual.Application.Course.Interfaces;
using PlatVirtual.Application.Course.Services.Projections;
using PlatVirtual.Domain.Entities;
using PlatVirtual.Infra.Repositories.CoursesInterfaces;

namespace PlatVirtual.Application.Course.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICoursesRepository _repository;

        public CourseService(ICoursesRepository repository)
        {
            _repository = repository;
        }

        public async Task<CourseResponseDto> Add(CreateCourseDto createDto)
        {
            var course = CreateCourse.DtoToCourse(createDto);
            await _repository.Add(course);

            return CourseResponse.CourseToDto(course);
        }

        public async Task<CourseResponseDto> Delete(Guid id)
        {
            var course = await _repository.GetById(id);
            course.IsActive = false;
            await _repository.Update(course);

            return CourseResponse.CourseToDto(course);
        }

        public async Task<List<CourseResponseDto>> GetAll()
        {
            var courses = await _repository.GetAll();

            return courses.Select(CourseResponse.CourseToDto).ToList();
        }

        public async Task<CourseResponseDto> GetById(Guid id)
        {
            var course = await _repository.GetById(id);

            return CourseResponse.CourseToDto(course);
        }

        public async Task<CourseResponseDto> GetByName(string name)
        {
            var course = await _repository.GetByName(name);

            return CourseResponse.CourseToDto(course);
        }

        public async Task<CourseResponseDto> Update(UpdateCourseDto updateDto)
        {
            var course = await _repository.GetById(updateDto.Id);
            course.ProfessorId = updateDto.ProfessorId;
            course.Name = updateDto.Name;
            course.Description = updateDto.Description;
            await _repository.Update(course);

            return CourseResponse.CourseToDto(course);
        }
    }
}
