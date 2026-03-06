using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlatVirtual.Domain.Entities;
using PlatVirtual.Domain.Interfaces.Repository;

namespace PlatVirtual.Infra.Repositories.EnrollmentsInterfaces
{
    public interface IEnrollmentsRepository: IRepository<Enrollments>
    {
        Task<List<Enrollments>> GetAllByDate(DateTime date);
        Task<List<Enrollments>> GetAllByCareerName(string career);
        Task<Enrollments> GetByStudentName(string student);
    }
}
