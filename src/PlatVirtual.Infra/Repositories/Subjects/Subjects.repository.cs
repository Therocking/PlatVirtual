using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PlatVirtual.Domain.Entities;
using PlatVirtual.Infra.Context;
using PlatVirtual.Infra.Repositories.SubjectsInterfaces;

namespace PlatVirtual.Infra.Repositories.SubjectsRepository
{
    public class SubjectsRepository : ISubjectsRepository
    {
        private readonly PlatVirtualContext _context;

        public SubjectsRepository(PlatVirtualContext context)
        {
            _context = context;
        }

        public async Task Add(Subjects entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Subjects>> GetAll()
        {
            return await _context.Subjects.Where(e => e.IsActive).ToListAsync();
        }

        public async Task<Subjects> GetByCareer(string career)
        {
            return await _context.Subjects.Where(e => e.IsActive && e.Career.Name == career).FirstOrDefaultAsync();
        }

        public async Task<Subjects> GetByCourse(string course)
        {
            return await _context.Subjects.Where(e => e.IsActive && e.Course.Name == course).FirstOrDefaultAsync();
        }

        public async Task<Subjects> GetById(Guid id)
        {
            return await _context.Subjects.Where(e => e.IsActive && e.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Subjects> GetByName(string name)
        {
            return await _context.Subjects.Where(e => e.IsActive && e.Name == name).FirstOrDefaultAsync();
        }

        public async Task Update(Subjects entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
