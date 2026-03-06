using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlatVirtual.Domain.Entities;
using PlatVirtual.Domain.Interfaces.Repository;

namespace PlatVirtual.Infra.Repositories.CoursesInterfaces
{
    public interface ICoursesRepository: IRepository<Courses>
    {
        Task<Courses> GetByName(string name);
    }
}
