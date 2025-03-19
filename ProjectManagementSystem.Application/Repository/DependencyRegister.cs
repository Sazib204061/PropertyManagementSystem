using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using ProjectManagementSystem.Application.Appointment;
using ProjectManagementSystem.Application.City;

namespace ProjectManagementSystem.Application.Repository
{
    public static class DependencyRegister
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            //add all services here
          
            services.AddScoped<ICityService, CityService>();

            services.AddScoped<IAppointmentService, AppointmentService>();

            //services.AddAutoMapper(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
