using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PlatVirtual.Domain.Entities;
using PlatVirtual.Infra.Context;
using PlatVirtual.Infra.Repositories.EnrollmentsInterfaces;

namespace PlatVirtual.Infra.Repositories.EnrollmentsRepository
{
    public class EnrollmentsRepository : IEnrollmentsRepository
    {
        private readonly PlatVirtualContext _context;

        public EnrollmentsRepository(PlatVirtualContext context)
        {
            _context = context;
        }

        public async Task Add(Enrollments entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Enrollments>> GetAll()
        {
            return await _context.Enrollments.Where(e => e.IsActive).ToListAsync();
        }

        public async Task<List<Enrollments>> GetAllByCareerName(string career)
        {
            return await _context.Enrollments.Where(e => 
                e.IsActive && e.Career.Name == career).ToListAsync();
        }

        public async Task<List<Enrollments>> GetAllByDate(DateTime date)
        {
            return await _context.Enrollments.Where(e => 
                e.IsActive && e.EnrollmentDate.Date == date).ToListAsync();
        }

        public async Task<Enrollments> GetById(Guid id)
        {
            return await _context.Enrollments.Where(e =>
                e.IsActive && e.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Enrollments> GetByStudentName(string student)
        {
            return await _context.Enrollments.Where(e =>
                e.IsActive && e.Student.FirstName == student).FirstOrDefaultAsync();
        }

        public async Task Update(Enrollments entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
