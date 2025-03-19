using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using ProjectManagementSystem.Application.Cities;
using ProjectManagementSystem.Application.Properties;

namespace ProjectManagementSystem.Application.Repository
{
    public static class DependencyRegister
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            //add all services here
            services.AddScoped<IPropertyService, PropertyService>();
            services.AddScoped<ICityService, CityService>();

            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
