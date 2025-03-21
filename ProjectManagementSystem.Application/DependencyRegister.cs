using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using ProjectManagementSystem.Application.Appointments;
using ProjectManagementSystem.Application.Cities;
using ProjectManagementSystem.Application.Images;
using ProjectManagementSystem.Application.Owners;
using ProjectManagementSystem.Application.Properties;
using ProjectManagementSystem.Application.PropertyDetails;
using ProjectManagementSystem.Application.Zones;

namespace ProjectManagementSystem.Application
{
    public static class DependencyRegister
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            //add all services here
            services.AddScoped<ICityService, CityService>();
            services.AddScoped<IImageFileService, ImageFileService>();
            services.AddScoped<IAppointmentService, AppointmentService>();
            services.AddScoped<IPropertyService, PropertyService>();
            services.AddScoped<IPropertyDetailsService, PropertyDetailsService>();
            services.AddScoped<IZoneService, ZoneService>();
            services.AddScoped<IOwnerService, OwnerService>();


            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
