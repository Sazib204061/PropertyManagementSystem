using ProjectManagementSystem.Domain.Common;

namespace ProjectManagementSystem.Domain.Entities
{
    public class Zone : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public City? City { get; set; }
        public int CityId { get; set; }
        public ICollection<Property> Properties { get; set; } = [];

    }
}
