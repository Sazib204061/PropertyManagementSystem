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
        public bool Status { get; set; }
        bool IsDleted { get; set; }


    }
}
