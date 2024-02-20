using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlatVirtual.Application.Career.Dtos;

namespace PlatVirtual.Application.Career.Interfaces
{
    public interface ICareerService
    {
        Task<CareerResponseDto> Add(CreateCareerDto createDto);
        Task<List<CareerResponseDto>> GetAll();
        Task<CareerResponseDto> GetById(Guid id);
        Task<CareerResponseDto> GetByName(string name);
        Task<CareerResponseDto> Update(UpdateCareerDto updateDto);
        Task<CareerResponseDto> Delete(Guid id);
    }
}
