using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PlatVirtual.Domain.Entities;
using PlatVirtual.Infra.Context;
using PlatVirtual.Infra.Repositories.CareersInterfaces;
using PlatVirtual.Infra.Repositories.CoursesInterfaces;

namespace PlatVirtual.Infra.Repositories.CoursesRepository
{
    public class CoursesRepository : ICoursesRepository
    {
        private readonly PlatVirtualContext _context;

        public CoursesRepository(PlatVirtualContext context)
        {
            _context = context;
        }

        public async Task Add(Courses entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Courses>> GetAll()
        {
            return await _context.Courses.Where(e => e.IsActive).ToListAsync();
        }

        public async Task<Courses> GetById(Guid id)
        {
            return await _context.Courses.Where(e => 
                e.IsActive && e.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Courses> GetByName(string name)
        {
            return await _context.Courses.Where(e =>
                e.IsActive && e.Name == name).FirstOrDefaultAsync();
        }

        public async Task Update(Courses entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
