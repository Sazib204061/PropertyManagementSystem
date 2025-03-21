using ProjectManagementSystem.Domain.Common;

namespace ProjectManagementSystem.Domain.Entities
{
    public class Owner : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string? ContactNumber { get; set; }
        public string Email { get; set; }
        public ICollection<Property>? Properties { get; set; }

    }
}
