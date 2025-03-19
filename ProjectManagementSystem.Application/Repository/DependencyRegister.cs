using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using ProjectManagementSystem.Application.City;
using ProjectManagementSystem.Application.Images;

namespace ProjectManagementSystem.Application.Repository
{
    public static class DependencyRegister
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            //add all services here
            services.AddScoped<ICityService, CityService>();
            services.AddScoped<IImageFileService, ImageFileService>();

            //services.AddAutoMapper(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
