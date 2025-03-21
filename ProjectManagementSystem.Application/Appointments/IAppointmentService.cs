namespace ProjectManagementSystem.Application.Appointments
{
    public interface IAppointmentService
    {
        Task<IList<AppointmentVM>> GetAllAppointmentsAsync();
        Task<AppointmentVM> GetAppointmentByIdAsync(int id);
        Task AddAppointmentAsync(AppointmentVM Appointment);
        Task UpdateAppointmentAsync(int id, AppointmentVM Appointment);
        Task DeleteAppointmentAsync(int id);
    }
}
