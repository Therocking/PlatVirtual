using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatVirtual.Domain.Interfaces.Repository
{
    public interface IRepository<T>
    {
        Task Add(T entity);
        Task<List<T>> GetAll();
        Task<T> GetById(Guid id);
        Task Update(T entity);
    }
}
