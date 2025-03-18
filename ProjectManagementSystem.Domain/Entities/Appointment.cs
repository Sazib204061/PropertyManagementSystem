using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Domain.Entities
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public Property ? Properties { get; set; }
        public DateTime AppointDate { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string UserEmail { get; set; } = string.Empty;
        public string UserPhone { get; set; } = string.Empty;
        bool IsDleted { get; set; }
        public enum OperationStatus
        {

            Success = 0,
            Inprocess = 1,
            Available = 2

        }

    }
}
