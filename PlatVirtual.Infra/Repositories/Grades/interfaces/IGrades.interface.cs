using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlatVirtual.Domain.Entities;
using PlatVirtual.Domain.Interfaces.Repository;

namespace PlatVirtual.Infra.Repositories.GradesInterfaces
{
    public interface IGradesRepository: IRepository<Grades>
    {
        Task<List<Grades>> GetAllByStudent(string student);
    }
}
