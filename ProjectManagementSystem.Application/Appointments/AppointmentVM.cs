using ProjectManagementSystem.Domain.Enums;

namespace ProjectManagementSystem.Application.Appointments
{
    public class AppointmentVM
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserPhone { get; set; }
        public AppointmentStatus AppointmentStatus { get; set; }
    }
}
