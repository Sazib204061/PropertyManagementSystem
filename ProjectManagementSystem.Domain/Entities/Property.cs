using ProjectManagementSystem.Domain.Common;
using ProjectManagementSystem.Domain.Enums;

namespace ProjectManagementSystem.Domain.Entities
{
    public class Property : BaseEntity
    {
        public string Name { get; set; }
        public Zone? Zone { get; set; }
        public int ZoneId { get; set; }
        public int OwnerId { get; set; }
        public Owner? Owner { get; set; }
        public PropertyDetail? PropertyDetails { get; set; }
        public PropertyStatus Status { get; set; }
        public PropertyTypes Type { get; set; }
        public ICollection<Appointment> Appointments { get; set; } = [];
    }
}
