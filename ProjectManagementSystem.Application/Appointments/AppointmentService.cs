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

      
        public async Task AddAppointmentAsync(AppointmentVM appointmentVM)
        {
            var appointmentToCreate = _mapper.Map<Appointment>(appointmentVM);
            await _appointmentRepository.AddAsync(appointmentToCreate);
        }

        public async Task DeleteAppointmentAsync(int id)
        {
            var appointmentToDelete = await _appointmentRepository.GetByIdAsync(id);
            if (appointmentToDelete == null) throw new KeyNotFoundException("Appointment not found.");

            await _appointmentRepository.DeleteAsync(appointmentToDelete);
        }

        public async Task<IList<AppointmentVM>> GetAllAppointmentsAsync()
        {
            var appointments = await _appointmentRepository.GetAllAsync();
            return _mapper.Map<IList<AppointmentVM>>(appointments);
        }

        public async Task<AppointmentVM> GetAppointmentByIdAsync(int id)
        {
            var appointment = await _appointmentRepository.GetByIdAsync(id);
            if (appointment == null) throw new KeyNotFoundException("Appointment not found.");
            return _mapper.Map<AppointmentVM>(appointment);
        }

        public async Task<AppointmentVM> GetAppointmentByNameAsync(string name)
        {
            var appointments = await _appointmentRepository.GetAllAsync(); // Get all records
            var appointment = appointments.FirstOrDefault(a => a.UserName.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (appointment == null)
                throw new KeyNotFoundException("Appointment not found.");

            return _mapper.Map<AppointmentVM>(appointment);
        }


        public async Task UpdateAppointmentAsync(int id, AppointmentVM appointmentVM)
        {
            var existingAppointment = await _appointmentRepository.GetByIdAsync(id);
            if (existingAppointment == null) throw new KeyNotFoundException("Appointment not found.");

            _mapper.Map(appointmentVM, existingAppointment);
            await _appointmentRepository.UpdateAsync(existingAppointment);
        }
    }
}
