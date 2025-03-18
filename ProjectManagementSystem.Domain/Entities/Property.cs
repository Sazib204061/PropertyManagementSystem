using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Domain.Entities
{
    public class Property
    {
        public int PropertyId { get; set; }
        public string PropertyName { get; set; }
        public Zone ? Zones { get; set; }
        public Owner Owners { get; set; }
        public  PropertyDetails ? PropertyDetails { get; set; }
        public string ?  Status { get; set; }
        public string? Type { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
    }
}
