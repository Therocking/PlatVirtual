using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PlatVirtual.Domain.Entities;

namespace PlatVirtual.Infra.Context
{
    public class PlatVirtualContext: DbContext
    {
        public PlatVirtualContext(DbContextOptions<PlatVirtualContext> options): base(options) 
        {
        }

        public DbSet<Roles> Roles { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Careers> Careers { get; set; }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<Subjects> Subjects { get; set; }
        public DbSet<Enrollments> Enrollments { get; set; }
        public DbSet<Grades> Grades { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Grades>()
            .HasOne(g => g.Professor)
            .WithMany()
            .HasForeignKey(g => g.ProfessorId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Grades>()
                .HasOne(g => g.Student)
                .WithMany()
                .HasForeignKey(g => g.StudentId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Users>()
                .HasIndex(e => e.Email)
                .IsUnique();
        }
    }
}
