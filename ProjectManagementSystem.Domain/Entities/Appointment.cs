using ProjectManagementSystem.Domain.Common;
using ProjectManagementSystem.Domain.Enums;

namespace ProjectManagementSystem.Domain.Entities
{
    public class Appointment : BaseEntity
    {

        public Property? Property { get; set; }
        public DateTime Date { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string UserEmail { get; set; } = string.Empty;
        public string UserPhone { get; set; } = string.Empty;
        public AppointmentStatus AppointmentStatus { get; set; }

    }
}
