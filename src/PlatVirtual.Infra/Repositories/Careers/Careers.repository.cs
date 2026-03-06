using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PlatVirtual.Domain.Entities;
using PlatVirtual.Infra.Context;
using PlatVirtual.Infra.Repositories.CareersInterfaces;

namespace PlatVirtual.Infra.Repositories.CareersRepository
{
    public class CareersRepository : ICareersRepository
    {
        private readonly PlatVirtualContext _context;
        public CareersRepository(PlatVirtualContext context)
        {
            _context = context;
        }
        public async Task Add(Careers entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Careers>> GetAll()
        {
            return await _context.Careers.Where(e => e.IsActive).ToListAsync();
        }

        public async Task<Careers> GetById(Guid id)
        {
            return await _context.Careers.Where(e => e.IsActive && e.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Careers> GetByName(string name)
        {
            return await _context.Careers.Where(e => e.IsActive && e.Name == name).FirstOrDefaultAsync();
        }

        public async Task Update(Careers entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
