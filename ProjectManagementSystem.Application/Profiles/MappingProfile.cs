using AutoMapper;
using ProjectManagementSystem.Application.Cities;
using ProjectManagementSystem.Application.Properties;
using ProjectManagementSystem.Domain.Entities;

namespace ProjectManagementSystem.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<City, CityVM>().ReverseMap();
            CreateMap<Property, PropertyVM>().ReverseMap();

        }

    }
}
