using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlatVirtual.Domain.Entities;
using PlatVirtual.Domain.Interfaces.Repository;

namespace PlatVirtual.Infra.Repositories.UsersInterfaces
{
    public interface IUsersRepository: IRepository<Users>
    {
        public Task<Users> GetByEmail(string email);
    }
}
