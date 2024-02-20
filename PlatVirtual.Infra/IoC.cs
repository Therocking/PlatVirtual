using Microsoft.Extensions.DependencyInjection;
using PlatVirtual.Domain.Entities;
using PlatVirtual.Infra.Repositories.CareersInterfaces;
using PlatVirtual.Infra.Repositories.CareersRepository;
using PlatVirtual.Infra.Repositories.CoursesInterfaces;
using PlatVirtual.Infra.Repositories.CoursesRepository;
using PlatVirtual.Infra.Repositories.EnrollmentsInterfaces;
using PlatVirtual.Infra.Repositories.EnrollmentsRepository;
using PlatVirtual.Infra.Repositories.GradesInterfaces;
using PlatVirtual.Infra.Repositories.GradesRepository;
using PlatVirtual.Infra.Repositories.SubjectsInterfaces;
using PlatVirtual.Infra.Repositories.SubjectsRepository;
using PlatVirtual.Infra.Repositories.UsersInterfaces;
using PlatVirtual.Infra.Repositories.UsersRepository;

namespace PlatVirtual.Infra
{
    public static class IoC
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services) 
        {
            return services
                .AddScoped<IUsersRepository, UsersRepository>()
                .AddScoped<ICareersRepository, CareersRepository>()
                .AddScoped<ICoursesRepository, CoursesRepository>()
                .AddScoped<ISubjectsRepository, SubjectsRepository>()
                .AddScoped<IEnrollmentsRepository, EnrollmentsRepository>()
                .AddScoped<IGradesRepository, GradesRepository>();
        }
    }
}
