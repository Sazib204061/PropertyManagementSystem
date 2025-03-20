using Microsoft.VisualBasic.FileIO;
using ProjectManagementSystem.Domain.Common;
using ProjectManagementSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Domain.Entities
{
    public class Property : BaseEntity
    {
        public string? Name { get; set; }
        public Zone? Zone { get; set; }
        public Owner? Owner { get; set; }
        public  PropertyDetail? PropertyDetails { get; set; }
        
        public PropertyStatus Status { get; set; }
        public string? Type { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
    }
}
