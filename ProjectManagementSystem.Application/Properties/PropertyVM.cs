using ProjectManagementSystem.Domain.Enums;

namespace ProjectManagementSystem.Application.Properties
{
    public class PropertyVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public PropertyStatus Status { get; set; }
        public PropertyTypes Types { get; set; }
        public int OwnerId { get; set; }
        public int ZoneId { get; set; }
    }
}
