using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ProjectManagementSystem.Application.Repository;
using ProjectManagementSystem.Domain.Entities;

namespace ProjectManagementSystem.Application.Appointments
{
    public class AppointmentService : IAppointmentService
    {
        private readonly IBaseRepository<Appointment> _appointmentRepository;
        private readonly IMapper _mapper;

        public AppointmentService(IBaseRepository<Appointment> appointmentRepository, IMapper mapper)
        {
            _appointmentRepository = appointmentRepository;
            _mapper = mapper;
        }
        public async Task AddAppointmentAsync(AppointmentVM appointment)
        {
            var curruentAppointment = _mapper.Map<Appointment>(appointment);
            await _appointmentRepository.AddAsync(curruentAppointment);
        }

        public async Task DeleteAppointmentAsync(int id)
        {
            var curruentAppointment = await _appointmentRepository.GetByIdAsync(id);
            if (curruentAppointment == null)
            {
                throw new KeyNotFoundException($"Appintment with ID {id} not found.");
            }
            await _appointmentRepository.DeleteAsync(id);
        }

        public async Task<IList<AppointmentVM>> GetAllAppointmentsAsync()
        {
            var appointments = await _appointmentRepository.GetAllAsync();
            return _mapper.Map<IList<AppointmentVM>>(appointments);
        }
        public async Task<AppointmentVM> GetAppointmentByIdAsync(int id)
        {
            var appointment = await _appointmentRepository.GetByIdAsync(id);
            if (appointment == null)
            {
                throw new KeyNotFoundException($"Appointment with ID {id} not found.");
            }
            return _mapper.Map<AppointmentVM>(appointment);
        }
        public async Task UpdateAppointmentAsync(int id, AppointmentVM appointment)
        {
            var existingAppointment = await _appointmentRepository.GetByIdAsync(id);
            if (existingAppointment == null)
            {
                throw new KeyNotFoundException($"Appointment with ID {id} not found.");
            }
            _mapper.Map(appointment, existingAppointment);
            await _appointmentRepository.UpdateAsync(existingAppointment);
        }
    }
}
