using Microsoft.Extensions.DependencyInjection;
using PlatVirtual.Application.User.Interfaces;
using PlatVirtual.Application.User.Services;
using PlatVirtual.Application.Career.Interfaces;
using PlatVirtual.Application.Career.Services;
using PlatVirtual.Application.Course.Interfaces;
using PlatVirtual.Application.Course.Services;
using PlatVirtual.Application.Enrollment.Interfaces;
using PlatVirtual.Application.Enrollment.Services;
using PlatVirtual.Application.Grade.Interfaces;
using PlatVirtual.Application.Grade.Services;
using PlatVirtual.Application.Subject.Interfaces;
using PlatVirtual.Application.Subject.Services;
using PlatVirtual.Application.Interfaces;
using PlatVirtual.Application.Helpers;

namespace PlatVirtual.Application
{
    public static class IoC
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            return services
                .AddScoped<IUserServices, UserService>()
                .AddScoped<ICareerService, CareerService>()
                .AddScoped<ICourseService, CourseService>()
                .AddScoped<ISubjectService, SubjectService>()
                .AddScoped<IEnrollmenService, EnrollmentService>()
                .AddScoped<IGradeService, GradeService>()
                .AddScoped<ITokenActions, TokenActions>()
                .AddScoped<IUploadImg, UploadImg>();
        }
    }
}
