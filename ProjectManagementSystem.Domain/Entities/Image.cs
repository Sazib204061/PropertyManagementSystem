using ProjectManagementSystem.Domain.Common;

namespace ProjectManagementSystem.Domain.Entities
{
    public class Image : BaseEntity
    {
        public string Path { get; set; } = string.Empty;
        public PropertyDetail? PropertyDetail { get; set; }
        public int PropertyDetailId { get; set; }
    }
}
