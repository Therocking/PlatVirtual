using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlatVirtual.Domain.Entities;
using PlatVirtual.Domain.Interfaces.Repository;

namespace PlatVirtual.Infra.Repositories.SubjectsInterfaces
{
    public interface ISubjectsRepository: IRepository<Subjects>
    {
        Task<Subjects> GetByName(string name);
        Task<Subjects> GetByCareer(string career);
        Task<Subjects> GetByCourse(string course);
    }
}
