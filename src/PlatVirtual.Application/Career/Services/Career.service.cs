using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlatVirtual.Application.Career.Dtos;
using PlatVirtual.Application.Career.Interfaces;
using PlatVirtual.Application.Career.Services.Projections;
using PlatVirtual.Infra.Repositories.CareersInterfaces;

namespace PlatVirtual.Application.Career.Services
{
    public class CareerService : ICareerService
    {
        private readonly ICareersRepository _repository;

        public CareerService(ICareersRepository repository)
        {
            _repository = repository;
        }

        public async Task<CareerResponseDto> Add(CreateCareerDto createDto)
        {
            var career = CreateCareer.CreateDtoToCareer(createDto);
            await _repository.Add(career);

            return CareerResponse.CareerToDto(career);
        }

        public async Task<CareerResponseDto> Delete(Guid id)
        {
            var career = await _repository.GetById(id);
            career.IsActive = false;
            await _repository.Update(career);

            return CareerResponse.CareerToDto(career);
        }

        public async Task<List<CareerResponseDto>> GetAll()
        {
            var careers = await _repository.GetAll();

            return careers.Select(CareerResponse.CareerToDto).ToList();
        }

        public async Task<CareerResponseDto> GetById(Guid id)
        {
            var career = await _repository.GetById(id);

            return CareerResponse.CareerToDto(career);
        }

        public async Task<CareerResponseDto> GetByName(string name)
        {
            var career = await _repository.GetByName(name);

            return CareerResponse.CareerToDto(career);
        }

        public async Task<CareerResponseDto> Update(UpdateCareerDto updateDto)
        {
            var career = await _repository.GetById(updateDto.Id);
            career.Duration = updateDto.Duration;
            career.Name = updateDto.Name;
            career.Description = updateDto.Description;
            career.Credits = updateDto.Credits;
            await _repository.Update(career);

            return CareerResponse.CareerToDto(career);
        }
    }
}
