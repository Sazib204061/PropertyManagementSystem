using AutoMapper;
using ProjectManagementSystem.Application.Appointments;
using ProjectManagementSystem.Domain.Entities;

namespace ProjectManagementSystem.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Appointment, AppointmentVM>().ReverseMap();
        }
    }
}
