using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectManagementSystem.Domain.Common;
using ProjectManagementSystem.Domain.Enums;

namespace ProjectManagementSystem.Domain.Entities
{
    public class Appointment : BaseEntity
    {
        public Property? Property { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string UserEmail { get; set; } = string.Empty;
        public string UserPhone { get; set; } = string.Empty;
        public bool IsDeleted { get; set; }
        public AppointmentStatus Status { get; set; }
    }
}
