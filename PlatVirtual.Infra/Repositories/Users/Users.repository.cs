using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PlatVirtual.Domain.Entities;
using PlatVirtual.Domain.Interfaces.Repository;
using PlatVirtual.Infra.Context;
using PlatVirtual.Infra.Repositories.UsersInterfaces;

namespace PlatVirtual.Infra.Repositories.UsersRepository
{
    public class UsersRepository: IUsersRepository
    {
        private readonly PlatVirtualContext _context;
        public UsersRepository(PlatVirtualContext context)
        {
            _context = context;
        }

        public async Task Add(Users entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Users>> GetAll()
        {
            return await _context.Users.Where(e => e.IsActive).ToListAsync();
        }

        public async Task<Users> GetById(Guid id)
        {
            return await _context.Users.Where(e => e.IsActive && e.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Users> GetByEmail(string email)
        {
            return await _context.Users.Where(e => e.IsActive && e.Email == email).FirstOrDefaultAsync();
        }

        public async Task Update(Users entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
