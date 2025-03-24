using AutoMapper;
using ProjectManagementSystem.Application.Appointments;
using ProjectManagementSystem.Application.Cities;
using ProjectManagementSystem.Application.Zones;
using ProjectManagementSystem.Domain.Entities;

namespace ProjectManagementSystem.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<City, CityVM>().ReverseMap();
            CreateMap<Zone, ZoneVM>().ReverseMap();
        }
    }
}
