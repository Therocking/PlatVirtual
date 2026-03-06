using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PlatVirtual.Domain.Entities;
using PlatVirtual.Infra.Context;
using PlatVirtual.Infra.Repositories.GradesInterfaces;

namespace PlatVirtual.Infra.Repositories.GradesRepository
{
    public class GradesRepository : IGradesRepository
    {
        private readonly PlatVirtualContext _context;

        public GradesRepository(PlatVirtualContext context)
        {
            _context = context;
        }

        public async Task Add(Grades entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Grades>> GetAll()
        {
            return await _context.Grades.Where(e => e.IsActive).ToListAsync();
        }

        public async Task<List<Grades>> GetAllByStudent(string student)
        {
            return await _context.Grades.Where(e => 
                e.IsActive && e.Student.FirstName == student).ToListAsync();
        }

        public async Task<Grades> GetById(Guid id)
        {
            return await _context.Grades.Where(e =>
                e.IsActive && e.Id == id).FirstOrDefaultAsync();
        }

        public async Task Update(Grades entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
