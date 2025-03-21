using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectManagementSystem.Domain.Entities;

namespace ProjectManagementSystem.Application.Appointments
{
    public interface IAppointmentService
    {
        Task<IList<AppointmentVM>> GetAllAppointmentsAsync();
        Task AddAppointmentAsync(AppointmentVM Appointment);
        Task UpdateAppointmentAsync(int Id, AppointmentVM Appointment);
        Task DeleteAppointmentAsync(int id);
        Task<AppointmentVM> GetAppointmentByIdAsync(int id);
        Task<AppointmentVM> GetAppointmentByNameAsync(string Name);

    }
}
